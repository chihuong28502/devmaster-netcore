using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class Tt21TienGium
{
    public int MaId { get; set; }

    public DateTime? Ngay { get; set; }

    public string LoaiTienId { get; set; } = null!;

    public double TonDauKy { get; set; }

    public double NhapTrongKy { get; set; }

    public double XuatTrongKy { get; set; }

    public double TonCuoiKy { get; set; }

    public string? Chinhanhid { get; set; }
}
