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
using BUS_QLSieuThi;
namespace QL_SieuThiMiNi
{
    public partial class frm_khoNhomHang : Form
    {
        BUSQLyKho busqlykho = new BUSQLyKho();
        public frm_khoNhomHang()
        {
            InitializeComponent();
        }
        void laydsnhomhang()
        {
            dtgvNhomhang.DataSource = busqlykho.KHO_LayDSNH();
        }
        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void lammoitextbox()
        {
            txtMaNH.Clear();
            txtTenNh.Clear();
        }
        private void btnlammoi_Click(object sender, EventArgs e)
        {
            lammoitextbox();
        }
        bool checktextboxnotnull()
        {
            if(txtMaNH.Text==string.Empty ||
            txtTenNh.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ");
                return false;
            }
            return true;
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            foreach(var i in busqlykho.KHO_TimNH(txtMaNH.Text))
            {
                if(i != null)
                {
                    MessageBox.Show("Nhóm Hàng Đã Tồn Tại");
                    return;
                }
            }
            if (checktextboxnotnull() == true)
            {

                if(busqlykho.KHO_ThemNH(new NhomHang(txtMaNH.Text, txtTenNh.Text)) == true)
                {
                    MessageBox.Show("Thêm Nhóm Hàng Thành Công");
                    laydsnhomhang();
                }
                else
                {
                    MessageBox.Show("Thêm Nhóm Hàng Thất bại");
                }

            }
        }

        private void frm_khoNhomHang_Load(object sender, EventArgs e)
        {
            laydsnhomhang();
        }

        private void dtgvNhomhang_MouseClick(object sender, MouseEventArgs e)
        {
            txtMaNH.Text = dtgvNhomhang.SelectedRows[0].Cells[0].Value.ToString();
            txtTenNh.Text = dtgvNhomhang.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            foreach (var i in busqlykho.KHO_TimNH(txtMaNH.Text))
            {
                if (i == null)
                {
                    MessageBox.Show("Nhóm Hàng không Tồn Tại");
                    return;
                }
            }
            if (checktextboxnotnull() == true)
            {
                if(busqlykho.KHO_SuaNH(new NhomHang(txtMaNH.Text, txtTenNh.Text)) == true)
                {
                    MessageBox.Show("Sửa Nhóm Hàng Thành Công");
                    laydsnhomhang();
                }
                else
                {
                    MessageBox.Show("Sửa Nhóm Hàng Thất bại");
                }
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            foreach (var i in busqlykho.KHO_TimNH(txtMaNH.Text))
            {
                if (i == null)
                {
                    MessageBox.Show("Nhóm Hàng không Tồn Tại");
                    return;
                }
            }
            if (busqlykho.KHO_XoaNH(txtMaNH.Text))
            {
                MessageBox.Show("Xóa Nhóm Hàng Thành Công");
                laydsnhomhang();
            }
            else
            {
                MessageBox.Show("Xóa Nhóm Hàng Thất bại");
            }
        }
    }
}
