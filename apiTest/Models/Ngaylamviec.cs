using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class Ngaylamviec
{
    public int NgayLamViecMa { get; set; }

    public DateTime? NgayLamViec1 { get; set; }

    public bool? IsCurrent { get; set; }

    public bool? Locked { get; set; }

    public bool? IsEndOfMonth { get; set; }
}
