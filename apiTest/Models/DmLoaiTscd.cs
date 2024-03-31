using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class DmLoaiTscd
{
    public int MaLoai { get; set; }

    public string TenLoai { get; set; } = null!;

    public string? GhiChu { get; set; }
}
