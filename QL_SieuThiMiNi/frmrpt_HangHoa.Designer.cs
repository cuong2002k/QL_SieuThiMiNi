namespace QL_SieuThiMiNi
{
    partial class frmrpt_HangHoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmrpt_HangHoa));
            this.rptvHangHoa = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rptvHangHoa
            // 
            this.rptvHangHoa.ActiveViewIndex = -1;
            this.rptvHangHoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptvHangHoa.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptvHangHoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptvHangHoa.Location = new System.Drawing.Point(0, 0);
            this.rptvHangHoa.Name = "rptvHangHoa";
            this.rptvHangHoa.Size = new System.Drawing.Size(800, 450);
            this.rptvHangHoa.TabIndex = 0;
            // 
            // frmrpt_HangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rptvHangHoa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmrpt_HangHoa";
            this.Text = "Báo cáo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer rptvHangHoa;
    }
}