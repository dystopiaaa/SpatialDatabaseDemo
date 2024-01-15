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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
    


        public void button1_Click(object sender, EventArgs e)
        {
            string sql = "select*from 员工基本信息 where 姓名='" + textBox1.Text + "'"; 
            Dao dao = new Dao();
            IDataReader dr = dao.Read(sql);
            while (dr.Read())
            {
                string a, b, c, d, h, f, g;
                a = dr["员工编号"].ToString();
                b = dr["姓名"].ToString();
                c = dr["性别"].ToString();
                d = dr["生日"].ToString();
                h = dr["电话"].ToString();
                f = dr["入职时间"].ToString();
                g = dr["学历编号"].ToString();
                string[] str = { a, b, c, d, h, f, g };
                dataGridView1.Rows.Add(str);
            }
            dr.Close();
        }

        private void 查询_Click(object sender, EventArgs e)
        {
            string sql = "select 员工基本信息.员工编号,姓名,性别,生日,电话,入职时间,员工基本信息.学历编号 from 员工婚姻信息  INNER JOIN 员工基本信息 on 员工基本信息.员工编号=员工婚姻信息.员工编号 INNER JOIN 员工学历信息 on 员工基本信息.学历编号=员工学历信息.学历编号 INNER JOIN 岗位 on 员工基本信息.员工编号=岗位.员工编号 INNER JOIN 部门 on 部门.部门编号=岗位.部门编号 where 配偶姓名 ='" + textBox2.Text + "'";
            Dao dao = new Dao();
            IDataReader dr = dao.Read(sql);
            while (dr.Read())
            {
                string a, b, c, d, h, f, g;
                a = dr["员工编号"].ToString();
                b = dr["姓名"].ToString();
                c = dr["性别"].ToString();
                d = dr["生日"].ToString();
                h = dr["电话"].ToString();
                f = dr["入职时间"].ToString();
                g = dr["学历编号"].ToString();
                string[] str = { a, b, c, d, h, f, g };
                dataGridView1.Rows.Add(str);
            }
            dr.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "select 员工基本信息.员工编号,姓名,性别,生日,电话,入职时间,员工基本信息.学历编号 from 员工婚姻信息  INNER JOIN 员工基本信息 on 员工基本信息.员工编号=员工婚姻信息.员工编号 INNER JOIN 员工学历信息 on 员工基本信息.学历编号=员工学历信息.学历编号 INNER JOIN 岗位 on 员工基本信息.员工编号=岗位.员工编号 INNER JOIN 部门 on 部门.部门编号=岗位.部门编号 where 岗位名称 ='" + textBox3.Text + "'";
            Dao dao = new Dao();
            IDataReader dr = dao.Read(sql);
            while (dr.Read())
            {
                string a, b, c, d, h, f, g;
                a = dr["员工编号"].ToString();
                b = dr["姓名"].ToString();
                c = dr["性别"].ToString();
                d = dr["生日"].ToString();
                h = dr["电话"].ToString();
                f = dr["入职时间"].ToString();
                g = dr["学历编号"].ToString();
                string[] str = { a, b, c, d, h, f, g };
                dataGridView1.Rows.Add(str);
            }
            dr.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sql = "select 员工基本信息.员工编号,姓名,性别,生日,电话,入职时间,员工基本信息.学历编号 from 员工婚姻信息  INNER JOIN 员工基本信息 on 员工基本信息.员工编号=员工婚姻信息.员工编号 INNER JOIN 员工学历信息 on 员工基本信息.学历编号=员工学历信息.学历编号 INNER JOIN 岗位 on 员工基本信息.员工编号=岗位.员工编号 INNER JOIN 部门 on 部门.部门编号=岗位.部门编号 where 学历 ='" + textBox4.Text + "'";
            Dao dao = new Dao();
            IDataReader dr = dao.Read(sql);
            while (dr.Read())
            {
                string a, b, c, d, h, f, g;
                a = dr["员工编号"].ToString();
                b = dr["姓名"].ToString();
                c = dr["性别"].ToString();
                d = dr["生日"].ToString();
                h = dr["电话"].ToString();
                f = dr["入职时间"].ToString();
                g = dr["学历编号"].ToString();
                string[] str = { a, b, c, d, h, f, g };
                dataGridView1.Rows.Add(str);
            }
            dr.Close();
        }
    }
}
