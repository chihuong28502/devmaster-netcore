using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class CtGiaoDich
{
    public string Uid { get; set; } = null!;

    public string? CtLenh { get; set; }

    public string? SoBt { get; set; }

    public DateTime? Ngay { get; set; }

    public string? LoaiGiaoDich { get; set; }

    public string? LoaiChungTu { get; set; }

    public string? CtHinhThuc { get; set; }

    public string? CtTienTe { get; set; }

    public int? CtTrangThai { get; set; }

    public string? CtGiaoDichId { get; set; }

    public string? CtChuyenKhoanId { get; set; }

    public string? CtNoiDung { get; set; }

    public int? CtDmBieuPhiUid { get; set; }

    public string? FePhiThuId { get; set; }

    public string? FeVatId { get; set; }

    public string? InKhid { get; set; }

    public string? InTkThanhToan { get; set; }

    public string? InTkNganHang { get; set; }

    public string? InDauMoiMa { get; set; }

    public string? InDauMoiTen { get; set; }

    public string? ExKhid { get; set; }

    public string? ExTkNganHang { get; set; }

    public string? ExDauMoiMa { get; set; }

    public string? ExDauMoiTen { get; set; }

    public string? UserCreate { get; set; }

    public DateTime? DateCreate { get; set; }

    public string? UserModify { get; set; }

    public DateTime? DateModify { get; set; }
}
