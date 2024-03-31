using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class InvoiceCtthue
{
    public string ThueId { get; set; } = null!;

    public string? ThueId0 { get; set; }

    public string LoaiGiaoDichId { get; set; } = null!;

    public DateTime NgayGd { get; set; }

    public DateTime NgayHd { get; set; }

    public DateTime? NgayHuy { get; set; }

    public string MauHd { get; set; } = null!;

    public string SoCt { get; set; } = null!;

    public string KyHieu { get; set; } = null!;

    public string SoHd { get; set; } = null!;

    public string? GhiChu { get; set; }

    public string KhachhangId { get; set; } = null!;

    public string KhachhangTen { get; set; } = null!;

    public string KhachhangDiachi { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string MaSoThue { get; set; } = null!;

    public string MaThue { get; set; } = null!;

    public double ThueSuat { get; set; }

    public double TienTruocThue { get; set; }

    public double TienThue { get; set; }

    public double TongTien { get; set; }

    public int TrangThai { get; set; }

    public string TkThue { get; set; } = null!;

    public string ChinhanhId { get; set; } = null!;

    public string Users { get; set; } = null!;

    public string GiaodichId { get; set; } = null!;

    public string? InvInvoiceAuthId { get; set; }

    public DateTime CreateDateIvc { get; set; }
}
