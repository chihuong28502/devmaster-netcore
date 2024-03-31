using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class KhachHangDmChamDiemKhXepLoai
{
    public int Id { get; set; }

    public int? MinXl { get; set; }

    public int? MaxXl { get; set; }

    public string? XepLoai { get; set; }

    public string? DanhGia { get; set; }

    public string? IsChoVay { get; set; }
}
