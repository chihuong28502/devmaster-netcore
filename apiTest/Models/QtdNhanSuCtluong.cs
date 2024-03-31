using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class QtdNhanSuCtluong
{
    public int LuongId { get; set; }

    public string KhachhangId { get; set; } = null!;

    public DateTime? NgayTl { get; set; }

    public DateTime? NgayGd { get; set; }

    public decimal? LuongCb { get; set; }

    public decimal? LuongTn { get; set; }

    public decimal? LuongTrN { get; set; }

    public decimal? LuongKd { get; set; }

    public decimal? TongLuong { get; set; }

    public decimal? LuongBhxh { get; set; }

    public decimal? BhxhNv { get; set; }

    public decimal? BhtnNv { get; set; }

    public decimal? BhytNv { get; set; }

    public decimal? ThuHo { get; set; }

    public decimal? PhuCap { get; set; }

    public decimal? BhxhQ { get; set; }

    public decimal? BhtnQ { get; set; }

    public decimal? BhytQ { get; set; }

    public decimal? ThucLinh { get; set; }

    public string? UsersNew { get; set; }

    public DateTime? DateNew { get; set; }

    public string? UsersModify { get; set; }

    public DateTime? DateModify { get; set; }

    public decimal? GiamTru { get; set; }

    public decimal? LuongTinhThue { get; set; }

    public decimal? ThueTncn { get; set; }

    public decimal? NgayCong { get; set; }

    public decimal? KpcdNv { get; set; }

    public decimal? KpcdQ { get; set; }

    public decimal? LamThem { get; set; }

    public decimal? ClAnca { get; set; }

    public double DangPhiNv { get; set; }

    public double DoanPhiNv { get; set; }

    public double DangPhiQ { get; set; }

    public double DoanPhiQ { get; set; }

    public double TyLeLkd { get; set; }

    public decimal? HeSo { get; set; }

    public decimal? LuongTt { get; set; }

    public double TntthueLamThem { get; set; }

    public decimal TyLeTinhLuong { get; set; }

    public string? GiaodichId { get; set; }

    public decimal HsTn { get; set; }

    public decimal HsTrN { get; set; }

    public decimal TongCpNv { get; set; }

    public decimal TongCpQ { get; set; }
}
