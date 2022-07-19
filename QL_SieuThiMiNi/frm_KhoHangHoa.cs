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
        void cleartextbox()
        {
            txtMaHH.Text = string.Empty;
            txtTenHH.Text = string.Empty;
            cboNH.Text = string.Empty;
            cboNCC.Text = string.Empty;
            txtVAT.Text = string.Empty;
            txtXuatXu.Text = string.Empty;
            txtGiaBan.Text = string.Empty;
            txtGiaNhap.Text = string.Empty;
            txtDVT.Text = string.Empty;
            txtMaVach.Text = string.Empty;
            txtDinhMuc.Text = string.Empty;
            txtSL.Text = string.Empty;
            txtTrangThai.Text = string.Empty;
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
                var test = busQLKHO.KHO_TimKiemHangHoa(txtMaHH.Text);
                foreach (var i in test)
                {
                    if (i == null)
                    {
                        HangHoa hanghoa = new HangHoa(txtMaHH.Text, txtTenHH.Text, cboNH.Text, txtXuatXu.Text, int.Parse(txtGiaNhap.Text), int.Parse(txtGiaBan.Text), txtDVT.Text, cboNCC.Text, txtMaVach.Text, int.Parse(txtDinhMuc.Text), int.Parse(txtSL.Text), Convert.ToBoolean(int.Parse(txtTrangThai.Text)), int.Parse(txtVAT.Text));
                        if (busQLKHO.KHO_ThemHangHoa(hanghoa))
                        {
                            MessageBox.Show("Thêm hàng hóa thành công");
                            HienThiHangHoa();
                        }
                        else
                        {
                            MessageBox.Show("Thêm hàng hóa thất bại");
                        }
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Hàng hóa đã tồn tại");
                    }
                }
            }
            else
            MessageBox.Show("Vui lòng nhập đầy đủ");
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (checktextboxnotnull() == true)
            {
                var test = busQLKHO.KHO_TimKiemHangHoa(txtMaHH.Text);
                foreach (var i in test)
                {
                    if (i == null)
                    {
                        MessageBox.Show("Hàng hóa không tồn tại");
                        return;
                    }
                }
                HangHoa hanghoa = new HangHoa(txtMaHH.Text, txtTenHH.Text, cboNH.Text, txtXuatXu.Text, int.Parse(txtGiaNhap.Text), int.Parse(txtGiaBan.Text), txtDVT.Text, cboNCC.Text, txtMaVach.Text, int.Parse(txtDinhMuc.Text), int.Parse(txtSL.Text), Convert.ToBoolean(int.Parse(txtTrangThai.Text)), int.Parse(txtVAT.Text));
                if (busQLKHO.KHO_SuaHangHoa(hanghoa))
                {
                    MessageBox.Show("Sửa Hàng hóa thành công");
                    HienThiHangHoa();
                }
                else
                {
                    MessageBox.Show("Sửa Hàng Hóa Không Thành Công");
                }
                return;
            }
            MessageBox.Show("Vui lòng nhập đầy đủ");
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (txtMaHH.Text == string.Empty)
            {
                MessageBox.Show("Mã Hàng Hóa không được trống");
                return;
            }
            var test = busQLKHO.KHO_TimKiemHangHoa(txtMaHH.Text);
            foreach(var i in test)
            {
                if (i == null)
                {
                    MessageBox.Show("Hàng hóa không tồn tại");
                    return;
                }
            }
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

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            cleartextbox();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgvHangHoa_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtMaHH.Text = dtgvHangHoa.SelectedRows[0].Cells[0].Value.ToString();
            txtTenHH.Text = dtgvHangHoa.SelectedRows[0].Cells[1].Value.ToString();
            cboNH.Text = dtgvHangHoa.SelectedRows[0].Cells[2].Value.ToString();
            txtXuatXu.Text = dtgvHangHoa.SelectedRows[0].Cells[3].Value.ToString();
            txtGiaNhap.Text = dtgvHangHoa.SelectedRows[0].Cells[4].Value.ToString();
            txtGiaBan.Text = dtgvHangHoa.SelectedRows[0].Cells[5].Value.ToString();
            txtDVT.Text = dtgvHangHoa.SelectedRows[0].Cells[6].Value.ToString();
            cboNCC.Text = dtgvHangHoa.SelectedRows[0].Cells[7].Value.ToString();
            txtMaVach.Text = dtgvHangHoa.SelectedRows[0].Cells[8].Value.ToString();
            txtDinhMuc.Text = dtgvHangHoa.SelectedRows[0].Cells[9].Value.ToString();
            txtSL.Text = dtgvHangHoa.SelectedRows[0].Cells[10].Value.ToString();
            txtTrangThai.Text = dtgvHangHoa.SelectedRows[0].Cells[11].Value.ToString();
            txtVAT.Text = dtgvHangHoa.SelectedRows[0].Cells[12].Value.ToString();
           

           
            
           
        }

        private void btnthongke_Click(object sender, EventArgs e)
        {
            rptHangHoa prthanghoa = new rptHangHoa();
            MessageBox.Show(busQLKHO.KHO_LayDSHH().Count.ToString());
            prthanghoa.SetDataSource(busQLKHO.KHO_LayDSHH());
            frmrpt_HangHoa frm = new frmrpt_HangHoa();
            frm.rptvHangHoa.ReportSource = prthanghoa;
            frm.ShowDialog();
        }
    }
}
