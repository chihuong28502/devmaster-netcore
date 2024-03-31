using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class SysGridConfig
{
    public string CodeId { get; set; } = null!;

    public string NameSource { get; set; } = null!;

    public string ColName { get; set; } = null!;

    public string Title { get; set; } = null!;

    public bool? Enable { get; set; }

    public bool? Visible { get; set; }

    public bool? Readonly { get; set; }

    public int Width { get; set; }

    public string Alignment { get; set; } = null!;

    public string Format { get; set; } = null!;

    public string TypeEditor { get; set; } = null!;

    public string Tooltip { get; set; } = null!;
}
