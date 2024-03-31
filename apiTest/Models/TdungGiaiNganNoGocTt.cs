using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class TdungGiaiNganNoGocTt
{
    public string GiaiNganId { get; set; } = null!;

    public string HoSoTdId { get; set; } = null!;

    public string? SoHopDong { get; set; }

    public DateTime? Ngay { get; set; }

    public double? SoTienGocTt { get; set; }

    public double? SoTienLaiTt { get; set; }

    public string? GhiChu { get; set; }
}
