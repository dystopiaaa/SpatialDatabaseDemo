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
    public partial class AddForm : Form
    {
        private SqlConnection con;

        public AddForm(string operatorName, ref SqlConnection con)
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
            string sql = "insert into employee values("
                + "'" + idBox.Text + "'," 
                + "'" + nmBox.Text + "',"
                + "'" + sex + "',"
                + ageBox.Text + ","//???
                + "'" + jobBox.Text + "',"
                + yW.Text + "-" + mW.Text + "-" + dW.Text + ","
                + "'" + titleBox.Text + "'"
                + ")";           
            if (idBox.Text=="" || nmBox.Text=="")
            {
                MessageBox.Show("输入数据非法");
                return;
            }
            if (xlBox.Text != "")
            {
                sql+= "insert into employee_education values("
                    + "'" + idBox.Text + "',"
                    + "'" + xlBox.Text + "',"
                    + "'" + zyBox.Text + "',"
                    + yBox.Text + "-" + mBox.Text + "-" + dBox.Text + ","
                    + "'" + schoolBox.Text + "',"
                    + "'" + fLangBox.Text + "'"
                    + ")";
            }
            if (marriedBtn.Checked || singleBtn.Checked)
            {
                byte married;
                if (marriedBtn.Checked) married = 1;
                else married = 0;
                sql += "insert into employee_marry values("
                    + "'" + idBox.Text + "',"
                    + "'" + married + "',"
                    + "'" + partnerBox.Text + "'"
                    + ")";
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
            
            MessageBox.Show("添加完成！");
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
