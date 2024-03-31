using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class CcNhapXuatDetail
{
    public string NgayBaoCao { get; set; } = null!;

    public string Loai { get; set; } = null!;

    public double? Giatien { get; set; }

    public string? SoluongDau { get; set; }

    public double? SotienDau { get; set; }

    public string? SoluongNhap { get; set; }

    public double? SotienNhap { get; set; }

    public string? SoluongXuat { get; set; }

    public double? SotienXuat { get; set; }

    public string? SoluongPh { get; set; }

    public double? SotienPh { get; set; }

    public string? SoluongCuoi { get; set; }

    public double? SotienCuoi { get; set; }

    public int? Status { get; set; }
}
