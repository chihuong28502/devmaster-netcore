using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class NgoaiteGiaodich
{
    public string GiaodichId { get; set; } = null!;

    public string NgoaiteId { get; set; } = null!;

    public DateTime? Ngay { get; set; }

    public string? SoChungTu { get; set; }

    public string? LoaiGiaoDichId { get; set; }

    public string? MaTkNo { get; set; }

    public string? MaTkCo { get; set; }

    public double? NgoaiteSoTien { get; set; }

    public decimal? Tygia { get; set; }

    public string? GhiChu { get; set; }

    public int? TrangThai { get; set; }

    public string? UsersNew { get; set; }

    public DateTime? DateNew { get; set; }

    public string? UsersModify { get; set; }

    public DateTime? DateModify { get; set; }

    public bool Active { get; set; }

    public bool Locked { get; set; }

    public bool Checked { get; set; }

    public string? ChinhanhId { get; set; }
}
