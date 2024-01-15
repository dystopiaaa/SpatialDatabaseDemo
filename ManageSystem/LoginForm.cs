using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InformationManageSystem
{
    public partial class LoginForm : Form
    {
        private MainForm mainFrm;

        public LoginForm(MainForm mainFrm)
        {
            InitializeComponent();
            this.mainFrm = mainFrm;
            this.mainFrm.Opacity = 0;
            this.mainFrm.Enabled = false;
        }

        

        private void loginBtn_Click(object sender, EventArgs e)
        {            
            //if (radioButton1.Checked == true)//用户名
            //{
            //    this.mainFrm.EntryMode = 1;
            //    entryMode = 1;
            //}
            //else if(radioButton2.Checked == true)//管理员
            //{
            //    this.mainFrm.EntryMode = 2;
            //    entryMode = 2;
            //}

            if (true)//nmTBox.Text == "user_1" && pwdTBox.Text == "123")
            {
                this.mainFrm.Nm = nmTBox.Text;
                this.mainFrm.Pwd = pwdTBox.Text;
                this.mainFrm.Opacity = 1;
                this.mainFrm.Enabled = true;
                this.Close();
                return;
            }
            
            //else if(entryMode ==0 /*2*/ && nmTBox.Text == ""/*"admin_1"*/ && pwdTBox.Text == ""/*"111"*/)
            //{
            //  this.mainFrm.Nm = nmTBox.Text;
            //    this.mainFrm.Pwd = pwdTBox.Text;
            //    this.mainFrm.Opacity = 1;
            //    this.mainFrm.Enabled = true;
            //    this.Close();
            //    return;
            //}
            this.mainFrm.Close();
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.mainFrm.Close();
            this.Close();
        }
    }
}
