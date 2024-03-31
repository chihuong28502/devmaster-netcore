using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class TkeCtcongthuc
{
    public string CtgocMa { get; set; } = null!;

    public string Congthuc { get; set; } = null!;

    public string Dieukien { get; set; } = null!;

    public int? Loaidl { get; set; }
}
