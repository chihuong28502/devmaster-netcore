using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class SysLastCodeId
{
    public string TableName { get; set; } = null!;

    public int CodeId { get; set; }

    public int CodeSerial { get; set; }

    public int Length { get; set; }

    public string Prefix { get; set; } = null!;

    public string Suffix { get; set; } = null!;

    public string GhiChu { get; set; } = null!;
}
