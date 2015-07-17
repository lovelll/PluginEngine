using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyPluginEngine;

namespace dataPreMenuBar
{
    public class dataPreMenuBar : MyPluginEngine.IMenuDef
    {
        #region IMenuDef 成员

        public string Caption
        {
            get { return "数据预处理"; }
        }

        public void GetItemInfo(int pos, ItemDef itemDef)
        {
            switch (pos)
            {
                case 0:
                    itemDef.ID = "dataPreMenuBar.cAddData";
                    itemDef.Group = false;
                    break;
                case 1:
                    itemDef.ID = "dataPreMenuBar.cIdentify";
                    itemDef.Group = false;
                    break;
                case 2:
                    itemDef.ID = "dataPreMenuBar.selectByAttr";
                    itemDef.Group = false;
                    break;
                case 3:
                    itemDef.ID = "dataPreMenuBar.featureRender";
                    itemDef.Group = false;
                    break;

                case 4:
                    itemDef.ID = "dataPreMenuBar.pointPicMarker";
                    itemDef.Group = false;
                    break;
                default:
                    break;

            }
        }

        public long ItemCount
        {
            get { return 5; }
        }

        public string Name
        {
            get { return "dataPreMenuBar"; }
        }

        #endregion
    }
}
