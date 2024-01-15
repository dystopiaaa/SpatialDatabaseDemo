using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InformationManageSystem
{
    public partial class MainForm : Form
    {
        public int EntryMode { set => entryMode = value; }
        private int entryMode = 0;//0默认，1用户，2管理员

        public string Nm { set => nm = value; }
        private string nm;

        public string Pwd { set => pwd = value; }
        private string pwd;

        private SqlConnection con;

        public MainForm()
        {
            CreateLoginForm();
            InitializeComponent();
        }

        //private Thread th;

        private void CreateLoginForm()
        {            
            LoginForm loginFrm = new LoginForm(this);
            if (loginFrm == null)
            {
                MessageBox.Show("加载登录界面失败！");
                this.Opacity = 1;
                this.Enabled = true;
                return;
            }            
            loginFrm.Show();                
        }

        private void CreateOperatorForm(string operatorName)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (operatorName == frm.Name)
                {
                    MessageBox.Show("已经打开了" + operatorName + "界面！");
                    return;
                }
            }
            Form operatorFrm = null;
            switch (operatorName)
            {
                case "添加":
                    operatorFrm = new AddForm(operatorName, ref con);
                    break;
                case "删除":
                    operatorFrm = new DelForm(operatorName, ref con);
                    break;
                case "更改":
                    operatorFrm = new UpdateForm(operatorName, ref con);
                    break;
            }
            
            if (operatorFrm == null)
            {
                MessageBox.Show("加载表格界面失败！");
                return;
            }
            operatorFrm.Show();
        }

        private void CreateTableForm(string tableName)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (tableName == frm.Name)
                {
                    MessageBox.Show("已经打开了" + tableName + "界面！");
                    return;
                }
            }

            TableForm tableFrm = new TableForm(tableName, ref con);
            if (tableFrm == null)
            {
                MessageBox.Show("加载表格界面失败！");
                return;
            }
            tableFrm.Show();
        }
        //MainForm
        //
        //文件
        private void 打开_Click(object sender, EventArgs e)
        {
            //sqlserver连接
            string connString =
                "server = .;" +
                "database = InformationData;" +
                "user id = user_1;" +
                "password = 123;";
            try
            {
                con = new SqlConnection(connString);
                con.Open();
                MessageBox.Show("打开数据库成功！");
            }
            catch (Exception _e)
            {
                MessageBox.Show(_e.Message);
                throw;
            }
        }
        private void 关闭_Click(object sender, EventArgs e)
        {
            try
            {
                con.Close();
                MessageBox.Show("关闭数据库成功！");
            }catch(Exception _e)
            {
                MessageBox.Show(_e.Message);
                throw;
            }
        }
        private void 退出_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //操作
        private void 添加_Click(object sender, EventArgs e)
        {
            CreateOperatorForm("添加");
        }
        private void 删除_Click(object sender, EventArgs e)
        {
            CreateOperatorForm("删除");
        }
        private void 更改_Click(object sender, EventArgs e)
        {
            CreateOperatorForm("更改");
        }
        //查看
        private void 员工基本信息表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateTableForm("员工基本信息表");
        }
        private void 员工婚姻情况表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateTableForm("员工婚姻情况表");
        }
        private void 员工学历信息表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateTableForm("员工学历信息表");
        }  
        private void 企业工作岗位表_Click(object sender, EventArgs e)
        {
            CreateTableForm("企业工作岗位表");
        }
        private void 企业部门信息表_Click(object sender, EventArgs e)
        {
            CreateTableForm("企业部门信息表");
        }
        
        private void 打开地图_Click(object sender, EventArgs e)
        {
            MapForm mapFrm = new MapForm(ref con);
            if (mapFrm == null)
            {
                MessageBox.Show("加载地图界面失败！");
                return;
            }
            mapFrm.Show();
        }
 
        //关于      
        private void 关于_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://baike.baidu.com/item/%E4%BA%BA%E4%BA%8B%E7%AE%A1%E7%90%86%E7%B3%BB%E7%BB%9F/1431485?fr=aladdin");
        }

        private void 查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QueryForm queryFrm = new QueryForm(ref con);
            if (queryFrm == null)
            {
                MessageBox.Show("加载查询界面失败！");
                return;
            }
            queryFrm.Show();
        }

        private void 统计ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatForm statFrm = new StatForm(ref con);
            if (statFrm == null)
            {
                MessageBox.Show("加载统计界面失败！");
                return;
            }
            statFrm.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            CreateOperatorForm("添加");
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            CreateOperatorForm("删除");
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            CreateOperatorForm("更改");
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            查询ToolStripMenuItem_Click(sender, e);
        }
    }
}
