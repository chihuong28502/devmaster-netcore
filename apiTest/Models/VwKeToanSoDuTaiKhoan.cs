using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class VwKeToanSoDuTaiKhoan
{
    public int MaId { get; set; }

    public string MaTk { get; set; } = null!;

    public string? Ngay { get; set; }

    public double NoDauKy { get; set; }

    public double CoDauKy { get; set; }

    public double NoTrongKy { get; set; }

    public double CoTrongKy { get; set; }

    public double NoCuoiKy { get; set; }

    public double CoCuoiKy { get; set; }

    public double NoDauNam { get; set; }

    public double CoDauNam { get; set; }

    public double NoLuyKe { get; set; }

    public double CoLuyKe { get; set; }

    public string? MaTkTh { get; set; }

    public string? TenTk { get; set; }

    public int? TinhChat { get; set; }

    public string? TienTeMa { get; set; }

    public string? LoaiTk { get; set; }

    public int? Thang { get; set; }

    public int? Nam { get; set; }
}
