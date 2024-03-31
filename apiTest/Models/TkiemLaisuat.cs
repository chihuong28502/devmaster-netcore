using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class TkiemLaisuat
{
    public string LsMa { get; set; } = null!;

    public string SanPhamMa { get; set; } = null!;

    public DateTime? LsTuNgay { get; set; }

    public DateTime? LsDenNgay { get; set; }

    public decimal? LsLaiSuat { get; set; }

    public decimal? LsNam { get; set; }

    public string? LsGhiChu { get; set; }

    public decimal LsNamMax { get; set; }

    public virtual TkiemSanpham SanPhamMaNavigation { get; set; } = null!;
}
