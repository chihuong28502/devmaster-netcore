using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class CcNhapXuat
{
    public string NxId { get; set; } = null!;

    public string? MaChungchi { get; set; }

    public DateTime? Ngay { get; set; }

    public int? Soluong { get; set; }

    public double? Giatien { get; set; }

    public double? Sotien { get; set; }

    public int? Nhapxuat { get; set; }

    public string? DienGiai { get; set; }

    public int? TrangThai { get; set; }

    public string? ChinhanhId { get; set; }

    public string? HoTen { get; set; }

    public string? CmtSerial { get; set; }

    public DateTime? CmtNgay { get; set; }

    public string? CmtNoiCap { get; set; }

    public string? SoChungTu { get; set; }

    public string? ChucVu { get; set; }

    public string? HoTen1 { get; set; }

    public string? CmtSerial1 { get; set; }

    public DateTime? CmtNgay1 { get; set; }

    public string? CmtNoiCap1 { get; set; }

    public string? ChucVu1 { get; set; }

    public string? TienTo { get; set; }

    public string? TuSerial { get; set; }

    public string? ToiSerial { get; set; }

    public virtual CcDanhmuc? MaChungchiNavigation { get; set; }
}
