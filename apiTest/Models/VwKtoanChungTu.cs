using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class VwKtoanChungTu
{
    public string ChungTuGdId { get; set; } = null!;

    public DateTime? Ngay { get; set; }

    public string Serial { get; set; } = null!;

    public string MaTkNo { get; set; } = null!;

    public string MaTkCo { get; set; } = null!;

    public double SoPhatSinh { get; set; }

    public string DienGiai { get; set; } = null!;

    public string MaGiaoDich { get; set; } = null!;

    public string MaChungTu { get; set; } = null!;

    public string TienteMa { get; set; } = null!;

    public double TienteTyGia { get; set; }

    public int TrangThai { get; set; }

    public string CtuHoTen { get; set; } = null!;

    public string CtuDiaChi { get; set; } = null!;

    public string CtuCmtSerial { get; set; } = null!;

    public DateTime? CtuCmtNgay { get; set; }

    public string CtuCmtNoiCap { get; set; } = null!;

    public string DienGiai0 { get; set; } = null!;

    public string DienGiai1 { get; set; } = null!;

    public string DienGiai2 { get; set; } = null!;

    public string UsersNew { get; set; } = null!;

    public DateTime? DateNew { get; set; }

    public string UsersModify { get; set; } = null!;

    public DateTime? DateModify { get; set; }

    public bool Active { get; set; }

    public bool IsLocked { get; set; }

    public bool IsSystem { get; set; }

    public string ChiNhanhId { get; set; } = null!;

    public string? TenGiaoDich { get; set; }

    public string? TenChungTu { get; set; }

    public string? TienteTen { get; set; }

    public string GiaoDichDcId { get; set; } = null!;

    public string? TenTkNo { get; set; }

    public string? TenTkCo { get; set; }
}
