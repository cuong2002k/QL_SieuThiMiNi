using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLSieuThi;
using DTO_QLSieuThi;
namespace BUS_QLSieuThi
{
    public class BUSQLyKho
    {
        DALQLyKho dalqlykho = new DALQLyKho();
        public List<HangHoa> KHO_LayDSHH()
        {
            return dalqlykho.KHO_LayDSHH();
        }
        public List<NhaCungCap> KHO_LayDSNCC()
        {
            return dalqlykho.KHO_LayDSNCC();
        }
        public Boolean KHO_ThemHangHoa(HangHoa hanghoa)
        {
            return dalqlykho.KHO_ThemHangHoa(hanghoa);
        }
        public Boolean KHO_SuaHangHoa(HangHoa hanghoa)
        {
            return dalqlykho.KHO_SuaHangHoa(hanghoa);
        }
        public Boolean KHO_XoaHangHoa(string MaHH)
        {
            return dalqlykho.KHO_XoaHangHoa(MaHH);
        }
        public List<HangHoa> KHO_TimKiemHangHoa(string MaHH)
        {
            return dalqlykho.KHO_TimKiemHangHoa(MaHH);
        }

        //-----------------------------------nhà cung cấp---------
        //them
        public bool Kho_ThemNhaCungCap(NhaCungCap nhacungcap)
        {
            return dalqlykho.Kho_ThemNhaCungCap(nhacungcap);
        }
        //xoa
        public bool Kho_XoaNhaCungCap(string MaNCC)
        {
            return dalqlykho.Kho_XoaNhaCungCap(MaNCC);
        }
        //sua
        public bool Kho_SuaNhaCungCap(NhaCungCap ncc)
        {
            return dalqlykho.Kho_SuaNhaCungCap(ncc);
        }
        //tim kiem
        public List<NhaCungCap> KHO_TimNCC(string mancc)
        {
            return dalqlykho.KHO_TimNCC(mancc);
        }
        //-------------------------------------------------
        //-----------------------------------------nhóm hàng------------------------------------------------//
        //hienthi
        public List<NhomHang> KHO_LayDSNH()
        {
            return dalqlykho.KHO_LayDSNH();
        }
        //them 
        public bool KHO_ThemNH(NhomHang nhomhang)
        {
            return dalqlykho.KHO_ThemNH(nhomhang);
        }
        //xoa
        public bool KHO_XoaNH(string MaNH)
        {
            return dalqlykho.KHO_XoaNH(MaNH);
        }
        //sua
        public bool KHO_SuaNH(NhomHang nhomhang)
        {
            return dalqlykho.KHO_SuaNH(nhomhang);
        }
        //timkiem
        public List<NhomHang> KHO_TimNH(string MaNH)
        {
            return dalqlykho.KHO_TimNH(MaNH);
        }
        //-----------------------------------------nhóm hàng end------------------------------------------------//
        //-----------------------------------------phieuNhap------------------------------------------------//

        //them 
        public Boolean KHO_LuuPhieuNhap(PhieuNhapHang phieunhap)
        {
            return dalqlykho.KHO_LuuPhieuNhap(phieunhap);
        }
        //xoa
        //sua

        //-----------------------------------------phieuNhap end------------------------------------------------//
        //-----------------------------------------phieuNhapct------------------------------------------------//

        //them 
        public Boolean KHO_LuuPhieuNhapCT(PhieuNhapHangCT phieunhapct)
        {
            return dalqlykho.KHO_LuuPhieuNhapCT(phieunhapct);
        }
        //xoa
        //sua

        //-----------------------------------------nha cung cap end------------------------------------------------//
    }
}
