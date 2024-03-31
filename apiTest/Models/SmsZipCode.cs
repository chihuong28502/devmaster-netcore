using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class SmsZipCode
{
    public int Id { get; set; }

    public string Zipcode { get; set; } = null!;

    public int IsLocked { get; set; }
}
