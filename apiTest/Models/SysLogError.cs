using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class SysLogError
{
    public int CodeId { get; set; }

    public string UsersId { get; set; } = null!;

    public string Menus { get; set; } = null!;

    public DateTime? ErrorDate { get; set; }

    public string ErrorNote { get; set; } = null!;

    public string IpAddr { get; set; } = null!;
}
