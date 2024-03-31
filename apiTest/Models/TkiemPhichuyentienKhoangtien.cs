using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class TkiemPhichuyentienKhoangtien
{
    public int IdKhoangTien { get; set; }

    public int IdPhiChuyenTien { get; set; }

    public decimal? Tu { get; set; }

    public decimal? Toi { get; set; }

    public decimal? PhiChuyen { get; set; }

    public virtual TkiemPhichuyentien IdPhiChuyenTienNavigation { get; set; } = null!;
}
