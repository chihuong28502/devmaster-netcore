using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class KehoachThuchien
{
    public string Nam { get; set; } = null!;

    public int Id { get; set; }

    public string? Stt { get; set; }

    public string? Chitieu { get; set; }

    public double? GiatriKehoach { get; set; }

    public string? Chenhlech { get; set; }

    public string? Congtru { get; set; }

    public string? Nhatsolieu { get; set; }

    public bool? Indam { get; set; }
}
