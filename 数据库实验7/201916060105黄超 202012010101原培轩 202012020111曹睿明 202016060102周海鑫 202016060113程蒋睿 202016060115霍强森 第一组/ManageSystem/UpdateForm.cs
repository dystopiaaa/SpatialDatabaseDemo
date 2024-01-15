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
                + ageBox.Text + ",job_id="//???
                + "'" + jobBox.Text + "',work_time="
                + yW.Text + "-" + mW.Text + "-" + dW.Text
                + ",title='" + titleBox.Text + "' "
                + "where id=" + "'" + idBox.Text + "';";           
            if (idBox.Text=="" || nmBox.Text=="")
            {
                MessageBox.Show("输入数据非法");
                return;
            }
            if (xlBox.Text != "")
            {
                sql += "update employee_education set edu_id="
                    + "'" + idBox.Text + "',education="
                    + "'" + xlBox.Text + "',major="
                    + "'" + zyBox.Text + "',edu_time="
                    + yBox.Text + "-" + mBox.Text + "-" + dBox.Text + ",edu_school="
                    + "'" + schoolBox.Text + "',[foreign]="
                    + "'" + fLangBox.Text + "' "
                    + "where edu_id='" + idBox.Text + "';";
            }
            if (marriedBtn.Checked || singleBtn.Checked)
            {
                byte married;
                if (marriedBtn.Checked) married = 1;
                else married = 0;
                sql += "update employee_marry set em_id="
                    + "'" + idBox.Text + "',married="
                    + "'" + married + "',partner_id="
                    + "'" + partnerBox.Text + "' "
                    + "where em_id='" + idBox.Text + "';";
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
