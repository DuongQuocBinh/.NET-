namespace Quản_Lý_Thư_Viện
{
    partial class frm_DangNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.piccapcha = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_DangNhap = new Guna.UI2.WinForms.Guna2Button();
            this.txt_tendangnhap = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_matkhau = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_maxacnhan = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_LamMoiMaXacNhan = new Guna.UI2.WinForms.Guna2Button();
            this.linkDangKi = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.piccapcha)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 235);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 298);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(144, 45);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(732, 44);
            this.label4.TabIndex = 8;
            this.label4.Text = "CHÀO MỪNG ĐẾN VỚI THƯ VIỆN XANH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(74, 355);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Mã xác nhận";
            // 
            // piccapcha
            // 
            this.piccapcha.Location = new System.Drawing.Point(573, 351);
            this.piccapcha.Name = "piccapcha";
            this.piccapcha.Size = new System.Drawing.Size(132, 37);
            this.piccapcha.TabIndex = 11;
            this.piccapcha.TabStop = false;
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.BorderRadius = 15;
            this.btn_DangNhap.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_DangNhap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_DangNhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_DangNhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_DangNhap.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_DangNhap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_DangNhap.ForeColor = System.Drawing.Color.White;
            this.btn_DangNhap.Location = new System.Drawing.Point(320, 462);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(119, 48);
            this.btn_DangNhap.TabIndex = 12;
            this.btn_DangNhap.Text = "Login";
            this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
            // 
            // txt_tendangnhap
            // 
            this.txt_tendangnhap.BorderRadius = 15;
            this.txt_tendangnhap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tendangnhap.DefaultText = "";
            this.txt_tendangnhap.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_tendangnhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_tendangnhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_tendangnhap.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_tendangnhap.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_tendangnhap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_tendangnhap.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_tendangnhap.Location = new System.Drawing.Point(268, 228);
            this.txt_tendangnhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_tendangnhap.Name = "txt_tendangnhap";
            this.txt_tendangnhap.PlaceholderText = "";
            this.txt_tendangnhap.SelectedText = "";
            this.txt_tendangnhap.Size = new System.Drawing.Size(266, 32);
            this.txt_tendangnhap.TabIndex = 13;
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.BorderRadius = 15;
            this.txt_matkhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_matkhau.DefaultText = "";
            this.txt_matkhau.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_matkhau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_matkhau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_matkhau.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_matkhau.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_matkhau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_matkhau.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_matkhau.Location = new System.Drawing.Point(268, 291);
            this.txt_matkhau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.PlaceholderText = "";
            this.txt_matkhau.SelectedText = "";
            this.txt_matkhau.Size = new System.Drawing.Size(266, 32);
            this.txt_matkhau.TabIndex = 14;
            // 
            // txt_maxacnhan
            // 
            this.txt_maxacnhan.BorderRadius = 15;
            this.txt_maxacnhan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_maxacnhan.DefaultText = "";
            this.txt_maxacnhan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_maxacnhan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_maxacnhan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_maxacnhan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_maxacnhan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_maxacnhan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_maxacnhan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_maxacnhan.Location = new System.Drawing.Point(268, 349);
            this.txt_maxacnhan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_maxacnhan.Name = "txt_maxacnhan";
            this.txt_maxacnhan.PlaceholderText = "";
            this.txt_maxacnhan.SelectedText = "";
            this.txt_maxacnhan.Size = new System.Drawing.Size(266, 31);
            this.txt_maxacnhan.TabIndex = 15;
            // 
            // btn_LamMoiMaXacNhan
            // 
            this.btn_LamMoiMaXacNhan.BorderRadius = 15;
            this.btn_LamMoiMaXacNhan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_LamMoiMaXacNhan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_LamMoiMaXacNhan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_LamMoiMaXacNhan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_LamMoiMaXacNhan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_LamMoiMaXacNhan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_LamMoiMaXacNhan.ForeColor = System.Drawing.Color.White;
            this.btn_LamMoiMaXacNhan.Location = new System.Drawing.Point(741, 342);
            this.btn_LamMoiMaXacNhan.Name = "btn_LamMoiMaXacNhan";
            this.btn_LamMoiMaXacNhan.Size = new System.Drawing.Size(119, 46);
            this.btn_LamMoiMaXacNhan.TabIndex = 16;
            this.btn_LamMoiMaXacNhan.Text = "Làm mới ";
            this.btn_LamMoiMaXacNhan.Click += new System.EventHandler(this.btn_LamMoiMaXacNhan_Click_1);
            // 
            // linkDangKi
            // 
            this.linkDangKi.BackColor = System.Drawing.Color.Transparent;
            this.linkDangKi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkDangKi.Location = new System.Drawing.Point(268, 406);
            this.linkDangKi.Name = "linkDangKi";
            this.linkDangKi.Size = new System.Drawing.Size(358, 27);
            this.linkDangKi.TabIndex = 17;
            this.linkDangKi.Text = "Chưa có tài khoản ? Đăng kí tại đây !";
            this.linkDangKi.Click += new System.EventHandler(this.linkDangKi_LinkClicked);
            // 
            // frm_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1300, 703);
            this.Controls.Add(this.linkDangKi);
            this.Controls.Add(this.btn_LamMoiMaXacNhan);
            this.Controls.Add(this.txt_maxacnhan);
            this.Controls.Add(this.txt_matkhau);
            this.Controls.Add(this.txt_tendangnhap);
            this.Controls.Add(this.btn_DangNhap);
            this.Controls.Add(this.piccapcha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frm_DangNhap";
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.frm_DangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.piccapcha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox piccapcha;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI2.WinForms.Guna2Button btn_DangNhap;
        private Guna.UI2.WinForms.Guna2TextBox txt_tendangnhap;
        private Guna.UI2.WinForms.Guna2TextBox txt_matkhau;
        private Guna.UI2.WinForms.Guna2TextBox txt_maxacnhan;
        private Guna.UI2.WinForms.Guna2Button btn_LamMoiMaXacNhan;
        private Guna.UI2.WinForms.Guna2HtmlLabel linkDangKi;
    }
}