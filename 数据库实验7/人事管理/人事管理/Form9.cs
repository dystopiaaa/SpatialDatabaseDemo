﻿using System;
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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {       

            string sql = "delete from 员工基本信息 where 员工编号='" + textBox1.Text + " '";

            MessageBox.Show(sql);

            Dao dao = new Dao();
            int i = dao.Execute(sql);
            if (i > 0)
            {
                MessageBox.Show("删除成功");
            }
            else
            {
                MessageBox.Show("删除失败");
            }

            dao.Execute(sql);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
