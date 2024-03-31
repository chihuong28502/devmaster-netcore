using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class Tt11DanhSachBaoCao
{
    public string Id { get; set; } = null!;

    public string? Name { get; set; }

    public string? Query { get; set; }

    public string? Query2 { get; set; }

    public string? KyBaocao { get; set; }

    public string? LoaiBaoCao { get; set; }

    public int? Int { get; set; }
}
