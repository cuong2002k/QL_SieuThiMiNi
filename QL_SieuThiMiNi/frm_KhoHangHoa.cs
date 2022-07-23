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
//3 thu vien can them vao
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;
namespace QL_SieuThiMiNi
{
    public partial class frm_KhoHangHoa : Form
    {
        BUSQLyKho busQLKHO = new BUSQLyKho();
        SieuThiMiniEntities db = new SieuThiMiniEntities();
        string mahh()
        {
            string mahh = DateTime.Now.ToString("MM")
                          + DateTime.Now.ToString("dd")
                          + DateTime.Now.ToString("HH")
                          + DateTime.Now.ToString("mm")
                          + DateTime.Now.ToString("ss");
            return mahh;
        }
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
            txtMaHH.Text = mahh();
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
            //910
            foreach(DataGridViewRow row in dtgvHangHoa.Rows)
            {
                if(int.Parse(row.Cells[10].Value.ToString())>= int.Parse(row.Cells[10].Value.ToString()))
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
            }
            
        }
        private void frm_KhoHangHoa_Load(object sender, EventArgs e)
        {
            HienThiHangHoa();
            var dbncc = busQLKHO.KHO_LayDSNCC();
            foreach (var i in dbncc)
            {
                cboNCC.Items.Add(i.TenNCC);
            }
            var dbNH = busQLKHO.KHO_LayDSNH();
            foreach(var i in dbNH)
            {
                cboNH.Items.Add(i.TenNH);
            }
            txtMaHH.Text = mahh();
            txtTrangThai.Items.Add("True");
            txtTrangThai.Items.Add("False");
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
          
            if (checktextboxnotnull() == true)
            {
                var test = busQLKHO.KHO_TimKiemHangHoa(txtMaHH.Text);
                foreach (var i in test)
                {
                    if (i == null)
                    {
                        var nh = db.NhomHang.Where(p => p.TenNH == cboNH.Text).SingleOrDefault();
                        var ncc = db.NhaCungCap.Where(p => p.TenNCC == cboNCC.Text).SingleOrDefault();
                        HangHoa hanghoa = new HangHoa(txtMaHH.Text, txtTenHH.Text, nh.MaNH, txtXuatXu.Text, int.Parse(txtGiaNhap.Text), int.Parse(txtGiaBan.Text), txtDVT.Text, ncc.MaNCC, txtMaVach.Text, int.Parse(txtDinhMuc.Text), int.Parse(txtSL.Text),txtTrangThai.Text=="True"?true : false, int.Parse(txtVAT.Text));
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
                var nh = db.NhomHang.Where(p => p.TenNH == cboNH.Text).SingleOrDefault();
                var ncc = db.NhaCungCap.Where(p => p.TenNCC == cboNCC.Text).SingleOrDefault();
                HangHoa hanghoa = new HangHoa(txtMaHH.Text, txtTenHH.Text, nh.MaNH, txtXuatXu.Text, int.Parse(txtGiaNhap.Text), int.Parse(txtGiaBan.Text), txtDVT.Text, ncc.MaNCC, txtMaVach.Text, int.Parse(txtDinhMuc.Text), int.Parse(txtSL.Text), txtTrangThai.Text == "True" ? true : false, int.Parse(txtVAT.Text));
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
            string manh = dtgvHangHoa.SelectedRows[0].Cells[2].Value.ToString();
            var nh = db.NhomHang.Where(p => p.MaNH == manh).SingleOrDefault();
            cboNH.Text = nh.TenNH;
            txtXuatXu.Text = dtgvHangHoa.SelectedRows[0].Cells[3].Value.ToString();
            txtGiaNhap.Text = dtgvHangHoa.SelectedRows[0].Cells[4].Value.ToString();
            txtGiaBan.Text = dtgvHangHoa.SelectedRows[0].Cells[5].Value.ToString();
            txtDVT.Text = dtgvHangHoa.SelectedRows[0].Cells[6].Value.ToString();
            string mancc = dtgvHangHoa.SelectedRows[0].Cells[7].Value.ToString();
            var ncc = db.NhaCungCap.Where(p => p.MaNCC == mancc).SingleOrDefault();
            cboNCC.Text = ncc.TenNCC;

            txtMaVach.Text = dtgvHangHoa.SelectedRows[0].Cells[8].Value.ToString();
            txtDinhMuc.Text = dtgvHangHoa.SelectedRows[0].Cells[9].Value.ToString();
            txtSL.Text = dtgvHangHoa.SelectedRows[0].Cells[10].Value.ToString();
            txtTrangThai.Text = dtgvHangHoa.SelectedRows[0].Cells[11].Value.ToString();
            txtVAT.Text = dtgvHangHoa.SelectedRows[0].Cells[12].Value.ToString();
        }

        private void btnthongke_Click(object sender, EventArgs e)
        {
            rptHangHoa prthanghoa = new rptHangHoa();
            //MessageBox.Show(busQLKHO.KHO_LayDSHH().Count.ToString());
            prthanghoa.SetDataSource(busQLKHO.KHO_LayDSHH());
            frmrpt_HangHoa frm = new frmrpt_HangHoa();
            frm.rptvHangHoa.ReportSource = prthanghoa;
            frm.ShowDialog();
        }

        private void dtgvHangHoa_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
        }

        private void dtgvHangHoa_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if(int.Parse(dtgvHangHoa.Rows[e.RowIndex].Cells[10].Value.ToString()) - int.Parse(dtgvHangHoa.Rows[e.RowIndex].Cells[9].Value.ToString()) <= 10){
                dtgvHangHoa.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
            }
            else
            {
                dtgvHangHoa.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            }
        }
        private void ExportExcel(string path)
        {
            //khoi tao file excels
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);
            //Tao Cot Cho File Excels
            for(int i = 0; i < dtgvHangHoa.Columns.Count; i++)
            {
                application.Cells[1,i+1] = dtgvHangHoa.Columns[i].HeaderText;
            }
            for(int i = 0; i < dtgvHangHoa.Rows.Count; i++)
            {
                for(int j  = 0; j < dtgvHangHoa.Columns.Count; j++)
                {
                    application.Cells[i + 2, j + 1] ="'" + dtgvHangHoa.Rows[i].Cells[j].Value.ToString();
                }
            }
            //dan dong ra cho de nhin
            application.Columns.AutoFit();
            //save file excel
            application.ActiveWorkbook.SaveCopyAs(path);
            application.ActiveWorkbook.Saved = true;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Title = "Export Excel";
            savefile.Filter = "Excel 2003(*.xls)|*.xls";
            if(savefile.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    ExportExcel(savefile.FileName);
                    MessageBox.Show("Xuat File Thanh Cong");
                }
                catch (Exception er)
                {
                    MessageBox.Show("Xuat File That Bai");
                }
            }
        }
    }
}
