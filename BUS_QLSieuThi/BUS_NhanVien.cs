using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLSieuThi;
namespace BUS_QLSieuThi
{
    public class BUSNhanVien
    {
        DALNhanVien dalnhanvien = new DALNhanVien();
        public bool ThemNhanVien(NhanVien nv)
        {
            return dalnhanvien.ThemNhanVien(nv);
        }
        public bool SuaNhanVien(NhanVien nv)
        {
            return dalnhanvien.SuaNhanVien(nv);
        }
        public bool XoaNhanVien(string nv)
        {
            return dalnhanvien.XoaNhanVien(nv);
        }
    }
}
