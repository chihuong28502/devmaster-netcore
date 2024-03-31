using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class SmsqueueBaoLaiTienVay
{
    public int Uid { get; set; }

    public string? SoDienThoai { get; set; }

    public string? MsgType { get; set; }

    public string? SmsNgay { get; set; }

    public string? SoHdtd { get; set; }

    public double? Sotienlai { get; set; }

    public string? SmsMessage { get; set; }
}
