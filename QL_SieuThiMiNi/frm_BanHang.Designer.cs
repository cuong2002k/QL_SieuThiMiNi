namespace QL_SieuThiMiNi
{
    partial class frm_BanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_BanHang));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgvHangHoaBan = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaVach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.txtTienGuiKhach = new Guna.UI2.WinForms.Guna2TextBox();
            this.pneTimkiemKhachHang = new System.Windows.Forms.Panel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.txtDiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txtTenKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txtMaKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnTienThanhToan = new Guna.UI2.WinForms.Guna2Button();
            this.txtTienKhachDua = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMavach = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnthoat = new System.Windows.Forms.ToolStripButton();
            this.btnlammoi = new System.Windows.Forms.ToolStripButton();
            this.btnsearchKH = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHangHoaBan)).BeginInit();
            this.panel3.SuspendLayout();
            this.pneTimkiemKhachHang.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(899, 461);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgvHangHoaBan);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(899, 461);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Hàng Hóa Bán";
            // 
            // dtgvHangHoaBan
            // 
            this.dtgvHangHoaBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvHangHoaBan.BackgroundColor = System.Drawing.Color.White;
            this.dtgvHangHoaBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHangHoaBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaVach,
            this.TenHH,
            this.SoLuong,
            this.DonGia});
            this.dtgvHangHoaBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvHangHoaBan.Location = new System.Drawing.Point(3, 16);
            this.dtgvHangHoaBan.Name = "dtgvHangHoaBan";
            this.dtgvHangHoaBan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvHangHoaBan.Size = new System.Drawing.Size(893, 442);
            this.dtgvHangHoaBan.TabIndex = 1;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // MaVach
            // 
            this.MaVach.HeaderText = "MaVach";
            this.MaVach.Name = "MaVach";
            // 
            // TenHH
            // 
            this.TenHH.HeaderText = "TenHH";
            this.TenHH.Name = "TenHH";
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "SoLuong";
            this.SoLuong.Name = "SoLuong";
            // 
            // DonGia
            // 
            this.DonGia.HeaderText = "DonGia";
            this.DonGia.Name = "DonGia";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gunaLabel4);
            this.panel3.Controls.Add(this.gunaLabel3);
            this.panel3.Controls.Add(this.txtTienGuiKhach);
            this.panel3.Controls.Add(this.pneTimkiemKhachHang);
            this.panel3.Controls.Add(this.gunaLabel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.txtTienKhachDua);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(899, 54);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(340, 533);
            this.panel3.TabIndex = 2;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel4.Location = new System.Drawing.Point(41, 404);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(47, 15);
            this.gunaLabel4.TabIndex = 27;
            this.gunaLabel4.Text = "TienGui";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.gunaLabel3.Location = new System.Drawing.Point(180, 433);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(160, 28);
            this.gunaLabel3.TabIndex = 21;
            this.gunaLabel3.Text = "Số Tiền Tạm Tính";
            this.gunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTienGuiKhach
            // 
            this.txtTienGuiKhach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTienGuiKhach.BorderRadius = 20;
            this.txtTienGuiKhach.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTienGuiKhach.DefaultText = "0";
            this.txtTienGuiKhach.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTienGuiKhach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTienGuiKhach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTienGuiKhach.DisabledState.Parent = this.txtTienGuiKhach;
            this.txtTienGuiKhach.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTienGuiKhach.Enabled = false;
            this.txtTienGuiKhach.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTienGuiKhach.FocusedState.Parent = this.txtTienGuiKhach;
            this.txtTienGuiKhach.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.txtTienGuiKhach.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTienGuiKhach.HoverState.Parent = this.txtTienGuiKhach;
            this.txtTienGuiKhach.Location = new System.Drawing.Point(128, 387);
            this.txtTienGuiKhach.Name = "txtTienGuiKhach";
            this.txtTienGuiKhach.PasswordChar = '\0';
            this.txtTienGuiKhach.PlaceholderText = "";
            this.txtTienGuiKhach.ReadOnly = true;
            this.txtTienGuiKhach.SelectedText = "";
            this.txtTienGuiKhach.SelectionStart = 1;
            this.txtTienGuiKhach.ShadowDecoration.Parent = this.txtTienGuiKhach;
            this.txtTienGuiKhach.Size = new System.Drawing.Size(200, 43);
            this.txtTienGuiKhach.TabIndex = 26;
            this.txtTienGuiKhach.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pneTimkiemKhachHang
            // 
            this.pneTimkiemKhachHang.Controls.Add(this.gunaLabel6);
            this.pneTimkiemKhachHang.Controls.Add(this.txtDiem);
            this.pneTimkiemKhachHang.Controls.Add(this.gunaLabel2);
            this.pneTimkiemKhachHang.Controls.Add(this.txtTenKH);
            this.pneTimkiemKhachHang.Controls.Add(this.gunaLabel1);
            this.pneTimkiemKhachHang.Controls.Add(this.txtMaKH);
            this.pneTimkiemKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.pneTimkiemKhachHang.Location = new System.Drawing.Point(0, 0);
            this.pneTimkiemKhachHang.Name = "pneTimkiemKhachHang";
            this.pneTimkiemKhachHang.Size = new System.Drawing.Size(340, 198);
            this.pneTimkiemKhachHang.TabIndex = 20;
            this.pneTimkiemKhachHang.Visible = false;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel6.Location = new System.Drawing.Point(58, 147);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(35, 15);
            this.gunaLabel6.TabIndex = 23;
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
            this.txtDiem.Enabled = false;
            this.txtDiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiem.FocusedState.Parent = this.txtDiem;
            this.txtDiem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtDiem.ForeColor = System.Drawing.Color.Black;
            this.txtDiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiem.HoverState.Parent = this.txtDiem;
            this.txtDiem.Location = new System.Drawing.Point(102, 136);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.PasswordChar = '\0';
            this.txtDiem.PlaceholderText = "";
            this.txtDiem.ReadOnly = true;
            this.txtDiem.SelectedText = "";
            this.txtDiem.ShadowDecoration.Parent = this.txtDiem;
            this.txtDiem.Size = new System.Drawing.Size(200, 43);
            this.txtDiem.TabIndex = 22;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(54, 94);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(41, 15);
            this.gunaLabel2.TabIndex = 21;
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
            this.txtTenKH.Enabled = false;
            this.txtTenKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenKH.FocusedState.Parent = this.txtTenKH;
            this.txtTenKH.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtTenKH.ForeColor = System.Drawing.Color.Black;
            this.txtTenKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenKH.HoverState.Parent = this.txtTenKH;
            this.txtTenKH.Location = new System.Drawing.Point(102, 84);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.PasswordChar = '\0';
            this.txtTenKH.PlaceholderText = "";
            this.txtTenKH.ReadOnly = true;
            this.txtTenKH.SelectedText = "";
            this.txtTenKH.ShadowDecoration.Parent = this.txtTenKH;
            this.txtTenKH.Size = new System.Drawing.Size(200, 43);
            this.txtTenKH.TabIndex = 20;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(54, 47);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(40, 15);
            this.gunaLabel1.TabIndex = 19;
            this.gunaLabel1.Text = "MaKH";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaKH.BorderRadius = 20;
            this.txtMaKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaKH.DefaultText = "none";
            this.txtMaKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaKH.DisabledState.Parent = this.txtMaKH;
            this.txtMaKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaKH.FocusedState.Parent = this.txtMaKH;
            this.txtMaKH.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtMaKH.ForeColor = System.Drawing.Color.Black;
            this.txtMaKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaKH.HoverState.Parent = this.txtMaKH;
            this.txtMaKH.Location = new System.Drawing.Point(102, 32);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.PasswordChar = '\0';
            this.txtMaKH.PlaceholderText = "";
            this.txtMaKH.SelectedText = "";
            this.txtMaKH.SelectionStart = 4;
            this.txtMaKH.ShadowDecoration.Parent = this.txtMaKH;
            this.txtMaKH.Size = new System.Drawing.Size(200, 43);
            this.txtMaKH.TabIndex = 18;
            this.txtMaKH.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaKH_KeyDown);
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel5.Location = new System.Drawing.Point(26, 350);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(83, 15);
            this.gunaLabel5.TabIndex = 25;
            this.gunaLabel5.Text = "TienKhachDua";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnTienThanhToan);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 461);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(340, 72);
            this.panel4.TabIndex = 0;
            // 
            // btnTienThanhToan
            // 
            this.btnTienThanhToan.CheckedState.Parent = this.btnTienThanhToan;
            this.btnTienThanhToan.CustomImages.Parent = this.btnTienThanhToan;
            this.btnTienThanhToan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTienThanhToan.Enabled = false;
            this.btnTienThanhToan.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnTienThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnTienThanhToan.HoverState.Parent = this.btnTienThanhToan;
            this.btnTienThanhToan.Location = new System.Drawing.Point(0, 0);
            this.btnTienThanhToan.Name = "btnTienThanhToan";
            this.btnTienThanhToan.ShadowDecoration.Parent = this.btnTienThanhToan;
            this.btnTienThanhToan.Size = new System.Drawing.Size(340, 72);
            this.btnTienThanhToan.TabIndex = 0;
            this.btnTienThanhToan.Text = "0";
            this.btnTienThanhToan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnTienThanhToan.Click += new System.EventHandler(this.btnTienThanhToan_Click);
            // 
            // txtTienKhachDua
            // 
            this.txtTienKhachDua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTienKhachDua.BorderRadius = 20;
            this.txtTienKhachDua.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTienKhachDua.DefaultText = "0";
            this.txtTienKhachDua.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTienKhachDua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTienKhachDua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTienKhachDua.DisabledState.Parent = this.txtTienKhachDua;
            this.txtTienKhachDua.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTienKhachDua.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTienKhachDua.FocusedState.Parent = this.txtTienKhachDua;
            this.txtTienKhachDua.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.txtTienKhachDua.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTienKhachDua.HoverState.Parent = this.txtTienKhachDua;
            this.txtTienKhachDua.Location = new System.Drawing.Point(128, 334);
            this.txtTienKhachDua.Name = "txtTienKhachDua";
            this.txtTienKhachDua.PasswordChar = '\0';
            this.txtTienKhachDua.PlaceholderText = "";
            this.txtTienKhachDua.SelectedText = "";
            this.txtTienKhachDua.SelectionStart = 1;
            this.txtTienKhachDua.ShadowDecoration.Parent = this.txtTienKhachDua;
            this.txtTienKhachDua.Size = new System.Drawing.Size(200, 43);
            this.txtTienKhachDua.TabIndex = 24;
            this.txtTienKhachDua.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTienKhachDua.TextChanged += new System.EventHandler(this.txtTienKhachDua_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtMavach);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 515);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(899, 72);
            this.panel2.TabIndex = 3;
            // 
            // txtMavach
            // 
            this.txtMavach.BorderRadius = 10;
            this.txtMavach.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMavach.DefaultText = "";
            this.txtMavach.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMavach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMavach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMavach.DisabledState.Parent = this.txtMavach;
            this.txtMavach.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMavach.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMavach.FocusedState.Parent = this.txtMavach;
            this.txtMavach.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMavach.ForeColor = System.Drawing.Color.Black;
            this.txtMavach.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMavach.HoverState.Parent = this.txtMavach;
            this.txtMavach.Location = new System.Drawing.Point(174, 16);
            this.txtMavach.Margin = new System.Windows.Forms.Padding(6);
            this.txtMavach.Name = "txtMavach";
            this.txtMavach.PasswordChar = '\0';
            this.txtMavach.PlaceholderText = "";
            this.txtMavach.SelectedText = "";
            this.txtMavach.ShadowDecoration.Parent = this.txtMavach;
            this.txtMavach.Size = new System.Drawing.Size(329, 50);
            this.txtMavach.TabIndex = 1;
            this.txtMavach.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMavach_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QL_SieuThiMiNi.Properties.Resources.icons8_barcode_96__1_;
            this.pictureBox1.Location = new System.Drawing.Point(100, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnthoat,
            this.btnlammoi,
            this.btnsearchKH});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(1239, 54);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
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
            // btnlammoi
            // 
            this.btnlammoi.Image = global::QL_SieuThiMiNi.Properties.Resources.icons8_clear_32;
            this.btnlammoi.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnlammoi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnlammoi.Name = "btnlammoi";
            this.btnlammoi.Size = new System.Drawing.Size(91, 51);
            this.btnlammoi.Text = "Làm Mới Phiếu";
            this.btnlammoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnlammoi.Click += new System.EventHandler(this.btnlammoi_Click);
            // 
            // btnsearchKH
            // 
            this.btnsearchKH.Image = global::QL_SieuThiMiNi.Properties.Resources.icons8_add_32;
            this.btnsearchKH.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnsearchKH.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnsearchKH.Name = "btnsearchKH";
            this.btnsearchKH.Size = new System.Drawing.Size(79, 51);
            this.btnsearchKH.Text = "Tìm kiếm KH";
            this.btnsearchKH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnsearchKH.Click += new System.EventHandler(this.btnsearchKH_Click);
            // 
            // frm_BanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 587);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_BanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Bán Hàng";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHangHoaBan)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pneTimkiemKhachHang.ResumeLayout(false);
            this.pneTimkiemKhachHang.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox txtMavach;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnTienThanhToan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgvHangHoaBan;
        private System.Windows.Forms.Panel pneTimkiemKhachHang;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI2.WinForms.Guna2TextBox txtDiem;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI2.WinForms.Guna2TextBox txtTenKH;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtMaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaVach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnsearchKH;
        private System.Windows.Forms.ToolStripButton btnlammoi;
        private System.Windows.Forms.ToolStripButton btnthoat;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI2.WinForms.Guna2TextBox txtTienGuiKhach;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI2.WinForms.Guna2TextBox txtTienKhachDua;
    }
}