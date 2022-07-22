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

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            frm_NhanVien frm = new frm_NhanVien();
            frm.ShowDialog();
        }

        private void btnkhachhang_Click(object sender, EventArgs e)
        {
            frm_KhachHang frm = new frm_KhachHang();
            frm.ShowDialog();
        }

        private void btn_BanHang_Click(object sender, EventArgs e)
        {
            frm_BanHang banhang = new frm_BanHang();
            banhang.ShowDialog();
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            frm_DoanhThu doanhthu = new frm_DoanhThu();
            doanhthu.ShowDialog();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            frm_BaoCao frm = new frm_BaoCao();
            frm.ShowDialog();
        }

        private void btndangxuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
