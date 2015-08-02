using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.Display;
using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.SystemUI;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.ADF;

/**
 * author lk 
 * 2014/12/23
 * 插件式gis应用框架的设计与实现
 * toccontrol 上右键时弹出快捷菜单
 * 
 * */
namespace MyMainGIS.Library
{
    public class MapMenu : ESRI.ArcGIS.ADF.BaseClasses.BaseCommand, ICommandSubType
    {

        private IHookHelper m_hookHelper = new HookHelperClass();
        private long m_subType;

        public MapMenu()
        {
        }

        public override void OnClick()
        {
            switch (m_subType)
            {
                case 1:
                case 2:
                    for (int i = 0; i <= m_hookHelper.FocusMap.LayerCount - 1; i++)
                    {
                        if (m_subType == 1)
                            m_hookHelper.FocusMap.get_Layer(i).Visible = true;
                        if (m_subType == 2)
                            m_hookHelper.FocusMap.get_Layer(i).Visible = false;
                        if (m_subType == 3)
                        {
                            ILegendGroup pLengendGroup;
                            ILegendInfo pLengendInfo = m_hookHelper.FocusMap.get_Layer(i) as ILegendInfo;
                            for (int j = 0; j < pLengendInfo.LegendGroupCount; j++)
                            {
                                pLengendGroup = pLengendInfo.get_LegendGroup(j);
                                pLengendGroup.Visible = true;
                            }
                        }
                        if (m_subType == 4)
                        {
                            ILegendGroup pLengendGroup;
                            ILegendInfo pLengendInfo = m_hookHelper.FocusMap.get_Layer(i) as ILegendInfo;
                            for (int j = 0; j < pLengendInfo.LegendGroupCount; j++)
                            {
                                pLengendGroup = pLengendInfo.get_LegendGroup(j);
                                pLengendGroup.Visible = false;
                            }
                        }
                    }
                    m_hookHelper.ActiveView.PartialRefresh(esriViewDrawPhase.esriViewGeography, null, null);
                    break;
                default:
                    break;
            }
        }

        public override void OnCreate(object hook)
        {
            m_hookHelper.Hook = hook;
        }

        #region ICommandSubType 成员

        public int GetCount()
        {
            return 4;
        }

        public void SetSubType(int SubType)
        {
            m_subType = SubType;
        }

        #endregion

        public override string Caption
        {
            get
            {
                switch (m_subType)
                {
                    case 1:
                        return "显示所有图层";
                    case 2:
                        return "关闭所有图层";
                    case 3:
                        return "展开所有图层";
                    case 4:
                        return "折叠所有图层";
                    default:
                        return "";
                }
            }
        }

        public override bool Enabled
        {
            get
            {
                bool enabled = false;
                int i;
                switch (m_subType)
                {
                    case 1:
                        for (i = 0; i <= m_hookHelper.FocusMap.LayerCount - 1; i++)
                        {
                            if (m_hookHelper.ActiveView.FocusMap.get_Layer(i).Visible == false)
                            {
                                enabled = true;
                                break;
                            }
                        }
                        break;
                    case 2:
                        for (i = 0; i <= m_hookHelper.FocusMap.LayerCount - 1; i++)
                        {
                            if (m_hookHelper.ActiveView.FocusMap.get_Layer(i).Visible == true)
                            {
                                enabled = true;
                                break;
                            }
                        }
                        break;
                    case 3:
                        for (i = 0; i <= m_hookHelper.FocusMap.LayerCount - 1; i++)
                        {
                            ILegendGroup pLengendGroup;
                            ILegendInfo pLengendInfo = m_hookHelper.FocusMap.get_Layer(i) as ILegendInfo;
                            for (int j = 0; j < pLengendInfo.LegendGroupCount; j++)
                            {
                                pLengendGroup = pLengendInfo.get_LegendGroup(j);
                                if (pLengendGroup.Visible == false)
                                {
                                    enabled = true;
                                    break;
                                }
                            }
                        }
                        break;
                    case 4:
                        for (i = 0; i <= m_hookHelper.FocusMap.LayerCount - 1; i++)
                        {
                            ILegendGroup pLengendGroup;
                            ILegendInfo pLengendInfo = m_hookHelper.FocusMap.get_Layer(i) as ILegendInfo;
                            for (int j = 0; j < pLengendInfo.LegendGroupCount; j++)
                            {
                                pLengendGroup = pLengendInfo.get_LegendGroup(j);
                                if (pLengendGroup.Visible == true)
                                {
                                    enabled = true;
                                    break;
                                }
                            }
                        }
                        break;
                    default:
                        break;
                }
                return enabled;
            }
        }
    }
}
