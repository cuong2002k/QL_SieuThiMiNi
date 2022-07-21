namespace QL_SieuThiMiNi
{
    partial class frm_KhoXuatHangchild
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
            this.btnthoat = new System.Windows.Forms.ToolStripButton();
            this.btnthem = new System.Windows.Forms.ToolStripButton();
            this.gunaLabel11 = new Guna.UI.WinForms.GunaLabel();
            this.txtSL = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txtTenHH = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txtMaHH = new Guna.UI2.WinForms.Guna2TextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnthoat,
            this.btnthem});
            this.toolStrip1.Location = new System.Drawing.Point(0, 169);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(289, 54);
            this.toolStrip1.TabIndex = 31;
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
            // gunaLabel11
            // 
            this.gunaLabel11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaLabel11.AutoSize = true;
            this.gunaLabel11.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel11.Location = new System.Drawing.Point(15, 117);
            this.gunaLabel11.Name = "gunaLabel11";
            this.gunaLabel11.Size = new System.Drawing.Size(54, 15);
            this.gunaLabel11.TabIndex = 30;
            this.gunaLabel11.Text = "SoLuong";
            // 
            // txtSL
            // 
            this.txtSL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSL.BorderRadius = 20;
            this.txtSL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSL.DefaultText = "1";
            this.txtSL.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSL.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSL.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSL.DisabledState.Parent = this.txtSL;
            this.txtSL.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSL.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSL.FocusedState.Parent = this.txtSL;
            this.txtSL.ForeColor = System.Drawing.Color.Black;
            this.txtSL.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSL.HoverState.Parent = this.txtSL;
            this.txtSL.Location = new System.Drawing.Point(68, 107);
            this.txtSL.Name = "txtSL";
            this.txtSL.PasswordChar = '\0';
            this.txtSL.PlaceholderText = "";
            this.txtSL.SelectedText = "";
            this.txtSL.SelectionStart = 1;
            this.txtSL.ShadowDecoration.Parent = this.txtSL;
            this.txtSL.Size = new System.Drawing.Size(200, 36);
            this.txtSL.TabIndex = 29;
            this.txtSL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(20, 75);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(43, 15);
            this.gunaLabel2.TabIndex = 28;
            this.gunaLabel2.Text = "TenHH";
            // 
            // txtTenHH
            // 
            this.txtTenHH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenHH.BorderRadius = 20;
            this.txtTenHH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenHH.DefaultText = "";
            this.txtTenHH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenHH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenHH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenHH.DisabledState.Parent = this.txtTenHH;
            this.txtTenHH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenHH.Enabled = false;
            this.txtTenHH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenHH.FocusedState.Parent = this.txtTenHH;
            this.txtTenHH.ForeColor = System.Drawing.Color.Black;
            this.txtTenHH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenHH.HoverState.Parent = this.txtTenHH;
            this.txtTenHH.Location = new System.Drawing.Point(68, 65);
            this.txtTenHH.Name = "txtTenHH";
            this.txtTenHH.PasswordChar = '\0';
            this.txtTenHH.PlaceholderText = "";
            this.txtTenHH.ReadOnly = true;
            this.txtTenHH.SelectedText = "";
            this.txtTenHH.ShadowDecoration.Parent = this.txtTenHH;
            this.txtTenHH.Size = new System.Drawing.Size(200, 36);
            this.txtTenHH.TabIndex = 27;
            this.txtTenHH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(20, 33);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(42, 15);
            this.gunaLabel1.TabIndex = 26;
            this.gunaLabel1.Text = "MaHH";
            // 
            // txtMaHH
            // 
            this.txtMaHH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaHH.BorderRadius = 20;
            this.txtMaHH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaHH.DefaultText = "";
            this.txtMaHH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaHH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaHH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaHH.DisabledState.Parent = this.txtMaHH;
            this.txtMaHH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaHH.Enabled = false;
            this.txtMaHH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaHH.FocusedState.Parent = this.txtMaHH;
            this.txtMaHH.ForeColor = System.Drawing.Color.Black;
            this.txtMaHH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaHH.HoverState.Parent = this.txtMaHH;
            this.txtMaHH.Location = new System.Drawing.Point(68, 23);
            this.txtMaHH.Name = "txtMaHH";
            this.txtMaHH.PasswordChar = '\0';
            this.txtMaHH.PlaceholderText = "";
            this.txtMaHH.ReadOnly = true;
            this.txtMaHH.SelectedText = "";
            this.txtMaHH.ShadowDecoration.Parent = this.txtMaHH;
            this.txtMaHH.Size = new System.Drawing.Size(200, 36);
            this.txtMaHH.TabIndex = 25;
            this.txtMaHH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frm_KhoXuatHangchild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 223);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gunaLabel11);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.txtTenHH);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.txtMaHH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_KhoXuatHangchild";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hàng Hóa";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.ToolStripButton btnthoat;
        public System.Windows.Forms.ToolStripButton btnthem;
        private Guna.UI.WinForms.GunaLabel gunaLabel11;
        public Guna.UI2.WinForms.Guna2TextBox txtSL;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        public Guna.UI2.WinForms.Guna2TextBox txtTenHH;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        public Guna.UI2.WinForms.Guna2TextBox txtMaHH;
    }
}