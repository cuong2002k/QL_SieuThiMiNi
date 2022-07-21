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
    public partial class frm_KhoXuatHang : Form
    {
        public static frm_KhoXuatHang frmxh = new frm_KhoXuatHang();
        SieuThiMiniEntities db = new SieuThiMiniEntities();
        string manv = "NV012";
        public frm_KhoXuatHang()
        {
            InitializeComponent();
            frmxh = this;
        }
        void laydshh()
        {
            var hh = from c in db.HangHoa select new { c.MaHH, c.TenHang, c.SoLuong, c.DinhMuc };
            dtgvHangHoa.DataSource = hh.ToList();
        }
        private void frm_KhoXuatHang_Load(object sender, EventArgs e)
        {
            laydshh();
        }

        private void dtgvHangHoa_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void dtgvHangHoa_DoubleClick(object sender, EventArgs e)
        {
            frm_KhoXuatHangchild frm = new frm_KhoXuatHangchild();
            frm.txtMaHH.Text = dtgvHangHoa.SelectedRows[0].Cells[1].Value.ToString();
            frm.txtTenHH.Text = dtgvHangHoa.SelectedRows[0].Cells[2].Value.ToString();
            frm.txtSL.Text = "1";
            frm.ShowDialog();
        }
        
        public void themhangxuat(int soluong)
        {
            if(int.Parse(dtgvHangHoa.SelectedRows[0].Cells[2].Value.ToString()) < soluong)
            {
                MessageBox.Show("Số Lượng Không Phù Hợp");
                return;
            }
            int stt = dtgvHangHoaXuat.Rows.Count + 1;
            string mahh = dtgvHangHoa.SelectedRows[0].Cells[0].Value.ToString();
            string tenhh = dtgvHangHoa.SelectedRows[0].Cells[1].Value.ToString();
            for(int i = 0; i < dtgvHangHoaXuat.Rows.Count; i++)
            {
                if (dtgvHangHoaXuat.Rows[i].Cells[1].Value.ToString().Equals(mahh))
                {
                    dtgvHangHoaXuat.Rows[i].Cells[3].Value = (int.Parse(dtgvHangHoaXuat.Rows[i].Cells[3].Value.ToString()) + soluong).ToString();
                     return;
                }
            }
            dtgvHangHoaXuat.Rows.Add(stt.ToString(), mahh, tenhh, soluong.ToString());
        }
        string SoPhieuXuat()
        {
            string sohd = "";
            sohd = DateTime.Now.ToString("dd") + DateTime.Now.ToString("HH")+ DateTime.Now.ToString("MM")  + DateTime.Now.ToString("mm") + DateTime.Now.ToString("ss");
            return sohd;
        }
        private void btnlapphieu_Click(object sender, EventArgs e)
        {
            DataTable tb = new DataTable();
            tb.Columns.Add("SoPhieuTra", typeof(string));
            tb.Columns.Add("TenNV", typeof(string));
            tb.Columns.Add("MaHH", typeof(string));
            tb.Columns.Add("TenHH", typeof(string));
            tb.Columns.Add("SoLuong", typeof(string));

            string sophieu = SoPhieuXuat();
            var nv = db.NhanVien.Where(p => p.MaNV == manv).SingleOrDefault();
            string tennv = nv.TenNV;
            foreach (DataGridViewRow i in dtgvHangHoaXuat.Rows)
            {
                tb.Rows.Add(sophieu, tennv, i.Cells[1].Value.ToString(), i.Cells[2].Value.ToString(), i.Cells[3].Value.ToString());
            }
            rptPhieuTraHang rptnhaphang = new rptPhieuTraHang();
            rptnhaphang.SetDataSource(tb);

            // form
            frmrpt_HangHoa frmrpt = new frmrpt_HangHoa();
            frmrpt.rptvHangHoa.ReportSource = rptnhaphang;
            frmrpt.ShowDialog();
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            dtgvHangHoaXuat.Rows.Clear();
        }
    }
}
