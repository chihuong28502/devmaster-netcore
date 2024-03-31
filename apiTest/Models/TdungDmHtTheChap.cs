using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class TdungDmHtTheChap
{
    public string Ma { get; set; } = null!;

    public string Ten { get; set; } = null!;

    public bool? Active { get; set; }

    public double? TyleRr { get; set; }

    public string? TaiKhoan { get; set; }

    public string TaikhoanGh { get; set; } = null!;

    public string? TaiKhoanTc { get; set; }
}
