using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 人事管理
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (login())
            {
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
        }
        private bool login()
        {
            if (textBox1.Text == "" || textBox2.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("输入不完整， 请检查", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                return false;
            }
            else
            {
                string sql = " select * from 员工基本信息 where 员工编号 = '" + textBox1.Text + "'and 密码 = '" + textBox2.Text + "'";
                Dao dao = new Dao();
                IDataReader dr = dao.Read(sql);
                if (dr.Read())
                {
                   
                    return true;
                }
                else
                {
                    MessageBox.Show("用户名或密码不正确");
                    return false;
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
