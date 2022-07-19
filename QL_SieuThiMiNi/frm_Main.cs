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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnkho_Click(object sender, EventArgs e)
        {
            frm_KhoMain frm = new frm_KhoMain();
            frm.ShowDialog();
        }
    }
}
