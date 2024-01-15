using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using SuperMapLib;//添加引用

namespace GetStart
{
    public partial class MainForm : Form
    {
        int nMeasureMode = 0; //0代表无量算，1长度，2角度，3面积

        public MainForm()
        {
            InitializeComponent();
        }

        private void ConnectSuperMap()
        {
            //关联SuperMap，SuperWorkspaceManager控件
            object objWSHandle = this.axSuperWorkspace1.CtlHandle;
            this.axSuperMap1.Connect(objWSHandle);
            
            //将工作空间管理器控件与工作空间控件进行关联
            this.axSuperWkspManager1.Connect(objWSHandle);
           
            //将图例控件与地图控件进行关联
            object objSMHandle = this.axSuperMap1.CtlHandle;
            axSuperLegend1.Connect(objSMHandle);

            ReleaseObjects(objWSHandle);
            ReleaseObjects(objSMHandle);
        }

        private void ReleaseObjects(object superObject)
        {
            //释放对象
            if (superObject != null)
            {
                Marshal.ReleaseComObject(superObject);
                superObject = null;
            }
        }
        
        private void ControlState(seAction MapAction)
        {
            //设置工具栏和菜单的状态
            toolStripBtnPointSel.Checked = false;
            toolStripPointSel.Checked = false;
            toolStripBtnZoomOut.Checked = false;
            toolStripZoomOut.Checked = false;
            toolStripBtnZoomIn.Checked = false;
            toolStripZoomIn.Checked = false;
            toolStripBtnAutoZoom.Checked = false;
            toolStripAutoZoom.Checked = false;
            toolStripBtnPan.Checked = false;
            toolStripPan.Checked = false;

            mnuMeasureDistance.Checked = false;
            mnuMeasureArea.Checked = false;
            mnuMeasureAngle.Checked = false;

            if (MapAction == SuperMapLib.seAction.scaSelect)
            {
                toolStripBtnPointSel.Checked = true;
                toolStripPointSel.Checked = true;
            }
            else if (MapAction == SuperMapLib.seAction.scaZoomOut)
            {
                toolStripBtnZoomOut.Checked = true;
                toolStripZoomOut.Checked = true;
            }
            else if (MapAction == SuperMapLib.seAction.scaZoomIn)
            {
                toolStripBtnZoomIn.Checked = true;
                toolStripZoomIn.Checked = true;
            }
            else if (MapAction == SuperMapLib.seAction.scaZoomFree)
            {
                toolStripBtnAutoZoom.Checked = true;
                toolStripAutoZoom.Checked = true;
            }
            else if (MapAction == SuperMapLib.seAction.scaPan)
            {
                toolStripBtnPan.Checked = true;
                toolStripPan.Checked = true;
            }
            else if (MapAction == SuperMapLib.seAction.scaTrackPolyline && nMeasureMode == 1)//长度量算
            {
                mnuMeasureDistance.Checked = true;
                toolStripMeasureDis.Checked = true;
            }
            else if (MapAction == SuperMapLib.seAction.scaTrackPolyline && nMeasureMode == 3)//面积量算
            {
                mnuMeasureArea.Checked = true;
                toolStripMeasureArea.Checked = true;
            }
            else if (MapAction == SuperMapLib.seAction.scaTrackPolyline && nMeasureMode == 2)//角度量算
            {
                mnuMeasureAngle.Checked = true;
                toolStripMeasureAngle.Checked = true;
            }
        }

