using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLSieuThi
{
    public class DALKhachHang : DbConnect
    {
        public bool ThemKhachHang(KhachHang kh)
        {
            try
            {
                KhachHang nv = db.KhachHang.Find(kh.MaKH);
                return true;
            }
            catch (Exception) { }
            return false;
        }
    }
}
