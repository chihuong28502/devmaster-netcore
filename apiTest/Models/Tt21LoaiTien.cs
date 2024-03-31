using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class Tt21LoaiTien
{
    public string LoaiTienId { get; set; } = null!;

    public string LoaiTien { get; set; } = null!;

    public bool? Active { get; set; }

    public int Stt { get; set; }

    public int? NumberCrc { get; set; }
}
