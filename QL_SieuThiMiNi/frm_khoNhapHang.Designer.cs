﻿namespace QL_SieuThiMiNi
{
    partial class frm_khoNhapHang
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
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btnluuphieu = new System.Windows.Forms.ToolStripButton();
            this.btnlammoi = new System.Windows.Forms.ToolStripButton();
            this.btnthoat = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgvHangHoaNhap = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XuatXu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtgvHangHoa = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgvNhaCungCap = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHangHoaNhap)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHangHoa)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNhaCungCap)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnlapphieu,
            this.toolStripButton1,
            this.btnluuphieu,
            this.btnlammoi,
            this.btnthoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 54);
            this.toolStrip1.TabIndex = 2;
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
            this.btnlapphieu.Click += new System.EventHandler(this.btnlapphieu_Click_1);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::QL_SieuThiMiNi.Properties.Resources.icons8_clear_32;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(91, 51);
            this.toolStripButton1.Text = "Làm Mới Phiếu";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
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
            this.groupBox1.Controls.Add(this.dtgvHangHoaNhap);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 396);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Hàng Nhập";
            // 
            // dtgvHangHoaNhap
            // 
            this.dtgvHangHoaNhap.AllowUserToAddRows = false;
            this.dtgvHangHoaNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvHangHoaNhap.BackgroundColor = System.Drawing.Color.White;
            this.dtgvHangHoaNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHangHoaNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.MaHH,
            this.TenHang,
            this.XuatXu,
            this.SoLuong});
            this.dtgvHangHoaNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvHangHoaNhap.Location = new System.Drawing.Point(3, 16);
            this.dtgvHangHoaNhap.Name = "dtgvHangHoaNhap";
            this.dtgvHangHoaNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvHangHoaNhap.Size = new System.Drawing.Size(394, 377);
            this.dtgvHangHoaNhap.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "STT";
            this.Column1.Name = "Column1";
            // 
            // MaHH
            // 
            this.MaHH.HeaderText = "MaHH";
            this.MaHH.Name = "MaHH";
            // 
            // TenHang
            // 
            this.TenHang.HeaderText = "Ten Hang Hoa";
            this.TenHang.Name = "TenHang";
            // 
            // XuatXu
            // 
            this.XuatXu.HeaderText = "Xuat Xu";
            this.XuatXu.Name = "XuatXu";
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "So Luong";
            this.SoLuong.Name = "SoLuong";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(400, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 396);
            this.panel1.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtgvHangHoa);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 194);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(400, 202);
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
            this.dtgvHangHoa.Size = new System.Drawing.Size(394, 183);
            this.dtgvHangHoa.TabIndex = 1;
            this.dtgvHangHoa.DoubleClick += new System.EventHandler(this.dtgvHangHoa_DoubleClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 194);
            this.panel2.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgvNhaCungCap);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 194);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhà Cung Cấp";
            // 
            // dtgvNhaCungCap
            // 
            this.dtgvNhaCungCap.BackgroundColor = System.Drawing.Color.White;
            this.dtgvNhaCungCap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvNhaCungCap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvNhaCungCap.Location = new System.Drawing.Point(3, 16);
            this.dtgvNhaCungCap.Name = "dtgvNhaCungCap";
            this.dtgvNhaCungCap.ReadOnly = true;
            this.dtgvNhaCungCap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvNhaCungCap.Size = new System.Drawing.Size(394, 175);
            this.dtgvNhaCungCap.TabIndex = 0;
            this.dtgvNhaCungCap.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dtgvNhaCungCap_MouseClick);
            // 
            // frm_khoNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frm_khoNhapHang";
            this.Text = "frm_khoNhapHang";
            this.Load += new System.EventHandler(this.frm_khoNhapHang_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHangHoaNhap)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHangHoa)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNhaCungCap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnlapphieu;
        private System.Windows.Forms.ToolStripButton btnlammoi;
        private System.Windows.Forms.ToolStripButton btnthoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dtgvHangHoa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgvNhaCungCap;
        private System.Windows.Forms.DataGridView dtgvHangHoaNhap;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton btnluuphieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn XuatXu;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
    }
}