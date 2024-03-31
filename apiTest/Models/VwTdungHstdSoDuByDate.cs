using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class VwTdungHstdSoDuByDate
{
    public string HosoTdId { get; set; } = null!;

    public string TkTinDung { get; set; } = null!;

    public string KhuvucMa { get; set; } = null!;

    public string NganhKinhTeId { get; set; } = null!;

    public string LoaiTienId { get; set; } = null!;

    public string LoaiHinhKinhTeId { get; set; } = null!;

    public string PhuongThucTheChapId { get; set; } = null!;

    public string MucDichVayId { get; set; } = null!;

    public string ChinhanhId { get; set; } = null!;

    public double SoDu { get; set; }

    public double LaiSuat { get; set; }

    public bool LaiSuatUuDai { get; set; }

    public int NhomNo { get; set; }

    public int LoaiVayId { get; set; }

    public string? NgayVay { get; set; }

    public string? NgayDaoHan { get; set; }

    public string? KhachHangId { get; set; }

    public string? SoHopDong { get; set; }

    public string? TenNguoiVay { get; set; }

    public string? SanPhamTdId { get; set; }

    public string? KhuvucTen { get; set; }
}
