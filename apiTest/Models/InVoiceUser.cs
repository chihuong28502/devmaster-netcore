using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class InVoiceUser
{
    public int Id { get; set; }

    public string UserName { get; set; } = null!;

    public string FullName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string MaDvcs { get; set; } = null!;

    public string? UrlMinvoice { get; set; }

    public int TypeCks { get; set; }

    public int? PinChecked { get; set; }
}
