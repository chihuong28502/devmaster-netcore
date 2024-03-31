using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class SysUserlogApp
{
    public int CodeId { get; set; }

    public string UserName { get; set; } = null!;

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string IpAddr { get; set; } = null!;
}
