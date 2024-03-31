using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class VwHstdUpdateMaThongKe
{
    public string HoSoTdId { get; set; } = null!;

    public string TenNguoiVay { get; set; } = null!;

    public string PhuongThucVayId { get; set; } = null!;

    public string? KhuVucMa { get; set; }

    public string? Ten { get; set; }

    public string? MaThongKe0 { get; set; }

    public string? MaThongKe1 { get; set; }
}
