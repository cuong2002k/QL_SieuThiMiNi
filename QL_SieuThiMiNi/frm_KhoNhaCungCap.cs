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
    public partial class frm_KhoNhaCungCap : Form
    {
        BUSQLyKho busqlykho = new BUSQLyKho();
        public frm_KhoNhaCungCap()
        {
            InitializeComponent();
        }
        void LayDSNhaCungCap()
        {
            dtgvNhaCungCap.DataSource = busqlykho.KHO_LayDSNCC();
        }
        bool checktextboxnotnull()
        {
           if( txtMaNCC.Text == string.Empty ||
            txtTenNCC.Text == string.Empty ||
            txtDiaChi.Text == string.Empty ||
            txtSDT.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ");
                return false;
            }
            return true;
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frm_KhoNhaCungCap_Load(object sender, EventArgs e)
        {
            LayDSNhaCungCap();
        }

        private void dtgvNhaCungCap_MouseClick(object sender, MouseEventArgs e)
        {
            txtMaNCC.Text = dtgvNhaCungCap.SelectedRows[0].Cells[0].Value.ToString();
            txtTenNCC.Text = dtgvNhaCungCap.SelectedRows[0].Cells[1].Value.ToString();
            txtDiaChi.Text = dtgvNhaCungCap.SelectedRows[0].Cells[2].Value.ToString();
            txtSDT.Text = dtgvNhaCungCap.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            txtMaNCC.Clear();
            txtTenNCC.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            foreach(var i in busqlykho.KHO_TimNCC(txtMaNCC.Text))
            {
                if (i != null)
                {
                    MessageBox.Show("Nhà cung cấp đã tồn tại");
                    return;
                }
            }
            if (checktextboxnotnull() == true)
            {
                NhaCungCap nhacungcap = new NhaCungCap(txtMaNCC.Text, txtTenNCC.Text, txtDiaChi.Text, txtSDT.Text);
                if (busqlykho.Kho_ThemNhaCungCap(nhacungcap) == true)
                {
                    MessageBox.Show("Thêm Nhà cung cấp thành công");
                    LayDSNhaCungCap();
                }
                else
                {
                    MessageBox.Show("Thêm Nhà cung cấp thất bại");
                }
                
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            foreach (var i in busqlykho.KHO_TimNCC(txtMaNCC.Text))
            {
                if (i == null)
                {
                    MessageBox.Show("Nhà cung cấp không tồn tại");
                    return;
                }
            }
            if (checktextboxnotnull() == true)
            {
                NhaCungCap nhacungcap = new NhaCungCap(txtMaNCC.Text, txtTenNCC.Text, txtDiaChi.Text, txtSDT.Text);
                if (busqlykho.Kho_SuaNhaCungCap(nhacungcap) == true)
                {
                    MessageBox.Show("Sửa Nhà cung cấp thành công");
                    LayDSNhaCungCap();
                }
                else
                {
                    MessageBox.Show("Sửa Nhà cung cấp thất bại");
                }

            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if(txtMaNCC.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng chọn Nhà cung cấp cần xóa");
                return;
            }
            foreach (var i in busqlykho.KHO_TimNCC(txtMaNCC.Text))
            {
                if (i == null)
                {
                    MessageBox.Show("Nhà cung cấp không tồn tại");
                    return;
                }
            }
           
            if (busqlykho.Kho_XoaNhaCungCap(txtMaNCC.Text) == true)
            {
                MessageBox.Show("xóa Nhà cung cấp thành công");
                LayDSNhaCungCap();
            }
            else
            {
                MessageBox.Show("xóa Nhà cung cấp thất bại");
            }
        }
    }
}
