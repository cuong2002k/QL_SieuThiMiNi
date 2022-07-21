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
    public partial class frm_BaoCao : Form
    {
        SieuThiMiniEntities db = new SieuThiMiniEntities();
        BusBaoCao bc = new BusBaoCao();
        public frm_BaoCao()
        {
            InitializeComponent();
          
        }
        void adddoanhThu()
        {
            DataTable tb = bc.dshanghoaban();
            DataTable tbnv = bc.dsnhanvien();
            List<KeyValuePair<string,int>> lst = new List<KeyValuePair<string, int>>();
            List<KeyValuePair<string, int>> lstnv = new List<KeyValuePair<string, int>>();
            for (int i = 0; i <  tb.Rows.Count; i++)
            {
                lst.Add(new KeyValuePair<string, int>(tb.Rows[i][0].ToString(), int.Parse(tb.Rows[i][1].ToString())));
                //MessageBox.Show(tb.Rows[i][0].ToString());
            }

            for (int i = 0; i < tbnv.Rows.Count; i++)
            {
                lstnv.Add(new KeyValuePair<string, int>(tbnv.Rows[i][0].ToString(), int.Parse(tbnv.Rows[i][1].ToString())));
                //MessageBox.Show(tb.Rows[i][0].ToString());
            }
            lst.Sort((x,y) => y.Value.CompareTo(x.Value));
            int k = 0;
            foreach(var i in lst)
            {
                
                chart1.Series["Đã Bán"].Points.Add(int.Parse(i.Value.ToString()));
                chart1.Series["Đã Bán"].Points[k].Label = i.Key.ToString();
                k++;
                if (k == 4) break;
                //i.Value.ToString();
            }
            int z = 0;
            foreach(var i in lstnv)
            {
                chart2.Series["Nhân Viên"].Points.Add(int.Parse(i.Value.ToString()));
                chart2.Series["Nhân Viên"].Points[z].Label = i.Key.ToString();
                z++;
            }
                    
        }
        private void frm_BaoCao_Load(object sender, EventArgs e)
        {
           
            adddoanhThu();
        }
    }
}
