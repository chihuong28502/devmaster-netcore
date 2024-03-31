using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class Tt35CanDoiTkChiTieu
{
    public string? Id { get; set; }

    public string? MaTk { get; set; }

    public string TenTaiKhoan { get; set; } = null!;

    public double NoDauKy { get; set; }

    public double CoDauKy { get; set; }

    public double NoTrongKy { get; set; }

    public double CoTrongKy { get; set; }

    public double NoCuoiKy { get; set; }

    public double CoCuoiKy { get; set; }

    public string? CanDoiLoai { get; set; }
}
