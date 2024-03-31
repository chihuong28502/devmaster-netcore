using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class CtKhachHangLog
{
    public string Uid { get; set; } = null!;

    public string? Ten { get; set; }

    public string? CmtSerial { get; set; }

    public DateTime? CmtNgayCap { get; set; }

    public string? CmtNoiCap { get; set; }

    public string? DiaChi { get; set; }

    public string? Sdt { get; set; }

    public string? NganHangMa { get; set; }

    public string? NganHangTk { get; set; }

    public string? KhachHangId { get; set; }

    public string? UserCreate { get; set; }

    public DateTime? DateCreate { get; set; }

    public string? UserModify { get; set; }

    public DateTime? DateModify { get; set; }
}
