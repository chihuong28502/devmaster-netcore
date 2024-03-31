using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class QtdNhanSuThuongPc
{
    public int Id { get; set; }

    public string KhachhangId { get; set; } = null!;

    public DateTime? NgayTinh { get; set; }

    public DateTime? NgayGd { get; set; }

    public string? MaThuong { get; set; }

    public int? TinhChat { get; set; }

    public decimal? TongHeso { get; set; }

    public int? SoThang { get; set; }

    public decimal? SoTien { get; set; }

    public string? DienGiai { get; set; }

    public string? GiaodichId { get; set; }
}
