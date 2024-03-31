using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class TdungDmHthucTraLai
{
    public string Ma { get; set; } = null!;

    public string Ten { get; set; } = null!;

    public bool? Active { get; set; }
}
