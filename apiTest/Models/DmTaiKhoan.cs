using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class DmTaiKhoan
{
    public string Ma { get; set; } = null!;

    public string Ten { get; set; } = null!;

    public int TinhChat { get; set; }

    public string TkNganHang { get; set; } = null!;

    public string TkCanDoi { get; set; } = null!;

    public string? MaCha { get; set; }

    public int BacTk { get; set; }

    public bool? Active { get; set; }

    public bool? IsSystem { get; set; }

    public string? UsersNew { get; set; }

    public DateTime? DateNew { get; set; }

    public string? UsersModify { get; set; }

    public DateTime? DateModify { get; set; }
}
