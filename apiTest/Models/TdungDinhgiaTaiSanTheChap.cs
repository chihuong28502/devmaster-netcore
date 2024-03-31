using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class TdungDinhgiaTaiSanTheChap
{
    public string TstcId { get; set; } = null!;

    public string TstcLoaiDinhGia { get; set; } = null!;

    public string HoSoTdId { get; set; } = null!;

    public string? TstcHdtc { get; set; }

    public string? TstcMa { get; set; }

    public string TstcTen { get; set; } = null!;

    public string TstcKyHieu { get; set; } = null!;

    public int TstcSoLuong { get; set; }

    public string TstcDdkyThuat { get; set; } = null!;

    public double TstcThanhTien { get; set; }

    public double TstcTyLeDp { get; set; }

    public string TstcGhiChu { get; set; } = null!;

    public DateTime? TstcNgayDuyet { get; set; }

    public string TstcTaiKhoan { get; set; } = null!;

    public string TstcMaLoai { get; set; } = null!;

    public string TstcMaNhom { get; set; } = null!;

    public int TstcTrangThai { get; set; }

    public string? ChuTsHoten { get; set; }

    public string? ChuTsDiachi { get; set; }

    public string? ChuTsDienthoai { get; set; }

    public string? ChuTsCmtnoicap { get; set; }

    public DateTime? ChuTsCmtngaycap { get; set; }

    public string UsersNew { get; set; } = null!;

    public DateTime? DateNew { get; set; }

    public string? UsersModify { get; set; }

    public DateTime? DateModify { get; set; }

    public string? ChuTsSoCmt { get; set; }
}
