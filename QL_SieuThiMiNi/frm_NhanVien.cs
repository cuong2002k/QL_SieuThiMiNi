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
    public partial class frm_NhanVien : Form
    {
        SieuThiMiniEntities db = new SieuThiMiniEntities();
        BUSQLyKho qlykho = new BUSQLyKho();
        BUSNhanVien busnhanvien = new BUSNhanVien();
        string manv()
        {
            string mahh = DateTime.Now.ToString("MM")
                          + DateTime.Now.ToString("dd")
                          + DateTime.Now.ToString("mm")
                          + DateTime.Now.ToString("ss")
                          + DateTime.Now.ToString("HH");
            return mahh;
        }
        public frm_NhanVien()
        {
            InitializeComponent();
            var maquyen = from c in db.PhanQuyen select new {  c.TenQuyen };
            foreach (var i in maquyen.ToList())
            {
                cboQuyen.Items.Add(i.TenQuyen);
            }
            cboGioiTinh.Items.Add(true);
            cboGioiTinh.Items.Add(false);
            cboGioiTinh.SelectedIndex = 0;
            cboQuyen.SelectedIndex = 0;
        }
        bool checktextboxnotnull()
        {
            if (txtMaNV.Text == string.Empty ||
               txtTenNV.Text == string.Empty ||
               cboGioiTinh.Text == string.Empty ||
               txtNgaySinh.Text == string.Empty ||
               txtSDT.Text == string.Empty ||
               txtDiaChi.Text == string.Empty ||
                txtEmail.Text == string.Empty ||
                txtUserName.Text == string.Empty ||
                txtPassword.Text == string.Empty ||
                cboQuyen.Text == string.Empty ||
                txtNgayBD.Text == string.Empty ||
                txtNgayKT.Text == string.Empty ||
                txtTrangThai.Text == string.Empty ||
                txtLuong.Text == string.Empty
                )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhân viên");
            }
              

            return true;
        }
        void LayDSNV()
        {
            
            var nv = from c in db.NhanVien
                     select new
                     {
                         c.MaNV,
                         c.TenNV,
                         c.GioiTinh,
                         c.NgaySinh,
                         c.SDT,
                         c.DiaChi,
                         c.Email,
                         c.UserName,
                         c.Password,
                         c.MaQuyen,
                         c.NgayVaoLam,
                         c.NgayNghiViec,
                         c.TrangThaiTaiKhoan,
                         c.Luong
                     }; 
            
            dtgvNhanVien.DataSource = nv.ToList();
           
        }
        private void frm_NhanVien_Load(object sender, EventArgs e)
        {
            LayDSNV();
            txtMaNV.Text = manv();
           
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (checktextboxnotnull() == true)
            {
                string MaNV = txtMaNV.Text;
                string TenNV = txtTenNV.Text;
                bool GioiTinh = cboGioiTinh.Text == "True" ? true : false;
                string NgaySinh = txtNgaySinh.Text;
                string SDT = txtSDT.Text;
                string DiaChi = txtDiaChi.Text;
                string Email = txtEmail.Text;
                string UserName = txtUserName.Text;
                string Password = txtPassword.Text;
                var quyen = db.PhanQuyen.Where(p => p.TenQuyen == cboQuyen.Text).SingleOrDefault();
                string MaQuyen = quyen.MaQuyen;
                string NgayVaoLam = txtNgayBD.Text;
                string NgayNghiViec = txtNgayKT.Text;
                bool TrangThaiTaiKhoan = txtTrangThai.Text == "True" ? true : false;
                int Luong = int.Parse(txtLuong.Text);
                foreach(DataGridViewRow i in dtgvNhanVien.Rows)
                {
                    if (i.Cells[0].Value.Equals(MaNV))
                    {
                        MessageBox.Show("Mã Nhân Viên Đã Tồn Tại");
                        return;
                    }
                }
               
                try
                {
                    db.NhanVien.Add(new NhanVien(MaNV, TenNV, GioiTinh, NgaySinh,
                    SDT, DiaChi, Email, UserName, Password, MaQuyen, NgayVaoLam,
                    NgayNghiViec, TrangThaiTaiKhoan, Luong));
                    db.SaveChanges();
                    LayDSNV();
                    MessageBox.Show("Thêm nhân viên thành công");
                    return;
                }
                catch (Exception) { }
                MessageBox.Show("Thêm nhân viên thất bại");
            }
           
            
    }

        private void dtgvNhanVien_MouseClick(object sender, MouseEventArgs e)
        {
            txtMaNV.Text = dtgvNhanVien.SelectedRows[0].Cells[0].Value.ToString();
            txtTenNV.Text = dtgvNhanVien.SelectedRows[0].Cells[1].Value.ToString();
            cboGioiTinh.Text = dtgvNhanVien.SelectedRows[0].Cells[2].Value.ToString();
            txtNgaySinh.Text = dtgvNhanVien.SelectedRows[0].Cells[3].Value.ToString();
            txtSDT.Text = dtgvNhanVien.SelectedRows[0].Cells[4].Value.ToString();
            txtDiaChi.Text = dtgvNhanVien.SelectedRows[0].Cells[5].Value.ToString();
            txtEmail.Text = dtgvNhanVien.SelectedRows[0].Cells[6].Value.ToString();
            txtUserName.Text = dtgvNhanVien.SelectedRows[0].Cells[7].Value.ToString();
            txtPassword.Text = dtgvNhanVien.SelectedRows[0].Cells[8].Value.ToString();
            string maquyen = dtgvNhanVien.SelectedRows[0].Cells[9].Value.ToString();
            var quyen = db.PhanQuyen.Where(p => p.MaQuyen == maquyen).SingleOrDefault();
            cboQuyen.Text = quyen.TenQuyen;

            txtNgayBD.Text = dtgvNhanVien.SelectedRows[0].Cells[10].Value.ToString();
            txtNgayKT.Text = "None";
            txtTrangThai.Text = dtgvNhanVien.SelectedRows[0].Cells[12].Value.ToString();
            txtLuong.Text = dtgvNhanVien.SelectedRows[0].Cells[13].Value.ToString();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            txtMaNV.Text = manv();
            txtTenNV.Text = string.Empty;
            cboGioiTinh.Text = string.Empty;
            txtNgaySinh.Text = string.Empty;
            txtSDT.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtUserName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            cboQuyen.Text = string.Empty;
            txtNgayBD.Text = string.Empty;
            txtNgayKT.Text = string.Empty;
            txtTrangThai.Text = string.Empty;
            txtLuong.Text = string.Empty;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string MaNV = txtMaNV.Text;
            string TenNV = txtTenNV.Text;
            bool GioiTinh = cboGioiTinh.Text == "True" ? true : false;
            string NgaySinh = txtNgaySinh.Text;
            string SDT = txtSDT.Text;
            string DiaChi = txtDiaChi.Text;
            string Email = txtEmail.Text;
            string UserName = txtUserName.Text;
            string Password = txtPassword.Text;
            var quyen = db.PhanQuyen.Where(p => p.TenQuyen == cboQuyen.Text).SingleOrDefault();
            string MaQuyen = quyen.MaQuyen;
            string NgayVaoLam = txtNgayBD.Text;
            string NgayNghiViec = txtNgayKT.Text;
            bool TrangThaiTaiKhoan = txtTrangThai.Text == "True" ? true : false;
            int Luong = int.Parse(txtLuong.Text);
            if (checktextboxnotnull() == true)
            {
                if (busnhanvien.SuaNhanVien(new NhanVien(MaNV, TenNV, GioiTinh, NgaySinh,
                    SDT, DiaChi, Email, UserName, Password, MaQuyen, NgayVaoLam,
                    NgayNghiViec, TrangThaiTaiKhoan, Luong)) == true)
                {
                    MessageBox.Show("Sửa thông tin nhan viên thành công");
                    LayDSNV();
                }
                else
                {
                    MessageBox.Show("Sửa thông tin nhan viên thất bại");
                }
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if(busnhanvien.XoaNhanVien(txtMaNV.Text) == true)
            {
                MessageBox.Show("Xóa Nhân Viên Thành Công");
                LayDSNV();
            }
            else
            {
                MessageBox.Show("Xóa Nhân Viên Thất bại");
            }
        }
    }
}
