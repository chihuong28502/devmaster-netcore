using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class DmKhuvuc
{
    public string Ma { get; set; } = null!;

    public string TenTat { get; set; } = null!;

    public string Ten { get; set; } = null!;

    public string GhiChu { get; set; } = null!;

    public bool? Active { get; set; }

    public bool IsSystem { get; set; }

    public bool DiaBanNongThon { get; set; }
}
