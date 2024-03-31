using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class Tt21TietKiem
{
    public string SoTietKiemId { get; set; } = null!;

    public string SoTietKiem { get; set; } = null!;

    public string TkTietKiem { get; set; } = null!;

    public string LoaiTienId { get; set; } = null!;

    public string LoaiHinhKinhTeId { get; set; } = null!;

    public double SoDu { get; set; }

    public double LaiSuat { get; set; }

    public DateTime? NgayGui { get; set; }

    public DateTime? NgayDaoHan { get; set; }

    public string LoaiKyHan { get; set; } = null!;

    public int DonViKyHan { get; set; }

    public DateTime? Ngay { get; set; }

    public string? KhachhangId { get; set; }
}
