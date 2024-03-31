using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class SysUserRight
{
    public int CodeId { get; set; }

    public string UsersId { get; set; } = null!;

    public string NameMenu { get; set; } = null!;

    public bool? IsView { get; set; }

    public bool? IsAdd { get; set; }

    public bool? IsEdit { get; set; }

    public bool? IsDelete { get; set; }
}
