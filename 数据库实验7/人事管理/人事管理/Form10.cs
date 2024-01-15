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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text ==null ||textBox2.Text ==null|| textBox3.Text == null || textBox5.Text == null || textBox6.Text == null || textBox7.Text == null )
            {
              
                MessageBox.Show("输入不完整， 请检查", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string sql = "Insert into 员工基本信息 values('"+textBox1.Text+ "', '" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" 
                    + textBox7.Text + "', '114514')";
                MessageBox.Show(sql);

                Dao dao = new Dao();

                int i = dao.Execute(sql);
                if (i > 0)
                {
                    MessageBox.Show("插入成功");
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }
    }
}
