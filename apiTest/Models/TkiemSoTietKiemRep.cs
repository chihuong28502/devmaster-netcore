using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class TkiemSoTietKiemRep
{
    public int Stack { get; set; }

    public string? Event { get; set; }

    public string? SoTkOld { get; set; }

    public string? SoTkNew { get; set; }

    public DateTime? NgayRep { get; set; }

    public string? LyDo { get; set; }

    public string? UserRep { get; set; }

    public string? ClientRep { get; set; }
}
