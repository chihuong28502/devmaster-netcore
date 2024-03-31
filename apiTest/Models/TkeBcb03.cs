using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class TkeBcb03
{
    public string TenBieu { get; set; } = null!;

    public int Id { get; set; }

    public DateTime Ngay { get; set; }

    public double? NamTruocCuoiQuy { get; set; }

    public double? NamTruocLuyKe { get; set; }

    public string? DaChotSoLieu { get; set; }

    public string? UsersNew { get; set; }

    public DateTime? UsersDate { get; set; }
}
