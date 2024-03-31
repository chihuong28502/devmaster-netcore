using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class SysLogModifyDatum
{
    public int Stack { get; set; }

    public string? Event { get; set; }

    public string? LoaiData { get; set; }

    public string? ObjectId { get; set; }

    public string? ObjectName { get; set; }

    public DateTime? NgayModify { get; set; }

    public DateTime? NgayNew { get; set; }

    public string? LyDo { get; set; }

    public string? UsersNew { get; set; }

    public string? UsersModify { get; set; }
}
