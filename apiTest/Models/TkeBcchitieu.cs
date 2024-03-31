using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class TkeBcchitieu
{
    public string Tenbieu { get; set; } = null!;

    public int Id { get; set; }

    public string Machitieu { get; set; } = null!;

    public string? Chitieu { get; set; }

    public int? Cot { get; set; }
}
