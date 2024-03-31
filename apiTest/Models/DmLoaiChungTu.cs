using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class DmLoaiChungTu
{
    public string Ma { get; set; } = null!;

    public string Ten { get; set; } = null!;

    public string TenTat { get; set; } = null!;

    public string GhiChu { get; set; } = null!;

    public bool? Active { get; set; }

    public bool? IsSystem { get; set; }

    public string MaTkNo { get; set; } = null!;

    public string MaTkCo { get; set; } = null!;

    public string NotMaTkNo { get; set; } = null!;

    public string NotMaTkCo { get; set; } = null!;
}
