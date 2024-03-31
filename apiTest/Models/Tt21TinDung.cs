using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class Tt21TinDung
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

    public bool ThanhVien { get; set; }

    public bool HoNgheo { get; set; }

    public double SoDu { get; set; }

    public double LaiSuat { get; set; }

    public bool LaiSuatUuDai { get; set; }

    public int NhomNo { get; set; }

    public int LoaiVayId { get; set; }

    public DateTime? NgayVay { get; set; }

    public DateTime? NgayDaoHan { get; set; }

    public DateTime? Ngay { get; set; }

    public string? KhachhangId { get; set; }
}
