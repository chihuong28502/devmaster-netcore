using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class TctdvHopDong
{
    public string HopDongId { get; set; } = null!;

    public string? TctdMa { get; set; }

    public string SoHopDong { get; set; } = null!;

    public string? TkHopDong { get; set; }

    public DateTime? NgayHopDong { get; set; }

    public string? TenTctdVay { get; set; }

    public string? TenNguoiDaiDien { get; set; }

    public string? DiachiNguoiDaiDien { get; set; }

    public string? CmtSerial { get; set; }

    public string? SanPhamVayId { get; set; }

    public DateTime? NgayVay { get; set; }

    public double? SoTien { get; set; }

    public int? KyHan { get; set; }

    public int? DvkyHanId { get; set; }

    public double? LaiSuat { get; set; }

    public string? HinhThucTraLaiId { get; set; }

    public DateTime? NgayDaoHan { get; set; }

    public DateTime? NgayGiaHan { get; set; }

    public DateTime? NgayChuyenQuaHan { get; set; }

    public double? LaiSuatQuaHan { get; set; }

    public int? LoaiVayId { get; set; }

    public string? GhiChu { get; set; }

    public double? SoGiaiNgan { get; set; }

    public double? SoDu { get; set; }

    public double? LaiDaTra { get; set; }

    public DateTime? LaiDenNgay { get; set; }

    public double? GocDaTra { get; set; }

    public DateTime? GocDenNgay { get; set; }

    public double? DuChi { get; set; }

    public DateTime? NgayDuChi { get; set; }

    public int? TrangThai { get; set; }

    public string? UsersNew { get; set; }

    public DateTime? DateNew { get; set; }

    public string? UsersModify { get; set; }

    public DateTime? DateModify { get; set; }

    public string? HinhThucVayId { get; set; }
}
