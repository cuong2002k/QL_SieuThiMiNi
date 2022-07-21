namespace QL_SieuThiMiNi
{
    partial class frm_khoNhomHang
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
            this.btnthem = new System.Windows.Forms.ToolStripButton();
            this.btnsua = new System.Windows.Forms.ToolStripButton();
            this.btnxoa = new System.Windows.Forms.ToolStripButton();
            this.btnlammoi = new System.Windows.Forms.ToolStripButton();
            this.btnthoat = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMaNH = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel13 = new Guna.UI.WinForms.GunaLabel();
            this.txtTenNh = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgvNhomhang = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNhomhang)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(174)))), ((int)(((byte)(197)))));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnthem,
            this.btnsua,
            this.btnxoa,
            this.btnlammoi,
            this.btnthoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1297, 54);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnthem
            // 
            this.btnthem.Image = global::QL_SieuThiMiNi.Properties.Resources.icons8_add_32;
            this.btnthem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnthem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(41, 51);
            this.btnthem.Text = "Thêm";
            this.btnthem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Image = global::QL_SieuThiMiNi.Properties.Resources.icons8_available_updates_32;
            this.btnsua.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnsua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(36, 51);
            this.btnsua.Text = "Sửa";
            this.btnsua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Image = global::QL_SieuThiMiNi.Properties.Resources.icons8_close_32;
            this.btnxoa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnxoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(36, 51);
            this.btnxoa.Text = "Xóa";
            this.btnxoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnlammoi
            // 
            this.btnlammoi.Image = global::QL_SieuThiMiNi.Properties.Resources.icons8_clear_32;
            this.btnlammoi.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnlammoi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnlammoi.Name = "btnlammoi";
            this.btnlammoi.Size = new System.Drawing.Size(58, 51);
            this.btnlammoi.Text = "Làm Mới";
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
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(174)))), ((int)(((byte)(197)))));
            this.panel2.Controls.Add(this.txtMaNH);
            this.panel2.Controls.Add(this.gunaLabel13);
            this.panel2.Controls.Add(this.txtTenNh);
            this.panel2.Controls.Add(this.gunaLabel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1297, 146);
            this.panel2.TabIndex = 4;
            // 
            // txtMaNH
            // 
            this.txtMaNH.BorderRadius = 20;
            this.txtMaNH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaNH.DefaultText = "";
            this.txtMaNH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaNH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaNH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaNH.DisabledState.Parent = this.txtMaNH;
            this.txtMaNH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaNH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaNH.FocusedState.Parent = this.txtMaNH;
            this.txtMaNH.ForeColor = System.Drawing.Color.Black;
            this.txtMaNH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaNH.HoverState.Parent = this.txtMaNH;
            this.txtMaNH.Location = new System.Drawing.Point(65, 32);
            this.txtMaNH.Name = "txtMaNH";
            this.txtMaNH.PasswordChar = '\0';
            this.txtMaNH.PlaceholderText = "";
            this.txtMaNH.SelectedText = "";
            this.txtMaNH.ShadowDecoration.Parent = this.txtMaNH;
            this.txtMaNH.Size = new System.Drawing.Size(200, 36);
            this.txtMaNH.TabIndex = 34;
            // 
            // gunaLabel13
            // 
            this.gunaLabel13.AutoSize = true;
            this.gunaLabel13.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel13.Location = new System.Drawing.Point(17, 86);
            this.gunaLabel13.Name = "gunaLabel13";
            this.gunaLabel13.Size = new System.Drawing.Size(43, 15);
            this.gunaLabel13.TabIndex = 33;
            this.gunaLabel13.Text = "TenNH";
            // 
            // txtTenNh
            // 
            this.txtTenNh.BorderRadius = 20;
            this.txtTenNh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenNh.DefaultText = "";
            this.txtTenNh.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenNh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenNh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNh.DisabledState.Parent = this.txtTenNh;
            this.txtTenNh.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNh.FocusedState.Parent = this.txtTenNh;
            this.txtTenNh.ForeColor = System.Drawing.Color.Black;
            this.txtTenNh.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNh.HoverState.Parent = this.txtTenNh;
            this.txtTenNh.Location = new System.Drawing.Point(65, 76);
            this.txtTenNh.Name = "txtTenNh";
            this.txtTenNh.PasswordChar = '\0';
            this.txtTenNh.PlaceholderText = "";
            this.txtTenNh.SelectedText = "";
            this.txtTenNh.ShadowDecoration.Parent = this.txtTenNh;
            this.txtTenNh.Size = new System.Drawing.Size(200, 36);
            this.txtTenNh.TabIndex = 32;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(17, 43);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(42, 15);
            this.gunaLabel3.TabIndex = 31;
            this.gunaLabel3.Text = "MaNH";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgvNhomhang);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 200);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1297, 250);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách nhóm hàng";
            // 
            // dtgvNhomhang
            // 
            this.dtgvNhomhang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvNhomhang.BackgroundColor = System.Drawing.Color.White;
            this.dtgvNhomhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvNhomhang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvNhomhang.Location = new System.Drawing.Point(3, 16);
            this.dtgvNhomhang.Name = "dtgvNhomhang";
            this.dtgvNhomhang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvNhomhang.Size = new System.Drawing.Size(1291, 231);
            this.dtgvNhomhang.TabIndex = 0;
            this.dtgvNhomhang.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dtgvNhomhang_MouseClick);
            // 
            // frm_khoNhomHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frm_khoNhomHang";
            this.Text = "frm_khoNhomHang";
            this.Load += new System.EventHandler(this.frm_khoNhomHang_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNhomhang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnthem;
        private System.Windows.Forms.ToolStripButton btnsua;
        private System.Windows.Forms.ToolStripButton btnxoa;
        private System.Windows.Forms.ToolStripButton btnlammoi;
        private System.Windows.Forms.ToolStripButton btnthoat;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox txtMaNH;
        private Guna.UI.WinForms.GunaLabel gunaLabel13;
        private Guna.UI2.WinForms.Guna2TextBox txtTenNh;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgvNhomhang;
    }
}