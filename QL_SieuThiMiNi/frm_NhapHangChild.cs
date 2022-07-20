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
    public partial class frm_NhapHangChild : Form
    {
        public frm_NhapHangChild()
        {
            InitializeComponent();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            frm_khoNhapHang.frmNH.ThemHangNhap(int.Parse(txtSL.Text));
            this.Close();
        }
    }
}
