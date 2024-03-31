using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class DmNgayNghi
{
    public DateTime Ngay { get; set; }

    public string DienGiai { get; set; } = null!;

    public string UsersNew { get; set; } = null!;

    public DateTime? DateNew { get; set; }

    public string UsersModify { get; set; } = null!;

    public DateTime? DateModify { get; set; }
}
