namespace Quản_Lý_Thư_Viện
{
    partial class frm_QuanLyTraSach
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
            this.cmb_LoaiTK = new System.Windows.Forms.ComboBox();
            this.txt_Ma = new System.Windows.Forms.TextBox();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_HienThi = new System.Windows.Forms.Button();
            this.txt_MaDG = new System.Windows.Forms.TextBox();
            this.txt_MaSach = new System.Windows.Forms.TextBox();
            this.dgv_QLTraSach = new System.Windows.Forms.DataGridView();
            this.lbl_TKTheo = new System.Windows.Forms.Label();
            this.lbl_MaDG = new System.Windows.Forms.Label();
            this.lbl_MaSach = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QLTraSach)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_LoaiTK
            // 
            this.cmb_LoaiTK.FormattingEnabled = true;
            this.cmb_LoaiTK.Location = new System.Drawing.Point(317, 64);
            this.cmb_LoaiTK.Name = "cmb_LoaiTK";
            this.cmb_LoaiTK.Size = new System.Drawing.Size(165, 21);
            this.cmb_LoaiTK.TabIndex = 0;
            // 
            // txt_Ma
            // 
            this.txt_Ma.Location = new System.Drawing.Point(328, 116);
            this.txt_Ma.Name = "txt_Ma";
            this.txt_Ma.Size = new System.Drawing.Size(145, 20);
            this.txt_Ma.TabIndex = 1;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.Location = new System.Drawing.Point(345, 165);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(109, 39);
            this.btn_TimKiem.TabIndex = 2;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(260, 241);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(107, 24);
            this.btn_Xoa.TabIndex = 3;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_HienThi
            // 
            this.btn_HienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HienThi.Location = new System.Drawing.Point(373, 241);
            this.btn_HienThi.Name = "btn_HienThi";
            this.btn_HienThi.Size = new System.Drawing.Size(109, 24);
            this.btn_HienThi.TabIndex = 4;
            this.btn_HienThi.Text = "Hiển thị";
            this.btn_HienThi.UseVisualStyleBackColor = true;
            this.btn_HienThi.Click += new System.EventHandler(this.btn_HienThi_Click);
            // 
            // txt_MaDG
            // 
            this.txt_MaDG.Location = new System.Drawing.Point(12, 241);
            this.txt_MaDG.Multiline = true;
            this.txt_MaDG.Name = "txt_MaDG";
            this.txt_MaDG.Size = new System.Drawing.Size(118, 24);
            this.txt_MaDG.TabIndex = 5;
            // 
            // txt_MaSach
            // 
            this.txt_MaSach.Location = new System.Drawing.Point(136, 241);
            this.txt_MaSach.Multiline = true;
            this.txt_MaSach.Name = "txt_MaSach";
            this.txt_MaSach.Size = new System.Drawing.Size(118, 24);
            this.txt_MaSach.TabIndex = 6;
            // 
            // dgv_QLTraSach
            // 
            this.dgv_QLTraSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_QLTraSach.Location = new System.Drawing.Point(-1, 284);
            this.dgv_QLTraSach.Name = "dgv_QLTraSach";
            this.dgv_QLTraSach.Size = new System.Drawing.Size(802, 167);
            this.dgv_QLTraSach.TabIndex = 7;
            // 
            // lbl_TKTheo
            // 
            this.lbl_TKTheo.AutoSize = true;
            this.lbl_TKTheo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TKTheo.Location = new System.Drawing.Point(276, 32);
            this.lbl_TKTheo.Name = "lbl_TKTheo";
            this.lbl_TKTheo.Size = new System.Drawing.Size(108, 16);
            this.lbl_TKTheo.TabIndex = 8;
            this.lbl_TKTheo.Text = "Tìm kiếm theo:";
            // 
            // lbl_MaDG
            // 
            this.lbl_MaDG.AutoSize = true;
            this.lbl_MaDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaDG.Location = new System.Drawing.Point(9, 216);
            this.lbl_MaDG.Name = "lbl_MaDG";
            this.lbl_MaDG.Size = new System.Drawing.Size(84, 16);
            this.lbl_MaDG.TabIndex = 9;
            this.lbl_MaDG.Text = "Mã đọc giả";
            // 
            // lbl_MaSach
            // 
            this.lbl_MaSach.AutoSize = true;
            this.lbl_MaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaSach.Location = new System.Drawing.Point(133, 216);
            this.lbl_MaSach.Name = "lbl_MaSach";
            this.lbl_MaSach.Size = new System.Drawing.Size(65, 16);
            this.lbl_MaSach.TabIndex = 10;
            this.lbl_MaSach.Text = "Mã sách";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(423, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 11;
            // 
            // frm_QuanLyTraSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_MaSach);
            this.Controls.Add(this.lbl_MaDG);
            this.Controls.Add(this.lbl_TKTheo);
            this.Controls.Add(this.dgv_QLTraSach);
            this.Controls.Add(this.txt_MaSach);
            this.Controls.Add(this.txt_MaDG);
            this.Controls.Add(this.btn_HienThi);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.txt_Ma);
            this.Controls.Add(this.cmb_LoaiTK);
            this.Name = "frm_QuanLyTraSach";
            this.Text = "frm_QuanLyTraSach";
            this.Load += new System.EventHandler(this.frm_QuanLyTraSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QLTraSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_LoaiTK;
        private System.Windows.Forms.TextBox txt_Ma;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_HienThi;
        private System.Windows.Forms.TextBox txt_MaDG;
        private System.Windows.Forms.TextBox txt_MaSach;
        private System.Windows.Forms.DataGridView dgv_QLTraSach;
        private System.Windows.Forms.Label lbl_TKTheo;
        private System.Windows.Forms.Label lbl_MaDG;
        private System.Windows.Forms.Label lbl_MaSach;
        private System.Windows.Forms.Label label4;
    }
}