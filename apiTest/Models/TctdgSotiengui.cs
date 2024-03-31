using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class TctdgSotiengui
{
    public string StkMa { get; set; } = null!;

    public string? StkTen { get; set; }

    public string? StkSoTietKiem { get; set; }

    public string? StkTkct { get; set; }

    public string? ChiNhanhMa { get; set; }

    public string? TctdMa { get; set; }

    public decimal? StkSoDu { get; set; }

    public decimal? StkLaiDaThu { get; set; }

    public string? SanPhamMa { get; set; }

    public string? TienTeMa { get; set; }

    public DateTime? StkNgayBatDau { get; set; }

    public string? HttlMa { get; set; }

    public DateTime? StkNgayBatDauTinhLai { get; set; }

    public DateTime? StkNgayDenHan { get; set; }

    public DateTime? StkDuthuDenNgay { get; set; }

    public decimal? StkDuthu { get; set; }

    public DateTime? StkNgayKyMoi { get; set; }

    public int? StkTrangThai { get; set; }

    public bool? StkCoTheThayDoiLaiSuat { get; set; }

    public bool? StkPhongToa { get; set; }

    public string? StkGhiChu { get; set; }

    public DateTime? StkNgayNhap { get; set; }

    public string? StkNguoiNhap { get; set; }

    public DateTime? StkNgayCapNhat { get; set; }

    public string? StkNguoiCapNhat { get; set; }

    public int? StkDaLaiNhapGoc { get; set; }

    public DateTime? StkNgayPhongToa { get; set; }

    public virtual DmChinhanh? ChiNhanhMaNavigation { get; set; }

    public virtual TctdgSanpham? SanPhamMaNavigation { get; set; }

    public virtual ICollection<TctdgLaisuatstg> TctdgLaisuatstgs { get; set; } = new List<TctdgLaisuatstg>();
}
