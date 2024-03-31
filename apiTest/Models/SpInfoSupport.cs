using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class SpInfoSupport
{
    public int Id { get; set; }

    public string? IdRequest { get; set; }

    public string? UserSupport { get; set; }

    public short? StatusSupport { get; set; }

    public string? NoiDungSupport { get; set; }

    public DateTime? CreateDateSupport { get; set; }

    public DateTime? UpdateDateSupport { get; set; }
}
