using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class SpRequestSupport
{
    public string? Id { get; set; }

    public int? MaMucUuTien { get; set; }

    public int? MaLoaiHoTro { get; set; }

    public string? MaQuy { get; set; }

    public string? TenQuy { get; set; }

    public string? TenCanBo { get; set; }

    public string? ChucVu { get; set; }

    public string? Sdt { get; set; }

    public string? TieuDe { get; set; }

    public string? ThongTinKetNoi { get; set; }

    public string? NoiDung { get; set; }

    public string? FileMau { get; set; }

    public short? StatusSupport { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UserSupport { get; set; }

    public string? NoiDungSupport { get; set; }

    public DateTime? UpdateDate { get; set; }
}
