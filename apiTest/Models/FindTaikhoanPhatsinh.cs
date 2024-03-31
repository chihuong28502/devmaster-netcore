using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class FindTaikhoanPhatsinh
{
    public string? MaTk { get; set; }

    public DateTime? Ngay { get; set; }

    public double? NoDauKy { get; set; }

    public double? CoDauKy { get; set; }

    public double? NoTrongKy { get; set; }

    public double? CoTrongKy { get; set; }

    public double? NoCuoiKy { get; set; }

    public double? CoCuoiKy { get; set; }

    public string? ChinhanhId { get; set; }
}
