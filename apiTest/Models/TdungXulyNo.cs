using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class TdungXulyNo
{
    public string HosoTdId { get; set; } = null!;

    public DateTime Ngay { get; set; }

    public double ThNh1 { get; set; }

    public double ThNh2 { get; set; }

    public double ThNh3 { get; set; }

    public double ThNh4 { get; set; }

    public double ThNh5 { get; set; }

    public double QhNh1 { get; set; }

    public double QhNh2 { get; set; }

    public double QhNh3 { get; set; }

    public double QhNh4 { get; set; }

    public double QhNh5 { get; set; }

    public string ChinhanhId { get; set; } = null!;
}
