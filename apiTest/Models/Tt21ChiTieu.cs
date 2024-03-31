using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class Tt21ChiTieu
{
    public string MaChiTieu { get; set; } = null!;

    public string ChiTieu { get; set; } = null!;

    public bool? IsUsed { get; set; }

    public string MaChiTieuGoc { get; set; } = null!;

    public string MaTieuNhom1 { get; set; } = null!;

    public string MaTieuNhom2 { get; set; } = null!;

    public string MaTieuNhom3 { get; set; } = null!;

    public string MaTieuNhom4 { get; set; } = null!;

    public double? N1 { get; set; }

    public string KyBaoCao { get; set; } = null!;

    public int? InDam { get; set; }
}