        private void ToolStripOpenWS_Click(object sender, EventArgs e)
        {
            bool blnOpen = false;
            string strOpenPath = string.Empty;
            this.openFileDialog1.Title = "打开工作空间";//对话框的标题
            this.openFileDialog1.FileName = ""; 
            this.openFileDialog1.Filter = "工作空间(.smw)|*.smw";//设置对话框打开文件的类型
            this.openFileDialog1.InitialDirectory = "..\\..\\..\\Data\\";//对话框打开时的初始文件路径
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)//显示对话框
            {
                strOpenPath = this.openFileDialog1.FileName;//打开对话框中选择的文件全路径，即将要打开的工作空间全路径
                this.ConnectSuperMap();//关联控件

                blnOpen = this.axSuperWorkspace1.Open(strOpenPath, "");//打开工作空间
                if (!blnOpen)
                {
                    MessageBox.Show("打开工作空间失败");
                    return;
                }
                else
                {
                    //设置选中面对象的风格
                    soSelection objSelection = axSuperMap1.selection;//获得选择集
                    soStyle objStyle = objSelection.Style; //选择集风格
                    objStyle.BrushStyle = 0; //填充风格，取值为填充库中的编码
                    objStyle.PenStyle = 0; //线型，取值为线型的编码
                    objStyle.BrushColor = System.Convert.ToUInt32(System.Drawing.ColorTranslator.ToOle(Color.FromArgb(255, 190, 189))); //填充颜色
                    objStyle.PenColor = System.Convert.ToUInt32(System.Drawing.ColorTranslator.ToOle(Color.FromArgb(0, 0, 255)));//线颜色
                    
                    ReleaseObjects(objStyle);
                    ReleaseObjects(objSelection);
                    //刷新工作空间管理器，将打开的工作空间可视化在工作空间管理器中
                    this.axSuperWkspManager1.Refresh();
                }
            }
            else
            {
                return;
            }

        }

        private void ToolStripCloseWS_Click(object sender, EventArgs e)
        {
            //关闭工作空间
            axSuperWkspManager1.Disconnect();
            axSuperLegend1.Disconnect();
            axSuperMap1.Disconnect();
            axSuperMap1.Close();
            axSuperWorkspace1.Close();
            axSuperMap1.Refresh();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //退出系统时断开所有连接
            axSuperWkspManager1.Disconnect();
            axSuperLegend1.Disconnect();
            axSuperMap1.Disconnect();
            axSuperMap1.Close();
            axSuperWorkspace1.Close();
            axSuperMap1.Refresh();
        }

        private void toolStripPointSel_Click(object sender, EventArgs e)
        {//点选
             axSuperMap1.Action = SuperMapLib.seAction.scaSelect;
             ControlState(seAction.scaSelect);//设置菜单项的状态
        }

        private void toolStripZoomIn_Click(object sender, EventArgs e)
        {//放大
            axSuperMap1.Action = SuperMapLib.seAction.scaZoomIn;
            ControlState(seAction.scaZoomIn);//设置菜单项的状态
        }

        private void toolStripZoomOut_Click(object sender, EventArgs e)
        {//缩小
            axSuperMap1.Action = SuperMapLib.seAction.scaZoomOut;
            ControlState(seAction.scaZoomOut);//设置菜单项的状态
        }

        private void toolStripAutoZoom_Click(object sender, EventArgs e)
        {//自由缩放
            axSuperMap1.Action = SuperMapLib.seAction.scaZoomFree;
            ControlState(seAction.scaZoomFree);//设置菜单项的状态
        }

        private void toolStripPan_Click(object sender, EventArgs e)
        {//平移
            axSuperMap1.Action = SuperMapLib.seAction.scaPan;
            ControlState(seAction.scaPan);//设置菜单项的状态
        }

        private void toolStripViewEntire_Click(object sender, EventArgs e)
        {//全幅显示
            axSuperMap1.ViewEntire();
            axSuperMap1.Refresh();
        }

        private void ToolStripExit(object sender, EventArgs e)
        {
            //退出系统
            this.Close();
        }

