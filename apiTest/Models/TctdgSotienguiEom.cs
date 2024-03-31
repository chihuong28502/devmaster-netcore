using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class TctdgSotienguiEom
{
    public string StkMa { get; set; } = null!;

    public string? StkSoTietKiem { get; set; }

    public string? StkTkct { get; set; }

    public decimal? StkSoDu { get; set; }

    public DateTime? StkDuthuDenNgay { get; set; }

    public decimal? StkDuthu { get; set; }

    public string? NgaySolieu { get; set; }

    public int? DaHoanDuThu { get; set; }
}
