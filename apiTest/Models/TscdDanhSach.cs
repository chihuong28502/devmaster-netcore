using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class TscdDanhSach
{
    public string MaTscd { get; set; } = null!;

    public string TenTscd { get; set; } = null!;

    public int LoaiTscd { get; set; }

    public int TscdHinhThuc { get; set; }

    public string? ChiNhanhId { get; set; }

    public string TaiKhoanTscd { get; set; } = null!;

    public decimal TscdNguyenGia { get; set; }

    public DateTime TscdNgayNhap { get; set; }

    public int TscdThoiGianSd { get; set; }

    public int? TscdSoKy { get; set; }

    public decimal TscdKhauHao { get; set; }

    public decimal? TscdSoTienKhauHao { get; set; }

    public decimal TscdGiaTriConLai { get; set; }

    public DateTime? TscdNgayKhauHao { get; set; }

    public DateTime? TscdNgayXuat { get; set; }

    public bool TscdTrangThai { get; set; }

    public string? TscdGhiChu { get; set; }

    public DateTime? NgayCapNhat { get; set; }

    public DateTime? TscdNgayKhauHao0 { get; set; }

    public decimal? TscdSoTienKhauHao0 { get; set; }

    public decimal? TscdGiatriConLai0 { get; set; }

    public string? TaiKhoanCp { get; set; }

    public int? TscdSoLuong { get; set; }

    public string? TscdDvt { get; set; }

    public string? TaiKhoanKh { get; set; }

    public int? IsLocked { get; set; }

    public string? TscdNhom { get; set; }

    public string? TscdNguoiQly { get; set; }

    public string? TscdNguoiSd { get; set; }

    public int? TstcDonViTgsd { get; set; }
}
