using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class GiaoDich
{
    public string GiaoDichId { get; set; } = null!;

    public string LoaiChungTuId { get; set; } = null!;

    public string LoaiGiaoDichId { get; set; } = null!;

    public DateTime Ngay { get; set; }

    public string? DienGiai { get; set; }

    public string TienTeMa { get; set; } = null!;

    public double TienTeTyGia { get; set; }

    public string ObjectId { get; set; } = null!;

    public string? ObjectSerial { get; set; }

    public string MaTkNo { get; set; } = null!;

    public string MaTkCo { get; set; } = null!;

    public double SoPhatSinh { get; set; }

    public double SoDuToan { get; set; }

    public int TrangThai { get; set; }

    public string ChinhanhId { get; set; } = null!;

    public string? UsersNew { get; set; }

    public DateTime? DateNew { get; set; }

    public string UsersModify { get; set; } = null!;

    public DateTime? DateModify { get; set; }

    public string? KhId { get; set; }
}
