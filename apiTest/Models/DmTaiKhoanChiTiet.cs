using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class DmTaiKhoanChiTiet
{
    public string Ma { get; set; } = null!;

    public string MaTkTh { get; set; } = null!;

    public string Ten { get; set; } = null!;

    public int? TinhChat { get; set; }

    public string? TienTeMa { get; set; }

    public DateTime? Ngay { get; set; }

    public double? SoDu { get; set; }

    public int? TrangThai { get; set; }

    public string? LoaiTk { get; set; }

    public int? Loai { get; set; }

    public string? UsersNew { get; set; }

    public DateTime? DateNew { get; set; }

    public string? UsersModify { get; set; }

    public DateTime? DateModify { get; set; }

    public string? ChiNhanhId { get; set; }

    public bool? Active { get; set; }

    public bool? IsSystem { get; set; }
}
