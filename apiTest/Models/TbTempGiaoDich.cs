using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class TbTempGiaoDich
{
    public DateTime? NgayGd { get; set; }

    public string? SoChungTu { get; set; }

    public double? SoTienVay { get; set; }

    public string? DienGiai { get; set; }

    public double? Goc { get; set; }

    public double? Lai { get; set; }

    public double? DuNo { get; set; }

    public double? SoTienChuyenNo { get; set; }

    public string? Gdv { get; set; }

    public int? LoaiChungTu { get; set; }
}
