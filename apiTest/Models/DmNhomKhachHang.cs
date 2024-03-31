using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class DmNhomKhachHang
{
    public string Ma { get; set; } = null!;

    public string? Ten { get; set; }

    public string? TenTat { get; set; }

    public string? GhiChu { get; set; }

    public int? PhanLoaiMa { get; set; }

    public bool? Active { get; set; }

    public bool? IsSystem { get; set; }

    public string? UsersNew { get; set; }

    public DateTime? DateNew { get; set; }

    public string? UsersModify { get; set; }

    public DateTime? DateModify { get; set; }
}
