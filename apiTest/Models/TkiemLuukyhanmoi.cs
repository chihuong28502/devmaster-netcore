using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class TkiemLuukyhanmoi
{
    public string GdtkMa { get; set; } = null!;

    public string? SanPhamMa { get; set; }

    public decimal? LaiSuatMoi { get; set; }

    public DateTime? NgayBatDauKyMoi { get; set; }

    public DateTime? NgayBatDauTinhLai { get; set; }

    public virtual TkiemGiaodich GdtkMaNavigation { get; set; } = null!;
}
