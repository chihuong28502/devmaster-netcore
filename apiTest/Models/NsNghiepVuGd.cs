using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class NsNghiepVuGd
{
    public string? Id { get; set; }

    public string? MaTk { get; set; }

    public string? KhachhangId { get; set; }

    public DateTime? NgayGd { get; set; }

    public string? LoaiGiaoDich { get; set; }

    public string? NghiepVuId { get; set; }

    public string? SoChungTu { get; set; }

    public double? SoTien { get; set; }

    public string? DienGiai { get; set; }

    public string? ChinhanhId { get; set; }

    public DateTime? DateNew { get; set; }

    public DateTime? DateModify { get; set; }

    public string? UserNew { get; set; }

    public string? UserModify { get; set; }
}
