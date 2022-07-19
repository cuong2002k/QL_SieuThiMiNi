using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QLSieuThi;
using DAL_QLSieuThi;
namespace QL_SieuThiMiNi
{
    public partial class frm_KhoHangHoa : Form
    {
        BUSQLyKho busQLKHO = new BUSQLyKho();
        public frm_KhoHangHoa()
        {
            InitializeComponent();
        }
        // Ham kiem tra textbox co null hay khong
        bool checktextboxnotnull()
        {
            if(txtMaHH.Text == string.Empty || txtTenHH.Text == string.Empty || cboNH.Text == string.Empty ||
             cboNCC.Text == string.Empty || txtVAT.Text == string.Empty || txtXuatXu.Text == string.Empty || txtGiaBan.Text == string.Empty||
            txtGiaNhap.Text==string.Empty || txtDVT.Text == string.Empty || txtMaVach.Text == string.Empty || txtDinhMuc.Text == string.Empty||
            txtSL.Text == string.Empty || txtTrangThai.Text == string.Empty)
            {
                return false;
            }
            return true;
        }
        void HienThiHangHoa()
        {
            dtgvHangHoa.DataSource = busQLKHO.KHO_LayDSHH();
            
        }
        private void frm_KhoHangHoa_Load(object sender, EventArgs e)
        {
            HienThiHangHoa();
            var dbncc = busQLKHO.KHO_LayDSNCC();
            foreach (var i in dbncc)
            {
                cboNCC.Items.Add(i.MaNCC);
            }
            var dbNH = busQLKHO.KHO_LayDSNH();
            foreach(var i in dbNH)
            {
                cboNH.Items.Add(i.MaNH);
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            //txtMaHH.Text == string.Empty || txtTenHH.Text == string.Empty || cboNH.Text == string.Empty ||
             //cboNCC.Text == string.Empty || txtVAT.Text == string.Empty || txtXuatXu.Text == string.Empty || txtGiaBan.Text == string.Empty ||
            //txtGiaNhap.Text == string.Empty || txtDVT.Text == string.Empty || txtMaVach.Text == string.Empty || txtDinhMuc.Text == string.Empty ||
            //txtSL.Text == string.Empty || txtTrangThai.Text == string.Empty)
            if (checktextboxnotnull() == true)
            {
                HangHoa hanghoa = new HangHoa(txtMaHH.Text, txtTenHH.Text, cboNH.Text,txtXuatXu.Text,int.Parse(txtGiaNhap.Text), int.Parse(txtGiaBan.Text),txtDVT.Text,cboNCC.Text,txtMaVach.Text, int.Parse(txtDinhMuc.Text), int.Parse(txtSL.Text),Convert.ToBoolean(int.Parse(txtTrangThai.Text)), int.Parse(txtVAT.Text));
                if (busQLKHO.KHO_ThemHangHoa(hanghoa))
                {
                    MessageBox.Show("Them hang hoa thanh cong");
                    HienThiHangHoa();
                }
                else
                {
                    MessageBox.Show("Them hang hoa k thanh cong");
                }
                return;
            }
            MessageBox.Show("vui long nhap day du");
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (checktextboxnotnull() == true)
            {
                HangHoa hanghoa = new HangHoa(txtMaHH.Text, txtTenHH.Text, cboNH.Text, txtXuatXu.Text, int.Parse(txtGiaNhap.Text), int.Parse(txtGiaBan.Text), txtDVT.Text, cboNCC.Text, txtMaVach.Text, int.Parse(txtDinhMuc.Text), int.Parse(txtSL.Text), Convert.ToBoolean(int.Parse(txtTrangThai.Text)), int.Parse(txtVAT.Text));
                if (busQLKHO.KHO_SuaHangHoa(hanghoa))
                {
                    MessageBox.Show("sua hang hoa thanh cong");
                    HienThiHangHoa();
                }
                else
                {
                    MessageBox.Show("sua hang hoa k thanh cong");
                }
                return;
            }
            MessageBox.Show("vui long nhap day du");
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (busQLKHO.KHO_XoaHangHoa(txtMaHH.Text))
            {
                MessageBox.Show("xoa hang hoa thanh cong");
                HienThiHangHoa();
            }
            else
            {
                MessageBox.Show("xoa hang hoa k thanh cong");
            }
        }
    }
}
