using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class SysSubsystem
{
    public int CodeId { get; set; }

    public string SubsysName { get; set; } = null!;

    public string SubsysId { get; set; } = null!;

    public bool Active { get; set; }
}
