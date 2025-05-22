namespace Quản_Lý_Thư_Viện
{
    partial class frm_QuanLySach
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
            this.MaSach = new System.Windows.Forms.Label();
            this.txt_MaSach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TenSach = new System.Windows.Forms.Label();
            this.txt_TenSach = new System.Windows.Forms.TextBox();
            this.TacGia = new System.Windows.Forms.Label();
            this.txt_TacGia = new System.Windows.Forms.TextBox();
            this.TheLoai = new System.Windows.Forms.Label();
            this.txt_TheLoai = new System.Windows.Forms.TextBox();
            this.NamxuatBan = new System.Windows.Forms.Label();
            this.txt_SoLuong = new System.Windows.Forms.TextBox();
            this.NhaXuatBan = new System.Windows.Forms.Label();
            this.txt_NamXuatBan = new System.Windows.Forms.TextBox();
            this.SoLuong = new System.Windows.Forms.Label();
            this.txt_NhaXuatBan = new System.Windows.Forms.TextBox();
            this.TimKiemSach = new System.Windows.Forms.Label();
            this.dgv_TimKiemSach = new System.Windows.Forms.DataGridView();
            this.txt_TimKiemSach = new System.Windows.Forms.TextBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TimKiemSach)).BeginInit();
            this.SuspendLayout();
            // 
            // MaSach
            // 
            this.MaSach.AutoSize = true;
            this.MaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaSach.Location = new System.Drawing.Point(39, 103);
            this.MaSach.Name = "MaSach";
            this.MaSach.Size = new System.Drawing.Size(89, 20);
            this.MaSach.TabIndex = 0;
            this.MaSach.Text = "Mã Sách :";
            // 
            // txt_MaSach
            // 
            this.txt_MaSach.Location = new System.Drawing.Point(163, 97);
            this.txt_MaSach.Name = "txt_MaSach";
            this.txt_MaSach.Size = new System.Drawing.Size(189, 26);
            this.txt_MaSach.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(323, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quản Lý Sách ";
            // 
            // TenSach
            // 
            this.TenSach.AutoSize = true;
            this.TenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenSach.Location = new System.Drawing.Point(39, 142);
            this.TenSach.Name = "TenSach";
            this.TenSach.Size = new System.Drawing.Size(95, 20);
            this.TenSach.TabIndex = 3;
            this.TenSach.Text = "Tên Sách :";
            // 
            // txt_TenSach
            // 
            this.txt_TenSach.Location = new System.Drawing.Point(163, 136);
            this.txt_TenSach.Name = "txt_TenSach";
            this.txt_TenSach.Size = new System.Drawing.Size(189, 26);
            this.txt_TenSach.TabIndex = 4;
            // 
            // TacGia
            // 
            this.TacGia.AutoSize = true;
            this.TacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TacGia.Location = new System.Drawing.Point(39, 181);
            this.TacGia.Name = "TacGia";
            this.TacGia.Size = new System.Drawing.Size(76, 20);
            this.TacGia.TabIndex = 5;
            this.TacGia.Text = "Tác Giả:";
            // 
            // txt_TacGia
            // 
            this.txt_TacGia.Location = new System.Drawing.Point(163, 175);
            this.txt_TacGia.Name = "txt_TacGia";
            this.txt_TacGia.Size = new System.Drawing.Size(189, 26);
            this.txt_TacGia.TabIndex = 6;
            // 
            // TheLoai
            // 
            this.TheLoai.AutoSize = true;
            this.TheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TheLoai.Location = new System.Drawing.Point(39, 220);
            this.TheLoai.Name = "TheLoai";
            this.TheLoai.Size = new System.Drawing.Size(88, 20);
            this.TheLoai.TabIndex = 7;
            this.TheLoai.Text = "Thể Loại :";
            // 
            // txt_TheLoai
            // 
            this.txt_TheLoai.Location = new System.Drawing.Point(163, 214);
            this.txt_TheLoai.Name = "txt_TheLoai";
            this.txt_TheLoai.Size = new System.Drawing.Size(189, 26);
            this.txt_TheLoai.TabIndex = 8;
            // 
            // NamxuatBan
            // 
            this.NamxuatBan.AutoSize = true;
            this.NamxuatBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamxuatBan.Location = new System.Drawing.Point(39, 293);
            this.NamxuatBan.Name = "NamxuatBan";
            this.NamxuatBan.Size = new System.Drawing.Size(135, 20);
            this.NamxuatBan.TabIndex = 9;
            this.NamxuatBan.Text = "Năm Xuất Bản :";
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.Location = new System.Drawing.Point(162, 251);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(189, 26);
            this.txt_SoLuong.TabIndex = 10;
            // 
            // NhaXuatBan
            // 
            this.NhaXuatBan.AutoSize = true;
            this.NhaXuatBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NhaXuatBan.Location = new System.Drawing.Point(39, 335);
            this.NhaXuatBan.Name = "NhaXuatBan";
            this.NhaXuatBan.Size = new System.Drawing.Size(131, 20);
            this.NhaXuatBan.TabIndex = 11;
            this.NhaXuatBan.Text = "Nhà Xuất Bản :";
            // 
            // txt_NamXuatBan
            // 
            this.txt_NamXuatBan.Location = new System.Drawing.Point(162, 290);
            this.txt_NamXuatBan.Name = "txt_NamXuatBan";
            this.txt_NamXuatBan.Size = new System.Drawing.Size(189, 26);
            this.txt_NamXuatBan.TabIndex = 12;
            // 
            // SoLuong
            // 
            this.SoLuong.AutoSize = true;
            this.SoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoLuong.Location = new System.Drawing.Point(39, 254);
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Size = new System.Drawing.Size(91, 20);
            this.SoLuong.TabIndex = 13;
            this.SoLuong.Text = "Số Lượng:";
            // 
            // txt_NhaXuatBan
            // 
            this.txt_NhaXuatBan.Location = new System.Drawing.Point(163, 332);
            this.txt_NhaXuatBan.Name = "txt_NhaXuatBan";
            this.txt_NhaXuatBan.Size = new System.Drawing.Size(189, 26);
            this.txt_NhaXuatBan.TabIndex = 14;
            // 
            // TimKiemSach
            // 
            this.TimKiemSach.AutoSize = true;
            this.TimKiemSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimKiemSach.Location = new System.Drawing.Point(462, 97);
            this.TimKiemSach.Name = "TimKiemSach";
            this.TimKiemSach.Size = new System.Drawing.Size(137, 20);
            this.TimKiemSach.TabIndex = 15;
            this.TimKiemSach.Text = "Tìm Kiếm Sách :";
            // 
            // dgv_TimKiemSach
            // 
            this.dgv_TimKiemSach.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgv_TimKiemSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TimKiemSach.Location = new System.Drawing.Point(379, 136);
            this.dgv_TimKiemSach.Name = "dgv_TimKiemSach";
            this.dgv_TimKiemSach.RowHeadersWidth = 62;
            this.dgv_TimKiemSach.RowTemplate.Height = 28;
            this.dgv_TimKiemSach.Size = new System.Drawing.Size(509, 302);
            this.dgv_TimKiemSach.TabIndex = 16;
            this.dgv_TimKiemSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_TimKiemSach_CellClick);
            this.dgv_TimKiemSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_TimKiemSach_CellContentClick);
            // 
            // txt_TimKiemSach
            // 
            this.txt_TimKiemSach.Location = new System.Drawing.Point(590, 91);
            this.txt_TimKiemSach.Name = "txt_TimKiemSach";
            this.txt_TimKiemSach.Size = new System.Drawing.Size(189, 26);
            this.txt_TimKiemSach.TabIndex = 17;
            this.txt_TimKiemSach.TextChanged += new System.EventHandler(this.txt_TimKiemSach_TextChanged);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(170, 463);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(103, 42);
            this.btn_Them.TabIndex = 18;
            this.btn_Them.Text = "Thêm ";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Location = new System.Drawing.Point(379, 463);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(103, 42);
            this.btn_Sua.TabIndex = 19;
            this.btn_Sua.Text = "Sửa ";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(574, 463);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(103, 42);
            this.btn_Xoa.TabIndex = 20;
            this.btn_Xoa.Text = "Xóa ";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // frm_QuanLySach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.txt_TimKiemSach);
            this.Controls.Add(this.dgv_TimKiemSach);
            this.Controls.Add(this.TimKiemSach);
            this.Controls.Add(this.txt_NhaXuatBan);
            this.Controls.Add(this.SoLuong);
            this.Controls.Add(this.txt_NamXuatBan);
            this.Controls.Add(this.NhaXuatBan);
            this.Controls.Add(this.txt_SoLuong);
            this.Controls.Add(this.NamxuatBan);
            this.Controls.Add(this.txt_TheLoai);
            this.Controls.Add(this.TheLoai);
            this.Controls.Add(this.txt_TacGia);
            this.Controls.Add(this.TacGia);
            this.Controls.Add(this.txt_TenSach);
            this.Controls.Add(this.TenSach);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_MaSach);
            this.Controls.Add(this.MaSach);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_QuanLySach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.frm_QuanLySach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TimKiemSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MaSach;
        private System.Windows.Forms.TextBox txt_MaSach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TenSach;
        private System.Windows.Forms.TextBox txt_TenSach;
        private System.Windows.Forms.Label TacGia;
        private System.Windows.Forms.TextBox txt_TacGia;
        private System.Windows.Forms.Label TheLoai;
        private System.Windows.Forms.TextBox txt_TheLoai;
        private System.Windows.Forms.Label NamxuatBan;
        private System.Windows.Forms.TextBox txt_SoLuong;
        private System.Windows.Forms.Label NhaXuatBan;
        private System.Windows.Forms.TextBox txt_NamXuatBan;
        private System.Windows.Forms.Label SoLuong;
        private System.Windows.Forms.TextBox txt_NhaXuatBan;
        private System.Windows.Forms.Label TimKiemSach;
        private System.Windows.Forms.DataGridView dgv_TimKiemSach;
        private System.Windows.Forms.TextBox txt_TimKiemSach;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
    }
}

