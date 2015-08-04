using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Controls;
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
        private AxMapControl m_MapControl;
        public frmAttributeTable(ILayer layer,AxMapControl pMapControl)
        {
            InitializeComponent();
            this.m_layer = layer;
            this.m_MapControl = pMapControl;
        }

        private void frmAttributeTable_Load(object sender, EventArgs e)
        {
            string sLayerName = LayerDataTable.getValidFeatureClassName(this.m_layer.Name);
            System.Data.DataTable pDataTable = LayerDataTable.CreateDataTable(this.m_layer, sLayerName);

            BindingSource bs = new BindingSource();
            dataGridView.DataSource = bs;
            bs.DataSource = pDataTable;
            bindingNavigator1.BindingSource=bs;
        }

        private void dataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                IFeature pFeat = null;
                try
                {
                    IFeatureClass pFeatCls = (m_MapControl.CustomProperty as IFeatureLayer).FeatureClass;
                    pFeat = pFeatCls.GetFeature(Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[0].Value));
                }
                catch (Exception ex )
                {
                    pFeat = null;
                }
                if (pFeat != null)
                {
                    if (pFeat.Shape.GeometryType == ESRI.ArcGIS.Geometry.esriGeometryType.esriGeometryPoint)
                    {
                        m_MapControl.CenterAt((IPoint)pFeat.Shape);
                    }
                    else
                    { 
                    
                    }
                }

            }
        }

    }
}
