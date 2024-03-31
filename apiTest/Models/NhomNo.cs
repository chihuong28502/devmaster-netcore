using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class NhomNo
{
    public int Id { get; set; }

    public int? NhomNo1 { get; set; }

    public double? DpCuThe { get; set; }

    public double? DpChung { get; set; }

    public double? GiaTriQuyDoi { get; set; }

    public string? UsersNew { get; set; }

    public DateTime? DateNew { get; set; }

    public string? UserModify { get; set; }

    public DateTime? DateModify { get; set; }

    public int? Startindex { get; set; }

    public int? Len { get; set; }
}
