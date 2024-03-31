using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class TkiemPhichuyentien
{
    public int IdPhiChuyenTien { get; set; }

    public DateTime? TuNgay { get; set; }

    public decimal? CungDiaBan { get; set; }

    public decimal? KhacDiaBan { get; set; }

    public decimal? CoTaiKhoan { get; set; }

    public decimal? KhongCoTaiKhoan { get; set; }

    public int? Gio { get; set; }

    public decimal? TruocGio { get; set; }

    public decimal? SauGio { get; set; }

    public decimal? PhiToiThieu { get; set; }

    public decimal? PhiToiDa { get; set; }

    public decimal? Vat { get; set; }

    public virtual ICollection<TkiemPhichuyentienKhoangtien> TkiemPhichuyentienKhoangtiens { get; set; } = new List<TkiemPhichuyentienKhoangtien>();
}
