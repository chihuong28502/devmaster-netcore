using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class NqGiaoDichSum
{
    public string KiemKeId { get; set; } = null!;

    public string GiaoDichId { get; set; } = null!;

    public int? PhamViGiaoDich { get; set; }

    public string? UsersNew { get; set; }

    public string? DateNew { get; set; }

    public string? UsersModify { get; set; }

    public DateTime? DateModify { get; set; }
}
