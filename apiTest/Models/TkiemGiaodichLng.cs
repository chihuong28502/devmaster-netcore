using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class TkiemGiaodichLng
{
    public string StkMa { get; set; } = null!;

    public string Sotietkiem { get; set; } = null!;

    public double? TienLng { get; set; }

    public double? TienDuchi { get; set; }

    public DateTime? NgayLng { get; set; }

    public string? ChinhanhId { get; set; }

    public string? GdtkMa2 { get; set; }

    public DateTime? GdtkNgayApDung { get; set; }

    public double? SoduKymoi { get; set; }

    public double? SoduCu { get; set; }

    public decimal? LsKymoi { get; set; }

    public DateTime? NgaydenhanNew { get; set; }
}
