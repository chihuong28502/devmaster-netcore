using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class NhanSuCtthue
{
    public int ThueId { get; set; }

    public string KhachhangId { get; set; } = null!;

    public DateTime? NgayThue { get; set; }

    public DateTime? NgayGd { get; set; }

    public double? TongLuong { get; set; }

    public double? GiamTru { get; set; }

    public double? LuongTinhThue { get; set; }

    public double? ThueTncn { get; set; }

    public string? UsersNew { get; set; }

    public DateTime? DateNew { get; set; }

    public string? UsersModify { get; set; }

    public DateTime? DateModify { get; set; }
}
