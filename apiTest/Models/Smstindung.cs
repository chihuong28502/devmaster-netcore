using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class Smstindung
{
    public string? HosoTdId { get; set; }

    public string? SoHopDong { get; set; }

    public string? MaKhachHang { get; set; }

    public string? MaThanhVien { get; set; }

    public string? TenNguoiVay { get; set; }

    public string? SoDt { get; set; }

    public double? SoDu { get; set; }

    public double? GocPhaiTra { get; set; }

    public DateTime? NgayDenHan { get; set; }
}
