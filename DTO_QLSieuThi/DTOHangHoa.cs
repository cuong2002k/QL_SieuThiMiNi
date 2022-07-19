using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLSieuThi
{
    public class DTOHangHoa
    {
        public DTOHangHoa(string maHH, string tenHang, string maNH, string xuatXu, int? giaNhap, int? giaBan, string donViTinh, string nhaCungCap, string maVach, int? dinhMuc, int? soLuong, bool? trangThaiBan, int? vAT)
        {
            MaHH = maHH;
            TenHang = tenHang;
            MaNH = maNH;
            XuatXu = xuatXu;
            GiaNhap = giaNhap;
            GiaBan = giaBan;
            DonViTinh = donViTinh;
            NhaCungCap = nhaCungCap;
            MaVach = maVach;
            DinhMuc = dinhMuc;
            SoLuong = soLuong;
            TrangThaiBan = trangThaiBan;
            VAT = vAT;
        }

        public string MaHH { get; set; }
        public string TenHang { get; set; }
        public string MaNH { get; set; }
        public string XuatXu { get; set; }
        public Nullable<int> GiaNhap { get; set; }
        public Nullable<int> GiaBan { get; set; }
        public string DonViTinh { get; set; }
        public string NhaCungCap { get; set; }
        public string MaVach { get; set; }
        public Nullable<int> DinhMuc { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public Nullable<bool> TrangThaiBan { get; set; }
        public Nullable<int> VAT { get; set; }
    }
}
