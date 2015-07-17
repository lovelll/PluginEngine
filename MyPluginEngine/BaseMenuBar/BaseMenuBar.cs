using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyPluginEngine;

namespace BaseMenuBar
{
    public class BaseMenuBar : MyPluginEngine.IMenuDef
    {
        #region IMenuDef 成员

        public string Caption
        {
            get { return "基础操作"; }
        }

        public void GetItemInfo(int pos, ItemDef itemDef)
        {
            switch (pos)
            {
                case 0:
                    itemDef.ID = "BaseMenuBar.cAddData";
                    itemDef.Group = false;
                    break;
                case 1:
                    itemDef.ID = "BaseMenuBar.cIdentify";
                    itemDef.Group = false;
                    break;
                case 2:
                    itemDef.ID = "BaseMenuBar.selectByAttr";
                    itemDef.Group = false;
                    break;
                case 3:
                    itemDef.ID = "BaseMenuBar.featureRender";
                    itemDef.Group = false;
                    break;

                case 4:
                    itemDef.ID = "BaseMenuBar.pointPicMarker";
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
            get { return "BaseMenuBar"; }
        }

        #endregion
    }
}
