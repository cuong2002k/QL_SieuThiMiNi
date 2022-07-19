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
        public List<NhomHang> KHO_LayDSNH()
        {
            return dalqlykho.KHO_LayDSNH();
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
    }
}
