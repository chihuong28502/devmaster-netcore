using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class KeToanTaiKhoanSoDuThang
{
    public string MaTk { get; set; } = null!;

    public double? NoDauKy { get; set; }

    public double? CoDauKy { get; set; }

    public double? NoTrongKy { get; set; }

    public double? CoTrongKy { get; set; }

    public double? NoCuoiKy { get; set; }

    public double? CoCuoiKy { get; set; }

    public string ChinhanhId { get; set; } = null!;

    public DateTime Thangnam { get; set; }
}
