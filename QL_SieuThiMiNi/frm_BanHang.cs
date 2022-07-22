using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using DAL_QLSieuThi;
namespace QL_SieuThiMiNi
{
    public partial class frm_BanHang : Form
    {
        string manv = "NV012";
        public frm_BanHang()
        {
            InitializeComponent();
           
        }
        SieuThiMiniEntities db = new SieuThiMiniEntities();
        private void btntimkiemkhachang_Click(object sender, EventArgs e)
        {
            
        }
        
        private void txtMavach_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(txtMavach.Text == string.Empty)
                {
                    MessageBox.Show("Vui Lòng Nhập Mã Hàng Hóa");
                    return;
                }
                HangHoa hh = db.HangHoa.Where(p => p.MaVach == txtMavach.Text).SingleOrDefault();
                if(hh == null)
                {
                    MessageBox.Show("Hàng Hóa Không Tồn tại");
                    txtMavach.Clear();
                    return;
                }
                for(int i = 0; i < dtgvHangHoaBan.Rows.Count - 1; i++)
                {
                    if (dtgvHangHoaBan.Rows[i].Cells[1].Value.ToString().Equals(txtMavach.Text))
                    {
                        int soluongban = int.Parse(dtgvHangHoaBan.Rows[i].Cells[3].Value.ToString()) + 1;
                        dtgvHangHoaBan.Rows[i].Cells[3].Value = (soluongban).ToString();
                        //tien thanh toan
                        int tienthanhtoan = int.Parse(btnTienThanhToan.Text);
                        int dongia = int.Parse(dtgvHangHoaBan.Rows[i].Cells[4].Value.ToString());
                        btnTienThanhToan.Text = (tienthanhtoan + dongia).ToString();
                        txtMavach.Clear();
                        return;
                    }
                }
                dtgvHangHoaBan.Rows.Add(dtgvHangHoaBan.Rows.Count.ToString(),hh.MaVach, hh.TenHang, 1, hh.GiaBan);
                int tien = int.Parse(btnTienThanhToan.Text);
                btnTienThanhToan.Text = (tien + hh.GiaBan).ToString();
                txtMavach.Clear();
            }
        }

        private void btnsearchKH_Click(object sender, EventArgs e)
        {
            if (btnsearchKH.Text == "Tìm kiếm KH")
            {
                btnsearchKH.Text = "Đóng Tìm kiếm";
                txtMaKH.Text = "";
                pneTimkiemKhachHang.Visible = true;
            }
            else
            {
                txtMaKH.Text = "none";
                btnsearchKH.Text = "Tìm kiếm KH";
                pneTimkiemKhachHang.Visible = false;
            }
        }

        private void txtMaKH_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(txtMaKH.Text != string.Empty)
                {
                    KhachHang KH = db.KhachHang.Where(p => p.MaKH == txtMaKH.Text).SingleOrDefault();
                    if(KH == null)
                    {
                        MessageBox.Show("Khách Hàng Không Tồn Tại");
                        txtMaKH.Text = "";
                        return;
                    }
                    txtTenKH.Text = KH.TenKH;
                    txtDiem.Text =  KH.Diem.ToString();
                    txtMaKH.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Vui Lòng Nhập Mã Khách Hàng");
                    
                }
            }
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            dtgvHangHoaBan.Rows.Clear();
        }
        string SoHD()
        {
            string sohd = "";
            sohd = DateTime.Now.ToString("dd") + DateTime.Now.ToString("MM") + DateTime.Now.ToString("HH") + DateTime.Now.ToString("mm") + DateTime.Now.ToString("ss");
            return sohd;
        }
       

        private void txtTienKhachDua_TextChanged(object sender, EventArgs e)
        {
            if (txtTienKhachDua.Text == string.Empty)
            {
                txtTienKhachDua.Text = "0";
                    return;
            }
            if(int.Parse(txtTienKhachDua.Text) - int.Parse(btnTienThanhToan.Text) >= 0 && int.Parse(txtTienKhachDua.Text) >0)
            {
                btnTienThanhToan.Enabled = true;
                txtTienGuiKhach.Text = (int.Parse(txtTienKhachDua.Text) - int.Parse(btnTienThanhToan.Text)).ToString();
            }
            else
            {
                btnTienThanhToan.Enabled = false;
                txtTienGuiKhach.Text = "0";
            }
        }
        void xuathoadon(string sohd)
        {
            NhanVien nv = db.NhanVien.Where(p => p.MaNV == manv).SingleOrDefault();
            DataTable tb = new DataTable();
            tb.Columns.Add("SoHD", typeof(string));
            tb.Columns.Add("TenHang", typeof(string));
            tb.Columns.Add("SoLuong", typeof(int));
            tb.Columns.Add("DonGia", typeof(int));
            
            foreach(DataGridViewRow i in dtgvHangHoaBan.Rows)
            {
                if (i.Cells[1].Value == null) break;
                tb.Rows.Add(sohd, i.Cells[2].Value.ToString(), int.Parse(i.Cells[3].Value.ToString()), int.Parse(i.Cells[4].Value.ToString()));
            }
            

            rptHoaDon rpthoadon = new rptHoaDon();
            TextObject nhanvien = (TextObject)rpthoadon.ReportDefinition.Sections["Section1"].ReportObjects["NhanVien"];
            TextObject tientrakhach = (TextObject)rpthoadon.ReportDefinition.Sections["Section4"].ReportObjects["TienTraKhach"];
            tientrakhach.Text = txtTienGuiKhach.Text;
            nhanvien.Text = nv.TenNV;
            rpthoadon.SetDataSource(tb);
            frmrpt_HangHoa frmrpt = new frmrpt_HangHoa();
            frmrpt.rptvHangHoa.ReportSource = rpthoadon;
            frmrpt.ShowDialog();
        }
        private void btnTienThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                string sohd = SoHD();
                string NgayLap = DateTime.Now.ToString("dd/MM/yyyy");
                string MaKh = txtMaKH.Text;
                int VAT = 0;
                int tienkhachdua = int.Parse(txtTienKhachDua.Text);
                int tienguikhach = int.Parse(txtTienGuiKhach.Text);
                int TongTienTT = int.Parse(btnTienThanhToan.Text);
                db.HoaDon.Add(new HoaDon(sohd, manv, NgayLap, MaKh, VAT, tienkhachdua, tienguikhach, TongTienTT));
                db.SaveChanges();
                foreach (DataGridViewRow i in dtgvHangHoaBan.Rows)
                {
                    if (i.Cells[1].Value == null) break;
                    string mavach = i.Cells[1].Value.ToString();
                    HangHoa hh = db.HangHoa.Where(p => p.MaVach == mavach).SingleOrDefault();
                    string mahh = hh.MaHH;
                    int sl = int.Parse(i.Cells[3].Value.ToString());
                    int dongia = int.Parse(i.Cells[4].Value.ToString());
                    int thanhtien = sl * dongia;
                    db.HoaDonCT.Add(new HoaDonCT(sohd, mahh, sl, dongia, thanhtien, VAT));
                    HangHoa dbhh = db.HangHoa.Where(p => p.MaHH == mahh).SingleOrDefault();
                    dbhh.SoLuong -= sl;
                    db.SaveChanges();
                }
                db.SaveChanges();
                //hoadon
                xuathoadon(sohd);

                //
                MessageBox.Show("Thanh Toán Thành Công");

                return;
            }
            catch (Exception) { }
            MessageBox.Show("Thanh Toán Không Thành Công");
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
