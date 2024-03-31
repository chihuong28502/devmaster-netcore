using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class CtDmNganHang
{
    public string Ma { get; set; } = null!;

    public string? TenDonVi { get; set; }

    public string? TenGiaoDich { get; set; }

    public string? DiaChi { get; set; }

    public string? Sdt { get; set; }

    public string? CapDonVi { get; set; }

    public string? TkHachToan { get; set; }

    public bool? IsActive { get; set; }

    public string? UserCreate { get; set; }

    public DateTime? DateCreate { get; set; }

    public string? UserModify { get; set; }

    public DateTime? DateModify { get; set; }
}
