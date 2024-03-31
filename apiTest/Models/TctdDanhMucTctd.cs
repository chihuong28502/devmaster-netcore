using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class TctdDanhMucTctd
{
    public string MaTctd { get; set; } = null!;

    public string? TenTctd { get; set; }

    public string? Diachi { get; set; }

    public string? Sdt { get; set; }

    public string? Masothue { get; set; }

    public string? ChiNhanh { get; set; }
}
