using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class InvoiceDmThueSuat
{
    public string? Ma { get; set; }

    public string? Ten { get; set; }

    public double? ThueSuat { get; set; }

    public bool Active { get; set; }
}
