using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class NhanSuDmthueTncn
{
    public int Id { get; set; }

    public string? BacThue { get; set; }

    public string? TenBac { get; set; }

    public double? Tien0 { get; set; }

    public double? Tien1 { get; set; }

    public double? ThueSuat { get; set; }

    public string? GhiChu { get; set; }
}
