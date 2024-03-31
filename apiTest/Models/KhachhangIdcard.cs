using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class KhachhangIdcard
{
    public string KhachhangId { get; set; } = null!;

    public string KhachhangIdcard1 { get; set; } = null!;

    public int LoaiThe { get; set; }

    public DateTime NgayCap { get; set; }

    public string GhiChu { get; set; } = null!;

    public string? UsersNew { get; set; }

    public DateTime? DateNew { get; set; }

    public string? UsersModify { get; set; }

    public DateTime? DateModify { get; set; }
}
