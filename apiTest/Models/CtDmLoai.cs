using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class CtDmLoai
{
    public int Uid { get; set; }

    public string? Loai { get; set; }

    public string? Ma { get; set; }

    public string? Ten { get; set; }

    public string? CtHinhThuc { get; set; }

    public int? SortKey { get; set; }

    public bool? IsActive { get; set; }

    public string? UserCreate { get; set; }

    public DateTime? DateCreate { get; set; }

    public string? UserModify { get; set; }

    public DateTime? DateModify { get; set; }
}
