using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class TkiemLuukyhanTattoan
{
    public int KyHanTatToanStt { get; set; }

    public string GdtkMa { get; set; } = null!;

    public string? SanPhamMa { get; set; }

    public string? SanPhamThoiGian { get; set; }

    public DateTime? TuNgay { get; set; }

    public DateTime? ToiNgay { get; set; }

    public decimal? SoTienLai { get; set; }

    public string? SanPhamTen { get; set; }

    public string? ChiTietCachTinhLai { get; set; }

    public virtual TkiemGiaodich GdtkMaNavigation { get; set; } = null!;
}
