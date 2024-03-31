using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class SysReportGroup
{
    public string MaId { get; set; } = null!;

    public string Ma { get; set; } = null!;

    public string Ten { get; set; } = null!;

    public bool? Active { get; set; }

    public string Username { get; set; } = null!;

    public DateTime? EditDate { get; set; }
}
