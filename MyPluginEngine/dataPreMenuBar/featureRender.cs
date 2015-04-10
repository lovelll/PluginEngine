using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

using ESRI.ArcGIS.ADF;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.esriSystem;

namespace dataPreMenuBar
{
    class featureRender : MyPluginEngine.ICommand
    {
        private MyPluginEngine.IApplication hk;
        private System.Drawing.Bitmap m_hBitmap;

        //private ESRI.ArcGIS.SystemUI.ICommand cmd = null;
        private IMapControlDefault _MapControl;
        private ITOCControlDefault _TOCControl;
        public featureRender()
        {
            string str = @"..\Data\Image\MainTools\featureRender.png";
            if (System.IO.File.Exists(str))
                m_hBitmap = new Bitmap(str);
            else
                m_hBitmap = null;
        }

        #region ICommand 成员

        public System.Drawing.Bitmap Bitmap
        {
            get { return m_hBitmap; }
        }

        public string Caption
        {
            get { return "专题制图"; }
        }

        public string Category
        {
            get { return "处理"; }
        }

        public bool Checked
        {
            get { return false; }
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
            get { return "专题制图"; }
        }

        public string Name
        {
            get { return "featureRender"; }
        }

        public void OnClick()
        {
            //cmd.OnClick();
            featureRenderFrm form = new featureRenderFrm(_MapControl, _TOCControl);
            form.Show();
        }

        public void OnCreate(MyPluginEngine.IApplication hook)
        {
            if (hook != null)
            {
                this.hk = hook;
                //cmd = new ControlsAddDataCommandClass();
                //cmd.OnCreate(this.hk.MapControl);
                _MapControl = this.hk.MapControl;
                _TOCControl = this.hk.TOCControl;
            }
        }

        public string Tooltip
        {
            get { return "专题制图"; }
        }

        #endregion
    }
}
