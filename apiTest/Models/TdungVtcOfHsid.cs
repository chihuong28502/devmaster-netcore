using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class TdungVtcOfHsid
{
    public string HosoTdId { get; set; } = null!;

    public DateTime? NgayHd { get; set; }

    public double? VonTuCo { get; set; }

    public double? SoTien1 { get; set; }

    public double? SoTien2 { get; set; }

    public double? SoTien3 { get; set; }
}
