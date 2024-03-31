using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class TdungLaiSuatSanPham
{
    public string? LsMa { get; set; }

    public string? SanPhamMa { get; set; }

    public DateTime? LsTuNgay { get; set; }

    public DateTime? LsDenNgay { get; set; }

    public double? LsLaiSuat { get; set; }

    public double? LsNam { get; set; }

    public string? LsGhiChu { get; set; }

    public double? LsQuaHan { get; set; }
}
