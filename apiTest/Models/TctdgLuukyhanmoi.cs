using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class TctdgLuukyhanmoi
{
    public string GdtkMa { get; set; } = null!;

    public string? SanPhamMa { get; set; }

    public decimal? LaiSuatMoi { get; set; }

    public DateTime? NgayBatDauKyMoi { get; set; }

    public DateTime? NgayBatDauTinhLai { get; set; }

    public virtual TctdgGiaodich GdtkMaNavigation { get; set; } = null!;
}
