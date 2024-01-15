using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InformationManageSystem
{
    public partial class DelForm : Form
    {
        private SqlConnection con;
        public DelForm()
        {
            InitializeComponent();
        }
        public DelForm(string operatorName, ref SqlConnection con)
        {
            InitializeComponent();
            this.Name = operatorName;
            this.con = con;
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            string sql = "delete from employee where id="
                +textBox1.Text;
            try
            {
                SqlCommand cmd = new SqlCommand(sql, this.con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception _e)
            {
                MessageBox.Show(_e.Message);
                throw;
            }

            MessageBox.Show("删除完成！");
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DelForm_Load(object sender, EventArgs e)
        {
            if (this.con == null)
            {
                MessageBox.Show("未连接数据库");
                this.Close();
                return;
            }
        }
    }
}
