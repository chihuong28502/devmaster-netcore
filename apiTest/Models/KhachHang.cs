using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class KhachHang
{
    public string KhachHangId { get; set; } = null!;

    public string Ma { get; set; } = null!;

    public int PhanLoaiMa { get; set; }

    public string PhanNhomMa { get; set; } = null!;

    public DateTime? Ngay { get; set; }

    public string TenTat { get; set; } = null!;

    public string Ten { get; set; } = null!;

    public int GioiTinh { get; set; }

    public DateTime? NgaySinh { get; set; }

    public string PhoneOffice { get; set; } = null!;

    public string? PhoneMobie { get; set; }

    public string Fax { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string SoDkkd { get; set; } = null!;

    public DateTime? NgayDkkd { get; set; }

    public string MaSoThue { get; set; } = null!;

    public string? NguoiDaiDien { get; set; }

    public string? ChucVuMa { get; set; }

    public string CmtSerial { get; set; } = null!;

    public DateTime? CmtNgayCap { get; set; }

    public string CmtNoiCap { get; set; } = null!;

    public string DiaChi { get; set; } = null!;

    public string KhuVucMa { get; set; } = null!;

    public string NganhNgheKdMa { get; set; } = null!;

    public string LoaiHinhDnMa { get; set; } = null!;

    public string NgheNghiepMa { get; set; } = null!;

    public int ThanhvienIs { get; set; }

    public string ThanhvienSerial { get; set; } = null!;

    public DateTime? ThanhvienNgay { get; set; }

    public string ThanhvienMa { get; set; } = null!;

    public string GhiChu { get; set; } = null!;

    public string ChinhanhId { get; set; } = null!;

    public bool IsChecked { get; set; }

    public bool IsLocked { get; set; }

    public string UsersNew { get; set; } = null!;

    public DateTime? DateNew { get; set; }

    public string UsersModify { get; set; } = null!;

    public DateTime? DateModify { get; set; }

    public double CoPhanXacLap { get; set; }

    public double CoPhanThuongXuyen { get; set; }

    public double DiemThuong { get; set; }

    public DateTime? NgayTinhDiem { get; set; }

    public double CoPhanThuongNien { get; set; }

    public int? MqhNuq { get; set; }

    public string? TenNuq { get; set; }

    public DateTime? NgaySinhNuq { get; set; }

    public string? DiaChiNuq { get; set; }

    public string? NoiONuq { get; set; }

    public string? CmtSerialNuq { get; set; }

    public DateTime? CmtNgaycapNuq { get; set; }

    public string? CmtNoicapNuq { get; set; }

    public string? DienThoaiNuq { get; set; }

    public string CmtSerialOld { get; set; } = null!;

    public string? DiaChiTt { get; set; }

    public DateTime? CmtOldNgayCap { get; set; }

    public string? CmtOldNoiCap { get; set; }

    public string? SoTaiKhoan { get; set; }

    public string? TenNganHang { get; set; }

    public string? DanToc { get; set; }
}
