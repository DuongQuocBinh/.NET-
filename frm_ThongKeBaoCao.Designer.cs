namespace QuanLyThuVien
{
    partial class frm_ThongKeBaoCao
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvSachDangMuon;
        private System.Windows.Forms.DataGridView dgvTreHan;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSachMuonNhieu;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuDocGia;
        private System.Windows.Forms.ToolStripMenuItem menuMuonTra;
        private System.Windows.Forms.ToolStripMenuItem menuSach;
        private System.Windows.Forms.ToolStripMenuItem menuDangXuat;
        private System.Windows.Forms.ToolStripMenuItem menuThoat;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dgvSachDangMuon = new System.Windows.Forms.DataGridView();
            this.dgvTreHan = new System.Windows.Forms.DataGridView();
            this.chartSachMuonNhieu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuDocGia = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMuonTra = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSach = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThoat = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachDangMuon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreHan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSachMuonNhieu)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSachDangMuon
            // 
            this.dgvSachDangMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSachDangMuon.Location = new System.Drawing.Point(20, 72);
            this.dgvSachDangMuon.Name = "dgvSachDangMuon";
            this.dgvSachDangMuon.Size = new System.Drawing.Size(500, 127);
            this.dgvSachDangMuon.TabIndex = 0;
            this.dgvSachDangMuon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSachDangMuon_CellContentClick);
            // 
            // dgvTreHan
            // 
            this.dgvTreHan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTreHan.Location = new System.Drawing.Point(20, 236);
            this.dgvTreHan.Name = "dgvTreHan";
            this.dgvTreHan.Size = new System.Drawing.Size(500, 122);
            this.dgvTreHan.TabIndex = 2;
            this.dgvTreHan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTreHan_CellContentClick);
            // 
            // chartSachMuonNhieu
            // 
            chartArea2.Name = "ChartArea1";
            this.chartSachMuonNhieu.ChartAreas.Add(chartArea2);
            this.chartSachMuonNhieu.Location = new System.Drawing.Point(20, 402);
            this.chartSachMuonNhieu.Name = "chartSachMuonNhieu";
            series2.ChartArea = "ChartArea1";
            series2.Name = "Sách mượn";
            this.chartSachMuonNhieu.Series.Add(series2);
            this.chartSachMuonNhieu.Size = new System.Drawing.Size(500, 200);
            this.chartSachMuonNhieu.TabIndex = 1;
            this.chartSachMuonNhieu.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Thống kê về danh sách đang mượn sách:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Biểu đồ sách đang được mượn nhiều nhất:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(310, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Thống kê về danh sách trễ hạn trả sách:";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDocGia,
            this.menuMuonTra,
            this.menuSach,
            this.menuDangXuat,
            this.menuThoat});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(589, 24);
            this.menuStrip.TabIndex = 10;
            this.menuStrip.Text = "menuStrip";
            // 
            // menuDocGia
            // 
            this.menuDocGia.Name = "menuDocGia";
            this.menuDocGia.Size = new System.Drawing.Size(99, 20);
            this.menuDocGia.Text = "Quản lí độc giả";
            this.menuDocGia.Click += new System.EventHandler(this.MenuDocGia_Click);
            // 
            // menuMuonTra
            // 
            this.menuMuonTra.Name = "menuMuonTra";
            this.menuMuonTra.Size = new System.Drawing.Size(136, 20);
            this.menuMuonTra.Text = "Quản lí mượn trả sách";
            this.menuMuonTra.Click += new System.EventHandler(this.MenuMuonTra_Click);
            // 
            // menuSach
            // 
            this.menuSach.Name = "menuSach";
            this.menuSach.Size = new System.Drawing.Size(84, 20);
            this.menuSach.Text = "Quản lí sách";
            this.menuSach.Click += new System.EventHandler(this.MenuSach_Click);
            // 
            // menuDangXuat
            // 
            this.menuDangXuat.Name = "menuDangXuat";
            this.menuDangXuat.Size = new System.Drawing.Size(73, 20);
            this.menuDangXuat.Text = "Đăng xuất";
            this.menuDangXuat.Click += new System.EventHandler(this.MenuDangXuat_Click);
            // 
            // menuThoat
            // 
            this.menuThoat.Name = "menuThoat";
            this.menuThoat.Size = new System.Drawing.Size(49, 20);
            this.menuThoat.Text = "Thoát";
            this.menuThoat.Click += new System.EventHandler(this.MenuThoat_Click);
            // 
            // frm_ThongKeBaoCao
            // 
            this.ClientSize = new System.Drawing.Size(589, 614);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTreHan);
            this.Controls.Add(this.chartSachMuonNhieu);
            this.Controls.Add(this.dgvSachDangMuon);
            this.Controls.Add(this.menuStrip);
            this.Name = "frm_ThongKeBaoCao";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frm_ThongKeBaoCao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachDangMuon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreHan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSachMuonNhieu)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
