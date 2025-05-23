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
    public partial class frm_QuanLyMuonTraSach: Form
    {
        public frm_QuanLyMuonTraSach()
        {
            InitializeComponent();
        }
        LopDungChung lopchung = new LopDungChung();
        private void btn_Them_Click(object sender, EventArgs e)
        {
            int maDocGia, maSach;
            if (!int.TryParse(txt_MaDG.Text, out maDocGia))
            {
                MessageBox.Show("Mã độc giả phải là số và không được để trống!");
                txt_MaDG.Focus();
                return;
            }
            if (!int.TryParse(txt_MaSach.Text, out maSach))
            {
                MessageBox.Show("Mã sách phải là số và không được để trống!");
                txt_MaSach.Focus();
                return;
            }

            string sql = "INSERT INTO PHIEUMUON (MADOCGIA, MASACH, NGAYMUON, TRANGTHAI, NGAYTRA, HANTRA) " +
                         "VALUES (@MaDocGia, @MaSach, @NgayMuon, @TrangThai, @NgayTra, @HanTra)";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@MaDocGia", maDocGia),
                new SqlParameter("@MaSach", maSach),
                new SqlParameter("@NgayMuon", dtp_NgayMuon.Value),
                new SqlParameter("@TrangThai", cmb_TrangThai.Text),
                new SqlParameter("@HanTra", dtp_HanTra.Value)
            };
            if (string.IsNullOrWhiteSpace(dtp_NgayTra.Text) || dtp_NgayTra.Value > dtp_HanTra.Value)
                parameters.Add(new SqlParameter("@NgayTra", DBNull.Value));
            else
                parameters.Add(new SqlParameter("@NgayTra", dtp_NgayTra.Value));

            int kq = lopchung.ThemSua(sql, parameters);
            if (kq >= 1)
                MessageBox.Show("Thêm phiếu mượn thành công");
            else
                MessageBox.Show("Thêm phiếu mượn không thành công");
            LoadPhieuMuon();
        }
        public void LoadPhieuMuon()
        {
            string sql = "SELECT * FROM PhieuMuon";
            DataTable dt = lopchung.LayDLBang(sql);

            dgv_QLThuVien.DataSource = dt;
        }

        private void frm_QuanLyMuonTraSach_Load(object sender, EventArgs e)
        {
            LoadPhieuMuon();
            string sql = "SELECT DISTINCT TRANGTHAI FROM PHIEUMUON";
            cmb_TrangThai.DataSource = lopchung.LayDLBang(sql);
            cmb_TrangThai.DisplayMember = "TRANGTHAI";
            cmb_TrangThai.ValueMember = "TRANGTHAI";

        }

        private void dgv_QLThuVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaDG.Text = dgv_QLThuVien.CurrentRow.Cells["MADOCGIA"].Value.ToString();
            txt_MaSach.Text = dgv_QLThuVien.CurrentRow.Cells["MASACH"].Value.ToString();
            txt_MaPhieuMuon.Text = dgv_QLThuVien.CurrentRow.Cells["MAPHIEUMUON"].Value.ToString();
            dtp_NgayMuon.Text = dgv_QLThuVien.CurrentRow.Cells["NGAYMUON"].Value.ToString();
            cmb_TrangThai.Text = dgv_QLThuVien.CurrentRow.Cells["TRANGTHAI"].Value.ToString();
            dtp_NgayTra.Text = dgv_QLThuVien.CurrentRow.Cells["NGAYTRA"].Value.ToString();
            dtp_HanTra.Text = dgv_QLThuVien.CurrentRow.Cells["HANTRA"].Value.ToString();

        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_MaSach.Text) || string.IsNullOrWhiteSpace(txt_MaPhieuMuon.Text) || cmb_TrangThai.SelectedIndex == -1 || string.IsNullOrWhiteSpace(dtp_NgayMuon.Text) || string.IsNullOrWhiteSpace(dtp_HanTra.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maSach, maPhieuMuon;
            if (!int.TryParse(txt_MaSach.Text, out maSach) || !int.TryParse(txt_MaPhieuMuon.Text, out maPhieuMuon))
            {
                MessageBox.Show("Mã sách và mã phiếu mượn phải là số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sql = "UPDATE PHIEUMUON SET MASACH = @MaSach, TRANGTHAI = @TrangThai, NGAYMUON = @NgayMuon, NGAYTRA = @NgayTra, HANTRA = @HanTra WHERE MAPHIEUMUON = @MaPhieuMuon";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@MaSach", int.Parse(txt_MaSach.Text)),
                new SqlParameter("@TrangThai", cmb_TrangThai.Text),
                new SqlParameter("@NgayMuon", dtp_NgayMuon.Value),
                new SqlParameter("@HanTra", dtp_HanTra.Value),
                new SqlParameter("@MaPhieuMuon", int.Parse(txt_MaPhieuMuon.Text))
            };

            if (string.IsNullOrWhiteSpace(dtp_NgayTra.Text) || dtp_NgayTra.Value > dtp_HanTra.Value)
                parameters.Add(new SqlParameter("@NgayTra", DBNull.Value));
            else
                parameters.Add(new SqlParameter("@NgayTra", dtp_NgayTra.Value));

            int kq = lopchung.ThemSua(sql, parameters);
            if (kq > 0)
                MessageBox.Show("Sửa phiếu mượn thành công");
            else
                MessageBox.Show("Sửa phiếu mượn không thành công");
            LoadPhieuMuon();
        }

        private void dgv_QLThuVien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgv_QLThuVien.Columns[e.ColumnIndex].Name == "NgayTra")
            {
                if (dgv_QLThuVien.Rows[e.RowIndex].IsNewRow) return;

                if (e.Value == null || e.Value == DBNull.Value)
                {
                    e.Value = "Chưa trả";
                    e.FormattingApplied = true;
                }
            }
        }
    }
}
