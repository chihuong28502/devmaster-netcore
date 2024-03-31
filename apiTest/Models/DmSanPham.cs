using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class DmSanPham
{
    public string Ma { get; set; } = null!;

    public string TenTat { get; set; } = null!;

    public string Ten { get; set; } = null!;

    public string TienTeId { get; set; } = null!;

    public int KyHan { get; set; }

    public string DvkyHanId { get; set; } = null!;

    public double LaiSuat { get; set; }

    public string GhiChu { get; set; } = null!;

    public string LoaiSpId { get; set; } = null!;

    public string Tk1 { get; set; } = null!;

    public string Tk2 { get; set; } = null!;

    public string Tk3 { get; set; } = null!;

    public string Tk4 { get; set; } = null!;

    public string Tk5 { get; set; } = null!;

    public string Tk6 { get; set; } = null!;

    public string? UsersNew { get; set; }

    public DateTime? DateNew { get; set; }

    public string? UsersModify { get; set; }

    public DateTime? DateModify { get; set; }
}
