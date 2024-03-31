using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class TdungLaiSuatDetail
{
    public string? TdungLaiSuatId { get; set; }

    public string HosoTdId { get; set; } = null!;

    public DateTime? Ngay { get; set; }

    public int? LoaiDc { get; set; }

    public int? LydoDc { get; set; }

    public double LaiSuat { get; set; }

    public double LaiSuatQuaHan { get; set; }

    public double LaiSuatCu { get; set; }

    public string GhiChu { get; set; } = null!;

    public string? UsersNew { get; set; }

    public DateTime? DateNew { get; set; }

    public string? UsersModify { get; set; }

    public DateTime? DateModify { get; set; }

    public string? ChiNhanhId { get; set; }

    public double? DuNoApDung { get; set; }
}
