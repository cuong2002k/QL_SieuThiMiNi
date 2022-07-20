using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLSieuThi
{
    public class  DALQLyKho : DbConnect
    {
        
       
        
        //----------------------------------hang hoa-------------------------------------------------------//
        public List<HangHoa> KHO_LayDSHH()
        {
            return db.HangHoa.ToList();
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
        public List<HangHoa> KHO_TimKiemHangHoa(string MaHH)
        {
            HangHoa hh = db.HangHoa.Where(p => p.MaHH == MaHH).SingleOrDefault();
            List<HangHoa> tb = new List<HangHoa>();
            tb.Add(hh);
            return tb;
        }
        //-----------------------------------------hang hoa end------------------------------------------------//
        //-----------------------------------------nha cung cap------------------------------------------------//
        //hien thi
        public List<NhaCungCap> KHO_LayDSNCC()
        {
            return db.NhaCungCap.ToList();
        }  
        //them 
        public bool Kho_ThemNhaCungCap(NhaCungCap nhacungcap)
        {
            try
            {
                db.NhaCungCap.Add(nhacungcap);
                db.SaveChanges();
                return true;
            }
            catch (Exception) { }
            return false;
        }
        //xoa
        public bool Kho_XoaNhaCungCap(string MaNCC)
        {
            try
            {
                NhaCungCap nhacungcap = db.NhaCungCap.Where(p => p.MaNCC == MaNCC).FirstOrDefault();
                db.NhaCungCap.Remove(nhacungcap);
                db.SaveChanges();
                return true;
            }
            catch (Exception) { }
            return false;
        }
        //sua
        public bool Kho_SuaNhaCungCap(NhaCungCap ncc)
        {
            try
            {
                NhaCungCap nhacungcap = db.NhaCungCap.Find(ncc.MaNCC);
                nhacungcap.MaNCC = ncc.MaNCC;
                nhacungcap.TenNCC = ncc.TenNCC;
                nhacungcap.DiaChi = ncc.DiaChi;
                nhacungcap.SDT = ncc.SDT;
                db.SaveChanges();
                return true;
            }
            catch (Exception) { }
            return false;
        }
        //tim kiem
        public List<NhaCungCap> KHO_TimNCC(string mancc)
        {
            List<NhaCungCap> lstncc = new List<NhaCungCap>();
            NhaCungCap nhacungcap = db.NhaCungCap.Find(mancc);
            lstncc.Add(nhacungcap);
            
            return lstncc;
        }
        //-----------------------------------------nha cung cap end------------------------------------------------//


        //-----------------------------------------nhóm hàng------------------------------------------------//
        //hienthi
        public List<NhomHang> KHO_LayDSNH()
        {
            return db.NhomHang.ToList();
        }
        //them 
        public bool KHO_ThemNH(NhomHang nhomhang)
        {
            try
            {
                db.NhomHang.Add(nhomhang);
                db.SaveChanges();
                return true;
            }
            catch { }
            return false;
        }
        //xoa
        public bool KHO_XoaNH(string MaNH)
        {
            try
            {
                db.NhomHang.Remove(db.NhomHang.Find(MaNH));
                db.SaveChanges();
                return true;
            }
            catch { }
            return false;
        }
        //sua
        public bool KHO_SuaNH(NhomHang nhomhang)
        {
            try
            {
                NhomHang nh = db.NhomHang.Find(nhomhang.MaNH);
                nh.MaNH = nhomhang.MaNH;
                nh.TenNH = nhomhang.TenNH;

                db.SaveChanges();
                return true;
            }
            catch { }
            return false;
        }
        //timkiem
        public List<NhomHang> KHO_TimNH(string MaNH)
        {
            List<NhomHang> lstnh = new List<NhomHang>();
            NhomHang nhomhang = db.NhomHang.Find(MaNH);
            lstnh.Add(nhomhang);
            return lstnh;
        }
        //-----------------------------------------nhóm hàng end------------------------------------------------//
        
        //-----------------------------------------phieuNhap------------------------------------------------//

        //them 
        public Boolean KHO_LuuPhieuNhap(PhieuNhapHang phieunhap)
        {
            try
            {
                db.PhieuNhapHang.Add(phieunhap);
                db.SaveChanges();
                return true;
            }
            catch { }
            return false;
        }
        //xoa
        //sua

        //-----------------------------------------phieuNhap end------------------------------------------------//
        //-----------------------------------------phieuNhapct------------------------------------------------//

        //them 
        public Boolean KHO_LuuPhieuNhapCT(PhieuNhapHangCT phieunhapct)
        {
            try
            {
                db.PhieuNhapHangCT.Add(phieunhapct);
                db.SaveChanges();
                return true;
            }
            catch { }
            return false;
        }
        //xoa
        //sua

        //-----------------------------------------nha cung cap end------------------------------------------------//
        //-----------------------------------------nha cung cap------------------------------------------------//

        //them 
        //xoa
        //sua

        //-----------------------------------------nha cung cap end------------------------------------------------//
    }
}
