using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class InVoiceDangKySeri
{
    public int Id { get; set; }

    public string? MaHd { get; set; }

    public string? MauHd { get; set; }

    public string? KyHieu { get; set; }

    public DateTime? NgayHl { get; set; }

    public decimal? SeriDau { get; set; }

    public decimal? SeriCuoi { get; set; }
}
