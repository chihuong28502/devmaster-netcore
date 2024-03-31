using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class TctdvKeHoachTraNo
{
    public string KhtraNoId { get; set; } = null!;

    public string HoSoTdId { get; set; } = null!;

    public DateTime? NgayTra { get; set; }

    public double SoTienLai { get; set; }

    public double SoTienGoc { get; set; }

    public double ThuGoc { get; set; }

    public double ThuLai { get; set; }

    public int TrangThai { get; set; }

    public string GhiChu { get; set; } = null!;

    public string? UsersNew { get; set; }

    public DateTime? DateNew { get; set; }

    public string? UsersModify { get; set; }

    public DateTime? DateModify { get; set; }
}
