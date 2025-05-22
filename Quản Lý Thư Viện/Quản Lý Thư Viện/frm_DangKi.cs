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
        public partial class frm_DangKi: Form
        {
             Lop_dung_chung ldc = new Lop_dung_chung();
        public frm_DangKi()
            {
                InitializeComponent();
               
            }

            private void btn_DangKi_Click(object sender, EventArgs e)
            {
                string hoten = txt_HoTen.Text.Trim();
                string tendangnhap = txt_TenDangNhap.Text.Trim();
                string matkhau = txt_MatKhau.Text.Trim();
                string nhaplaimatkhau = txt_Nhaplaimatkhau.Text.Trim();
                string email = txt_Email.Text.Trim();
                string diachi = txt_DiaChi.Text.Trim();
                dte_NgaySinh.Value = DateTime.Now;

                if(string.IsNullOrEmpty(hoten) || string.IsNullOrEmpty(tendangnhap) || string.IsNullOrEmpty(matkhau) || string.IsNullOrEmpty(nhaplaimatkhau) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(diachi))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                    return;
                }
                if (matkhau != nhaplaimatkhau)
                {
                    MessageBox.Show("Mật khẩu không khớp.");
                    return;
                }
                if (matkhau.Length < 6)
                {
                    MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự.");
                    return;
                }

                string query = $"INSERT INTO Users (HoTen, TenDangNhap, MatKhau, Email, DiaChi, NgaySinh) VALUES ('{hoten}', '{tendangnhap}', '{matkhau}', '{email}', '{diachi}', '{dte_NgaySinh.Value.ToString("yyyy-MM-dd")}')";

                bool isSuccess = ldc.ThucThi(query);
                if (isSuccess)
                {
                    MessageBox.Show("Đăng ký thành công.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đăng ký thất bại.");
                }
                KiemTraGioiTinh();
        }

            private void btn_Reset_Click(object sender, EventArgs e)
            {
                txt_HoTen.Clear();
                txt_TenDangNhap.Clear();
                txt_MatKhau.Clear();
                txt_Nhaplaimatkhau.Clear();
                rdo_Nam.Checked = false;
                rdo_Nu.Checked = false;
                txt_Email.Clear();
                txt_DiaChi.Clear();
                dte_NgaySinh.Value = DateTime.Now;

            }

            private void btn_DangNhap_Click(object sender, EventArgs e)
            {
                string hashPassword = ldc.EncodePassword(txt_MatKhau.Text.Trim());
                this.Hide();
                frm_DangNhap dangnhap = new frm_DangNhap();
                dangnhap.ShowDialog();
                this.Close();

            }
        private void txt_MatKhau_Leave(object sender, EventArgs e)
        {
           string matkhau = txt_MatKhau.Text.Trim();
            if (matkhau.Length < 6)
            {
                lbl_CheckMatkhau.Text = "Mật khẩu phải có ít nhất 6 ký tự.";
                lbl_CheckMatkhau.ForeColor = Color.Red;
                lbl_CheckMatkhau.Visible = true;
            }
            else
            {
                lbl_CheckMatkhau.Text = "Mật khẩu hợp lệ.";
                lbl_CheckMatkhau.ForeColor = Color.Green;
                lbl_CheckMatkhau.Visible = true;
            }
        }
        private void txt_Hoten_Leave(object sender, EventArgs e)
        {
            string hoten = txt_HoTen.Text.Trim();
            if (string.IsNullOrEmpty(hoten))
            {
                lbl_CheckHoTen.Text = "Họ tên không được để trống.";
                lbl_CheckHoTen.ForeColor = Color.Red;
                lbl_CheckHoTen.Visible = true;
            }
            else
            {
                lbl_CheckHoTen.Text = "Họ tên hợp lệ.";
                lbl_CheckHoTen.ForeColor = Color.Green;
                lbl_CheckHoTen.Visible = true;
            }
        }
        private void txt_TenDangNhap_Leave(object sender, EventArgs e)
        {
            string tendangnhap = txt_TenDangNhap.Text.Trim();
            if (string.IsNullOrEmpty(tendangnhap))
            {
               lb_CheckTenDangNhap.Text = "Tên đăng nhập không được để trống.";
               lb_CheckTenDangNhap.ForeColor = Color.Red;
               lb_CheckTenDangNhap.Visible = true;
            }
            else
            {
                lb_CheckTenDangNhap.Text = "Tên đăng nhập hợp lệ.";
                lb_CheckTenDangNhap.ForeColor = Color.Green;
                lb_CheckTenDangNhap.Visible = true;
            }
        }
        private void txt_Nhaplaimatkhau_Leave(object sender, EventArgs e)
        {
            string matkhau = txt_MatKhau.Text.Trim();
            string nhaplaimatkhau = txt_Nhaplaimatkhau.Text.Trim();
            if (nhaplaimatkhau != matkhau)
            {
                lb_CheckNhapLaiMatKhau.Text = "Mật khẩu không khớp.";
                lb_CheckNhapLaiMatKhau.ForeColor = Color.Red;
                lb_CheckNhapLaiMatKhau.Visible = true;
            }
            else
            {
                lb_CheckNhapLaiMatKhau.Text = "Mật khẩu khớp.";
                lb_CheckNhapLaiMatKhau.ForeColor = Color.Green;
                lb_CheckNhapLaiMatKhau.Visible = true;
            }
        }
        private void KiemTraGioiTinh()
        {
            if (!rdo_Nam.Checked && !rdo_Nu.Checked)
            {
                lb_CheckGioiTinh.Text = "Vui lòng chọn giới tính.";
                lb_CheckGioiTinh.ForeColor = Color.Red;
                lb_CheckGioiTinh.Visible = true;
            }
            else
            {
                lb_CheckGioiTinh.Text = "✔";
                lb_CheckGioiTinh.ForeColor = Color.Green;
            }

            lb_CheckGioiTinh.Visible = true;
        }
        private void txt_Email_Leave(object sender, EventArgs e)
        {
            string email = txt_Email.Text.Trim();
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (string.IsNullOrEmpty(email))
            {
                lb_CheckEmail.Text = "Vui lòng nhập email.";
                lb_CheckEmail.ForeColor = Color.Red;
                lb_CheckEmail.Visible = true;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(email, pattern))
            {
                lb_CheckEmail.Text = "Email không đúng định dạng.";
                lb_CheckEmail.ForeColor = Color.Red;
                lb_CheckEmail.Visible = true;
            }
            else
            {
                lb_CheckEmail.Visible = false;
            }
        }
        private void txt_DiaChi_Leave(object sender, EventArgs e)
        {
            string diachi = txt_DiaChi.Text.Trim();
            if (string.IsNullOrEmpty(diachi))
            {
                lb_CheckDiachi.Text = "Địa chỉ không được để trống.";
                lb_CheckDiachi.ForeColor = Color.Red;
                lb_CheckDiachi.Visible = true;
            }
            else
            {
                lb_CheckDiachi.Visible = false;
            }
        }
        private void frm_DangKi_Load(object sender, EventArgs e)
        {
            txt_HoTen.Leave += txt_Hoten_Leave;
            txt_TenDangNhap.Leave += txt_TenDangNhap_Leave;
            txt_MatKhau.Leave += txt_MatKhau_Leave;
            txt_Nhaplaimatkhau.Leave += txt_Nhaplaimatkhau_Leave;
            txt_Email.Leave += txt_Email_Leave;
            txt_DiaChi.Leave += txt_DiaChi_Leave;
      
        }
    }
}
