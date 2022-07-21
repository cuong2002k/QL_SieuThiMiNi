using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_SieuThiMiNi
{
    public partial class frm_KhoMain : Form
    {
        public frm_KhoMain()
        {
            InitializeComponent();
            OpenChildForm(new frm_KhoHangHoa());
        }
        private Form Active = null;
        private void OpenChildForm(Form ChildForm)
        {
            if (Active != null)
            {
                Active.Close();
            }
            Active = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panelchildform.Controls.Add(ChildForm);
            panelchildform.Tag = ChildForm;
            //ChildForm.BringToFront();
            ChildForm.Show();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHangHoa_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_KhoHangHoa());
        }

        private void btnnhacungcap_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_KhoNhaCungCap());
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_khoNhomHang());
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_khoNhapHang());
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
