using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class SysReportConfig
{
    public int MaId { get; set; }

    public string Groups { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string DienGiai { get; set; } = null!;

    public string Title { get; set; } = null!;

    public string MauNumber { get; set; } = null!;

    public string MauDescription { get; set; } = null!;

    public string FilterMaTk { get; set; } = null!;

    public string FilterNgay { get; set; } = null!;

    public string StoredProcedure { get; set; } = null!;

    public string IsChiTietCtu { get; set; } = null!;

    public string IsDuToan { get; set; } = null!;

    public string IsSoDuDky { get; set; } = null!;

    public int CheckMaTk { get; set; }

    public int CheckMaTkDu { get; set; }

    public int CheckMaChuong { get; set; }

    public int CheckMaNguonKp { get; set; }

    public int CheckMaTcNguonKp { get; set; }

    public int CheckMaMuc { get; set; }

    public int CheckMaTieuMuc { get; set; }

    public int CheckMaTieuNhom { get; set; }

    public int CheckMaKhoan { get; set; }

    public int CheckMaLoai { get; set; }

    public int CheckMaCtmt { get; set; }

    public int CheckMaDuAn { get; set; }

    public int CheckMaDtpn { get; set; }

    public int CheckMaCapPhat { get; set; }

    public int CheckMaHdsn { get; set; }

    public int CheckMaNghiepVu { get; set; }

    public int CheckMaLoaiQuy { get; set; }

    public int CheckTimeReport { get; set; }

    public string NameOffice0 { get; set; } = null!;

    public string NameOffice1 { get; set; } = null!;

    public string Subtitle { get; set; } = null!;

    public string Source0 { get; set; } = null!;

    public string Source1 { get; set; } = null!;

    public string Source2 { get; set; } = null!;

    public string Source3 { get; set; } = null!;

    public string Source4 { get; set; } = null!;

    public string Source5 { get; set; } = null!;

    public string Label0 { get; set; } = null!;

    public string Label1 { get; set; } = null!;

    public string Label2 { get; set; } = null!;

    public string Label3 { get; set; } = null!;

    public string Label4 { get; set; } = null!;

    public string Label5 { get; set; } = null!;

    public bool Active { get; set; }

    public string FileName { get; set; } = null!;

    public string ReportDescription { get; set; } = null!;

    public bool PrintDatetime { get; set; }

    public bool PrintSigner { get; set; }

    public string DefaultFilter { get; set; } = null!;

    public string Modules { get; set; } = null!;
}
