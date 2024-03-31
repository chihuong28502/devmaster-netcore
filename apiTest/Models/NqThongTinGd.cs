using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class NqThongTinGd
{
    public string GiaoDichId { get; set; } = null!;

    public string? MaKh { get; set; }

    public string? TenKh { get; set; }

    public string? DiaChi { get; set; }

    public string? DienThoai { get; set; }

    public string? CmtSerial { get; set; }

    public string? CmtNoiCap { get; set; }

    public DateTime? CmtNgayCap { get; set; }

    public string? NoiDung { get; set; }
}
