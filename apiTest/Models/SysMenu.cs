using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class SysMenu
{
    public string MenuId { get; set; } = null!;

    public string NameMenu { get; set; } = null!;

    public string Caption { get; set; } = null!;

    public string Description { get; set; } = null!;

    public short LevelMenu { get; set; }

    public string Parents { get; set; } = null!;

    public bool? Enable { get; set; }

    public bool? Visible { get; set; }

    public string IconFile { get; set; } = null!;

    public string ShortCut { get; set; } = null!;

    public string ModuleName { get; set; } = null!;

    public string NotInModule { get; set; } = null!;
}
