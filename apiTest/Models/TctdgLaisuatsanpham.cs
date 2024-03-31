using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class TctdgLaisuatsanpham
{
    public string LsMa { get; set; } = null!;

    public string SanPhamMa { get; set; } = null!;

    public DateTime? LsTuNgay { get; set; }

    public DateTime? LsDenNgay { get; set; }

    public decimal? LsLaiSuat { get; set; }

    public decimal? LsNam { get; set; }

    public string? LsGhiChu { get; set; }
}
