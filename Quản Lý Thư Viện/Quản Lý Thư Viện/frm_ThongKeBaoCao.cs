using Quản_Lý_Thư_Viện;
using System;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLyThuVien
{
    public partial class frm_ThongKeBaoCao : Form
    {
       
        private LopDungChung lopChung = new LopDungChung(); 

        public frm_ThongKeBaoCao()
        {
            InitializeComponent();
        }

        private void frm_ThongKeBaoCao_Load(object sender, EventArgs e)
        {
            LoadSachDangMuon();
            LoadSachMuonNhieu();
            LoadDocGiaTreHan();
        }

        private void LoadSachDangMuon()
        {
            string query = @"
                SELECT b.MaSoSach AS [Mã Sách], b.TieuDe AS [Tên Sách], r.HoTen AS [Người Mượn], br.NgayMuon AS [Ngày Mượn]
                FROM PhieuMuon br
                JOIN Sach b ON br.MaSach = b.MaSach
                JOIN DocGia r ON br.MaDocGia = r.MaDocGia
                WHERE br.TrangThai = N'Đang Mượn'";

            dgvSachDangMuon.DataSource = lopChung.LayDLBang(query);
        }

        private void LoadSachMuonNhieu()
        {
            string query = @"
                SELECT b.TieuDe, COUNT(*) AS SoLanMuon
                FROM PhieuMuon br
                JOIN Sach b ON br.MaSach = b.MaSach
                GROUP BY b.TieuDe
                ORDER BY SoLanMuon DESC";

            DataTable dt = lopChung.LayDLBang(query);

            chartSachMuonNhieu.Series["Sách mượn"].Points.Clear();
            foreach (DataRow row in dt.Rows)
            {
                chartSachMuonNhieu.Series["Sách mượn"].Points.AddXY(row["TieuDe"], row["SoLanMuon"]);
            }
        }

        private void LoadDocGiaTreHan()
        {
            string query = @"
                SELECT r.HoTen AS [Họ tên], b.TieuDe AS [Tên sách], br.NgayMuon AS [Ngày mượn], br.HanTra AS [Hạn trả]
                FROM PhieuMuon br
                JOIN Sach b ON br.MaSach = b.MaSach
                JOIN DocGia r ON br.MaDocGia = r.MaDocGia
                WHERE br.TrangThai = N'Đang Mượn' AND br.NgayTra IS NULL AND br.HanTra < GETDATE()";

            dgvTreHan.DataSource = lopChung.LayDLBang(query);
        }

        private void dgvSachDangMuon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void MenuDocGia_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frm_QuanLyDocGia().ShowDialog();
            this.Show();
        }

        private void MenuMuonTra_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frm_QuanLyMuonTraSach().ShowDialog();
            this.Show();
        }

        private void MenuSach_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frm_QuanLySach().ShowDialog();
            this.Show();
        }

        private void MenuDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frm_DangNhap().Show();
        }

        private void MenuThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgvTreHan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
