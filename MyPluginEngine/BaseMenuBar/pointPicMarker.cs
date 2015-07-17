using System;
using System.Drawing;
using System.Collections.Generic;
using System.Text;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Display;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.SystemUI;
using MyPluginEngine;

using System.Windows.Forms;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.DataSourcesFile;

/**
 * author lk 
 * 2015/4/23
 * 
 * 1.从文件夹中加载点数据，
 * 2.使用空间查询，查询鼠标点击point "重叠"的points,
 *   将第一个进行pictureMarkerSymbol
 * 
 **/
namespace BaseMenuBar
{
    public class pointPicMarker : MyPluginEngine.ITool
    {
        private MyPluginEngine.IApplication hk;
        private System.Drawing.Bitmap m_hBitmap;
        //private IActiveView pActiveView;
        private IMapControlDefault pMapControl;
        
        // points
        private IFeatureLayer pFeatureLayer;
        // picture and points file path
        string pictureFilePath;

        public pointPicMarker()
        {
            string str = @"..\Data\Image\MainTools\picture.png";
            if (System.IO.File.Exists(str))
                m_hBitmap = new Bitmap(str);
            else
                m_hBitmap = null;
        }


        #region ITool 成员

        public Bitmap Bitmap
        {
            get { return m_hBitmap; }
        }

        public string Caption
        {
            get { return "图片"; }
        }

        public string Category
        {
            get { return "MainTool"; }
        }

        public bool Checked
        {
            get { return false; }
        }

        public int Cursor
        {
            get { return (int)ESRI.ArcGIS.Controls.esriControlsMousePointer.esriPointerIdentify; }
        }

        public bool Deactivate()
        {
            return false;
        }

        public bool Enabled
        {
            get { return true; }
        }

        public int HelpContextId
        {
            get { return 0; }
        }

        public string HelpFile
        {
            get { return ""; }
        }

        public string Message
        {
            get { return "图片"; }
        }

        public string Name
        {
            get { return "Picture"; }
        }

        public void OnClick()
        {   //获取当前路径 文件名
            OpenFileDialog openFileD = new OpenFileDialog();
            openFileD.Filter = "Shape(*.shp)|*.shp|All Files(*.*)|*.*";
            openFileD.Title = "Open Shapefile data";
            openFileD.ShowDialog();
            string strFullPath = openFileD.FileName;

            int nameIndex = strFullPath.LastIndexOf("\\");
            pictureFilePath = strFullPath.Substring(0, nameIndex);
            string fileName = strFullPath.Substring(nameIndex + 1);

            // 打开points文件
            IWorkspaceFactory pWorkspaceF = new ShapefileWorkspaceFactoryClass();
            IFeatureWorkspace pFeatureW = (IFeatureWorkspace)pWorkspaceF.OpenFromFile(pictureFilePath,0);

            pFeatureLayer = new FeatureLayerClass();
            pFeatureLayer.FeatureClass = pFeatureW.OpenFeatureClass(fileName);
            pFeatureLayer.Name = pFeatureLayer.FeatureClass.AliasName;
            this.pMapControl.Map.AddLayer(pFeatureLayer);
            this.pMapControl.ActiveView.Refresh();

        }

        public bool OnContextMenu(int x, int y)
        {
            return false;
        }

        public void OnCreate(IApplication hook)
        {
            if (hook != null)
            {
                this.hk = hook;
                pMapControl = this.hk.MapControl;
            }
        }

        public void OnDblClick()
        {
        }

        public void OnKeyDown(int keyCode, int shift)
        {
        }

        public void OnKeyUp(int keyCode, int shift)
        {
        }

