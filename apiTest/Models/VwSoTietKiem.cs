using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class VwSoTietKiem
{
    public string StkMa { get; set; } = null!;

    public string? StkTen { get; set; }

    public string? StkSoTietKiem { get; set; }

    public string? StkTkct { get; set; }

    public string? ChiNhanhMa { get; set; }

    public string? KhachHangMa { get; set; }

    public decimal? StkSoDu { get; set; }

    public decimal? StkLaiDaTra { get; set; }

    public string? SanPhamMa { get; set; }

    public string? TienTeMa { get; set; }

    public DateTime? StkNgayBatDau { get; set; }

    public string? HttlMa { get; set; }

    public DateTime? StkNgayBatDauTinhLai { get; set; }

    public DateTime? StkNgayDenHan { get; set; }

    public DateTime? StkDuChiDenNgay { get; set; }

    public decimal? StkDuChi { get; set; }

    public DateTime? StkNgayKyMoi { get; set; }

    public int? StkTrangThai { get; set; }

    public bool? StkCoTheThayDoiLaiSuat { get; set; }

    public string? StkGhiChu { get; set; }

    public bool? StkPhongToa { get; set; }

    public string? LoaiHinhDnMa { get; set; }

    public int SanPhamKyHan { get; set; }

    public string? DvkyHanMa { get; set; }

    public int? StkDaLaiNhapGoc { get; set; }
}
