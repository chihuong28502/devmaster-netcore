using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class SmstietKiem
{
    public string StkSoTietKiem { get; set; } = null!;

    public string? MaKhachHang { get; set; }

    public string? MaThanhVien { get; set; }

    public string? TenKhachHang { get; set; }

    public string? SoDt { get; set; }

    public double? SoDu { get; set; }

    public double? LaiSuat { get; set; }

    public DateTime? NgayDenHan { get; set; }
}