        //在工作空间管理器窗口中双击
        private void axSuperWkspManager1_LDbClick(object sender, AxSuperWkspManagerLib._DSuperWkspManagerEvents_LDbClickEvent e)
        {
            switch (e.nFlag)
            {
                case SuperMapLib.seSelectedItemFlag.scsDataset: //如果是在数据集名称上面双击鼠标左键
                    {
                        //当双击节点类型为数据集时，将数据集添加到地图窗口
                        soDataSources objDss = this.axSuperWorkspace1.Datasources;//获得工作空间下的数据源集合
                        soDataSource objDs = objDss[e.strParent];//通过当前选中数据集的父节点获得数据集所在的数据源
                        soDatasets objDts = objDs.Datasets;//获得该数据源下的数据集集合
                        soDataset objDt = objDts[e.strSelected];//通过当前选中数据集的名称获得该数据集
                        soLayers objLys = axSuperMap1.Layers; //获得地图窗口的图层集合

                        soLayer objLy = objLys.AddDataset(objDt, true);//添加指定数据集到地图窗口中
                        this.axSuperMap1.ViewEntire(); //地图窗口全幅显示
                        axSuperMap1.Refresh(); //刷新地图窗口
                        axSuperLegend1.Refresh();//刷新图例窗口，这样在图例中可以看到刚刚添加的图层

                        ReleaseObjects(objLy);//释放变量
                        ReleaseObjects(objLys);
                        ReleaseObjects(objDt);
                        ReleaseObjects(objDs);
                        ReleaseObjects(objDts);
                        ReleaseObjects(objDss);
                        break;
                    }
                case SuperMapLib.seSelectedItemFlag.scsMap:
                     {
                         //当双击节点类型为地图时，在地图窗口中显示当前地图
                         bool bResult;
                         soLayers objLys2 = axSuperMap1.Layers;
                         objLys2.RemoveAll();//移除地图窗口的所有图层
                         bResult = axSuperMap1.OpenMap(e.strSelected);//打开地图

                         axSuperMap1.ViewEntire();
                         axSuperMap1.Refresh();
                         axSuperLegend1.Refresh();
                         ReleaseObjects(objLys2);
                         break;
                     }
                 case SuperMapLib.seSelectedItemFlag.scsSymbolLib:
                     {//当双击对象为点符号时，显示点符号编辑器
                         soResources objResources = this.axSuperWorkspace1.Resources;
                         soSymbolLib objSymbolLib = objResources.SymbolLib;
                         objSymbolLib.ShowEditor();
                         ReleaseObjects(objSymbolLib);
                         ReleaseObjects(objResources);
                         break;
                     }
                 case SuperMapLib.seSelectedItemFlag.scsLineStyleLib:
                     {//当双击对象为线符号时，显示线符号编辑器
                         soResources objResources = this.axSuperWorkspace1.Resources;
                         soLineStyleLib objLineStyleLib = objResources.LineStyleLib;
                         objLineStyleLib.ShowEditor();
                         ReleaseObjects(objLineStyleLib);
                         ReleaseObjects(objResources);
                         break;
                     }
                 case SuperMapLib.seSelectedItemFlag.scsFillStyleLib:
                     {//当双击对象为填充符号时，显示填充符号编辑器
                         soResources objResources = this.axSuperWorkspace1.Resources;
                         soFillStyleLib objFillLib = objResources.FillStyleLib;
                         objFillLib.ShowEditor();
                         ReleaseObjects(objFillLib);
                         ReleaseObjects(objResources);
                         break;
                     }
             }
        }

        private void axSuperMap1_DblClick(object sender, EventArgs e)
        {
            //双击对话框显示对象属性
            soSelection objSelection = this.axSuperMap1.selection;  //获得选择集;
            soRecordset objRd=objSelection.ToRecordset(false);    //将选择集转化为记录集;
            if (objRd.RecordCount > 0) //如果当前有选中的对象
            {
                string str = "";
                for (int i = 1; i <= objRd.FieldCount; i++)//提取所选对象的属性字段信息
                {
                    str += objRd.GetFieldInfo(i).Name; //得到属性字段名称                                                                 
                    str += ":" + objRd.GetFieldValue(i).ToString() + "\n"; //得到每个字段值                                                   
                }
                MessageBox.Show(str, "属性");//弹出一个窗体显示选中对象的所有属性字段值
            }
            objRd.Close(); //关闭记录集

            ReleaseObjects(objSelection);
            ReleaseObjects(objRd);
        }

