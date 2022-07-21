using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLSieuThi
{
    public class DALBaoCao
    {
        SqlConnection _conn = new SqlConnection(@"Data Source=desktop-hi8uc8m\sqlexpress;Initial Catalog=SieuThiMini;Integrated Security=True");
        public DataTable dshanghoaban()
        {
            _conn.Open();
            DataTable tb = new DataTable();
            string sql = @"select HangHoa.TenHang, sum(HoaDonCT.Soluong) as dem
                            from HangHoa join HoaDonCT on HangHoa.MaHH = HoaDonCT.MaHH
                            Group by HangHoa.TenHang";
            SqlDataAdapter dt = new SqlDataAdapter(sql, _conn);
            dt.Fill(tb);
            _conn.Close();
            return tb;
        }
        public DataTable dsnhanvien()
        {
            _conn.Open();
            string sql = @"select TenQuyen, COUNT(NhanVien.MaQuyen) as dem
                        from PhanQuyen join NhanVien on PhanQuyen.MaQuyen = NhanVien.MaQuyen
                        group by TenQuyen";
            DataTable tb = new DataTable();
            SqlDataAdapter dt = new SqlDataAdapter(sql, _conn);
            dt.Fill(tb);
            _conn.Close();
            return tb;
        }
   
    }
}
