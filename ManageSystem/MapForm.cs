using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;        
using System.IO;
using System.Threading;
using System.Collections;
using System.Data;
using System.Data.SqlClient;

namespace InformationManageSystem
{
    [System.Runtime.InteropServices.ComVisible(true)]
    public partial class MapForm : Form
    {
        private SqlConnection con;
        public MapForm()
        {
            InitializeComponent();
        }
        public MapForm(ref SqlConnection con)
        {
            InitializeComponent();
            this.con = con;
        }

        private void MapForm_Load(object sender, EventArgs e)
        {
            string str_url = Application.StartupPath + "/AMap.html";
            Uri url = new Uri(str_url);
            webBrowser1.Url = url;
            webBrowser1.ObjectForScripting = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "SELECT job_location.Long AS 经度,job_location.Lat AS 纬度 FROM sys_job WHERE job_id="
                +comboBox1.Text;
            if (this.con == null)
            {
                MessageBox.Show("未连接数据库");
                this.Close();
                return;
            }
            SqlCommand cmd = new SqlCommand(sql, this.con);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();           
            dataAdapter.Fill(dt);
            dataAdapter.Dispose();//释放适配器内存
            longBox.Text = dt.Tables[0].Rows[0].ItemArray[0].ToString();
            latBox.Text = dt.Tables[0].Rows[0].ItemArray[1].ToString();
            dt.Clear();
        }
    }
}
