using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class ChitieuCb
{
    public int Id { get; set; }

    public string? Chitieu { get; set; }

    public double? Giatri { get; set; }

    public string? Congthuc { get; set; }

    public string? Nhatsolieu { get; set; }

    public string Tenbieu { get; set; } = null!;
}
