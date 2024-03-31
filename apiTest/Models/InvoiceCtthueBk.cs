using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class InvoiceCtthueBk
{
    public string ThueId { get; set; } = null!;

    public string GiaodichId { get; set; } = null!;

    public string LoaiGiaoDichId { get; set; } = null!;

    public string MauHd { get; set; } = null!;

    public DateTime NgayHd { get; set; }

    public string? SoHd { get; set; }

    public string SoCt { get; set; } = null!;

    public string? GhiChu { get; set; }

    public string KhachhangId { get; set; } = null!;

    public string KhachhangTen { get; set; } = null!;

    public string KhachhangDiachi { get; set; } = null!;

    public string MaSoThue { get; set; } = null!;

    public string MaThue { get; set; } = null!;

    public double? ThueSuat { get; set; }

    public double TienTruocThue { get; set; }

    public double TienThue { get; set; }

    public double TongTien { get; set; }

    public int TrangThai { get; set; }

    public string? InvInvoiceAuthId { get; set; }
}
