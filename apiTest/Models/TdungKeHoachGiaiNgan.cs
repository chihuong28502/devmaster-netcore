using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class TdungKeHoachGiaiNgan
{
    public string KhGiaiNganId { get; set; } = null!;

    public string HoSoTdId { get; set; } = null!;

    public DateTime? NgayGn { get; set; }

    public double SoTienGn { get; set; }

    public int TrangThai { get; set; }

    public string GhiChu { get; set; } = null!;

    public string UsersNew { get; set; } = null!;

    public DateTime? DateNew { get; set; }

    public string UsersModify { get; set; } = null!;

    public DateTime? DateModify { get; set; }

    public string? ChinhanhId { get; set; }
}
