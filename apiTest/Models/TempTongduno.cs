using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class TempTongduno
{
    public string KhachHangId { get; set; } = null!;

    public string? Ten { get; set; }

    public string? DiaChi { get; set; }

    public string? CmtSerial { get; set; }

    public decimal? TotalDebt { get; set; }
}
