using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class SmstrangThai
{
    public string? NgayLamViec { get; set; }

    public string? LoaiDuLieu { get; set; }

    /// <summary>
    /// 0: Chưa bắt đầu; 1: Đang làm; 2: Đã xong
    /// </summary>
    public int? TrangThai { get; set; }
}
