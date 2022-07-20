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
    public partial class frm_KhachHang : Form
    {
        SieuThiMiniEntities db = new SieuThiMiniEntities();
        public frm_KhachHang()
        {
            InitializeComponent();
        }
        void LayDsKhachHang()
        {
            var khachhang = from c in db.KhachHang
                            select new
                            {
                                c.MaKH,
                                c.TenKH,
                                c.CMND,
                                c.DiaChi,
                                c.SDT,
                                c.Diem,
                                c.NgayTao,
                                c.NamGanBo
                            };
            dtgvKH.DataSource = khachhang.ToList();
        }
        bool checktextboxnotnull()
        {
            if(txtMaKH.Text == string.Empty ||
            txtTenKH.Text == string.Empty ||
            txtCMND.Text == string.Empty ||
           txtDiaChi.Text == string.Empty ||
           txtSDT.Text == string.Empty ||
            txtDiem.Text == string.Empty
       )
            {
                return false;
            }
            return true;
        }
        private void frm_KhachHang_Load(object sender, EventArgs e)
        {
            LayDsKhachHang();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (checktextboxnotnull())
            {
                string MaKH = txtMaKH.Text;
                string TenKH = txtTenKH.Text;
                string CMND = txtCMND.Text;
                string DiaChi = txtDiaChi.Text;
                string SDT = txtSDT.Text;
                int Diem = int.Parse(txtDiem.Text);
                string NgayTao = DateTime.Now.ToString("dd/MM/yyyy");
                int NamGanBo = int.Parse(txtNamGanBo.Text);
                foreach(DataGridViewRow i in dtgvKH.Rows)
                {

                    if (i.Cells[0].Value.ToString().Equals(MaKH))
                    {
                        MessageBox.Show("Mã Khách Hàng Đã Tồn Tại");
                        return;
                    }
                }
                try
                {
                    db.KhachHang.Add(new KhachHang(MaKH, TenKH, CMND, DiaChi, SDT, Diem, NgayTao, NamGanBo));
                    db.SaveChanges();
                    MessageBox.Show("Thêm Khách Hàng Thành Công");
                    LayDsKhachHang();
                    return;
                }
                catch (Exception) { }
                MessageBox.Show("Thêm Khách Hàng Thất Bại");

            }
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            txtMaKH.Text = string.Empty;
            txtTenKH.Text = string.Empty;
            txtCMND.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtSDT.Text = string.Empty;
            txtDiem.Text = string.Empty;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (checktextboxnotnull()) { 
            string MaKH = txtMaKH.Text;
            string TenKH = txtTenKH.Text;
            string CMND = txtCMND.Text;
            string DiaChi = txtDiaChi.Text;
            string SDT = txtSDT.Text;
            int Diem = int.Parse(txtDiem.Text);
            string NgayTao = DateTime.Now.ToString("dd/MM/yyyy");
            int NamGanBo = int.Parse(txtNamGanBo.Text);
                try
                {
                    KhachHang nv = db.KhachHang.Find(MaKH);
                    nv.MaKH = MaKH;
                    nv.TenKH = TenKH;
                    nv.CMND = CMND;
                    nv.DiaChi = DiaChi;
                    nv.SDT = SDT;
                    nv.Diem = Diem;
                    nv.NamGanBo = NamGanBo;
                    db.SaveChanges();
                    LayDsKhachHang();
                    MessageBox.Show("Sửa Hàng Hóa THành Công");
                    return;
                }
                catch (Exception) { }
                MessageBox.Show("Sửa Hàng Hóa Thất bại");
            }
        }

        private void dtgvKH_MouseClick(object sender, MouseEventArgs e)
        {
            txtMaKH.Text = dtgvKH.SelectedRows[0].Cells[0].Value.ToString();
            txtTenKH.Text = dtgvKH.SelectedRows[0].Cells[1].Value.ToString();
            txtCMND.Text = dtgvKH.SelectedRows[0].Cells[2].Value.ToString();
            txtDiaChi.Text = dtgvKH.SelectedRows[0].Cells[3].Value.ToString();
            txtSDT.Text = dtgvKH.SelectedRows[0].Cells[4].Value.ToString();
            txtDiem.Text = dtgvKH.SelectedRows[0].Cells[5].Value.ToString();
            txtNamGanBo.Text = dtgvKH.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                KhachHang kh = db.KhachHang.Find(txtMaKH.Text);
                db.KhachHang.Remove(kh);
                db.SaveChanges();
                MessageBox.Show("Xóa Khách Hàng Thành Công");
                LayDsKhachHang();
                return;
            }
            catch (Exception) { }
            MessageBox.Show("Xóa Khách Hàng Thất Bại");
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
