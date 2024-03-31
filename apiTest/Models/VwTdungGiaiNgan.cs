using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class VwTdungGiaiNgan
{
    public string GiaiNganId { get; set; } = null!;

    public string HoSoTdId { get; set; } = null!;

    public string? NgayTinhLai { get; set; }

    public string? Ngay { get; set; }

    public int? HinhThucGnId { get; set; }

    public string? MaTkNo { get; set; }

    public string? MaTkCo { get; set; }

    public double? SoTien { get; set; }

    public double? SoDuToan { get; set; }

    public string? GhiChu { get; set; }

    public int? TrangThai { get; set; }

    public bool Active { get; set; }

    public bool Locked { get; set; }

    public bool Checked { get; set; }

    public string? KhachHangId { get; set; }

    public string? TkTinDung { get; set; }

    public string? SoHopDong { get; set; }

    public string? NgayHopDong { get; set; }

    public string? TenNguoiVay { get; set; }

    public string? SanPhamTdId { get; set; }

    public string? NgayVay { get; set; }

    public double? SoTienVay { get; set; }

    public int? DonViKyHan { get; set; }

    public int? KyHanVay { get; set; }

    public string? NgayDaoHan { get; set; }

    public double? LaiSuat { get; set; }

    public int? KieuLaiSuat { get; set; }

    public string? NgayGiaHan { get; set; }

    public string? NgayChuyenQuaHan { get; set; }

    public double? LaiSuatQuaHan { get; set; }

    public string? MucDichVay { get; set; }

    public int? NhomNo { get; set; }

    public string? HinhThucTraLaiId { get; set; }

    public int? LoaiVayId { get; set; }

    public string? DoiTuongId { get; set; }

    public string? PhuongThucVayId { get; set; }

    public string? HinhThucTstcId { get; set; }

    public string? DienGiai { get; set; }

    public string? KhachHangMa { get; set; }

    public string? KhachHangTen { get; set; }

    public string? CmtSerial { get; set; }

    public string? DiaChi { get; set; }

    public string? KhuVucMa { get; set; }

    public string? ThanhvienSerial { get; set; }

    public string? KhuvucTen { get; set; }

    public string? TenLoaiVay { get; set; }

    public double? SoDu { get; set; }

    public double? ThuaThieuKyTruoc { get; set; }

    public double? ThuaThieuKyNay { get; set; }

    public string? MaMucDichVay { get; set; }

    public bool? LaiSuatUuDai { get; set; }

    public string? MaThongKe1 { get; set; }

    public string? MaThongKe0 { get; set; }
}
