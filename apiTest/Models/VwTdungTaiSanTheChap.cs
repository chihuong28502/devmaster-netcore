using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class VwTdungTaiSanTheChap
{
    public string TstcId { get; set; } = null!;

    public string HoSoTdId { get; set; } = null!;

    public string TstcTen { get; set; } = null!;

    public string TstcKyHieu { get; set; } = null!;

    public int TstcSoLuong { get; set; }

    public double TstcThanhTien { get; set; }

    public double TstcTyLeDp { get; set; }

    public string TstcTaiKhoan { get; set; } = null!;

    public string? TstcNgayDuyet { get; set; }

    public int TstcTrangThai { get; set; }

    public string? TstcNgayXuat { get; set; }

    public bool Locked { get; set; }

    public bool Active { get; set; }

    public bool Checked { get; set; }

    public string? TkTinDung { get; set; }

    public string? SoHopDong { get; set; }

    public string? NgayHopDong { get; set; }

    public string? TenNguoiVay { get; set; }

    public string? NgayDaoHan { get; set; }

    public string TstcGhiChu { get; set; } = null!;

    public string TstcMaLoai { get; set; } = null!;

    public string TstcMaNhom { get; set; } = null!;

    public string TstcGhiChuXuat { get; set; } = null!;

    public int TstcTrangThaiXuat { get; set; }

    public double? SoDu { get; set; }

    public string? KhuVucMa { get; set; }

    public string? KhuvucTen { get; set; }

    public double? SoTienVay { get; set; }

    public string? SanPhamTdId { get; set; }

    public double? LaiSuat { get; set; }

    public int? LoaiVayId { get; set; }

    public string? DoiTuongId { get; set; }

    public string? PhuongThucVayId { get; set; }

    public string? HinhThucTstcId { get; set; }

    public string? NgayVay { get; set; }

    public string? TstcTenLoai { get; set; }

    public string? TstcHdtc { get; set; }

    public string? ChuTsHoten { get; set; }

    public string? ChuTsSoCmt { get; set; }
}
