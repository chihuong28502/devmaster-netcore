using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class DmDvKyHan
{
    public string Ma { get; set; } = null!;

    public string Ten { get; set; } = null!;

    public bool? Active { get; set; }

    public virtual ICollection<TctdgSanpham> TctdgSanphams { get; set; } = new List<TctdgSanpham>();

    public virtual ICollection<TguiSanpham> TguiSanphams { get; set; } = new List<TguiSanpham>();

    public virtual ICollection<TkiemSanpham> TkiemSanphams { get; set; } = new List<TkiemSanpham>();
}
