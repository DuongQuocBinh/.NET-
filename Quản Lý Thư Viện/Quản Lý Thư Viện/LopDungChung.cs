using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_Lý_Thư_Viện
{
    internal class LopDungChung
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\QuanLyThuVien.mdf;Integrated Security=True";

        public DataTable LayDLBang(string sql)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {   
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public int ThemSuaXoa(string sql)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                int kq = cmd.ExecuteNonQuery();
                conn.Close();
                return kq;
            }
        }
    }
}
