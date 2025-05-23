namespace Quản_Lý_Thư_Viện
{
    partial class frm_QuanLyMuonTraSach
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
            this.lbl_MaDG = new System.Windows.Forms.Label();
            this.lbl_MaSach = new System.Windows.Forms.Label();
            this.lbl_TrangThai = new System.Windows.Forms.Label();
            this.lbl_NgayMuon = new System.Windows.Forms.Label();
            this.lbl_NgayTra = new System.Windows.Forms.Label();
            this.txt_MaDG = new System.Windows.Forms.TextBox();
            this.txt_MaSach = new System.Windows.Forms.TextBox();
            this.dtp_NgayMuon = new System.Windows.Forms.DateTimePicker();
            this.dtp_NgayTra = new System.Windows.Forms.DateTimePicker();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.dgv_QLThuVien = new System.Windows.Forms.DataGridView();
            this.dtp_HanTra = new System.Windows.Forms.DateTimePicker();
            this.lbl_HanTra = new System.Windows.Forms.Label();
            this.cmb_TrangThai = new System.Windows.Forms.ComboBox();
            this.lbl_TenSach = new System.Windows.Forms.Label();
            this.txt_MaPhieuMuon = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QLThuVien)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_MaDG
            // 
            this.lbl_MaDG.AutoSize = true;
            this.lbl_MaDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaDG.Location = new System.Drawing.Point(77, 104);
            this.lbl_MaDG.Name = "lbl_MaDG";
            this.lbl_MaDG.Size = new System.Drawing.Size(82, 15);
            this.lbl_MaDG.TabIndex = 0;
            this.lbl_MaDG.Text = "Mã Độc Giả";
            // 
            // lbl_MaSach
            // 
            this.lbl_MaSach.AutoSize = true;
            this.lbl_MaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaSach.Location = new System.Drawing.Point(77, 164);
            this.lbl_MaSach.Name = "lbl_MaSach";
            this.lbl_MaSach.Size = new System.Drawing.Size(63, 15);
            this.lbl_MaSach.TabIndex = 1;
            this.lbl_MaSach.Text = "Mã Sách";
            // 
            // lbl_TrangThai
            // 
            this.lbl_TrangThai.AutoSize = true;
            this.lbl_TrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TrangThai.Location = new System.Drawing.Point(77, 227);
            this.lbl_TrangThai.Name = "lbl_TrangThai";
            this.lbl_TrangThai.Size = new System.Drawing.Size(76, 15);
            this.lbl_TrangThai.TabIndex = 3;
            this.lbl_TrangThai.Text = "Trạng Thái";
            // 
            // lbl_NgayMuon
            // 
            this.lbl_NgayMuon.AutoSize = true;
            this.lbl_NgayMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NgayMuon.Location = new System.Drawing.Point(435, 44);
            this.lbl_NgayMuon.Name = "lbl_NgayMuon";
            this.lbl_NgayMuon.Size = new System.Drawing.Size(115, 15);
            this.lbl_NgayMuon.TabIndex = 4;
            this.lbl_NgayMuon.Text = "Ngày Mượn Sách";
            // 
            // lbl_NgayTra
            // 
            this.lbl_NgayTra.AutoSize = true;
            this.lbl_NgayTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NgayTra.Location = new System.Drawing.Point(435, 104);
            this.lbl_NgayTra.Name = "lbl_NgayTra";
            this.lbl_NgayTra.Size = new System.Drawing.Size(100, 15);
            this.lbl_NgayTra.TabIndex = 5;
            this.lbl_NgayTra.Text = "Ngày Trả Sách";
            // 
            // txt_MaDG
            // 
            this.txt_MaDG.Location = new System.Drawing.Point(195, 101);
            this.txt_MaDG.Name = "txt_MaDG";
            this.txt_MaDG.Size = new System.Drawing.Size(193, 20);
            this.txt_MaDG.TabIndex = 6;
            // 
            // txt_MaSach
            // 
            this.txt_MaSach.Location = new System.Drawing.Point(195, 161);
            this.txt_MaSach.Name = "txt_MaSach";
            this.txt_MaSach.Size = new System.Drawing.Size(193, 20);
            this.txt_MaSach.TabIndex = 7;
            // 
            // dtp_NgayMuon
            // 
            this.dtp_NgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgayMuon.Location = new System.Drawing.Point(574, 44);
            this.dtp_NgayMuon.Name = "dtp_NgayMuon";
            this.dtp_NgayMuon.Size = new System.Drawing.Size(152, 20);
            this.dtp_NgayMuon.TabIndex = 10;
            // 
            // dtp_NgayTra
            // 
            this.dtp_NgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgayTra.Location = new System.Drawing.Point(574, 104);
            this.dtp_NgayTra.Name = "dtp_NgayTra";
            this.dtp_NgayTra.Size = new System.Drawing.Size(152, 20);
            this.dtp_NgayTra.TabIndex = 11;
            // 
            // btn_Them
            // 
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(455, 218);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(99, 31);
            this.btn_Them.TabIndex = 12;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Location = new System.Drawing.Point(612, 218);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(99, 31);
            this.btn_Sua.TabIndex = 13;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // dgv_QLThuVien
            // 
            this.dgv_QLThuVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_QLThuVien.Location = new System.Drawing.Point(1, 282);
            this.dgv_QLThuVien.Name = "dgv_QLThuVien";
            this.dgv_QLThuVien.Size = new System.Drawing.Size(805, 169);
            this.dgv_QLThuVien.TabIndex = 14;
            this.dgv_QLThuVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_QLThuVien_CellClick);
            this.dgv_QLThuVien.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_QLThuVien_CellFormatting);
            // 
            // dtp_HanTra
            // 
            this.dtp_HanTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_HanTra.Location = new System.Drawing.Point(574, 164);
            this.dtp_HanTra.Name = "dtp_HanTra";
            this.dtp_HanTra.Size = new System.Drawing.Size(152, 20);
            this.dtp_HanTra.TabIndex = 16;
            // 
            // lbl_HanTra
            // 
            this.lbl_HanTra.AutoSize = true;
            this.lbl_HanTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HanTra.Location = new System.Drawing.Point(435, 164);
            this.lbl_HanTra.Name = "lbl_HanTra";
            this.lbl_HanTra.Size = new System.Drawing.Size(58, 15);
            this.lbl_HanTra.TabIndex = 15;
            this.lbl_HanTra.Text = "Hạn Trả";
            // 
            // cmb_TrangThai
            // 
            this.cmb_TrangThai.FormattingEnabled = true;
            this.cmb_TrangThai.Location = new System.Drawing.Point(195, 228);
            this.cmb_TrangThai.Name = "cmb_TrangThai";
            this.cmb_TrangThai.Size = new System.Drawing.Size(193, 21);
            this.cmb_TrangThai.TabIndex = 17;
            // 
            // lbl_TenSach
            // 
            this.lbl_TenSach.AutoSize = true;
            this.lbl_TenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenSach.Location = new System.Drawing.Point(77, 41);
            this.lbl_TenSach.Name = "lbl_TenSach";
            this.lbl_TenSach.Size = new System.Drawing.Size(108, 15);
            this.lbl_TenSach.TabIndex = 2;
            this.lbl_TenSach.Text = "Mã Phiếu Mượn";
            // 
            // txt_MaPhieuMuon
            // 
            this.txt_MaPhieuMuon.Location = new System.Drawing.Point(195, 38);
            this.txt_MaPhieuMuon.Name = "txt_MaPhieuMuon";
            this.txt_MaPhieuMuon.Size = new System.Drawing.Size(193, 20);
            this.txt_MaPhieuMuon.TabIndex = 8;
            // 
            // frm_QuanLyMuonTraSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmb_TrangThai);
            this.Controls.Add(this.dtp_HanTra);
            this.Controls.Add(this.lbl_HanTra);
            this.Controls.Add(this.dgv_QLThuVien);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.dtp_NgayTra);
            this.Controls.Add(this.dtp_NgayMuon);
            this.Controls.Add(this.txt_MaPhieuMuon);
            this.Controls.Add(this.txt_MaSach);
            this.Controls.Add(this.txt_MaDG);
            this.Controls.Add(this.lbl_NgayTra);
            this.Controls.Add(this.lbl_NgayMuon);
            this.Controls.Add(this.lbl_TrangThai);
            this.Controls.Add(this.lbl_TenSach);
            this.Controls.Add(this.lbl_MaSach);
            this.Controls.Add(this.lbl_MaDG);
            this.Name = "frm_QuanLyMuonTraSach";
            this.Text = "frm_QuanLyMuonTraSach";
            this.Load += new System.EventHandler(this.frm_QuanLyMuonTraSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QLThuVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_MaDG;
        private System.Windows.Forms.Label lbl_MaSach;
        private System.Windows.Forms.Label lbl_TrangThai;
        private System.Windows.Forms.Label lbl_NgayMuon;
        private System.Windows.Forms.Label lbl_NgayTra;
        private System.Windows.Forms.TextBox txt_MaDG;
        private System.Windows.Forms.TextBox txt_MaSach;
        private System.Windows.Forms.DateTimePicker dtp_NgayMuon;
        private System.Windows.Forms.DateTimePicker dtp_NgayTra;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.DataGridView dgv_QLThuVien;
        private System.Windows.Forms.DateTimePicker dtp_HanTra;
        private System.Windows.Forms.Label lbl_HanTra;
        private System.Windows.Forms.ComboBox cmb_TrangThai;
        private System.Windows.Forms.Label lbl_TenSach;
        private System.Windows.Forms.TextBox txt_MaPhieuMuon;
    }
}