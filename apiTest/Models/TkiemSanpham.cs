﻿using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class TkiemSanpham
{
    public string SanPhamMa { get; set; } = null!;

    public string SanPhamTenTat { get; set; } = null!;

    public string? SanPhamTen { get; set; }

    public string? TienTeMa { get; set; }

    public int SanPhamKyHan { get; set; }

    public string? SanPhamGhiChu { get; set; }

    public string? LoaiSpMa { get; set; }

    public string? DvkyHanMa { get; set; }

    public string? Tk1 { get; set; }

    public string? Tk2 { get; set; }

    public string? Tk3 { get; set; }

    public string? Tk4 { get; set; }

    public string? Tk5 { get; set; }

    public string? Tk6 { get; set; }

    public string? SanPhamNguoiNhap { get; set; }

    public DateTime? SanPhamNgayNhap { get; set; }

    public string? SanPhamNguoiCn { get; set; }

    public DateTime? SanPhamNgayCn { get; set; }

    public bool? IsActive { get; set; }

    public virtual DmDvKyHan? DvkyHanMaNavigation { get; set; }

    public virtual TkiemLoaisp? LoaiSpMaNavigation { get; set; }

    public virtual ICollection<TkiemLaisuat> TkiemLaisuats { get; set; } = new List<TkiemLaisuat>();

    public virtual ICollection<TkiemSotietkiem> TkiemSotietkiems { get; set; } = new List<TkiemSotietkiem>();
}
