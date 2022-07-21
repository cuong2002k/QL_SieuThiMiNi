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
    public partial class frm_khoNhapHang : Form
    {
        BUSQLyKho busqlykho = new BUSQLyKho();
        SieuThiMiniEntities db = new SieuThiMiniEntities();
        string manv = "NV01";
        public static frm_khoNhapHang frmNH = new frm_khoNhapHang();
        public frm_khoNhapHang()
        {
            InitializeComponent();
            frmNH = this;
        }
        string SoPhieuNhap()
        {
            string sohd = "";
            sohd = DateTime.Now.ToString("MM") + DateTime.Now.ToString("dd") + DateTime.Now.ToString("HH") + DateTime.Now.ToString("mm") + DateTime.Now.ToString("ss");
            return sohd;
        }
        private void frm_khoNhapHang_Load(object sender, EventArgs e)
        {
            dtgvNhaCungCap.DataSource = busqlykho.KHO_LayDSNCC();
           
                        
         }

        private void dtgvNhaCungCap_MouseClick(object sender, MouseEventArgs e)
        {
            string mancc = dtgvNhaCungCap.SelectedRows[0].Cells[0].Value.ToString();
            var dshanghoa = from c in db.HangHoa where c.NhaCungCap == mancc
                            select new {c.MaHH,c.TenHang, c.XuatXu,c.DinhMuc,c.SoLuong};
            dtgvHangHoa.DataSource = dshanghoa.ToList();
                //db.HangHoa.Where(p => p.NhaCungCap == mancc).ToList();
        }

        private void dtgvHangHoa_DoubleClick(object sender, EventArgs e)
        {
            frm_NhapHangChild frm = new frm_NhapHangChild();
            frm.txtMaHH.Text = dtgvHangHoa.SelectedRows[0].Cells[0].Value.ToString();
            frm.txtTenHH.Text = dtgvHangHoa.SelectedRows[0].Cells[1].Value.ToString();
            frm.txtSL.Text = "1";
            frm.btnsua.Visible = false;
            frm.btnxoa.Visible = false;
            frm.ShowDialog();
        }
        public void ThemHangNhap(int SoLuong)
        {
            
            string mahh = dtgvHangHoa.SelectedRows[0].Cells[0].Value.ToString();
            string tenhh = dtgvHangHoa.SelectedRows[0].Cells[1].Value.ToString();
            string xuatxu = dtgvHangHoa.SelectedRows[0].Cells[3].Value.ToString();
            string sl = Convert.ToString(SoLuong);            
            for(int i = 0; i < dtgvHangHoaNhap.Rows.Count; i++)
            {
                
                if (dtgvHangHoaNhap.Rows[i].Cells[1].Value.ToString().Equals(mahh))
                {
                    int soluonghangdatontai = int.Parse(dtgvHangHoaNhap.Rows[i].Cells[4].Value.ToString()) + SoLuong;
                    dtgvHangHoaNhap.Rows[i].Cells[4].Value = soluonghangdatontai.ToString();
                    return;
                }
            }
            dtgvHangHoaNhap.Rows.Add((dtgvHangHoaNhap.Rows.Count+1).ToString(),mahh,tenhh,xuatxu,sl);
        }

    

        private void btnlapphieu_Click_1(object sender, EventArgs e)
        {
            DataTable tb = new DataTable();
            tb.Columns.Add("MaHH", typeof(string));
            tb.Columns.Add("TenHang", typeof(string));
            tb.Columns.Add("XuatXu", typeof(string));
            tb.Columns.Add("SoLuong", typeof(string));
            foreach(DataGridViewRow i in dtgvHangHoaNhap.Rows)
            {
                tb.Rows.Add(i.Cells[1].Value, i.Cells[2].Value, i.Cells[3].Value, i.Cells[4].Value);
            }
            NhanVien nv = db.NhanVien.Find(manv);
            rptPhieuNhapHang rptphieunhap = new rptPhieuNhapHang();
            rptphieunhap.SetDataSource(tb);
            frmrpt_HangHoa frm = new frmrpt_HangHoa();
            frm.rptvHangHoa.ReportSource = rptphieunhap;
            frm.ShowDialog();
        }

     

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn hủy phiếu?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                dtgvHangHoaNhap.Rows.Clear();
            }
            
        }

        private void btnluuphieu_Click(object sender, EventArgs e)
        {
            if(dtgvHangHoaNhap.Rows.Count == 0)
            {
                MessageBox.Show("Vui Lòng Chọn Hàng Hóa Để Nhập");
                return;
            }
            string sophieunhap = SoPhieuNhap();
            DateTime ngaytao = DateTime.Now;
            string nhacungcap = dtgvNhaCungCap.SelectedRows[0].Cells[0].Value.ToString();

            if (busqlykho.KHO_LuuPhieuNhap(new PhieuNhapHang(sophieunhap, manv, ngaytao, nhacungcap)) == true)
            {
                foreach(DataGridViewRow i in dtgvHangHoaNhap.Rows)
                {
                    string maHangNhap = i.Cells[1].Value.ToString();
                    string soPhieu = sophieunhap;
                    int soLuongNhap = int.Parse(i.Cells[4].Value.ToString());
                    int vAT = 0;
                    busqlykho.KHO_LuuPhieuNhapCT(new PhieuNhapHangCT(maHangNhap, soPhieu, soLuongNhap, vAT));
                }
               
                MessageBox.Show("Lưu Phiếu Thành Công");
            }
           
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
