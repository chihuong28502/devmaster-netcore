using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class Tt21MauExcel
{
    public string Tenbieu { get; set; } = null!;

    public string? DateFormat { get; set; }

    public string? IntFormat { get; set; }

    public string? NumericFormat { get; set; }

    public string? CogianHangCot { get; set; }

    public string? CellBatdau { get; set; }

    public string? TenSheet { get; set; }

    public string? FileMau { get; set; }

    public bool? MoFile { get; set; }

    public bool? LuuFile { get; set; }

    public string? Duongdan { get; set; }

    public bool? DinhdangMacdinh { get; set; }

    public string? CellMaquy { get; set; }

    public string? CellTitle { get; set; }

    public string? Title { get; set; }

    public string? CellSubTitle { get; set; }

    public string? CellDonvitinh { get; set; }

    public string? Donvitinh { get; set; }
}
