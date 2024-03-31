using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class TkeCtgoc
{
    public string CtgocMa { get; set; } = null!;

    public string CtgocTen { get; set; } = null!;

    public string CtgocDinhky { get; set; } = null!;

    public string? CtgocMathongke { get; set; }

    public string? CtgocMota { get; set; }

    public string? NhomctMa { get; set; }
}
