using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLSieuThi
{
    public class DALNhanVien : DbConnect
    {
        public bool ThemNhanVien(NhanVien nv)
        {
            try
            {
                db.NhanVien.Add(nv);
                db.SaveChanges();
                return true;
            }
            catch (Exception) { }
            return false;
        }
        public bool SuaNhanVien(NhanVien nv)
        {
            try
            {
                NhanVien nhanvien = db.NhanVien.Find(nv.MaNV);
                nhanvien.MaNV = nv.MaNV;
                nhanvien.TenNV = nv.TenNV;
                nhanvien.GioiTinh = nv.GioiTinh;
                nhanvien.NgaySinh = nv.NgaySinh;
                nhanvien.SDT = nv.SDT;
                nhanvien.DiaChi = nv.DiaChi;
                nhanvien.Email = nv.Email;
                nhanvien.UserName = nv.UserName;
                nhanvien.Password = nv.Password;
                nhanvien.MaQuyen = nv.MaQuyen;
                nhanvien.NgayVaoLam = nv.NgayVaoLam;
                nhanvien.NgayNghiViec = nv.NgayNghiViec;
                nhanvien.TrangThaiTaiKhoan = nv.TrangThaiTaiKhoan;
                nhanvien.Luong = nv.Luong;
                db.SaveChanges();
                db.SaveChanges();
                return true;

            }
            catch (Exception) { }
            return false;
        }
        public bool XoaNhanVien(string nv)
        {
            try
            {
                NhanVien nhanvien = db.NhanVien.Find(nv);
                db.NhanVien.Remove(nhanvien);
                db.SaveChanges();
                return true;
            }
            catch (Exception) { }
            return false;
        }
    }
}
