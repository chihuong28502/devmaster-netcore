using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class TctdgGiaodich
{
    public string GdtkMa { get; set; } = null!;

    public string? GdtkSoChungTu { get; set; }

    public string GdtkSoTietKiem { get; set; } = null!;

    public DateTime? GdtkNgayGiaoDich { get; set; }

    public string? GdtkLoaiGiaoDichMa { get; set; }

    public decimal? GdtkSoTien { get; set; }

    public decimal? GdtkSoTienDuChi { get; set; }

    public string? GdtkDienGiai { get; set; }

    public string? TienTeMa { get; set; }

    public decimal? TienTeTyGia { get; set; }

    public int? GdtkTrangThai { get; set; }

    public DateTime? GdtkNgayApDung { get; set; }

    public string? GdtkNguoiNhap { get; set; }

    public DateTime? GdtkNgayNhap { get; set; }

    public string? GdtkNguoiCapNhat { get; set; }

    public DateTime? GdtkNgayCapNhat { get; set; }

    public decimal? DuChiCu { get; set; }

    public DateTime? NgayDuChiCu { get; set; }

    public string? SanPhamMaCu { get; set; }

    public DateTime? NgayKyMoiCu { get; set; }

    public DateTime? NgayBatDauTinhLaiCu { get; set; }

    public DateTime? NgayDenHanCu { get; set; }

    public decimal? LaiSuatCu { get; set; }

    public decimal? SoDuCu { get; set; }

    public decimal? LaiDaTraCu { get; set; }

    public string? GdtkLoaiso { get; set; }

    public string? GdtkMa2 { get; set; }

    public virtual TctdgLuukyhanmoi? TctdgLuukyhanmoi { get; set; }
}
