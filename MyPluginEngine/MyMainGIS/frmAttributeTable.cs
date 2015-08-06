﻿using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.Display;
using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Geometry;
using MyMainGIS.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyMainGIS
{
    public partial class frmAttributeTable : Form
    {
        private ILayer m_layer;
        private MapControl m_MapControl;
        System.Data.DataTable pDataTable = new System.Data.DataTable();
        public frmAttributeTable(ILayer layer,MapControl pMapControl)
        {
            InitializeComponent();
            this.m_layer = layer;
            this.m_MapControl = pMapControl;
        }

        private void frmAttributeTable_Load(object sender, EventArgs e)
        {
            string sLayerName = LayerDataTable.getValidFeatureClassName(this.m_layer.Name);
            pDataTable = LayerDataTable.CreateDataTable(this.m_layer, sLayerName);

            BindingSource bs = new BindingSource();
            dataGridView.DataSource = bs;
            bs.DataSource = pDataTable;
            bindingNavigator1.BindingSource=bs;
        }

        //private void dataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        //{
        //    if (e.RowIndex != -1)
        //    {
        //        IFeature pFeat = null;
        //        try
        //        {
        //            IFeatureClass pFeatCls = (m_MapControl.CustomProperty as IFeatureLayer).FeatureClass;
        //            pFeat = pFeatCls.GetFeature(Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[0].Value));
        //        }
        //        catch (Exception ex )
        //        {
        //            pFeat = null;
        //        }
        //        if (pFeat != null)
        //        {
        //            if (pFeat.Shape.GeometryType == ESRI.ArcGIS.Geometry.esriGeometryType.esriGeometryPoint)
        //            {
        //                m_MapControl.CenterAt((IPoint)pFeat.Shape);
        //            }
        //            else
        //            {
        //                IEnvelope pEnv = pFeat.Shape.Envelope;
        //                pEnv.Expand(5,5,true);
        //                m_MapControl.ActiveView.Extent = pEnv;
        //            }
        //            m_MapControl.ActiveView.Refresh();
        //            m_MapControl.ActiveView.ScreenDisplay.UpdateWindow();
        //            switch (pFeat.Shape.GeometryType)
        //            { 
        //                case esriGeometryType.esriGeometryPoint:
        //                    FlashFeature.FlashPoint(m_MapControl,m_MapControl.ActiveView.ScreenDisplay,pFeat.Shape);
        //                    break;
        //                case esriGeometryType.esriGeometryPolyline:
        //                    FlashFeature.FlashLine(m_MapControl, m_MapControl.ActiveView.ScreenDisplay, pFeat.Shape);
        //                    break;
        //                case esriGeometryType.esriGeometryPolygon:
        //                    FlashFeature.FlashPoint(m_MapControl, m_MapControl.ActiveView.ScreenDisplay, pFeat.Shape);
        //                    break;
        //                default:
        //                    break;
        //            }
        //            m_MapControl.ActiveView.PartialRefresh(esriViewDrawPhase.esriViewGeoSelection,null,null);
        //            m_MapControl.ActiveView.PartialRefresh(esriViewDrawPhase.esriViewGeography, null, null);
        //        }

        //    }
        //}


        /// <summary>
        /// 构造查询条件
        /// </summary>
        /// <param name="where"></param>
        public void FilterLayer(string where)
        {
            IFeatureLayer flyr = m_layer as IFeatureLayer;
            IFeatureClass fcls = flyr.FeatureClass;

            IQueryFilter queryFilter = new QueryFilterClass();
            queryFilter.WhereClause = where;

            // 缩放到选择结果集，并高亮显示 
            ZoomToSelectedFeature(flyr, queryFilter);

            //闪烁选中得图斑 
            IFeatureCursor featureCursor = fcls.Search(queryFilter, true);
            FlashPolygons(featureCursor);
        }
        /// <summary>
        /// 缩放到图层，并高亮显示
        /// </summary>
        /// <param name="pFeatureLyr"></param>
        /// <param name="pQueryFilter"></param>
        private void ZoomToSelectedFeature(IFeatureLayer pFeatureLyr, IQueryFilter pQueryFilter)
        {
            #region 高亮显示查询到的要素集合

            //符号边线颜色 
            IRgbColor pLineColor = new RgbColor();
            pLineColor.Red = 0;
            pLineColor.Green = 255;
            pLineColor.Blue = 255;
            ILineSymbol ilSymbl = new SimpleLineSymbolClass();
            ilSymbl.Color = pLineColor;
            ilSymbl.Width = 3;

            //定义选中要素的符号为红色 
            ISimpleFillSymbol ipSimpleFillSymbol = new SimpleFillSymbol();
            ipSimpleFillSymbol.Outline = ilSymbl;
            RgbColor pFillColor = new RgbColor();
            pFillColor.Green = 60;
            ipSimpleFillSymbol.Color = pFillColor;
            //ipSimpleFillSymbol.Style = esriSimpleFillStyle.esriSFSForwardDiagonal;
            ipSimpleFillSymbol.Style = esriSimpleFillStyle.esriSFSNull;

            //选取要素集 
            IFeatureSelection pFtSelection = pFeatureLyr as IFeatureSelection;
            pFtSelection.SetSelectionSymbol = true;
            pFtSelection.SelectionSymbol = (ISymbol)ipSimpleFillSymbol;
            pFtSelection.SelectFeatures(pQueryFilter, esriSelectionResultEnum.esriSelectionResultNew, false);

            #endregion
            m_MapControl.ActiveView.Refresh();
        }
        /// <summary>
        /// 闪烁选中图斑
        /// </summary>
        /// <param name="featureCursor"></param>
        private void FlashPolygons(IFeatureCursor featureCursor)
        {
            IArray geoArray = new ArrayClass();
            IFeature feature = null;
            while ((feature = featureCursor.NextFeature()) != null)
            {
                //feature是循环外指针，所以必须用ShapeCopy 
                geoArray.Add(feature.ShapeCopy);
            }

            //通过IHookActions闪烁要素集合 
            HookHelperClass m_pHookHelper = new HookHelperClass();
            m_pHookHelper.Hook = m_MapControl.Object;
            IHookActions hookActions = (IHookActions)m_pHookHelper;

            hookActions.DoActionOnMultiple(geoArray, esriHookActions.esriHookActionsPan);

            System.Windows.Forms.Application.DoEvents();
            m_pHookHelper.ActiveView.ScreenDisplay.UpdateWindow();

            hookActions.DoActionOnMultiple(geoArray, esriHookActions.esriHookActionsFlash);
            System.Windows.Forms.Application.DoEvents();
            m_pHookHelper.ActiveView.ScreenDisplay.UpdateWindow();

        }

        private void dataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView.SelectedRows[0].Cells[0].Value.ToString() != "")
            {
                long strflag = Convert.ToInt64(dataGridView.SelectedRows[0].Cells[0].Value.ToString());
                string filename = pDataTable.Columns[0].ToString();

                if (filename == "FID")
                {

                    FilterLayer("FID=" + strflag + "");
                }
                else
                {


                    FilterLayer("OBJECTID=" + strflag + "");
                }
            }

        }
    }
}
