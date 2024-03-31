using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class NqGiaoDich
{
    public string GiaoDichId { get; set; } = null!;

    public string LoaiTienId { get; set; } = null!;

    public string? SoChungTu { get; set; }

    public string? TienTe { get; set; }

    public DateTime Ngay { get; set; }

    public string? LoaiGiaoDich { get; set; }

    public double? SoTien { get; set; }

    public int? Thu { get; set; }

    public int? Chi { get; set; }

    public int? TonDauKy { get; set; }

    public int? TonCuoiKy { get; set; }

    public string? ChiNhanhId { get; set; }

    public string? UsersNew { get; set; }

    public DateTime? DateNew { get; set; }

    public string? UsersModify { get; set; }

    public DateTime? DateModify { get; set; }

    public string? TkTm { get; set; }

    public int IsGd { get; set; }
}
