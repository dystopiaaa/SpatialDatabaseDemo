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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = " select * from 员工基本信息 where 员工编号 = '" + textBox1.Text + "'";
            Dao dao = new Dao();
            IDataReader dr = dao.Read(sql);
            if (dr.Read())
            {
                string sql2 = "delete from 员工基本信息 where 员工编号='" + textBox1.Text + " '";
               
                Dao dao2 = new Dao();
                int i = dao2.Execute(sql2);
                if (i > 0)
                {
                    string sql1 = "Insert into 员工基本信息 values('" + textBox1.Text + "', '" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','"
              + textBox7.Text + "', '114514')";
                   

                    Dao dao3 = new Dao();
                    int y = dao3.Execute(sql1);
                    MessageBox.Show("修改成功");
                }
            }
            else
            {
                string sql1 = "Insert into 员工基本信息 values('" + textBox1.Text + "', '" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','"
               + textBox7.Text + "', '114514')";
                MessageBox.Show(sql1);

                Dao dao1 = new Dao();

                int i = dao1.Execute(sql1);
                if (i > 0)
                {
                    MessageBox.Show("插入成功");
                }
            }

           



        }
    }
}
