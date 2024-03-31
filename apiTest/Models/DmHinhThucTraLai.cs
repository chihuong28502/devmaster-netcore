using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class DmHinhThucTraLai
{
    public string Ma { get; set; } = null!;

    public string Ten { get; set; } = null!;

    public string GhiChu { get; set; } = null!;

    public string MaLoaiId { get; set; } = null!;

    public bool? Active { get; set; }
}
