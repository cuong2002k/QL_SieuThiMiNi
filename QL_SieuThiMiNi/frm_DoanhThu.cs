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
    public partial class frm_DoanhThu : Form
    {
        public frm_DoanhThu()
        {
            InitializeComponent();
        }
        SieuThiMiniEntities db = new SieuThiMiniEntities();
        int test(string month)
        {
            int Tien = 0;
            var hd = db.HoaDon.ToList();
            foreach(var i in hd)
            {
                DateTime temp = DateTime.ParseExact(i.NgayLap, "dd/MM/yyyy", null);
                if (temp.ToString("MM").Equals(month))
                {
                    Tien += i.ThanhTien;
                }
                
            }
            return Tien;
        }
        int tongdoanhthu()
        {
            int Tien = 0;
            var hd = db.HoaDon.ToList();
            foreach (var i in hd)
            {
                Tien += i.ThanhTien;

            }
            return Tien;
        }
        int tongdonhang()
        {
     
            var hd = db.HoaDon.ToList();
            return hd.Count;
        }
        int sosptrongkho()
        {
            return db.HangHoa.ToList().Count;
        }
        private void frm_DoanhThu_Load(object sender, EventArgs e)
        {
            chartdoanhthu.Series["Salary"].Points.Add(test("01"));
            chartdoanhthu.Series["Salary"].Points[0].Label = test("01").ToString();

            chartdoanhthu.Series["Salary"].Points.Add(test("02"));
            chartdoanhthu.Series["Salary"].Points[1].Label = test("02").ToString();

            chartdoanhthu.Series["Salary"].Points.Add(test("03"));
            chartdoanhthu.Series["Salary"].Points[2].Label = test("03").ToString();

            chartdoanhthu.Series["Salary"].Points.Add(test("04"));
            chartdoanhthu.Series["Salary"].Points[3].Label = test("04").ToString();

            chartdoanhthu.Series["Salary"].Points.Add(test("05"));
            chartdoanhthu.Series["Salary"].Points[4].Label = test("05").ToString();

            chartdoanhthu.Series["Salary"].Points.Add(test("06"));
            chartdoanhthu.Series["Salary"].Points[5].Label = test("06").ToString();

            chartdoanhthu.Series["Salary"].Points.Add(test("07"));
            chartdoanhthu.Series["Salary"].Points[6].Label = test("07").ToString();

            chartdoanhthu.Series["Salary"].Points.Add(test("08"));
            chartdoanhthu.Series["Salary"].Points[7].Label = test("08").ToString();

            chartdoanhthu.Series["Salary"].Points.Add(test("09"));
            chartdoanhthu.Series["Salary"].Points[8].Label = test("09").ToString();

            chartdoanhthu.Series["Salary"].Points.Add(test("10"));
            chartdoanhthu.Series["Salary"].Points[9].Label = test("10").ToString();

            chartdoanhthu.Series["Salary"].Points.Add(test("11"));
            chartdoanhthu.Series["Salary"].Points[10].Label = test("11").ToString();

            chartdoanhthu.Series["Salary"].Points.Add(test("12"));
            chartdoanhthu.Series["Salary"].Points[11].Label = test("12").ToString();

            lblTongDoanhThu.Text = tongdoanhthu().ToString();
            lblDonHang.Text = tongdonhang().ToString();
            lblsptrongkho.Text = sosptrongkho().ToString();
        }
    }
}
