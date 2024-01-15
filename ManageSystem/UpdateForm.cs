using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InformationManageSystem
{
    public partial class UpdateForm : Form
    {
        private SqlConnection con;

        public UpdateForm(string operatorName, ref SqlConnection con)
        {
            InitializeComponent();
            this.Name = operatorName;
            this.con = con;
        }

        private void OperatorForm_Load(object sender, EventArgs e)
        {
            if (this.con == null)
            {
                MessageBox.Show("未连接数据库");
                this.Close();
                return;
            }            
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            string sex;
            if (mRBtn.Checked) sex = mRBtn.Text;
            else if (fRBtn.Checked) sex = fRBtn.Text;
            else sex = "";
            string sql = "update employee set id="
                + "'" + idBox.Text + "',name=" 
                + "'" + nmBox.Text + "',sex="
                + "'" + sex + "',age="
                + ageBox.Text + ",dept="//???
                + "'" + deptBox.Text + "'";           
            if (idBox.Text=="" || nmBox.Text=="" /*|| sex=="" || 
                ageBox.Text=="" || deptBox.Text==""*/)
            {
                MessageBox.Show("输入数据非法");
                return;
            }
            try
            {
                SqlCommand cmd = new SqlCommand(sql, this.con);
                cmd.ExecuteNonQuery();
            }
            catch(Exception _e)
            {
                MessageBox.Show(_e.Message);
                throw;
            }
            
            MessageBox.Show("更改完成！");
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
