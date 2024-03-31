using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class DmLoaisanpham
{
    public string Ma { get; set; } = null!;

    public string Ten { get; set; } = null!;

    public string GhiChu { get; set; } = null!;

    public bool? Active { get; set; }
}
