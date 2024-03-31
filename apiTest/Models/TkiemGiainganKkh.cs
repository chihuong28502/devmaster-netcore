using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class TkiemGiainganKkh
{
    public string GnId { get; set; } = null!;

    public string GiaoDichId { get; set; } = null!;

    public string? SoChungTu { get; set; }

    public DateTime? GnNgayGiaiNgan { get; set; }

    public int? HinhThucGnId { get; set; }

    public string? GnTkno { get; set; }

    public string? GnTkco { get; set; }

    public double? GnSoTien { get; set; }

    public string? GnGhiChu { get; set; }

    public string? UsersNew { get; set; }

    public DateTime? DateNew { get; set; }

    public string? UsersModify { get; set; }

    public DateTime? DateModify { get; set; }

    public bool? Active { get; set; }

    public bool? Locked { get; set; }

    public bool? Checked { get; set; }

    public string? GnLoaiChungTu { get; set; }

    public string? GiaoDichId2 { get; set; }

    public string? GnGhiChuDcgr { get; set; }
}
