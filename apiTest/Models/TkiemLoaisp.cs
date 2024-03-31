using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class TkiemLoaisp
{
    public string LoaiSpMa { get; set; } = null!;

    public string? LoaiSpTen { get; set; }

    public string? LoaiSpGhiChu { get; set; }

    public virtual ICollection<TkiemSanpham> TkiemSanphams { get; set; } = new List<TkiemSanpham>();
}
