using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class TkeChitieu
{
    public string ChitieuMa { get; set; } = null!;

    public string ChitieuTen { get; set; } = null!;

    public string? ChitieuMota { get; set; }

    public string? CtgocMa { get; set; }

    public string? CtMathongke { get; set; }
}
