using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class CtDmTkHachToan
{
    public int Uid { get; set; }

    public int CtDmBieuPhiUid { get; set; }

    public string? Label { get; set; }

    public string? TaiKhoanMa { get; set; }

    public string? TaiKhoanTenHienThi { get; set; }

    public string? UserCreate { get; set; }

    public DateTime? DateCreate { get; set; }

    public string? UserModify { get; set; }

    public DateTime? DateModify { get; set; }
}
