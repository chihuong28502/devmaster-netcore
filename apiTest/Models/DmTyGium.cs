using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class DmTyGium
{
    public string TyGiaId { get; set; } = null!;

    public DateTime Ngay { get; set; }

    public string TienTeId { get; set; } = null!;

    public double TyGia { get; set; }

    public string UsersNew { get; set; } = null!;

    public DateTime? DateNew { get; set; }

    public string UsersModify { get; set; } = null!;

    public DateTime? DateModify { get; set; }
}
