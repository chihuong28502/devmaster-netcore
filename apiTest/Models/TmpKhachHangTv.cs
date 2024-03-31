using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class TmpKhachHangTv
{
    public string KhId { get; set; } = null!;

    public string KhMa { get; set; } = null!;

    public string? TvMa { get; set; }

    public string? TvSocp { get; set; }

    public double Cpxl { get; set; }

    public double Cptx { get; set; }

    public double Cptn { get; set; }

    public double CpSodu { get; set; }

    public int TvIs { get; set; }

    public DateTime? TvNgay { get; set; }

    public string TvTen { get; set; } = null!;

    public string? Cmnd { get; set; }

    public DateTime? CmndNgay { get; set; }

    public string DiaChi { get; set; } = null!;

    public string KvMa { get; set; } = null!;

    public string LoaihinhId { get; set; } = null!;

    public int DiabanIs { get; set; }

    public string ChinhanhId { get; set; } = null!;
}
