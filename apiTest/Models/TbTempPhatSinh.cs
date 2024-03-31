using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class TbTempPhatSinh
{
    public int? LoaiGiaoDich { get; set; }

    public DateTime? NgayGd { get; set; }

    public string? SoChungTu { get; set; }

    public double? SoTienVay { get; set; }

    public string? DienGiai { get; set; }

    public double? SoTien { get; set; }

    public string? GiaiNganId { get; set; }

    public string? GiaoDichId { get; set; }

    public double? SoDu { get; set; }

    public DateTime? NgayTinh { get; set; }

    public string? Gdv { get; set; }
}
