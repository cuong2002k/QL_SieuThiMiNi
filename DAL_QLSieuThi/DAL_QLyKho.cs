using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLSieuThi
{
    public class  DALQLyKho : DbConnect
    {
        
        public List<HangHoa> KHO_LayDSHH()
        {
            return db.HangHoa.ToList();
        }
        public List<NhomHang> KHO_LayDSNH()
        {
            return db.NhomHang.ToList();
        }
        public List<NhaCungCap> KHO_LayDSNCC()
        {
            return db.NhaCungCap.ToList();
        }
        public Boolean KHO_ThemHangHoa(HangHoa hanghoa)
        {
            try
            {
                db.HangHoa.Add(hanghoa);
                db.SaveChanges();
                return true;
            }
            catch (Exception) { }
            return false;
        }
        public Boolean KHO_SuaHangHoa(HangHoa hanghoa)
        {
            try
            {
                HangHoa hh = db.HangHoa.Find(hanghoa.MaHH);
                hh.MaHH = hanghoa.MaHH;
                hh.TenHang = hanghoa.TenHang;
                hh.MaNH = hanghoa.MaNH;
                hh.XuatXu = hanghoa.XuatXu;
                hh.GiaNhap = hanghoa.GiaNhap;
                hh.GiaBan = hanghoa.GiaBan;
                hh.DonViTinh = hanghoa.DonViTinh;
                hh.NhaCungCap = hanghoa.NhaCungCap;
                hh.MaVach = hanghoa.MaVach;
                hh.DinhMuc = hanghoa.DinhMuc;
                hh.SoLuong = hanghoa.SoLuong;
                hh.TrangThaiBan = hanghoa.TrangThaiBan;
                hh.VAT = hanghoa.VAT;
           
               db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

            }
            return false;
        }
        public Boolean KHO_XoaHangHoa(string MaHH)
        {
            try
            {
                HangHoa hh = db.HangHoa.Find(MaHH);
                db.HangHoa.Remove(hh);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

            }
            return false;
        }

    }
}
