using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class SysExpFilter
{
    public int MaId { get; set; }

    public string NameForm { get; set; } = null!;

    public string Ten { get; set; } = null!;

    public string Filter { get; set; } = null!;

    public bool? Active { get; set; }
}
