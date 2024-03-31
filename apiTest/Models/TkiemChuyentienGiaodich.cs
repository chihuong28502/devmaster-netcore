using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class TkiemChuyentienGiaodich
{
    public string Ma { get; set; } = null!;

    public string TenFile { get; set; } = null!;

    public string? SoHieuGiaoDich { get; set; }

    public string? NgayLamViecHeThong { get; set; }

    public string? MaPhanLoaiDichVu { get; set; }

    public string? LoaiGiaoDichChuyenTien { get; set; }

    public decimal? SoTienGiaoDich { get; set; }

    public string? LoaiTienTe { get; set; }

    public DateTime? ThoiDiemTaoGiaoDich { get; set; }

    public string? SoButToan { get; set; }

    public string? NoiDungGiaoDich { get; set; }

    public string? ChiNhanhDauMoiGuiMa { get; set; }

    public string? NguoiKiemSoatGiaoDichDauMoiGui { get; set; }

    public string? ChiNhanhDauMoiNhanMa { get; set; }

    public string? NguoiDuyetGiaoDichDauMoiNhan { get; set; }

    public string? DonViKhoiPhatGiaoDichMa { get; set; }

    public string? KhachHangGuiMa { get; set; }

    public string? KhachHangGuiTen { get; set; }

    public string? KhachHangGuiDiaChi { get; set; }

    public string? KhachHangGuiCmnd { get; set; }

    public string? KhachHangGuiCmndNgayCap { get; set; }

    public string? KhachHangGuiCmndNoiCap { get; set; }

    public string? KhachHangGuiTaiKhoanCaNhan { get; set; }

    public string? NguoiKiemSoatGiaoDichDonViKhoiPhat { get; set; }

    public string? DonViNhanGiaoDichMa { get; set; }

    public string? KhachHangNhanMa { get; set; }

    public string? KhachHangNhanTen { get; set; }

    public string? KhachHangNhanDiaChi { get; set; }

    public string? KhachHangNhanCmnd { get; set; }

    public string? KhachHangNhanCmndNgayCap { get; set; }

    public string? KhachHangNhanCmndNoiCap { get; set; }

    public string? KhachHangNhanTaiKhoanCaNhan { get; set; }

    public string? MaSoThueKhachHangThuHuong { get; set; }

    public string? HanMucKhachHangThuHuong { get; set; }

    public string? NguoKiemSoatGiaoDichDonViNhan { get; set; }

    public string? ThoiGianKiemSoatGiaoDichDvn { get; set; }

    public string? ThongTinKqxlgiaoDich { get; set; }

    public string? TinhTrangGiaoDich { get; set; }

    public string? LoaiNghiepVuMa { get; set; }

    public string? KyHieuChuyenTien { get; set; }

    public int? HuyGiaoDich { get; set; }

    public string? MaXacThuc { get; set; }

    public decimal? LePhiChuyen { get; set; }

    public int? TrangThaiGiaoDichChuyenTien { get; set; }

    public string? UserNew { get; set; }

    public DateTime? DateNew { get; set; }

    public string? UserModify { get; set; }

    public DateTime? DateModify { get; set; }
}
