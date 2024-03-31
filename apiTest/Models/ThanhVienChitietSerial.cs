using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class ThanhVienChitietSerial
{
    public string KhachhangId { get; set; } = null!;

    public string ThanhvienSerial { get; set; } = null!;

    public DateTime Ngay { get; set; }

    public double SoTien { get; set; }

    public string GhiChu { get; set; } = null!;
}
