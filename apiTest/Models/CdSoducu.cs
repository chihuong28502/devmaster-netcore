using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class CdSoducu
{
    public string Matk { get; set; } = null!;

    public double? Sodudau { get; set; }

    public double? Psno { get; set; }

    public double? Psco { get; set; }

    public double? Soducuoi { get; set; }

    public int? Tinhchat { get; set; }
}
