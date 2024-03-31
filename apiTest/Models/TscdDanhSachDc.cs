using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class TscdDanhSachDc
{
    public string MaTscd { get; set; } = null!;

    public DateTime TscdNgay { get; set; }

    public int TscdSoKy { get; set; }

    public decimal TscdKhauHao { get; set; }

    public string? TscdGhiChu { get; set; }

    public string? ChiNhanhId { get; set; }
}
