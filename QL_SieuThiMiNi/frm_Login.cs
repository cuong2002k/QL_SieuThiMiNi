using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL_QLSieuThi;
namespace QL_SieuThiMiNi
{
    public partial class frm_Login : Form
    {
        public static frm_Login frmlogin = new frm_Login();
        public string manv;
        SieuThiMiniEntities db = new SieuThiMiniEntities();
        public frm_Login()
        {
            InitializeComponent();
            frmlogin = this;
        }
        bool checktextboxnotnull()
        {
            if(txttaikhoan.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập tài khoản");
                txttaikhoan.Focus();
                return false;
            }
            else if (txtmatkhau.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập mật khẩu");
                txtmatkhau.Focus();
                return false;
            }
            return true;
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (checktextboxnotnull())
            {
                var nhanvien = db.NhanVien.Where(p => p.UserName == txttaikhoan.Text && p.Password == txtmatkhau.Text).SingleOrDefault();
                if(nhanvien == null)
                {
                    MessageBox.Show("Thông tin tài khoản mật khẩu không chính xác");
                    return;
                }
                frmMain frm = new frmMain();
                manv = nhanvien.MaNV;
                if (nhanvien.MaQuyen.Equals("MQ01"))
                {
                    frm.btn_BanHang.Enabled = true;
                    frm.btnDoanhThu.Enabled = true;
                }  
                else if (nhanvien.MaQuyen.Equals("MQ02"))
                {
                    frm.btnkho.Enabled = true;
                    frm.btnDoanhThu.Enabled = true;
                }
                else if (nhanvien.MaQuyen.Equals("MQ03"))
                {
                    frm.btnBaoCao.Enabled = true;
                    frm.btnDoanhThu.Enabled = true;
                    frm.btnNhanVien.Enabled = true;
                    frm.btnkhachhang.Enabled = true;
                    frm.btnkho.Enabled = true;
                }
                    frm.Show();
            }
            
        }
    }
}
