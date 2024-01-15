
namespace InformationManageSystem
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件 = new System.Windows.Forms.ToolStripMenuItem();
            this.打开 = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.退出 = new System.Windows.Forms.ToolStripMenuItem();
            this.操作 = new System.Windows.Forms.ToolStripMenuItem();
            this.添加 = new System.Windows.Forms.ToolStripMenuItem();
            this.删除 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.更改 = new System.Windows.Forms.ToolStripMenuItem();
            this.查看 = new System.Windows.Forms.ToolStripMenuItem();
            this.表格 = new System.Windows.Forms.ToolStripMenuItem();
            this.打开表格 = new System.Windows.Forms.ToolStripMenuItem();
            this.员工基本信息表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.员工婚姻情况表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.员工学历信息表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.企业工作岗位表 = new System.Windows.Forms.ToolStripMenuItem();
            this.企业部门信息表 = new System.Windows.Forms.ToolStripMenuItem();
            this.地图 = new System.Windows.Forms.ToolStripMenuItem();
            this.打开地图 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.帮助 = new System.Windows.Forms.ToolStripMenuItem();
            this.使用帮助 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.关于 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件,
            this.操作,
            this.查看,
            this.帮助});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(682, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件
            // 
            this.文件.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开,
            this.关闭,
            this.toolStripSeparator3,
            this.退出});
            this.文件.Name = "文件";
            this.文件.Size = new System.Drawing.Size(53, 29);
            this.文件.Text = "文件";
            // 
            // 打开
            // 
            this.打开.Name = "打开";
            this.打开.Size = new System.Drawing.Size(167, 26);
            this.打开.Text = "打开数据库";
            this.打开.Click += new System.EventHandler(this.打开_Click);
            // 
            // 关闭
            // 
            this.关闭.Name = "关闭";
            this.关闭.Size = new System.Drawing.Size(167, 26);
            this.关闭.Text = "关闭数据库";
            this.关闭.Click += new System.EventHandler(this.关闭_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(164, 6);
            // 
            // 退出
            // 
            this.退出.Name = "退出";
            this.退出.Size = new System.Drawing.Size(167, 26);
            this.退出.Text = "退出系统";
            this.退出.Click += new System.EventHandler(this.退出_Click);
            // 
            // 操作
            // 
            this.操作.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加,
            this.删除,
            this.toolStripSeparator4,
            this.更改});
            this.操作.Name = "操作";
            this.操作.Size = new System.Drawing.Size(53, 29);
            this.操作.Text = "操作";
            // 
            // 添加
            // 
            this.添加.Name = "添加";
            this.添加.Size = new System.Drawing.Size(122, 26);
            this.添加.Text = "添加";
            this.添加.Click += new System.EventHandler(this.添加_Click);
            // 
            // 删除
            // 
            this.删除.Name = "删除";
            this.删除.Size = new System.Drawing.Size(122, 26);
            this.删除.Text = "删除";
            this.删除.Click += new System.EventHandler(this.删除_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(119, 6);
            // 
            // 更改
            // 
            this.更改.Name = "更改";
            this.更改.Size = new System.Drawing.Size(122, 26);
            this.更改.Text = "更改";
            this.更改.Click += new System.EventHandler(this.更改_Click);
            // 
            // 查看
            // 
            this.查看.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.表格,
            this.地图,
            this.toolStripSeparator1,
            this.查询ToolStripMenuItem,
            this.toolStripSeparator6});
            this.查看.Name = "查看";
            this.查看.Size = new System.Drawing.Size(53, 29);
            this.查看.Text = "查看";
            // 
            // 表格
            // 
            this.表格.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开表格});
            this.表格.Name = "表格";
            this.表格.Size = new System.Drawing.Size(224, 26);
            this.表格.Text = "表格";
            // 
            // 打开表格
            // 
            this.打开表格.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.员工基本信息表ToolStripMenuItem,
            this.员工婚姻情况表ToolStripMenuItem,
            this.员工学历信息表ToolStripMenuItem,
            this.toolStripSeparator2,
            this.企业工作岗位表,
            this.企业部门信息表});
            this.打开表格.Name = "打开表格";
            this.打开表格.Size = new System.Drawing.Size(224, 26);
            this.打开表格.Text = "打开表格";
            // 
            // 员工基本信息表ToolStripMenuItem
            // 
            this.员工基本信息表ToolStripMenuItem.Name = "员工基本信息表ToolStripMenuItem";
            this.员工基本信息表ToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.员工基本信息表ToolStripMenuItem.Text = "员工基本信息表";
            this.员工基本信息表ToolStripMenuItem.Click += new System.EventHandler(this.员工基本信息表ToolStripMenuItem_Click);
            // 
            // 员工婚姻情况表ToolStripMenuItem
            // 
            this.员工婚姻情况表ToolStripMenuItem.Name = "员工婚姻情况表ToolStripMenuItem";
            this.员工婚姻情况表ToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.员工婚姻情况表ToolStripMenuItem.Text = "员工婚姻情况表";
            this.员工婚姻情况表ToolStripMenuItem.Click += new System.EventHandler(this.员工婚姻情况表ToolStripMenuItem_Click);
            // 
            // 员工学历信息表ToolStripMenuItem
            // 
            this.员工学历信息表ToolStripMenuItem.Name = "员工学历信息表ToolStripMenuItem";
            this.员工学历信息表ToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.员工学历信息表ToolStripMenuItem.Text = "员工学历信息表";
            this.员工学历信息表ToolStripMenuItem.Click += new System.EventHandler(this.员工学历信息表ToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(194, 6);
            // 
            // 企业工作岗位表
            // 
            this.企业工作岗位表.Name = "企业工作岗位表";
            this.企业工作岗位表.Size = new System.Drawing.Size(197, 26);
            this.企业工作岗位表.Text = "企业工作岗位表";
            this.企业工作岗位表.Click += new System.EventHandler(this.企业工作岗位表_Click);
            // 
            // 企业部门信息表
            // 
            this.企业部门信息表.Name = "企业部门信息表";
            this.企业部门信息表.Size = new System.Drawing.Size(197, 26);
            this.企业部门信息表.Text = "企业部门信息表";
            this.企业部门信息表.Click += new System.EventHandler(this.企业部门信息表_Click);
            // 
            // 地图
            // 
            this.地图.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开地图});
            this.地图.Name = "地图";
            this.地图.Size = new System.Drawing.Size(224, 26);
            this.地图.Text = "地图";
            // 
            // 打开地图
            // 
            this.打开地图.Name = "打开地图";
            this.打开地图.Size = new System.Drawing.Size(152, 26);
            this.打开地图.Text = "打开地图";
            this.打开地图.Click += new System.EventHandler(this.打开地图_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // 查询ToolStripMenuItem
            // 
            this.查询ToolStripMenuItem.Name = "查询ToolStripMenuItem";
            this.查询ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.查询ToolStripMenuItem.Text = "查询";
            this.查询ToolStripMenuItem.Click += new System.EventHandler(this.查询ToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(221, 6);
            // 
            // 帮助
            // 
            this.帮助.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.使用帮助,
            this.toolStripSeparator5,
            this.关于});
            this.帮助.Name = "帮助";
            this.帮助.Size = new System.Drawing.Size(53, 29);
            this.帮助.Text = "帮助";
            // 
            // 使用帮助
            // 
            this.使用帮助.Name = "使用帮助";
            this.使用帮助.Size = new System.Drawing.Size(152, 26);
            this.使用帮助.Text = "使用帮助";
            this.使用帮助.Click += new System.EventHandler(this.使用帮助_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(149, 6);
            // 
            // 关于
            // 
            this.关于.Name = "关于";
            this.关于.Size = new System.Drawing.Size(152, 26);
            this.关于.Text = "关于";
            this.关于.Click += new System.EventHandler(this.关于_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 33);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(700, 80);
            this.MinimumSize = new System.Drawing.Size(700, 80);
            this.Name = "MainForm";
            this.Text = "人事管理系统";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件;
        private System.Windows.Forms.ToolStripMenuItem 操作;
        private System.Windows.Forms.ToolStripMenuItem 查看;
        private System.Windows.Forms.ToolStripMenuItem 表格;
        private System.Windows.Forms.ToolStripMenuItem 地图;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 帮助;
        private System.Windows.Forms.ToolStripMenuItem 打开表格;
        private System.Windows.Forms.ToolStripMenuItem 打开地图;
        private System.Windows.Forms.ToolStripMenuItem 打开;
        private System.Windows.Forms.ToolStripMenuItem 关闭;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem 退出;
        private System.Windows.Forms.ToolStripMenuItem 添加;
        private System.Windows.Forms.ToolStripMenuItem 删除;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem 更改;
        private System.Windows.Forms.ToolStripMenuItem 员工基本信息表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 员工婚姻情况表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 员工学历信息表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 企业工作岗位表;
        private System.Windows.Forms.ToolStripMenuItem 企业部门信息表;
        private System.Windows.Forms.ToolStripMenuItem 使用帮助;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem 关于;
        private System.Windows.Forms.ToolStripMenuItem 查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
    }
}

