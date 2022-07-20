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
    public partial class frm_BaoCao : Form
    {
        SieuThiMiniEntities db = new SieuThiMiniEntities();
        public frm_BaoCao()
        {
            InitializeComponent();
        }
        void adddoanhThu()
        {
            
        }
        private void frm_BaoCao_Load(object sender, EventArgs e)
        {
            chart1.Series["Đã Bán"].Points.Add(10);
            chart1.Series["Đã Bán"].Points.Add(20);
            chart1.Series["Đã Bán"].Points.Add(30);
            chart1.Series["Đã Bán"].Points.Add(40);
            chart1.Series["Đã Bán"].Points.Add(50);
        }
    }
}
