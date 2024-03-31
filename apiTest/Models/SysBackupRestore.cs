using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class SysBackupRestore
{
    public int CodeId { get; set; }

    public string FileNames { get; set; } = null!;

    public string UserCreate { get; set; } = null!;

    public DateTime? DateCreate { get; set; }

    public string UserModify { get; set; } = null!;

    public DateTime? DateModify { get; set; }

    public string UserRestore { get; set; } = null!;

    public DateTime? DateRestore { get; set; }
}
