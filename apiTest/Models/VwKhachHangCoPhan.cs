using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class VwKhachHangCoPhan
{
    public string CoPhanGdId { get; set; } = null!;

    public string KhachHangId { get; set; } = null!;

    public string? Ngay { get; set; }

    public string? NgayHuongLai { get; set; }

    public int LoaiGiaoDich { get; set; }

    public int LoaiGopVon { get; set; }

    public double LaiSuat { get; set; }

    public string MaTkNo { get; set; } = null!;

    public string MaTkCo { get; set; } = null!;

    public int TrangThai { get; set; }

    public double SoPhatSinh { get; set; }

    public string GhiChu { get; set; } = null!;

    public bool Active { get; set; }

    public bool Checked { get; set; }

    public bool Locked { get; set; }

    public string UsersNew { get; set; } = null!;

    public DateTime? DateNew { get; set; }

    public string UsersModify { get; set; } = null!;

    public DateTime? DateModify { get; set; }

    public string? KhachHangMa { get; set; }

    public string? KhachHangTen { get; set; }

    public string? DiaChi { get; set; }

    public string? KhuVucMa { get; set; }

    public string? CmtSerial { get; set; }

    public string? KhuvucTen { get; set; }

    public string? ThanhvienMa { get; set; }

    public int? PhanLoaiMa { get; set; }

    public string? PhanNhomMa { get; set; }

    public int? GioiTinh { get; set; }

    public int? ThanhvienIs { get; set; }

    public string? ThanhvienSerial { get; set; }

    public string? ThanhVienNgay { get; set; }

    public string? ChinhanhId { get; set; }

    public string? NganhNgheKdMa { get; set; }

    public string? LoaiHinhDnMa { get; set; }

    public string SoChungTu { get; set; } = null!;
}
