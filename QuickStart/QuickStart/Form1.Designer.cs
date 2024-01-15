namespace GetStart
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stadisvalue = new System.Windows.Forms.ToolStripStatusLabel();
            this.statotledisvalue = new System.Windows.Forms.ToolStripStatusLabel();
            this.staregionvalue = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStripFile = new System.Windows.Forms.MenuStrip();
            this.MenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripOpenWorkSpace = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripCloseWorkSpace = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripExitProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMap = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripPointSel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripZoomIn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripZoomOut = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripAutoZoom = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripPan = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripViewEntire = new System.Windows.Forms.ToolStripMenuItem();
            this.量算ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMeasureDistance = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMeasureArea = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMeasureAngle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripPointSelect = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnPointSel = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnZoomIn = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnZoomOut = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnAutoZoom = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnPan = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnViewEntire = new System.Windows.Forms.ToolStripButton();
            this.toolStripMeasureDis = new System.Windows.Forms.ToolStripButton();
            this.toolStripMeasureArea = new System.Windows.Forms.ToolStripButton();
            this.toolStripMeasureAngle = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.axSuperLegend1 = new AxSuperLegendLib.AxSuperLegend();
            this.axSuperWkspManager1 = new AxSuperWkspManagerLib.AxSuperWkspManager();
            this.axSuperMap1 = new AxSuperMapLib.AxSuperMap();
            this.ToolStripOpenWS = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripCloseWS = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.axSuperWorkspace1 = new AxSuperMapLib.AxSuperWorkspace();
            this.tableLayoutPanel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStripFile.SuspendLayout();
            this.toolStripPointSelect.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axSuperLegend1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axSuperWkspManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axSuperMap1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axSuperWorkspace1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.statusStrip1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.menuStripFile, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.toolStripPointSelect, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(454, 379);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stadisvalue,
            this.statotledisvalue,
            this.staregionvalue});
            this.statusStrip1.Location = new System.Drawing.Point(0, 357);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(454, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stadisvalue
            // 
            this.stadisvalue.Name = "stadisvalue";
            this.stadisvalue.Size = new System.Drawing.Size(0, 17);
            // 
            // statotledisvalue
            // 
            this.statotledisvalue.Name = "statotledisvalue";
            this.statotledisvalue.Size = new System.Drawing.Size(0, 17);
            // 
            // staregionvalue
            // 
            this.staregionvalue.Name = "staregionvalue";
            this.staregionvalue.Size = new System.Drawing.Size(0, 17);
            // 
            // menuStripFile
            // 
            this.menuStripFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemFile,
            this.ToolStripMap,
            this.量算ToolStripMenuItem});
            this.menuStripFile.Location = new System.Drawing.Point(0, 0);
            this.menuStripFile.Name = "menuStripFile";
            this.menuStripFile.Size = new System.Drawing.Size(454, 24);
            this.menuStripFile.TabIndex = 0;
            this.menuStripFile.Text = "文件";
            // 
            // MenuItemFile
            // 
            this.MenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripOpenWorkSpace,
            this.ToolStripCloseWorkSpace,
            this.ToolStripExitProgram});
            this.MenuItemFile.Name = "MenuItemFile";
            this.MenuItemFile.Size = new System.Drawing.Size(43, 20);
            this.MenuItemFile.Text = "文件";
            // 
            // ToolStripOpenWorkSpace
            // 
            this.ToolStripOpenWorkSpace.Name = "ToolStripOpenWorkSpace";
            this.ToolStripOpenWorkSpace.Size = new System.Drawing.Size(146, 22);
            this.ToolStripOpenWorkSpace.Text = "打开工作空间";
            this.ToolStripOpenWorkSpace.Click += new System.EventHandler(this.ToolStripOpenWS_Click);
            // 
            // ToolStripCloseWorkSpace
            // 
            this.ToolStripCloseWorkSpace.Name = "ToolStripCloseWorkSpace";
            this.ToolStripCloseWorkSpace.Size = new System.Drawing.Size(146, 22);
            this.ToolStripCloseWorkSpace.Text = "关闭工作空间";
            this.ToolStripCloseWorkSpace.Click += new System.EventHandler(this.ToolStripCloseWS_Click);
            // 
            // ToolStripExitProgram
            // 
            this.ToolStripExitProgram.Name = "ToolStripExitProgram";
            this.ToolStripExitProgram.Size = new System.Drawing.Size(146, 22);
            this.ToolStripExitProgram.Text = "退出";
            this.ToolStripExitProgram.Click += new System.EventHandler(this.ToolStripExit);
            // 
            // ToolStripMap
            // 
            this.ToolStripMap.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripPointSel,
            this.toolStripZoomIn,
            this.toolStripZoomOut,
            this.toolStripAutoZoom,
            this.toolStripPan,
            this.toolStripViewEntire});
            this.ToolStripMap.Name = "ToolStripMap";
            this.ToolStripMap.Size = new System.Drawing.Size(43, 20);
            this.ToolStripMap.Text = "地图";
            // 
            // toolStripPointSel
            // 
            this.toolStripPointSel.Name = "toolStripPointSel";
            this.toolStripPointSel.Size = new System.Drawing.Size(122, 22);
            this.toolStripPointSel.Text = "点选";
            this.toolStripPointSel.Click += new System.EventHandler(this.toolStripPointSel_Click);
            // 
            // toolStripZoomIn
            // 
            this.toolStripZoomIn.Name = "toolStripZoomIn";
            this.toolStripZoomIn.Size = new System.Drawing.Size(122, 22);
            this.toolStripZoomIn.Text = "放大";
            this.toolStripZoomIn.Click += new System.EventHandler(this.toolStripZoomIn_Click);
            // 
            // toolStripZoomOut
            // 
            this.toolStripZoomOut.Name = "toolStripZoomOut";
            this.toolStripZoomOut.Size = new System.Drawing.Size(122, 22);
            this.toolStripZoomOut.Text = "缩小";
            this.toolStripZoomOut.Click += new System.EventHandler(this.toolStripZoomOut_Click);
            // 
            // toolStripAutoZoom
            // 
            this.toolStripAutoZoom.Name = "toolStripAutoZoom";
            this.toolStripAutoZoom.Size = new System.Drawing.Size(122, 22);
            this.toolStripAutoZoom.Text = "自由缩放";
            this.toolStripAutoZoom.Click += new System.EventHandler(this.toolStripAutoZoom_Click);
            // 
            // toolStripPan
            // 
            this.toolStripPan.Name = "toolStripPan";
            this.toolStripPan.Size = new System.Drawing.Size(122, 22);
            this.toolStripPan.Text = "平移";
            this.toolStripPan.Click += new System.EventHandler(this.toolStripPan_Click);
            // 
            // toolStripViewEntire
            // 
            this.toolStripViewEntire.Name = "toolStripViewEntire";
            this.toolStripViewEntire.Size = new System.Drawing.Size(122, 22);
            this.toolStripViewEntire.Text = "全幅显示";
            this.toolStripViewEntire.Click += new System.EventHandler(this.toolStripViewEntire_Click);
            // 
            // 量算ToolStripMenuItem
            // 
            this.量算ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMeasureDistance,
            this.mnuMeasureArea,
            this.mnuMeasureAngle});
            this.量算ToolStripMenuItem.Name = "量算ToolStripMenuItem";
            this.量算ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.量算ToolStripMenuItem.Text = "量算";
            // 
            // mnuMeasureDistance
            // 
            this.mnuMeasureDistance.Name = "mnuMeasureDistance";
            this.mnuMeasureDistance.Size = new System.Drawing.Size(98, 22);
            this.mnuMeasureDistance.Text = "距离";
            this.mnuMeasureDistance.Click += new System.EventHandler(this.mnuMeasureDistance_Click);
            // 
            // mnuMeasureArea
            // 
            this.mnuMeasureArea.Name = "mnuMeasureArea";
            this.mnuMeasureArea.Size = new System.Drawing.Size(98, 22);
            this.mnuMeasureArea.Text = "面积";
            this.mnuMeasureArea.Click += new System.EventHandler(this.mnuMeasureArea_Click);
            // 
            // mnuMeasureAngle
            // 
            this.mnuMeasureAngle.Name = "mnuMeasureAngle";
            this.mnuMeasureAngle.Size = new System.Drawing.Size(98, 22);
            this.mnuMeasureAngle.Text = "角度";
            this.mnuMeasureAngle.Click += new System.EventHandler(this.mnuMeasureAngle_Click);
            // 
            // toolStripPointSelect
            // 
            this.toolStripPointSelect.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnPointSel,
            this.toolStripBtnZoomIn,
            this.toolStripBtnZoomOut,
            this.toolStripBtnAutoZoom,
            this.toolStripBtnPan,
            this.toolStripBtnViewEntire,
            this.toolStripMeasureDis,
            this.toolStripMeasureArea,
            this.toolStripMeasureAngle});
            this.toolStripPointSelect.Location = new System.Drawing.Point(0, 27);
            this.toolStripPointSelect.Name = "toolStripPointSelect";
            this.toolStripPointSelect.Size = new System.Drawing.Size(454, 25);
            this.toolStripPointSelect.TabIndex = 1;
            this.toolStripPointSelect.Text = "toolStrip1";
            // 
            // toolStripBtnPointSel
            // 
            this.toolStripBtnPointSel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnPointSel.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnPointSel.Image")));
            this.toolStripBtnPointSel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnPointSel.Name = "toolStripBtnPointSel";
            this.toolStripBtnPointSel.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnPointSel.Text = "点选";
            this.toolStripBtnPointSel.ToolTipText = "点选";
            this.toolStripBtnPointSel.Click += new System.EventHandler(this.toolStripPointSel_Click);
            // 
            // toolStripBtnZoomIn
            // 
            this.toolStripBtnZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnZoomIn.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnZoomIn.Image")));
            this.toolStripBtnZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnZoomIn.Name = "toolStripBtnZoomIn";
            this.toolStripBtnZoomIn.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnZoomIn.Text = "放大";
            this.toolStripBtnZoomIn.Click += new System.EventHandler(this.toolStripZoomIn_Click);
            // 
            // toolStripBtnZoomOut
            // 
            this.toolStripBtnZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnZoomOut.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnZoomOut.Image")));
            this.toolStripBtnZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnZoomOut.Name = "toolStripBtnZoomOut";
            this.toolStripBtnZoomOut.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnZoomOut.Text = "缩小";
            this.toolStripBtnZoomOut.Click += new System.EventHandler(this.toolStripZoomOut_Click);
            // 
            // toolStripBtnAutoZoom
            // 
            this.toolStripBtnAutoZoom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnAutoZoom.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnAutoZoom.Image")));
            this.toolStripBtnAutoZoom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnAutoZoom.Name = "toolStripBtnAutoZoom";
            this.toolStripBtnAutoZoom.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnAutoZoom.Text = "自由缩放";
            this.toolStripBtnAutoZoom.Click += new System.EventHandler(this.toolStripAutoZoom_Click);
            // 
            // toolStripBtnPan
            // 
            this.toolStripBtnPan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnPan.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnPan.Image")));
            this.toolStripBtnPan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnPan.Name = "toolStripBtnPan";
            this.toolStripBtnPan.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnPan.Text = "平移";
            this.toolStripBtnPan.Click += new System.EventHandler(this.toolStripPan_Click);
            // 
            // toolStripBtnViewEntire
            // 
            this.toolStripBtnViewEntire.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnViewEntire.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnViewEntire.Image")));
            this.toolStripBtnViewEntire.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnViewEntire.Name = "toolStripBtnViewEntire";
            this.toolStripBtnViewEntire.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnViewEntire.Text = "全屏显示";
            this.toolStripBtnViewEntire.Click += new System.EventHandler(this.toolStripViewEntire_Click);
            // 
            // toolStripMeasureDis
            // 
            this.toolStripMeasureDis.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripMeasureDis.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMeasureDis.Image")));
            this.toolStripMeasureDis.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripMeasureDis.Name = "toolStripMeasureDis";
            this.toolStripMeasureDis.Size = new System.Drawing.Size(23, 22);
            this.toolStripMeasureDis.Text = "toolStripMeasureDis";
            this.toolStripMeasureDis.Click += new System.EventHandler(this.mnuMeasureDistance_Click);
            // 
            // toolStripMeasureArea
            // 
            this.toolStripMeasureArea.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripMeasureArea.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMeasureArea.Image")));
            this.toolStripMeasureArea.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripMeasureArea.Name = "toolStripMeasureArea";
            this.toolStripMeasureArea.Size = new System.Drawing.Size(23, 22);
            this.toolStripMeasureArea.Text = "toolStripMeasureArea";
            this.toolStripMeasureArea.Click += new System.EventHandler(this.mnuMeasureArea_Click);
            // 
            // toolStripMeasureAngle
            // 
            this.toolStripMeasureAngle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripMeasureAngle.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMeasureAngle.Image")));
            this.toolStripMeasureAngle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripMeasureAngle.Name = "toolStripMeasureAngle";
            this.toolStripMeasureAngle.Size = new System.Drawing.Size(23, 22);
            this.toolStripMeasureAngle.Text = "toolStripMeasureAngle";
            this.toolStripMeasureAngle.Click += new System.EventHandler(this.mnuMeasureAngle_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.axSuperMap1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1, 55);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(452, 301);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.axSuperLegend1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.axSuperWkspManager1, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(1, 1);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(88, 299);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // axSuperLegend1
            // 
            this.axSuperLegend1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axSuperLegend1.Enabled = true;
            this.axSuperLegend1.Location = new System.Drawing.Point(0, 179);
            this.axSuperLegend1.Margin = new System.Windows.Forms.Padding(0);
            this.axSuperLegend1.Name = "axSuperLegend1";
            this.axSuperLegend1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axSuperLegend1.OcxState")));
            this.axSuperLegend1.Size = new System.Drawing.Size(88, 120);
            this.axSuperLegend1.TabIndex = 1;
            this.axSuperLegend1.Modified += new System.EventHandler(this.axSuperLegend1_Modified);
            // 
            // axSuperWkspManager1
            // 
            this.axSuperWkspManager1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axSuperWkspManager1.Enabled = true;
            this.axSuperWkspManager1.Location = new System.Drawing.Point(0, 0);
            this.axSuperWkspManager1.Margin = new System.Windows.Forms.Padding(0);
            this.axSuperWkspManager1.Name = "axSuperWkspManager1";
            this.axSuperWkspManager1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axSuperWkspManager1.OcxState")));
            this.axSuperWkspManager1.Size = new System.Drawing.Size(88, 179);
            this.axSuperWkspManager1.TabIndex = 0;
            this.axSuperWkspManager1.LDbClick += new AxSuperWkspManagerLib._DSuperWkspManagerEvents_LDbClickEventHandler(this.axSuperWkspManager1_LDbClick);
            // 
            // axSuperMap1
            // 
            this.axSuperMap1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axSuperMap1.Enabled = true;
            this.axSuperMap1.Location = new System.Drawing.Point(90, 0);
            this.axSuperMap1.Margin = new System.Windows.Forms.Padding(0);
            this.axSuperMap1.Name = "axSuperMap1";
            this.axSuperMap1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axSuperMap1.OcxState")));
            this.axSuperMap1.Size = new System.Drawing.Size(362, 301);
            this.axSuperMap1.TabIndex = 1;
            this.axSuperMap1.MouseWheelEvent += new AxSuperMapLib._DSuperMapEvents_MouseWheelEventHandler(this.axSuperMap1_MouseWheelEvent);
            this.axSuperMap1.Tracking += new AxSuperMapLib._DSuperMapEvents_TrackingEventHandler(this.axSuperMap1_Tracking);
            this.axSuperMap1.DblClick += new System.EventHandler(this.axSuperMap1_DblClick);
            this.axSuperMap1.Tracked += new System.EventHandler(this.axSuperMap1_Tracked);
            // 
            // ToolStripOpenWS
            // 
            this.ToolStripOpenWS.Name = "ToolStripOpenWS";
            this.ToolStripOpenWS.Size = new System.Drawing.Size(152, 22);
            this.ToolStripOpenWS.Text = "打开工作空间";
            this.ToolStripOpenWS.Click += new System.EventHandler(this.ToolStripOpenWS_Click);
            // 
            // ToolStripCloseWS
            // 
            this.ToolStripCloseWS.Name = "ToolStripCloseWS";
            this.ToolStripCloseWS.Size = new System.Drawing.Size(152, 22);
            this.ToolStripCloseWS.Text = "关闭工作空间";
            this.ToolStripCloseWS.Click += new System.EventHandler(this.ToolStripCloseWS_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // axSuperWorkspace1
            // 
            this.axSuperWorkspace1.Enabled = true;
            this.axSuperWorkspace1.Location = new System.Drawing.Point(209, 0);
            this.axSuperWorkspace1.Name = "axSuperWorkspace1";
            this.axSuperWorkspace1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axSuperWorkspace1.OcxState")));
            this.axSuperWorkspace1.Size = new System.Drawing.Size(32, 32);
            this.axSuperWorkspace1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(454, 379);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.axSuperWorkspace1);
            this.MainMenuStrip = this.menuStripFile;
            this.Name = "MainForm";
            this.Text = "开发入门";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStripFile.ResumeLayout(false);
            this.menuStripFile.PerformLayout();
            this.toolStripPointSelect.ResumeLayout(false);
            this.toolStripPointSelect.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axSuperLegend1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axSuperWkspManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axSuperMap1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axSuperWorkspace1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStripFile;
        private System.Windows.Forms.ToolStrip toolStripPointSelect;
        private System.Windows.Forms.ToolStripMenuItem ToolStripOpenWS;
        private System.Windows.Forms.ToolStripMenuItem ToolStripCloseWS;
        private System.Windows.Forms.ToolStripButton toolStripBtnPointSel;
        private System.Windows.Forms.ToolStripButton toolStripBtnZoomIn;
        private System.Windows.Forms.ToolStripButton toolStripBtnZoomOut;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMap;
        private System.Windows.Forms.ToolStripButton toolStripBtnAutoZoom;
        private System.Windows.Forms.ToolStripButton toolStripBtnPan;
        private System.Windows.Forms.ToolStripButton toolStripBtnViewEntire;
        private System.Windows.Forms.ToolStripMenuItem toolStripPointSel;
        private System.Windows.Forms.ToolStripMenuItem toolStripZoomIn;
        private System.Windows.Forms.ToolStripMenuItem toolStripZoomOut;
        private System.Windows.Forms.ToolStripMenuItem toolStripAutoZoom;
        private System.Windows.Forms.ToolStripMenuItem toolStripPan;
        private System.Windows.Forms.ToolStripMenuItem toolStripViewEntire;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem ToolStripOpenWorkSpace;
        private System.Windows.Forms.ToolStripMenuItem ToolStripCloseWorkSpace;
        private System.Windows.Forms.ToolStripMenuItem ToolStripExitProgram;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem 量算ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuMeasureDistance;
        private System.Windows.Forms.ToolStripMenuItem mnuMeasureArea;
        private System.Windows.Forms.ToolStripMenuItem mnuMeasureAngle;
        private System.Windows.Forms.ToolStripButton toolStripMeasureDis;
        private System.Windows.Forms.ToolStripButton toolStripMeasureArea;
        private System.Windows.Forms.ToolStripButton toolStripMeasureAngle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private AxSuperLegendLib.AxSuperLegend axSuperLegend1;
        private AxSuperWkspManagerLib.AxSuperWkspManager axSuperWkspManager1;
        private AxSuperMapLib.AxSuperMap axSuperMap1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel stadisvalue;
        private System.Windows.Forms.ToolStripStatusLabel statotledisvalue;
        private System.Windows.Forms.ToolStripStatusLabel staregionvalue;
        private AxSuperMapLib.AxSuperWorkspace axSuperWorkspace1;

    }
}

