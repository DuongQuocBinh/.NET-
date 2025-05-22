using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_Lý_Thư_Viện
{
    class LOPDUNGCHUNG
    {
        SqlConnection conn;
        public LOPDUNGCHUNG()
        {
            string chuoikn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\ProjectWinForm\.NET-\Quản Lý Thư Viện\Quản Lý Thư Viện\QuanLyThuVien.mdf"";Integrated Security=True";
            conn = new SqlConnection(chuoikn);
        }
        //Viết phương thức cho các nút Thêm Sửa Xoá
        public int ThemSuaXoa(string sql)
        {
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            int kq = comm.ExecuteNonQuery();
            conn.Close();
            return kq;
        }
        //Viết phương thức cho các nút Lấy giá trị
        public object LayGT(string sql)
        {
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            object kq = comm.ExecuteScalar();
            conn.Close();
            return kq;
        }
        //Viết phương thức cho dữ liệu bảng
        public DataTable LayDLBang(string sql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            return dt;
        }
    }
}
