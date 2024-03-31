using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class TctdvDmSanPham
{
    public string Ma { get; set; } = null!;

    public string? TenTat { get; set; }

    public string? Ten { get; set; }

    public string? TienTeMa { get; set; }

    public int? KyHan { get; set; }

    public string? DvkyHanId { get; set; }

    public double? LaiSuat { get; set; }

    public string? GhiChu { get; set; }

    public string? LoaiSpId { get; set; }

    public string? Tk1 { get; set; }

    public string? Tk2 { get; set; }

    public string? Tk3 { get; set; }

    public string? Tk4 { get; set; }

    public string? Tk5 { get; set; }

    public string? Tk6 { get; set; }

    public string? Tk7 { get; set; }

    public string? UsersNew { get; set; }

    public DateTime? DateNew { get; set; }

    public string? UsersModify { get; set; }

    public DateTime? DateModify { get; set; }
}
