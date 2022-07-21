namespace QL_SieuThiMiNi
{
    partial class frm_KhoXuatHang
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnlapphieu = new System.Windows.Forms.ToolStripButton();
            this.btnluuphieu = new System.Windows.Forms.ToolStripButton();
            this.btnlammoi = new System.Windows.Forms.ToolStripButton();
            this.btnthoat = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgvHangHoaXuat = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtgvHangHoa = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHangHoaXuat)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHangHoa)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(174)))), ((int)(((byte)(197)))));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnlapphieu,
            this.btnluuphieu,
            this.btnlammoi,
            this.btnthoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 54);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnlapphieu
            // 
            this.btnlapphieu.Image = global::QL_SieuThiMiNi.Properties.Resources.icons8_add_32;
            this.btnlapphieu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnlapphieu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnlapphieu.Name = "btnlapphieu";
            this.btnlapphieu.Size = new System.Drawing.Size(60, 51);
            this.btnlapphieu.Text = "lập Phiếu";
            this.btnlapphieu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnlapphieu.Click += new System.EventHandler(this.btnlapphieu_Click);
            // 
            // btnluuphieu
            // 
            this.btnluuphieu.Image = global::QL_SieuThiMiNi.Properties.Resources.icons8_save_32__1_;
            this.btnluuphieu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnluuphieu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnluuphieu.Name = "btnluuphieu";
            this.btnluuphieu.Size = new System.Drawing.Size(64, 51);
            this.btnluuphieu.Text = "Lưu Phiếu";
            this.btnluuphieu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnluuphieu.Click += new System.EventHandler(this.btnluuphieu_Click);
            // 
            // btnlammoi
            // 
            this.btnlammoi.Image = global::QL_SieuThiMiNi.Properties.Resources.icons8_close_32;
            this.btnlammoi.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnlammoi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnlammoi.Name = "btnlammoi";
            this.btnlammoi.Size = new System.Drawing.Size(66, 51);
            this.btnlammoi.Text = "Hủy Phiếu";
            this.btnlammoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnlammoi.Click += new System.EventHandler(this.btnlammoi_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Image = global::QL_SieuThiMiNi.Properties.Resources.icons8_sign_out_32;
            this.btnthoat.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnthoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(41, 51);
            this.btnthoat.Text = "Thoát";
            this.btnthoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgvHangHoaXuat);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 396);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Hàng Xuất";
            // 
            // dtgvHangHoaXuat
            // 
            this.dtgvHangHoaXuat.AllowUserToAddRows = false;
            this.dtgvHangHoaXuat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvHangHoaXuat.BackgroundColor = System.Drawing.Color.White;
            this.dtgvHangHoaXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHangHoaXuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.MaHH,
            this.TenHang,
            this.SoLuong});
            this.dtgvHangHoaXuat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvHangHoaXuat.Location = new System.Drawing.Point(3, 16);
            this.dtgvHangHoaXuat.Name = "dtgvHangHoaXuat";
            this.dtgvHangHoaXuat.ReadOnly = true;
            this.dtgvHangHoaXuat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvHangHoaXuat.Size = new System.Drawing.Size(394, 377);
            this.dtgvHangHoaXuat.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "STT";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // MaHH
            // 
            this.MaHH.HeaderText = "MaHH";
            this.MaHH.Name = "MaHH";
            this.MaHH.ReadOnly = true;
            // 
            // TenHang
            // 
            this.TenHang.HeaderText = "Ten Hang Hoa";
            this.TenHang.Name = "TenHang";
            this.TenHang.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "So Luong";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(400, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 396);
            this.panel1.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtgvHangHoa);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(400, 396);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách Hàng Hóa";
            // 
            // dtgvHangHoa
            // 
            this.dtgvHangHoa.BackgroundColor = System.Drawing.Color.White;
            this.dtgvHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHangHoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvHangHoa.Location = new System.Drawing.Point(3, 16);
            this.dtgvHangHoa.Name = "dtgvHangHoa";
            this.dtgvHangHoa.ReadOnly = true;
            this.dtgvHangHoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvHangHoa.Size = new System.Drawing.Size(394, 377);
            this.dtgvHangHoa.TabIndex = 1;
            this.dtgvHangHoa.DoubleClick += new System.EventHandler(this.dtgvHangHoa_DoubleClick);
            this.dtgvHangHoa.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dtgvHangHoa_MouseClick);
            // 
            // frm_KhoXuatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frm_KhoXuatHang";
            this.Text = "frm_KhoXuatHang";
            this.Load += new System.EventHandler(this.frm_KhoXuatHang_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHangHoaXuat)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHangHoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnlapphieu;
        private System.Windows.Forms.ToolStripButton btnluuphieu;
        private System.Windows.Forms.ToolStripButton btnlammoi;
        private System.Windows.Forms.ToolStripButton btnthoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgvHangHoaXuat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dtgvHangHoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
    }
}