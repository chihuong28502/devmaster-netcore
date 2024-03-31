using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class CcDanhmuc
{
    public string Ma { get; set; } = null!;

    public string Ten { get; set; } = null!;

    public string? Tentat { get; set; }

    public string? Ghichu { get; set; }

    public string? Tk1 { get; set; }

    public string? Tk2 { get; set; }

    public virtual ICollection<CcNhapXuat> CcNhapXuats { get; set; } = new List<CcNhapXuat>();
}
