using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class CdTaikhoanChitiet
{
    public string MaCtMoi { get; set; } = null!;

    public string? MaThMoi { get; set; }

    public string? ManvMoi { get; set; }

    public string? MaCtCu { get; set; }

    public string? MaThCu { get; set; }
}
