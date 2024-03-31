using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class TkiemStkEom
{
    public string? StkMa { get; set; }

    public string? KhMa { get; set; }

    public string? StkTkct { get; set; }

    public decimal? SoDu { get; set; }

    public decimal? TienDuChi { get; set; }

    public string? NgaySoLieu { get; set; }

    public string? ChiNhanhId { get; set; }

    public DateTime? DateNew { get; set; }

    public bool? DaHoanDuChi { get; set; }

    public string? StkSoTietKiem { get; set; }

    public decimal? DuChiCu { get; set; }
}
