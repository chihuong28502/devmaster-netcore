using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class KhachhangRegInforDevice
{
    public int Id { get; set; }

    public string PortName { get; set; } = null!;

    public int BaudRate { get; set; }

    public int DataBits { get; set; }

    public string? Parity { get; set; }

    public string? StopBits { get; set; }

    public string? Handshake { get; set; }

    public int ReadTimeout { get; set; }

    public int? RtsEnable { get; set; }

    public int? DtrEnable { get; set; }

    public DateTime DateNew { get; set; }
}
