using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class SysOptionSystem
{
    public string OptionId { get; set; } = null!;

    public string? OptionValue { get; set; }

    public int ValueType { get; set; }

    public bool IsSystem { get; set; }

    public string? Description { get; set; }
}
