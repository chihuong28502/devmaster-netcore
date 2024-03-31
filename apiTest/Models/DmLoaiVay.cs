using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class DmLoaiVay
{
    public int Ma { get; set; }

    public string? Ten { get; set; }

    public bool? Active { get; set; }

    public bool? IsSystem { get; set; }
}
