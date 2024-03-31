using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class TdungGiaiNganNoLaiNb
{
    public string? GiaiNganId { get; set; }

    public string HoSoTdId { get; set; } = null!;

    public string? SoHopDong { get; set; }

    public DateTime? Ngay { get; set; }

    public string? LoaiGiaoDich { get; set; }

    public string? MaTk { get; set; }

    public double? LaiDuThu { get; set; }

    public string? ChinhanhId { get; set; }

    public string? GhiChu { get; set; }

    public string? UsersNew { get; set; }

    public string? UsersModify { get; set; }
}
