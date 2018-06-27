﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAO
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DB_LOTTECINEMAEntities : DbContext
    {
        public DB_LOTTECINEMAEntities()
            : base("name=DB_LOTTECINEMAEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BANGTHAMSO> BANGTHAMSOes { get; set; }
        public virtual DbSet<DOHOTPHIM> DOHOTPHIMs { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<PHIM> PHIMs { get; set; }
        public virtual DbSet<PHONG> PHONGs { get; set; }
        public virtual DbSet<SUATCHIEU> SUATCHIEUx { get; set; }
        public virtual DbSet<TRANGTHIETBI> TRANGTHIETBIs { get; set; }
        public virtual DbSet<VEXEMPHIM> VEXEMPHIMs { get; set; }
    
        public virtual int CAPNHATGIAVECOBAN(Nullable<int> giaVeMoi)
        {
            var giaVeMoiParameter = giaVeMoi.HasValue ?
                new ObjectParameter("GiaVeMoi", giaVeMoi) :
                new ObjectParameter("GiaVeMoi", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CAPNHATGIAVECOBAN", giaVeMoiParameter);
        }
    
        public virtual int CAPNHATKHACHHANG(string mAKHACHHANG, string hOTEN, Nullable<bool> gIOITINH, Nullable<System.DateTime> nGAYSINH, string cMND, string sODIENTHOAI)
        {
            var mAKHACHHANGParameter = mAKHACHHANG != null ?
                new ObjectParameter("MAKHACHHANG", mAKHACHHANG) :
                new ObjectParameter("MAKHACHHANG", typeof(string));
    
            var hOTENParameter = hOTEN != null ?
                new ObjectParameter("HOTEN", hOTEN) :
                new ObjectParameter("HOTEN", typeof(string));
    
            var gIOITINHParameter = gIOITINH.HasValue ?
                new ObjectParameter("GIOITINH", gIOITINH) :
                new ObjectParameter("GIOITINH", typeof(bool));
    
            var nGAYSINHParameter = nGAYSINH.HasValue ?
                new ObjectParameter("NGAYSINH", nGAYSINH) :
                new ObjectParameter("NGAYSINH", typeof(System.DateTime));
    
            var cMNDParameter = cMND != null ?
                new ObjectParameter("CMND", cMND) :
                new ObjectParameter("CMND", typeof(string));
    
            var sODIENTHOAIParameter = sODIENTHOAI != null ?
                new ObjectParameter("SODIENTHOAI", sODIENTHOAI) :
                new ObjectParameter("SODIENTHOAI", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CAPNHATKHACHHANG", mAKHACHHANGParameter, hOTENParameter, gIOITINHParameter, nGAYSINHParameter, cMNDParameter, sODIENTHOAIParameter);
        }
    
        public virtual int CAPNHATPHIM(string maPhim, string tenPhim, Nullable<int> tinhTrang, Nullable<int> thoiLuong, Nullable<int> maDoHot)
        {
            var maPhimParameter = maPhim != null ?
                new ObjectParameter("MaPhim", maPhim) :
                new ObjectParameter("MaPhim", typeof(string));
    
            var tenPhimParameter = tenPhim != null ?
                new ObjectParameter("TenPhim", tenPhim) :
                new ObjectParameter("TenPhim", typeof(string));
    
            var tinhTrangParameter = tinhTrang.HasValue ?
                new ObjectParameter("TinhTrang", tinhTrang) :
                new ObjectParameter("TinhTrang", typeof(int));
    
            var thoiLuongParameter = thoiLuong.HasValue ?
                new ObjectParameter("ThoiLuong", thoiLuong) :
                new ObjectParameter("ThoiLuong", typeof(int));
    
            var maDoHotParameter = maDoHot.HasValue ?
                new ObjectParameter("MaDoHot", maDoHot) :
                new ObjectParameter("MaDoHot", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CAPNHATPHIM", maPhimParameter, tenPhimParameter, tinhTrangParameter, thoiLuongParameter, maDoHotParameter);
        }
    
        public virtual int CAPNHATPHUTHUCHONGOIDEP(Nullable<int> phuThuMoi)
        {
            var phuThuMoiParameter = phuThuMoi.HasValue ?
                new ObjectParameter("PhuThuMoi", phuThuMoi) :
                new ObjectParameter("PhuThuMoi", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CAPNHATPHUTHUCHONGOIDEP", phuThuMoiParameter);
        }
    
        public virtual int CAPNHATVE(string maVe, Nullable<int> maKhachHang, Nullable<int> tinhTrang, string tenChoNgoi, Nullable<int> maSuatChieu, Nullable<bool> choNgoiDep, string sDTDatVe, string nhanVienBanVe)
        {
            var maVeParameter = maVe != null ?
                new ObjectParameter("MaVe", maVe) :
                new ObjectParameter("MaVe", typeof(string));
    
            var maKhachHangParameter = maKhachHang.HasValue ?
                new ObjectParameter("MaKhachHang", maKhachHang) :
                new ObjectParameter("MaKhachHang", typeof(int));
    
            var tinhTrangParameter = tinhTrang.HasValue ?
                new ObjectParameter("TinhTrang", tinhTrang) :
                new ObjectParameter("TinhTrang", typeof(int));
    
            var tenChoNgoiParameter = tenChoNgoi != null ?
                new ObjectParameter("TenChoNgoi", tenChoNgoi) :
                new ObjectParameter("TenChoNgoi", typeof(string));
    
            var maSuatChieuParameter = maSuatChieu.HasValue ?
                new ObjectParameter("MaSuatChieu", maSuatChieu) :
                new ObjectParameter("MaSuatChieu", typeof(int));
    
            var choNgoiDepParameter = choNgoiDep.HasValue ?
                new ObjectParameter("ChoNgoiDep", choNgoiDep) :
                new ObjectParameter("ChoNgoiDep", typeof(bool));
    
            var sDTDatVeParameter = sDTDatVe != null ?
                new ObjectParameter("SDTDatVe", sDTDatVe) :
                new ObjectParameter("SDTDatVe", typeof(string));
    
            var nhanVienBanVeParameter = nhanVienBanVe != null ?
                new ObjectParameter("NhanVienBanVe", nhanVienBanVe) :
                new ObjectParameter("NhanVienBanVe", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CAPNHATVE", maVeParameter, maKhachHangParameter, tinhTrangParameter, tenChoNgoiParameter, maSuatChieuParameter, choNgoiDepParameter, sDTDatVeParameter, nhanVienBanVeParameter);
        }
    
        public virtual ObjectResult<KHACHHANG> LAYDSKHACHHANG()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<KHACHHANG>("LAYDSKHACHHANG");
        }
    
        public virtual ObjectResult<KHACHHANG> LAYDSKHACHHANG(MergeOption mergeOption)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<KHACHHANG>("LAYDSKHACHHANG", mergeOption);
        }
    
        public virtual ObjectResult<PHIM> LAYDSPHIM()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PHIM>("LAYDSPHIM");
        }
    
        public virtual ObjectResult<PHIM> LAYDSPHIM(MergeOption mergeOption)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PHIM>("LAYDSPHIM", mergeOption);
        }
    
        public virtual ObjectResult<SUATCHIEU> LAYDSSUATCHIEU()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SUATCHIEU>("LAYDSSUATCHIEU");
        }
    
        public virtual ObjectResult<SUATCHIEU> LAYDSSUATCHIEU(MergeOption mergeOption)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SUATCHIEU>("LAYDSSUATCHIEU", mergeOption);
        }
    
        public virtual ObjectResult<NHANVIEN> LAYNHANVIEN(string mANV)
        {
            var mANVParameter = mANV != null ?
                new ObjectParameter("MANV", mANV) :
                new ObjectParameter("MANV", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<NHANVIEN>("LAYNHANVIEN", mANVParameter);
        }
    
        public virtual ObjectResult<NHANVIEN> LAYNHANVIEN(string mANV, MergeOption mergeOption)
        {
            var mANVParameter = mANV != null ?
                new ObjectParameter("MANV", mANV) :
                new ObjectParameter("MANV", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<NHANVIEN>("LAYNHANVIEN", mergeOption, mANVParameter);
        }
    
        public virtual ObjectResult<PHIM> LAYPHIMTHEOMAPHIM(string maPhim)
        {
            var maPhimParameter = maPhim != null ?
                new ObjectParameter("MaPhim", maPhim) :
                new ObjectParameter("MaPhim", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PHIM>("LAYPHIMTHEOMAPHIM", maPhimParameter);
        }
    
        public virtual ObjectResult<PHIM> LAYPHIMTHEOMAPHIM(string maPhim, MergeOption mergeOption)
        {
            var maPhimParameter = maPhim != null ?
                new ObjectParameter("MaPhim", maPhim) :
                new ObjectParameter("MaPhim", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PHIM>("LAYPHIMTHEOMAPHIM", mergeOption, maPhimParameter);
        }
    
        public virtual ObjectResult<SUATCHIEU> LAYSUATCHIEUTHEOMA(string maSuatChieu)
        {
            var maSuatChieuParameter = maSuatChieu != null ?
                new ObjectParameter("MaSuatChieu", maSuatChieu) :
                new ObjectParameter("MaSuatChieu", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SUATCHIEU>("LAYSUATCHIEUTHEOMA", maSuatChieuParameter);
        }
    
        public virtual ObjectResult<SUATCHIEU> LAYSUATCHIEUTHEOMA(string maSuatChieu, MergeOption mergeOption)
        {
            var maSuatChieuParameter = maSuatChieu != null ?
                new ObjectParameter("MaSuatChieu", maSuatChieu) :
                new ObjectParameter("MaSuatChieu", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SUATCHIEU>("LAYSUATCHIEUTHEOMA", mergeOption, maSuatChieuParameter);
        }
    
        public virtual ObjectResult<VEXEMPHIM> LAYVETHEOMAVE(string mave)
        {
            var maveParameter = mave != null ?
                new ObjectParameter("Mave", mave) :
                new ObjectParameter("Mave", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<VEXEMPHIM>("LAYVETHEOMAVE", maveParameter);
        }
    
        public virtual ObjectResult<VEXEMPHIM> LAYVETHEOMAVE(string mave, MergeOption mergeOption)
        {
            var maveParameter = mave != null ?
                new ObjectParameter("Mave", mave) :
                new ObjectParameter("Mave", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<VEXEMPHIM>("LAYVETHEOMAVE", mergeOption, maveParameter);
        }
    
        public virtual ObjectResult<LAYVETHEOSDTDATVE_Result> LAYVETHEOSDTDATVE(string sDTDatVe)
        {
            var sDTDatVeParameter = sDTDatVe != null ?
                new ObjectParameter("SDTDatVe", sDTDatVe) :
                new ObjectParameter("SDTDatVe", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<LAYVETHEOSDTDATVE_Result>("LAYVETHEOSDTDATVE", sDTDatVeParameter);
        }
    
        public virtual int TAOVE(Nullable<int> maKhachHang, Nullable<int> tinhTrang, string tenChoNgoi, Nullable<int> maSuatChieu, Nullable<bool> choNgoiDep, string sDTDatVe, string nhanVienBanVe)
        {
            var maKhachHangParameter = maKhachHang.HasValue ?
                new ObjectParameter("MaKhachHang", maKhachHang) :
                new ObjectParameter("MaKhachHang", typeof(int));
    
            var tinhTrangParameter = tinhTrang.HasValue ?
                new ObjectParameter("TinhTrang", tinhTrang) :
                new ObjectParameter("TinhTrang", typeof(int));
    
            var tenChoNgoiParameter = tenChoNgoi != null ?
                new ObjectParameter("TenChoNgoi", tenChoNgoi) :
                new ObjectParameter("TenChoNgoi", typeof(string));
    
            var maSuatChieuParameter = maSuatChieu.HasValue ?
                new ObjectParameter("MaSuatChieu", maSuatChieu) :
                new ObjectParameter("MaSuatChieu", typeof(int));
    
            var choNgoiDepParameter = choNgoiDep.HasValue ?
                new ObjectParameter("ChoNgoiDep", choNgoiDep) :
                new ObjectParameter("ChoNgoiDep", typeof(bool));
    
            var sDTDatVeParameter = sDTDatVe != null ?
                new ObjectParameter("SDTDatVe", sDTDatVe) :
                new ObjectParameter("SDTDatVe", typeof(string));
    
            var nhanVienBanVeParameter = nhanVienBanVe != null ?
                new ObjectParameter("NhanVienBanVe", nhanVienBanVe) :
                new ObjectParameter("NhanVienBanVe", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("TAOVE", maKhachHangParameter, tinhTrangParameter, tenChoNgoiParameter, maSuatChieuParameter, choNgoiDepParameter, sDTDatVeParameter, nhanVienBanVeParameter);
        }
    
        public virtual int THEMKHACHHANG(string hOTEN, Nullable<bool> gIOITINH, Nullable<System.DateTime> nGAYSINH, string cMND, string sODIENTHOAI)
        {
            var hOTENParameter = hOTEN != null ?
                new ObjectParameter("HOTEN", hOTEN) :
                new ObjectParameter("HOTEN", typeof(string));
    
            var gIOITINHParameter = gIOITINH.HasValue ?
                new ObjectParameter("GIOITINH", gIOITINH) :
                new ObjectParameter("GIOITINH", typeof(bool));
    
            var nGAYSINHParameter = nGAYSINH.HasValue ?
                new ObjectParameter("NGAYSINH", nGAYSINH) :
                new ObjectParameter("NGAYSINH", typeof(System.DateTime));
    
            var cMNDParameter = cMND != null ?
                new ObjectParameter("CMND", cMND) :
                new ObjectParameter("CMND", typeof(string));
    
            var sODIENTHOAIParameter = sODIENTHOAI != null ?
                new ObjectParameter("SODIENTHOAI", sODIENTHOAI) :
                new ObjectParameter("SODIENTHOAI", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("THEMKHACHHANG", hOTENParameter, gIOITINHParameter, nGAYSINHParameter, cMNDParameter, sODIENTHOAIParameter);
        }
    
        public virtual ObjectResult<THONGKE_VEBANRATHEOPHIM_Result> THONGKE_VEBANRATHEOPHIM(Nullable<System.DateTime> ngayBatDau, Nullable<System.DateTime> ngayKetThuc)
        {
            var ngayBatDauParameter = ngayBatDau.HasValue ?
                new ObjectParameter("NgayBatDau", ngayBatDau) :
                new ObjectParameter("NgayBatDau", typeof(System.DateTime));
    
            var ngayKetThucParameter = ngayKetThuc.HasValue ?
                new ObjectParameter("NgayKetThuc", ngayKetThuc) :
                new ObjectParameter("NgayKetThuc", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<THONGKE_VEBANRATHEOPHIM_Result>("THONGKE_VEBANRATHEOPHIM", ngayBatDauParameter, ngayKetThucParameter);
        }
    
        public virtual ObjectResult<THONGKE_VEHUYTHEOPHIM_Result> THONGKE_VEHUYTHEOPHIM(Nullable<System.DateTime> ngayBatDau, Nullable<System.DateTime> ngayKetThuc)
        {
            var ngayBatDauParameter = ngayBatDau.HasValue ?
                new ObjectParameter("NgayBatDau", ngayBatDau) :
                new ObjectParameter("NgayBatDau", typeof(System.DateTime));
    
            var ngayKetThucParameter = ngayKetThuc.HasValue ?
                new ObjectParameter("NgayKetThuc", ngayKetThuc) :
                new ObjectParameter("NgayKetThuc", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<THONGKE_VEHUYTHEOPHIM_Result>("THONGKE_VEHUYTHEOPHIM", ngayBatDauParameter, ngayKetThucParameter);
        }
    
        public virtual ObjectResult<SUATCHIEU> TRACUUSUATCHIEU(Nullable<System.DateTime> ngayBatDau, Nullable<System.DateTime> ngayKetThuc, Nullable<System.TimeSpan> thoiGianBatDau, Nullable<System.TimeSpan> thoiGianKetThuc, Nullable<int> maPhim, Nullable<int> maPhong)
        {
            var ngayBatDauParameter = ngayBatDau.HasValue ?
                new ObjectParameter("NgayBatDau", ngayBatDau) :
                new ObjectParameter("NgayBatDau", typeof(System.DateTime));
    
            var ngayKetThucParameter = ngayKetThuc.HasValue ?
                new ObjectParameter("NgayKetThuc", ngayKetThuc) :
                new ObjectParameter("NgayKetThuc", typeof(System.DateTime));
    
            var thoiGianBatDauParameter = thoiGianBatDau.HasValue ?
                new ObjectParameter("ThoiGianBatDau", thoiGianBatDau) :
                new ObjectParameter("ThoiGianBatDau", typeof(System.TimeSpan));
    
            var thoiGianKetThucParameter = thoiGianKetThuc.HasValue ?
                new ObjectParameter("ThoiGianKetThuc", thoiGianKetThuc) :
                new ObjectParameter("ThoiGianKetThuc", typeof(System.TimeSpan));
    
            var maPhimParameter = maPhim.HasValue ?
                new ObjectParameter("MaPhim", maPhim) :
                new ObjectParameter("MaPhim", typeof(int));
    
            var maPhongParameter = maPhong.HasValue ?
                new ObjectParameter("MaPhong", maPhong) :
                new ObjectParameter("MaPhong", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SUATCHIEU>("TRACUUSUATCHIEU", ngayBatDauParameter, ngayKetThucParameter, thoiGianBatDauParameter, thoiGianKetThucParameter, maPhimParameter, maPhongParameter);
        }
    
        public virtual ObjectResult<SUATCHIEU> TRACUUSUATCHIEU(Nullable<System.DateTime> ngayBatDau, Nullable<System.DateTime> ngayKetThuc, Nullable<System.TimeSpan> thoiGianBatDau, Nullable<System.TimeSpan> thoiGianKetThuc, Nullable<int> maPhim, Nullable<int> maPhong, MergeOption mergeOption)
        {
            var ngayBatDauParameter = ngayBatDau.HasValue ?
                new ObjectParameter("NgayBatDau", ngayBatDau) :
                new ObjectParameter("NgayBatDau", typeof(System.DateTime));
    
            var ngayKetThucParameter = ngayKetThuc.HasValue ?
                new ObjectParameter("NgayKetThuc", ngayKetThuc) :
                new ObjectParameter("NgayKetThuc", typeof(System.DateTime));
    
            var thoiGianBatDauParameter = thoiGianBatDau.HasValue ?
                new ObjectParameter("ThoiGianBatDau", thoiGianBatDau) :
                new ObjectParameter("ThoiGianBatDau", typeof(System.TimeSpan));
    
            var thoiGianKetThucParameter = thoiGianKetThuc.HasValue ?
                new ObjectParameter("ThoiGianKetThuc", thoiGianKetThuc) :
                new ObjectParameter("ThoiGianKetThuc", typeof(System.TimeSpan));
    
            var maPhimParameter = maPhim.HasValue ?
                new ObjectParameter("MaPhim", maPhim) :
                new ObjectParameter("MaPhim", typeof(int));
    
            var maPhongParameter = maPhong.HasValue ?
                new ObjectParameter("MaPhong", maPhong) :
                new ObjectParameter("MaPhong", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SUATCHIEU>("TRACUUSUATCHIEU", mergeOption, ngayBatDauParameter, ngayKetThucParameter, thoiGianBatDauParameter, thoiGianKetThucParameter, maPhimParameter, maPhongParameter);
        }
    
        public virtual ObjectResult<KHACHHANG> LAYKHACHHANGTHEOMAKH(string maKhachHang)
        {
            var maKhachHangParameter = maKhachHang != null ?
                new ObjectParameter("MaKhachHang", maKhachHang) :
                new ObjectParameter("MaKhachHang", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<KHACHHANG>("LAYKHACHHANGTHEOMAKH", maKhachHangParameter);
        }
    
        public virtual ObjectResult<KHACHHANG> LAYKHACHHANGTHEOMAKH(string maKhachHang, MergeOption mergeOption)
        {
            var maKhachHangParameter = maKhachHang != null ?
                new ObjectParameter("MaKhachHang", maKhachHang) :
                new ObjectParameter("MaKhachHang", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<KHACHHANG>("LAYKHACHHANGTHEOMAKH", mergeOption, maKhachHangParameter);
        }
    
        public virtual int CAPNHATDOHOTPHIM(string maDoHot, string tenDoHot, Nullable<int> tienPhuThem)
        {
            var maDoHotParameter = maDoHot != null ?
                new ObjectParameter("MaDoHot", maDoHot) :
                new ObjectParameter("MaDoHot", typeof(string));
    
            var tenDoHotParameter = tenDoHot != null ?
                new ObjectParameter("TenDoHot", tenDoHot) :
                new ObjectParameter("TenDoHot", typeof(string));
    
            var tienPhuThemParameter = tienPhuThem.HasValue ?
                new ObjectParameter("TienPhuThem", tienPhuThem) :
                new ObjectParameter("TienPhuThem", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CAPNHATDOHOTPHIM", maDoHotParameter, tenDoHotParameter, tienPhuThemParameter);
        }
    
        public virtual ObjectResult<DOHOTPHIM> LAYDOHOTPHIMTHEOMA(string maDoHot)
        {
            var maDoHotParameter = maDoHot != null ?
                new ObjectParameter("MaDoHot", maDoHot) :
                new ObjectParameter("MaDoHot", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DOHOTPHIM>("LAYDOHOTPHIMTHEOMA", maDoHotParameter);
        }
    
        public virtual ObjectResult<DOHOTPHIM> LAYDOHOTPHIMTHEOMA(string maDoHot, MergeOption mergeOption)
        {
            var maDoHotParameter = maDoHot != null ?
                new ObjectParameter("MaDoHot", maDoHot) :
                new ObjectParameter("MaDoHot", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DOHOTPHIM>("LAYDOHOTPHIMTHEOMA", mergeOption, maDoHotParameter);
        }
    
        public virtual ObjectResult<DOHOTPHIM> LAYDSDOHOTPHIM()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DOHOTPHIM>("LAYDSDOHOTPHIM");
        }
    
        public virtual ObjectResult<DOHOTPHIM> LAYDSDOHOTPHIM(MergeOption mergeOption)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DOHOTPHIM>("LAYDSDOHOTPHIM", mergeOption);
        }
    
        public virtual int TAODOHOTPHIM(string tenDoHot, Nullable<int> tienPhuThem)
        {
            var tenDoHotParameter = tenDoHot != null ?
                new ObjectParameter("TenDoHot", tenDoHot) :
                new ObjectParameter("TenDoHot", typeof(string));
    
            var tienPhuThemParameter = tienPhuThem.HasValue ?
                new ObjectParameter("TienPhuThem", tienPhuThem) :
                new ObjectParameter("TienPhuThem", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("TAODOHOTPHIM", tenDoHotParameter, tienPhuThemParameter);
        }
    
        public virtual int TAOPHIM(string tenPhim, Nullable<int> tinhTrang, Nullable<int> thoiLuong, Nullable<int> maDoHot)
        {
            var tenPhimParameter = tenPhim != null ?
                new ObjectParameter("TenPhim", tenPhim) :
                new ObjectParameter("TenPhim", typeof(string));
    
            var tinhTrangParameter = tinhTrang.HasValue ?
                new ObjectParameter("TinhTrang", tinhTrang) :
                new ObjectParameter("TinhTrang", typeof(int));
    
            var thoiLuongParameter = thoiLuong.HasValue ?
                new ObjectParameter("ThoiLuong", thoiLuong) :
                new ObjectParameter("ThoiLuong", typeof(int));
    
            var maDoHotParameter = maDoHot.HasValue ?
                new ObjectParameter("MaDoHot", maDoHot) :
                new ObjectParameter("MaDoHot", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("TAOPHIM", tenPhimParameter, tinhTrangParameter, thoiLuongParameter, maDoHotParameter);
        }
    
        public virtual int CAPNHATTRANGTHIETBI(string maThietBi, string tenThietBi, Nullable<int> tienPhuThem)
        {
            var maThietBiParameter = maThietBi != null ?
                new ObjectParameter("MaThietBi", maThietBi) :
                new ObjectParameter("MaThietBi", typeof(string));
    
            var tenThietBiParameter = tenThietBi != null ?
                new ObjectParameter("TenThietBi", tenThietBi) :
                new ObjectParameter("TenThietBi", typeof(string));
    
            var tienPhuThemParameter = tienPhuThem.HasValue ?
                new ObjectParameter("TienPhuThem", tienPhuThem) :
                new ObjectParameter("TienPhuThem", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CAPNHATTRANGTHIETBI", maThietBiParameter, tenThietBiParameter, tienPhuThemParameter);
        }
    
        public virtual ObjectResult<TRANGTHIETBI> LAYDSTRANGTHIETBI()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TRANGTHIETBI>("LAYDSTRANGTHIETBI");
        }
    
        public virtual ObjectResult<TRANGTHIETBI> LAYDSTRANGTHIETBI(MergeOption mergeOption)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TRANGTHIETBI>("LAYDSTRANGTHIETBI", mergeOption);
        }
    
        public virtual ObjectResult<TRANGTHIETBI> LAYTRANGTHIETBITHEOMA(string maThietBi)
        {
            var maThietBiParameter = maThietBi != null ?
                new ObjectParameter("MaThietBi", maThietBi) :
                new ObjectParameter("MaThietBi", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TRANGTHIETBI>("LAYTRANGTHIETBITHEOMA", maThietBiParameter);
        }
    
        public virtual ObjectResult<TRANGTHIETBI> LAYTRANGTHIETBITHEOMA(string maThietBi, MergeOption mergeOption)
        {
            var maThietBiParameter = maThietBi != null ?
                new ObjectParameter("MaThietBi", maThietBi) :
                new ObjectParameter("MaThietBi", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TRANGTHIETBI>("LAYTRANGTHIETBITHEOMA", mergeOption, maThietBiParameter);
        }
    
        public virtual int TAOTRANGTHIETBI(string tenThietBi, Nullable<int> tienPhuThem)
        {
            var tenThietBiParameter = tenThietBi != null ?
                new ObjectParameter("TenThietBi", tenThietBi) :
                new ObjectParameter("TenThietBi", typeof(string));
    
            var tienPhuThemParameter = tienPhuThem.HasValue ?
                new ObjectParameter("TienPhuThem", tienPhuThem) :
                new ObjectParameter("TienPhuThem", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("TAOTRANGTHIETBI", tenThietBiParameter, tienPhuThemParameter);
        }
    
        public virtual int CAPNHATPHONG(string maPhong, string tenPhong)
        {
            var maPhongParameter = maPhong != null ?
                new ObjectParameter("MaPhong", maPhong) :
                new ObjectParameter("MaPhong", typeof(string));
    
            var tenPhongParameter = tenPhong != null ?
                new ObjectParameter("TenPhong", tenPhong) :
                new ObjectParameter("TenPhong", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CAPNHATPHONG", maPhongParameter, tenPhongParameter);
        }
    
        public virtual ObjectResult<PHONG> LAYDANHSACHPHONG()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PHONG>("LAYDANHSACHPHONG");
        }
    
        public virtual ObjectResult<PHONG> LAYDANHSACHPHONG(MergeOption mergeOption)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PHONG>("LAYDANHSACHPHONG", mergeOption);
        }
    
        public virtual ObjectResult<PHONG> LAYPHONGTHEOMA(string maPhong)
        {
            var maPhongParameter = maPhong != null ?
                new ObjectParameter("MaPhong", maPhong) :
                new ObjectParameter("MaPhong", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PHONG>("LAYPHONGTHEOMA", maPhongParameter);
        }
    
        public virtual ObjectResult<PHONG> LAYPHONGTHEOMA(string maPhong, MergeOption mergeOption)
        {
            var maPhongParameter = maPhong != null ?
                new ObjectParameter("MaPhong", maPhong) :
                new ObjectParameter("MaPhong", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PHONG>("LAYPHONGTHEOMA", mergeOption, maPhongParameter);
        }
    
        public virtual int TAOPHONG(string tenPhong)
        {
            var tenPhongParameter = tenPhong != null ?
                new ObjectParameter("TenPhong", tenPhong) :
                new ObjectParameter("TenPhong", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("TAOPHONG", tenPhongParameter);
        }
    
        public virtual int CAPNHATSUATCHIEU(string maSuatChieu, Nullable<System.DateTime> ngayChieu, Nullable<System.TimeSpan> thoiGianBatDau, Nullable<System.TimeSpan> thoiGianKetThuc, Nullable<int> maPhim, Nullable<int> maPhong)
        {
            var maSuatChieuParameter = maSuatChieu != null ?
                new ObjectParameter("MaSuatChieu", maSuatChieu) :
                new ObjectParameter("MaSuatChieu", typeof(string));
    
            var ngayChieuParameter = ngayChieu.HasValue ?
                new ObjectParameter("NgayChieu", ngayChieu) :
                new ObjectParameter("NgayChieu", typeof(System.DateTime));
    
            var thoiGianBatDauParameter = thoiGianBatDau.HasValue ?
                new ObjectParameter("ThoiGianBatDau", thoiGianBatDau) :
                new ObjectParameter("ThoiGianBatDau", typeof(System.TimeSpan));
    
            var thoiGianKetThucParameter = thoiGianKetThuc.HasValue ?
                new ObjectParameter("ThoiGianKetThuc", thoiGianKetThuc) :
                new ObjectParameter("ThoiGianKetThuc", typeof(System.TimeSpan));
    
            var maPhimParameter = maPhim.HasValue ?
                new ObjectParameter("MaPhim", maPhim) :
                new ObjectParameter("MaPhim", typeof(int));
    
            var maPhongParameter = maPhong.HasValue ?
                new ObjectParameter("MaPhong", maPhong) :
                new ObjectParameter("MaPhong", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CAPNHATSUATCHIEU", maSuatChieuParameter, ngayChieuParameter, thoiGianBatDauParameter, thoiGianKetThucParameter, maPhimParameter, maPhongParameter);
        }
    
        public virtual ObjectResult<VEXEMPHIM> LAYDSVE()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<VEXEMPHIM>("LAYDSVE");
        }
    
        public virtual ObjectResult<VEXEMPHIM> LAYDSVE(MergeOption mergeOption)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<VEXEMPHIM>("LAYDSVE", mergeOption);
        }
    
        public virtual int TAOSUATCHIEU(Nullable<System.DateTime> ngayChieu, Nullable<System.TimeSpan> thoiGianBatDau, Nullable<System.TimeSpan> thoiGianKetThuc, Nullable<int> maPhim, Nullable<int> maPhong)
        {
            var ngayChieuParameter = ngayChieu.HasValue ?
                new ObjectParameter("NgayChieu", ngayChieu) :
                new ObjectParameter("NgayChieu", typeof(System.DateTime));
    
            var thoiGianBatDauParameter = thoiGianBatDau.HasValue ?
                new ObjectParameter("ThoiGianBatDau", thoiGianBatDau) :
                new ObjectParameter("ThoiGianBatDau", typeof(System.TimeSpan));
    
            var thoiGianKetThucParameter = thoiGianKetThuc.HasValue ?
                new ObjectParameter("ThoiGianKetThuc", thoiGianKetThuc) :
                new ObjectParameter("ThoiGianKetThuc", typeof(System.TimeSpan));
    
            var maPhimParameter = maPhim.HasValue ?
                new ObjectParameter("MaPhim", maPhim) :
                new ObjectParameter("MaPhim", typeof(int));
    
            var maPhongParameter = maPhong.HasValue ?
                new ObjectParameter("MaPhong", maPhong) :
                new ObjectParameter("MaPhong", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("TAOSUATCHIEU", ngayChieuParameter, thoiGianBatDauParameter, thoiGianKetThucParameter, maPhimParameter, maPhongParameter);
        }
    
        public virtual ObjectResult<VEXEMPHIM> TRACUUVE(Nullable<int> maKhachHang, string sDTDatVe, string nhanVienBanVe)
        {
            var maKhachHangParameter = maKhachHang.HasValue ?
                new ObjectParameter("MaKhachHang", maKhachHang) :
                new ObjectParameter("MaKhachHang", typeof(int));
    
            var sDTDatVeParameter = sDTDatVe != null ?
                new ObjectParameter("SDTDatVe", sDTDatVe) :
                new ObjectParameter("SDTDatVe", typeof(string));
    
            var nhanVienBanVeParameter = nhanVienBanVe != null ?
                new ObjectParameter("NhanVienBanVe", nhanVienBanVe) :
                new ObjectParameter("NhanVienBanVe", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<VEXEMPHIM>("TRACUUVE", maKhachHangParameter, sDTDatVeParameter, nhanVienBanVeParameter);
        }
    
        public virtual ObjectResult<VEXEMPHIM> TRACUUVE(Nullable<int> maKhachHang, string sDTDatVe, string nhanVienBanVe, MergeOption mergeOption)
        {
            var maKhachHangParameter = maKhachHang.HasValue ?
                new ObjectParameter("MaKhachHang", maKhachHang) :
                new ObjectParameter("MaKhachHang", typeof(int));
    
            var sDTDatVeParameter = sDTDatVe != null ?
                new ObjectParameter("SDTDatVe", sDTDatVe) :
                new ObjectParameter("SDTDatVe", typeof(string));
    
            var nhanVienBanVeParameter = nhanVienBanVe != null ?
                new ObjectParameter("NhanVienBanVe", nhanVienBanVe) :
                new ObjectParameter("NhanVienBanVe", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<VEXEMPHIM>("TRACUUVE", mergeOption, maKhachHangParameter, sDTDatVeParameter, nhanVienBanVeParameter);
        }
    }
}
