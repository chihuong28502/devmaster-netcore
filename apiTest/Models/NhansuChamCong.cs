using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class NhansuChamCong
{
    public string KhachhangId { get; set; } = null!;

    public DateTime Ngay { get; set; }

    public decimal? LuongTinhtoan { get; set; }

    public int? NgayCong { get; set; }

    public decimal? T7Cn { get; set; }

    public decimal? NgayLe { get; set; }

    public decimal? ThemGio { get; set; }

    public decimal? LuongT7cn { get; set; }

    public decimal? LuongNgayLe { get; set; }

    public decimal? LuongThemgio { get; set; }

    public decimal? ClAnca { get; set; }

    public string? UsersNew { get; set; }

    public DateTime? DateNew { get; set; }

    public string? UsersModify { get; set; }

    public DateTime? DateModify { get; set; }

    public decimal? Songaylamviec { get; set; }

    public decimal? DongiaCong { get; set; }

    public decimal? TongLamthem { get; set; }

    public double AnCa { get; set; }

    public string? CongId { get; set; }
}
