using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class TdungTstcStk
{
    public string TstcId { get; set; } = null!;

    public string HoSoTdId { get; set; } = null!;

    public string? StkSoTietkiem { get; set; }

    public string TstcKyHieu { get; set; } = null!;

    public string TstcDdkyThuat { get; set; } = null!;

    public double TstcThanhTien { get; set; }

    public string TstcGhiChu { get; set; } = null!;

    public DateTime? TstcNgayDuyet { get; set; }

    public string TstcMaNhom { get; set; } = null!;

    public string UsersNew { get; set; } = null!;

    public DateTime? DateNew { get; set; }

    public string UsersModify { get; set; } = null!;

    public DateTime? DateModify { get; set; }

    public string? TstcHdtc { get; set; }

    public string? ChinhanhId { get; set; }
}
