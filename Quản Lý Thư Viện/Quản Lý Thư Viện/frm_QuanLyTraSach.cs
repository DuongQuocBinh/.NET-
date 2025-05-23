using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_Lý_Thư_Viện
{
    public partial class frm_QuanLyTraSach: Form
    {
        public frm_QuanLyTraSach()
        {
            InitializeComponent();
        }
        LopDungChung lopchung = new LopDungChung();


        private void frm_QuanLyTraSach_Load(object sender, EventArgs e)
        {
            LoadPhieuMuon();
            cmb_LoaiTK.Items.Clear();
            cmb_LoaiTK.Items.Add("Mã phiếu mượn");
            cmb_LoaiTK.Items.Add("Mã sách");
            cmb_LoaiTK.SelectedIndex = 0;
        }
        public void LoadPhieuMuon()
        {
            string sql = "SELECT * FROM PhieuMuon";
            DataTable dt = lopchung.LayDLBang(sql);

            dgv_QLTraSach.DataSource = dt;
        }

        private void btn_HienThi_Click(object sender, EventArgs e)
        {
       
            LoadPhieuMuon();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string loai = cmb_LoaiTK.SelectedItem.ToString();
            string giatri = txt_Ma.Text.Trim();
            string sql = "SELECT * FROM PhieuMuon WHERE 1=1";
            List<SqlParameter> parameters = new List<SqlParameter>();

            if (loai == "Mã phiếu mượn")
            {
                sql += " AND MaPhieuMuon = @giatri";
                int maPhieu;
                if (int.TryParse(giatri, out maPhieu))
                    parameters.Add(new SqlParameter("@giatri", maPhieu));
                else
                {
                    MessageBox.Show("Mã phiếu mượn phải là số!");
                    return;
                }
            }
            else if (loai == "Mã sách")
            {
                sql += " AND MaSach = @giatri";
                int maSach;
                if (int.TryParse(giatri, out maSach))
                    parameters.Add(new SqlParameter("@giatri", maSach));
                else
                {
                    MessageBox.Show("Mã sách phải là số!");
                    return;
                }
            }

            // Sử dụng SqlDataAdapter với tham số
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    if (parameters.Count > 0)
                        cmd.Parameters.AddRange(parameters.ToArray());
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            dgv_QLTraSach.DataSource = dt;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            int maDocGia, maSach;
            if (!int.TryParse(txt_MaDG.Text, out maDocGia) || !int.TryParse(txt_MaSach.Text, out maSach))
            {
                MessageBox.Show("Mã độc giả và mã sách phải là số!");
                return;
            }
            string sql = "DELETE FROM PhieuMuon WHERE MaDocGia = @maDG AND MaSach = @maSach";
            List<SqlParameter> parameters = new List<SqlParameter>
    {
        new SqlParameter("@maDG", maDocGia),
        new SqlParameter("@maSach", maSach)
    };
            int kq = lopchung.ThemSua(sql, parameters);
            if (kq > 0)
                MessageBox.Show("Xóa thành công!");
            else
                MessageBox.Show("Xóa không thành công!");
            LoadPhieuMuon(); // Cập nhật lại DataGridView
        }
        private string GetConnectionString()
        {
            var field = typeof(LopDungChung).GetField("conn", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            SqlConnection conn = (SqlConnection)field.GetValue(lopchung);
            return conn.ConnectionString;
        }

    }
}
