using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class TguiLaisuatstg
{
    public int LsMa { get; set; }

    public string StkMa { get; set; } = null!;

    public DateTime LsTuNgay { get; set; }

    public decimal LsLaiSuat { get; set; }

    public string? LsGhiChu { get; set; }

    public virtual TguiSotiengui StkMaNavigation { get; set; } = null!;
}
