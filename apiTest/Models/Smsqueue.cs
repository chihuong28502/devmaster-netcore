using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class Smsqueue
{
    public int Uid { get; set; }

    public string? SoDienThoai { get; set; }

    public string? Noidung { get; set; }

    public string? ConnectionString { get; set; }

    public string? MsgType { get; set; }

    public string? DiaChi { get; set; }

    public string? MaKh { get; set; }

    public string? TenKh { get; set; }
}
