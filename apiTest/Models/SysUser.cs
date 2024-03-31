using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class SysUser
{
    public string UsersId { get; set; } = null!;

    public string UserName { get; set; } = null!;

    public string Passwords { get; set; } = null!;

    public string FullName { get; set; } = null!;

    public string Groups { get; set; } = null!;

    public bool? IsMon { get; set; }

    public bool? IsTue { get; set; }

    public bool? IsWed { get; set; }

    public bool? IsThu { get; set; }

    public bool? IsFri { get; set; }

    public bool? IsSad { get; set; }

    public bool? IsSun { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string Note { get; set; } = null!;

    public string MaDonVi { get; set; } = null!;

    public string MaNhanVien { get; set; } = null!;

    public string Checksum { get; set; } = null!;
}