        public void OnMouseDown(int button, int shift, int x, int y)
        {
            //1 鼠标点击point 进行buffer 
            //2 然后进行 空间过滤 spatialFilter 得到一个picturePoint
            //3 picturePoint 进行pictureMarkerSymbol
            if (button == 1)
            {
                IPoint mousePoint = this.pMapControl.ActiveView.ScreenDisplay.DisplayTransformation.ToMapPoint(x,y);
                //mousePoint.SpatialReference = this.pMapControl.Map.SpatialReference;

                //buffer
                double length =  ConvertPixelsToMapUnits(this.pMapControl.ActiveView, 6);
                ITopologicalOperator topo = mousePoint as ITopologicalOperator;
                IGeometry pGeo = topo.Buffer(length);
                //设置点击点的位置       
                IEnvelope pEnv = this.pMapControl.TrackRectangle();

                // 空间过滤
                ISpatialFilter pFilter = new SpatialFilter();
                // pFilter.Geometry = pGeo;
                pFilter.Geometry = pEnv;
                pFilter.GeometryField = pFeatureLayer.FeatureClass.ShapeFieldName;
                pFilter.SpatialRel = esriSpatialRelEnum.esriSpatialRelContains;
                
                //search
                IFeatureCursor pFeatureCursor = pFeatureLayer.FeatureClass.Search(pFilter,false);
                //select
                //IFeatureSelection featureS = pFeatureLayer as IFeatureSelection;
                //featureS.SelectFeatures(pFilter, esriSelectionResultEnum.esriSelectionResultNew, true);
                //ISelectionSet selectSet = featureS.SelectionSet;
                //ICursor pCursor;
                //selectSet.Search(null, true, out pCursor);
                //IFeatureCursor pFeatureCursor = pCursor as IFeatureCursor;
                IFeature picturePoint = pFeatureCursor.NextFeature();
                //int total = 0;
                //while (picturePoint != null)
                //{
                //    total++;
                //    picturePoint = pFeatureCursor.NextFeature();
                //}
                if (picturePoint != null)
                {
                    string value = picturePoint.get_Value(picturePoint.Fields.FindField("Name")).ToString();
                    int NameIndex = value.IndexOf("_");
                    string pictureName = value.Substring(NameIndex + 1);
                    string pFile = pictureFilePath + "\\" + pictureName;


                    IMarkerElement pMarkerElement = new MarkerElementClass();
                    IPictureMarkerSymbol pictureM = createPicterM(pFile);
                    IElement pEle;
                    pMarkerElement.Symbol = pictureM;
                    pEle = pMarkerElement as IElement;
                    pEle.Geometry = picturePoint.Shape;
                    IGraphicsContainer pGraphicsContainer = this.pMapControl.Map as IGraphicsContainer;
                    pGraphicsContainer.AddElement(pEle, 0);
                    this.pMapControl.ActiveView.PartialRefresh(esriViewDrawPhase.esriViewGraphics, null, null);

                }
            }

        }
        public IPictureMarkerSymbol createPicterM(string pictureFile)
        {
            if (pictureFile == null) return null;
            IRgbColor rgb = new RgbColorClass();
            rgb.Red = 255;
            rgb.Green = 255;
            rgb.Blue = 255;
            //esriIPictureType pt = new esriIPictureType();
            //pt = esriIPictureBitmap;

            IPictureMarkerSymbol pictureM = new PictureMarkerSymbolClass();
            pictureM.CreateMarkerSymbolFromFile(esriIPictureType.esriIPictureBitmap, pictureFile);
            pictureM.Angle = 0;
            pictureM.BitmapTransparencyColor = rgb;
            pictureM.Size = 100;
            pictureM.XOffset = 0;
            pictureM.YOffset = 0;

            return pictureM;

        }

        private double ConvertPixelsToMapUnits(IActiveView pActiveView, double pixelUnits)
        {
            // Uses the ratio of the size of the map in pixels to map units to do the conversion
            IPoint p1 = pActiveView.ScreenDisplay.DisplayTransformation.VisibleBounds.UpperLeft;
            IPoint p2 = pActiveView.ScreenDisplay.DisplayTransformation.VisibleBounds.UpperRight;
            int x1, x2, y1, y2;
            pActiveView.ScreenDisplay.DisplayTransformation.FromMapPoint(p1, out x1, out y1);
            pActiveView.ScreenDisplay.DisplayTransformation.FromMapPoint(p2, out x2, out y2);
            double pixelExtent = x2 - x1;
            double realWorldDisplayExtent = pActiveView.ScreenDisplay.DisplayTransformation.VisibleBounds.Width;
            double sizeOfOnePixel = realWorldDisplayExtent / pixelExtent;
            return pixelUnits * sizeOfOnePixel;
        }

        public void OnMouseMove(int button, int shift, int x, int y)
        {
        }

        public void OnMouseUp(int button, int shift, int x, int y)
        {
        }

        public void Refresh(int hDC)
        {
        }

        public string Tooltip
        {
            get { return "图片"; }
        }

        #endregion
    }
}
