using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class KhachHangCoPhan
{
    public string CoPhanGdId { get; set; } = null!;

    public string KhachHangId { get; set; } = null!;

    public string SoChungTu { get; set; } = null!;

    public DateTime? Ngay { get; set; }

    public DateTime? NgayHuongLai { get; set; }

    public int LoaiGiaoDich { get; set; }

    public int LoaiGopVon { get; set; }

    public double LaiSuat { get; set; }

    public string MaTkNo { get; set; } = null!;

    public string MaTkCo { get; set; } = null!;

    public int TrangThai { get; set; }

    public double SoPhatSinh { get; set; }

    public string GhiChu { get; set; } = null!;

    public bool Active { get; set; }

    public bool Checked { get; set; }

    public bool Locked { get; set; }

    public string UsersNew { get; set; } = null!;

    public DateTime? DateNew { get; set; }

    public string UsersModify { get; set; } = null!;

    public DateTime? DateModify { get; set; }

    public string? CoPhanGdId2 { get; set; }

    public string? ChinhanhId { get; set; }

    public DateTime? NgayDuyet { get; set; }
}
