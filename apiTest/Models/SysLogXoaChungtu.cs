using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class SysLogXoaChungtu
{
    public int Stack { get; set; }

    public string? Event { get; set; }

    public string? LoaiCt { get; set; }

    public string? GiaodichId { get; set; }

    public DateTime? NgayCt { get; set; }

    public string? SoChungTu { get; set; }

    public string? NoiDung { get; set; }

    public int? TrangThai { get; set; }

    public double? SoPhatSinh { get; set; }

    public DateTime? NgayXoa { get; set; }

    public string? LyDo { get; set; }

    public string? UsersNew { get; set; }

    public string? UsersDelete { get; set; }

    public DateTime? DateModify { get; set; }
}
