using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.SqlClient;

namespace Quản_Lý_Thư_Viện
{
    public partial class frm_DangNhap : Form
    {
        Lop_dung_chung ldc = new Lop_dung_chung();
        private string captchaCode = "";

        public frm_DangNhap()
        {
            InitializeComponent();
            linkDangKi.LinkClicked += linkDangKi_LinkClicked;

        }

        private void GenerateCaptcha()
        {
            Random rand = new Random();
            captchaCode = rand.Next(1000, 9999).ToString();

            Bitmap bmp = new Bitmap(100, 40);
            Graphics g = Graphics.FromImage(bmp);
            g.Clear(Color.White);
            Font font = new Font("Arial", 20, FontStyle.Bold);
            g.DrawString(captchaCode, font, Brushes.Brown, 10, 5);
            piccapcha.Image = bmp;
        }

        private void frm_DangNhap_Load(object sender, EventArgs e)
        {
            GenerateCaptcha();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            if (txt_maxacnhan.Text != captchaCode)
            {
                MessageBox.Show("Mã xác nhận không đúng!");
                GenerateCaptcha();
                return;
            }

            string username = txt_tendangnhap.Text.Trim();
            string password = txt_matkhau.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu.");
                return;
            }

            
            username = username.Replace("'", "''");

            string hashedPassword = ldc.EncodePassword(password);
            string query = $"SELECT VaiTro FROM Users WHERE TenDangNhap = '{username}' AND MatKhau = '{hashedPassword}'";

            
            DataTable dt = ldc.LayDLBang(query);

            if (dt.Rows.Count > 0)
            {
                string role = dt.Rows[0]["Role"].ToString();
                MessageBox.Show("Đăng nhập thành công!");
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_tendangnhap.Clear();
                txt_matkhau.Clear();
                GenerateCaptcha();
            }
        }

        private void btn_LamMoiMaXacNhan_Click_1(object sender, EventArgs e)
        {
            GenerateCaptcha();
        }
        private void linkDangKi_LinkClicked(object sender, EventArgs e)
        {
            frm_DangKi frm = new frm_DangKi();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
    }
}
