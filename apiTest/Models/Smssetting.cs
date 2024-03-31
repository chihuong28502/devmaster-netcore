using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class Smssetting
{
    public string? Loai { get; set; }

    public int? SoNgay { get; set; }

    public bool? KichHoat { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? UpdateDate { get; set; }
}
