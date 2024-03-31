using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class NhansuLuongTt
{
    public int Id { get; set; }

    public DateTime TuNgay { get; set; }

    public double? LuongTt { get; set; }

    public string? GhiChu { get; set; }

    public double? AnCa { get; set; }

    public int? SoNgay { get; set; }

    public double TyleBhxhNv { get; set; }

    public double TyleBhtnNv { get; set; }

    public double TyleBhytNv { get; set; }

    public double TyleKpcdNv { get; set; }

    public double TyleDangPhiNv { get; set; }

    public double TyleDoanPhiNv { get; set; }

    public double TyleBhxhQ { get; set; }

    public double TyleBhtnQ { get; set; }

    public double TyleBhytQ { get; set; }

    public double TyleKpcdQ { get; set; }

    public double TyleDangPhiQ { get; set; }

    public double TyleDoanPhiQ { get; set; }

    public double AnCaQd { get; set; }

    public decimal TyLeTinhLuong { get; set; }
}
