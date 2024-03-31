using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class TctdvGiaiNgan
{
    public string GiaiNganId { get; set; } = null!;

    public string HopDongId { get; set; } = null!;

    public DateTime? NgayTinhLai { get; set; }

    public DateTime? Ngay { get; set; }

    public string? SoChungTu { get; set; }

    public string? LoaiGiaoDichId { get; set; }

    public int? HinhThucGnId { get; set; }

    public string? MaTkNo { get; set; }

    public string? MaTkCo { get; set; }

    public double? SoTien { get; set; }

    public double? SoDuToan { get; set; }

    public DateTime? NgayDuChiCu { get; set; }

    public double? SoDuChiCu { get; set; }

    public string? GhiChu { get; set; }

    public int? TrangThai { get; set; }

    public string? UsersNew { get; set; }

    public DateTime? DateNew { get; set; }

    public string? UsersModify { get; set; }

    public DateTime? DateModify { get; set; }

    public string? GiaoDichId { get; set; }
}
