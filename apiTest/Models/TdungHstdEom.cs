using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class TdungHstdEom
{
    public string? HoSoTdId { get; set; }

    public string? TkTinDung { get; set; }

    public double? SoDuNo { get; set; }

    public double? TstcTriGia { get; set; }

    public DateTime? NgayThuLai { get; set; }

    public DateTime? NgayDuThu { get; set; }

    public double? TienDuThu { get; set; }

    public string? NgaySoLieu { get; set; }

    public string? ChiNhanhId { get; set; }

    public DateTime? DateNew { get; set; }

    public bool? DaHoanDuThu { get; set; }
}
