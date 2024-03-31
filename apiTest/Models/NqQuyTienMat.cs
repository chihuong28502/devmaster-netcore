using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class NqQuyTienMat
{
    public string LoaiTienId { get; set; } = null!;

    public DateTime Ngay { get; set; }

    public int? TonDauKy { get; set; }

    public int? Thu { get; set; }

    public int? Chi { get; set; }

    public int? TonCuoiKy { get; set; }

    public string? ChinhanhId { get; set; }

    public string? UserNew { get; set; }

    public DateTime? DateNew { get; set; }
}
