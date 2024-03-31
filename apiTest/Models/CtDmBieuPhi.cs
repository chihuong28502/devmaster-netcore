using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class CtDmBieuPhi
{
    public int Uid { get; set; }

    public string Ma { get; set; } = null!;

    public string? Ten { get; set; }

    public string? LoaiBieuPhi { get; set; }

    public string? TienTeMa { get; set; }

    public double? ThueVat { get; set; }

    public string? GhiChu { get; set; }

    public string? UserCreate { get; set; }

    public DateTime? DateCreate { get; set; }

    public string? UserModify { get; set; }

    public DateTime? DateModify { get; set; }
}
