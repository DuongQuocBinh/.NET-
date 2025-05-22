using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Management.Instrumentation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Quản_Lý_Thư_Viện
{
    class Lop_dung_chung
    {
        SqlConnection conn;
        public Lop_dung_chung()
        {
            string chuoikn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\duong\source\repos\Quản Lý Thư Viện\Quản Lý Thư Viện\QuanLyThuVien.mdf"";Integrated Security=True";
            conn = new SqlConnection(chuoikn);
        }
        public object LayGt(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql,conn);
            conn.Open();
            object gt = cmd.ExecuteScalar();
            conn.Close();
            return gt;
        }
        public DataTable LayDLBang(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public string EncodePassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        public bool KiemTraDangNhap(string username, string password)
        {
            string sql = "SELECT Role FROM Users WHERE TenDangNhap = @username AND MatKhau = @password";
            SqlCommand cmd = new SqlCommand(sql, conn);
            string encodedPassword = EncodePassword(password);
            object kt = LayGt(sql);
            return Convert.ToInt32(kt) > 0;
        }
        public DataTable LayDLBang(string sql, SqlParameter[] parameters)
        {
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddRange(parameters);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool ThucThi(string sql)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                int result = cmd.ExecuteNonQuery();
                conn.Close();
                return result > 0;
            }
            catch
            {
                conn.Close();
                return false;
            }
        }
    }
}