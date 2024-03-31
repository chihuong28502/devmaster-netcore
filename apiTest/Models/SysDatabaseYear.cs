using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class SysDatabaseYear
{
    public int Nam { get; set; }

    public bool? Active { get; set; }

    public string GhiChu { get; set; } = null!;

    public string Username { get; set; } = null!;

    public DateTime? EditDate { get; set; }
}
