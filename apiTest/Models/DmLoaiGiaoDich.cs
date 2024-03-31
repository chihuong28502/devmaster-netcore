using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class DmLoaiGiaoDich
{
    public string Ma { get; set; } = null!;

    public string Ten { get; set; } = null!;

    public string TenTat { get; set; } = null!;

    public string GhiChu { get; set; } = null!;

    public string MaNhom { get; set; } = null!;

    public bool? Active { get; set; }

    public bool? IsSystem { get; set; }

    public string LoaiTkNo0 { get; set; } = null!;

    public string MaTkNo0 { get; set; } = null!;

    public string TenTkNo0 { get; set; } = null!;

    public string LoaiTkCo0 { get; set; } = null!;

    public string MaTkCo0 { get; set; } = null!;

    public string TenTkCo0 { get; set; } = null!;

    public string GhiChu0 { get; set; } = null!;

    public string MaTkNo1 { get; set; } = null!;

    public string MaTkCo1 { get; set; } = null!;

    public string GhiChu1 { get; set; } = null!;
}
