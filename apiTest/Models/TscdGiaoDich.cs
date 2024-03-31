using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class TscdGiaoDich
{
    public string GdtsId { get; set; } = null!;

    public string? TscdMa { get; set; }

    public DateTime? NgayGd { get; set; }

    public string? LoaiGd { get; set; }

    public decimal? SoTien { get; set; }

    public string? DienGiai { get; set; }

    public DateTime? NgayNhap { get; set; }

    public string? NguoiNhap { get; set; }

    public string? ChiNhanhId { get; set; }

    public int? TrangThai { get; set; }

    public string? TaiKhoanNo { get; set; }

    public string? TaiKhoanCo { get; set; }

    public DateTime? NgayKhCu { get; set; }

    public DateTime? NgayKh { get; set; }

    public string? Serial { get; set; }

    public string HinhThucGd { get; set; } = null!;
}
