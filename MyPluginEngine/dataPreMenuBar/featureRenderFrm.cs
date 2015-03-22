using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Controls;

namespace dataPreMenuBar
{
    public partial class featureRenderFrm : DevComponents.DotNetBar.Office2007Form
    {
        public featureRenderFrm(IMapControlDefault mapControl)
        {
            InitializeComponent();
        }
    }
}
