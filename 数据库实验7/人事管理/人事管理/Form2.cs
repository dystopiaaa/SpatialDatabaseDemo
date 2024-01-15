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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Table();
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            dataGridView4.Visible = false;
            dataGridView5.Visible = false;
            dataGridView6.Visible = false;
            
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Table()
        {
            string sql = "select*from 员工基本信息 ";
            Dao dao = new Dao();
            IDataReader dr = dao.Read(sql);
            while (dr.Read())
            {
                string a,b,c,d,e,f,g;
                a = dr["员工编号"].ToString(); 
                b = dr["姓名"].ToString();
                c = dr["性别"].ToString();
                d = dr["生日"].ToString();
                e = dr["电话"].ToString();
                f = dr["入职时间"].ToString();
                g = dr["学历编号"].ToString();
                string[]str = { a, b, c, d, e,f,g };
                dataGridView1.Rows.Add(str);
            }
            dr.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void 员工基本信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void 部门ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView2.Visible = true;
            dataGridView1.Visible = false;
            dataGridView3.Visible = false;
            dataGridView4.Visible = false;
            dataGridView5.Visible = false;
            dataGridView6.Visible = false;
            string sql = "select*from 部门 ";
            Dao dao = new Dao();
            IDataReader dr = dao.Read(sql);
            while (dr.Read())
            {
                string a, b;
                a = dr["部门编号"].ToString();
                b = dr["部门名称"].ToString();            
                string[] str = { a, b };
                dataGridView2.Rows.Add(str);
            }
            dr.Close();
        }

        private void 员工婚姻信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView3.Visible = true;
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView4.Visible = false;
            dataGridView5.Visible = false;
            dataGridView6.Visible = false;
            string sql = "select*from 员工婚姻信息 ";
            Dao dao = new Dao();
            IDataReader dr = dao.Read(sql);
            while (dr.Read())
            {
                string a, b, c, d, h, f, g;
                a = dr["婚姻编号"].ToString();
                b = dr["配偶姓名"].ToString();
                c = dr["配偶性别"].ToString();
                d = dr["配偶年龄"].ToString();
                h = dr["配偶生日"].ToString();
                f = dr["员工编号"].ToString();
                g = dr["婚姻状况"].ToString();
                string[] str = { a, b, c, d, h, f, g };
                dataGridView3.Rows.Add(str);
            }
            dr.Close();
        }

        private void 员工学历信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView4.Visible = true;
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            dataGridView5.Visible = false;
            dataGridView6.Visible = false;
            string sql = "select*from 员工学历信息 ";
            Dao dao = new Dao();
            IDataReader dr = dao.Read(sql);
            while (dr.Read())
            {
                string a, b, c, d, h, f, g;
                a = dr["学历编号"].ToString();
                b = dr["学历"].ToString();
                c = dr["专业"].ToString();
                d = dr["学校"].ToString();
                h = dr["毕业时间"].ToString();
                f = dr["外语情况"].ToString();
                g = dr["员工编号"].ToString();
                string[] str = { a, b, c, d, h, f, g };
                dataGridView4.Rows.Add(str);
            }
            dr.Close();
        }

        private void 岗位ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView5.Visible = true;
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            dataGridView4.Visible = false;
            dataGridView6.Visible = false;
            string sql = "select*from 岗位 ";
            Dao dao = new Dao();
            IDataReader dr = dao.Read(sql);
            while (dr.Read())
            {
                string a, b, c, d;
                a = dr["岗位编号"].ToString();
                b = dr["岗位名称"].ToString();
                c = dr["部门编号"].ToString();
                d = dr["员工编号"].ToString();
                string[] str = { a, b, c, d };
                dataGridView5.Rows.Add(str);
            }
            dr.Close();
        }
        

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            form9.Show();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            dataGridView4.Visible = false;
            dataGridView5.Visible = false;
            dataGridView6.Visible = false;
            Table();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            form10.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Form11 form11= new Form11();
            form11.Show();
        }
    }
}
