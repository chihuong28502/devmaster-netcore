using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class Tt21LuyKeThanhVienSl
{
    public string ThoiGian { get; set; } = null!;

    public int? SumMembersIn { get; set; }

    public int? SumMemberOut { get; set; }

    public int? SumMemberGive { get; set; }

    public bool? Lock { get; set; }

    public string? Flag { get; set; }
}
