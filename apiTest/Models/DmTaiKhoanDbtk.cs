using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class DmTaiKhoanDbtk
{
    public string Id { get; set; } = null!;

    public string Ma { get; set; } = null!;

    public string? Ten { get; set; }

    public string? MaCha { get; set; }

    public string? MaKvtc { get; set; }

    public string? MaKvtc0 { get; set; }
}
