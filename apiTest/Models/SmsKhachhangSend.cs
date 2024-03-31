using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class SmsKhachhangSend
{
    public string KhachHangId { get; set; } = null!;

    public int SendBdsdLng { get; set; }

    public int SendSinhNhat { get; set; }

    public int SendCskh { get; set; }

    public int SendTbdh { get; set; }

    public int SendLaiTd { get; set; }
}
