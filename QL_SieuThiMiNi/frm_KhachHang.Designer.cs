namespace QL_SieuThiMiNi
{
    partial class frm_KhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_KhachHang));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnthem = new System.Windows.Forms.ToolStripButton();
            this.btnsua = new System.Windows.Forms.ToolStripButton();
            this.btnxoa = new System.Windows.Forms.ToolStripButton();
            this.btnlammoi = new System.Windows.Forms.ToolStripButton();
            this.btnthongke = new System.Windows.Forms.ToolStripButton();
            this.btnthoat = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtCMND = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel11 = new Guna.UI.WinForms.GunaLabel();
            this.txtNamGanBo = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.txtDiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.txtDiaChi = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.txtSDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txtTenKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txtMaKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgvKH = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKH)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(119)))));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnthem,
            this.btnsua,
            this.btnxoa,
            this.btnlammoi,
            this.btnthongke,
            this.btnthoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1125, 54);
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
            // btnthongke
            // 
            this.btnthongke.Image = global::QL_SieuThiMiNi.Properties.Resources.icons8_report_card_32;
            this.btnthongke.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnthongke.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnthongke.Name = "btnthongke";
            this.btnthongke.Size = new System.Drawing.Size(60, 51);
            this.btnthongke.Text = "Thống kê";
            this.btnthongke.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnthongke.Click += new System.EventHandler(this.btnthongke_Click);
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
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(119)))));
            this.panel2.Controls.Add(this.txtCMND);
            this.panel2.Controls.Add(this.gunaLabel11);
            this.panel2.Controls.Add(this.txtNamGanBo);
            this.panel2.Controls.Add(this.gunaLabel6);
            this.panel2.Controls.Add(this.txtDiem);
            this.panel2.Controls.Add(this.gunaLabel5);
            this.panel2.Controls.Add(this.txtDiaChi);
            this.panel2.Controls.Add(this.gunaLabel4);
            this.panel2.Controls.Add(this.txtSDT);
            this.panel2.Controls.Add(this.gunaLabel3);
            this.panel2.Controls.Add(this.gunaLabel2);
            this.panel2.Controls.Add(this.txtTenKH);
            this.panel2.Controls.Add(this.gunaLabel1);
            this.panel2.Controls.Add(this.txtMaKH);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1125, 214);
            this.panel2.TabIndex = 4;
            // 
            // txtCMND
            // 
            this.txtCMND.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCMND.BorderRadius = 20;
            this.txtCMND.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCMND.DefaultText = "";
            this.txtCMND.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCMND.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCMND.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCMND.DisabledState.Parent = this.txtCMND;
            this.txtCMND.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCMND.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCMND.FocusedState.Parent = this.txtCMND;
            this.txtCMND.ForeColor = System.Drawing.Color.Black;
            this.txtCMND.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCMND.HoverState.Parent = this.txtCMND;
            this.txtCMND.Location = new System.Drawing.Point(225, 130);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.PasswordChar = '\0';
            this.txtCMND.PlaceholderText = "";
            this.txtCMND.SelectedText = "";
            this.txtCMND.ShadowDecoration.Parent = this.txtCMND;
            this.txtCMND.Size = new System.Drawing.Size(200, 36);
            this.txtCMND.TabIndex = 22;
            // 
            // gunaLabel11
            // 
            this.gunaLabel11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaLabel11.AutoSize = true;
            this.gunaLabel11.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel11.Location = new System.Drawing.Point(694, 56);
            this.gunaLabel11.Name = "gunaLabel11";
            this.gunaLabel11.Size = new System.Drawing.Size(68, 15);
            this.gunaLabel11.TabIndex = 21;
            this.gunaLabel11.Text = "NamGanBo";
            // 
            // txtNamGanBo
            // 
            this.txtNamGanBo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNamGanBo.BorderRadius = 20;
            this.txtNamGanBo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNamGanBo.DefaultText = "";
            this.txtNamGanBo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNamGanBo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNamGanBo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNamGanBo.DisabledState.Parent = this.txtNamGanBo;
            this.txtNamGanBo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNamGanBo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNamGanBo.FocusedState.Parent = this.txtNamGanBo;
            this.txtNamGanBo.ForeColor = System.Drawing.Color.Black;
            this.txtNamGanBo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNamGanBo.HoverState.Parent = this.txtNamGanBo;
            this.txtNamGanBo.Location = new System.Drawing.Point(762, 46);
            this.txtNamGanBo.Name = "txtNamGanBo";
            this.txtNamGanBo.PasswordChar = '\0';
            this.txtNamGanBo.PlaceholderText = "";
            this.txtNamGanBo.SelectedText = "";
            this.txtNamGanBo.ShadowDecoration.Parent = this.txtNamGanBo;
            this.txtNamGanBo.Size = new System.Drawing.Size(200, 36);
            this.txtNamGanBo.TabIndex = 20;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel6.Location = new System.Drawing.Point(437, 140);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(35, 15);
            this.gunaLabel6.TabIndex = 11;
            this.gunaLabel6.Text = "Diem";
            // 
            // txtDiem
            // 
            this.txtDiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDiem.BorderRadius = 20;
            this.txtDiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiem.DefaultText = "";
            this.txtDiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiem.DisabledState.Parent = this.txtDiem;
            this.txtDiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiem.FocusedState.Parent = this.txtDiem;
            this.txtDiem.ForeColor = System.Drawing.Color.Black;
            this.txtDiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiem.HoverState.Parent = this.txtDiem;
            this.txtDiem.Location = new System.Drawing.Point(485, 130);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.PasswordChar = '\0';
            this.txtDiem.PlaceholderText = "";
            this.txtDiem.SelectedText = "";
            this.txtDiem.ShadowDecoration.Parent = this.txtDiem;
            this.txtDiem.Size = new System.Drawing.Size(200, 36);
            this.txtDiem.TabIndex = 10;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel5.Location = new System.Drawing.Point(437, 98);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(42, 15);
            this.gunaLabel5.TabIndex = 9;
            this.gunaLabel5.Text = "DiaChi";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDiaChi.BorderRadius = 20;
            this.txtDiaChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiaChi.DefaultText = "";
            this.txtDiaChi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiaChi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiaChi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaChi.DisabledState.Parent = this.txtDiaChi;
            this.txtDiaChi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaChi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiaChi.FocusedState.Parent = this.txtDiaChi;
            this.txtDiaChi.ForeColor = System.Drawing.Color.Black;
            this.txtDiaChi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiaChi.HoverState.Parent = this.txtDiaChi;
            this.txtDiaChi.Location = new System.Drawing.Point(485, 88);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.PasswordChar = '\0';
            this.txtDiaChi.PlaceholderText = "";
            this.txtDiaChi.SelectedText = "";
            this.txtDiaChi.ShadowDecoration.Parent = this.txtDiaChi;
            this.txtDiaChi.Size = new System.Drawing.Size(200, 36);
            this.txtDiaChi.TabIndex = 8;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel4.Location = new System.Drawing.Point(437, 56);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(26, 15);
            this.gunaLabel4.TabIndex = 7;
            this.gunaLabel4.Text = "SDT";
            // 
            // txtSDT
            // 
            this.txtSDT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSDT.BorderRadius = 20;
            this.txtSDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSDT.DefaultText = "";
            this.txtSDT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSDT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSDT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSDT.DisabledState.Parent = this.txtSDT;
            this.txtSDT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSDT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSDT.FocusedState.Parent = this.txtSDT;
            this.txtSDT.ForeColor = System.Drawing.Color.Black;
            this.txtSDT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSDT.HoverState.Parent = this.txtSDT;
            this.txtSDT.Location = new System.Drawing.Point(485, 46);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.PasswordChar = '\0';
            this.txtSDT.PlaceholderText = "";
            this.txtSDT.SelectedText = "";
            this.txtSDT.ShadowDecoration.Parent = this.txtSDT;
            this.txtSDT.Size = new System.Drawing.Size(200, 36);
            this.txtSDT.TabIndex = 6;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(177, 141);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(43, 15);
            this.gunaLabel3.TabIndex = 5;
            this.gunaLabel3.Text = "CMND";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(177, 98);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(41, 15);
            this.gunaLabel2.TabIndex = 4;
            this.gunaLabel2.Text = "TenKH";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenKH.BorderRadius = 20;
            this.txtTenKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenKH.DefaultText = "";
            this.txtTenKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenKH.DisabledState.Parent = this.txtTenKH;
            this.txtTenKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenKH.FocusedState.Parent = this.txtTenKH;
            this.txtTenKH.ForeColor = System.Drawing.Color.Black;
            this.txtTenKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenKH.HoverState.Parent = this.txtTenKH;
            this.txtTenKH.Location = new System.Drawing.Point(225, 88);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.PasswordChar = '\0';
            this.txtTenKH.PlaceholderText = "";
            this.txtTenKH.SelectedText = "";
            this.txtTenKH.ShadowDecoration.Parent = this.txtTenKH;
            this.txtTenKH.Size = new System.Drawing.Size(200, 36);
            this.txtTenKH.TabIndex = 3;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(177, 56);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(40, 15);
            this.gunaLabel1.TabIndex = 2;
            this.gunaLabel1.Text = "MaKH";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaKH.BorderRadius = 20;
            this.txtMaKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaKH.DefaultText = "";
            this.txtMaKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaKH.DisabledState.Parent = this.txtMaKH;
            this.txtMaKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaKH.Enabled = false;
            this.txtMaKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaKH.FocusedState.Parent = this.txtMaKH;
            this.txtMaKH.ForeColor = System.Drawing.Color.Black;
            this.txtMaKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaKH.HoverState.Parent = this.txtMaKH;
            this.txtMaKH.Location = new System.Drawing.Point(225, 46);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.PasswordChar = '\0';
            this.txtMaKH.PlaceholderText = "";
            this.txtMaKH.SelectedText = "";
            this.txtMaKH.ShadowDecoration.Parent = this.txtMaKH;
            this.txtMaKH.Size = new System.Drawing.Size(200, 36);
            this.txtMaKH.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgvKH);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 268);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1125, 182);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Khách Hàng";
            // 
            // dtgvKH
            // 
            this.dtgvKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvKH.BackgroundColor = System.Drawing.Color.White;
            this.dtgvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvKH.Location = new System.Drawing.Point(3, 16);
            this.dtgvKH.Name = "dtgvKH";
            this.dtgvKH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvKH.Size = new System.Drawing.Size(1119, 163);
            this.dtgvKH.TabIndex = 0;
            this.dtgvKH.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dtgvKH_MouseClick);
            // 
            // frm_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_KhachHang";
            this.Text = "Quản Lý Khách Hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_KhachHang_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnthem;
        private System.Windows.Forms.ToolStripButton btnsua;
        private System.Windows.Forms.ToolStripButton btnxoa;
        private System.Windows.Forms.ToolStripButton btnlammoi;
        private System.Windows.Forms.ToolStripButton btnthongke;
        private System.Windows.Forms.ToolStripButton btnthoat;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel11;
        private Guna.UI2.WinForms.Guna2TextBox txtNamGanBo;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI2.WinForms.Guna2TextBox txtDiem;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI2.WinForms.Guna2TextBox txtDiaChi;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI2.WinForms.Guna2TextBox txtSDT;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI2.WinForms.Guna2TextBox txtTenKH;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtMaKH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgvKH;
        private Guna.UI2.WinForms.Guna2TextBox txtCMND;
    }
}