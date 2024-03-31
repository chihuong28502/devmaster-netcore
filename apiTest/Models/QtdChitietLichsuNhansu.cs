using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class QtdChitietLichsuNhansu
{
    public string KhachHangId { get; set; } = null!;

    public DateTime Ngay { get; set; }

    public string PhongbanId { get; set; } = null!;

    public string NhanSuChucVu { get; set; } = null!;

    public string? NhanSuTrinhDo { get; set; }

    public double? NhanSuHeSoLuong { get; set; }

    public string? NhanSuGhichu { get; set; }

    public int? IsActived { get; set; }

    public string? SoHdld { get; set; }

    public int? LoaiHd { get; set; }

    public int? LoaiThoiHan { get; set; }

    public int? DonviThoihan { get; set; }

    public int? ThoiHan { get; set; }
}
