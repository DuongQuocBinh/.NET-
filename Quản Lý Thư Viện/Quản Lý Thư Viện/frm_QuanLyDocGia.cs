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
    public partial class frm_QuanLyDocGia: Form
    {
        public frm_QuanLyDocGia()
        {
            InitializeComponent();
        }
        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string sql = $"INSERT INTO DocGia values ('" + txt_MaDocGia.Text + "',N'" + txt_HoTen.Text + "',Convert(datetime,N'" + dt_NgaySinh.Text + "',103),'" + cb_GioiTinh.Text + "', N'" + txt_Lop.Text + "', N'" + txt_SoDienThoai.Text + "', '" + cb_LoaiDocGia.Text + "')";
            int kq = lopchung.ThemSuaXoa(sql);
            if (kq >= 1)
                MessageBox.Show("Thêm độc giả thành công");
            else
                MessageBox.Show("Thêm độc giả không thành công");
            LoadDocGia();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sql = $"UPDATE DocGia SET HoTen = N'" + txt_HoTen.Text + "', NgaySinh = Convert(datetime,N'" + dt_NgaySinh.Text + "',103), GioiTinh = N'" + cb_GioiTinh.Text + "', Lop = N'" + txt_Lop.Text + "',  SoDienThoai = '" + txt_SoDienThoai.Text + "', LoaiDocGia = N'" + cb_LoaiDocGia.Text + "' WHERE MaSoDocGia = '" + txt_MaDocGia.Text + "'";
            int kq = lopchung.ThemSuaXoa(sql);
            if (kq > 0)
            {
                MessageBox.Show("Sửa độc giả thành công");
            }
            else
                MessageBox.Show("Sửa độc giả không thành công");
            LoadDocGia();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM DocGia WHERE MaSoDocGia = '" + txt_MaDocGia.Text + "'";
            int kq = lopchung.ThemSuaXoa(sql);
            if (kq > 0)
            {
                MessageBox.Show("Xóa độc giả thành công");
            }
            else
                MessageBox.Show("Xóa độc giả không thành công");
            LoadDocGia();
        }

        public void LoadDocGia()
        {
            string sql = "Select * from DocGia";
            dataGridView1.DataSource = lopchung.LayDLBang(sql);
        }

        private void frm_QuanLyDocGia_Load(object sender, EventArgs e)
        {
            LoadDocGia();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaDocGia.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_HoTen.Text = dataGridView1.CurrentRow.Cells["HoTen"].Value.ToString();
            cb_GioiTinh.SelectedValue = dataGridView1.CurrentRow.Cells["GioiTinh"].Value.ToString();
            dt_NgaySinh.Text = dataGridView1.CurrentRow.Cells["NgaySinh"].Value.ToString();
            txt_Lop.Text = dataGridView1.CurrentRow.Cells["Lop"].Value.ToString();
            txt_SoDienThoai.Text = dataGridView1.CurrentRow.Cells["SoDienThoai"].Value.ToString();
            cb_LoaiDocGia.SelectedValue = dataGridView1.CurrentRow.Cells["LoaiDocGia"].Value.ToString();
        }
    }
}
