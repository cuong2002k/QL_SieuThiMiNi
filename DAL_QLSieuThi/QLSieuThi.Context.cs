﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL_QLSieuThi
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SieuThiMiniEntities : DbContext
    {
        public SieuThiMiniEntities()
            : base("name=SieuThiMiniEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ChamCong> ChamCong { get; set; }
        public virtual DbSet<DSKhuyenMai> DSKhuyenMai { get; set; }
        public virtual DbSet<GiaoCa> GiaoCa { get; set; }
        public virtual DbSet<HangHoa> HangHoa { get; set; }
        public virtual DbSet<HoaDon> HoaDon { get; set; }
        public virtual DbSet<HoaDonCT> HoaDonCT { get; set; }
        public virtual DbSet<KhachHang> KhachHang { get; set; }
        public virtual DbSet<KhuyenMai> KhuyenMai { get; set; }
        public virtual DbSet<MucHangKhachHang> MucHangKhachHang { get; set; }
        public virtual DbSet<NhaCungCap> NhaCungCap { get; set; }
        public virtual DbSet<NhanVien> NhanVien { get; set; }
        public virtual DbSet<NhomHang> NhomHang { get; set; }
        public virtual DbSet<PhanCa> PhanCa { get; set; }
        public virtual DbSet<PhanQuyen> PhanQuyen { get; set; }
        public virtual DbSet<PhieuNhapHang> PhieuNhapHang { get; set; }
        public virtual DbSet<PhieuNhapHangCT> PhieuNhapHangCT { get; set; }
        public virtual DbSet<PhieuTraHang> PhieuTraHang { get; set; }
        public virtual DbSet<PhieuTraHangCT> PhieuTraHangCT { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
