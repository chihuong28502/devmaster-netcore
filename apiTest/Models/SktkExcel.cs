using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class SktkExcel
{
    public string SoTietKiemId { get; set; } = null!;

    public string? TkTietKiem { get; set; }

    public string? KhachhangId { get; set; }

    public string? HoTen { get; set; }

    public string? Cmnd { get; set; }

    public string? DiaChi { get; set; }

    public string? SoTietKiem { get; set; }

    public string? NgayGui { get; set; }

    public string? NgayDaoHan { get; set; }

    public double? LaiSuat { get; set; }

    public double SoDu { get; set; }
}
