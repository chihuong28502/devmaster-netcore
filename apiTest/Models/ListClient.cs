using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class ListClient
{
    public string ComputerName { get; set; } = null!;

    public string? PathRun { get; set; }

    public string? IsServer { get; set; }

    public string? IsConnected { get; set; }

    public string? Updated { get; set; }

    public string? LastUpdated { get; set; }

    public DateTime? VersionDate { get; set; }
}
