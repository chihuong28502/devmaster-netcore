using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class SysVariable
{
    public string RecordId { get; set; } = null!;

    public string Variable { get; set; } = null!;

    public string Comments { get; set; } = null!;

    public string Types { get; set; } = null!;

    public string Defaulvalue { get; set; } = null!;

    public string Realvalue { get; set; } = null!;

    public string Groups { get; set; } = null!;

    public string Username { get; set; } = null!;

    public DateTime? EditDate { get; set; }

    public string Checksum { get; set; } = null!;
}