        private void axSuperMap1_MouseWheelEvent(object sender, AxSuperMapLib._DSuperMapEvents_MouseWheelEvent e)
        {
            if (e.zDelta > 0)//当滚轮向上滚动时表示地图放大
            {
                axSuperMap1.Zoom(2);
                axSuperMap1.Refresh();
            }
            else if(e.zDelta < 0)//当滚轮向下滚动时表示地图缩小
            {
                axSuperMap1.Zoom(0.5);
                axSuperMap1.Refresh();
            }
        }

        private void axSuperLegend1_Modified(object sender, EventArgs e)
        {
            axSuperMap1.Refresh();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            axSuperMap1.BorderStyle = 1; //设置 SuperMap 控件的边框样式，BorderStyle为0 时采用无边框；为时用单线边框
        }

        private void mnuMeasureDistance_Click(object sender, EventArgs e)
        {
            //量算距离
            soTrackingLayer objTLayer = axSuperMap1.TrackingLayer;//获得跟踪层对象
            objTLayer.ClearEvents(); //清除跟踪层所有几何事件对象
            axSuperMap1.Action = seAction.scaTrackPolyline; //设置当前鼠标状态为在内存中画折线
            ReleaseObjects(objTLayer);
            nMeasureMode = 1;//量算长度
            objTLayer = null;

            ControlState(seAction.scaTrackPolyline);//控制菜单状态
            this.stadisvalue.Text = "";
            this.statotledisvalue.Text = "";
            this.staregionvalue.Text = "";
        }

        private void mnuMeasureArea_Click(object sender, EventArgs e)
        {
            //量算面积
            soTrackingLayer objTLayer = axSuperMap1.TrackingLayer;
            objTLayer.ClearEvents();
            axSuperMap1.Action = seAction.scaTrackPolygon;
            ReleaseObjects(objTLayer);
            objTLayer = null;
            nMeasureMode = 3;

            ControlState(seAction.scaTrackPolyline);
            this.stadisvalue.Text = "";
            this.statotledisvalue.Text = "";
            this.staregionvalue.Text = "";
        }

        private void mnuMeasureAngle_Click(object sender, EventArgs e)
        {
            //量算角度
            soTrackingLayer objTLayer = axSuperMap1.TrackingLayer;
            objTLayer.ClearEvents();
            ReleaseObjects(objTLayer);
            objTLayer = null;
            nMeasureMode = 2;
            axSuperMap1.Action = seAction.scaTrackPolyline;

            ControlState(seAction.scaTrackPolyline);
            this.stadisvalue.Text = "";
            this.statotledisvalue.Text = "";
            this.staregionvalue.Text = "";
        }

        private void axSuperMap1_Tracking(object sender, AxSuperMapLib._DSuperMapEvents_TrackingEvent e)
        {
            //在状态栏上显示相应的长度以及面积
            //nMeasureMode为全局变量，1为长度量算，2为角度量算，3为面积量算
            if (e.dTotalArea > 0 && nMeasureMode == 3) //当前绘制面的面积
                this.staregionvalue.Text = "   面积:" + e.dTotalArea.ToString();

            if (e.dCurrentLength > 0 && nMeasureMode == 1) //当前绘制的折线最后一段的长度
                this.stadisvalue.Text = "长度:" + e.dCurrentLength.ToString();
            if (e.dTotalLength > 0 && nMeasureMode == 1) //当前绘制的折线总长度
                this.statotledisvalue.Text = "   总长度:" + e.dTotalLength.ToString();

            if (e.dCurrentAngle > 0 && nMeasureMode == 2) 
                this.statotledisvalue.Text = "   角度:" + e.dCurrentAngle.ToString();
        }

        private void axSuperMap1_Tracked(object sender, EventArgs e)
        {
            //设置菜单、工具条按钮状态
            mnuMeasureDistance.Checked = false;//子菜单
            mnuMeasureArea.Checked = false;
            mnuMeasureAngle.Checked = false;

            toolStripMeasureDis.Checked = false;//工具条上
            toolStripMeasureArea.Checked = false;
            toolStripMeasureAngle.Checked = false;

            axSuperMap1.Action = seAction.scaSelect;//设置当前鼠标状态为点选
        }

    }
}