using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class TdungGiahanNoDetail
{
    public string? GnId { get; set; }

    public DateTime? NgayGd { get; set; }

    public string? HosotdId { get; set; }

    public DateTime? NgayGiaHan { get; set; }

    public int? LyDo { get; set; }

    public double? SoDu { get; set; }

    public DateTime? DateNew { get; set; }

    public int LoaiGiaHan { get; set; }

    public string? KhtraNoId { get; set; }
}
