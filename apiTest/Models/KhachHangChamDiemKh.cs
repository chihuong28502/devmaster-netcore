using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class KhachHangChamDiemKh
{
    public int Id { get; set; }

    public string? KhachHangId { get; set; }

    public string? ChiTieuId { get; set; }

    public string? ChiTieuChiTietId { get; set; }

    public string? GroupBieu { get; set; }

    public string? ChiTieu { get; set; }

    public double? DiemSo { get; set; }

    public double? TrongSo { get; set; }

    public double? DiemDatDuoc { get; set; }

    public string? GhiChu { get; set; }

    public string? UsersNew { get; set; }

    public DateTime? DateNew { get; set; }

    public DateTime? DateModify { get; set; }

    public string? UsersModify { get; set; }
}
