using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class Ozekimessageout
{
    public int Id { get; set; }

    public string? Sender { get; set; }

    public string? Receiver { get; set; }

    public string? Msg { get; set; }

    public string? Senttime { get; set; }

    public string? Receivedtime { get; set; }

    public string? Reference { get; set; }

    public string? Status { get; set; }

    public string? Operator { get; set; }

    public string? Msgtype { get; set; }

    public string? NgayDenHan { get; set; }

    public string? SoHd { get; set; }
}
