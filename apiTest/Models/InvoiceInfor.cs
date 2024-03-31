using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class InvoiceInfor
{
    public string Id { get; set; } = null!;

    public string? Comments { get; set; }

    public string Realvalue { get; set; } = null!;
}
