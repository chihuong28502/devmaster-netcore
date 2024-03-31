using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class TempTotalDebt
{
    public string KhachHangId { get; set; } = null!;

    public decimal? TotalDebt { get; set; }

    public string? Ten { get; set; }

    public string? DiaChi { get; set; }

    public string? CmtSerial { get; set; }
}
