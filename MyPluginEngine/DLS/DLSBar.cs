using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyPluginEngine;

namespace DLS
{
    public class DLSBar : MyPluginEngine.IMenuDef
    {
        #region IMenuDef 成员

        public string Caption
        {
            get { return "DLS"; }
        }

        public void GetItemInfo(int pos, ItemDef itemDef)
        {
            switch (pos)
            {
                case 0:
                    itemDef.ID = "DLS.DLS";
                    itemDef.Group = false;
                    break;
               
                ////case 1:
                //    //itemDef.ID = "";
                //    //itemDef.Group = true;
                //    break;
                default:
                    break;

            }
        }

        public long ItemCount
        {
            get { return 1; }
        }

        public string Name
        {
            get { return "DLSBar"; }
        }

        #endregion
    }
}
