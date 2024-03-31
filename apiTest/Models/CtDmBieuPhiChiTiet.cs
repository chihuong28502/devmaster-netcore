using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class CtDmBieuPhiChiTiet
{
    public int Uid { get; set; }

    public int CtDmBieuPhiUid { get; set; }

    public DateTime? Ngay { get; set; }

    public double? Tyle { get; set; }

    public double? Min { get; set; }

    public double? Max { get; set; }

    public string? UserCreate { get; set; }

    public DateTime? DateCreate { get; set; }

    public string? UserModify { get; set; }

    public DateTime? DateModify { get; set; }
}
