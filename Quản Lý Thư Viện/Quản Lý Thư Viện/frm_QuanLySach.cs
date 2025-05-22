using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_Lý_Thư_Viện
{
    public partial class frm_QuanLySach : Form
    {
        private LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();

        public frm_QuanLySach()
        {
            InitializeComponent();
        }

        private void frm_QuanLySach_Load(object sender, EventArgs e)
        {
            LoadSach();
        }

        private void LoadSach()
        {
            string sql = "SELECT * FROM Sach";
            dgv_TimKiemSach.DataSource = lopchung.LayDLBang(sql);
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string sql = $"INSERT INTO Sach (MaSach, MaSoSach, TieuDe, TacGia, TheLoai, NamXuatBan, NhaXuatBan, SoLuong) VALUES ({txt_MaSach.Text}, 'S{txt_MaSach.Text}', N'{txt_TenSach.Text}', N'{txt_TacGia.Text}', N'{txt_TheLoai.Text}', {txt_NamXuatBan.Text}, N'{txt_NhaXuatBan.Text}', {txt_SoLuong.Text})";
            int kq = lopchung.ThemSuaXoa(sql);
            if (kq >= 1)
                MessageBox.Show("Thêm sách thành công");
            else
                MessageBox.Show("Thêm sách không thành công");
            LoadSach();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sql = $"UPDATE Sach SET MaSach = {txt_MaSach.Text}, TieuDe = N'{txt_TenSach.Text}', TacGia = N'{txt_TacGia.Text}', TheLoai = N'{txt_TheLoai.Text}', SoLuong = {txt_SoLuong.Text}, NamXuatBan = {txt_NamXuatBan.Text}, NhaXuatBan = N'{txt_NhaXuatBan.Text}' WHERE MaSoSach = 'S{txt_MaSach.Text}'";
            int kq = lopchung.ThemSuaXoa(sql);
            if (kq > 0)
            {
                MessageBox.Show("Sửa sách thành công");
            }
            else
                MessageBox.Show("Sửa sách không thành công");
            LoadSach();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string sql = $"DELETE FROM Sach WHERE MaSach = {txt_MaSach.Text} OR MaSoSach = 'S{txt_MaSach.Text}'";
            int kq = lopchung.ThemSuaXoa(sql);
            if (kq > 0)
            {
                MessageBox.Show("Xóa sách thành công");
            }
            else
                MessageBox.Show("Xóa sách không thành công");
            LoadSach();
        }

        private void dgv_TimKiemSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_TimKiemSach.CurrentRow != null)
            {
                txt_MaSach.Text = dgv_TimKiemSach.CurrentRow.Cells[0].Value.ToString();
                txt_TenSach.Text = dgv_TimKiemSach.CurrentRow.Cells["TieuDe"].Value.ToString();
                txt_TheLoai.Text = dgv_TimKiemSach.CurrentRow.Cells["TheLoai"].Value.ToString();
                txt_TacGia.Text = dgv_TimKiemSach.CurrentRow.Cells["TacGia"].Value.ToString();
                txt_SoLuong.Text = dgv_TimKiemSach.CurrentRow.Cells["SoLuong"].Value.ToString();
                txt_NamXuatBan.Text = dgv_TimKiemSach.CurrentRow.Cells["NamXuatBan"].Value.ToString();
                txt_NhaXuatBan.Text = dgv_TimKiemSach.CurrentRow.Cells["NhaXuatBan"].Value.ToString();
            }
        }

        private void txt_TimKiemSach_TextChanged(object sender, EventArgs e)
        {
            string keyword = txt_TimKiemSach.Text;
            string sql = $"SELECT * FROM Sach WHERE TieuDe LIKE N'%{keyword}%'";
            dgv_TimKiemSach.DataSource = lopchung.LayDLBang(sql);
        }

        private void dgv_TimKiemSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
