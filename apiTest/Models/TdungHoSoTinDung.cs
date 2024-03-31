using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class TdungHoSoTinDung
{
    public string HoSoTdId { get; set; } = null!;

    public string KhachHangId { get; set; } = null!;

    public string TkTinDung { get; set; } = null!;

    public string SoHopDong { get; set; } = null!;

    public DateTime? NgayHopDong { get; set; }

    public string TenNguoiVay { get; set; } = null!;

    public string NguoiThuaKe { get; set; } = null!;

    public string NguoiBaoLanh { get; set; } = null!;

    public string SanPhamTdId { get; set; } = null!;

    public DateTime? NgayVay { get; set; }

    public double SoTienVay { get; set; }

    public int KyHanVay { get; set; }

    public int DonViKyHan { get; set; }

    public DateTime? NgayDaoHan { get; set; }

    public double LaiSuat { get; set; }

    public int KieuLaiSuat { get; set; }

    public DateTime? NgayGiaHan { get; set; }

    public DateTime? NgayChuyenQuaHan { get; set; }

    public double LaiSuatQuaHan { get; set; }

    public string MucDichVay { get; set; } = null!;

    public int NhomNo { get; set; }

    public string HinhThucTraLaiId { get; set; } = null!;

    public int LoaiVayId { get; set; }

    public string DoiTuongId { get; set; } = null!;

    public string PhuongThucVayId { get; set; } = null!;

    public string HinhThucTstcId { get; set; } = null!;

    public string GhiChu { get; set; } = null!;

    /// <summary>
    /// Số dư hiện thời của hồ sơ tín dụng
    /// </summary>
    public double SoDu { get; set; }

    public double SoGiaiNgan { get; set; }

    /// <summary>
    /// Tổng trị giá tài sản thế chấp
    /// </summary>
    public double TstcTriGia { get; set; }

    /// <summary>
    /// Tổng Số Lãi đã thu hiện thời của hồ sơ tín dụng
    /// </summary>
    public double LaiDaThu { get; set; }

    /// <summary>
    /// Ngày thu lãi gần nhất đã thu hiện thời của hồ sơ tín dụng
    /// </summary>
    public DateTime? LaiDenNgay { get; set; }

    /// <summary>
    /// Tổng số GỐC đã thu của hồ sơ
    /// </summary>
    public double GocDaThu { get; set; }

    /// <summary>
    /// Ngày thu gốc gần nhất
    /// </summary>
    public DateTime? GocDenNgay { get; set; }

    /// <summary>
    /// Tổng số lãi dự thu
    /// </summary>
    public double LaiDuThu { get; set; }

    /// <summary>
    /// Số ngày dự thu
    /// </summary>
    public DateTime? NgayDuThu { get; set; }

    public int TrangThai { get; set; }

    public int QuaHan { get; set; }

    public double NoQuaHan { get; set; }

    public double SoTienDuPhong { get; set; }

    public DateTime? NgayDtdk { get; set; }

    public int DauVao { get; set; }

    public double SoTienNo { get; set; }

    public string? NguyenNhanNo { get; set; }

    public double SoTienNhan { get; set; }

    public string UsersNew { get; set; } = null!;

    public DateTime? DateNew { get; set; }

    public string UsersModify { get; set; } = null!;

    public DateTime? DateModify { get; set; }

    public bool Active { get; set; }

    public bool Checked { get; set; }

    public bool Locked { get; set; }

    public string? MaThongKe0 { get; set; }

    public string? MaThongKe1 { get; set; }

    public string? MaMucDichVay { get; set; }

    public double? SoKyTraGop { get; set; }

    public double? LaiPhaiThu { get; set; }

    public double? LaiTheoKy { get; set; }

    public double? LaiKyCuoi { get; set; }

    public double? GocTheoKy { get; set; }

    public double? GocKyCuoi { get; set; }

    public string? Tk { get; set; }

    public bool LaiSuatUuDai { get; set; }

    public double LaiDuThuCu { get; set; }

    public DateTime? NgayDuThuCu { get; set; }

    public string HstdParent { get; set; } = null!;

    public string Sokheuoc { get; set; } = null!;

    public DateTime? NgayGiaiNgan { get; set; }
}
