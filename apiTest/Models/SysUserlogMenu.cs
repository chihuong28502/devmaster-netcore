using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class SysUserlogMenu
{
    public int CodeId { get; set; }

    public string UserName { get; set; } = null!;

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string Menus { get; set; } = null!;

    public string IpAddr { get; set; } = null!;

    public string HandleForm { get; set; } = null!;
}
