using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class DmChinhanh
{
    public string Ma { get; set; } = null!;

    public string TenTat { get; set; } = null!;

    public string Ten { get; set; } = null!;

    public string DiaChi { get; set; } = null!;

    public string DienThoai { get; set; } = null!;

    public string Fax { get; set; } = null!;

    public string GhiChu { get; set; } = null!;

    public string NguoiPhuTrach { get; set; } = null!;

    public string? TieuDeBaoCao { get; set; }

    public string? DiaChiBaoCao { get; set; }

    public string? TieuDeThuQui { get; set; }

    public string? TieuDeKeToanTruong { get; set; }

    public string? TieuDeKeToan { get; set; }

    public string? TieuDeKiemSoat { get; set; }

    public string? TieuDeGiamDoc { get; set; }

    public string? TieuDeNguoiNhanTien { get; set; }

    public string? TieuDeNguoiGuiTien { get; set; }

    public string? TenThuQui { get; set; }

    public string? TenKeToanTruong { get; set; }

    public string? TenKeToan { get; set; }

    public string? TenKiemSoat { get; set; }

    public string? TenGiamDoc { get; set; }

    public string? TenNguoiNhanTien { get; set; }

    public string? TenNguoiGuiTien { get; set; }

    public string? DiaChiTat { get; set; }

    public string? TieuDeNguoiLapBang { get; set; }

    public string? TenNguoiLapBang { get; set; }

    public bool? Active { get; set; }

    public virtual ICollection<TctdgSotiengui> TctdgSotienguis { get; set; } = new List<TctdgSotiengui>();

    public virtual ICollection<TguiSotiengui> TguiSotienguis { get; set; } = new List<TguiSotiengui>();

    public virtual ICollection<TkiemSotietkiem> TkiemSotietkiems { get; set; } = new List<TkiemSotietkiem>();
}
