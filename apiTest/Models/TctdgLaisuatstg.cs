using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class TctdgLaisuatstg
{
    public string LsMa { get; set; } = null!;

    public string StkMa { get; set; } = null!;

    public DateTime LsTuNgay { get; set; }

    public decimal LsLaiSuat { get; set; }

    public string? LsGhiChu { get; set; }

    public virtual TctdgSotiengui StkMaNavigation { get; set; } = null!;
}
