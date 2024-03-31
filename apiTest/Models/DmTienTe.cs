using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class DmTienTe
{
    public string Ma { get; set; } = null!;

    public string? Ten { get; set; }

    public string? TenTat { get; set; }

    public string? GhiChu { get; set; }

    public bool? Active { get; set; }

    public bool? IsSystem { get; set; }
}
