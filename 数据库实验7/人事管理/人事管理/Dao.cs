using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace 人事管理
{
    class Dao
    {
        public SqlConnection Connect()
        {
            /*string str = @"Data Source=DESKTOP-KA8C2SB\CRM;Initial Catalog=InformationData;Integrated Security=True";
            SqlConnection sc = new SqlConnection(str);
            sc.Open();
            return sc;*/
            //sqlserver连接
            string connString =
                "server = .;" +
                "database = InformationData;" +
                "user id = user_1;" +
                "password = 123;";
            try
            {
                SqlConnection sc = new SqlConnection(connString);
                sc.Open();
                //MessageBox.Show("打开数据库成功！");
                return sc;
            }
            catch (Exception _e)
            {
                MessageBox.Show(_e.Message);
                throw;
            }
        }
        public SqlCommand Command(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, Connect());
            return cmd;
        }
        public int Execute(string sql)
        {
            return Command(sql).ExecuteNonQuery();
        }
        public SqlDataReader Read(string sql)
        {
            return Command(sql).ExecuteReader();
        }
    }
}
