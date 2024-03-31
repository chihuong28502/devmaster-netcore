using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class CcAnchiGtcg
{
    public string Ma { get; set; } = null!;

    public string? DanhSach { get; set; }

    public DateTime Ngay { get; set; }

    public DateTime? NgayXuatKho { get; set; }

    public DateTime? NgayXuatQuy { get; set; }

    public string? TinhTrang { get; set; }

    public int? AnchiTrangthai { get; set; }

    public string? KhachHangMa { get; set; }

    public string? ChinhanhMa { get; set; }

    public string? SerialId { get; set; }

    public int? Soluong { get; set; }

    public double? Giatien { get; set; }

    public int Id { get; set; }
}
