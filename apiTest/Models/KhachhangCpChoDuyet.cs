using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class KhachhangCpChoDuyet
{
    public int MaId { get; set; }

    public string? KhachhangId { get; set; }

    public DateTime? Ngay { get; set; }

    public double? CpXacLap { get; set; }

    public double? CpThuongXuyen { get; set; }

    public double? CpThuongNien { get; set; }

    public double? LaiCpXacLap { get; set; }

    public double? LaiCpThuongXuyen { get; set; }

    public double? LaiCpThuongNien { get; set; }

    public double? TongLai { get; set; }

    public double? Thue { get; set; }

    public int? TrangThai { get; set; }

    public string? UsersNew { get; set; }

    public DateTime? DateNew { get; set; }

    public string? UsersModify { get; set; }

    public DateTime? DateModify { get; set; }

    public string? DienGiaiXl { get; set; }

    public string? DienGiaiTx { get; set; }

    public string? DienGiaiTn { get; set; }

    public string? ObjectId { get; set; }

    public double? ThuathieuKytruoc { get; set; }

    public DateTime? NgayDuyet { get; set; }

    public string? ChinhanhId { get; set; }
}
