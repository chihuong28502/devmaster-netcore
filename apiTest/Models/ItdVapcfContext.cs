using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace apiTest.Models;

public partial class ItdVapcfContext : DbContext
{
    public ItdVapcfContext()
    {
    }

    public ItdVapcfContext(DbContextOptions<ItdVapcfContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CcAnchiGtcg> CcAnchiGtcgs { get; set; }

    public virtual DbSet<CcDanhmuc> CcDanhmucs { get; set; }

    public virtual DbSet<CcNhapXuat> CcNhapXuats { get; set; }

    public virtual DbSet<CcNhapXuatDetail> CcNhapXuatDetails { get; set; }

    public virtual DbSet<CdAnhxatk> CdAnhxatks { get; set; }

    public virtual DbSet<CdSoducu> CdSoducus { get; set; }

    public virtual DbSet<CdSodumoi> CdSodumois { get; set; }

    public virtual DbSet<CdTaikhoanChitiet> CdTaikhoanChitiets { get; set; }

    public virtual DbSet<ChitieuCb> ChitieuCbs { get; set; }

    public virtual DbSet<ChitieuCbgiatri> ChitieuCbgiatris { get; set; }

    public virtual DbSet<ChitieuQdnhnn> ChitieuQdnhnns { get; set; }

    public virtual DbSet<ChitieuTdl> ChitieuTdls { get; set; }

    public virtual DbSet<CicMucdich> CicMucdiches { get; set; }

    public virtual DbSet<CicPl01> CicPl01s { get; set; }

    public virtual DbSet<CicPl02> CicPl02s { get; set; }

    public virtual DbSet<Cophan> Cophans { get; set; }

    public virtual DbSet<CtDmBieuPhi> CtDmBieuPhis { get; set; }

    public virtual DbSet<CtDmBieuPhiChiTiet> CtDmBieuPhiChiTiets { get; set; }

    public virtual DbSet<CtDmLoai> CtDmLoais { get; set; }

    public virtual DbSet<CtDmNganHang> CtDmNganHangs { get; set; }

    public virtual DbSet<CtDmTkHachToan> CtDmTkHachToans { get; set; }

    public virtual DbSet<CtGiaoDich> CtGiaoDiches { get; set; }

    public virtual DbSet<CtKhachHangLog> CtKhachHangLogs { get; set; }

    public virtual DbSet<Ctp> Ctps { get; set; }

    public virtual DbSet<DanhGiaTvChiTieu> DanhGiaTvChiTieus { get; set; }

    public virtual DbSet<DanhgiaThanhVien> DanhgiaThanhViens { get; set; }

    public virtual DbSet<DmChinhanh> DmChinhanhs { get; set; }

    public virtual DbSet<DmChucvu> DmChucvus { get; set; }

    public virtual DbSet<DmDvKyHan> DmDvKyHans { get; set; }

    public virtual DbSet<DmHinhThucTraLai> DmHinhThucTraLais { get; set; }

    public virtual DbSet<DmIndexChanged> DmIndexChangeds { get; set; }

    public virtual DbSet<DmKhuvuc> DmKhuvucs { get; set; }

    public virtual DbSet<DmLoaiChungTu> DmLoaiChungTus { get; set; }

    public virtual DbSet<DmLoaiGiaoDich> DmLoaiGiaoDiches { get; set; }

    public virtual DbSet<DmLoaiTscd> DmLoaiTscds { get; set; }

    public virtual DbSet<DmLoaiVay> DmLoaiVays { get; set; }

    public virtual DbSet<DmLoaisanpham> DmLoaisanphams { get; set; }

    public virtual DbSet<DmLoaithongke> DmLoaithongkes { get; set; }

    public virtual DbSet<DmMathongke> DmMathongkes { get; set; }

    public virtual DbSet<DmNgayNghi> DmNgayNghis { get; set; }

    public virtual DbSet<DmNgheNghiep> DmNgheNghieps { get; set; }

    public virtual DbSet<DmNguoiLq> DmNguoiLqs { get; set; }

    public virtual DbSet<DmNhomKhachHang> DmNhomKhachHangs { get; set; }

    public virtual DbSet<DmNhomThongKe> DmNhomThongKes { get; set; }

    public virtual DbSet<DmSanPham> DmSanPhams { get; set; }

    public virtual DbSet<DmSanPhamTd> DmSanPhamTds { get; set; }

    public virtual DbSet<DmTaiKhoan> DmTaiKhoans { get; set; }

    public virtual DbSet<DmTaiKhoanChiTiet> DmTaiKhoanChiTiets { get; set; }

    public virtual DbSet<DmTaiKhoanDbtk> DmTaiKhoanDbtks { get; set; }

    public virtual DbSet<DmTaiKhoanN> DmTaiKhoanNs { get; set; }

    public virtual DbSet<DmTienTe> DmTienTes { get; set; }

    public virtual DbSet<DmTyGium> DmTyGia { get; set; }

    public virtual DbSet<FindCandoiTaiKhoan> FindCandoiTaiKhoans { get; set; }

    public virtual DbSet<FindTaikhoanPhatsinh> FindTaikhoanPhatsinhs { get; set; }

    public virtual DbSet<FindTmpGiaoDich> FindTmpGiaoDiches { get; set; }

    public virtual DbSet<GiaoDich> GiaoDiches { get; set; }

    public virtual DbSet<ImagesStore> ImagesStores { get; set; }

    public virtual DbSet<InVoiceDangKySeri> InVoiceDangKySeris { get; set; }

    public virtual DbSet<InVoiceUser> InVoiceUsers { get; set; }

    public virtual DbSet<InvoiceCtthue> InvoiceCtthues { get; set; }

    public virtual DbSet<InvoiceCtthueBk> InvoiceCtthueBks { get; set; }

    public virtual DbSet<InvoiceDmThueSuat> InvoiceDmThueSuats { get; set; }

    public virtual DbSet<InvoiceInfor> InvoiceInfors { get; set; }

    public virtual DbSet<KeToanTaiKhoanSoDu> KeToanTaiKhoanSoDus { get; set; }

    public virtual DbSet<KeToanTaiKhoanSoDuThang> KeToanTaiKhoanSoDuThangs { get; set; }

    public virtual DbSet<KehoachThuchien> KehoachThuchiens { get; set; }

    public virtual DbSet<KetquaBieu02c> KetquaBieu02cs { get; set; }

    public virtual DbSet<KhMaTmp> KhMaTmps { get; set; }

    public virtual DbSet<KhachHang> KhachHangs { get; set; }

    public virtual DbSet<KhachHangChamDiemKh> KhachHangChamDiemKhs { get; set; }

    public virtual DbSet<KhachHangCoPhan> KhachHangCoPhans { get; set; }

    public virtual DbSet<KhachHangCoPhanCn> KhachHangCoPhanCns { get; set; }

    public virtual DbSet<KhachHangCoPhanTreo> KhachHangCoPhanTreos { get; set; }

    public virtual DbSet<KhachHangDmChamDiemKh> KhachHangDmChamDiemKhs { get; set; }

    public virtual DbSet<KhachHangDmChamDiemKhChiTiet> KhachHangDmChamDiemKhChiTiets { get; set; }

    public virtual DbSet<KhachHangDmChamDiemKhXepLoai> KhachHangDmChamDiemKhXepLoais { get; set; }

    public virtual DbSet<KhachHangNguoiLq> KhachHangNguoiLqs { get; set; }

    public virtual DbSet<KhachHangTinhLaiCp> KhachHangTinhLaiCps { get; set; }

    public virtual DbSet<KhachhangCpChoDuyet> KhachhangCpChoDuyets { get; set; }

    public virtual DbSet<KhachhangIdcard> KhachhangIdcards { get; set; }

    public virtual DbSet<KhachhangRegInforDevice> KhachhangRegInforDevices { get; set; }

    public virtual DbSet<KtoanChungTu> KtoanChungTus { get; set; }

    public virtual DbSet<ListClient> ListClients { get; set; }

    public virtual DbSet<ListHd> ListHds { get; set; }

    public virtual DbSet<ListKhTietkiem> ListKhTietkiems { get; set; }

    public virtual DbSet<NgayTemp> NgayTemps { get; set; }

    public virtual DbSet<Ngaylamviec> Ngaylamviecs { get; set; }

    public virtual DbSet<NgoaiteGiaodich> NgoaiteGiaodiches { get; set; }

    public virtual DbSet<NgoaiteSodu> NgoaiteSodus { get; set; }

    public virtual DbSet<NhanSuChamCongDetail> NhanSuChamCongDetails { get; set; }

    public virtual DbSet<NhanSuCtthue> NhanSuCtthues { get; set; }

    public virtual DbSet<NhanSuDmLuongThuongPc> NhanSuDmLuongThuongPcs { get; set; }

    public virtual DbSet<NhanSuDmthueTncn> NhanSuDmthueTncns { get; set; }

    public virtual DbSet<NhansuChamCong> NhansuChamCongs { get; set; }

    public virtual DbSet<NhansuDmLoai> NhansuDmLoais { get; set; }

    public virtual DbSet<NhansuDmtk> NhansuDmtks { get; set; }

    public virtual DbSet<NhansuLuongTt> NhansuLuongTts { get; set; }

    public virtual DbSet<NhansuTkHachtoan> NhansuTkHachtoans { get; set; }

    public virtual DbSet<NhomNo> NhomNos { get; set; }

    public virtual DbSet<NqGiaoDich> NqGiaoDiches { get; set; }

    public virtual DbSet<NqGiaoDichSum> NqGiaoDichSums { get; set; }

    public virtual DbSet<NqQuyTienMat> NqQuyTienMats { get; set; }

    public virtual DbSet<NqThongTinGd> NqThongTinGds { get; set; }

    public virtual DbSet<NsNghiepVuGd> NsNghiepVuGds { get; set; }

    public virtual DbSet<Ozekimessagein> Ozekimessageins { get; set; }

    public virtual DbSet<Ozekimessageout> Ozekimessageouts { get; set; }

    public virtual DbSet<Permission> Permissions { get; set; }

    public virtual DbSet<QtdChitietLichsuNhansu> QtdChitietLichsuNhansus { get; set; }

    public virtual DbSet<QtdNhanSuCtluong> QtdNhanSuCtluongs { get; set; }

    public virtual DbSet<QtdNhanSuLuong> QtdNhanSuLuongs { get; set; }

    public virtual DbSet<QtdNhanSuThuongPc> QtdNhanSuThuongPcs { get; set; }

    public virtual DbSet<QtdNhansu> QtdNhansus { get; set; }

    public virtual DbSet<QtdPhongban> QtdPhongbans { get; set; }

    public virtual DbSet<SktdExcel> SktdExcels { get; set; }

    public virtual DbSet<SktkExcel> SktkExcels { get; set; }

    public virtual DbSet<SmsKhachhangSend> SmsKhachhangSends { get; set; }

    public virtual DbSet<SmsTemp> SmsTemps { get; set; }

    public virtual DbSet<SmsZipCode> SmsZipCodes { get; set; }

    public virtual DbSet<Smsqueue> Smsqueues { get; set; }

    public virtual DbSet<SmsqueueBaoLaiTienVay> SmsqueueBaoLaiTienVays { get; set; }

    public virtual DbSet<Smssetting> Smssettings { get; set; }

    public virtual DbSet<SmstietKiem> SmstietKiems { get; set; }

    public virtual DbSet<Smstindung> Smstindungs { get; set; }

    public virtual DbSet<SmstrangThai> SmstrangThais { get; set; }

    public virtual DbSet<SpDmChucVu> SpDmChucVus { get; set; }

    public virtual DbSet<SpDmLoaiHoTro> SpDmLoaiHoTros { get; set; }

    public virtual DbSet<SpDmMucUuTien> SpDmMucUuTiens { get; set; }

    public virtual DbSet<SpDmStatusSupport> SpDmStatusSupports { get; set; }

    public virtual DbSet<SpInfoSupport> SpInfoSupports { get; set; }

    public virtual DbSet<SpRequestSupport> SpRequestSupports { get; set; }

    public virtual DbSet<StkDuchiPhatsinh> StkDuchiPhatsinhs { get; set; }

    public virtual DbSet<SysBackupRestore> SysBackupRestores { get; set; }

    public virtual DbSet<SysDatabaseYear> SysDatabaseYears { get; set; }

    public virtual DbSet<SysExpFilter> SysExpFilters { get; set; }

    public virtual DbSet<SysGiaoDichId> SysGiaoDichIds { get; set; }

    public virtual DbSet<SysGridConfig> SysGridConfigs { get; set; }

    public virtual DbSet<SysLastCodeId> SysLastCodeIds { get; set; }

    public virtual DbSet<SysLogError> SysLogErrors { get; set; }

    public virtual DbSet<SysLogModifyDatum> SysLogModifyData { get; set; }

    public virtual DbSet<SysLogXoaChungtu> SysLogXoaChungtus { get; set; }

    public virtual DbSet<SysMaxTkctTheoMa> SysMaxTkctTheoMas { get; set; }

    public virtual DbSet<SysMenu> SysMenus { get; set; }

    public virtual DbSet<SysOptionSystem> SysOptionSystems { get; set; }

    public virtual DbSet<SysOwnerBranch> SysOwnerBranches { get; set; }

    public virtual DbSet<SysReportConfig> SysReportConfigs { get; set; }

    public virtual DbSet<SysReportGroup> SysReportGroups { get; set; }

    public virtual DbSet<SysSoChungTuId> SysSoChungTuIds { get; set; }

    public virtual DbSet<SysSoTscdId> SysSoTscdIds { get; set; }

    public virtual DbSet<SysStackXoaChungtu> SysStackXoaChungtus { get; set; }

    public virtual DbSet<SysStackXoaHoadon> SysStackXoaHoadons { get; set; }

    public virtual DbSet<SysSubsystem> SysSubsystems { get; set; }

    public virtual DbSet<SysUser> SysUsers { get; set; }

    public virtual DbSet<SysUserRight> SysUserRights { get; set; }

    public virtual DbSet<SysUserlogApp> SysUserlogApps { get; set; }

    public virtual DbSet<SysUserlogMenu> SysUserlogMenus { get; set; }

    public virtual DbSet<SysVariable> SysVariables { get; set; }

    public virtual DbSet<SysVariableSupport> SysVariableSupports { get; set; }

    public virtual DbSet<TaikhoanCv7552> TaikhoanCv7552s { get; set; }

    public virtual DbSet<TaikhoanCv7552Chitiet> TaikhoanCv7552Chitiets { get; set; }

    public virtual DbSet<Tam01> Tam01s { get; set; }

    public virtual DbSet<TbTempGiaoDich> TbTempGiaoDiches { get; set; }

    public virtual DbSet<TbTempPhatSinh> TbTempPhatSinhs { get; set; }

    public virtual DbSet<TblCauhinhgrid> TblCauhinhgrids { get; set; }

    public virtual DbSet<TblNhatkythaydoidl> TblNhatkythaydoidls { get; set; }

    public virtual DbSet<TblTmpListAnchi> TblTmpListAnchis { get; set; }

    public virtual DbSet<TctdDanhMucTctd> TctdDanhMucTctds { get; set; }

    public virtual DbSet<TctdgGiaingan> TctdgGiaingans { get; set; }

    public virtual DbSet<TctdgGiaodich> TctdgGiaodiches { get; set; }

    public virtual DbSet<TctdgLaisuatsanpham> TctdgLaisuatsanphams { get; set; }

    public virtual DbSet<TctdgLaisuatstg> TctdgLaisuatstgs { get; set; }

    public virtual DbSet<TctdgLuukyhanmoi> TctdgLuukyhanmois { get; set; }

    public virtual DbSet<TctdgSanpham> TctdgSanphams { get; set; }

    public virtual DbSet<TctdgSotiengui> TctdgSotienguis { get; set; }

    public virtual DbSet<TctdgSotienguiEom> TctdgSotienguiEoms { get; set; }

    public virtual DbSet<TctdvDmHtVay> TctdvDmHtVays { get; set; }

    public virtual DbSet<TctdvDmSanPham> TctdvDmSanPhams { get; set; }

    public virtual DbSet<TctdvGiaiNgan> TctdvGiaiNgans { get; set; }

    public virtual DbSet<TctdvHopDong> TctdvHopDongs { get; set; }

    public virtual DbSet<TctdvKeHoachTraNo> TctdvKeHoachTraNos { get; set; }

    public virtual DbSet<TctdvLaiSuat> TctdvLaiSuats { get; set; }

    public virtual DbSet<TdungDinhgiaTaiSanTheChap> TdungDinhgiaTaiSanTheChaps { get; set; }

    public virtual DbSet<TdungDmHtTheChap> TdungDmHtTheChaps { get; set; }

    public virtual DbSet<TdungDmHtTheChap02> TdungDmHtTheChap02s { get; set; }

    public virtual DbSet<TdungDmHthucTraLai> TdungDmHthucTraLais { get; set; }

    public virtual DbSet<TdungDmLoaiTstc> TdungDmLoaiTstcs { get; set; }

    public virtual DbSet<TdungDmNhomNo> TdungDmNhomNos { get; set; }

    public virtual DbSet<TdungDmPthucVay> TdungDmPthucVays { get; set; }

    public virtual DbSet<TdungGiahanNo1phan> TdungGiahanNo1phans { get; set; }

    public virtual DbSet<TdungGiahanNoDetail> TdungGiahanNoDetails { get; set; }

    public virtual DbSet<TdungGiaiNgan> TdungGiaiNgans { get; set; }

    public virtual DbSet<TdungGiaiNganNoGocTt> TdungGiaiNganNoGocTts { get; set; }

    public virtual DbSet<TdungGiaiNganNoLaiNb> TdungGiaiNganNoLaiNbs { get; set; }

    public virtual DbSet<TdungGiaiNganUserTragop> TdungGiaiNganUserTragops { get; set; }

    public virtual DbSet<TdungHoSoTinDung> TdungHoSoTinDungs { get; set; }

    public virtual DbSet<TdungHstdEom> TdungHstdEoms { get; set; }

    public virtual DbSet<TdungKeHoachGiaiNgan> TdungKeHoachGiaiNgans { get; set; }

    public virtual DbSet<TdungKeHoachTraNo> TdungKeHoachTraNos { get; set; }

    public virtual DbSet<TdungLaiSuat> TdungLaiSuats { get; set; }

    public virtual DbSet<TdungLaiSuatDetail> TdungLaiSuatDetails { get; set; }

    public virtual DbSet<TdungLaiSuatSanPham> TdungLaiSuatSanPhams { get; set; }

    public virtual DbSet<TdungMucDichVay> TdungMucDichVays { get; set; }

    public virtual DbSet<TdungTaiSanGiuHo> TdungTaiSanGiuHos { get; set; }

    public virtual DbSet<TdungTaiSanTheChap> TdungTaiSanTheChaps { get; set; }

    public virtual DbSet<TdungTaisanthechapDetail> TdungTaisanthechapDetails { get; set; }

    public virtual DbSet<TdungTaisanthechapDetailMau> TdungTaisanthechapDetailMaus { get; set; }

    public virtual DbSet<TdungTmp> TdungTmps { get; set; }

    public virtual DbSet<TdungTstcStk> TdungTstcStks { get; set; }

    public virtual DbSet<TdungTstcTemp> TdungTstcTemps { get; set; }

    public virtual DbSet<TdungVtcOfHsid> TdungVtcOfHsids { get; set; }

    public virtual DbSet<TdungXulyNo> TdungXulyNos { get; set; }

    public virtual DbSet<TempCandoi> TempCandois { get; set; }

    public virtual DbSet<TempPtkntt> TempPtkntts { get; set; }

    public virtual DbSet<TempTongduno> TempTongdunos { get; set; }

    public virtual DbSet<TempTotalDebt> TempTotalDebts { get; set; }

    public virtual DbSet<TguiGiaingan> TguiGiaingans { get; set; }

    public virtual DbSet<TguiGiainganTmp> TguiGiainganTmps { get; set; }

    public virtual DbSet<TguiGiaodich> TguiGiaodiches { get; set; }

    public virtual DbSet<TguiLaisuatsanpham> TguiLaisuatsanphams { get; set; }

    public virtual DbSet<TguiLaisuatstg> TguiLaisuatstgs { get; set; }

    public virtual DbSet<TguiSanpham> TguiSanphams { get; set; }

    public virtual DbSet<TguiSotiengui> TguiSotienguis { get; set; }

    public virtual DbSet<ThanhVienChitietSerial> ThanhVienChitietSerials { get; set; }

    public virtual DbSet<TienluongTemp> TienluongTemps { get; set; }

    public virtual DbSet<TietkiemTemp> TietkiemTemps { get; set; }

    public virtual DbSet<TkeBcb03> TkeBcb03s { get; set; }

    public virtual DbSet<TkeBcchitieu> TkeBcchitieus { get; set; }

    public virtual DbSet<TkeBccongthuc> TkeBccongthucs { get; set; }

    public virtual DbSet<TkeChitieu> TkeChitieus { get; set; }

    public virtual DbSet<TkeCtcongthuc> TkeCtcongthucs { get; set; }

    public virtual DbSet<TkeCtgoc> TkeCtgocs { get; set; }

    public virtual DbSet<TkeDmbaocao> TkeDmbaocaos { get; set; }

    public virtual DbSet<TkeGiatrichitieu> TkeGiatrichitieus { get; set; }

    public virtual DbSet<TkiemBhtg2252Chitieu> TkiemBhtg2252Chitieus { get; set; }

    public virtual DbSet<TkiemBhtgMaubc> TkiemBhtgMaubcs { get; set; }

    public virtual DbSet<TkiemChuyentienGiaodich> TkiemChuyentienGiaodiches { get; set; }

    public virtual DbSet<TkiemGiaingan> TkiemGiaingans { get; set; }

    public virtual DbSet<TkiemGiainganKkh> TkiemGiainganKkhs { get; set; }

    public virtual DbSet<TkiemGiaodich> TkiemGiaodiches { get; set; }

    public virtual DbSet<TkiemGiaodichKkh> TkiemGiaodichKkhs { get; set; }

    public virtual DbSet<TkiemGiaodichLng> TkiemGiaodichLngs { get; set; }

    public virtual DbSet<TkiemHinhthuctralai> TkiemHinhthuctralais { get; set; }

    public virtual DbSet<TkiemLaisuat> TkiemLaisuats { get; set; }

    public virtual DbSet<TkiemLaisuatstk> TkiemLaisuatstks { get; set; }

    public virtual DbSet<TkiemLoaisp> TkiemLoaisps { get; set; }

    public virtual DbSet<TkiemLuukyhanTattoan> TkiemLuukyhanTattoans { get; set; }

    public virtual DbSet<TkiemLuukyhanmoi> TkiemLuukyhanmois { get; set; }

    public virtual DbSet<TkiemPhichuyentien> TkiemPhichuyentiens { get; set; }

    public virtual DbSet<TkiemPhichuyentienKhoangtien> TkiemPhichuyentienKhoangtiens { get; set; }

    public virtual DbSet<TkiemSanpham> TkiemSanphams { get; set; }

    public virtual DbSet<TkiemSoTietKiemRep> TkiemSoTietKiemReps { get; set; }

    public virtual DbSet<TkiemSotietkiem> TkiemSotietkiems { get; set; }

    public virtual DbSet<TkiemStkEom> TkiemStkEoms { get; set; }

    public virtual DbSet<TkiemTaikhoanchuyentien> TkiemTaikhoanchuyentiens { get; set; }

    public virtual DbSet<Tmp> Tmps { get; set; }

    public virtual DbSet<TmpAnChi> TmpAnChis { get; set; }

    public virtual DbSet<TmpChitieuGiatriSldb> TmpChitieuGiatriSldbs { get; set; }

    public virtual DbSet<TmpChitieuGiatriTlnv> TmpChitieuGiatriTlnvs { get; set; }

    public virtual DbSet<TmpChitieuhoatdong> TmpChitieuhoatdongs { get; set; }

    public virtual DbSet<TmpHd> TmpHds { get; set; }

    public virtual DbSet<TmpHoSoDuThuKetQua> TmpHoSoDuThuKetQuas { get; set; }

    public virtual DbSet<TmpHoSoDuThuTheoHdtd> TmpHoSoDuThuTheoHdtds { get; set; }

    public virtual DbSet<TmpHosoTd> TmpHosoTds { get; set; }

    public virtual DbSet<TmpHosoTd127> TmpHosoTd127s { get; set; }

    public virtual DbSet<TmpHosoTdGiaoDich> TmpHosoTdGiaoDiches { get; set; }

    public virtual DbSet<TmpKhachHangTv> TmpKhachHangTvs { get; set; }

    public virtual DbSet<TmpTaikhoanSodu> TmpTaikhoanSodus { get; set; }

    public virtual DbSet<TmpTietKiem> TmpTietKiems { get; set; }

    public virtual DbSet<Tongduno> Tongdunos { get; set; }

    public virtual DbSet<TscdDanhSach> TscdDanhSaches { get; set; }

    public virtual DbSet<TscdDanhSachDc> TscdDanhSachDcs { get; set; }

    public virtual DbSet<TscdDmNhom> TscdDmNhoms { get; set; }

    public virtual DbSet<TscdGiaoDich> TscdGiaoDiches { get; set; }

    public virtual DbSet<TstcTmp111> TstcTmp111s { get; set; }

    public virtual DbSet<Tt04Template> Tt04Templates { get; set; }

    public virtual DbSet<Tt11BieuC00314Lai> Tt11BieuC00314Lais { get; set; }

    public virtual DbSet<Tt11DanhSachBaoCao> Tt11DanhSachBaoCaos { get; set; }

    public virtual DbSet<Tt11DunoKinhte> Tt11DunoKinhtes { get; set; }

    public virtual DbSet<Tt11MauExcel> Tt11MauExcels { get; set; }

    public virtual DbSet<Tt21ChiTieu> Tt21ChiTieus { get; set; }

    public virtual DbSet<Tt21KiemKeTien> Tt21KiemKeTiens { get; set; }

    public virtual DbSet<Tt21LoaiTien> Tt21LoaiTiens { get; set; }

    public virtual DbSet<Tt21LuyKeThanhVienSl> Tt21LuyKeThanhVienSls { get; set; }

    public virtual DbSet<Tt21MauExcel> Tt21MauExcels { get; set; }

    public virtual DbSet<Tt21TempCp> Tt21TempCps { get; set; }

    public virtual DbSet<Tt21Template> Tt21Templates { get; set; }

    public virtual DbSet<Tt21TienGium> Tt21TienGia { get; set; }

    public virtual DbSet<Tt21TienGuiTt> Tt21TienGuiTts { get; set; }

    public virtual DbSet<Tt21TietKiem> Tt21TietKiems { get; set; }

    public virtual DbSet<Tt21TinDung> Tt21TinDungs { get; set; }

    public virtual DbSet<Tt31ChiTieu> Tt31ChiTieus { get; set; }

    public virtual DbSet<Tt31DanhSachBaoCao> Tt31DanhSachBaoCaos { get; set; }

    public virtual DbSet<Tt31Template> Tt31Templates { get; set; }

    public virtual DbSet<Tt35CanDoiTkChiTieu> Tt35CanDoiTkChiTieus { get; set; }

    public virtual DbSet<Tt35CanDoiTkChiTieu1112> Tt35CanDoiTkChiTieu1112s { get; set; }

    public virtual DbSet<Tt35CanDoiTkChiTieu5870> Tt35CanDoiTkChiTieu5870s { get; set; }

    public virtual DbSet<Tt35DanhSachBaoCao> Tt35DanhSachBaoCaos { get; set; }

    public virtual DbSet<Tt35MauExcel> Tt35MauExcels { get; set; }

    public virtual DbSet<Tt35NganquyTcnv> Tt35NganquyTcnvs { get; set; }

    public virtual DbSet<Tt35NguoiDung> Tt35NguoiDungs { get; set; }

    public virtual DbSet<Tt35RrlsChitieu> Tt35RrlsChitieus { get; set; }

    public virtual DbSet<Tt35RrtkChitieu> Tt35RrtkChitieus { get; set; }

    public virtual DbSet<Tt35TindungMucdichvayCongthuc> Tt35TindungMucdichvayCongthucs { get; set; }

    public virtual DbSet<Tt35TkeBccongthuc> Tt35TkeBccongthucs { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UsersPermission> UsersPermissions { get; set; }

    public virtual DbSet<VTdung477> VTdung477s { get; set; }

    public virtual DbSet<VTkiem477> VTkiem477s { get; set; }

    public virtual DbSet<Vb1112Tstc> Vb1112Tstcs { get; set; }

    public virtual DbSet<Vb2947DanhSachBaoCao> Vb2947DanhSachBaoCaos { get; set; }

    public virtual DbSet<Vb2947MauExcel> Vb2947MauExcels { get; set; }

    public virtual DbSet<Vb2947Tietkiem> Vb2947Tietkiems { get; set; }

    public virtual DbSet<Vb2947Tindung> Vb2947Tindungs { get; set; }

    public virtual DbSet<Vb2947Tstc> Vb2947Tstcs { get; set; }

    public virtual DbSet<VwDmSanPhamTd> VwDmSanPhamTds { get; set; }

    public virtual DbSet<VwGiaoDich> VwGiaoDiches { get; set; }

    public virtual DbSet<VwHstdUpdateMaThongKe> VwHstdUpdateMaThongKes { get; set; }

    public virtual DbSet<VwKeToanSoDuTaiKhoan> VwKeToanSoDuTaiKhoans { get; set; }

    public virtual DbSet<VwKhachHang> VwKhachHangs { get; set; }

    public virtual DbSet<VwKhachHangCoPhan> VwKhachHangCoPhans { get; set; }

    public virtual DbSet<VwKtoanChungTu> VwKtoanChungTus { get; set; }

    public virtual DbSet<VwSoTietKiem> VwSoTietKiems { get; set; }

    public virtual DbSet<VwTdungGiaiNgan> VwTdungGiaiNgans { get; set; }

    public virtual DbSet<VwTdungHoSoTinDung> VwTdungHoSoTinDungs { get; set; }

    public virtual DbSet<VwTdungHstdSoDuByDate> VwTdungHstdSoDuByDates { get; set; }

    public virtual DbSet<VwTdungTaiSanTheChap> VwTdungTaiSanTheChaps { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=HUONG-ITDVAPCF;Database=itd_vapcf;Trusted_Connection=True;MultipleActiveResultSets=True; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CcAnchiGtcg>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Cc_Anchi_GTCG");

            entity.Property(e => e.AnchiTrangthai).HasColumnName("Anchi_Trangthai");
            entity.Property(e => e.ChinhanhMa)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("Chinhanh_ma");
            entity.Property(e => e.DanhSach)
                .HasMaxLength(50)
                .HasColumnName("Danh_Sach");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.KhachHangMa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KhachHang_Ma");
            entity.Property(e => e.Ma)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Ngay).HasColumnType("datetime");
            entity.Property(e => e.NgayXuatKho).HasColumnType("datetime");
            entity.Property(e => e.NgayXuatQuy).HasColumnType("datetime");
            entity.Property(e => e.SerialId)
                .HasMaxLength(50)
                .HasColumnName("Serial_Id");
        });

        modelBuilder.Entity<CcDanhmuc>(entity =>
        {
            entity.HasKey(e => e.Ma);

            entity.ToTable("Cc_Danhmuc");

            entity.Property(e => e.Ma)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ghichu)
                .HasMaxLength(150)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Ten).HasMaxLength(150);
            entity.Property(e => e.Tentat)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Tk1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TK1");
            entity.Property(e => e.Tk2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TK2");
        });

        modelBuilder.Entity<CcNhapXuat>(entity =>
        {
            entity.HasKey(e => e.NxId);

            entity.ToTable("Cc_NhapXuat");

            entity.Property(e => e.NxId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nx_ID");
            entity.Property(e => e.ChinhanhId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Chinhanh_ID");
            entity.Property(e => e.ChucVu)
                .HasMaxLength(400)
                .HasColumnName("Chuc_vu");
            entity.Property(e => e.ChucVu1)
                .HasMaxLength(400)
                .HasColumnName("Chuc_vu1");
            entity.Property(e => e.CmtNgay)
                .HasColumnType("datetime")
                .HasColumnName("cmt_ngay");
            entity.Property(e => e.CmtNgay1)
                .HasColumnType("datetime")
                .HasColumnName("cmt_ngay1");
            entity.Property(e => e.CmtNoiCap)
                .HasMaxLength(200)
                .HasColumnName("cmt_noi_cap");
            entity.Property(e => e.CmtNoiCap1)
                .HasMaxLength(400)
                .HasColumnName("cmt_noi_cap1");
            entity.Property(e => e.CmtSerial)
                .HasMaxLength(100)
                .HasColumnName("cmt_serial");
            entity.Property(e => e.CmtSerial1)
                .HasMaxLength(100)
                .HasColumnName("cmt_serial1");
            entity.Property(e => e.HoTen)
                .HasMaxLength(200)
                .HasColumnName("ho_ten");
            entity.Property(e => e.HoTen1)
                .HasMaxLength(200)
                .HasColumnName("ho_ten1");
            entity.Property(e => e.MaChungchi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Ma_Chungchi");
            entity.Property(e => e.Ngay).HasColumnType("datetime");
            entity.Property(e => e.SoChungTu)
                .HasMaxLength(50)
                .HasColumnName("So_chung_tu");
            entity.Property(e => e.TienTo)
                .HasMaxLength(50)
                .HasColumnName("tien_To");
            entity.Property(e => e.ToiSerial)
                .HasMaxLength(50)
                .HasColumnName("Toi_serial");
            entity.Property(e => e.TuSerial)
                .HasMaxLength(50)
                .HasColumnName("Tu_serial");

            entity.HasOne(d => d.MaChungchiNavigation).WithMany(p => p.CcNhapXuats)
                .HasForeignKey(d => d.MaChungchi)
                .HasConstraintName("FK_Cc_NhapXuat_Cc_Danhmuc");
        });

        modelBuilder.Entity<CcNhapXuatDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Cc_NhapXuat_Detail");

            entity.Property(e => e.Loai)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.NgayBaoCao)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.SoluongCuoi).HasMaxLength(200);
            entity.Property(e => e.SoluongDau).HasMaxLength(200);
            entity.Property(e => e.SoluongNhap).HasMaxLength(200);
            entity.Property(e => e.SoluongPh).HasMaxLength(200);
            entity.Property(e => e.SoluongXuat).HasMaxLength(200);
            entity.Property(e => e.Status).HasColumnName("STATUS");
        });

        modelBuilder.Entity<CdAnhxatk>(entity =>
        {
            entity.HasKey(e => new { e.MathCu, e.MatkMoi });

            entity.ToTable("CD_anhxatk");

            entity.Property(e => e.MathCu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("math_cu");
            entity.Property(e => e.MatkMoi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("matk_moi");
            entity.Property(e => e.Loai).HasColumnName("loai");
        });

        modelBuilder.Entity<CdSoducu>(entity =>
        {
            entity.HasKey(e => e.Matk);

            entity.ToTable("CD_soducu");

            entity.Property(e => e.Matk)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("matk");
            entity.Property(e => e.Psco).HasColumnName("psco");
            entity.Property(e => e.Psno).HasColumnName("psno");
            entity.Property(e => e.Soducuoi).HasColumnName("soducuoi");
            entity.Property(e => e.Sodudau).HasColumnName("sodudau");
            entity.Property(e => e.Tinhchat).HasColumnName("tinhchat");
        });

        modelBuilder.Entity<CdSodumoi>(entity =>
        {
            entity.HasKey(e => new { e.Matk, e.MatkCu });

            entity.ToTable("CD_sodumoi");

            entity.Property(e => e.Matk)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("matk");
            entity.Property(e => e.MatkCu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("matk_cu");
            entity.Property(e => e.Id)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("ID");
            entity.Property(e => e.Psco).HasColumnName("psco");
            entity.Property(e => e.Psno).HasColumnName("psno");
            entity.Property(e => e.Soducuoi).HasColumnName("soducuoi");
            entity.Property(e => e.Sodudau).HasColumnName("sodudau");
            entity.Property(e => e.Tinhchat).HasColumnName("tinhchat");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("type");
        });

        modelBuilder.Entity<CdTaikhoanChitiet>(entity =>
        {
            entity.HasKey(e => e.MaCtMoi);

            entity.ToTable("CD_Taikhoan_chitiet");

            entity.Property(e => e.MaCtMoi)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ma_ct_moi");
            entity.Property(e => e.MaCtCu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ma_ct_cu");
            entity.Property(e => e.MaThCu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ma_th_cu");
            entity.Property(e => e.MaThMoi)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ma_th_moi");
            entity.Property(e => e.ManvMoi)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("manv_moi");
        });

        modelBuilder.Entity<ChitieuCb>(entity =>
        {
            entity.ToTable("CHITIEU_CB");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Chitieu)
                .HasMaxLength(300)
                .HasColumnName("CHITIEU");
            entity.Property(e => e.Congthuc)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("CONGTHUC");
            entity.Property(e => e.Giatri).HasColumnName("GIATRI");
            entity.Property(e => e.Nhatsolieu)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("NHATSOLIEU");
            entity.Property(e => e.Tenbieu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TENBIEU");
        });

        modelBuilder.Entity<ChitieuCbgiatri>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CHITIEU_CBGIATRI");

            entity.Property(e => e.Chitieu)
                .HasMaxLength(300)
                .HasColumnName("CHITIEU");
            entity.Property(e => e.Giatri).HasColumnName("GIATRI");
        });

        modelBuilder.Entity<ChitieuQdnhnn>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CHITIEU_QDNHNN");

            entity.Property(e => e.Chitieu).HasMaxLength(300);
            entity.Property(e => e.Mau)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("mau");
            entity.Property(e => e.Xeploai)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<ChitieuTdl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CHITIEU_TDLS");

            entity.Property(e => e.Congthuc)
                .HasMaxLength(300)
                .HasDefaultValueSql("('')")
                .IsFixedLength()
                .HasColumnName("CONGTHUC");
            entity.Property(e => e.Loai)
                .HasDefaultValueSql("((0))")
                .HasColumnName("LOAI");
            entity.Property(e => e.Thdau)
                .HasDefaultValueSql("((0))")
                .HasColumnName("THDAU");
            entity.Property(e => e.Thoihan)
                .HasMaxLength(100)
                .HasColumnName("THOIHAN");
            entity.Property(e => e.Thsau)
                .HasDefaultValueSql("((0))")
                .HasColumnName("THSAU");
        });

        modelBuilder.Entity<CicMucdich>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CIC_MUCDICH");

            entity.Property(e => e.Macic)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MACIC");
            entity.Property(e => e.Matt21)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("MATT21");
            entity.Property(e => e.Ten).HasMaxLength(500);
        });

        modelBuilder.Entity<CicPl01>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CIC_PL01");

            entity.Property(e => e.Cmnd)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasColumnName("CMND");
            entity.Property(e => e.DiaChi)
                .HasMaxLength(255)
                .HasDefaultValueSql("('')")
                .HasColumnName("DIA_CHI");
            entity.Property(e => e.DuNo)
                .HasDefaultValueSql("('')")
                .HasColumnName("DU_NO");
            entity.Property(e => e.GioiTinh)
                .HasDefaultValueSql("((0))")
                .HasColumnName("GIOI_TINH");
            entity.Property(e => e.HdHanmuc)
                .HasDefaultValueSql("((0))")
                .HasColumnName("HD_HANMUC");
            entity.Property(e => e.HdNgayDh)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("HD_NGAY_DH");
            entity.Property(e => e.HdNgayKy)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("HD_NGAY_KY");
            entity.Property(e => e.HdSo)
                .HasMaxLength(30)
                .HasDefaultValueSql("('')")
                .HasColumnName("HD_SO");
            entity.Property(e => e.HoTen)
                .HasMaxLength(255)
                .HasDefaultValueSql("('')")
                .HasColumnName("HO_TEN");
            entity.Property(e => e.KhachhangId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("khachhang_id");
            entity.Property(e => e.KuNgayDh)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("KU_NGAY_DH");
            entity.Property(e => e.KuNgayKy)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("KU_NGAY_KY");
            entity.Property(e => e.KuNgayPs)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("KU_NGAY_PS");
            entity.Property(e => e.KuSo)
                .HasMaxLength(30)
                .HasDefaultValueSql("('')")
                .HasColumnName("KU_SO");
            entity.Property(e => e.LaiSuat)
                .HasDefaultValueSql("((0))")
                .HasColumnName("LAI_SUAT");
            entity.Property(e => e.LoaiKh)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LOAI_KH");
            entity.Property(e => e.LoaiVay)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LOAI_VAY");
            entity.Property(e => e.MaDv)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("MA_DV");
            entity.Property(e => e.MaSoThue)
                .HasMaxLength(30)
                .HasDefaultValueSql("('')")
                .HasColumnName("MA_SO_THUE");
            entity.Property(e => e.MaTv)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasColumnName("Ma_TV");
            entity.Property(e => e.MucDich)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("MUC_DICH");
            entity.Property(e => e.NgayCap)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("NGAY_CAP");
            entity.Property(e => e.NgaySinh)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("NGAY_SINH");
            entity.Property(e => e.NhomNo)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("NHOM_NO");
        });

        modelBuilder.Entity<CicPl02>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CIC_PL02");

            entity.Property(e => e.Cmnd)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CMND");
            entity.Property(e => e.Hoten)
                .HasMaxLength(255)
                .HasDefaultValueSql("('')")
                .HasColumnName("HOTEN");
            entity.Property(e => e.KhMa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("KH_MA");
            entity.Property(e => e.MaTv)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("MA_TV");
            entity.Property(e => e.Madv)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("MADV");
            entity.Property(e => e.Mst)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("MST");
            entity.Property(e => e.NgayDg)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("NGAY_DG");
            entity.Property(e => e.TsGiatri)
                .HasDefaultValueSql("((0))")
                .HasColumnName("TS_GIATRI");
            entity.Property(e => e.TsLoai)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TS_LOAI");
            entity.Property(e => e.TsMa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TS_MA");
            entity.Property(e => e.TsMota)
                .HasMaxLength(1000)
                .HasDefaultValueSql("('')")
                .HasColumnName("TS_MOTA");
        });

        modelBuilder.Entity<Cophan>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Cophan");

            entity.Property(e => e.Cptn)
                .HasColumnType("money")
                .HasColumnName("CPTN");
            entity.Property(e => e.Cptx)
                .HasColumnType("money")
                .HasColumnName("CPTX");
            entity.Property(e => e.Cpxl)
                .HasColumnType("money")
                .HasColumnName("CPXL");
            entity.Property(e => e.Matv).HasColumnName("MATV");
        });

        modelBuilder.Entity<CtDmBieuPhi>(entity =>
        {
            entity.HasKey(e => new { e.Uid, e.Ma });

            entity.ToTable("CT_DM_BieuPhi");

            entity.Property(e => e.Uid)
                .ValueGeneratedOnAdd()
                .HasColumnName("UID");
            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DateCreate)
                .HasColumnType("datetime")
                .HasColumnName("Date_Create");
            entity.Property(e => e.DateModify)
                .HasColumnType("datetime")
                .HasColumnName("Date_Modify");
            entity.Property(e => e.GhiChu).HasMaxLength(255);
            entity.Property(e => e.LoaiBieuPhi)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Ten).HasMaxLength(255);
            entity.Property(e => e.ThueVat).HasColumnName("ThueVAT");
            entity.Property(e => e.TienTeMa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TienTe_Ma");
            entity.Property(e => e.UserCreate)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("User_Create");
            entity.Property(e => e.UserModify)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("User_Modify");
        });

        modelBuilder.Entity<CtDmBieuPhiChiTiet>(entity =>
        {
            entity.HasKey(e => e.Uid);

            entity.ToTable("CT_DM_BieuPhi_ChiTiet");

            entity.Property(e => e.Uid).HasColumnName("UID");
            entity.Property(e => e.CtDmBieuPhiUid).HasColumnName("CT_DM_BieuPhi_UID");
            entity.Property(e => e.DateCreate)
                .HasColumnType("datetime")
                .HasColumnName("Date_Create");
            entity.Property(e => e.DateModify)
                .HasColumnType("datetime")
                .HasColumnName("Date_Modify");
            entity.Property(e => e.Ngay).HasColumnType("datetime");
            entity.Property(e => e.UserCreate)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("User_Create");
            entity.Property(e => e.UserModify)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("User_Modify");
        });

        modelBuilder.Entity<CtDmLoai>(entity =>
        {
            entity.HasKey(e => e.Uid);

            entity.ToTable("CT_DM_Loai");

            entity.Property(e => e.Uid).HasColumnName("UID");
            entity.Property(e => e.CtHinhThuc)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CT_HinhThuc");
            entity.Property(e => e.DateCreate)
                .HasColumnType("datetime")
                .HasColumnName("Date_Create");
            entity.Property(e => e.DateModify)
                .HasColumnType("datetime")
                .HasColumnName("Date_Modify");
            entity.Property(e => e.Loai)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Ten).HasMaxLength(255);
            entity.Property(e => e.UserCreate)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("User_Create");
            entity.Property(e => e.UserModify)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("User_Modify");
        });

        modelBuilder.Entity<CtDmNganHang>(entity =>
        {
            entity.HasKey(e => e.Ma);

            entity.ToTable("CT_DM_NganHang");

            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CapDonVi).HasMaxLength(255);
            entity.Property(e => e.DateCreate)
                .HasColumnType("datetime")
                .HasColumnName("Date_Create");
            entity.Property(e => e.DateModify)
                .HasColumnType("datetime")
                .HasColumnName("Date_Modify");
            entity.Property(e => e.DiaChi).HasMaxLength(255);
            entity.Property(e => e.Sdt)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SDT");
            entity.Property(e => e.TenDonVi).HasMaxLength(255);
            entity.Property(e => e.TenGiaoDich).HasMaxLength(255);
            entity.Property(e => e.TkHachToan)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TK_HachToan");
            entity.Property(e => e.UserCreate)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("User_Create");
            entity.Property(e => e.UserModify)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("User_Modify");
        });

        modelBuilder.Entity<CtDmTkHachToan>(entity =>
        {
            entity.HasKey(e => e.Uid);

            entity.ToTable("CT_DM_TK_HachToan");

            entity.Property(e => e.Uid).HasColumnName("UID");
            entity.Property(e => e.CtDmBieuPhiUid).HasColumnName("CT_DM_BieuPhi_UID");
            entity.Property(e => e.DateCreate)
                .HasColumnType("datetime")
                .HasColumnName("Date_Create");
            entity.Property(e => e.DateModify)
                .HasColumnType("datetime")
                .HasColumnName("Date_Modify");
            entity.Property(e => e.Label).HasMaxLength(255);
            entity.Property(e => e.TaiKhoanMa)
                .HasMaxLength(20)
                .HasColumnName("TaiKhoan_Ma");
            entity.Property(e => e.TaiKhoanTenHienThi)
                .HasMaxLength(255)
                .HasColumnName("TaiKhoan_TenHienThi");
            entity.Property(e => e.UserCreate)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("User_Create");
            entity.Property(e => e.UserModify)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("User_Modify");
        });

        modelBuilder.Entity<CtGiaoDich>(entity =>
        {
            entity.HasKey(e => e.Uid);

            entity.ToTable("CT_GiaoDich");

            entity.Property(e => e.Uid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UID");
            entity.Property(e => e.CtChuyenKhoanId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CT_ChuyenKhoanID");
            entity.Property(e => e.CtDmBieuPhiUid).HasColumnName("CT_DM_BieuPhi_UID");
            entity.Property(e => e.CtGiaoDichId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CT_GiaoDichID");
            entity.Property(e => e.CtHinhThuc)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CT_HinhThuc");
            entity.Property(e => e.CtLenh)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CT_Lenh");
            entity.Property(e => e.CtNoiDung)
                .HasMaxLength(500)
                .HasColumnName("CT_NoiDung");
            entity.Property(e => e.CtTienTe)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CT_TienTe");
            entity.Property(e => e.CtTrangThai).HasColumnName("CT_TrangThai");
            entity.Property(e => e.DateCreate)
                .HasColumnType("datetime")
                .HasColumnName("Date_Create");
            entity.Property(e => e.DateModify)
                .HasColumnType("datetime")
                .HasColumnName("Date_Modify");
            entity.Property(e => e.ExDauMoiMa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("EX_DauMoi_Ma");
            entity.Property(e => e.ExDauMoiTen)
                .HasMaxLength(255)
                .HasColumnName("EX_DauMoi_Ten");
            entity.Property(e => e.ExKhid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("EX_KHID");
            entity.Property(e => e.ExTkNganHang)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("EX_TK_NganHang");
            entity.Property(e => e.FePhiThuId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FE_PhiThu_ID");
            entity.Property(e => e.FeVatId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FE_VAT_ID");
            entity.Property(e => e.InDauMoiMa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN_DauMoi_Ma");
            entity.Property(e => e.InDauMoiTen)
                .HasMaxLength(255)
                .HasColumnName("IN_DauMoi_Ten");
            entity.Property(e => e.InKhid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN_KHID");
            entity.Property(e => e.InTkNganHang)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN_TK_NganHang");
            entity.Property(e => e.InTkThanhToan)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN_TK_ThanhToan");
            entity.Property(e => e.LoaiChungTu)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.LoaiGiaoDich)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Ngay).HasColumnType("datetime");
            entity.Property(e => e.SoBt)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SoBT");
            entity.Property(e => e.UserCreate)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("User_Create");
            entity.Property(e => e.UserModify)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("User_Modify");
        });

        modelBuilder.Entity<CtKhachHangLog>(entity =>
        {
            entity.HasKey(e => e.Uid);

            entity.ToTable("CT_KhachHang_Log");

            entity.Property(e => e.Uid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UID");
            entity.Property(e => e.CmtNgayCap)
                .HasColumnType("datetime")
                .HasColumnName("CMT_NgayCap");
            entity.Property(e => e.CmtNoiCap)
                .HasMaxLength(255)
                .HasColumnName("CMT_NoiCap");
            entity.Property(e => e.CmtSerial)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CMT_Serial");
            entity.Property(e => e.DateCreate)
                .HasColumnType("datetime")
                .HasColumnName("Date_Create");
            entity.Property(e => e.DateModify)
                .HasColumnType("datetime")
                .HasColumnName("Date_Modify");
            entity.Property(e => e.DiaChi).HasMaxLength(255);
            entity.Property(e => e.KhachHangId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KhachHangID");
            entity.Property(e => e.NganHangMa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NganHang_Ma");
            entity.Property(e => e.NganHangTk)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NganHang_TK");
            entity.Property(e => e.Sdt)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SDT");
            entity.Property(e => e.Ten).HasMaxLength(255);
            entity.Property(e => e.UserCreate)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("User_Create");
            entity.Property(e => e.UserModify)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("User_Modify");
        });

        modelBuilder.Entity<Ctp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CTPS");

            entity.Property(e => e.ChinhanhId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("chinhanh_id");
            entity.Property(e => e.Ngay)
                .HasColumnType("datetime")
                .HasColumnName("ngay");
            entity.Property(e => e.Noidung)
                .HasMaxLength(250)
                .HasColumnName("noidung");
            entity.Property(e => e.Psco).HasColumnName("psco");
            entity.Property(e => e.Psno).HasColumnName("psno");
            entity.Property(e => e.Soct)
                .HasMaxLength(20)
                .HasColumnName("soct");
            entity.Property(e => e.Sogd)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("sogd");
            entity.Property(e => e.Sotk)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("sotk");
            entity.Property(e => e.Tentk)
                .HasMaxLength(250)
                .HasColumnName("tentk");
            entity.Property(e => e.Tkgiaodich)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("tkgiaodich");
        });

        modelBuilder.Entity<DanhGiaTvChiTieu>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DanhGia_TV_ChiTieu");

            entity.Property(e => e.Ma)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DanhgiaThanhVien>(entity =>
        {
            entity.HasKey(e => e.Ngay).HasName("PK__Danhgia_ThanhVie__13E2A44E");

            entity.ToTable("Danhgia_ThanhVien");

            entity.Property(e => e.Ngay).HasColumnType("datetime");
            entity.Property(e => e.DConLai).HasColumnName("D_ConLai");
            entity.Property(e => e.DGiaTriBds).HasColumnName("D_GiaTriBDS");
            entity.Property(e => e.DHinhThucTs).HasColumnName("D_HinhThucTS");
            entity.Property(e => e.DHocVan).HasColumnName("D_HocVan");
            entity.Property(e => e.DHonNhan).HasColumnName("D_HonNhan");
            entity.Property(e => e.DLaoDong).HasColumnName("D_LaoDong");
            entity.Property(e => e.DNgheNghiep).HasColumnName("D_NgheNghiep");
            entity.Property(e => e.DNguoiThan).HasColumnName("D_NguoiThan");
            entity.Property(e => e.DNoXau).HasColumnName("D_NoXau");
            entity.Property(e => e.DNoiOhienNay).HasColumnName("D_NoiOHienNay");
            entity.Property(e => e.DQuanHe).HasColumnName("D_QuanHe");
            entity.Property(e => e.DRuiRo).HasColumnName("D_RuiRo");
            entity.Property(e => e.DSoLanChamTraLai).HasColumnName("D_SoLanChamTraLai");
            entity.Property(e => e.DSoLanCoCauNo).HasColumnName("D_SoLanCoCauNo");
            entity.Property(e => e.DSoLanTraCham).HasColumnName("D_SoLanTraCham");
            entity.Property(e => e.DSoNgayQuaHan).HasColumnName("D_SoNgayQuaHan");
            entity.Property(e => e.DThoiGianLam).HasColumnName("D_ThoiGianLam");
            entity.Property(e => e.DThuNhapGiaDinh).HasColumnName("D_ThuNhapGiaDinh");
            entity.Property(e => e.DThuNhapNguoiVay).HasColumnName("D_ThuNhapNguoiVay");
            entity.Property(e => e.DTienAn).HasColumnName("D_TienAn");
            entity.Property(e => e.DTongCong).HasColumnName("D_TongCong");
            entity.Property(e => e.DTongNghe).HasColumnName("D_TongNghe");
            entity.Property(e => e.DTongSoLuoc).HasColumnName("D_TongSoLuoc");
            entity.Property(e => e.DTongTaiSan).HasColumnName("D_TongTaiSan");
            entity.Property(e => e.DTongTd).HasColumnName("D_TongTD");
            entity.Property(e => e.DTongThuChi).HasColumnName("D_TongThuChi");
            entity.Property(e => e.DTscoGia).HasColumnName("D_TSCoGia");
            entity.Property(e => e.DTuoi).HasColumnName("D_Tuoi");
            entity.Property(e => e.DVayTctdkhac).HasColumnName("D_VayTCTDKhac");
            entity.Property(e => e.DYthuc).HasColumnName("D_YThuc");
            entity.Property(e => e.MaTv)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MaTV");
            entity.Property(e => e.XepLoai).HasMaxLength(20);
        });

        modelBuilder.Entity<DmChinhanh>(entity =>
        {
            entity.HasKey(e => e.Ma);

            entity.ToTable("DM_CHINHANH");

            entity.Property(e => e.Ma)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.DiaChi)
                .HasMaxLength(255)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Dia_chi");
            entity.Property(e => e.DiaChiBaoCao).HasMaxLength(100);
            entity.Property(e => e.DiaChiTat)
                .HasMaxLength(100)
                .HasColumnName("Dia_Chi_Tat");
            entity.Property(e => e.DienThoai)
                .HasMaxLength(20)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Dien_Thoai");
            entity.Property(e => e.Fax)
                .HasMaxLength(20)
                .HasDefaultValueSql("(' ')");
            entity.Property(e => e.GhiChu)
                .HasMaxLength(255)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Ghi_Chu");
            entity.Property(e => e.NguoiPhuTrach)
                .HasMaxLength(50)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Nguoi_Phu_Trach");
            entity.Property(e => e.Ten)
                .HasMaxLength(255)
                .HasDefaultValueSql("(' ')");
            entity.Property(e => e.TenGiamDoc).HasMaxLength(100);
            entity.Property(e => e.TenKeToan).HasMaxLength(100);
            entity.Property(e => e.TenKeToanTruong).HasMaxLength(100);
            entity.Property(e => e.TenKiemSoat).HasMaxLength(100);
            entity.Property(e => e.TenNguoiGuiTien).HasMaxLength(100);
            entity.Property(e => e.TenNguoiLapBang).HasMaxLength(100);
            entity.Property(e => e.TenNguoiNhanTien).HasMaxLength(100);
            entity.Property(e => e.TenTat)
                .HasMaxLength(50)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("ten_tat");
            entity.Property(e => e.TenThuQui).HasMaxLength(100);
            entity.Property(e => e.TieuDeBaoCao).HasMaxLength(100);
            entity.Property(e => e.TieuDeGiamDoc).HasMaxLength(100);
            entity.Property(e => e.TieuDeKeToan).HasMaxLength(100);
            entity.Property(e => e.TieuDeKeToanTruong).HasMaxLength(100);
            entity.Property(e => e.TieuDeKiemSoat).HasMaxLength(100);
            entity.Property(e => e.TieuDeNguoiGuiTien).HasMaxLength(100);
            entity.Property(e => e.TieuDeNguoiLapBang).HasMaxLength(100);
            entity.Property(e => e.TieuDeNguoiNhanTien).HasMaxLength(100);
            entity.Property(e => e.TieuDeThuQui).HasMaxLength(100);
        });

        modelBuilder.Entity<DmChucvu>(entity =>
        {
            entity.HasKey(e => e.Ma);

            entity.ToTable("DM_CHUCVU");

            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')");
            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.GhiChu)
                .HasMaxLength(400)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Ghi_Chu");
            entity.Property(e => e.Ten)
                .HasMaxLength(255)
                .HasDefaultValueSql("(' ')");
            entity.Property(e => e.TenTat)
                .HasMaxLength(20)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Ten_Tat");
        });

        modelBuilder.Entity<DmDvKyHan>(entity =>
        {
            entity.HasKey(e => e.Ma).HasName("PK_DM_DVKyHan");

            entity.ToTable("DM_DV_Ky_Han");

            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.Ten)
                .HasMaxLength(50)
                .HasDefaultValueSql("(' ')");
        });

        modelBuilder.Entity<DmHinhThucTraLai>(entity =>
        {
            entity.HasKey(e => e.Ma).HasName("PK_DM_HinhThuc");

            entity.ToTable("DM_HinhThucTraLai");

            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.GhiChu)
                .HasMaxLength(400)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Ghi_Chu");
            entity.Property(e => e.MaLoaiId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Ma_Loai_ID");
            entity.Property(e => e.Ten)
                .HasMaxLength(255)
                .HasDefaultValueSql("(' ')");
        });

        modelBuilder.Entity<DmIndexChanged>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DM_IndexChanged");

            entity.Property(e => e.GiaTri1)
                .HasDefaultValueSql("((0))")
                .HasColumnType("numeric(20, 0)")
                .HasColumnName("Gia_tri1");
            entity.Property(e => e.GiaTri2)
                .HasDefaultValueSql("((0))")
                .HasColumnType("numeric(20, 0)")
                .HasColumnName("Gia_tri2");
            entity.Property(e => e.IdIndex)
                .HasMaxLength(50)
                .HasColumnName("ID_index");
            entity.Property(e => e.Ten)
                .HasMaxLength(160)
                .HasDefaultValueSql("('')");
        });

        modelBuilder.Entity<DmKhuvuc>(entity =>
        {
            entity.HasKey(e => e.Ma);

            entity.ToTable("DM_KHUVUC");

            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.GhiChu)
                .HasMaxLength(255)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Ghi_Chu");
            entity.Property(e => e.Ten)
                .HasMaxLength(255)
                .HasDefaultValueSql("(' ')");
            entity.Property(e => e.TenTat)
                .HasMaxLength(20)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Ten_Tat");
        });

        modelBuilder.Entity<DmLoaiChungTu>(entity =>
        {
            entity.HasKey(e => e.Ma).HasName("PK_dm_loai_chung_tu");

            entity.ToTable("Dm_Loai_Chung_Tu");

            entity.Property(e => e.Ma)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("ma");
            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.GhiChu)
                .HasMaxLength(200)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("ghi_chu");
            entity.Property(e => e.IsSystem)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.MaTkCo)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("ma_tk_co");
            entity.Property(e => e.MaTkNo)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("ma_tk_no");
            entity.Property(e => e.NotMaTkCo)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("not_ma_tk_co");
            entity.Property(e => e.NotMaTkNo)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("not_ma_tk_no");
            entity.Property(e => e.Ten)
                .HasMaxLength(50)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("ten");
            entity.Property(e => e.TenTat)
                .HasMaxLength(20)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("ten_tat");
        });

        modelBuilder.Entity<DmLoaiGiaoDich>(entity =>
        {
            entity.HasKey(e => e.Ma).HasName("PK_dm_loai_giao_dich");

            entity.ToTable("Dm_Loai_Giao_Dich");

            entity.Property(e => e.Ma)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ma");
            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("active");
            entity.Property(e => e.GhiChu)
                .HasMaxLength(500)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("ghi_chu");
            entity.Property(e => e.GhiChu0)
                .HasMaxLength(100)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("ghi_chu0");
            entity.Property(e => e.GhiChu1)
                .HasMaxLength(100)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("ghi_chu1");
            entity.Property(e => e.IsSystem)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.LoaiTkCo0)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("loai_tk_co0");
            entity.Property(e => e.LoaiTkNo0)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("loai_tk_no0");
            entity.Property(e => e.MaNhom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("ma_nhom");
            entity.Property(e => e.MaTkCo0)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("ma_tk_co0");
            entity.Property(e => e.MaTkCo1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("ma_tk_co1");
            entity.Property(e => e.MaTkNo0)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("ma_tk_no0");
            entity.Property(e => e.MaTkNo1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("ma_tk_no1");
            entity.Property(e => e.Ten)
                .HasMaxLength(50)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("ten");
            entity.Property(e => e.TenTat)
                .HasMaxLength(50)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("ten_tat");
            entity.Property(e => e.TenTkCo0)
                .HasMaxLength(100)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("ten_tk_co0");
            entity.Property(e => e.TenTkNo0)
                .HasMaxLength(100)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("ten_tk_no0");
        });

        modelBuilder.Entity<DmLoaiTscd>(entity =>
        {
            entity.HasKey(e => e.MaLoai).HasName("PK__DM_LoaiTSCD__4A73BF29");

            entity.ToTable("DM_LoaiTSCD");

            entity.Property(e => e.MaLoai).HasColumnName("Ma_Loai");
            entity.Property(e => e.GhiChu).HasColumnName("Ghi_Chu");
            entity.Property(e => e.TenLoai)
                .HasMaxLength(50)
                .HasColumnName("Ten_Loai");
        });

        modelBuilder.Entity<DmLoaiVay>(entity =>
        {
            entity.HasKey(e => e.Ma).HasName("PK_dm_loai_vay");

            entity.ToTable("Dm_Loai_Vay");

            entity.Property(e => e.Ma)
                .ValueGeneratedNever()
                .HasColumnName("ma");
            entity.Property(e => e.Active).HasDefaultValueSql("((1))");
            entity.Property(e => e.IsSystem).HasDefaultValueSql("((1))");
            entity.Property(e => e.Ten)
                .HasMaxLength(50)
                .HasColumnName("ten");
        });

        modelBuilder.Entity<DmLoaisanpham>(entity =>
        {
            entity.HasKey(e => e.Ma).HasName("PK_DM_LOAISP");

            entity.ToTable("DM_LOAISANPHAM");

            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.GhiChu)
                .HasMaxLength(255)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Ghi_Chu");
            entity.Property(e => e.Ten)
                .HasMaxLength(255)
                .HasDefaultValueSql("(' ')");
        });

        modelBuilder.Entity<DmLoaithongke>(entity =>
        {
            entity.HasKey(e => e.Ma).HasName("PK_DM_LOAI");

            entity.ToTable("DM_LOAITHONGKE");

            entity.Property(e => e.Ma)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.Ten)
                .HasMaxLength(255)
                .HasDefaultValueSql("(' ')");
        });

        modelBuilder.Entity<DmMathongke>(entity =>
        {
            entity.HasKey(e => e.MaId);

            entity.ToTable("DM_MATHONGKE");

            entity.Property(e => e.MaId).HasColumnName("ma_id");
            entity.Property(e => e.GhiChu)
                .HasMaxLength(255)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Ghi_Chu");
            entity.Property(e => e.Ma)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.MaLoaiId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("Ma_Loai_ID");
            entity.Property(e => e.Ten)
                .HasMaxLength(255)
                .HasDefaultValueSql("(' ')");
            entity.Property(e => e.TenTat)
                .HasMaxLength(20)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Ten_Tat");
        });

        modelBuilder.Entity<DmNgayNghi>(entity =>
        {
            entity.HasKey(e => e.Ngay);

            entity.ToTable("Dm_Ngay_Nghi");

            entity.Property(e => e.Ngay)
                .HasColumnType("datetime")
                .HasColumnName("ngay");
            entity.Property(e => e.DateModify)
                .HasColumnType("datetime")
                .HasColumnName("Date_Modify");
            entity.Property(e => e.DateNew)
                .HasColumnType("datetime")
                .HasColumnName("Date_New");
            entity.Property(e => e.DienGiai)
                .HasMaxLength(200)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("dien_giai");
            entity.Property(e => e.UsersModify)
                .HasMaxLength(20)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Users_Modify");
            entity.Property(e => e.UsersNew)
                .HasMaxLength(20)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Users_New");
        });

        modelBuilder.Entity<DmNgheNghiep>(entity =>
        {
            entity.HasKey(e => e.Ma).HasName("PK_dm_nghe_nghiep");

            entity.ToTable("Dm_Nghe_Nghiep");

            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ma");
            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.GhiChu)
                .HasMaxLength(200)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("ghi_chu");
            entity.Property(e => e.Ten)
                .HasMaxLength(50)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("ten");
            entity.Property(e => e.TenTat)
                .HasMaxLength(20)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("ten_tat");
        });

        modelBuilder.Entity<DmNguoiLq>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DM_NguoiLQ");

            entity.Property(e => e.Ma).HasMaxLength(50);
            entity.Property(e => e.Ten).HasMaxLength(50);
        });

        modelBuilder.Entity<DmNhomKhachHang>(entity =>
        {
            entity.HasKey(e => e.Ma).HasName("PK_dm_loai_khach_hang");

            entity.ToTable("Dm_Nhom_Khach_Hang");

            entity.Property(e => e.Ma).HasMaxLength(20);
            entity.Property(e => e.DateModify)
                .HasColumnType("smalldatetime")
                .HasColumnName("Date_Modify");
            entity.Property(e => e.DateNew)
                .HasColumnType("smalldatetime")
                .HasColumnName("Date_New");
            entity.Property(e => e.GhiChu)
                .HasMaxLength(500)
                .HasColumnName("Ghi_Chu");
            entity.Property(e => e.PhanLoaiMa).HasColumnName("Phan_Loai_Ma");
            entity.Property(e => e.Ten).HasMaxLength(100);
            entity.Property(e => e.TenTat)
                .HasMaxLength(20)
                .HasColumnName("Ten_Tat");
            entity.Property(e => e.UsersModify)
                .HasMaxLength(20)
                .HasColumnName("Users_Modify");
            entity.Property(e => e.UsersNew)
                .HasMaxLength(50)
                .HasColumnName("Users_New");
        });

        modelBuilder.Entity<DmNhomThongKe>(entity =>
        {
            entity.HasKey(e => e.Ma);

            entity.ToTable("dm_nhom_thong_ke");

            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ma");
            entity.Property(e => e.KyHieu)
                .HasMaxLength(50)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("ky_hieu");
            entity.Property(e => e.TableName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("table_name");
            entity.Property(e => e.Ten)
                .HasMaxLength(200)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("ten");
        });

        modelBuilder.Entity<DmSanPham>(entity =>
        {
            entity.HasKey(e => e.Ma);

            entity.ToTable("DM_SanPham");

            entity.Property(e => e.Ma)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DateModify)
                .HasColumnType("datetime")
                .HasColumnName("Date_Modify");
            entity.Property(e => e.DateNew)
                .HasColumnType("datetime")
                .HasColumnName("Date_New");
            entity.Property(e => e.DvkyHanId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("DVKyHan_ID");
            entity.Property(e => e.GhiChu)
                .HasMaxLength(255)
                .HasColumnName("Ghi_Chu");
            entity.Property(e => e.KyHan).HasColumnName("Ky_Han");
            entity.Property(e => e.LaiSuat).HasColumnName("Lai_Suat");
            entity.Property(e => e.LoaiSpId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Loai_SP_ID");
            entity.Property(e => e.Ten).HasMaxLength(255);
            entity.Property(e => e.TenTat)
                .HasMaxLength(20)
                .HasColumnName("Ten_Tat");
            entity.Property(e => e.TienTeId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TienTe_Id");
            entity.Property(e => e.Tk1)
                .HasMaxLength(20)
                .HasColumnName("TK1");
            entity.Property(e => e.Tk2)
                .HasMaxLength(20)
                .HasColumnName("TK2");
            entity.Property(e => e.Tk3)
                .HasMaxLength(20)
                .HasColumnName("TK3");
            entity.Property(e => e.Tk4)
                .HasMaxLength(20)
                .HasColumnName("TK4");
            entity.Property(e => e.Tk5)
                .HasMaxLength(20)
                .HasColumnName("TK5");
            entity.Property(e => e.Tk6)
                .HasMaxLength(20)
                .HasColumnName("TK6");
            entity.Property(e => e.UsersModify)
                .HasMaxLength(20)
                .HasColumnName("Users_Modify");
            entity.Property(e => e.UsersNew)
                .HasMaxLength(20)
                .HasColumnName("Users_New");
        });

        modelBuilder.Entity<DmSanPhamTd>(entity =>
        {
            entity.HasKey(e => e.Ma);

            entity.ToTable("Dm_SanPham_TD");

            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Active)
                .HasDefaultValueSql("((1))")
                .HasColumnName("active");
            entity.Property(e => e.DateModify)
                .HasColumnType("datetime")
                .HasColumnName("Date_Modify");
            entity.Property(e => e.DateNew)
                .HasColumnType("datetime")
                .HasColumnName("Date_New");
            entity.Property(e => e.GhiChu)
                .HasMaxLength(255)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Ghi_Chu");
            entity.Property(e => e.HinhThucMa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("HinhThuc_Ma");
            entity.Property(e => e.KyHan)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Ky_Han");
            entity.Property(e => e.LaiSuat)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Lai_Suat");
            entity.Property(e => e.LoaiVay)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Loai_Vay");
            entity.Property(e => e.QuaHan)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Qua_Han");
            entity.Property(e => e.Ten)
                .HasMaxLength(255)
                .HasDefaultValueSql("(' ')");
            entity.Property(e => e.TenTat)
                .HasMaxLength(20)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Ten_Tat");
            entity.Property(e => e.TienTeMa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("TienTe_Ma");
            entity.Property(e => e.Tk1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("TK1");
            entity.Property(e => e.Tk2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("TK2");
            entity.Property(e => e.Tk3)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("TK3");
            entity.Property(e => e.Tk4)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("TK4");
            entity.Property(e => e.Tk5)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("TK5");
            entity.Property(e => e.Tk6)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("TK6");
            entity.Property(e => e.Tk7)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("TK7");
            entity.Property(e => e.TkChiDuPhong)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("TK_ChiDuPhong");
            entity.Property(e => e.TkDuPhong)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("TK_DuPhong");
            entity.Property(e => e.TkDuThu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("TK_DuThu");
            entity.Property(e => e.TkLaichuathu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("tk_laichuathu");
            entity.Property(e => e.TkLaiphat)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("tk_laiphat");
            entity.Property(e => e.TkLaithua)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("tk_laithua");
            entity.Property(e => e.TkPhattratruoc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("tk_phattratruoc");
            entity.Property(e => e.TkThuLai)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("TK_ThuLai");
            entity.Property(e => e.TkThukhac)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("tk_thukhac");
            entity.Property(e => e.TkTienMat)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("TK_TienMat");
            entity.Property(e => e.TkTscamco)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("tk_tscamco");
            entity.Property(e => e.TkTsdb)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("TK_TSDB");
            entity.Property(e => e.TkTskdb)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("TK_TSKDB");
            entity.Property(e => e.UsersModify)
                .HasMaxLength(20)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Users_Modify");
            entity.Property(e => e.UsersNew)
                .HasMaxLength(20)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Users_New");
        });

        modelBuilder.Entity<DmTaiKhoan>(entity =>
        {
            entity.HasKey(e => e.Ma);

            entity.ToTable("Dm_Tai_Khoan");

            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ma");
            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.BacTk)
                .HasDefaultValueSql("((4))")
                .HasColumnName("Bac_TK");
            entity.Property(e => e.DateModify)
                .HasColumnType("datetime")
                .HasColumnName("Date_Modify");
            entity.Property(e => e.DateNew)
                .HasColumnType("datetime")
                .HasColumnName("Date_New");
            entity.Property(e => e.IsSystem)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.MaCha)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Ma_cha");
            entity.Property(e => e.Ten)
                .HasMaxLength(255)
                .HasDefaultValueSql("(' ')");
            entity.Property(e => e.TinhChat).HasColumnName("Tinh_chat");
            entity.Property(e => e.TkCanDoi)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("TK_Can_Doi");
            entity.Property(e => e.TkNganHang)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("TK_Ngan_Hang");
            entity.Property(e => e.UsersModify)
                .HasMaxLength(20)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Users_Modify");
            entity.Property(e => e.UsersNew)
                .HasMaxLength(20)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Users_New");
        });

        modelBuilder.Entity<DmTaiKhoanChiTiet>(entity =>
        {
            entity.HasKey(e => e.Ma).HasName("PK_ITDVAPCF_TKCT");

            entity.ToTable("Dm_Tai_Khoan_Chi_Tiet");

            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ma");
            entity.Property(e => e.Active).HasDefaultValueSql("((1))");
            entity.Property(e => e.ChiNhanhId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("ChiNhanh_ID");
            entity.Property(e => e.DateModify)
                .HasColumnType("datetime")
                .HasColumnName("Date_Modify");
            entity.Property(e => e.DateNew)
                .HasColumnType("datetime")
                .HasColumnName("Date_New");
            entity.Property(e => e.IsSystem).HasDefaultValueSql("((1))");
            entity.Property(e => e.Loai).HasDefaultValueSql("((0))");
            entity.Property(e => e.LoaiTk)
                .HasMaxLength(5)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Loai_TK");
            entity.Property(e => e.MaTkTh)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("ma_tk_th");
            entity.Property(e => e.Ngay).HasColumnType("datetime");
            entity.Property(e => e.SoDu)
                .HasDefaultValueSql("((0))")
                .HasColumnName("So_Du");
            entity.Property(e => e.Ten)
                .HasMaxLength(250)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("ten");
            entity.Property(e => e.TienTeMa)
                .HasMaxLength(20)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("TienTe_Ma");
            entity.Property(e => e.TinhChat)
                .HasDefaultValueSql("((0))")
                .HasColumnName("tinh_chat");
            entity.Property(e => e.TrangThai)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Trang_Thai");
            entity.Property(e => e.UsersModify)
                .HasMaxLength(20)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Users_Modify");
            entity.Property(e => e.UsersNew)
                .HasMaxLength(20)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Users_New");
        });

        modelBuilder.Entity<DmTaiKhoanDbtk>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Dm_Tai_khoan_DBTK");

            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .HasColumnName("ID");
            entity.Property(e => e.Ma).HasMaxLength(50);
            entity.Property(e => e.MaCha)
                .HasMaxLength(50)
                .HasColumnName("Ma_Cha");
            entity.Property(e => e.MaKvtc)
                .HasMaxLength(50)
                .HasColumnName("Ma_KVTC");
            entity.Property(e => e.MaKvtc0)
                .HasMaxLength(50)
                .HasColumnName("Ma_KVTC0");
            entity.Property(e => e.Ten).HasMaxLength(200);
        });

        modelBuilder.Entity<DmTaiKhoanN>(entity =>
        {
            entity.HasKey(e => e.Ma);

            entity.ToTable("Dm_Tai_Khoan_n");

            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ma");
            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.BacTk)
                .HasDefaultValueSql("((4))")
                .HasColumnName("Bac_TK");
            entity.Property(e => e.DateModify)
                .HasColumnType("datetime")
                .HasColumnName("Date_Modify");
            entity.Property(e => e.DateNew)
                .HasColumnType("datetime")
                .HasColumnName("Date_New");
            entity.Property(e => e.IsSystem)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.MaCha)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Ma_cha");
            entity.Property(e => e.Ten)
                .HasMaxLength(255)
                .HasDefaultValueSql("(' ')");
            entity.Property(e => e.TinhChat).HasColumnName("Tinh_chat");
            entity.Property(e => e.TkCanDoi)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("TK_Can_Doi");
            entity.Property(e => e.TkNganHang)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("TK_Ngan_Hang");
            entity.Property(e => e.UsersModify)
                .HasMaxLength(20)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Users_Modify");
            entity.Property(e => e.UsersNew)
                .HasMaxLength(20)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Users_New");
        });

        modelBuilder.Entity<DmTienTe>(entity =>
        {
            entity.HasKey(e => e.Ma);

            entity.ToTable("Dm_Tien_Te");

            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .HasColumnName("ma");
            entity.Property(e => e.Active).HasDefaultValueSql("((1))");
            entity.Property(e => e.GhiChu)
                .HasMaxLength(250)
                .HasColumnName("ghi_chu");
            entity.Property(e => e.IsSystem).HasDefaultValueSql("((1))");
            entity.Property(e => e.Ten)
                .HasMaxLength(250)
                .HasColumnName("ten");
            entity.Property(e => e.TenTat)
                .HasMaxLength(250)
                .HasColumnName("ten_tat");
        });

        modelBuilder.Entity<DmTyGium>(entity =>
        {
            entity.HasKey(e => new { e.TyGiaId, e.Ngay }).HasName("PK_DM_LSTyGia");

            entity.ToTable("DM_Ty_Gia");

            entity.Property(e => e.TyGiaId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TY_GIA_ID");
            entity.Property(e => e.Ngay).HasColumnType("datetime");
            entity.Property(e => e.DateModify)
                .HasColumnType("datetime")
                .HasColumnName("Date_Modify");
            entity.Property(e => e.DateNew)
                .HasColumnType("datetime")
                .HasColumnName("Date_New");
            entity.Property(e => e.TienTeId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("TienTe_ID");
            entity.Property(e => e.TyGia)
                .HasDefaultValueSql("((1))")
                .HasColumnName("ty_gia");
            entity.Property(e => e.UsersModify)
                .HasMaxLength(20)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Users_Modify");
            entity.Property(e => e.UsersNew)
                .HasMaxLength(20)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Users_New");
        });

        modelBuilder.Entity<FindCandoiTaiKhoan>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("find_CandoiTaiKhoan");

            entity.Property(e => e.Captk).HasColumnName("captk");
            entity.Property(e => e.Cocuoiky)
                .HasDefaultValueSql("((0))")
                .HasColumnName("cocuoiky");
            entity.Property(e => e.Codauky)
                .HasDefaultValueSql("((0))")
                .HasColumnName("codauky");
            entity.Property(e => e.Cophatsinh)
                .HasDefaultValueSql("((0))")
                .HasColumnName("cophatsinh");
            entity.Property(e => e.Macha)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("macha");
            entity.Property(e => e.Machinhanh)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .HasColumnName("machinhanh");
            entity.Property(e => e.Matktonghop)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("matktonghop");
            entity.Property(e => e.Nocuoiky)
                .HasDefaultValueSql("((0))")
                .HasColumnName("nocuoiky");
            entity.Property(e => e.Nodauky)
                .HasDefaultValueSql("((0))")
                .HasColumnName("nodauky");
            entity.Property(e => e.Nophatsinh)
                .HasDefaultValueSql("((0))")
                .HasColumnName("nophatsinh");
            entity.Property(e => e.Sotaikhoan)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("sotaikhoan");
            entity.Property(e => e.Tentaikhoan)
                .HasMaxLength(250)
                .HasColumnName("tentaikhoan");
        });

        modelBuilder.Entity<FindTaikhoanPhatsinh>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("find_TaikhoanPhatsinh");

            entity.Property(e => e.ChinhanhId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .HasColumnName("chinhanh_id");
            entity.Property(e => e.CoCuoiKy)
                .HasDefaultValueSql("((0))")
                .HasColumnName("co_cuoi_ky");
            entity.Property(e => e.CoDauKy)
                .HasDefaultValueSql("((0))")
                .HasColumnName("co_dau_ky");
            entity.Property(e => e.CoTrongKy)
                .HasDefaultValueSql("((0))")
                .HasColumnName("co_trong_ky");
            entity.Property(e => e.MaTk)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ma_tk");
            entity.Property(e => e.Ngay)
                .HasColumnType("datetime")
                .HasColumnName("ngay");
            entity.Property(e => e.NoCuoiKy)
                .HasDefaultValueSql("((0))")
                .HasColumnName("no_cuoi_ky");
            entity.Property(e => e.NoDauKy)
                .HasDefaultValueSql("((0))")
                .HasColumnName("no_dau_ky");
            entity.Property(e => e.NoTrongKy)
                .HasDefaultValueSql("((0))")
                .HasColumnName("no_trong_ky");
        });

        modelBuilder.Entity<FindTmpGiaoDich>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("find_tmpGiaoDich");

            entity.Property(e => e.Cophatsinh)
                .HasDefaultValueSql("((0))")
                .HasColumnName("cophatsinh");
            entity.Property(e => e.Ngaygiaodich)
                .HasColumnType("datetime")
                .HasColumnName("ngaygiaodich");
            entity.Property(e => e.Nophatsinh)
                .HasDefaultValueSql("((0))")
                .HasColumnName("nophatsinh");
            entity.Property(e => e.Sotaikhoan)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("sotaikhoan");
        });

        modelBuilder.Entity<GiaoDich>(entity =>
        {
            entity.ToTable("Giao_Dich", tb =>
                {
                    tb.HasTrigger("trg_GIAODICHGD_DEL");
                    tb.HasTrigger("trg_GIAODICHGD_NganQuy_DEL");
                });

            entity.HasIndex(e => e.ObjectId, "IX_Giao_Dich");

            entity.Property(e => e.GiaoDichId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GiaoDich_ID");
            entity.Property(e => e.ChinhanhId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("chinhanh_id");
            entity.Property(e => e.DateModify)
                .HasColumnType("datetime")
                .HasColumnName("Date_Modify");
            entity.Property(e => e.DateNew)
                .HasColumnType("datetime")
                .HasColumnName("Date_New");
            entity.Property(e => e.DienGiai)
                .HasMaxLength(200)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Dien_Giai");
            entity.Property(e => e.KhId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KH_ID");
            entity.Property(e => e.LoaiChungTuId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Loai_Chung_Tu_ID");
            entity.Property(e => e.LoaiGiaoDichId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Loai_Giao_Dich_ID");
            entity.Property(e => e.MaTkCo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("ma_tk_co");
            entity.Property(e => e.MaTkNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("ma_tk_no");
            entity.Property(e => e.Ngay).HasColumnType("datetime");
            entity.Property(e => e.ObjectId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("object_id");
            entity.Property(e => e.ObjectSerial)
                .HasMaxLength(20)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("object_serial");
            entity.Property(e => e.SoDuToan).HasColumnName("so_du_toan");
            entity.Property(e => e.SoPhatSinh).HasColumnName("so_phat_sinh");
            entity.Property(e => e.TienTeMa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("TienTe_Ma");
            entity.Property(e => e.TienTeTyGia).HasColumnName("TienTe_TyGia");
            entity.Property(e => e.TrangThai).HasColumnName("Trang_Thai");
            entity.Property(e => e.UsersModify)
                .HasMaxLength(20)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Users_Modify");
            entity.Property(e => e.UsersNew)
                .HasMaxLength(20)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Users_New");
        });

        modelBuilder.Entity<ImagesStore>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ImagesStore");

            entity.Property(e => e.ImageData).HasColumnType("image");
            entity.Property(e => e.ImageId).ValueGeneratedOnAdd();
            entity.Property(e => e.KhachHangId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KhachHang_Id");
            entity.Property(e => e.OriginalPath)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<InVoiceDangKySeri>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("InVoice_DangKy_Seri");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.KyHieu)
                .HasMaxLength(50)
                .HasColumnName("Ky_hieu");
            entity.Property(e => e.MaHd)
                .HasMaxLength(50)
                .HasColumnName("Ma_HD");
            entity.Property(e => e.MauHd)
                .HasMaxLength(50)
                .HasColumnName("Mau_HD");
            entity.Property(e => e.NgayHl)
                .HasColumnType("smalldatetime")
                .HasColumnName("Ngay_HL");
            entity.Property(e => e.SeriCuoi)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("Seri_cuoi");
            entity.Property(e => e.SeriDau)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("Seri_dau");
        });

        modelBuilder.Entity<InVoiceUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("InVoice_Users");

            entity.Property(e => e.FullName).HasMaxLength(100);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.MaDvcs)
                .HasMaxLength(50)
                .HasColumnName("Ma_dvcs");
            entity.Property(e => e.Password).HasMaxLength(50);
            entity.Property(e => e.PinChecked).HasColumnName("PIN_Checked");
            entity.Property(e => e.TypeCks).HasColumnName("TypeCKS");
            entity.Property(e => e.UrlMinvoice)
                .HasMaxLength(50)
                .HasColumnName("Url_Minvoice");
            entity.Property(e => e.UserName).HasMaxLength(50);
        });

        modelBuilder.Entity<InvoiceCtthue>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Invoice_CTThue");

            entity.Property(e => e.ChinhanhId)
                .HasMaxLength(20)
                .HasColumnName("chinhanh_ID");
            entity.Property(e => e.CreateDateIvc).HasColumnType("smalldatetime");
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.GhiChu)
                .HasMaxLength(500)
                .HasColumnName("Ghi_chu");
            entity.Property(e => e.GiaodichId)
                .HasMaxLength(50)
                .HasColumnName("Giaodich_ID");
            entity.Property(e => e.InvInvoiceAuthId)
                .HasMaxLength(50)
                .HasColumnName("inv_InvoiceAuth_id");
            entity.Property(e => e.KhachhangDiachi)
                .HasMaxLength(300)
                .HasColumnName("khachhang_diachi");
            entity.Property(e => e.KhachhangId)
                .HasMaxLength(20)
                .HasColumnName("khachhang_ID");
            entity.Property(e => e.KhachhangTen)
                .HasMaxLength(300)
                .HasColumnName("khachhang_Ten");
            entity.Property(e => e.KyHieu)
                .HasMaxLength(50)
                .HasColumnName("Ky_hieu");
            entity.Property(e => e.LoaiGiaoDichId)
                .HasMaxLength(20)
                .HasColumnName("Loai_Giao_Dich_ID");
            entity.Property(e => e.MaSoThue)
                .HasMaxLength(50)
                .HasColumnName("ma_so_thue");
            entity.Property(e => e.MaThue)
                .HasMaxLength(50)
                .HasColumnName("ma_thue");
            entity.Property(e => e.MauHd)
                .HasMaxLength(50)
                .HasColumnName("Mau_HD");
            entity.Property(e => e.NgayGd)
                .HasColumnType("smalldatetime")
                .HasColumnName("ngay_GD");
            entity.Property(e => e.NgayHd)
                .HasColumnType("smalldatetime")
                .HasColumnName("Ngay_HD");
            entity.Property(e => e.NgayHuy)
                .HasColumnType("smalldatetime")
                .HasColumnName("Ngay_huy");
            entity.Property(e => e.SoCt)
                .HasMaxLength(50)
                .HasColumnName("So_ct");
            entity.Property(e => e.SoHd)
                .HasMaxLength(50)
                .HasColumnName("So_HD");
            entity.Property(e => e.ThueId)
                .HasMaxLength(20)
                .HasColumnName("Thue_id");
            entity.Property(e => e.ThueId0)
                .HasMaxLength(20)
                .HasColumnName("Thue_id0");
            entity.Property(e => e.ThueSuat).HasColumnName("Thue_Suat");
            entity.Property(e => e.TienThue).HasColumnName("Tien_thue");
            entity.Property(e => e.TienTruocThue).HasColumnName("Tien_truoc_thue");
            entity.Property(e => e.TkThue)
                .HasMaxLength(50)
                .HasColumnName("tk_thue");
            entity.Property(e => e.TongTien).HasColumnName("Tong_tien");
            entity.Property(e => e.TrangThai).HasColumnName("trang_thai");
            entity.Property(e => e.Users)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("users");
        });

        modelBuilder.Entity<InvoiceCtthueBk>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Invoice_CTThueBK");

            entity.Property(e => e.GhiChu)
                .HasMaxLength(500)
                .HasColumnName("Ghi_chu");
            entity.Property(e => e.GiaodichId)
                .HasMaxLength(20)
                .HasColumnName("Giaodich_Id");
            entity.Property(e => e.InvInvoiceAuthId)
                .HasMaxLength(50)
                .HasColumnName("inv_InvoiceAuth_id");
            entity.Property(e => e.KhachhangDiachi)
                .HasMaxLength(300)
                .HasColumnName("khachhang_diachi");
            entity.Property(e => e.KhachhangId)
                .HasMaxLength(20)
                .HasColumnName("khachhang_ID");
            entity.Property(e => e.KhachhangTen)
                .HasMaxLength(300)
                .HasColumnName("khachhang_Ten");
            entity.Property(e => e.LoaiGiaoDichId)
                .HasMaxLength(20)
                .HasColumnName("Loai_Giao_Dich_ID");
            entity.Property(e => e.MaSoThue)
                .HasMaxLength(50)
                .HasColumnName("ma_so_thue");
            entity.Property(e => e.MaThue)
                .HasMaxLength(50)
                .HasColumnName("ma_thue");
            entity.Property(e => e.MauHd)
                .HasMaxLength(50)
                .HasColumnName("Mau_HD");
            entity.Property(e => e.NgayHd)
                .HasColumnType("smalldatetime")
                .HasColumnName("ngay_HD");
            entity.Property(e => e.SoCt)
                .HasMaxLength(50)
                .HasColumnName("So_ct");
            entity.Property(e => e.SoHd)
                .HasMaxLength(50)
                .HasColumnName("So_HD");
            entity.Property(e => e.ThueId)
                .HasMaxLength(20)
                .HasColumnName("Thue_id");
            entity.Property(e => e.ThueSuat).HasColumnName("Thue_suat");
            entity.Property(e => e.TienThue).HasColumnName("Tien_thue");
            entity.Property(e => e.TienTruocThue).HasColumnName("Tien_truoc_thue");
            entity.Property(e => e.TongTien).HasColumnName("Tong_tien");
            entity.Property(e => e.TrangThai).HasColumnName("trang_thai");
        });

        modelBuilder.Entity<InvoiceDmThueSuat>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Invoice_Dm_ThueSuat");

            entity.Property(e => e.Ma).HasMaxLength(50);
            entity.Property(e => e.Ten).HasMaxLength(50);
            entity.Property(e => e.ThueSuat).HasColumnName("Thue_suat");
        });

        modelBuilder.Entity<InvoiceInfor>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Invoice_Infor");

            entity.Property(e => e.Comments).HasMaxLength(200);
            entity.Property(e => e.Id).HasMaxLength(50);
            entity.Property(e => e.Realvalue)
                .HasMaxLength(200)
                .HasColumnName("realvalue");
        });

        modelBuilder.Entity<KeToanTaiKhoanSoDu>(entity =>
        {
            entity.HasKey(e => new { e.MaTk, e.Ngay });

            entity.ToTable("KeToan_Tai_Khoan_So_Du");

            entity.Property(e => e.MaTk)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("ma_tk");
            entity.Property(e => e.Ngay)
                .HasColumnType("datetime")
                .HasColumnName("ngay");
            entity.Property(e => e.ChinhanhId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("chinhanh_id");
            entity.Property(e => e.CoCuoiKy)
                .HasDefaultValueSql("((0))")
                .HasColumnName("co_cuoi_ky");
            entity.Property(e => e.CoDauKy)
                .HasDefaultValueSql("((0))")
                .HasColumnName("co_dau_ky");
            entity.Property(e => e.CoDauNam).HasColumnName("co_dau_nam");
            entity.Property(e => e.CoLuyKe).HasColumnName("co_luy_ke");
            entity.Property(e => e.CoTrongKy)
                .HasDefaultValueSql("((0))")
                .HasColumnName("co_trong_ky");
            entity.Property(e => e.DateModify)
                .HasColumnType("datetime")
                .HasColumnName("Date_Modify");
            entity.Property(e => e.DateNew)
                .HasColumnType("datetime")
                .HasColumnName("Date_New");
            entity.Property(e => e.LoaiDl).HasColumnName("LoaiDL");
            entity.Property(e => e.MaId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ma_id");
            entity.Property(e => e.NoCuoiKy)
                .HasDefaultValueSql("((0))")
                .HasColumnName("no_cuoi_ky");
            entity.Property(e => e.NoDauKy)
                .HasDefaultValueSql("((0))")
                .HasColumnName("no_dau_ky");
            entity.Property(e => e.NoDauNam).HasColumnName("no_dau_nam");
            entity.Property(e => e.NoLuyKe).HasColumnName("no_luy_ke");
            entity.Property(e => e.NoTrongKy)
                .HasDefaultValueSql("((0))")
                .HasColumnName("no_trong_ky");
            entity.Property(e => e.UsersModify)
                .HasMaxLength(20)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Users_Modify");
            entity.Property(e => e.UsersNew)
                .HasMaxLength(20)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Users_New");
        });

        modelBuilder.Entity<KeToanTaiKhoanSoDuThang>(entity =>
        {
            entity.HasKey(e => new { e.MaTk, e.ChinhanhId, e.Thangnam });

            entity.ToTable("KeToan_TaiKhoanSoDu_Thang");

            entity.Property(e => e.MaTk)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("ma_tk");
            entity.Property(e => e.ChinhanhId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("chinhanh_id");
            entity.Property(e => e.Thangnam)
                .HasColumnType("datetime")
                .HasColumnName("thangnam");
            entity.Property(e => e.CoCuoiKy)
                .HasDefaultValueSql("((0))")
                .HasColumnName("co_cuoi_ky");
            entity.Property(e => e.CoDauKy)
                .HasDefaultValueSql("((0))")
                .HasColumnName("co_dau_ky");
            entity.Property(e => e.CoTrongKy)
                .HasDefaultValueSql("((0))")
                .HasColumnName("co_trong_ky");
            entity.Property(e => e.NoCuoiKy)
                .HasDefaultValueSql("((0))")
                .HasColumnName("no_cuoi_ky");
            entity.Property(e => e.NoDauKy)
                .HasDefaultValueSql("((0))")
                .HasColumnName("no_dau_ky");
            entity.Property(e => e.NoTrongKy)
                .HasDefaultValueSql("((0))")
                .HasColumnName("no_trong_ky");
        });

        modelBuilder.Entity<KehoachThuchien>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Kehoach_thuchien");

            entity.Property(e => e.Chenhlech)
                .HasMaxLength(300)
                .HasColumnName("CHENHLECH");
            entity.Property(e => e.Chitieu)
                .HasMaxLength(300)
                .HasColumnName("CHITIEU");
            entity.Property(e => e.Congtru)
                .HasMaxLength(300)
                .HasColumnName("CONGTRU");
            entity.Property(e => e.GiatriKehoach).HasColumnName("Giatri_kehoach");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Indam).HasColumnName("INDAM");
            entity.Property(e => e.Nam).HasMaxLength(10);
            entity.Property(e => e.Nhatsolieu)
                .HasMaxLength(300)
                .HasColumnName("NHATSOLIEU");
            entity.Property(e => e.Stt)
                .HasMaxLength(50)
                .HasColumnName("STT");
        });

        modelBuilder.Entity<KetquaBieu02c>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("KETQUA_BIEU02C");

            entity.Property(e => e.Id)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ID");
            entity.Property(e => e.Ma)
                .HasMaxLength(150)
                .HasColumnName("MA");
            entity.Property(e => e.Sodu1).HasColumnName("SODU1");
            entity.Property(e => e.Sodu2).HasColumnName("SODU2");
            entity.Property(e => e.Sodu3).HasColumnName("SODU3");
            entity.Property(e => e.Sodu4).HasColumnName("SODU4");
        });

        modelBuilder.Entity<KhMaTmp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("kh_ma_tmp");

            entity.Property(e => e.CusId)
                .HasMaxLength(50)
                .HasColumnName("cus_id");
            entity.Property(e => e.MaNew)
                .HasMaxLength(50)
                .HasColumnName("ma_new");
        });

        modelBuilder.Entity<KhachHang>(entity =>
        {
            entity.HasKey(e => e.KhachHangId).HasName("PK_KHACH_HANG");

            entity.ToTable("Khach_Hang", tb => tb.HasTrigger("trgAfterUpdate_CcAnchiGTCG_Sogopvon"));

            entity.Property(e => e.KhachHangId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KhachHang_ID");
            entity.Property(e => e.ChinhanhId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("CHINHANH_ID");
            entity.Property(e => e.ChucVuMa)
                .HasMaxLength(20)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("ChucVu_Ma");
            entity.Property(e => e.CmtNgayCap)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("CMT_NgayCap");
            entity.Property(e => e.CmtNgaycapNuq)
                .HasDefaultValueSql("('1900-01-01')")
                .HasColumnType("datetime")
                .HasColumnName("Cmt_ngaycap_NUQ");
            entity.Property(e => e.CmtNoiCap)
                .HasMaxLength(255)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("CMT_NoiCap");
            entity.Property(e => e.CmtNoicapNuq)
                .HasMaxLength(400)
                .HasColumnName("Cmt_noicap_NUQ");
            entity.Property(e => e.CmtOldNgayCap)
                .HasColumnType("datetime")
                .HasColumnName("CMT_Old_NgayCap");
            entity.Property(e => e.CmtOldNoiCap)
                .HasMaxLength(100)
                .HasColumnName("CMT_Old_NoiCap");
            entity.Property(e => e.CmtSerial)
                .HasMaxLength(20)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("CMT_Serial");
            entity.Property(e => e.CmtSerialNuq)
                .HasMaxLength(40)
                .HasColumnName("Cmt_serial_NUQ");
            entity.Property(e => e.CmtSerialOld)
                .HasMaxLength(14)
                .HasDefaultValueSql("('')")
                .HasColumnName("CMT_Serial_Old");
            entity.Property(e => e.CoPhanThuongNien).HasColumnName("co_phan_thuong_nien");
            entity.Property(e => e.CoPhanThuongXuyen).HasColumnName("co_phan_thuong_xuyen");
            entity.Property(e => e.CoPhanXacLap).HasColumnName("co_phan_xac_lap");
            entity.Property(e => e.DanToc).HasMaxLength(50);
            entity.Property(e => e.DateModify)
                .HasColumnType("datetime")
                .HasColumnName("Date_Modify");
            entity.Property(e => e.DateNew)
                .HasColumnType("datetime")
                .HasColumnName("Date_New");
            entity.Property(e => e.DiaChi)
                .HasMaxLength(255)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Dia_Chi");
            entity.Property(e => e.DiaChiNuq)
                .HasMaxLength(400)
                .HasColumnName("Dia_chi_NUQ");
            entity.Property(e => e.DiaChiTt)
                .HasMaxLength(255)
                .HasColumnName("dia_chi_TT");
            entity.Property(e => e.DiemThuong).HasColumnName("diem_thuong");
            entity.Property(e => e.DienThoaiNuq)
                .HasMaxLength(300)
                .HasColumnName("Dien_thoai_NUQ");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasDefaultValueSql("(' ')");
            entity.Property(e => e.Fax)
                .HasMaxLength(150)
                .HasDefaultValueSql("(' ')");
            entity.Property(e => e.GhiChu)
                .HasMaxLength(500)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Ghi_Chu");
            entity.Property(e => e.GioiTinh).HasColumnName("Gioi_Tinh");
            entity.Property(e => e.IsChecked).HasColumnName("Is_Checked");
            entity.Property(e => e.IsLocked).HasColumnName("Is_Locked");
            entity.Property(e => e.KhuVucMa)
                .HasMaxLength(20)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("KhuVuc_Ma");
            entity.Property(e => e.LoaiHinhDnMa)
                .HasMaxLength(20)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("LoaiHinhDN_Ma");
            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')");
            entity.Property(e => e.MaSoThue)
                .HasMaxLength(20)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Ma_So_Thue");
            entity.Property(e => e.MqhNuq).HasColumnName("Mqh_NUQ");
            entity.Property(e => e.NganhNgheKdMa)
                .HasMaxLength(20)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("NganhNgheKD_Ma");
            entity.Property(e => e.Ngay).HasColumnType("smalldatetime");
            entity.Property(e => e.NgayDkkd)
                .HasColumnType("datetime")
                .HasColumnName("Ngay_DKKD");
            entity.Property(e => e.NgaySinh)
                .HasColumnType("datetime")
                .HasColumnName("Ngay_Sinh");
            entity.Property(e => e.NgaySinhNuq)
                .HasDefaultValueSql("('1900-01-01')")
                .HasColumnType("datetime")
                .HasColumnName("Ngay_sinh_NUQ");
            entity.Property(e => e.NgayTinhDiem)
                .HasColumnType("smalldatetime")
                .HasColumnName("ngay_tinh_diem");
            entity.Property(e => e.NgheNghiepMa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("NgheNghiep_Ma");
            entity.Property(e => e.NguoiDaiDien)
                .HasMaxLength(50)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Nguoi_Dai_Dien");
            entity.Property(e => e.NoiONuq)
                .HasMaxLength(400)
                .HasColumnName("Noi_o_NUQ");
            entity.Property(e => e.PhanLoaiMa).HasColumnName("Phan_Loai_Ma");
            entity.Property(e => e.PhanNhomMa)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Phan_Nhom_Ma");
            entity.Property(e => e.PhoneMobie)
                .HasMaxLength(150)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Phone_Mobie");
            entity.Property(e => e.PhoneOffice)
                .HasMaxLength(150)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Phone_Office");
            entity.Property(e => e.SoDkkd)
                .HasMaxLength(20)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("So_DKKD");
            entity.Property(e => e.SoTaiKhoan)
                .HasMaxLength(20)
                .HasColumnName("So_TaiKhoan");
            entity.Property(e => e.Ten)
                .HasMaxLength(255)
                .HasDefaultValueSql("(' ')");
            entity.Property(e => e.TenNganHang)
                .HasMaxLength(200)
                .HasColumnName("Ten_NganHang");
            entity.Property(e => e.TenNuq)
                .HasMaxLength(400)
                .HasColumnName("Ten_NUQ");
            entity.Property(e => e.TenTat)
                .HasMaxLength(20)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Ten_Tat");
            entity.Property(e => e.ThanhvienIs).HasColumnName("THANHVIEN_IS");
            entity.Property(e => e.ThanhvienMa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("THANHVIEN_MA");
            entity.Property(e => e.ThanhvienNgay)
                .HasColumnType("datetime")
                .HasColumnName("THANHVIEN_NGAY");
            entity.Property(e => e.ThanhvienSerial)
                .HasMaxLength(20)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("THANHVIEN_SERIAL");
            entity.Property(e => e.UsersModify)
                .HasMaxLength(200)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Users_Modify");
            entity.Property(e => e.UsersNew)
                .HasMaxLength(200)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Users_New");
        });

        modelBuilder.Entity<KhachHangChamDiemKh>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("KhachHang_ChamDiemKH");

            entity.Property(e => e.ChiTieu).HasMaxLength(255);
            entity.Property(e => e.ChiTieuChiTietId)
                .HasMaxLength(20)
                .HasColumnName("ChiTieuChiTiet_ID");
            entity.Property(e => e.ChiTieuId)
                .HasMaxLength(20)
                .HasColumnName("ChiTieu_ID");
            entity.Property(e => e.DateModify).HasColumnType("datetime");
            entity.Property(e => e.DateNew).HasColumnType("datetime");
            entity.Property(e => e.GhiChu).HasMaxLength(200);
            entity.Property(e => e.GroupBieu)
                .HasMaxLength(20)
                .HasColumnName("Group_bieu");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.KhachHangId)
                .HasMaxLength(50)
                .HasColumnName("KhachHang_ID");
            entity.Property(e => e.UsersModify).HasMaxLength(20);
            entity.Property(e => e.UsersNew).HasMaxLength(20);
        });

        modelBuilder.Entity<KhachHangCoPhan>(entity =>
        {
            entity.HasKey(e => e.CoPhanGdId).HasName("PK_KhachHang_GiaoDich_CoPhan");

            entity.ToTable("KhachHang_CoPhan");

            entity.Property(e => e.CoPhanGdId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CoPhanGD_ID");
            entity.Property(e => e.ChinhanhId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("Chinhanh_Id");
            entity.Property(e => e.CoPhanGdId2)
                .HasMaxLength(30)
                .HasColumnName("CoPhanGD_ID2");
            entity.Property(e => e.DateModify)
                .HasColumnType("datetime")
                .HasColumnName("Date_Modify");
            entity.Property(e => e.DateNew)
                .HasColumnType("datetime")
                .HasColumnName("Date_New");
            entity.Property(e => e.GhiChu)
                .HasMaxLength(500)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Ghi_Chu");
            entity.Property(e => e.KhachHangId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("KhachHang_Id");
            entity.Property(e => e.LaiSuat).HasColumnName("Lai_Suat");
            entity.Property(e => e.LoaiGiaoDich).HasColumnName("Loai_Giao_Dich");
            entity.Property(e => e.LoaiGopVon).HasColumnName("Loai_Gop_Von");
            entity.Property(e => e.MaTkCo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Ma_Tk_Co");
            entity.Property(e => e.MaTkNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Ma_TK_No");
            entity.Property(e => e.Ngay).HasColumnType("datetime");
            entity.Property(e => e.NgayDuyet)
                .HasColumnType("datetime")
                .HasColumnName("ngay_duyet");
            entity.Property(e => e.NgayHuongLai)
                .HasColumnType("datetime")
                .HasColumnName("Ngay_Huong_Lai");
            entity.Property(e => e.SoChungTu)
                .HasMaxLength(20)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("so_chung_tu");
            entity.Property(e => e.SoPhatSinh).HasColumnName("So_Phat_Sinh");
            entity.Property(e => e.TrangThai).HasColumnName("Trang_Thai");
            entity.Property(e => e.UsersModify)
                .HasMaxLength(20)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Users_Modify");
            entity.Property(e => e.UsersNew)
                .HasMaxLength(20)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Users_New");
        });

        modelBuilder.Entity<KhachHangCoPhanCn>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("KhachHang_CoPhan_CN");

            entity.Property(e => e.GhiChu)
                .HasMaxLength(500)
                .HasColumnName("ghi_chu");
            entity.Property(e => e.GiaodichId1)
                .HasMaxLength(20)
                .HasColumnName("giaodich_id1");
            entity.Property(e => e.GiaodichId2)
                .HasMaxLength(20)
                .HasColumnName("giaodich_id2");
            entity.Property(e => e.KhachhangId1)
                .HasMaxLength(20)
                .HasColumnName("khachhang_id1");
            entity.Property(e => e.KhachhangId2)
                .HasMaxLength(20)
                .HasColumnName("khachhang_id2");
            entity.Property(e => e.LoaiCn)
                .HasDefaultValueSql("((0))")
                .HasColumnName("loai_cn");
            entity.Property(e => e.NgayCn)
                .HasColumnType("datetime")
                .HasColumnName("ngay_cn");
            entity.Property(e => e.SotienCn)
                .HasDefaultValueSql("((0))")
                .HasColumnName("sotien_cn");
        });

        modelBuilder.Entity<KhachHangCoPhanTreo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("KhachHang_CoPhan_Treo");

            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.Checked)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.ChinhanhId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("Chinhanh_Id");
            entity.Property(e => e.CoPhanGdId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CoPhanGD_ID");
            entity.Property(e => e.DateModify)
                .HasColumnType("datetime")
                .HasColumnName("Date_Modify");
            entity.Property(e => e.DateNew)
                .HasColumnType("datetime")
                .HasColumnName("Date_New");
            entity.Property(e => e.GhiChu)
                .HasMaxLength(500)
                .HasColumnName("Ghi_Chu");
            entity.Property(e => e.KhachHangId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KhachHang_Id");
            entity.Property(e => e.LaiSuat).HasColumnName("Lai_Suat");
            entity.Property(e => e.LoaiCoPhan)
                .HasDefaultValueSql("((1))")
                .HasColumnName("Loai_co_Phan");
            entity.Property(e => e.LoaiGiaoDich).HasColumnName("Loai_Giao_Dich");
            entity.Property(e => e.LoaiGopVon).HasColumnName("Loai_Gop_Von");
            entity.Property(e => e.Locked)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.MaTkCo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Ma_Tk_Co");
            entity.Property(e => e.MaTkNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Ma_TK_No");
            entity.Property(e => e.Ngay).HasColumnType("datetime");
            entity.Property(e => e.NgayHuongLai)
                .HasColumnType("datetime")
                .HasColumnName("Ngay_Huong_Lai");
            entity.Property(e => e.SoChungTu)
                .HasMaxLength(20)
                .HasColumnName("so_chung_tu");
            entity.Property(e => e.SoPhatSinh).HasColumnName("So_Phat_Sinh");
            entity.Property(e => e.TrangThai).HasColumnName("Trang_Thai");
            entity.Property(e => e.UsersModify)
                .HasMaxLength(20)
                .HasColumnName("Users_Modify");
            entity.Property(e => e.UsersNew)
                .HasMaxLength(20)
                .HasColumnName("Users_New");
        });

        modelBuilder.Entity<KhachHangDmChamDiemKh>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("KhachHang_DM_ChamDiemKH");

            entity.HasIndex(e => e.Id, "UQ__KhachHan__3214EC2653A6EC5F").IsUnique();

            entity.Property(e => e.ChiTieu).HasMaxLength(255);
            entity.Property(e => e.GhiChu).HasMaxLength(200);
            entity.Property(e => e.GroupBieu)
                .HasMaxLength(20)
                .HasColumnName("Group_bieu");
            entity.Property(e => e.GroupDm)
                .HasMaxLength(20)
                .HasColumnName("Group_DM");
            entity.Property(e => e.Id)
                .HasMaxLength(20)
                .HasColumnName("ID");
        });

        modelBuilder.Entity<KhachHangDmChamDiemKhChiTiet>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("KhachHang_DM_ChamDiemKH_ChiTiet");

            entity.HasIndex(e => e.Id, "UQ__KhachHan__3214EC2657777D43").IsUnique();

            entity.Property(e => e.ChiTieuId)
                .HasMaxLength(255)
                .HasColumnName("ChiTieu_ID");
            entity.Property(e => e.Diem).HasMaxLength(200);
            entity.Property(e => e.Id)
                .HasMaxLength(20)
                .HasColumnName("ID");
            entity.Property(e => e.MucChiTieu).HasMaxLength(255);
        });

        modelBuilder.Entity<KhachHangDmChamDiemKhXepLoai>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("KhachHang_DM_ChamDiemKH_XepLoai");

            entity.Property(e => e.DanhGia).HasMaxLength(50);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.IsChoVay)
                .HasMaxLength(50)
                .HasColumnName("isChoVay");
            entity.Property(e => e.MaxXl).HasColumnName("MaxXL");
            entity.Property(e => e.MinXl).HasColumnName("MinXL");
            entity.Property(e => e.XepLoai)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<KhachHangNguoiLq>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("KhachHang_NguoiLQ");

            entity.Property(e => e.KhId0)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KH_ID_0");
            entity.Property(e => e.KhId1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KH_ID_1");
            entity.Property(e => e.QhId).HasColumnName("QH_ID");
        });

        modelBuilder.Entity<KhachHangTinhLaiCp>(entity =>
        {
            entity.HasKey(e => e.MaId).HasName("PK__KhachHang_TinhLa__3B9207D9");

            entity.ToTable("KhachHang_TinhLaiCP");

            entity.Property(e => e.MaId).HasColumnName("ma_id");
            entity.Property(e => e.CoPhanGdId)
                .HasMaxLength(20)
                .HasColumnName("CoPhanGD_ID");
            entity.Property(e => e.CpThuongNien)
                .HasDefaultValueSql("((0))")
                .HasColumnName("cp_thuong_nien");
            entity.Property(e => e.CpThuongXuyen)
                .HasDefaultValueSql("((0))")
                .HasColumnName("cp_thuong_xuyen");
            entity.Property(e => e.CpXacLap)
                .HasDefaultValueSql("((0))")
                .HasColumnName("cp_xac_lap");
            entity.Property(e => e.DateModify)
                .HasColumnType("datetime")
                .HasColumnName("Date_Modify");
            entity.Property(e => e.DateNew)
                .HasColumnType("datetime")
                .HasColumnName("Date_New");
            entity.Property(e => e.DienGiaiTn).HasColumnName("DienGiai_TN");
            entity.Property(e => e.DienGiaiTx).HasColumnName("DienGiai_TX");
            entity.Property(e => e.DienGiaiXl).HasColumnName("DienGiai_XL");
            entity.Property(e => e.KhachhangId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("khachhang_ID");
            entity.Property(e => e.LaiConLai).HasColumnName("lai_con_lai");
            entity.Property(e => e.LaiCpThuongNien)
                .HasDefaultValueSql("((0))")
                .HasColumnName("lai_cp_thuong_nien");
            entity.Property(e => e.LaiCpThuongXuyen)
                .HasDefaultValueSql("((0))")
                .HasColumnName("lai_cp_thuong_xuyen");
            entity.Property(e => e.LaiCpXacLap)
                .HasDefaultValueSql("((0))")
                .HasColumnName("lai_cp_xac_lap");
            entity.Property(e => e.Ngay)
                .HasColumnType("datetime")
                .HasColumnName("ngay");
            entity.Property(e => e.ThuathieuKytruoc).HasColumnName("thuathieu_kytruoc");
            entity.Property(e => e.Thue)
                .HasDefaultValueSql("((0))")
                .HasColumnName("thue");
            entity.Property(e => e.TongLai)
                .HasDefaultValueSql("((0))")
                .HasColumnName("tong_lai");
            entity.Property(e => e.TrangThai)
                .HasDefaultValueSql("((0))")
                .HasColumnName("trang_thai");
            entity.Property(e => e.UsersModify)
                .HasMaxLength(20)
                .HasColumnName("Users_Modify");
            entity.Property(e => e.UsersNew)
                .HasMaxLength(20)
                .HasColumnName("Users_New");
        });

        modelBuilder.Entity<KhachhangCpChoDuyet>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("khachhang_CpChoDuyet");

            entity.Property(e => e.ChinhanhId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("chinhanh_id");
            entity.Property(e => e.CpThuongNien).HasColumnName("cp_thuong_nien");
            entity.Property(e => e.CpThuongXuyen).HasColumnName("cp_thuong_xuyen");
            entity.Property(e => e.CpXacLap).HasColumnName("cp_xac_lap");
            entity.Property(e => e.DateModify)
                .HasColumnType("datetime")
                .HasColumnName("Date_Modify");
            entity.Property(e => e.DateNew)
                .HasColumnType("datetime")
                .HasColumnName("Date_New");
            entity.Property(e => e.DienGiaiTn).HasColumnName("DienGiai_TN");
            entity.Property(e => e.DienGiaiTx).HasColumnName("DienGiai_TX");
            entity.Property(e => e.DienGiaiXl).HasColumnName("DienGiai_XL");
            entity.Property(e => e.KhachhangId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("khachhang_ID");
            entity.Property(e => e.LaiCpThuongNien).HasColumnName("lai_cp_thuong_nien");
            entity.Property(e => e.LaiCpThuongXuyen).HasColumnName("lai_cp_thuong_xuyen");
            entity.Property(e => e.LaiCpXacLap).HasColumnName("lai_cp_xac_lap");
            entity.Property(e => e.MaId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ma_id");
            entity.Property(e => e.Ngay)
                .HasColumnType("datetime")
                .HasColumnName("ngay");
            entity.Property(e => e.NgayDuyet)
                .HasColumnType("datetime")
                .HasColumnName("Ngay_Duyet");
            entity.Property(e => e.ObjectId)
                .HasMaxLength(20)
                .HasColumnName("object_id");
            entity.Property(e => e.ThuathieuKytruoc).HasColumnName("thuathieu_kytruoc");
            entity.Property(e => e.Thue).HasColumnName("thue");
            entity.Property(e => e.TongLai).HasColumnName("tong_lai");
            entity.Property(e => e.TrangThai).HasColumnName("trang_thai");
            entity.Property(e => e.UsersModify)
                .HasMaxLength(20)
                .HasColumnName("Users_Modify");
            entity.Property(e => e.UsersNew)
                .HasMaxLength(20)
                .HasColumnName("Users_New");
        });

        modelBuilder.Entity<KhachhangIdcard>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Khachhang_IDCard");

            entity.Property(e => e.DateModify)
                .HasColumnType("datetime")
                .HasColumnName("Date_Modify");
            entity.Property(e => e.DateNew)
                .HasColumnType("datetime")
                .HasColumnName("Date_New");
            entity.Property(e => e.GhiChu)
                .HasMaxLength(100)
                .HasColumnName("Ghi_chu");
            entity.Property(e => e.KhachhangId)
                .HasMaxLength(50)
                .HasColumnName("Khachhang_id");
            entity.Property(e => e.KhachhangIdcard1)
                .HasMaxLength(50)
                .HasColumnName("Khachhang_IDCard");
            entity.Property(e => e.LoaiThe).HasColumnName("Loai_the");
            entity.Property(e => e.NgayCap)
                .HasColumnType("datetime")
                .HasColumnName("Ngay_Cap");
            entity.Property(e => e.UsersModify)
                .HasMaxLength(20)
                .HasColumnName("Users_Modify");
            entity.Property(e => e.UsersNew)
                .HasMaxLength(20)
                .HasColumnName("Users_New");
        });

        modelBuilder.Entity<KhachhangRegInforDevice>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Khachhang_RegInforDevice");

            entity.Property(e => e.DateNew)
                .HasColumnType("datetime")
                .HasColumnName("Date_New");
            entity.Property(e => e.Handshake).HasMaxLength(50);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Parity).HasMaxLength(50);
            entity.Property(e => e.PortName).HasMaxLength(50);
            entity.Property(e => e.StopBits).HasMaxLength(50);
        });

        modelBuilder.Entity<KtoanChungTu>(entity =>
        {
            entity.HasKey(e => e.ChungTuGdId);

            entity.ToTable("KTOAN_Chung_Tu", tb => tb.HasTrigger("trg_GIAODICHKT_DEL"));

            entity.Property(e => e.ChungTuGdId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ChungTuGD_ID");
            entity.Property(e => e.ChiNhanhId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("ChiNhanh_id");
            entity.Property(e => e.CtuCmtNgay)
                .HasColumnType("smalldatetime")
                .HasColumnName("ctu_cmt_ngay");
            entity.Property(e => e.CtuCmtNoiCap)
                .HasMaxLength(50)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("ctu_cmt_noi_cap");
            entity.Property(e => e.CtuCmtSerial)
                .HasMaxLength(50)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("ctu_cmt_serial");
            entity.Property(e => e.CtuDiaChi)
                .HasMaxLength(50)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("ctu_dia_chi");
            entity.Property(e => e.CtuHoTen)
                .HasMaxLength(50)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("ctu_ho_ten");
            entity.Property(e => e.DateModify)
                .HasColumnType("datetime")
                .HasColumnName("Date_Modify");
            entity.Property(e => e.DateNew)
                .HasColumnType("datetime")
                .HasColumnName("Date_New");
            entity.Property(e => e.DienGiai)
                .HasMaxLength(200)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("dien_giai");
            entity.Property(e => e.DienGiai0)
                .HasMaxLength(100)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("dien_giai0");
            entity.Property(e => e.DienGiai1)
                .HasMaxLength(100)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("dien_giai1");
            entity.Property(e => e.DienGiai2)
                .HasMaxLength(100)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("dien_giai2");
            entity.Property(e => e.GiaoDichDcId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("GiaoDichDC_ID");
            entity.Property(e => e.IsLocked).HasColumnName("Is_Locked");
            entity.Property(e => e.IsSystem).HasColumnName("Is_System");
            entity.Property(e => e.MaChungTu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("ma_chung_tu");
            entity.Property(e => e.MaGiaoDich)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("ma_giao_dich");
            entity.Property(e => e.MaTkCo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("ma_tk_co");
            entity.Property(e => e.MaTkNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("ma_tk_no");
            entity.Property(e => e.Ngay)
                .HasColumnType("smalldatetime")
                .HasColumnName("ngay");
            entity.Property(e => e.Serial)
                .HasMaxLength(20)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("serial");
            entity.Property(e => e.SoPhatSinh).HasColumnName("so_phat_sinh");
            entity.Property(e => e.TienteMa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("tiente_ma");
            entity.Property(e => e.TienteTyGia)
                .HasDefaultValueSql("((1))")
                .HasColumnName("tiente_ty_gia");
            entity.Property(e => e.TrangThai).HasColumnName("trang_thai");
            entity.Property(e => e.UsersModify)
                .HasMaxLength(20)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Users_Modify");
            entity.Property(e => e.UsersNew)
                .HasMaxLength(20)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Users_New");
        });

        modelBuilder.Entity<ListClient>(entity =>
        {
            entity.HasKey(e => e.ComputerName);

            entity.ToTable(tb => tb.HasTrigger("trg_ListClients_Ins"));

            entity.Property(e => e.ComputerName).HasMaxLength(50);
            entity.Property(e => e.IsConnected).HasMaxLength(50);
            entity.Property(e => e.IsServer).HasMaxLength(50);
            entity.Property(e => e.LastUpdated).HasMaxLength(50);
            entity.Property(e => e.Updated).HasMaxLength(50);
            entity.Property(e => e.VersionDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ListHd>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ListHD");

            entity.Property(e => e.HinhThucTstcId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("HinhThucTSTC_ID");
            entity.Property(e => e.HinhThucTstcTen)
                .HasMaxLength(255)
                .HasColumnName("HinhThucTSTC_Ten");
            entity.Property(e => e.HosoTdId)
                .HasMaxLength(20)
                .HasColumnName("HosoTD_ID");
            entity.Property(e => e.KhachHangId)
                .HasMaxLength(20)
                .HasColumnName("KhachHangID");
            entity.Property(e => e.KhuvucMa)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("khuvuc_ma");
            entity.Property(e => e.KhuvucTen)
                .HasMaxLength(255)
                .HasColumnName("khuvuc_ten");
            entity.Property(e => e.LaiDaThu).HasColumnName("lai_da_thu");
            entity.Property(e => e.LaiSuat).HasColumnName("Lai_Suat");
            entity.Property(e => e.LoaiHinhKinhTeId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("loai_hinh_kinh_te_id");
            entity.Property(e => e.LoaiVayId).HasColumnName("Loai_vay_id");
            entity.Property(e => e.MaThongKe0)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ma_thong_ke0");
            entity.Property(e => e.MaThongKe1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ma_thong_ke1");
            entity.Property(e => e.MucDichVay)
                .HasMaxLength(1000)
                .HasColumnName("Muc_dich_vay");
            entity.Property(e => e.MucDichVayId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("muc_dich_vay_id");
            entity.Property(e => e.NganHan).HasColumnName("Ngan_han");
            entity.Property(e => e.NganhNgheKdMa)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("NganhNgheKD_Ma");
            entity.Property(e => e.NganhNgheKdTen)
                .HasMaxLength(1000)
                .HasColumnName("NganhNgheKD_Ten");
            entity.Property(e => e.NgayDaoHan)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Ngay_Dao_Han");
            entity.Property(e => e.NgayGiaHan)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Ngay_gia_han");
            entity.Property(e => e.NgayVay)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ngay_vay");
            entity.Property(e => e.NhomNo).HasColumnName("Nhom_no");
            entity.Property(e => e.SanPhamTdId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SanPhamTD_ID");
            entity.Property(e => e.SoDu).HasColumnName("So_Du");
            entity.Property(e => e.SoDuThu).HasColumnName("So_Du_Thu");
            entity.Property(e => e.SoHopDong)
                .HasMaxLength(20)
                .HasColumnName("So_Hop_Dong");
            entity.Property(e => e.TenNguoiVay)
                .HasMaxLength(100)
                .HasColumnName("Ten_Nguoi_Vay");
            entity.Property(e => e.TenNhomTk0)
                .HasMaxLength(255)
                .HasColumnName("TenNhomTK0");
            entity.Property(e => e.TenNhomTk1)
                .HasMaxLength(255)
                .HasColumnName("TenNhomTK1");
            entity.Property(e => e.TenTaiKhoan)
                .HasMaxLength(255)
                .HasColumnName("Ten_tai_khoan");
            entity.Property(e => e.TkTinDung)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TK_Tin_Dung");
            entity.Property(e => e.TrungHan).HasColumnName("Trung_han");
            entity.Property(e => e.TstcTriGia).HasColumnName("TSTC_Tri_gia");
        });

        modelBuilder.Entity<ListKhTietkiem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("list_kh_tietkiem");

            entity.Property(e => e.KhId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("kh_id");
            entity.Property(e => e.TongSodu).HasColumnName("tong_sodu");
        });

        modelBuilder.Entity<NgayTemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ngay_temp");

            entity.Property(e => e.Ngay)
                .HasColumnType("datetime")
                .HasColumnName("ngay_");
        });

        modelBuilder.Entity<Ngaylamviec>(entity =>
        {
            entity.HasKey(e => e.NgayLamViecMa).HasName("PK_SYS_NgayLamViec");

            entity.ToTable("NGAYLAMVIEC");

            entity.Property(e => e.NgayLamViecMa).HasColumnName("NgayLamViec_Ma");
            entity.Property(e => e.IsCurrent).HasDefaultValueSql("((0))");
            entity.Property(e => e.Locked).HasDefaultValueSql("((0))");
            entity.Property(e => e.NgayLamViec1)
                .HasColumnType("smalldatetime")
                .HasColumnName("NgayLamViec");
        });

        modelBuilder.Entity<NgoaiteGiaodich>(entity =>
        {
            entity.HasKey(e => e.GiaodichId).HasName("PK_Ngoaite_Giaodich_Giaodich");

            entity.ToTable("Ngoaite_Giaodich");

            entity.Property(e => e.GiaodichId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Giaodich_ID");
            entity.Property(e => e.ChinhanhId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("Chinhanh_ID");
            entity.Property(e => e.DateModify)
                .HasColumnType("datetime")
                .HasColumnName("Date_Modify");
            entity.Property(e => e.DateNew)
                .HasColumnType("datetime")
                .HasColumnName("Date_New");
            entity.Property(e => e.GhiChu)
                .HasMaxLength(500)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Ghi_Chu");
            entity.Property(e => e.LoaiGiaoDichId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Loai_Giao_Dich_ID");
            entity.Property(e => e.MaTkCo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Ma_TK_Co");
            entity.Property(e => e.MaTkNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Ma_TK_No");
            entity.Property(e => e.Ngay).HasColumnType("smalldatetime");
            entity.Property(e => e.NgoaiteId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Ngoaite_ID");
            entity.Property(e => e.NgoaiteSoTien)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Ngoaite_SoTien");
            entity.Property(e => e.SoChungTu)
                .HasMaxLength(20)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("So_Chung_Tu");
            entity.Property(e => e.TrangThai)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Trang_Thai");
            entity.Property(e => e.Tygia).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.UsersModify)
                .HasMaxLength(20)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Users_Modify");
            entity.Property(e => e.UsersNew)
                .HasMaxLength(20)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Users_New");
        });

        modelBuilder.Entity<NgoaiteSodu>(entity =>
        {
            entity.HasKey(e => new { e.MaTk, e.Ngay }).HasName("PK_Ngoaite");

            entity.ToTable("Ngoaite_Sodu");

            entity.Property(e => e.MaTk)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ma_tk");
            entity.Property(e => e.Ngay)
                .HasColumnType("datetime")
                .HasColumnName("ngay");
            entity.Property(e => e.ChinhanhId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("chinhanh_id");
            entity.Property(e => e.CoCuoiKy)
                .HasDefaultValueSql("((0))")
                .HasColumnName("co_cuoi_ky");
            entity.Property(e => e.CoDauKy)
                .HasDefaultValueSql("((0))")
                .HasColumnName("co_dau_ky");
            entity.Property(e => e.CoDauNam).HasColumnName("co_dau_nam");
            entity.Property(e => e.CoLuyKe).HasColumnName("co_luy_ke");
            entity.Property(e => e.CoTrongKy)
                .HasDefaultValueSql("((0))")
                .HasColumnName("co_trong_ky");
            entity.Property(e => e.DateModify)
                .HasColumnType("datetime")
                .HasColumnName("Date_Modify");
            entity.Property(e => e.DateNew)
                .HasColumnType("datetime")
                .HasColumnName("Date_New");
            entity.Property(e => e.NoCuoiKy)
                .HasDefaultValueSql("((0))")
                .HasColumnName("no_cuoi_ky");
            entity.Property(e => e.NoDauKy)
                .HasDefaultValueSql("((0))")
                .HasColumnName("no_dau_ky");
            entity.Property(e => e.NoDauNam).HasColumnName("no_dau_nam");
            entity.Property(e => e.NoLuyKe).HasColumnName("no_luy_ke");
            entity.Property(e => e.NoTrongKy)
                .HasDefaultValueSql("((0))")
                .HasColumnName("no_trong_ky");
            entity.Property(e => e.UsersModify)
                .HasMaxLength(20)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Users_Modify");
            entity.Property(e => e.UsersNew)
                .HasMaxLength(20)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Users_New");
        });

        modelBuilder.Entity<NhanSuChamCongDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("NhanSu_ChamCong_Detail");

            entity.Property(e => e.CN01)
                .HasMaxLength(50)
                .HasColumnName("C_N_01");
            entity.Property(e => e.CN02)
                .HasMaxLength(50)
                .HasColumnName("C_N_02");
            entity.Property(e => e.CN03)
                .HasMaxLength(50)
                .HasColumnName("C_N_03");
            entity.Property(e => e.CN04)
                .HasMaxLength(50)
                .HasColumnName("C_N_04");
            entity.Property(e => e.CN05)
                .HasMaxLength(50)
                .HasColumnName("C_N_05");
            entity.Property(e => e.CN06)
                .HasMaxLength(50)
                .HasColumnName("C_N_06");
            entity.Property(e => e.CN07)
                .HasMaxLength(50)
                .HasColumnName("C_N_07");
            entity.Property(e => e.CN08)
                .HasMaxLength(50)
                .HasColumnName("C_N_08");
            entity.Property(e => e.CN09)
                .HasMaxLength(50)
                .HasColumnName("C_N_09");
            entity.Property(e => e.CN10)
                .HasMaxLength(50)
                .HasColumnName("C_N_10");
            entity.Property(e => e.CN11)
                .HasMaxLength(50)
                .HasColumnName("C_N_11");
            entity.Property(e => e.CN12)
                .HasMaxLength(50)
                .HasColumnName("C_N_12");
            entity.Property(e => e.CN13)
                .HasMaxLength(50)
                .HasColumnName("C_N_13");
            entity.Property(e => e.CN14)
                .HasMaxLength(50)
                .HasColumnName("C_N_14");
            entity.Property(e => e.CN15)
                .HasMaxLength(50)
                .HasColumnName("C_N_15");
            entity.Property(e => e.CN16)
                .HasMaxLength(50)
                .HasColumnName("C_N_16");
            entity.Property(e => e.CN17)
                .HasMaxLength(50)
                .HasColumnName("C_N_17");
            entity.Property(e => e.CN18)
                .HasMaxLength(50)
                .HasColumnName("C_N_18");
            entity.Property(e => e.CN19)
                .HasMaxLength(50)
                .HasColumnName("C_N_19");
            entity.Property(e => e.CN20)
                .HasMaxLength(50)
                .HasColumnName("C_N_20");
            entity.Property(e => e.CN21)
                .HasMaxLength(50)
                .HasColumnName("C_N_21");
            entity.Property(e => e.CN22)
                .HasMaxLength(50)
                .HasColumnName("C_N_22");
            entity.Property(e => e.CN23)
                .HasMaxLength(50)
                .HasColumnName("C_N_23");
            entity.Property(e => e.CN24)
                .HasMaxLength(50)
                .HasColumnName("C_N_24");
            entity.Property(e => e.CN25)
                .HasMaxLength(50)
                .HasColumnName("C_N_25");
            entity.Property(e => e.CN26)
                .HasMaxLength(50)
                .HasColumnName("C_N_26");
            entity.Property(e => e.CN27)
                .HasMaxLength(50)
                .HasColumnName("C_N_27");
            entity.Property(e => e.CN28)
                .HasMaxLength(50)
                .HasColumnName("C_N_28");
            entity.Property(e => e.CN29)
                .HasMaxLength(50)
                .HasColumnName("C_N_29");
            entity.Property(e => e.CN30)
                .HasMaxLength(50)
                .HasColumnName("C_N_30");
            entity.Property(e => e.CN31)
                .HasMaxLength(50)
                .HasColumnName("C_N_31");
            entity.Property(e => e.CongId)
                .HasMaxLength(50)
                .HasColumnName("Cong_Id");
            entity.Property(e => e.NgayCong).HasColumnName("Ngay_Cong");
            entity.Property(e => e.NgayNghi).HasColumnName("Ngay_nghi");
            entity.Property(e => e.SN01)
                .HasMaxLength(50)
                .HasColumnName("S_N_01");
            entity.Property(e => e.SN02)
                .HasMaxLength(50)
                .HasColumnName("S_N_02");
            entity.Property(e => e.SN03)
                .HasMaxLength(50)
                .HasColumnName("S_N_03");
            entity.Property(e => e.SN04)
                .HasMaxLength(50)
                .HasColumnName("S_N_04");
            entity.Property(e => e.SN05)
                .HasMaxLength(50)
                .HasColumnName("S_N_05");
            entity.Property(e => e.SN06)
                .HasMaxLength(50)
                .HasColumnName("S_N_06");
            entity.Property(e => e.SN07)
                .HasMaxLength(50)
                .HasColumnName("S_N_07");
            entity.Property(e => e.SN08)
                .HasMaxLength(50)
                .HasColumnName("S_N_08");
            entity.Property(e => e.SN09)
                .HasMaxLength(50)
                .HasColumnName("S_N_09");
            entity.Property(e => e.SN10)
                .HasMaxLength(50)
                .HasColumnName("S_N_10");
            entity.Property(e => e.SN11)
                .HasMaxLength(50)
                .HasColumnName("S_N_11");
            entity.Property(e => e.SN12)
                .HasMaxLength(50)
                .HasColumnName("S_N_12");
            entity.Property(e => e.SN13)
                .HasMaxLength(50)
                .HasColumnName("S_N_13");
            entity.Property(e => e.SN14)
                .HasMaxLength(50)
                .HasColumnName("S_N_14");
            entity.Property(e => e.SN15)
                .HasMaxLength(50)
                .HasColumnName("S_N_15");
            entity.Property(e => e.SN16)
                .HasMaxLength(50)
                .HasColumnName("S_N_16");
            entity.Property(e => e.SN17)
                .HasMaxLength(50)
                .HasColumnName("S_N_17");
            entity.Property(e => e.SN18)
                .HasMaxLength(50)
                .HasColumnName("S_N_18");
            entity.Property(e => e.SN19)
                .HasMaxLength(50)
                .HasColumnName("S_N_19");
            entity.Property(e => e.SN20)
                .HasMaxLength(50)
                .HasColumnName("S_N_20");
            entity.Property(e => e.SN21)
                .HasMaxLength(50)
                .HasColumnName("S_N_21");
            entity.Property(e => e.SN22)
                .HasMaxLength(50)
                .HasColumnName("S_N_22");
            entity.Property(e => e.SN23)
                .HasMaxLength(50)
                .HasColumnName("S_N_23");
            entity.Property(e => e.SN24)
                .HasMaxLength(50)
                .HasColumnName("S_N_24");
            entity.Property(e => e.SN25)
                .HasMaxLength(50)
                .HasColumnName("S_N_25");
            entity.Property(e => e.SN26)
                .HasMaxLength(50)
                .HasColumnName("S_N_26");
            entity.Property(e => e.SN27)
                .HasMaxLength(50)
                .HasColumnName("S_N_27");
            entity.Property(e => e.SN28)
                .HasMaxLength(50)
                .HasColumnName("S_N_28");
            entity.Property(e => e.SN29)
                .HasMaxLength(50)
                .HasColumnName("S_N_29");
            entity.Property(e => e.SN30)
                .HasMaxLength(50)
                .HasColumnName("S_N_30");
            entity.Property(e => e.SN31)
                .HasMaxLength(50)
                .HasColumnName("S_N_31");
        });

        modelBuilder.Entity<NhanSuCtthue>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("NhanSu_CTThue");

            entity.Property(e => e.DateModify)
                .HasColumnType("datetime")
                .HasColumnName("Date_Modify");
            entity.Property(e => e.DateNew)
                .HasColumnType("datetime")
                .HasColumnName("Date_New");
            entity.Property(e => e.GiamTru).HasColumnName("Giam_tru");
            entity.Property(e => e.KhachhangId)
                .HasMaxLength(50)
                .HasColumnName("Khachhang_ID");
            entity.Property(e => e.LuongTinhThue).HasColumnName("Luong_tinh_thue");
            entity.Property(e => e.NgayGd)
                .HasColumnType("datetime")
                .HasColumnName("Ngay_GD");
            entity.Property(e => e.NgayThue)
                .HasColumnType("datetime")
                .HasColumnName("Ngay_Thue");
            entity.Property(e => e.ThueId)
                .ValueGeneratedOnAdd()
                .HasColumnName("Thue_ID");
            entity.Property(e => e.ThueTncn).HasColumnName("Thue_TNCN");
            entity.Property(e => e.TongLuong).HasColumnName("Tong_luong");
            entity.Property(e => e.UsersModify)
                .HasMaxLength(20)
                .HasColumnName("Users_Modify");
            entity.Property(e => e.UsersNew)
                .HasMaxLength(20)
                .HasColumnName("Users_New");
        });

        modelBuilder.Entity<NhanSuDmLuongThuongPc>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("NhanSu_DM_LuongThuongPC");

            entity.Property(e => e.GhiChu)
                .HasMaxLength(200)
                .HasColumnName("Ghi_chu");
            entity.Property(e => e.GiaTri).HasColumnName("Gia_tri");
            entity.Property(e => e.Ma).HasMaxLength(50);
            entity.Property(e => e.MaLoai)
                .HasMaxLength(50)
                .HasColumnName("Ma_loai");
            entity.Property(e => e.Ten).HasMaxLength(50);
            entity.Property(e => e.TenTat)
                .HasMaxLength(50)
                .HasColumnName("Ten_tat");
            entity.Property(e => e.TinhChat)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("Tinh_chat");
            entity.Property(e => e.TkCo)
                .HasMaxLength(50)
                .HasColumnName("Tk_co");
            entity.Property(e => e.TkNo)
                .HasMaxLength(50)
                .HasColumnName("Tk_no");
            entity.Property(e => e.TyLe).HasColumnName("Ty_le");
        });

        modelBuilder.Entity<NhanSuDmthueTncn>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("NhanSu_DMThue_TNCN");

            entity.Property(e => e.BacThue)
                .HasMaxLength(50)
                .HasColumnName("Bac_thue");
            entity.Property(e => e.GhiChu)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("Ghi_chu");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.TenBac)
                .HasMaxLength(50)
                .HasColumnName("Ten_Bac");
            entity.Property(e => e.ThueSuat).HasColumnName("Thue_suat");
        });

        modelBuilder.Entity<NhansuChamCong>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Nhansu_ChamCong");

            entity.Property(e => e.AnCa).HasColumnName("An_Ca");
            entity.Property(e => e.ClAnca)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("Cl_Anca");
            entity.Property(e => e.CongId)
                .HasMaxLength(50)
                .HasColumnName("Cong_ID");
            entity.Property(e => e.DateModify)
                .HasColumnType("datetime")
                .HasColumnName("Date_modify");
            entity.Property(e => e.DateNew)
                .HasColumnType("datetime")
                .HasColumnName("Date_New");
            entity.Property(e => e.DongiaCong)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("Dongia_Cong");
            entity.Property(e => e.KhachhangId)
                .HasMaxLength(50)
                .HasColumnName("Khachhang_ID");
            entity.Property(e => e.LuongNgayLe)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("Luong_ngayLe");
            entity.Property(e => e.LuongT7cn)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("Luong_T7CN");
            entity.Property(e => e.LuongThemgio)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("Luong_themgio");
            entity.Property(e => e.LuongTinhtoan)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("Luong_tinhtoan");
            entity.Property(e => e.Ngay).HasColumnType("datetime");
            entity.Property(e => e.NgayCong).HasColumnName("Ngay_cong");
            entity.Property(e => e.NgayLe)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("Ngay_le");
            entity.Property(e => e.Songaylamviec).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.T7Cn)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("T7_Cn");
            entity.Property(e => e.ThemGio)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("Them_gio");
            entity.Property(e => e.TongLamthem)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("Tong_lamthem");
            entity.Property(e => e.UsersModify)
                .HasMaxLength(50)
                .HasColumnName("Users_modify");
            entity.Property(e => e.UsersNew)
                .HasMaxLength(50)
                .HasColumnName("users_New");
        });

        modelBuilder.Entity<NhansuDmLoai>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Nhansu_DM_Loai");

            entity.Property(e => e.Ma).HasMaxLength(50);
            entity.Property(e => e.MaNhom)
                .HasMaxLength(50)
                .HasColumnName("Ma_nhom");
            entity.Property(e => e.Ten).HasMaxLength(50);
        });

        modelBuilder.Entity<NhansuDmtk>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Nhansu_DMTK");

            entity.Property(e => e.KhachhangId)
                .HasMaxLength(50)
                .HasColumnName("Khachhang_ID");
            entity.Property(e => e.Tk1)
                .HasMaxLength(50)
                .HasColumnName("TK1");
            entity.Property(e => e.Tk2)
                .HasMaxLength(50)
                .HasColumnName("TK2");
            entity.Property(e => e.Tk3)
                .HasMaxLength(50)
                .HasColumnName("TK3");
            entity.Property(e => e.Tk4)
                .HasMaxLength(50)
                .HasColumnName("TK4");
            entity.Property(e => e.Tk5)
                .HasMaxLength(50)
                .HasColumnName("TK5");
        });

        modelBuilder.Entity<NhansuLuongTt>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Nhansu_luongTT");

            entity.Property(e => e.AnCa).HasColumnName("An_Ca");
            entity.Property(e => e.AnCaQd)
                .HasDefaultValueSql("((730000))")
                .HasColumnName("AnCa_QD");
            entity.Property(e => e.GhiChu)
                .HasMaxLength(200)
                .HasColumnName("Ghi_chu");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.LuongTt).HasColumnName("Luong_TT");
            entity.Property(e => e.SoNgay).HasColumnName("So_ngay");
            entity.Property(e => e.TuNgay)
                .HasColumnType("datetime")
                .HasColumnName("Tu_ngay");
            entity.Property(e => e.TyLeTinhLuong)
                .HasDefaultValueSql("((80))")
                .HasColumnType("numeric(10, 4)")
                .HasColumnName("TyLe_TinhLuong");
            entity.Property(e => e.TyleBhtnNv)
                .HasDefaultValueSql("((1))")
                .HasColumnName("Tyle_BHTN_NV");
            entity.Property(e => e.TyleBhtnQ).HasColumnName("Tyle_BHTN_Q");
            entity.Property(e => e.TyleBhxhNv)
                .HasDefaultValueSql("((8))")
                .HasColumnName("Tyle_BHXH_NV");
            entity.Property(e => e.TyleBhxhQ).HasColumnName("Tyle_BHXH_Q");
            entity.Property(e => e.TyleBhytNv)
                .HasDefaultValueSql("((1.5))")
                .HasColumnName("Tyle_BHYT_NV");
            entity.Property(e => e.TyleBhytQ).HasColumnName("Tyle_BHYT_Q");
            entity.Property(e => e.TyleDangPhiNv).HasColumnName("Tyle_DangPhi_NV");
            entity.Property(e => e.TyleDangPhiQ).HasColumnName("Tyle_DangPhi_Q");
            entity.Property(e => e.TyleDoanPhiNv).HasColumnName("Tyle_DoanPhi_NV");
            entity.Property(e => e.TyleDoanPhiQ).HasColumnName("Tyle_DoanPhi_Q");
            entity.Property(e => e.TyleKpcdNv)
                .HasDefaultValueSql("((1))")
                .HasColumnName("Tyle_KPCD_NV");
            entity.Property(e => e.TyleKpcdQ).HasColumnName("Tyle_KPCD_Q");
        });

        modelBuilder.Entity<NhansuTkHachtoan>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Nhansu_TK_Hachtoan");

            entity.Property(e => e.Label).HasMaxLength(50);
            entity.Property(e => e.TaiKhoanCo)
                .HasMaxLength(50)
                .HasColumnName("Tai_khoan_co");
            entity.Property(e => e.TaiKhoanNo)
                .HasMaxLength(50)
                .HasColumnName("Tai_khoan_no");
        });

        modelBuilder.Entity<NhomNo>(entity =>
        {
            entity.ToTable("Nhom_No");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.DateModify)
                .HasColumnType("datetime")
                .HasColumnName("Date_Modify");
            entity.Property(e => e.DateNew)
                .HasColumnType("datetime")
                .HasColumnName("Date_New");
            entity.Property(e => e.DpChung).HasColumnName("DP_chung");
            entity.Property(e => e.DpCuThe).HasColumnName("DP_cu_the");
            entity.Property(e => e.Len).HasColumnName("len");
            entity.Property(e => e.NhomNo1).HasColumnName("Nhom_No");
            entity.Property(e => e.Startindex).HasColumnName("startindex");
            entity.Property(e => e.UserModify)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("User_Modify");
            entity.Property(e => e.UsersNew)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Users_New");
        });

        modelBuilder.Entity<NqGiaoDich>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("NQ_GiaoDich", tb => tb.HasTrigger("trg_GIAODICH_NganQuy_DEL"));

            entity.Property(e => e.ChiNhanhId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ChiNhanh_ID");
            entity.Property(e => e.DateModify).HasColumnType("datetime");
            entity.Property(e => e.DateNew).HasColumnType("datetime");
            entity.Property(e => e.GiaoDichId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GiaoDichID");
            entity.Property(e => e.IsGd).HasColumnName("Is_GD");
            entity.Property(e => e.LoaiGiaoDich)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Loai_Giao_Dich");
            entity.Property(e => e.LoaiTienId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("LoaiTienID");
            entity.Property(e => e.Ngay).HasColumnType("datetime");
            entity.Property(e => e.SoChungTu)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TienTe)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TkTm)
                .HasMaxLength(50)
                .HasColumnName("TK_TM");
            entity.Property(e => e.UsersModify)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UsersNew)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<NqGiaoDichSum>(entity =>
        {
            entity.HasKey(e => new { e.KiemKeId, e.GiaoDichId });

            entity.ToTable("NQ_GiaoDich_Sum");

            entity.Property(e => e.KiemKeId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KiemKeID");
            entity.Property(e => e.GiaoDichId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GiaoDichID");
            entity.Property(e => e.DateModify).HasColumnType("datetime");
            entity.Property(e => e.DateNew)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UsersModify)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UsersNew)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<NqQuyTienMat>(entity =>
        {
            entity.HasKey(e => new { e.LoaiTienId, e.Ngay });

            entity.ToTable("NQ_QuyTienMat");

            entity.Property(e => e.LoaiTienId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("loai_tien_id");
            entity.Property(e => e.Ngay)
                .HasColumnType("datetime")
                .HasColumnName("ngay");
            entity.Property(e => e.Chi).HasColumnName("chi");
            entity.Property(e => e.ChinhanhId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("chinhanh_id");
            entity.Property(e => e.DateNew).HasColumnType("datetime");
            entity.Property(e => e.Thu).HasColumnName("thu");
            entity.Property(e => e.TonCuoiKy).HasColumnName("ton_cuoi_ky");
            entity.Property(e => e.TonDauKy).HasColumnName("ton_dau_ky");
            entity.Property(e => e.UserNew)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<NqThongTinGd>(entity =>
        {
            entity.HasKey(e => e.GiaoDichId);

            entity.ToTable("NQ_ThongTinGD");

            entity.Property(e => e.GiaoDichId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GiaoDich_ID");
            entity.Property(e => e.CmtNgayCap)
                .HasColumnType("datetime")
                .HasColumnName("CMT_NgayCap");
            entity.Property(e => e.CmtNoiCap)
                .HasMaxLength(255)
                .HasColumnName("CMT_NoiCap");
            entity.Property(e => e.CmtSerial)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CMT_Serial");
            entity.Property(e => e.DiaChi).HasMaxLength(255);
            entity.Property(e => e.DienThoai)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MaKh)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MaKH");
            entity.Property(e => e.NoiDung).HasMaxLength(255);
            entity.Property(e => e.TenKh)
                .HasMaxLength(255)
                .HasColumnName("TenKH");
        });

        modelBuilder.Entity<NsNghiepVuGd>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("NS_NghiepVu_GD");

            entity.Property(e => e.ChinhanhId)
                .HasMaxLength(50)
                .HasColumnName("Chinhanh_ID");
            entity.Property(e => e.DateModify).HasColumnType("datetime");
            entity.Property(e => e.DateNew).HasColumnType("datetime");
            entity.Property(e => e.DienGiai)
                .HasMaxLength(200)
                .HasColumnName("Dien_giai");
            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .HasColumnName("ID");
            entity.Property(e => e.KhachhangId)
                .HasMaxLength(50)
                .HasColumnName("Khachhang_Id");
            entity.Property(e => e.LoaiGiaoDich)
                .HasMaxLength(50)
                .HasColumnName("Loai_giao_dich");
            entity.Property(e => e.MaTk)
                .HasMaxLength(50)
                .HasColumnName("Ma_Tk");
            entity.Property(e => e.NgayGd)
                .HasColumnType("datetime")
                .HasColumnName("Ngay_gd");
            entity.Property(e => e.NghiepVuId)
                .HasMaxLength(50)
                .HasColumnName("Nghiep_vu_Id");
            entity.Property(e => e.SoChungTu)
                .HasMaxLength(50)
                .HasColumnName("So_chung_tu");
            entity.Property(e => e.SoTien).HasColumnName("So_tien");
            entity.Property(e => e.UserModify).HasMaxLength(50);
            entity.Property(e => e.UserNew).HasMaxLength(50);
        });

        modelBuilder.Entity<Ozekimessagein>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ozekimessagein", tb => tb.HasTrigger("trgAfterInsert_SMS_IN"));

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Msg)
                .HasMaxLength(160)
                .IsUnicode(false)
                .HasColumnName("msg");
            entity.Property(e => e.Msgtype)
                .HasMaxLength(160)
                .IsUnicode(false)
                .HasColumnName("msgtype");
            entity.Property(e => e.Operator)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("operator");
            entity.Property(e => e.Receivedtime)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("receivedtime");
            entity.Property(e => e.Receiver)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("receiver");
            entity.Property(e => e.Reference)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("reference");
            entity.Property(e => e.Sender)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("sender");
            entity.Property(e => e.Senttime)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("senttime");
        });

        modelBuilder.Entity<Ozekimessageout>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ozekimessageout");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Msg)
                .HasMaxLength(160)
                .IsUnicode(false)
                .HasColumnName("msg");
            entity.Property(e => e.Msgtype)
                .HasMaxLength(160)
                .IsUnicode(false)
                .HasColumnName("msgtype");
            entity.Property(e => e.NgayDenHan)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Ngay_Den_Han");
            entity.Property(e => e.Operator)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("operator");
            entity.Property(e => e.Receivedtime)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("receivedtime");
            entity.Property(e => e.Receiver)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("receiver");
            entity.Property(e => e.Reference)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("reference");
            entity.Property(e => e.Sender)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("sender");
            entity.Property(e => e.Senttime)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("senttime");
            entity.Property(e => e.SoHd)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SoHD");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("status");
        });

        modelBuilder.Entity<Permission>(entity =>
        {
            entity.HasKey(e => e.PermissionId).HasName("PK_MENU_PERMISSION");

            entity.ToTable("PERMISSIONS");

            entity.Property(e => e.PermissionId).HasColumnName("PermissionID");
            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.IsControlInfor)
                .HasDefaultValueSql("((0))")
                .HasColumnName("isControl_Infor");
            entity.Property(e => e.PermissionDescription).HasMaxLength(100);
            entity.Property(e => e.PermissionKey).HasMaxLength(50);
            entity.Property(e => e.PermissionName).HasMaxLength(100);
        });

        modelBuilder.Entity<QtdChitietLichsuNhansu>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("QTD_Chitiet_Lichsu_Nhansu");

            entity.Property(e => e.DonviThoihan).HasColumnName("Donvi_thoihan");
            entity.Property(e => e.IsActived).HasColumnName("Is_Actived");
            entity.Property(e => e.KhachHangId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("KhachHang_ID");
            entity.Property(e => e.LoaiHd).HasColumnName("Loai_HD");
            entity.Property(e => e.LoaiThoiHan).HasColumnName("Loai_ThoiHan");
            entity.Property(e => e.Ngay).HasColumnType("smalldatetime");
            entity.Property(e => e.NhanSuChucVu)
                .HasMaxLength(50)
                .HasColumnName("NhanSu_ChucVu");
            entity.Property(e => e.NhanSuGhichu)
                .HasMaxLength(50)
                .HasColumnName("NhanSu_ghichu");
            entity.Property(e => e.NhanSuHeSoLuong).HasColumnName("NhanSu_HeSoLuong");
            entity.Property(e => e.NhanSuTrinhDo)
                .HasMaxLength(50)
                .HasColumnName("NhanSu_TrinhDo");
            entity.Property(e => e.PhongbanId)
                .HasMaxLength(50)
                .HasColumnName("Phongban_ID");
            entity.Property(e => e.SoHdld)
                .HasMaxLength(50)
                .HasColumnName("So_HDLD");
            entity.Property(e => e.ThoiHan).HasColumnName("Thoi_han");
        });

        modelBuilder.Entity<QtdNhanSuCtluong>(entity =>
        {
            entity.HasKey(e => e.LuongId).HasName("PK_QTD_NhanSu_CTLuong_1");

            entity.ToTable("QTD_NhanSu_CTLuong");

            entity.Property(e => e.LuongId).HasColumnName("Luong_Id");
            entity.Property(e => e.BhtnNv)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("BHTN_NV");
            entity.Property(e => e.BhtnQ)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("BHTN_Q");
            entity.Property(e => e.BhxhNv)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("BHXH_NV");
            entity.Property(e => e.BhxhQ)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("BHXH_Q");
            entity.Property(e => e.BhytNv)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("BHYT_NV");
            entity.Property(e => e.BhytQ)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("BHYT_Q");
            entity.Property(e => e.ClAnca)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("Cl_Anca");
            entity.Property(e => e.DangPhiNv).HasColumnName("DangPhi_NV");
            entity.Property(e => e.DangPhiQ).HasColumnName("DangPhi_Q");
            entity.Property(e => e.DateModify)
                .HasColumnType("datetime")
                .HasColumnName("Date_Modify");
            entity.Property(e => e.DateNew)
                .HasColumnType("datetime")
                .HasColumnName("Date_New");
            entity.Property(e => e.DoanPhiNv).HasColumnName("DoanPhi_NV");
            entity.Property(e => e.DoanPhiQ).HasColumnName("DoanPhi_Q");
            entity.Property(e => e.GiamTru)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("Giam_tru");
            entity.Property(e => e.GiaodichId)
                .HasMaxLength(50)
                .HasColumnName("Giaodich_ID");
            entity.Property(e => e.HeSo)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("he_so");
            entity.Property(e => e.HsTn)
                .HasColumnType("numeric(10, 4)")
                .HasColumnName("Hs_TN");
            entity.Property(e => e.HsTrN)
                .HasColumnType("numeric(10, 4)")
                .HasColumnName("Hs_TrN");
            entity.Property(e => e.KhachhangId)
                .HasMaxLength(50)
                .HasColumnName("Khachhang_ID");
            entity.Property(e => e.KpcdNv)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("KPCD_NV");
            entity.Property(e => e.KpcdQ)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("KPCD_Q");
            entity.Property(e => e.LamThem)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("Lam_them");
            entity.Property(e => e.LuongBhxh)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("luong_BHXH");
            entity.Property(e => e.LuongCb)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("Luong_CB");
            entity.Property(e => e.LuongKd)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("Luong_KD");
            entity.Property(e => e.LuongTinhThue)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("Luong_Tinh_thue");
            entity.Property(e => e.LuongTn)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("Luong_TN");
            entity.Property(e => e.LuongTrN)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("Luong_TrN");
            entity.Property(e => e.LuongTt)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("Luong_TT");
            entity.Property(e => e.NgayCong)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("Ngay_Cong");
            entity.Property(e => e.NgayGd)
                .HasColumnType("datetime")
                .HasColumnName("Ngay_GD");
            entity.Property(e => e.NgayTl)
                .HasColumnType("datetime")
                .HasColumnName("Ngay_TL");
            entity.Property(e => e.PhuCap)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("Phu_Cap");
            entity.Property(e => e.ThuHo)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("Thu_ho");
            entity.Property(e => e.ThucLinh)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("Thuc_linh");
            entity.Property(e => e.ThueTncn)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("Thue_TNCN");
            entity.Property(e => e.TntthueLamThem).HasColumnName("TNTThue_lamThem");
            entity.Property(e => e.TongCpNv)
                .HasColumnType("numeric(10, 4)")
                .HasColumnName("Tong_CP_NV");
            entity.Property(e => e.TongCpQ)
                .HasColumnType("numeric(10, 4)")
                .HasColumnName("Tong_CP_Q");
            entity.Property(e => e.TongLuong)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("Tong_luong");
            entity.Property(e => e.TyLeLkd).HasColumnName("TyLe_LKD");
            entity.Property(e => e.TyLeTinhLuong)
                .HasColumnType("numeric(10, 4)")
                .HasColumnName("TyLe_TinhLuong");
            entity.Property(e => e.UsersModify)
                .HasMaxLength(20)
                .HasColumnName("Users_Modify");
            entity.Property(e => e.UsersNew)
                .HasMaxLength(20)
                .HasColumnName("Users_New");
        });

        modelBuilder.Entity<QtdNhanSuLuong>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("QTD_NhanSuLuong");

            entity.Property(e => e.BhtnNv)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("BHTN_NV");
            entity.Property(e => e.BhtnQ)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("BHTN_Q");
            entity.Property(e => e.BhxhNv)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("BHXH_NV");
            entity.Property(e => e.BhxhQ)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("BHXH_Q");
            entity.Property(e => e.BhytNv)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("BHYT_NV");
            entity.Property(e => e.BhytQ)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("BHYT_Q");
            entity.Property(e => e.DangPhiNv).HasColumnName("DangPhi_NV");
            entity.Property(e => e.DangPhiQ).HasColumnName("dangPhi_Q");
            entity.Property(e => e.DoanPhiNv).HasColumnName("DoanPhi_NV");
            entity.Property(e => e.DoanPhiQ).HasColumnName("DoanPhi_Q");
            entity.Property(e => e.GiamTru)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("Giam_tru");
            entity.Property(e => e.HeSo)
                .HasColumnType("numeric(10, 4)")
                .HasColumnName("He_so");
            entity.Property(e => e.HsTn)
                .HasColumnType("numeric(10, 4)")
                .HasColumnName("Hs_TN");
            entity.Property(e => e.HsTrN)
                .HasColumnType("numeric(10, 4)")
                .HasColumnName("Hs_TrN");
            entity.Property(e => e.KhachhangId)
                .HasMaxLength(50)
                .HasColumnName("Khachhang_ID");
            entity.Property(e => e.KpcdNv)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("KPCD_NV");
            entity.Property(e => e.KpcdQ)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("KPCD_Q");
            entity.Property(e => e.LuongBhxh)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("luong_BHXH");
            entity.Property(e => e.LuongCb)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("Luong_CB");
            entity.Property(e => e.LuongKd)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("Luong_KD");
            entity.Property(e => e.LuongTinhThue)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("Luong_tinh_thue");
            entity.Property(e => e.LuongTn)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("Luong_TN");
            entity.Property(e => e.LuongTrN)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("Luong_TrN");
            entity.Property(e => e.LuongTt)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("Luong_TT");
            entity.Property(e => e.PhuCap).HasColumnName("phu_cap");
            entity.Property(e => e.ThueTncn)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("Thue_TNCN");
            entity.Property(e => e.TinhThue).HasColumnName("Tinh_thue");
            entity.Property(e => e.TlTinhBh)
                .HasColumnType("numeric(10, 4)")
                .HasColumnName("TL_Tinh_BH");
            entity.Property(e => e.ToiNgay)
                .HasColumnType("datetime")
                .HasColumnName("Toi_ngay");
            entity.Property(e => e.TongLuong)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("Tong_luong");
            entity.Property(e => e.TuNgay)
                .HasColumnType("datetime")
                .HasColumnName("Tu_ngay");
            entity.Property(e => e.TyLeLkd).HasColumnName("TyLe_LKD");
            entity.Property(e => e.TyLeTinhLuong)
                .HasColumnType("numeric(10, 4)")
                .HasColumnName("TyLe_TinhLuong");
            entity.Property(e => e.TyleBhtnNv)
                .HasColumnType("numeric(10, 4)")
                .HasColumnName("Tyle_BHTN_NV");
            entity.Property(e => e.TyleBhtnQ)
                .HasColumnType("numeric(10, 4)")
                .HasColumnName("Tyle_BHTN_Q");
            entity.Property(e => e.TyleBhxhNv)
                .HasColumnType("numeric(10, 4)")
                .HasColumnName("Tyle_BHXH_NV");
            entity.Property(e => e.TyleBhxhQ)
                .HasColumnType("numeric(10, 4)")
                .HasColumnName("Tyle_BHXH_Q");
            entity.Property(e => e.TyleBhytNv)
                .HasColumnType("numeric(10, 4)")
                .HasColumnName("Tyle_BHYT_NV");
            entity.Property(e => e.TyleBhytQ)
                .HasColumnType("numeric(10, 4)")
                .HasColumnName("Tyle_BHYT_Q");
            entity.Property(e => e.TyleDangPhiNv).HasColumnName("Tyle_DangPhi_NV");
            entity.Property(e => e.TyleDangPhiQ).HasColumnName("Tyle_DangPhi_Q");
            entity.Property(e => e.TyleDoanPhiNv).HasColumnName("Tyle_DoanPhi_NV");
            entity.Property(e => e.TyleDoanPhiQ).HasColumnName("Tyle_DoanPhi_Q");
            entity.Property(e => e.TyleKpcdNv)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("Tyle_KPCD_NV");
            entity.Property(e => e.TyleKpcdQ)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("Tyle_KPCD_Q");
        });

        modelBuilder.Entity<QtdNhanSuThuongPc>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("QTD_NhanSu_ThuongPC");

            entity.Property(e => e.DienGiai)
                .HasMaxLength(200)
                .HasColumnName("Dien_giai");
            entity.Property(e => e.GiaodichId)
                .HasMaxLength(50)
                .HasColumnName("Giaodich_ID");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.KhachhangId)
                .HasMaxLength(50)
                .HasColumnName("Khachhang_ID");
            entity.Property(e => e.MaThuong)
                .HasMaxLength(50)
                .HasColumnName("Ma_thuong");
            entity.Property(e => e.NgayGd)
                .HasColumnType("datetime")
                .HasColumnName("Ngay_GD");
            entity.Property(e => e.NgayTinh)
                .HasColumnType("datetime")
                .HasColumnName("Ngay_Tinh");
            entity.Property(e => e.SoThang).HasColumnName("So_thang");
            entity.Property(e => e.SoTien)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("So_tien");
            entity.Property(e => e.TinhChat).HasColumnName("Tinh_chat");
            entity.Property(e => e.TongHeso)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("Tong_Heso");
        });

        modelBuilder.Entity<QtdNhansu>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("QTD_NHANSU");

            entity.Property(e => e.DonviThoihan).HasColumnName("Donvi_thoihan");
            entity.Property(e => e.IsActived).HasColumnName("Is_Actived");
            entity.Property(e => e.KhachHangId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("KhachHang_ID");
            entity.Property(e => e.LoaiHd).HasColumnName("Loai_HD");
            entity.Property(e => e.LoaiThoiHan).HasColumnName("Loai_ThoiHan");
            entity.Property(e => e.NgayBd)
                .HasColumnType("datetime")
                .HasColumnName("Ngay_BD");
            entity.Property(e => e.NgayBhxh)
                .HasColumnType("datetime")
                .HasColumnName("Ngay_BHXH");
            entity.Property(e => e.NhanSuChucVu)
                .HasMaxLength(50)
                .HasColumnName("NhanSu_ChucVu");
            entity.Property(e => e.NhanSuDiaChi)
                .HasMaxLength(50)
                .HasColumnName("NhanSu_DiaChi");
            entity.Property(e => e.NhanSuGhichu)
                .HasMaxLength(50)
                .HasColumnName("NhanSu_ghichu");
            entity.Property(e => e.NhanSuHeSoLuong).HasColumnName("NhanSu_HeSoLuong");
            entity.Property(e => e.NhanSuTen)
                .HasMaxLength(50)
                .HasColumnName("NhanSu_Ten");
            entity.Property(e => e.NhanSuTrinhDo)
                .HasMaxLength(50)
                .HasColumnName("NhanSu_TrinhDo");
            entity.Property(e => e.PhongbanId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Phongban_ID");
            entity.Property(e => e.SoBhxh)
                .HasMaxLength(50)
                .HasColumnName("So_BHXH");
            entity.Property(e => e.SoHdld)
                .HasMaxLength(50)
                .HasColumnName("So_HDLD");
            entity.Property(e => e.ThoiHan).HasColumnName("Thoi_han");
        });

        modelBuilder.Entity<QtdPhongban>(entity =>
        {
            entity.HasKey(e => e.Ma);

            entity.ToTable("QTD_PHONGBAN");

            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.GhiChu)
                .HasMaxLength(255)
                .HasColumnName("Ghi_Chu");
            entity.Property(e => e.Ten).HasMaxLength(50);
            entity.Property(e => e.TenTat)
                .HasMaxLength(50)
                .HasColumnName("Ten_Tat");
        });

        modelBuilder.Entity<SktdExcel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SKTD_EXCEL");

            entity.Property(e => e.Cmnd)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasColumnName("CMND");
            entity.Property(e => e.DiaChi)
                .HasMaxLength(500)
                .HasDefaultValueSql("('')")
                .HasColumnName("DIA_CHI");
            entity.Property(e => e.DuNo)
                .HasDefaultValueSql("('')")
                .HasColumnName("DU_NO");
            entity.Property(e => e.GioiTinh)
                .HasDefaultValueSql("((0))")
                .HasColumnName("GIOI_TINH");
            entity.Property(e => e.HdHanmuc)
                .HasDefaultValueSql("((0))")
                .HasColumnName("HD_HANMUC");
            entity.Property(e => e.HdNgayDh)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("HD_NGAY_DH");
            entity.Property(e => e.HdNgayKy)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("HD_NGAY_KY");
            entity.Property(e => e.HdSo)
                .HasMaxLength(30)
                .HasDefaultValueSql("('')")
                .HasColumnName("HD_SO");
            entity.Property(e => e.HoTen)
                .HasMaxLength(255)
                .HasDefaultValueSql("('')")
                .HasColumnName("HO_TEN");
            entity.Property(e => e.KhachhangId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("khachhang_id");
            entity.Property(e => e.KuNgayDh)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("KU_NGAY_DH");
            entity.Property(e => e.KuNgayGiahan)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("KU_NGAY_GIAHAN");
            entity.Property(e => e.KuNgayKy)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("KU_NGAY_KY");
            entity.Property(e => e.KuNgayPs)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("KU_NGAY_PS");
            entity.Property(e => e.KuSo)
                .HasMaxLength(30)
                .HasDefaultValueSql("('')")
                .HasColumnName("KU_SO");
            entity.Property(e => e.LaiSuat)
                .HasDefaultValueSql("((0))")
                .HasColumnName("LAI_SUAT");
            entity.Property(e => e.LoaiKh)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LOAI_KH");
            entity.Property(e => e.LoaiVay)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LOAI_VAY");
            entity.Property(e => e.MaDv)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("MA_DV");
            entity.Property(e => e.MaSoThue)
                .HasMaxLength(30)
                .HasDefaultValueSql("('')")
                .HasColumnName("MA_SO_THUE");
            entity.Property(e => e.MaTv)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasColumnName("Ma_TV");
            entity.Property(e => e.MucDich)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("MUC_DICH");
            entity.Property(e => e.NgayCap)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("NGAY_CAP");
            entity.Property(e => e.NgaySinh)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("NGAY_SINH");
            entity.Property(e => e.NhomNo)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("NHOM_NO");
            entity.Property(e => e.TsGiatri).HasColumnName("TS_GIATRI");
            entity.Property(e => e.TsLoai)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TS_LOAI");
        });

        modelBuilder.Entity<SktkExcel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SKTK_EXCEL");

            entity.Property(e => e.Cmnd)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CMND");
            entity.Property(e => e.DiaChi)
                .HasMaxLength(500)
                .HasColumnName("DIA_CHI");
            entity.Property(e => e.HoTen)
                .HasMaxLength(255)
                .HasColumnName("HO_TEN");
            entity.Property(e => e.KhachhangId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KHACHHANG_ID");
            entity.Property(e => e.LaiSuat).HasColumnName("lai_suat");
            entity.Property(e => e.NgayDaoHan)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ngay_dao_han");
            entity.Property(e => e.NgayGui)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ngay_gui");
            entity.Property(e => e.SoDu).HasColumnName("so_du");
            entity.Property(e => e.SoTietKiem)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SO_TIET_KIEM");
            entity.Property(e => e.SoTietKiemId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SoTietKiem_ID");
            entity.Property(e => e.TkTietKiem)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TK_TIET_KIEM");
        });

        modelBuilder.Entity<SmsKhachhangSend>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SMS_Khachhang_Send");

            entity.Property(e => e.KhachHangId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KhachHang_Id");
            entity.Property(e => e.SendBdsdLng).HasColumnName("Send_bdsd_LNG");
            entity.Property(e => e.SendCskh).HasColumnName("Send_CSKH");
            entity.Property(e => e.SendLaiTd).HasColumnName("Send_LaiTD");
            entity.Property(e => e.SendSinhNhat).HasColumnName("Send_Sinh_nhat");
            entity.Property(e => e.SendTbdh).HasColumnName("Send_TBDH");
        });

        modelBuilder.Entity<SmsTemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("sms_temp");

            entity.Property(e => e.Diachi)
                .HasMaxLength(500)
                .HasColumnName("diachi");
            entity.Property(e => e.Ma)
                .HasMaxLength(50)
                .HasColumnName("ma");
            entity.Property(e => e.Sms)
                .HasMaxLength(200)
                .HasColumnName("sms");
            entity.Property(e => e.Sodienthoai)
                .HasMaxLength(50)
                .HasColumnName("sodienthoai");
            entity.Property(e => e.Ten)
                .HasMaxLength(50)
                .HasColumnName("ten");
        });

        modelBuilder.Entity<SmsZipCode>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SMS_ZipCode");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.IsLocked).HasColumnName("Is_locked");
            entity.Property(e => e.Zipcode)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')");
        });

        modelBuilder.Entity<Smsqueue>(entity =>
        {
            entity.HasKey(e => e.Uid);

            entity.ToTable("SMSQueue");

            entity.Property(e => e.ConnectionString)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DiaChi).HasMaxLength(255);
            entity.Property(e => e.MaKh)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MaKH");
            entity.Property(e => e.MsgType)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Noidung)
                .HasMaxLength(160)
                .IsUnicode(false);
            entity.Property(e => e.SoDienThoai)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.TenKh)
                .HasMaxLength(255)
                .HasColumnName("TenKH");
        });

        modelBuilder.Entity<SmsqueueBaoLaiTienVay>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SMSQueue_BaoLaiTienVay");

            entity.Property(e => e.MsgType)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.SmsMessage)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("sms_message");
            entity.Property(e => e.SmsNgay)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("sms_ngay");
            entity.Property(e => e.SoDienThoai)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.SoHdtd)
                .HasMaxLength(30)
                .HasColumnName("soHDTD");
            entity.Property(e => e.Sotienlai).HasColumnName("sotienlai");
            entity.Property(e => e.Uid).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Smssetting>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SMSSetting");

            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Loai)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<SmstietKiem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SMSTietKiem", tb => tb.HasTrigger("trgAfterInsert_SMSTietKiem"));

            entity.Property(e => e.LaiSuat).HasColumnName("Lai_suat");
            entity.Property(e => e.MaKhachHang)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Ma_Khach_Hang");
            entity.Property(e => e.MaThanhVien)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Ma_Thanh_Vien");
            entity.Property(e => e.NgayDenHan)
                .HasColumnType("datetime")
                .HasColumnName("Ngay_den_han");
            entity.Property(e => e.SoDt)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SoDT");
            entity.Property(e => e.SoDu).HasColumnName("So_du");
            entity.Property(e => e.StkSoTietKiem)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("STK_SoTietKiem");
            entity.Property(e => e.TenKhachHang)
                .HasMaxLength(255)
                .HasColumnName("Ten_KhachHang");
        });

        modelBuilder.Entity<Smstindung>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SMSTindung", tb => tb.HasTrigger("trgAfterInsert_SMSTinDung"));

            entity.Property(e => e.GocPhaiTra).HasColumnName("Goc_Phai_Tra");
            entity.Property(e => e.HosoTdId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("HosoTD_ID");
            entity.Property(e => e.MaKhachHang)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Ma_Khach_Hang");
            entity.Property(e => e.MaThanhVien)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Ma_Thanh_Vien");
            entity.Property(e => e.NgayDenHan)
                .HasColumnType("datetime")
                .HasColumnName("Ngay_Den_Han");
            entity.Property(e => e.SoDt)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SoDT");
            entity.Property(e => e.SoDu).HasColumnName("So_du");
            entity.Property(e => e.SoHopDong)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("So_Hop_Dong");
            entity.Property(e => e.TenNguoiVay)
                .HasMaxLength(255)
                .HasColumnName("Ten_nguoi_vay");
        });

        modelBuilder.Entity<SmstrangThai>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SMSTrangThai");

            entity.Property(e => e.LoaiDuLieu)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NgayLamViec)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TrangThai).HasComment("0: Chưa bắt đầu; 1: Đang làm; 2: Đã xong");
        });

        modelBuilder.Entity<SpDmChucVu>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SP_DM_ChucVu");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Ten).HasMaxLength(255);
            entity.Property(e => e.TenTat)
                .HasMaxLength(255)
                .HasColumnName("Ten_Tat");
        });

        modelBuilder.Entity<SpDmLoaiHoTro>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SP_DM_LoaiHoTro");

            entity.HasIndex(e => e.Ma, "UQ__SP_DM_Lo__3214CC9E391553B9").IsUnique();

            entity.Property(e => e.DienGiai).HasMaxLength(255);
        });

        modelBuilder.Entity<SpDmMucUuTien>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SP_DM_MucUuTien");

            entity.HasIndex(e => e.Ma, "UQ__SP_DM_Mu__3214CC9E3544C2D5").IsUnique();

            entity.Property(e => e.DienGiai).HasMaxLength(255);
        });

        modelBuilder.Entity<SpDmStatusSupport>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SP_DM_StatusSupport");

            entity.HasIndex(e => e.Ma, "UQ__SP_DM_St__3214CC9E3CE5E49D").IsUnique();

            entity.Property(e => e.DienGiai).HasMaxLength(255);
        });

        modelBuilder.Entity<SpInfoSupport>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SP_InfoSupport");

            entity.Property(e => e.CreateDateSupport).HasColumnType("datetime");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.IdRequest)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ID_Request");
            entity.Property(e => e.NoiDungSupport).HasMaxLength(2000);
            entity.Property(e => e.UpdateDateSupport).HasColumnType("datetime");
            entity.Property(e => e.UserSupport)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SpRequestSupport>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SP_RequestSupport");

            entity.HasIndex(e => e.Id, "UQ__SP_Reque__3214EC2640B67581").IsUnique();

            entity.Property(e => e.ChucVu).HasMaxLength(255);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.FileMau).HasMaxLength(255);
            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ID");
            entity.Property(e => e.MaLoaiHoTro).HasColumnName("Ma_LoaiHoTro");
            entity.Property(e => e.MaMucUuTien).HasColumnName("Ma_MucUuTien");
            entity.Property(e => e.MaQuy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.NoiDung).HasMaxLength(2000);
            entity.Property(e => e.NoiDungSupport).HasMaxLength(2000);
            entity.Property(e => e.Sdt)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SDT");
            entity.Property(e => e.TenCanBo).HasMaxLength(255);
            entity.Property(e => e.TenQuy).HasMaxLength(255);
            entity.Property(e => e.ThongTinKetNoi).HasMaxLength(255);
            entity.Property(e => e.TieuDe).HasMaxLength(255);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UserSupport).HasMaxLength(255);
        });

        modelBuilder.Entity<StkDuchiPhatsinh>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("STK_DUCHI_PHATSINH");

            entity.Property(e => e.CnId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CN_ID");
            entity.Property(e => e.GdtkMa2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("GDTK_MA2");
            entity.Property(e => e.Laiduchi).HasColumnName("LAIDUCHI");
            entity.Property(e => e.LaiduchiCu).HasColumnName("LAIDUCHI_CU");
            entity.Property(e => e.Ngayapdung)
                .HasColumnType("datetime")
                .HasColumnName("NGAYAPDUNG");
            entity.Property(e => e.NgayduchiCu)
                .HasColumnType("datetime")
                .HasColumnName("NGAYDUCHI_CU");
            entity.Property(e => e.Ngaylamviec)
                .HasColumnType("datetime")
                .HasColumnName("NGAYLAMVIEC");
            entity.Property(e => e.Sotietkiem)
                .HasMaxLength(50)
                .HasColumnName("SOTIETKIEM");
        });

        modelBuilder.Entity<SysBackupRestore>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("sys_backup_restore");

            entity.Property(e => e.CodeId).HasColumnName("code_id");
            entity.Property(e => e.DateCreate)
                .HasColumnType("datetime")
                .HasColumnName("date_create");
            entity.Property(e => e.DateModify)
                .HasColumnType("datetime")
                .HasColumnName("date_modify");
            entity.Property(e => e.DateRestore)
                .HasColumnType("datetime")
                .HasColumnName("date_restore");
            entity.Property(e => e.FileNames)
                .HasMaxLength(150)
                .HasColumnName("File_Names");
            entity.Property(e => e.UserCreate)
                .HasMaxLength(10)
                .HasColumnName("User_create");
            entity.Property(e => e.UserModify)
                .HasMaxLength(10)
                .HasColumnName("User_modify");
            entity.Property(e => e.UserRestore)
                .HasMaxLength(10)
                .HasColumnName("User_restore");
        });

        modelBuilder.Entity<SysDatabaseYear>(entity =>
        {
            entity.HasKey(e => e.Nam);

            entity.ToTable("sys_database_year");

            entity.Property(e => e.Nam)
                .ValueGeneratedNever()
                .HasColumnName("nam");
            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("active");
            entity.Property(e => e.EditDate)
                .HasColumnType("datetime")
                .HasColumnName("edit_date");
            entity.Property(e => e.GhiChu)
                .HasMaxLength(200)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("ghi_chu");
            entity.Property(e => e.Username)
                .HasMaxLength(20)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("username");
        });

        modelBuilder.Entity<SysExpFilter>(entity =>
        {
            entity.HasKey(e => e.MaId);

            entity.ToTable("sys_exp_filter");

            entity.Property(e => e.MaId).HasColumnName("ma_id");
            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("active");
            entity.Property(e => e.Filter)
                .HasMaxLength(100)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("filter");
            entity.Property(e => e.NameForm)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("name_form");
            entity.Property(e => e.Ten)
                .HasMaxLength(100)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("ten");
        });

        modelBuilder.Entity<SysGiaoDichId>(entity =>
        {
            entity.HasKey(e => e.Ngay).HasName("PK_Sys_Code_Giao_Dich");

            entity.ToTable("Sys_Giao_Dich_ID");

            entity.Property(e => e.Ngay)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("ngay");
            entity.Property(e => e.Number).HasColumnName("number");
        });

        modelBuilder.Entity<SysGridConfig>(entity =>
        {
            entity.HasKey(e => e.CodeId).HasName("PK_setupgrid_dic");

            entity.ToTable("sys_grid_config");

            entity.Property(e => e.CodeId)
                .HasMaxLength(4)
                .IsFixedLength()
                .HasColumnName("code_id");
            entity.Property(e => e.Alignment)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'ML')")
                .IsFixedLength()
                .HasColumnName("alignment");
            entity.Property(e => e.ColName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(N' ')")
                .HasColumnName("col_name");
            entity.Property(e => e.Enable)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("enable");
            entity.Property(e => e.Format)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("(N' ')")
                .HasColumnName("format");
            entity.Property(e => e.NameSource)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(N' ')")
                .HasColumnName("name_source");
            entity.Property(e => e.Readonly)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("readonly");
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N' ')")
                .HasColumnName("title");
            entity.Property(e => e.Tooltip)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N' ')")
                .HasColumnName("tooltip");
            entity.Property(e => e.TypeEditor)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'TextBox')")
                .HasColumnName("type_editor");
            entity.Property(e => e.Visible)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("visible");
            entity.Property(e => e.Width)
                .HasDefaultValueSql("((50))")
                .HasColumnName("width");
        });

        modelBuilder.Entity<SysLastCodeId>(entity =>
        {
            entity.HasKey(e => e.TableName);

            entity.ToTable("sys_last_code_id");

            entity.Property(e => e.TableName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("table_name");
            entity.Property(e => e.CodeId).HasColumnName("code_id");
            entity.Property(e => e.CodeSerial).HasColumnName("code_serial");
            entity.Property(e => e.GhiChu)
                .HasMaxLength(200)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("ghi_chu");
            entity.Property(e => e.Length)
                .HasDefaultValueSql("((4))")
                .HasColumnName("length");
            entity.Property(e => e.Prefix)
                .HasMaxLength(10)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("prefix");
            entity.Property(e => e.Suffix)
                .HasMaxLength(10)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("suffix");
        });

        modelBuilder.Entity<SysLogError>(entity =>
        {
            entity.HasKey(e => e.CodeId);

            entity.ToTable("sys_log_error");

            entity.Property(e => e.CodeId).HasColumnName("code_id");
            entity.Property(e => e.ErrorDate)
                .HasColumnType("datetime")
                .HasColumnName("error_date");
            entity.Property(e => e.ErrorNote)
                .HasMaxLength(150)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("error_note");
            entity.Property(e => e.IpAddr)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("ip_addr");
            entity.Property(e => e.Menus)
                .HasMaxLength(50)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("menus");
            entity.Property(e => e.UsersId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .IsFixedLength()
                .HasColumnName("usersID");
        });

        modelBuilder.Entity<SysLogModifyDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Sys_Log_ModifyData");

            entity.Property(e => e.Event).HasMaxLength(50);
            entity.Property(e => e.LoaiData)
                .HasMaxLength(50)
                .HasColumnName("Loai_Data");
            entity.Property(e => e.LyDo).HasColumnName("Ly_do");
            entity.Property(e => e.NgayModify)
                .HasColumnType("datetime")
                .HasColumnName("Ngay_Modify");
            entity.Property(e => e.NgayNew)
                .HasColumnType("datetime")
                .HasColumnName("Ngay_New");
            entity.Property(e => e.ObjectId)
                .HasMaxLength(50)
                .HasColumnName("Object_ID");
            entity.Property(e => e.ObjectName)
                .HasMaxLength(30)
                .HasColumnName("Object_Name");
            entity.Property(e => e.Stack)
                .ValueGeneratedOnAdd()
                .HasColumnName("STACK");
            entity.Property(e => e.UsersModify)
                .HasMaxLength(50)
                .HasColumnName("USERS_Modify");
            entity.Property(e => e.UsersNew)
                .HasMaxLength(50)
                .HasColumnName("USERS_New");
        });

        modelBuilder.Entity<SysLogXoaChungtu>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Sys_Log_XOA_CHUNGTU");

            entity.Property(e => e.DateModify)
                .HasColumnType("datetime")
                .HasColumnName("DATE_Modify");
            entity.Property(e => e.Event).HasMaxLength(50);
            entity.Property(e => e.GiaodichId)
                .HasMaxLength(50)
                .HasColumnName("Giaodich_Id");
            entity.Property(e => e.LoaiCt)
                .HasMaxLength(50)
                .HasColumnName("Loai_Ct");
            entity.Property(e => e.LyDo).HasColumnName("Ly_do");
            entity.Property(e => e.NgayCt)
                .HasColumnType("datetime")
                .HasColumnName("Ngay_Ct");
            entity.Property(e => e.NgayXoa)
                .HasColumnType("datetime")
                .HasColumnName("Ngay_Xoa");
            entity.Property(e => e.NoiDung).HasColumnName("Noi_Dung");
            entity.Property(e => e.SoChungTu)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.SoPhatSinh).HasColumnName("So_phat_sinh");
            entity.Property(e => e.Stack)
                .ValueGeneratedOnAdd()
                .HasColumnName("STACK");
            entity.Property(e => e.TrangThai).HasColumnName("Trang_thai");
            entity.Property(e => e.UsersDelete)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("USERS_Delete");
            entity.Property(e => e.UsersNew)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USERS_New");
        });

        modelBuilder.Entity<SysMaxTkctTheoMa>(entity =>
        {
            entity.HasKey(e => e.TkctMa);

            entity.ToTable("Sys_Max_TKCT_TheoMa");

            entity.Property(e => e.TkctMa)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TKCT_Ma");
            entity.Property(e => e.Number)
                .HasDefaultValueSql("((1))")
                .HasColumnName("number");
        });

        modelBuilder.Entity<SysMenu>(entity =>
        {
            entity.HasKey(e => e.MenuId).HasName("PK_sys_menu_main");

            entity.ToTable("sys_menu");

            entity.Property(e => e.MenuId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("menu_id");
            entity.Property(e => e.Caption)
                .HasMaxLength(100)
                .HasDefaultValueSql("(N' ')")
                .HasColumnName("caption");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .HasDefaultValueSql("(N' ')")
                .HasColumnName("description");
            entity.Property(e => e.Enable)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("enable");
            entity.Property(e => e.IconFile)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(N' ')")
                .HasColumnName("icon_file");
            entity.Property(e => e.LevelMenu)
                .HasDefaultValueSql("((1))")
                .HasColumnName("level_menu");
            entity.Property(e => e.ModuleName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(N' ')")
                .HasColumnName("module_name");
            entity.Property(e => e.NameMenu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(N' ')")
                .HasColumnName("name_menu");
            entity.Property(e => e.NotInModule)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("not_in_module");
            entity.Property(e => e.Parents)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(N' ')")
                .IsFixedLength()
                .HasColumnName("parents");
            entity.Property(e => e.ShortCut)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(N' ')")
                .HasColumnName("short_cut");
            entity.Property(e => e.Visible)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("visible");
        });

        modelBuilder.Entity<SysOptionSystem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("sys_option_system");

            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.OptionId)
                .HasMaxLength(50)
                .HasColumnName("OptionID");
            entity.Property(e => e.OptionValue).HasMaxLength(255);
        });

        modelBuilder.Entity<SysOwnerBranch>(entity =>
        {
            entity.HasKey(e => e.Ma);

            entity.ToTable("sys_owner_branch");

            entity.Property(e => e.Ma)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ma");
            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.Ten)
                .HasMaxLength(100)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("ten");
        });

        modelBuilder.Entity<SysReportConfig>(entity =>
        {
            entity.HasKey(e => e.MaId);

            entity.ToTable("sys_report_config");

            entity.Property(e => e.MaId).HasColumnName("ma_id");
            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.CheckMaCapPhat)
                .HasDefaultValueSql("((2))")
                .HasColumnName("check_ma_cap_phat");
            entity.Property(e => e.CheckMaChuong)
                .HasDefaultValueSql("((2))")
                .HasColumnName("check_ma_chuong");
            entity.Property(e => e.CheckMaCtmt)
                .HasDefaultValueSql("((2))")
                .HasColumnName("check_ma_ctmt");
            entity.Property(e => e.CheckMaDtpn)
                .HasDefaultValueSql("((2))")
                .HasColumnName("check_ma_dtpn");
            entity.Property(e => e.CheckMaDuAn)
                .HasDefaultValueSql("((2))")
                .HasColumnName("check_ma_du_an");
            entity.Property(e => e.CheckMaHdsn)
                .HasDefaultValueSql("((2))")
                .HasColumnName("check_ma_hdsn");
            entity.Property(e => e.CheckMaKhoan)
                .HasDefaultValueSql("((2))")
                .HasColumnName("check_ma_khoan");
            entity.Property(e => e.CheckMaLoai)
                .HasDefaultValueSql("((2))")
                .HasColumnName("check_ma_loai");
            entity.Property(e => e.CheckMaLoaiQuy)
                .HasDefaultValueSql("((2))")
                .HasColumnName("check_ma_loai_quy");
            entity.Property(e => e.CheckMaMuc)
                .HasDefaultValueSql("((2))")
                .HasColumnName("check_ma_muc");
            entity.Property(e => e.CheckMaNghiepVu)
                .HasDefaultValueSql("((2))")
                .HasColumnName("check_ma_nghiep_vu");
            entity.Property(e => e.CheckMaNguonKp)
                .HasDefaultValueSql("((2))")
                .HasColumnName("check_ma_nguon_kp");
            entity.Property(e => e.CheckMaTcNguonKp)
                .HasDefaultValueSql("((2))")
                .HasColumnName("check_ma_tc_nguon_kp");
            entity.Property(e => e.CheckMaTieuMuc)
                .HasDefaultValueSql("((2))")
                .HasColumnName("check_ma_tieu_muc");
            entity.Property(e => e.CheckMaTieuNhom)
                .HasDefaultValueSql("((2))")
                .HasColumnName("check_ma_tieu_nhom");
            entity.Property(e => e.CheckMaTk)
                .HasDefaultValueSql("((2))")
                .HasColumnName("check_ma_tk");
            entity.Property(e => e.CheckMaTkDu)
                .HasDefaultValueSql("((2))")
                .HasColumnName("check_ma_tk_du");
            entity.Property(e => e.CheckTimeReport).HasColumnName("check_time_report");
            entity.Property(e => e.DefaultFilter)
                .HasMaxLength(200)
                .HasColumnName("default_filter");
            entity.Property(e => e.DienGiai)
                .HasMaxLength(200)
                .HasColumnName("dien_giai");
            entity.Property(e => e.FileName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("file_name");
            entity.Property(e => e.FilterMaTk)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("filter_ma_tk");
            entity.Property(e => e.FilterNgay)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("filter_ngay");
            entity.Property(e => e.Groups)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("groups");
            entity.Property(e => e.IsChiTietCtu)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('Y')")
                .IsFixedLength()
                .HasColumnName("is_chi_tiet_ctu");
            entity.Property(e => e.IsDuToan)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('N')")
                .IsFixedLength()
                .HasColumnName("is_du_toan");
            entity.Property(e => e.IsSoDuDky)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('Y')")
                .IsFixedLength()
                .HasColumnName("is_so_du_dky");
            entity.Property(e => e.Label0)
                .HasMaxLength(50)
                .HasColumnName("label0");
            entity.Property(e => e.Label1)
                .HasMaxLength(50)
                .HasColumnName("label1");
            entity.Property(e => e.Label2)
                .HasMaxLength(50)
                .HasColumnName("label2");
            entity.Property(e => e.Label3)
                .HasMaxLength(50)
                .HasColumnName("label3");
            entity.Property(e => e.Label4)
                .HasMaxLength(50)
                .HasColumnName("label4");
            entity.Property(e => e.Label5)
                .HasMaxLength(50)
                .HasColumnName("label5");
            entity.Property(e => e.MauDescription)
                .HasMaxLength(200)
                .HasColumnName("mau_description");
            entity.Property(e => e.MauNumber)
                .HasMaxLength(100)
                .HasColumnName("mau_number");
            entity.Property(e => e.Modules)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("modules");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.NameOffice0)
                .HasMaxLength(100)
                .HasColumnName("name_office0");
            entity.Property(e => e.NameOffice1)
                .HasMaxLength(100)
                .HasColumnName("name_office1");
            entity.Property(e => e.PrintDatetime).HasColumnName("print_datetime");
            entity.Property(e => e.PrintSigner).HasColumnName("print_signer");
            entity.Property(e => e.ReportDescription)
                .HasMaxLength(200)
                .HasColumnName("report_description");
            entity.Property(e => e.Source0)
                .HasMaxLength(50)
                .HasColumnName("source0");
            entity.Property(e => e.Source1)
                .HasMaxLength(50)
                .HasColumnName("source1");
            entity.Property(e => e.Source2)
                .HasMaxLength(50)
                .HasColumnName("source2");
            entity.Property(e => e.Source3)
                .HasMaxLength(50)
                .HasColumnName("source3");
            entity.Property(e => e.Source4)
                .HasMaxLength(50)
                .HasColumnName("source4");
            entity.Property(e => e.Source5)
                .HasMaxLength(50)
                .HasColumnName("source5");
            entity.Property(e => e.StoredProcedure)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Subtitle)
                .HasMaxLength(100)
                .HasColumnName("subtitle");
            entity.Property(e => e.Title)
                .HasMaxLength(200)
                .HasColumnName("title");
        });

        modelBuilder.Entity<SysReportGroup>(entity =>
        {
            entity.HasKey(e => e.MaId);

            entity.ToTable("sys_report_group");

            entity.Property(e => e.MaId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .IsFixedLength()
                .HasColumnName("ma_id");
            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("active");
            entity.Property(e => e.EditDate)
                .HasColumnType("datetime")
                .HasColumnName("edit_date");
            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("ma");
            entity.Property(e => e.Ten)
                .HasMaxLength(100)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("ten");
            entity.Property(e => e.Username)
                .HasMaxLength(20)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("username");
        });

        modelBuilder.Entity<SysSoChungTuId>(entity =>
        {
            entity.HasKey(e => e.ChungTu);

            entity.ToTable("Sys_So_Chung_Tu_ID");

            entity.Property(e => e.ChungTu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("chung_tu");
            entity.Property(e => e.Number).HasColumnName("number");
        });

        modelBuilder.Entity<SysSoTscdId>(entity =>
        {
            entity.HasKey(e => e.Ngay).HasName("PK__Sys_So_TSCD_ID__502C987F");

            entity.ToTable("Sys_So_TSCD_ID");

            entity.Property(e => e.Ngay)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ngay");
            entity.Property(e => e.Number).HasColumnName("number");
        });

        modelBuilder.Entity<SysStackXoaChungtu>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Sys_STACK_XOA_CHUNGTU");

            entity.Property(e => e.ChungtuId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("ID của chứng từ tương ứng trường chung_tu ở bảng Sys_So_Chung_Tu_ID")
                .HasColumnName("CHUNGTU_ID");
            entity.Property(e => e.DateModify)
                .HasColumnType("datetime")
                .HasColumnName("DATE_MODIFY");
            entity.Property(e => e.Noidung)
                .HasComment("Nội dung của chứng từ được xóa")
                .HasColumnName("NOIDUNG");
            entity.Property(e => e.Sochungtu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("Là số chứng từ được xóa")
                .HasColumnName("SOCHUNGTU");
            entity.Property(e => e.Stack)
                .ValueGeneratedOnAdd()
                .HasColumnName("STACK");
            entity.Property(e => e.UsersName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USERS_NAME");
        });

        modelBuilder.Entity<SysStackXoaHoadon>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Sys_STACK_XOA_HOADON");

            entity.Property(e => e.ChungtuId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CHUNGTU_ID");
            entity.Property(e => e.Sohoadon)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SOHOADON");
            entity.Property(e => e.Stack)
                .ValueGeneratedOnAdd()
                .HasColumnName("STACK");
        });

        modelBuilder.Entity<SysSubsystem>(entity =>
        {
            entity.HasKey(e => e.CodeId);

            entity.ToTable("sys_subsystem");

            entity.Property(e => e.CodeId).HasColumnName("code_id");
            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.SubsysId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("(N' ')")
                .IsFixedLength()
                .HasColumnName("subsys_id");
            entity.Property(e => e.SubsysName)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N' ')")
                .HasColumnName("subsys_name");
        });

        modelBuilder.Entity<SysUser>(entity =>
        {
            entity.HasKey(e => e.UsersId);

            entity.ToTable("Sys_Users");

            entity.Property(e => e.UsersId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("UsersID");
            entity.Property(e => e.Checksum)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .IsFixedLength()
                .HasColumnName("checksum");
            entity.Property(e => e.EndDate)
                .HasColumnType("datetime")
                .HasColumnName("End_Date");
            entity.Property(e => e.FullName)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N' ')")
                .HasColumnName("Full_Name");
            entity.Property(e => e.Groups)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N' ')");
            entity.Property(e => e.IsFri)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("Is_Fri");
            entity.Property(e => e.IsMon)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("Is_Mon");
            entity.Property(e => e.IsSad)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("Is_Sad");
            entity.Property(e => e.IsSun)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("Is_Sun");
            entity.Property(e => e.IsThu)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("Is_Thu");
            entity.Property(e => e.IsTue)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("Is_Tue");
            entity.Property(e => e.IsWed)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("Is_Wed");
            entity.Property(e => e.MaDonVi)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .IsFixedLength()
                .HasColumnName("ma_don_vi");
            entity.Property(e => e.MaNhanVien)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .IsFixedLength()
                .HasColumnName("ma_nhan_vien");
            entity.Property(e => e.Note)
                .HasMaxLength(200)
                .HasDefaultValueSql("(N' ')");
            entity.Property(e => e.Passwords)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasDefaultValueSql("(N' ')")
                .IsFixedLength();
            entity.Property(e => e.StartDate)
                .HasColumnType("datetime")
                .HasColumnName("Start_Date");
            entity.Property(e => e.UserName)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N' ')")
                .HasColumnName("User_Name");
        });

        modelBuilder.Entity<SysUserRight>(entity =>
        {
            entity.HasKey(e => e.CodeId);

            entity.ToTable("Sys_User_Rights");

            entity.Property(e => e.CodeId).HasColumnName("code_id");
            entity.Property(e => e.IsAdd)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("is_add");
            entity.Property(e => e.IsDelete)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("is_delete");
            entity.Property(e => e.IsEdit)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("is_edit");
            entity.Property(e => e.IsView)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("is_view");
            entity.Property(e => e.NameMenu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("name_menu");
            entity.Property(e => e.UsersId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .IsFixedLength()
                .HasColumnName("UsersID");
        });

        modelBuilder.Entity<SysUserlogApp>(entity =>
        {
            entity.HasKey(e => e.CodeId);

            entity.ToTable("sys_userlog_app");

            entity.Property(e => e.CodeId).HasColumnName("code_id");
            entity.Property(e => e.EndDate)
                .HasColumnType("datetime")
                .HasColumnName("end_date");
            entity.Property(e => e.IpAddr)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .IsFixedLength()
                .HasColumnName("ip_addr");
            entity.Property(e => e.StartDate)
                .HasColumnType("datetime")
                .HasColumnName("start_date");
            entity.Property(e => e.UserName)
                .HasMaxLength(20)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("user_name");
        });

        modelBuilder.Entity<SysUserlogMenu>(entity =>
        {
            entity.HasKey(e => e.CodeId);

            entity.ToTable("sys_userlog_menus");

            entity.Property(e => e.CodeId).HasColumnName("code_id");
            entity.Property(e => e.EndDate)
                .HasColumnType("datetime")
                .HasColumnName("end_date");
            entity.Property(e => e.HandleForm)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(N' ')")
                .IsFixedLength()
                .HasColumnName("handle_form");
            entity.Property(e => e.IpAddr)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("(N' ')")
                .IsFixedLength()
                .HasColumnName("ip_addr");
            entity.Property(e => e.Menus)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N' ')")
                .HasColumnName("menus");
            entity.Property(e => e.StartDate)
                .HasColumnType("datetime")
                .HasColumnName("start_date");
            entity.Property(e => e.UserName)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N' ')")
                .HasColumnName("user_name");
        });

        modelBuilder.Entity<SysVariable>(entity =>
        {
            entity.HasKey(e => e.RecordId).HasName("PK_sys_variable");

            entity.ToTable("Sys_variable");

            entity.Property(e => e.RecordId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .IsFixedLength()
                .HasColumnName("record_id");
            entity.Property(e => e.Checksum)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .IsFixedLength()
                .HasColumnName("checksum");
            entity.Property(e => e.Comments)
                .HasMaxLength(100)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("comments");
            entity.Property(e => e.Defaulvalue)
                .HasMaxLength(100)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("defaulvalue");
            entity.Property(e => e.EditDate)
                .HasColumnType("datetime")
                .HasColumnName("edit_date");
            entity.Property(e => e.Groups)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("groups");
            entity.Property(e => e.Realvalue)
                .HasMaxLength(100)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("realvalue");
            entity.Property(e => e.Types)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('C')")
                .IsFixedLength()
                .HasColumnName("types");
            entity.Property(e => e.Username)
                .HasMaxLength(20)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("username");
            entity.Property(e => e.Variable)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("variable");
        });

        modelBuilder.Entity<SysVariableSupport>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Sys_Variable_Support");

            entity.HasIndex(e => e.Ma, "UQ__Sys_Vari__3213C8B648579749").IsUnique();

            entity.HasIndex(e => e.Variable, "UQ__Sys_Vari__5A5A8360457B2A9E").IsUnique();

            entity.Property(e => e.GhiChu)
                .HasMaxLength(255)
                .HasColumnName("ghiChu");
            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ma");
            entity.Property(e => e.Realvariable)
                .HasMaxLength(255)
                .HasColumnName("realvariable");
            entity.Property(e => e.Variable)
                .HasMaxLength(255)
                .HasColumnName("variable");
        });

        modelBuilder.Entity<TaikhoanCv7552>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TAIKHOAN_CV7552");

            entity.Property(e => e.BacTk).HasColumnName("Bac_TK");
            entity.Property(e => e.DateModify)
                .HasColumnType("datetime")
                .HasColumnName("Date_Modify");
            entity.Property(e => e.DateNew)
                .HasColumnType("datetime")
                .HasColumnName("Date_New");
            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ma");
            entity.Property(e => e.MaCha)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Ma_cha");
            entity.Property(e => e.Ten).HasMaxLength(255);
            entity.Property(e => e.TinhChat).HasColumnName("Tinh_chat");
            entity.Property(e => e.TkCanDoi)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TK_Can_Doi");
            entity.Property(e => e.TkNganHang)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TK_Ngan_Hang");
            entity.Property(e => e.UsersModify)
                .HasMaxLength(20)
                .HasColumnName("Users_Modify");
            entity.Property(e => e.UsersNew)
                .HasMaxLength(20)
                .HasColumnName("Users_New");
        });

        modelBuilder.Entity<TaikhoanCv7552Chitiet>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TAIKHOAN_CV7552_CHITIET");

            entity.Property(e => e.ChiNhanhId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ChiNhanh_ID");
            entity.Property(e => e.DateModify)
                .HasColumnType("datetime")
                .HasColumnName("Date_Modify");
            entity.Property(e => e.DateNew)
                .HasColumnType("datetime")
                .HasColumnName("Date_New");
            entity.Property(e => e.LoaiTk)
                .HasMaxLength(5)
                .HasColumnName("Loai_TK");
            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ma");
            entity.Property(e => e.MaTkTh)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ma_tk_th");
            entity.Property(e => e.Ngay).HasColumnType("datetime");
            entity.Property(e => e.SoDu).HasColumnName("So_Du");
            entity.Property(e => e.Ten)
                .HasMaxLength(250)
                .HasColumnName("ten");
            entity.Property(e => e.TienTeMa)
                .HasMaxLength(20)
                .HasColumnName("TienTe_Ma");
            entity.Property(e => e.TinhChat).HasColumnName("tinh_chat");
            entity.Property(e => e.TrangThai).HasColumnName("Trang_Thai");
            entity.Property(e => e.UsersModify)
                .HasMaxLength(20)
                .HasColumnName("Users_Modify");
            entity.Property(e => e.UsersNew)
                .HasMaxLength(20)
                .HasColumnName("Users_New");
        });

        modelBuilder.Entity<Tam01>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TAM01");

            entity.Property(e => e.DuThu).HasColumnName("du_thu");
            entity.Property(e => e.SoHopDong)
                .HasMaxLength(20)
                .HasColumnName("so_hop_dong");
        });

        modelBuilder.Entity<TbTempGiaoDich>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbTempGiaoDich");

            entity.Property(e => e.DienGiai).HasColumnName("Dien_giai");
            entity.Property(e => e.DuNo).HasColumnName("Du_no");
            entity.Property(e => e.Gdv)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GDV");
            entity.Property(e => e.LoaiChungTu).HasColumnName("Loai_chung_tu");
            entity.Property(e => e.NgayGd)
                .HasColumnType("datetime")
                .HasColumnName("NgayGD");
            entity.Property(e => e.SoChungTu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("So_chung_tu");
            entity.Property(e => e.SoTienChuyenNo).HasColumnName("So_tien_chuyen_no");
            entity.Property(e => e.SoTienVay).HasColumnName("So_tien_vay");
        });

        modelBuilder.Entity<TbTempPhatSinh>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbTempPhatSinh");

            entity.Property(e => e.DienGiai).HasColumnName("Dien_giai");
            entity.Property(e => e.Gdv)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GDV");
            entity.Property(e => e.GiaiNganId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GiaiNgan_ID");
            entity.Property(e => e.GiaoDichId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GiaoDich_ID");
            entity.Property(e => e.LoaiGiaoDich).HasColumnName("Loai_giao_dich");
            entity.Property(e => e.NgayGd)
                .HasColumnType("datetime")
                .HasColumnName("NgayGD");
            entity.Property(e => e.NgayTinh)
                .HasColumnType("datetime")
                .HasColumnName("Ngay_tinh");
            entity.Property(e => e.SoChungTu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("So_chung_tu");
            entity.Property(e => e.SoDu).HasColumnName("So_Du");
            entity.Property(e => e.SoTien).HasColumnName("So_tien");
            entity.Property(e => e.SoTienVay).HasColumnName("So_tien_vay");
        });

        modelBuilder.Entity<TblCauhinhgrid>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_cauhinhgrid");

            entity.Property(e => e.CAlign)
                .HasMaxLength(2)
                .HasColumnName("c_align");
            entity.Property(e => e.CDorong)
                .HasMaxLength(4)
                .HasColumnName("c_dorong");
            entity.Property(e => e.CFormat)
                .HasMaxLength(50)
                .HasColumnName("c_format");
            entity.Property(e => e.CKdl)
                .HasMaxLength(50)
                .HasColumnName("c_kdl");
            entity.Property(e => e.CMaxvalue)
                .HasMaxLength(50)
                .HasColumnName("c_maxvalue");
            entity.Property(e => e.CMinvalue)
                .HasMaxLength(50)
                .HasColumnName("c_minvalue");
            entity.Property(e => e.CMota)
                .HasMaxLength(100)
                .HasColumnName("c_mota");
            entity.Property(e => e.CReadonly)
                .HasMaxLength(5)
                .HasColumnName("c_readonly");
            entity.Property(e => e.CTengrid)
                .HasMaxLength(50)
                .HasColumnName("c_tengrid");
            entity.Property(e => e.CTentruong)
                .HasMaxLength(50)
                .HasColumnName("c_tentruong");
        });

        modelBuilder.Entity<TblNhatkythaydoidl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_nhatkythaydoidl");

            entity.Property(e => e.IdExport)
                .HasDefaultValueSql("((0))")
                .HasColumnName("id_export");
            entity.Property(e => e.IdRow)
                .HasMaxLength(250)
                .HasColumnName("id_row");
            entity.Property(e => e.Pk)
                .HasMaxLength(250)
                .HasColumnName("pk");
            entity.Property(e => e.Tenbang)
                .HasMaxLength(50)
                .HasColumnName("tenbang");
            entity.Property(e => e.Tenlenh)
                .HasMaxLength(10)
                .HasColumnName("tenlenh");
        });

        modelBuilder.Entity<TblTmpListAnchi>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_tmpListAnchi");

            entity.Property(e => e.AnchiTrangthai).HasColumnName("Anchi_Trangthai");
            entity.Property(e => e.ChinhanhMa)
                .HasMaxLength(10)
                .HasColumnName("chinhanh_ma");
            entity.Property(e => e.ChinhanhTen)
                .HasMaxLength(200)
                .HasColumnName("chinhanh_ten");
            entity.Property(e => e.KhachHangMa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KhachHang_Ma");
            entity.Property(e => e.KhachHangTen)
                .HasMaxLength(80)
                .HasColumnName("KhachHang_Ten");
            entity.Property(e => e.Ma)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.NgayNhap)
                .HasColumnType("datetime")
                .HasColumnName("Ngay_nhap");
            entity.Property(e => e.NgayXuatKho).HasColumnType("datetime");
            entity.Property(e => e.NgayXuatQuy).HasColumnType("datetime");
            entity.Property(e => e.Serial).HasMaxLength(50);
            entity.Property(e => e.SerialId)
                .HasMaxLength(50)
                .HasColumnName("Serial_Id");
            entity.Property(e => e.Taikhoan)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Ten).HasMaxLength(150);
            entity.Property(e => e.Tinhtrang).HasMaxLength(100);
        });

        modelBuilder.Entity<TctdDanhMucTctd>(entity =>
        {
            entity.HasKey(e => e.MaTctd);

            entity.ToTable("TCTD_DanhMucTCTD");

            entity.Property(e => e.MaTctd)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MaTCTD");
            entity.Property(e => e.ChiNhanh).HasMaxLength(255);
            entity.Property(e => e.Diachi).HasMaxLength(255);
            entity.Property(e => e.Masothue)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Sdt)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SDT");
            entity.Property(e => e.TenTctd)
                .HasMaxLength(255)
                .HasColumnName("TenTCTD");
        });

        modelBuilder.Entity<TctdgGiaingan>(entity =>
        {
            entity.HasKey(e => new { e.GnId, e.GiaoDichId });

            entity.ToTable("TCTDG_GIAINGAN");

            entity.Property(e => e.GnId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GN_ID");
            entity.Property(e => e.GiaoDichId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GiaoDich_ID");
            entity.Property(e => e.DateModify)
                .HasColumnType("datetime")
                .HasColumnName("Date_Modify");
            entity.Property(e => e.DateNew)
                .HasColumnType("datetime")
                .HasColumnName("Date_New");
            entity.Property(e => e.GiaoDichId2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GiaoDich_ID2");
            entity.Property(e => e.GnGhiChu)
                .HasMaxLength(500)
                .HasColumnName("GN_GhiChu");
            entity.Property(e => e.GnLoaiChungTu)
                .HasMaxLength(20)
                .HasColumnName("GN_LoaiChungTu");
            entity.Property(e => e.GnNgayGiaiNgan)
                .HasColumnType("smalldatetime")
                .HasColumnName("GN_NgayGiaiNgan");
            entity.Property(e => e.GnSoTien).HasColumnName("GN_SoTien");
            entity.Property(e => e.GnTkco)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GN_TKCo");
            entity.Property(e => e.GnTkno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GN_TKNo");
            entity.Property(e => e.HinhThucGnId).HasColumnName("HinhThucGN_ID");
            entity.Property(e => e.SoChungTu).HasMaxLength(20);
            entity.Property(e => e.UsersModify)
                .HasMaxLength(20)
                .HasColumnName("Users_Modify");
            entity.Property(e => e.UsersNew)
                .HasMaxLength(20)
                .HasColumnName("Users_New");
        });

        modelBuilder.Entity<TctdgGiaodich>(entity =>
        {
            entity.HasKey(e => e.GdtkMa);

            entity.ToTable("TCTDG_GIAODICH");

            entity.Property(e => e.GdtkMa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GDTK_Ma");
            entity.Property(e => e.DuChiCu)
                .HasColumnType("money")
                .HasColumnName("DuChi_Cu");
            entity.Property(e => e.GdtkDienGiai)
                .HasMaxLength(500)
                .HasDefaultValueSql("('')")
                .HasColumnName("GDTK_DienGiai");
            entity.Property(e => e.GdtkLoaiGiaoDichMa)
                .HasMaxLength(20)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("GDTK_LoaiGiaoDich_Ma");
            entity.Property(e => e.GdtkLoaiso)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValueSql("('TK')")
                .HasColumnName("GDTK_Loaiso");
            entity.Property(e => e.GdtkMa2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GDTK_Ma2");
            entity.Property(e => e.GdtkNgayApDung)
                .HasColumnType("datetime")
                .HasColumnName("GDTK_NgayApDung");
            entity.Property(e => e.GdtkNgayCapNhat)
                .HasColumnType("datetime")
                .HasColumnName("GDTK_NgayCapNhat");
            entity.Property(e => e.GdtkNgayGiaoDich)
                .HasColumnType("datetime")
                .HasColumnName("GDTK_NgayGiaoDich");
            entity.Property(e => e.GdtkNgayNhap)
                .HasColumnType("datetime")
                .HasColumnName("GDTK_NgayNhap");
            entity.Property(e => e.GdtkNguoiCapNhat)
                .HasMaxLength(20)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("GDTK_NguoiCapNhat");
            entity.Property(e => e.GdtkNguoiNhap)
                .HasMaxLength(20)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("GDTK_NguoiNhap");
            entity.Property(e => e.GdtkSoChungTu)
                .HasMaxLength(50)
                .HasColumnName("GDTK_SoChungTu");
            entity.Property(e => e.GdtkSoTien)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("GDTK_SoTien");
            entity.Property(e => e.GdtkSoTienDuChi)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("GDTK_SoTienDuChi");
            entity.Property(e => e.GdtkSoTietKiem)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasColumnName("GDTK_SoTietKiem");
            entity.Property(e => e.GdtkTrangThai)
                .HasDefaultValueSql("((0))")
                .HasColumnName("GDTK_TrangThai");
            entity.Property(e => e.LaiDaTraCu)
                .HasColumnType("money")
                .HasColumnName("LaiDaTra_Cu");
            entity.Property(e => e.LaiSuatCu)
                .HasColumnType("money")
                .HasColumnName("LaiSuat_Cu");
            entity.Property(e => e.NgayBatDauTinhLaiCu)
                .HasColumnType("datetime")
                .HasColumnName("NgayBatDauTinhLai_Cu");
            entity.Property(e => e.NgayDenHanCu)
                .HasColumnType("datetime")
                .HasColumnName("NgayDenHan_Cu");
            entity.Property(e => e.NgayDuChiCu)
                .HasColumnType("datetime")
                .HasColumnName("NgayDuChi_Cu");
            entity.Property(e => e.NgayKyMoiCu)
                .HasColumnType("datetime")
                .HasColumnName("NgayKyMoi_Cu");
            entity.Property(e => e.SanPhamMaCu)
                .HasMaxLength(20)
                .HasColumnName("SanPham_Ma_Cu");
            entity.Property(e => e.SoDuCu)
                .HasColumnType("money")
                .HasColumnName("SoDu_Cu");
            entity.Property(e => e.TienTeMa)
                .HasMaxLength(20)
                .HasDefaultValueSql("('00')")
                .HasColumnName("TienTe_Ma");
            entity.Property(e => e.TienTeTyGia)
                .HasDefaultValueSql("((1))")
                .HasColumnType("money")
                .HasColumnName("TienTe_TyGia");
        });

        modelBuilder.Entity<TctdgLaisuatsanpham>(entity =>
        {
            entity.HasKey(e => new { e.LsMa, e.SanPhamMa }).HasName("PK_TCTDG_LAISUAT");

            entity.ToTable("TCTDG_LAISUATSANPHAM");

            entity.Property(e => e.LsMa)
                .HasMaxLength(20)
                .HasColumnName("LS_Ma");
            entity.Property(e => e.SanPhamMa)
                .HasMaxLength(20)
                .HasColumnName("SanPham_Ma");
            entity.Property(e => e.LsDenNgay)
                .HasColumnType("datetime")
                .HasColumnName("LS_DenNgay");
            entity.Property(e => e.LsGhiChu)
                .HasMaxLength(255)
                .HasColumnName("LS_GhiChu");
            entity.Property(e => e.LsLaiSuat)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("LS_LaiSuat");
            entity.Property(e => e.LsNam)
                .HasColumnType("money")
                .HasColumnName("LS_Nam");
            entity.Property(e => e.LsTuNgay)
                .HasColumnType("datetime")
                .HasColumnName("LS_TuNgay");
        });

        modelBuilder.Entity<TctdgLaisuatstg>(entity =>
        {
            entity.HasKey(e => e.LsMa);

            entity.ToTable("TCTDG_LAISUATSTG");

            entity.Property(e => e.LsMa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("LS_Ma");
            entity.Property(e => e.LsGhiChu)
                .HasMaxLength(255)
                .HasColumnName("LS_GhiChu");
            entity.Property(e => e.LsLaiSuat)
                .HasColumnType("money")
                .HasColumnName("LS_LaiSuat");
            entity.Property(e => e.LsTuNgay)
                .HasColumnType("datetime")
                .HasColumnName("LS_TuNgay");
            entity.Property(e => e.StkMa)
                .HasMaxLength(20)
                .HasColumnName("STK_Ma");

            entity.HasOne(d => d.StkMaNavigation).WithMany(p => p.TctdgLaisuatstgs)
                .HasForeignKey(d => d.StkMa)
                .HasConstraintName("FK_TCTDG_LAISUATSTG_TCTDG_SOTIENGUI");
        });

        modelBuilder.Entity<TctdgLuukyhanmoi>(entity =>
        {
            entity.HasKey(e => e.GdtkMa);

            entity.ToTable("TCTDG_LUUKYHANMOI");

            entity.Property(e => e.GdtkMa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GDTK_Ma");
            entity.Property(e => e.LaiSuatMoi).HasColumnType("money");
            entity.Property(e => e.NgayBatDauKyMoi).HasColumnType("datetime");
            entity.Property(e => e.NgayBatDauTinhLai).HasColumnType("datetime");
            entity.Property(e => e.SanPhamMa)
                .HasMaxLength(20)
                .HasColumnName("SanPham_Ma");

            entity.HasOne(d => d.GdtkMaNavigation).WithOne(p => p.TctdgLuukyhanmoi)
                .HasForeignKey<TctdgLuukyhanmoi>(d => d.GdtkMa)
                .HasConstraintName("FK_TCTDG_LUUKYHANMOI_TCTDG_GIAODICH");
        });

        modelBuilder.Entity<TctdgSanpham>(entity =>
        {
            entity.HasKey(e => e.SanPhamMa).HasName("PK_TCTDG_SanPham");

            entity.ToTable("TCTDG_SANPHAM");

            entity.Property(e => e.SanPhamMa)
                .HasMaxLength(20)
                .HasColumnName("SanPham_Ma");
            entity.Property(e => e.DvkyHanMa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DVKyHan_Ma");
            entity.Property(e => e.LoaiSpMa)
                .HasMaxLength(20)
                .HasColumnName("LoaiSP_Ma");
            entity.Property(e => e.SanPhamGhiChu)
                .HasMaxLength(255)
                .HasColumnName("SanPham_GhiChu");
            entity.Property(e => e.SanPhamKyHan).HasColumnName("SanPham_KyHan");
            entity.Property(e => e.SanPhamNgayCn)
                .HasColumnType("datetime")
                .HasColumnName("SanPham_NgayCN");
            entity.Property(e => e.SanPhamNgayNhap)
                .HasColumnType("datetime")
                .HasColumnName("SanPham_NgayNhap");
            entity.Property(e => e.SanPhamNguoiCn)
                .HasMaxLength(20)
                .HasColumnName("SanPham_NguoiCN");
            entity.Property(e => e.SanPhamNguoiNhap)
                .HasMaxLength(20)
                .HasColumnName("SanPham_NguoiNhap");
            entity.Property(e => e.SanPhamTen)
                .HasMaxLength(255)
                .HasColumnName("SanPham_Ten");
            entity.Property(e => e.SanPhamTenTat)
                .HasMaxLength(20)
                .HasColumnName("SanPham_TenTat");
            entity.Property(e => e.TienTeMa)
                .HasMaxLength(20)
                .HasColumnName("TienTe_Ma");
            entity.Property(e => e.Tk1)
                .HasMaxLength(20)
                .HasColumnName("TK1");
            entity.Property(e => e.Tk2)
                .HasMaxLength(20)
                .HasColumnName("TK2");
            entity.Property(e => e.Tk3)
                .HasMaxLength(20)
                .HasColumnName("TK3");
            entity.Property(e => e.Tk4)
                .HasMaxLength(20)
                .HasColumnName("TK4");
            entity.Property(e => e.Tk5)
                .HasMaxLength(20)
                .HasColumnName("TK5");
            entity.Property(e => e.Tk6)
                .HasMaxLength(20)
                .HasColumnName("TK6");

            entity.HasOne(d => d.DvkyHanMaNavigation).WithMany(p => p.TctdgSanphams)
                .HasForeignKey(d => d.DvkyHanMa)
                .HasConstraintName("FK_TCTDG_SANPHAM_DM_DV_Ky_Han");
        });

        modelBuilder.Entity<TctdgSotiengui>(entity =>
        {
            entity.HasKey(e => e.StkMa);

            entity.ToTable("TCTDG_SOTIENGUI");

            entity.Property(e => e.StkMa)
                .HasMaxLength(20)
                .HasColumnName("STK_Ma");
            entity.Property(e => e.ChiNhanhMa)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("ChiNhanh_Ma");
            entity.Property(e => e.HttlMa)
                .HasMaxLength(20)
                .HasColumnName("HTTL_Ma");
            entity.Property(e => e.SanPhamMa)
                .HasMaxLength(20)
                .HasColumnName("SanPham_Ma");
            entity.Property(e => e.StkCoTheThayDoiLaiSuat).HasColumnName("STK_CoTheThayDoiLaiSuat");
            entity.Property(e => e.StkDaLaiNhapGoc)
                .HasDefaultValueSql("((0))")
                .HasColumnName("STK_DaLaiNhapGoc");
            entity.Property(e => e.StkDuthu)
                .HasColumnType("money")
                .HasColumnName("STK_Duthu");
            entity.Property(e => e.StkDuthuDenNgay)
                .HasColumnType("datetime")
                .HasColumnName("STK_DuthuDenNgay");
            entity.Property(e => e.StkGhiChu)
                .HasMaxLength(255)
                .HasColumnName("STK_GhiChu");
            entity.Property(e => e.StkLaiDaThu)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("STK_LaiDaThu");
            entity.Property(e => e.StkNgayBatDau)
                .HasColumnType("datetime")
                .HasColumnName("STK_NgayBatDau");
            entity.Property(e => e.StkNgayBatDauTinhLai)
                .HasColumnType("datetime")
                .HasColumnName("STK_NgayBatDauTinhLai");
            entity.Property(e => e.StkNgayCapNhat)
                .HasColumnType("datetime")
                .HasColumnName("STK_NgayCapNhat");
            entity.Property(e => e.StkNgayDenHan)
                .HasColumnType("datetime")
                .HasColumnName("STK_NgayDenHan");
            entity.Property(e => e.StkNgayKyMoi)
                .HasColumnType("datetime")
                .HasColumnName("STK_NgayKyMoi");
            entity.Property(e => e.StkNgayNhap)
                .HasColumnType("datetime")
                .HasColumnName("STK_NgayNhap");
            entity.Property(e => e.StkNgayPhongToa)
                .HasColumnType("datetime")
                .HasColumnName("STK_NgayPhongToa");
            entity.Property(e => e.StkNguoiCapNhat)
                .HasMaxLength(20)
                .HasColumnName("STK_NguoiCapNhat");
            entity.Property(e => e.StkNguoiNhap)
                .HasMaxLength(20)
                .HasColumnName("STK_NguoiNhap");
            entity.Property(e => e.StkPhongToa).HasColumnName("STK_PhongToa");
            entity.Property(e => e.StkSoDu)
                .HasColumnType("money")
                .HasColumnName("STK_SoDu");
            entity.Property(e => e.StkSoTietKiem)
                .HasMaxLength(20)
                .HasColumnName("STK_SoTietKiem");
            entity.Property(e => e.StkTen)
                .HasMaxLength(255)
                .HasColumnName("STK_Ten");
            entity.Property(e => e.StkTkct)
                .HasMaxLength(20)
                .HasColumnName("STK_TKCT");
            entity.Property(e => e.StkTrangThai).HasColumnName("STK_TrangThai");
            entity.Property(e => e.TctdMa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("TCTD_Ma");
            entity.Property(e => e.TienTeMa)
                .HasMaxLength(20)
                .HasColumnName("TienTe_Ma");

            entity.HasOne(d => d.ChiNhanhMaNavigation).WithMany(p => p.TctdgSotienguis)
                .HasForeignKey(d => d.ChiNhanhMa)
                .HasConstraintName("FK_TCTDG_SOTIENGUI_DM_CHINHANH");

            entity.HasOne(d => d.SanPhamMaNavigation).WithMany(p => p.TctdgSotienguis)
                .HasForeignKey(d => d.SanPhamMa)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_TCTDG_SOTIENGUI_TCTDG_SANPHAM");
        });

        modelBuilder.Entity<TctdgSotienguiEom>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TCTDG_SOTIENGUI_EOM");

            entity.Property(e => e.NgaySolieu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ngay_solieu");
            entity.Property(e => e.StkDuthu)
                .HasColumnType("money")
                .HasColumnName("STK_Duthu");
            entity.Property(e => e.StkDuthuDenNgay)
                .HasColumnType("datetime")
                .HasColumnName("STK_DuthuDenNgay");
            entity.Property(e => e.StkMa)
                .HasMaxLength(20)
                .HasColumnName("STK_Ma");
            entity.Property(e => e.StkSoDu)
                .HasColumnType("money")
                .HasColumnName("STK_SoDu");
            entity.Property(e => e.StkSoTietKiem)
                .HasMaxLength(20)
                .HasColumnName("STK_SoTietKiem");
            entity.Property(e => e.StkTkct)
                .HasMaxLength(20)
                .HasColumnName("STK_TKCT");
        });

        modelBuilder.Entity<TctdvDmHtVay>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TCTDV_DM_HT_Vay");

            entity.Property(e => e.GhiChu)
                .HasMaxLength(50)
                .HasColumnName("ghi_chu");
            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ma");
            entity.Property(e => e.Ten)
                .HasMaxLength(200)
                .HasColumnName("ten");
        });

        modelBuilder.Entity<TctdvDmSanPham>(entity =>
        {
            entity.HasKey(e => e.Ma).HasName("PK_TCTDV_SanPham");

            entity.ToTable("TCTDV_DM_SanPham");

            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DateModify)
                .HasColumnType("datetime")
                .HasColumnName("Date_Modify");
            entity.Property(e => e.DateNew)
                .HasColumnType("datetime")
                .HasColumnName("Date_New");
            entity.Property(e => e.DvkyHanId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasColumnName("DVKyHan_ID");
            entity.Property(e => e.GhiChu)
                .HasMaxLength(255)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Ghi_Chu");
            entity.Property(e => e.KyHan)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Ky_Han");
            entity.Property(e => e.LaiSuat)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Lai_Suat");
            entity.Property(e => e.LoaiSpId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Loai_SP_ID");
            entity.Property(e => e.Ten)
                .HasMaxLength(255)
                .HasDefaultValueSql("(' ')");
            entity.Property(e => e.TenTat)
                .HasMaxLength(20)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Ten_Tat");
            entity.Property(e => e.TienTeMa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("TienTe_Ma");
            entity.Property(e => e.Tk1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("TK1");
            entity.Property(e => e.Tk2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("TK2");
            entity.Property(e => e.Tk3)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("TK3");
            entity.Property(e => e.Tk4)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("TK4");
            entity.Property(e => e.Tk5)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("TK5");
            entity.Property(e => e.Tk6)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("TK6");
            entity.Property(e => e.Tk7)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TK7");
            entity.Property(e => e.UsersModify)
                .HasMaxLength(20)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Users_Modify");
            entity.Property(e => e.UsersNew)
                .HasMaxLength(20)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Users_New");
        });

        modelBuilder.Entity<TctdvGiaiNgan>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TCTDV_GiaiNgan");

            entity.Property(e => e.DateModify)
                .HasColumnType("datetime")
                .HasColumnName("Date_Modify");
            entity.Property(e => e.DateNew)
                .HasColumnType("datetime")
                .HasColumnName("Date_New");
            entity.Property(e => e.GhiChu)
                .HasMaxLength(500)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Ghi_Chu");
            entity.Property(e => e.GiaiNganId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GiaiNgan_ID");
            entity.Property(e => e.GiaoDichId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("GiaoDich_ID");
            entity.Property(e => e.HinhThucGnId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("HinhThucGN_ID");
            entity.Property(e => e.HopDongId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Hop_Dong_ID");
            entity.Property(e => e.LoaiGiaoDichId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Loai_Giao_Dich_ID");
            entity.Property(e => e.MaTkCo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Ma_TK_Co");
            entity.Property(e => e.MaTkNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Ma_TK_No");
            entity.Property(e => e.Ngay).HasColumnType("smalldatetime");
            entity.Property(e => e.NgayDuChiCu)
                .HasColumnType("datetime")
                .HasColumnName("Ngay_du_chi_cu");
            entity.Property(e => e.NgayTinhLai)
                .HasColumnType("datetime")
                .HasColumnName("Ngay_tinh_lai");
            entity.Property(e => e.SoChungTu)
                .HasMaxLength(20)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("So_Chung_Tu");
            entity.Property(e => e.SoDuChiCu).HasColumnName("So_du_chi_cu");
            entity.Property(e => e.SoDuToan)
                .HasDefaultValueSql("((0))")
                .HasColumnName("So_Du_Toan");
            entity.Property(e => e.SoTien)
                .HasDefaultValueSql("((0))")
                .HasColumnName("So_Tien");
            entity.Property(e => e.TrangThai)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Trang_Thai");
            entity.Property(e => e.UsersModify)
                .HasMaxLength(20)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Users_Modify");
            entity.Property(e => e.UsersNew)
                .HasMaxLength(20)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Users_New");
        });

        modelBuilder.Entity<TctdvHopDong>(entity =>
        {
            entity.HasKey(e => e.HopDongId);

            entity.ToTable("TCTDV_HopDong");

            entity.Property(e => e.HopDongId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Hop_Dong_ID");
            entity.Property(e => e.CmtSerial)
                .HasMaxLength(20)
                .HasColumnName("CMT_Serial");
            entity.Property(e => e.DateModify)
                .HasColumnType("datetime")
                .HasColumnName("Date_Modify");
            entity.Property(e => e.DateNew)
                .HasColumnType("datetime")
                .HasColumnName("Date_New");
            entity.Property(e => e.DiachiNguoiDaiDien)
                .HasMaxLength(100)
                .HasColumnName("Diachi_NguoiDaiDien");
            entity.Property(e => e.DuChi)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Du_Chi");
            entity.Property(e => e.DvkyHanId)
                .HasDefaultValueSql("((1))")
                .HasColumnName("DVKyHan_ID");
            entity.Property(e => e.GhiChu)
                .HasMaxLength(400)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Ghi_Chu");
            entity.Property(e => e.GocDaTra)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Goc_Da_Tra");
            entity.Property(e => e.GocDenNgay)
                .HasColumnType("datetime")
                .HasColumnName("Goc_Den_Ngay");
            entity.Property(e => e.HinhThucTraLaiId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("HinhThucTraLai_ID");
            entity.Property(e => e.HinhThucVayId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("HinhThucVay_ID");
            entity.Property(e => e.KyHan)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Ky_Han");
            entity.Property(e => e.LaiDaTra)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Lai_Da_Tra");
            entity.Property(e => e.LaiDenNgay)
                .HasColumnType("datetime")
                .HasColumnName("Lai_Den_Ngay");
            entity.Property(e => e.LaiSuat)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Lai_Suat");
            entity.Property(e => e.LaiSuatQuaHan)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Lai_Suat_Qua_Han");
            entity.Property(e => e.LoaiVayId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Loai_Vay_ID");
            entity.Property(e => e.NgayChuyenQuaHan)
                .HasColumnType("datetime")
                .HasColumnName("Ngay_Chuyen_Qua_Han");
            entity.Property(e => e.NgayDaoHan)
                .HasColumnType("datetime")
                .HasColumnName("Ngay_Dao_Han");
            entity.Property(e => e.NgayDuChi)
                .HasColumnType("datetime")
                .HasColumnName("Ngay_Du_Chi");
            entity.Property(e => e.NgayGiaHan)
                .HasColumnType("datetime")
                .HasColumnName("Ngay_Gia_Han");
            entity.Property(e => e.NgayHopDong)
                .HasColumnType("smalldatetime")
                .HasColumnName("Ngay_Hop_Dong");
            entity.Property(e => e.NgayVay)
                .HasColumnType("datetime")
                .HasColumnName("Ngay_Vay");
            entity.Property(e => e.SanPhamVayId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("SanPhamVay_ID");
            entity.Property(e => e.SoDu)
                .HasDefaultValueSql("((0))")
                .HasColumnName("So_Du");
            entity.Property(e => e.SoGiaiNgan)
                .HasDefaultValueSql("((0))")
                .HasColumnName("So_Giai_Ngan");
            entity.Property(e => e.SoHopDong)
                .HasMaxLength(20)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("So_Hop_Dong");
            entity.Property(e => e.SoTien)
                .HasDefaultValueSql("((0))")
                .HasColumnName("So_Tien");
            entity.Property(e => e.TctdMa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("TCTD_Ma");
            entity.Property(e => e.TenNguoiDaiDien)
                .HasMaxLength(100)
                .HasColumnName("Ten_NguoiDaiDien");
            entity.Property(e => e.TenTctdVay)
                .HasMaxLength(100)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Ten_TCTD_Vay");
            entity.Property(e => e.TkHopDong)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TK_Hop_Dong");
            entity.Property(e => e.TrangThai)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Trang_Thai");
            entity.Property(e => e.UsersModify)
                .HasMaxLength(50)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Users_Modify");
            entity.Property(e => e.UsersNew)
                .HasMaxLength(50)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Users_New");
        });

        modelBuilder.Entity<TctdvKeHoachTraNo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TCTDV_KeHoachTraNo");

            entity.Property(e => e.DateModify)
                .HasColumnType("datetime")
                .HasColumnName("Date_Modify");
            entity.Property(e => e.DateNew)
                .HasColumnType("datetime")
                .HasColumnName("Date_New");
            entity.Property(e => e.GhiChu)
                .HasMaxLength(100)
                .HasColumnName("Ghi_Chu");
            entity.Property(e => e.HoSoTdId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("HoSoTD_ID");
            entity.Property(e => e.KhtraNoId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KHTraNo_ID");
            entity.Property(e => e.NgayTra)
                .HasColumnType("smalldatetime")
                .HasColumnName("Ngay_Tra");
            entity.Property(e => e.SoTienGoc).HasColumnName("So_Tien_Goc");
            entity.Property(e => e.SoTienLai).HasColumnName("So_Tien_Lai");
            entity.Property(e => e.ThuGoc).HasColumnName("Thu_Goc");
            entity.Property(e => e.ThuLai).HasColumnName("Thu_Lai");
            entity.Property(e => e.TrangThai).HasColumnName("Trang_Thai");
            entity.Property(e => e.UsersModify)
                .HasMaxLength(20)
                .HasColumnName("Users_Modify");
            entity.Property(e => e.UsersNew)
                .HasMaxLength(20)
                .HasColumnName("Users_New");
        });

        modelBuilder.Entity<TctdvLaiSuat>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TCTDV_Lai_Suat");

            entity.Property(e => e.DateModify)
                .HasColumnType("datetime")
                .HasColumnName("Date_Modify");
            entity.Property(e => e.DateNew)
                .HasColumnType("datetime")
                .HasColumnName("Date_New");
            entity.Property(e => e.GhiChu)
                .HasMaxLength(100)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Ghi_chu");
            entity.Property(e => e.HosoTdId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("HosoTD_ID");
            entity.Property(e => e.LaiSuat).HasColumnName("Lai_Suat");
            entity.Property(e => e.LaiSuatId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Lai_Suat_ID");
            entity.Property(e => e.LaiSuatQuaHan).HasColumnName("Lai_Suat_Qua_Han");
            entity.Property(e => e.Ngay).HasColumnType("smalldatetime");
            entity.Property(e => e.UsersModify)
                .HasMaxLength(20)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Users_Modify");
            entity.Property(e => e.UsersNew)
                .HasMaxLength(20)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Users_New");
        });

        modelBuilder.Entity<TdungDinhgiaTaiSanTheChap>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TDUNG_DinhgiaTaiSanTheChap", tb =>
                {
                    tb.HasTrigger("DeleteTDung_DinhgiaHosoTdung_HinhThucTSTC_ID");
                    tb.HasTrigger("capnhatTDung_DinhgiaHosoTdung_HinhThucTSTC_ID");
                });

            entity.Property(e => e.ChuTsCmtngaycap)
                .HasColumnType("datetime")
                .HasColumnName("ChuTS_CMTNgaycap");
            entity.Property(e => e.ChuTsCmtnoicap)
                .HasMaxLength(100)
                .HasColumnName("ChuTS_CMTNoicap");
            entity.Property(e => e.ChuTsDiachi)
                .HasMaxLength(250)
                .HasColumnName("ChuTS_Diachi");
            entity.Property(e => e.ChuTsDienthoai)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ChuTS_Dienthoai");
            entity.Property(e => e.ChuTsHoten)
                .HasMaxLength(50)
                .HasColumnName("ChuTS_Hoten");
            entity.Property(e => e.ChuTsSoCmt)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ChuTS_SoCMT");
            entity.Property(e => e.DateModify)
                .HasColumnType("datetime")
                .HasColumnName("Date_Modify");
            entity.Property(e => e.DateNew)
                .HasColumnType("datetime")
                .HasColumnName("Date_New");
            entity.Property(e => e.HoSoTdId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("HoSoTD_ID");
            entity.Property(e => e.TstcDdkyThuat)
                .HasMaxLength(250)
                .HasColumnName("TSTC_DDKyThuat");
            entity.Property(e => e.TstcGhiChu)
                .HasMaxLength(200)
                .HasColumnName("TSTC_GhiChu");
            entity.Property(e => e.TstcHdtc)
                .HasMaxLength(40)
                .HasColumnName("TSTC_HDTC");
            entity.Property(e => e.TstcId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TSTC_ID");
            entity.Property(e => e.TstcKyHieu)
                .HasMaxLength(50)
                .HasColumnName("TSTC_KyHieu");
            entity.Property(e => e.TstcLoaiDinhGia)
                .HasMaxLength(20)
                .HasColumnName("TSTC_Loai_Dinh_gia");
            entity.Property(e => e.TstcMa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TSTC_Ma");
            entity.Property(e => e.TstcMaLoai)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TSTC_Ma_Loai");
            entity.Property(e => e.TstcMaNhom)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TSTC_Ma_Nhom");
            entity.Property(e => e.TstcNgayDuyet)
                .HasColumnType("smalldatetime")
                .HasColumnName("TSTC_NgayDuyet");
            entity.Property(e => e.TstcSoLuong).HasColumnName("TSTC_SoLuong");
            entity.Property(e => e.TstcTaiKhoan)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TSTC_Tai_Khoan");
            entity.Property(e => e.TstcTen)
                .HasMaxLength(250)
                .HasColumnName("TSTC_Ten");
            entity.Property(e => e.TstcThanhTien).HasColumnName("TSTC_ThanhTien");
            entity.Property(e => e.TstcTrangThai).HasColumnName("TSTC_TrangThai");
            entity.Property(e => e.TstcTyLeDp).HasColumnName("TSTC_TyLeDP");
            entity.Property(e => e.UsersModify)
                .HasMaxLength(50)
                .HasColumnName("Users_Modify");
            entity.Property(e => e.UsersNew)
                .HasMaxLength(50)
                .HasColumnName("Users_New");
        });

        modelBuilder.Entity<TdungDmHtTheChap>(entity =>
        {
            entity.HasKey(e => e.Ma).HasName("PK_TDUNG_Dm_TheChap");

            entity.ToTable("TDUNG_Dm_HT_TheChap");

            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ma");
            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("active");
            entity.Property(e => e.TaiKhoan)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('9940001.0001.001')");
            entity.Property(e => e.TaiKhoanTc)
                .HasMaxLength(100)
                .HasColumnName("TaiKhoan_TC");
            entity.Property(e => e.TaikhoanGh)
                .HasMaxLength(20)
                .HasDefaultValueSql("('9920001.0001.001')")
                .HasColumnName("Taikhoan_GH");
            entity.Property(e => e.Ten)
                .HasMaxLength(50)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("ten");
            entity.Property(e => e.TyleRr)
                .HasDefaultValueSql("((50))")
                .HasColumnName("tyle_rr");
        });

        modelBuilder.Entity<TdungDmHtTheChap02>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TDUNG_Dm_HT_TheChap02");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ma");
            entity.Property(e => e.TaiKhoan)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TaikhoanGh)
                .HasMaxLength(20)
                .HasDefaultValueSql("('9920001.0002.001')")
                .HasColumnName("Taikhoan_GH");
            entity.Property(e => e.Ten)
                .HasMaxLength(50)
                .HasColumnName("ten");
            entity.Property(e => e.TyleRr).HasColumnName("tyle_rr");
        });

        modelBuilder.Entity<TdungDmHthucTraLai>(entity =>
        {
            entity.HasKey(e => e.Ma).HasName("PK_TDUNG_Hthuc_TraLai");

            entity.ToTable("TDUNG_Dm_Hthuc_TraLai");

            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ma");
            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("active");
            entity.Property(e => e.Ten)
                .HasMaxLength(50)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("ten");
        });

        modelBuilder.Entity<TdungDmLoaiTstc>(entity =>
        {
            entity.HasKey(e => e.Ma);

            entity.ToTable("TDUNG_Dm_Loai_TSTC");

            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ma");
            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("active");
            entity.Property(e => e.Ten)
                .HasMaxLength(100)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("ten");
        });

        modelBuilder.Entity<TdungDmNhomNo>(entity =>
        {
            entity.HasKey(e => e.Ma);

            entity.ToTable("TDUNG_Dm_Nhom_No");

            entity.Property(e => e.Ma)
                .ValueGeneratedNever()
                .HasColumnName("ma");
            entity.Property(e => e.Ten)
                .HasMaxLength(50)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("ten");
        });

        modelBuilder.Entity<TdungDmPthucVay>(entity =>
        {
            entity.HasKey(e => e.Ma).HasName("PK_TDUNG_PThuc_Vay");

            entity.ToTable("TDUNG_Dm_PThuc_Vay");

            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ma");
            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("active");
            entity.Property(e => e.Ten)
                .HasMaxLength(50)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("ten");
        });

        modelBuilder.Entity<TdungGiahanNo1phan>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Tdung_GiahanNo_1Phan");

            entity.Property(e => e.DateNew)
                .HasColumnType("datetime")
                .HasColumnName("Date_new");
            entity.Property(e => e.GnId)
                .HasMaxLength(50)
                .HasColumnName("GN_id");
            entity.Property(e => e.HosotdId)
                .HasMaxLength(50)
                .HasColumnName("Hosotd_ID");
            entity.Property(e => e.KhtraNoId)
                .HasMaxLength(50)
                .HasColumnName("KHTraNo_ID");
            entity.Property(e => e.LaiDuThu).HasColumnName("Lai_du_thu");
            entity.Property(e => e.NgayGd)
                .HasColumnType("datetime")
                .HasColumnName("Ngay_Gd");
            entity.Property(e => e.NgayGiaHan)
                .HasColumnType("datetime")
                .HasColumnName("Ngay_Gia_han");
            entity.Property(e => e.NgayTra)
                .HasColumnType("datetime")
                .HasColumnName("Ngay_tra");
            entity.Property(e => e.ThuGoc).HasColumnName("Thu_Goc");
        });

        modelBuilder.Entity<TdungGiahanNoDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Tdung_GiahanNo_Detail");

            entity.Property(e => e.DateNew)
                .HasColumnType("datetime")
                .HasColumnName("Date_new");
            entity.Property(e => e.GnId)
                .HasMaxLength(50)
                .HasColumnName("GN_id");
            entity.Property(e => e.HosotdId)
                .HasMaxLength(50)
                .HasColumnName("Hosotd_ID");
            entity.Property(e => e.KhtraNoId)
                .HasMaxLength(80)
                .HasColumnName("KHTraNo_ID");
            entity.Property(e => e.LoaiGiaHan).HasColumnName("Loai_gia_han");
            entity.Property(e => e.LyDo).HasColumnName("Ly_do");
            entity.Property(e => e.NgayGd)
                .HasColumnType("datetime")
                .HasColumnName("Ngay_Gd");
            entity.Property(e => e.NgayGiaHan)
                .HasColumnType("datetime")
                .HasColumnName("Ngay_Gia_han");
            entity.Property(e => e.SoDu).HasColumnName("So_du");
        });

        modelBuilder.Entity<TdungGiaiNgan>(entity =>
        {
            entity.HasKey(e => e.GiaiNganId);

            entity.ToTable("TDUNG_Giai_Ngan", tb => tb.HasTrigger("trg_GIAODICHTD_DEL"));

            entity.Property(e => e.GiaiNganId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GiaiNgan_ID");
            entity.Property(e => e.ChiNhanhId)
                .HasMaxLength(4)
                .HasColumnName("ChiNhanh_ID");
            entity.Property(e => e.DateModify)
                .HasColumnType("datetime")
                .HasColumnName("Date_Modify");
            entity.Property(e => e.DateNew)
                .HasColumnType("datetime")
                .HasColumnName("Date_New");
            entity.Property(e => e.GhiChu)
                .HasMaxLength(500)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Ghi_Chu");
            entity.Property(e => e.GiaoDichId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("GiaoDich_ID");
            entity.Property(e => e.HinhThucGnId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("HinhThucGN_ID");
            entity.Property(e => e.HoSoTdId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("HoSoTD_ID");
            entity.Property(e => e.LoaiGiaoDichId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Loai_Giao_Dich_ID");
            entity.Property(e => e.MaTkCo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Ma_TK_Co");
            entity.Property(e => e.MaTkNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Ma_TK_No");
            entity.Property(e => e.Ngay).HasColumnType("smalldatetime");
            entity.Property(e => e.NgayDuThuCu)
                .HasColumnType("datetime")
                .HasColumnName("Ngay_DuThuCu");
            entity.Property(e => e.NgayTinhLai)
                .HasColumnType("smalldatetime")
                .HasColumnName("Ngay_Tinh_Lai");
            entity.Property(e => e.SoChungTu)
                .HasMaxLength(20)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("So_Chung_Tu");
            entity.Property(e => e.SoDuToan)
                .HasDefaultValueSql("((0))")
                .HasColumnName("So_Du_Toan");
            entity.Property(e => e.SoThuThem)
                .HasDefaultValueSql("((0))")
                .HasColumnName("So_Thu_Them");
            entity.Property(e => e.SoTien)
                .HasDefaultValueSql("((0))")
                .HasColumnName("So_Tien");
            entity.Property(e => e.SoTien0)
                .HasDefaultValueSql("((0))")
                .HasColumnName("so_tien0");
            entity.Property(e => e.SoTienDuThuCu)
                .HasDefaultValueSql("((0))")
                .HasColumnName("SoTien_DuThu_Cu");
            entity.Property(e => e.ThuaThieuKyNay)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Thua_Thieu_Ky_Nay");
            entity.Property(e => e.ThuaThieuKyTruoc)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Thua_Thieu_Ky_Truoc");
            entity.Property(e => e.TrangThai)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Trang_Thai");
            entity.Property(e => e.UsersModify)
                .HasMaxLength(20)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Users_Modify");
            entity.Property(e => e.UsersNew)
                .HasMaxLength(20)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Users_New");
        });

        modelBuilder.Entity<TdungGiaiNganNoGocTt>(entity =>
        {
            entity.HasKey(e => e.GiaiNganId).HasName("PK__TDUNG_Giai_Ngan___18335540");

            entity.ToTable("TDUNG_Giai_Ngan_NoGocTT");

            entity.Property(e => e.GiaiNganId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GiaiNgan_ID");
            entity.Property(e => e.GhiChu)
                .HasMaxLength(500)
                .HasColumnName("Ghi_Chu");
            entity.Property(e => e.HoSoTdId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("HoSoTD_ID");
            entity.Property(e => e.Ngay).HasColumnType("smalldatetime");
            entity.Property(e => e.SoHopDong)
                .HasMaxLength(20)
                .HasColumnName("So_Hop_Dong");
            entity.Property(e => e.SoTienGocTt).HasColumnName("SoTienGoc_TT");
            entity.Property(e => e.SoTienLaiTt).HasColumnName("SoTienLai_TT");
        });

        modelBuilder.Entity<TdungGiaiNganNoLaiNb>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TDUNG_GiaiNgan_NoLaiNB");

            entity.Property(e => e.ChinhanhId)
                .HasMaxLength(20)
                .HasColumnName("Chinhanh_ID");
            entity.Property(e => e.GhiChu)
                .HasMaxLength(500)
                .HasColumnName("Ghi_Chu");
            entity.Property(e => e.GiaiNganId)
                .HasMaxLength(20)
                .HasColumnName("GiaiNgan_Id");
            entity.Property(e => e.HoSoTdId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("HoSoTD_ID");
            entity.Property(e => e.LaiDuThu).HasColumnName("Lai_Du_Thu");
            entity.Property(e => e.LoaiGiaoDich)
                .HasMaxLength(10)
                .HasColumnName("loai_giao_dich");
            entity.Property(e => e.MaTk)
                .HasMaxLength(50)
                .HasColumnName("Ma_Tk");
            entity.Property(e => e.Ngay).HasColumnType("smalldatetime");
            entity.Property(e => e.SoHopDong)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("So_hop_Dong");
            entity.Property(e => e.UsersModify)
                .HasMaxLength(100)
                .HasColumnName("Users_modify");
            entity.Property(e => e.UsersNew)
                .HasMaxLength(100)
                .HasColumnName("Users_new");
        });

        modelBuilder.Entity<TdungGiaiNganUserTragop>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TDUNG_Giai_Ngan_User_Tragop");

            entity.Property(e => e.CmtNgayCap)
                .HasColumnType("datetime")
                .HasColumnName("CMT_NgayCap");
            entity.Property(e => e.CmtNoiCap)
                .HasMaxLength(255)
                .HasColumnName("CMT_NoiCap");
            entity.Property(e => e.CmtSerial)
                .HasMaxLength(20)
                .HasColumnName("CMT_Serial");
            entity.Property(e => e.DiaChi)
                .HasMaxLength(200)
                .HasColumnName("Dia_Chi");
            entity.Property(e => e.GiaoDichId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GiaoDich_ID");
            entity.Property(e => e.Ten).HasMaxLength(50);
        });

        modelBuilder.Entity<TdungHoSoTinDung>(entity =>
        {
            entity.HasKey(e => e.HoSoTdId).HasName("PK_ITDVAPCF_TDUNG");

            entity.ToTable("TDUNG_HoSoTinDung");

            entity.HasIndex(e => e.SoHopDong, "IX_TDUNG_HoSoTinDung");

            entity.Property(e => e.HoSoTdId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("HoSoTD_ID");
            entity.Property(e => e.DateModify)
                .HasColumnType("datetime")
                .HasColumnName("Date_Modify");
            entity.Property(e => e.DateNew)
                .HasColumnType("datetime")
                .HasColumnName("Date_New");
            entity.Property(e => e.DauVao).HasColumnName("Dau_Vao");
            entity.Property(e => e.DoiTuongId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Doi_Tuong_ID");
            entity.Property(e => e.DonViKyHan)
                .HasDefaultValueSql("((1))")
                .HasColumnName("Don_Vi_Ky_Han");
            entity.Property(e => e.GhiChu)
                .HasMaxLength(400)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Ghi_Chu");
            entity.Property(e => e.GocDaThu)
                .HasComment("Tổng số GỐC đã thu của hồ sơ")
                .HasColumnName("Goc_Da_Thu");
            entity.Property(e => e.GocDenNgay)
                .HasComment("Ngày thu gốc gần nhất")
                .HasColumnType("datetime")
                .HasColumnName("Goc_Den_Ngay");
            entity.Property(e => e.GocKyCuoi)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Goc_Ky_Cuoi");
            entity.Property(e => e.GocTheoKy)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Goc_Theo_Ky");
            entity.Property(e => e.HinhThucTraLaiId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("HinhThucTraLai_ID");
            entity.Property(e => e.HinhThucTstcId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("HinhThucTSTC_ID");
            entity.Property(e => e.HstdParent)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasColumnName("HSTD_parent");
            entity.Property(e => e.KhachHangId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("KhachHang_ID");
            entity.Property(e => e.KieuLaiSuat).HasColumnName("Kieu_Lai_Suat");
            entity.Property(e => e.KyHanVay).HasColumnName("Ky_Han_Vay");
            entity.Property(e => e.LaiDaThu)
                .HasComment("Tổng Số Lãi đã thu hiện thời của hồ sơ tín dụng")
                .HasColumnName("Lai_Da_Thu");
            entity.Property(e => e.LaiDenNgay)
                .HasComment("Ngày thu lãi gần nhất đã thu hiện thời của hồ sơ tín dụng")
                .HasColumnType("datetime")
                .HasColumnName("Lai_Den_Ngay");
            entity.Property(e => e.LaiDuThu)
                .HasComment("Tổng số lãi dự thu")
                .HasColumnName("Lai_Du_Thu");
            entity.Property(e => e.LaiDuThuCu).HasColumnName("Lai_Du_Thu_Cu");
            entity.Property(e => e.LaiKyCuoi)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Lai_Ky_Cuoi");
            entity.Property(e => e.LaiPhaiThu)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Lai_Phai_Thu");
            entity.Property(e => e.LaiSuat).HasColumnName("Lai_Suat");
            entity.Property(e => e.LaiSuatQuaHan).HasColumnName("Lai_Suat_Qua_Han");
            entity.Property(e => e.LaiSuatUuDai).HasColumnName("Lai_Suat_Uu_Dai");
            entity.Property(e => e.LaiTheoKy)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Lai_Theo_Ky");
            entity.Property(e => e.LoaiVayId).HasColumnName("Loai_Vay_ID");
            entity.Property(e => e.MaMucDichVay)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("ma_muc_dich_vay");
            entity.Property(e => e.MaThongKe0)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ma_thong_ke0");
            entity.Property(e => e.MaThongKe1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ma_thong_ke1");
            entity.Property(e => e.MucDichVay)
                .HasMaxLength(255)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Muc_Dich_Vay");
            entity.Property(e => e.NgayChuyenQuaHan)
                .HasColumnType("smalldatetime")
                .HasColumnName("Ngay_Chuyen_Qua_Han");
            entity.Property(e => e.NgayDaoHan)
                .HasColumnType("smalldatetime")
                .HasColumnName("Ngay_Dao_Han");
            entity.Property(e => e.NgayDtdk)
                .HasColumnType("smalldatetime")
                .HasColumnName("Ngay_DTDK");
            entity.Property(e => e.NgayDuThu)
                .HasComment("Số ngày dự thu")
                .HasColumnType("smalldatetime")
                .HasColumnName("Ngay_Du_Thu");
            entity.Property(e => e.NgayDuThuCu)
                .HasColumnType("smalldatetime")
                .HasColumnName("Ngay_Du_Thu_Cu");
            entity.Property(e => e.NgayGiaHan)
                .HasColumnType("smalldatetime")
                .HasColumnName("Ngay_Gia_Han");
            entity.Property(e => e.NgayGiaiNgan)
                .HasColumnType("smalldatetime")
                .HasColumnName("Ngay_Giai_Ngan");
            entity.Property(e => e.NgayHopDong)
                .HasColumnType("smalldatetime")
                .HasColumnName("Ngay_Hop_Dong");
            entity.Property(e => e.NgayVay)
                .HasColumnType("smalldatetime")
                .HasColumnName("Ngay_Vay");
            entity.Property(e => e.NguoiBaoLanh)
                .HasMaxLength(100)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Nguoi_Bao_Lanh");
            entity.Property(e => e.NguoiThuaKe)
                .HasMaxLength(100)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Nguoi_Thua_Ke");
            entity.Property(e => e.NguyenNhanNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Nguyen_Nhan_No");
            entity.Property(e => e.NhomNo)
                .HasDefaultValueSql("((1))")
                .HasColumnName("Nhom_No");
            entity.Property(e => e.NoQuaHan).HasColumnName("No_Qua_Han");
            entity.Property(e => e.PhuongThucVayId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("PhuongThucVay_ID");
            entity.Property(e => e.QuaHan).HasColumnName("Qua_Han");
            entity.Property(e => e.SanPhamTdId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("SanPhamTD_ID");
            entity.Property(e => e.SoDu)
                .HasComment("Số dư hiện thời của hồ sơ tín dụng")
                .HasColumnName("So_Du");
            entity.Property(e => e.SoGiaiNgan).HasColumnName("So_Giai_Ngan");
            entity.Property(e => e.SoHopDong)
                .HasMaxLength(20)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("So_Hop_Dong");
            entity.Property(e => e.SoKyTraGop)
                .HasDefaultValueSql("((0))")
                .HasColumnName("So_ky_Tra_Gop");
            entity.Property(e => e.SoTienDuPhong).HasColumnName("So_Tien_Du_Phong");
            entity.Property(e => e.SoTienNhan).HasColumnName("So_Tien_Nhan");
            entity.Property(e => e.SoTienNo).HasColumnName("So_Tien_No");
            entity.Property(e => e.SoTienVay).HasColumnName("So_Tien_Vay");
            entity.Property(e => e.Sokheuoc)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.TenNguoiVay)
                .HasMaxLength(100)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Ten_Nguoi_Vay");
            entity.Property(e => e.Tk)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TK");
            entity.Property(e => e.TkTinDung)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("TK_Tin_Dung");
            entity.Property(e => e.TrangThai).HasColumnName("Trang_Thai");
            entity.Property(e => e.TstcTriGia)
                .HasComment("Tổng trị giá tài sản thế chấp")
                .HasColumnName("TSTC_Tri_gia");
            entity.Property(e => e.UsersModify)
                .HasMaxLength(50)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Users_Modify");
            entity.Property(e => e.UsersNew)
                .HasMaxLength(50)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Users_New");
        });

        modelBuilder.Entity<TdungHstdEom>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TDUNG_HSTD_EOM");

            entity.Property(e => e.ChiNhanhId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ChiNhanh_ID");
            entity.Property(e => e.DateNew)
                .HasColumnType("datetime")
                .HasColumnName("Date_New");
            entity.Property(e => e.HoSoTdId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("HoSoTD_ID");
            entity.Property(e => e.NgayDuThu)
                .HasColumnType("datetime")
                .HasColumnName("Ngay_DuThu");
            entity.Property(e => e.NgaySoLieu)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Ngay_SoLieu");
            entity.Property(e => e.NgayThuLai)
                .HasColumnType("datetime")
                .HasColumnName("Ngay_ThuLai");
            entity.Property(e => e.TienDuThu).HasColumnName("Tien_DuThu");
            entity.Property(e => e.TkTinDung)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TK_TinDung");
            entity.Property(e => e.TstcTriGia).HasColumnName("TSTC_TriGia");
        });

        modelBuilder.Entity<TdungKeHoachGiaiNgan>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Tdung_KeHoachGiaiNgan");

            entity.Property(e => e.ChinhanhId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("chinhanh_id");
            entity.Property(e => e.DateModify)
                .HasColumnType("datetime")
                .HasColumnName("Date_Modify");
            entity.Property(e => e.DateNew)
                .HasColumnType("datetime")
                .HasColumnName("Date_New");
            entity.Property(e => e.GhiChu)
                .HasMaxLength(100)
                .HasColumnName("Ghi_Chu");
            entity.Property(e => e.HoSoTdId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("HoSoTD_ID");
            entity.Property(e => e.KhGiaiNganId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KhGiaiNgan_ID");
            entity.Property(e => e.NgayGn)
                .HasColumnType("smalldatetime")
                .HasColumnName("Ngay_GN");
            entity.Property(e => e.SoTienGn).HasColumnName("So_Tien_GN");
            entity.Property(e => e.TrangThai).HasColumnName("Trang_Thai");
            entity.Property(e => e.UsersModify)
                .HasMaxLength(20)
                .HasColumnName("Users_Modify");
            entity.Property(e => e.UsersNew)
                .HasMaxLength(20)
                .HasColumnName("Users_New");
        });

        modelBuilder.Entity<TdungKeHoachTraNo>(entity =>
        {
            entity.HasKey(e => e.KhtraNoId);

            entity.ToTable("TDUNG_KeHoachTraNo");

            entity.Property(e => e.KhtraNoId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KHTraNo_ID");
            entity.Property(e => e.ChinhanhId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("chinhanh_id");
            entity.Property(e => e.DateModify)
                .HasColumnType("datetime")
                .HasColumnName("Date_Modify");
            entity.Property(e => e.DateNew)
                .HasColumnType("datetime")
                .HasColumnName("Date_New");
            entity.Property(e => e.GhiChu)
                .HasMaxLength(100)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Ghi_Chu");
            entity.Property(e => e.HoSoTdId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("HoSoTD_ID");
            entity.Property(e => e.NgayGiaHan)
                .HasColumnType("smalldatetime")
                .HasColumnName("Ngay_gia_han");
            entity.Property(e => e.NgayTra)
                .HasColumnType("smalldatetime")
                .HasColumnName("Ngay_Tra");
            entity.Property(e => e.SoTienGoc).HasColumnName("So_Tien_Goc");
            entity.Property(e => e.SoTienLai).HasColumnName("So_Tien_Lai");
            entity.Property(e => e.ThuGoc).HasColumnName("Thu_Goc");
            entity.Property(e => e.ThuLai).HasColumnName("Thu_Lai");
            entity.Property(e => e.TrangThai).HasColumnName("Trang_Thai");
            entity.Property(e => e.UsersModify)
                .HasMaxLength(20)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Users_Modify");
            entity.Property(e => e.UsersNew)
                .HasMaxLength(20)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Users_New");
        });

        modelBuilder.Entity<TdungLaiSuat>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TDUNG_Lai_Suat");

            entity.Property(e => e.ChiNhanhId)
                .HasMaxLength(4)
                .HasColumnName("ChiNhanh_ID");
            entity.Property(e => e.DateModify)
                .HasColumnType("datetime")
                .HasColumnName("Date_Modify");
            entity.Property(e => e.DateNew)
                .HasColumnType("datetime")
                .HasColumnName("Date_New");
            entity.Property(e => e.GhiChu)
                .HasMaxLength(100)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Ghi_chu");
            entity.Property(e => e.HosoTdId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("HosoTD_ID");
            entity.Property(e => e.LaiSuat).HasColumnName("Lai_Suat");
            entity.Property(e => e.LaiSuatQuaHan).HasColumnName("Lai_Suat_Qua_Han");
            entity.Property(e => e.Ngay).HasColumnType("smalldatetime");
            entity.Property(e => e.TdungLaiSuatId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TDUNG_Lai_Suat_ID");
            entity.Property(e => e.UsersModify)
                .HasMaxLength(20)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Users_Modify");
            entity.Property(e => e.UsersNew)
                .HasMaxLength(20)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Users_New");
        });

        modelBuilder.Entity<TdungLaiSuatDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Tdung_lai_suat_Detail");

            entity.Property(e => e.ChiNhanhId)
                .HasMaxLength(4)
                .HasColumnName("ChiNhanh_ID");
            entity.Property(e => e.DateModify)
                .HasColumnType("datetime")
                .HasColumnName("Date_Modify");
            entity.Property(e => e.DateNew)
                .HasColumnType("datetime")
                .HasColumnName("Date_New");
            entity.Property(e => e.DuNoApDung)
                .HasDefaultValueSql("((0))")
                .HasColumnName("DuNo_ApDung");
            entity.Property(e => e.GhiChu)
                .HasMaxLength(100)
                .HasColumnName("Ghi_chu");
            entity.Property(e => e.HosoTdId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("HosoTD_ID");
            entity.Property(e => e.LaiSuat).HasColumnName("Lai_Suat");
            entity.Property(e => e.LaiSuatCu).HasColumnName("Lai_Suat_Cu");
            entity.Property(e => e.LaiSuatQuaHan).HasColumnName("Lai_Suat_Qua_Han");
            entity.Property(e => e.LoaiDc).HasColumnName("Loai_DC");
            entity.Property(e => e.LydoDc).HasColumnName("Lydo_DC");
            entity.Property(e => e.Ngay).HasColumnType("smalldatetime");
            entity.Property(e => e.TdungLaiSuatId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TDUNG_Lai_Suat_ID");
            entity.Property(e => e.UsersModify)
                .HasMaxLength(20)
                .HasColumnName("Users_Modify");
            entity.Property(e => e.UsersNew)
                .HasMaxLength(20)
                .HasColumnName("Users_New");
        });

        modelBuilder.Entity<TdungLaiSuatSanPham>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TDUNG_LaiSuat_SanPham");

            entity.Property(e => e.LsDenNgay)
                .HasColumnType("datetime")
                .HasColumnName("LS_DenNgay");
            entity.Property(e => e.LsGhiChu)
                .HasMaxLength(255)
                .HasColumnName("LS_GhiChu");
            entity.Property(e => e.LsLaiSuat).HasColumnName("LS_LaiSuat");
            entity.Property(e => e.LsMa)
                .HasMaxLength(20)
                .HasColumnName("LS_Ma");
            entity.Property(e => e.LsNam).HasColumnName("LS_Nam");
            entity.Property(e => e.LsQuaHan).HasColumnName("LS_QuaHan");
            entity.Property(e => e.LsTuNgay)
                .HasColumnType("datetime")
                .HasColumnName("LS_TuNgay");
            entity.Property(e => e.SanPhamMa)
                .HasMaxLength(20)
                .HasColumnName("SanPham_Ma");
        });

        modelBuilder.Entity<TdungMucDichVay>(entity =>
        {
            entity.HasKey(e => e.Ma).HasName("PK_Dm_Muc_Dich_Vay");

            entity.ToTable("TDung_Muc_Dich_Vay");

            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ma");
            entity.Property(e => e.MaNhom)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("ma_nhom");
            entity.Property(e => e.Ten)
                .HasMaxLength(100)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("ten");
        });

        modelBuilder.Entity<TdungTaiSanGiuHo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TDUNG_TaiSanGiuHo");

            entity.Property(e => e.ChinhanhId)
                .HasMaxLength(50)
                .HasColumnName("Chinhanh_id");
            entity.Property(e => e.ChuTsCmtngaycap)
                .HasColumnType("datetime")
                .HasColumnName("ChuTS_CMTNgaycap");
            entity.Property(e => e.ChuTsCmtnoicap)
                .HasMaxLength(100)
                .HasColumnName("ChuTS_CMTNoicap");
            entity.Property(e => e.ChuTsDiachi)
                .HasMaxLength(250)
                .HasColumnName("ChuTS_Diachi");
            entity.Property(e => e.ChuTsDienthoai)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ChuTS_Dienthoai");
            entity.Property(e => e.ChuTsHoten)
                .HasMaxLength(50)
                .HasColumnName("ChuTS_Hoten");
            entity.Property(e => e.ChuTsSoCmt)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ChuTS_SoCMT");
            entity.Property(e => e.DateModify)
                .HasColumnType("datetime")
                .HasColumnName("Date_Modify");
            entity.Property(e => e.DateNew)
                .HasColumnType("datetime")
                .HasColumnName("Date_New");
            entity.Property(e => e.HinhThuc)
                .HasDefaultValueSql("('0')")
                .HasColumnName("hinh_thuc");
            entity.Property(e => e.HoSoTdId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("HoSoTD_ID");
            entity.Property(e => e.NguoiGdCmtngayCap)
                .HasColumnType("datetime")
                .HasColumnName("NguoiGD_CMTNgayCap");
            entity.Property(e => e.NguoiGdCmtnoicap)
                .HasMaxLength(300)
                .HasColumnName("NguoiGD_CMTNoicap");
            entity.Property(e => e.NguoiGdDiachi)
                .HasMaxLength(300)
                .HasColumnName("NguoiGD_Diachi");
            entity.Property(e => e.NguoiGdHoten)
                .HasMaxLength(200)
                .HasColumnName("NguoiGD_Hoten");
            entity.Property(e => e.NguoiGdSoCmt)
                .HasMaxLength(100)
                .HasColumnName("NguoiGD_SoCMT");
            entity.Property(e => e.TstcDdkyThuat)
                .HasMaxLength(250)
                .HasColumnName("TSTC_DDKyThuat");
            entity.Property(e => e.TstcGhiChu)
                .HasMaxLength(200)
                .HasColumnName("TSTC_GhiChu");
            entity.Property(e => e.TstcGhiChuXuat)
                .HasMaxLength(200)
                .HasColumnName("TSTC_GhiChu_Xuat");
            entity.Property(e => e.TstcHdtc)
                .HasMaxLength(40)
                .HasColumnName("TSTC_HDTC");
            entity.Property(e => e.TstcId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TSTC_ID");
            entity.Property(e => e.TstcKyHieu)
                .HasMaxLength(50)
                .HasColumnName("TSTC_KyHieu");
            entity.Property(e => e.TstcMa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TSTC_Ma");
            entity.Property(e => e.TstcMaLoai)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TSTC_Ma_Loai");
            entity.Property(e => e.TstcMaNhom)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TSTC_Ma_Nhom");
            entity.Property(e => e.TstcNgayDuyet)
                .HasColumnType("smalldatetime")
                .HasColumnName("TSTC_NgayDuyet");
            entity.Property(e => e.TstcNgayXuat)
                .HasColumnType("smalldatetime")
                .HasColumnName("TSTC_NgayXuat");
            entity.Property(e => e.TstcSoCtuXuat)
                .HasMaxLength(20)
                .HasColumnName("TSTC_So_CTU_Xuat");
            entity.Property(e => e.TstcSoLuong).HasColumnName("TSTC_SoLuong");
            entity.Property(e => e.TstcTaiKhoan)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TSTC_Tai_Khoan");
            entity.Property(e => e.TstcTen)
                .HasMaxLength(250)
                .HasColumnName("TSTC_Ten");
            entity.Property(e => e.TstcThanhTien).HasColumnName("TSTC_ThanhTien");
            entity.Property(e => e.TstcTrangThai).HasColumnName("TSTC_TrangThai");
            entity.Property(e => e.TstcTrangThaiXuat).HasColumnName("TSTC_TrangThai_Xuat");
            entity.Property(e => e.TstcTyLeDp).HasColumnName("TSTC_TyLeDP");
            entity.Property(e => e.UsersModify)
                .HasMaxLength(50)
                .HasColumnName("Users_Modify");
            entity.Property(e => e.UsersNew)
                .HasMaxLength(50)
                .HasColumnName("Users_New");
        });

        modelBuilder.Entity<TdungTaiSanTheChap>(entity =>
        {
            entity.HasKey(e => e.TstcId);

            entity.ToTable("TDUNG_TaiSanTheChap", tb =>
                {
                    tb.HasTrigger("capnhatTDung_HosoTdung_HinhThucTSTC_ID");
                    tb.HasTrigger("themTDung_HosoTdung_HinhThucTSTC_ID");
                });

            entity.Property(e => e.TstcId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TSTC_ID");
            entity.Property(e => e.ChinhanhId)
                .HasMaxLength(30)
                .HasColumnName("Chinhanh_id");
            entity.Property(e => e.ChuTsCmtngaycap)
                .HasColumnType("datetime")
                .HasColumnName("ChuTS_CMTNgaycap");
            entity.Property(e => e.ChuTsCmtnoicap)
                .HasMaxLength(100)
                .HasDefaultValueSql("('')")
                .HasColumnName("ChuTS_CMTNoicap");
            entity.Property(e => e.ChuTsDiachi)
                .HasMaxLength(250)
                .HasDefaultValueSql("('')")
                .HasColumnName("ChuTS_Diachi");
            entity.Property(e => e.ChuTsDienthoai)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ChuTS_Dienthoai");
            entity.Property(e => e.ChuTsHoten)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasColumnName("ChuTS_Hoten");
            entity.Property(e => e.ChuTsSoCmt)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ChuTS_SoCMT");
            entity.Property(e => e.DateModify)
                .HasColumnType("datetime")
                .HasColumnName("Date_Modify");
            entity.Property(e => e.DateNew)
                .HasColumnType("datetime")
                .HasColumnName("Date_New");
            entity.Property(e => e.HoSoTdId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("HoSoTD_ID");
            entity.Property(e => e.KhachhangId)
                .HasMaxLength(20)
                .HasColumnName("Khachhang_ID");
            entity.Property(e => e.TstcDdkyThuat)
                .HasMaxLength(250)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("TSTC_DDKyThuat");
            entity.Property(e => e.TstcGhiChu)
                .HasMaxLength(200)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("TSTC_GhiChu");
            entity.Property(e => e.TstcGhiChuXuat)
                .HasMaxLength(200)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("TSTC_GhiChu_Xuat");
            entity.Property(e => e.TstcHdtc)
                .HasMaxLength(40)
                .HasColumnName("TSTC_HDTC");
            entity.Property(e => e.TstcKyHieu)
                .HasMaxLength(50)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("TSTC_KyHieu");
            entity.Property(e => e.TstcMa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TSTC_Ma");
            entity.Property(e => e.TstcMaLoai)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("TSTC_Ma_Loai");
            entity.Property(e => e.TstcMaNhom)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("TSTC_Ma_Nhom");
            entity.Property(e => e.TstcNgayDuyet)
                .HasColumnType("smalldatetime")
                .HasColumnName("TSTC_NgayDuyet");
            entity.Property(e => e.TstcNgayXuat)
                .HasColumnType("smalldatetime")
                .HasColumnName("TSTC_NgayXuat");
            entity.Property(e => e.TstcSoCtuXuat)
                .HasMaxLength(20)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("TSTC_So_CTU_Xuat");
            entity.Property(e => e.TstcSoLuong).HasColumnName("TSTC_SoLuong");
            entity.Property(e => e.TstcTaiKhoan)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("TSTC_Tai_Khoan");
            entity.Property(e => e.TstcTen)
                .HasMaxLength(250)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("TSTC_Ten");
            entity.Property(e => e.TstcThanhTien).HasColumnName("TSTC_ThanhTien");
            entity.Property(e => e.TstcTrangThai).HasColumnName("TSTC_TrangThai");
            entity.Property(e => e.TstcTrangThaiXuat).HasColumnName("TSTC_TrangThai_Xuat");
            entity.Property(e => e.TstcTyLeDp).HasColumnName("TSTC_TyLeDP");
            entity.Property(e => e.UsersModify)
                .HasMaxLength(50)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Users_Modify");
            entity.Property(e => e.UsersNew)
                .HasMaxLength(50)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Users_New");
        });

        modelBuilder.Entity<TdungTaisanthechapDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Tdung_Taisanthechap_Detail");

            entity.Property(e => e.ChiTieu)
                .HasMaxLength(100)
                .HasColumnName("Chi_tieu");
            entity.Property(e => e.GiaTri)
                .HasMaxLength(200)
                .HasColumnName("Gia_tri");
            entity.Property(e => e.Id0)
                .HasMaxLength(50)
                .HasColumnName("ID0");
            entity.Property(e => e.MaLoai)
                .HasMaxLength(50)
                .HasColumnName("Ma_loai");
            entity.Property(e => e.TstcId)
                .HasMaxLength(50)
                .HasColumnName("TSTC_ID");
        });

        modelBuilder.Entity<TdungTaisanthechapDetailMau>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tdung_taisanthechap_DetailMau");

            entity.Property(e => e.ChiTieu)
                .HasMaxLength(100)
                .HasColumnName("Chi_tieu");
            entity.Property(e => e.GiaTri)
                .HasMaxLength(200)
                .HasColumnName("Gia_tri");
            entity.Property(e => e.Id0)
                .HasMaxLength(50)
                .HasColumnName("ID0");
            entity.Property(e => e.MaLoai)
                .HasMaxLength(50)
                .HasColumnName("Ma_loai");
        });

        modelBuilder.Entity<TdungTmp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tdung_tmp");

            entity.Property(e => e.HopDong)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("hop_dong");
            entity.Property(e => e.TaiKhoanCu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tai_khoan_cu");
            entity.Property(e => e.TaiKhoanMoi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tai_khoan_moi");
        });

        modelBuilder.Entity<TdungTstcStk>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Tdung_TSTC_STK", tb => tb.HasTrigger("trg_TSTC_STK_DEL"));

            entity.Property(e => e.ChinhanhId)
                .HasMaxLength(30)
                .HasColumnName("Chinhanh_id");
            entity.Property(e => e.DateModify)
                .HasColumnType("datetime")
                .HasColumnName("Date_Modify");
            entity.Property(e => e.DateNew)
                .HasColumnType("datetime")
                .HasColumnName("Date_New");
            entity.Property(e => e.HoSoTdId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("HoSoTD_ID");
            entity.Property(e => e.StkSoTietkiem)
                .HasMaxLength(20)
                .HasColumnName("STK_SoTietkiem");
            entity.Property(e => e.TstcDdkyThuat)
                .HasMaxLength(250)
                .HasColumnName("TSTC_DDKyThuat");
            entity.Property(e => e.TstcGhiChu)
                .HasMaxLength(200)
                .HasColumnName("TSTC_GhiChu");
            entity.Property(e => e.TstcHdtc)
                .HasMaxLength(40)
                .HasColumnName("TSTC_HDTC");
            entity.Property(e => e.TstcId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TSTC_ID");
            entity.Property(e => e.TstcKyHieu)
                .HasMaxLength(50)
                .HasColumnName("TSTC_KyHieu");
            entity.Property(e => e.TstcMaNhom)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TSTC_Ma_Nhom");
            entity.Property(e => e.TstcNgayDuyet)
                .HasColumnType("smalldatetime")
                .HasColumnName("TSTC_NgayDuyet");
            entity.Property(e => e.TstcThanhTien).HasColumnName("TSTC_ThanhTien");
            entity.Property(e => e.UsersModify)
                .HasMaxLength(50)
                .HasColumnName("Users_Modify");
            entity.Property(e => e.UsersNew)
                .HasMaxLength(50)
                .HasColumnName("Users_New");
        });

        modelBuilder.Entity<TdungTstcTemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TDung_TSTC_Temp");

            entity.Property(e => e.GhiChu).HasMaxLength(50);
            entity.Property(e => e.HopDongId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HopDong_ID");
            entity.Property(e => e.KyHieuTstc)
                .HasMaxLength(50)
                .HasColumnName("KyHieu_TSTC");
            entity.Property(e => e.NgayNhap)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TenTstc)
                .HasMaxLength(50)
                .HasColumnName("Ten_TSTC");
            entity.Property(e => e.TriGia).HasColumnType("money");
        });

        modelBuilder.Entity<TdungVtcOfHsid>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TDung_VTC_Of_HSID");

            entity.Property(e => e.HosoTdId)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasColumnName("HosoTd_ID");
            entity.Property(e => e.NgayHd)
                .HasColumnType("smalldatetime")
                .HasColumnName("Ngay_HD");
            entity.Property(e => e.SoTien1).HasColumnName("So_tien1");
            entity.Property(e => e.SoTien2).HasColumnName("So_tien2");
            entity.Property(e => e.SoTien3).HasColumnName("So_tien3");
            entity.Property(e => e.VonTuCo).HasColumnName("Von_Tu_co");
        });

        modelBuilder.Entity<TdungXulyNo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Tdung_XulyNo");

            entity.Property(e => e.ChinhanhId)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasColumnName("Chinhanh_ID");
            entity.Property(e => e.HosoTdId)
                .HasMaxLength(50)
                .HasColumnName("HosoTD_ID");
            entity.Property(e => e.Ngay).HasColumnType("datetime");
            entity.Property(e => e.QhNh1).HasColumnName("QH_NH1");
            entity.Property(e => e.QhNh2).HasColumnName("QH_NH2");
            entity.Property(e => e.QhNh3).HasColumnName("QH_NH3");
            entity.Property(e => e.QhNh4).HasColumnName("QH_NH4");
            entity.Property(e => e.QhNh5).HasColumnName("QH_NH5");
            entity.Property(e => e.ThNh1).HasColumnName("TH_NH1");
            entity.Property(e => e.ThNh2).HasColumnName("TH_NH2");
            entity.Property(e => e.ThNh3).HasColumnName("TH_NH3");
            entity.Property(e => e.ThNh4).HasColumnName("TH_NH4");
            entity.Property(e => e.ThNh5).HasColumnName("TH_NH5");
        });

        modelBuilder.Entity<TempCandoi>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TempCandoi");

            entity.Property(e => e.Cocuoiky)
                .HasDefaultValueSql("((0))")
                .HasColumnName("cocuoiky");
            entity.Property(e => e.Codauky)
                .HasDefaultValueSql("((0))")
                .HasColumnName("codauky");
            entity.Property(e => e.Cophatsinh)
                .HasDefaultValueSql("((0))")
                .HasColumnName("cophatsinh");
            entity.Property(e => e.Matktonghop)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("matktonghop");
            entity.Property(e => e.Nocuoiky)
                .HasDefaultValueSql("((0))")
                .HasColumnName("nocuoiky");
            entity.Property(e => e.Nodauky)
                .HasDefaultValueSql("((0))")
                .HasColumnName("nodauky");
            entity.Property(e => e.Nophatsinh)
                .HasDefaultValueSql("((0))")
                .HasColumnName("nophatsinh");
            entity.Property(e => e.Tentaikhoan)
                .HasMaxLength(250)
                .HasColumnName("tentaikhoan");
        });

        modelBuilder.Entity<TempPtkntt>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tempPTKNTT");

            entity.Property(e => e.Co7homsau).HasColumnName("Co_7Homsau");
            entity.Property(e => e.CoHomsau).HasColumnName("Co_Homsau");
            entity.Property(e => e.Ngay)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.No7homsau).HasColumnName("No_7Homsau");
            entity.Property(e => e.NoHomsau).HasColumnName("No_Homsau");
            entity.Property(e => e.Stt).HasColumnName("STT");
            entity.Property(e => e.TyLe7homSau)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("TyLe_7HomSau");
            entity.Property(e => e.TyleHomSau)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Tyle_HomSau");
        });

        modelBuilder.Entity<TempTongduno>(entity =>
        {
            entity.HasKey(e => e.KhachHangId).HasName("PK__Temp_Ton__16A1551A28BD772E");

            entity.ToTable("Temp_Tongduno");

            entity.Property(e => e.KhachHangId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KhachHang_ID");
            entity.Property(e => e.CmtSerial)
                .HasMaxLength(20)
                .HasColumnName("CMT_Serial");
            entity.Property(e => e.DiaChi)
                .HasMaxLength(255)
                .HasColumnName("Dia_Chi");
            entity.Property(e => e.Ten).HasMaxLength(255);
            entity.Property(e => e.TotalDebt).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<TempTotalDebt>(entity =>
        {
            entity.HasKey(e => e.KhachHangId).HasName("PK__TempTota__16A1551A3004DEBB");

            entity.ToTable("TempTotalDebt");

            entity.Property(e => e.KhachHangId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KhachHang_ID");
            entity.Property(e => e.CmtSerial)
                .HasMaxLength(20)
                .HasColumnName("CMT_Serial");
            entity.Property(e => e.DiaChi)
                .HasMaxLength(255)
                .HasColumnName("Dia_Chi");
            entity.Property(e => e.Ten).HasMaxLength(255);
            entity.Property(e => e.TotalDebt).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<TguiGiaingan>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TGUI_GIAINGAN");

            entity.Property(e => e.DateModify)
                .HasColumnType("datetime")
                .HasColumnName("Date_Modify");
            entity.Property(e => e.DateNew)
                .HasColumnType("datetime")
                .HasColumnName("Date_New");
            entity.Property(e => e.GiaoDichId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GiaoDich_ID");
            entity.Property(e => e.GiaoDichId2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GiaoDich_ID2");
            entity.Property(e => e.GnGhiChu)
                .HasMaxLength(500)
                .HasColumnName("GN_GhiChu");
            entity.Property(e => e.GnGhiChuDcgr)
                .HasMaxLength(500)
                .HasColumnName("GN_GhiChu_DCGR");
            entity.Property(e => e.GnId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GN_ID");
            entity.Property(e => e.GnLoaiChungTu)
                .HasMaxLength(20)
                .HasColumnName("GN_LoaiChungTu");
            entity.Property(e => e.GnNgayGiaiNgan)
                .HasColumnType("smalldatetime")
                .HasColumnName("GN_NgayGiaiNgan");
            entity.Property(e => e.GnSoTien).HasColumnName("GN_SoTien");
            entity.Property(e => e.GnTkco)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GN_TKCo");
            entity.Property(e => e.GnTkno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GN_TKNo");
            entity.Property(e => e.HinhThucGnId).HasColumnName("HinhThucGN_ID");
            entity.Property(e => e.SoChungTu).HasMaxLength(20);
            entity.Property(e => e.UsersModify)
                .HasMaxLength(20)
                .HasColumnName("Users_Modify");
            entity.Property(e => e.UsersNew)
                .HasMaxLength(20)
                .HasColumnName("Users_New");
        });

        modelBuilder.Entity<TguiGiainganTmp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TGUI_GIAINGAN_TMP");

            entity.Property(e => e.DateModify)
                .HasColumnType("datetime")
                .HasColumnName("Date_Modify");
            entity.Property(e => e.DateNew)
                .HasColumnType("datetime")
                .HasColumnName("Date_New");
            entity.Property(e => e.GiaoDichId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GiaoDich_ID");
            entity.Property(e => e.GiaoDichId2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GiaoDich_ID2");
            entity.Property(e => e.GnGhiChu)
                .HasMaxLength(500)
                .HasColumnName("GN_GhiChu");
            entity.Property(e => e.GnId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GN_ID");
            entity.Property(e => e.GnLoaiChungTu)
                .HasMaxLength(20)
                .HasColumnName("GN_LoaiChungTu");
            entity.Property(e => e.GnNgayGiaiNgan)
                .HasColumnType("smalldatetime")
                .HasColumnName("GN_NgayGiaiNgan");
            entity.Property(e => e.GnSoTien).HasColumnName("GN_SoTien");
            entity.Property(e => e.GnTkco)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GN_TKCo");
            entity.Property(e => e.GnTkno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GN_TKNo");
            entity.Property(e => e.HinhThucGnId).HasColumnName("HinhThucGN_ID");
            entity.Property(e => e.SoChungTu).HasMaxLength(20);
            entity.Property(e => e.UsersModify)
                .HasMaxLength(20)
                .HasColumnName("Users_Modify");
            entity.Property(e => e.UsersNew)
                .HasMaxLength(20)
                .HasColumnName("Users_New");
        });

        modelBuilder.Entity<TguiGiaodich>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TGUI_GIAODICH");

            entity.Property(e => e.ChiNhanhMa)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ChiNhanh_Ma");
            entity.Property(e => e.DuChiCu)
                .HasColumnType("money")
                .HasColumnName("DuChi_Cu");
            entity.Property(e => e.GdtkDienGiai)
                .HasMaxLength(500)
                .HasDefaultValueSql("('')")
                .HasColumnName("GDTK_DienGiai");
            entity.Property(e => e.GdtkLoaiGiaoDichMa)
                .HasMaxLength(20)
                .HasColumnName("GDTK_LoaiGiaoDich_Ma");
            entity.Property(e => e.GdtkLoaiso)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValueSql("('TK')")
                .HasColumnName("GDTK_Loaiso");
            entity.Property(e => e.GdtkMa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GDTK_Ma");
            entity.Property(e => e.GdtkMa2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GDTK_Ma2");
            entity.Property(e => e.GdtkNgayApDung)
                .HasColumnType("datetime")
                .HasColumnName("GDTK_NgayApDung");
            entity.Property(e => e.GdtkNgayCapNhat)
                .HasColumnType("datetime")
                .HasColumnName("GDTK_NgayCapNhat");
            entity.Property(e => e.GdtkNgayGiaoDich)
                .HasColumnType("datetime")
                .HasColumnName("GDTK_NgayGiaoDich");
            entity.Property(e => e.GdtkNgayNhap)
                .HasColumnType("datetime")
                .HasColumnName("GDTK_NgayNhap");
            entity.Property(e => e.GdtkNguoiCapNhat)
                .HasMaxLength(20)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("GDTK_NguoiCapNhat");
            entity.Property(e => e.GdtkNguoiNhap)
                .HasMaxLength(20)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("GDTK_NguoiNhap");
            entity.Property(e => e.GdtkSoChungTu)
                .HasMaxLength(50)
                .HasColumnName("GDTK_SoChungTu");
            entity.Property(e => e.GdtkSoTien)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("GDTK_SoTien");
            entity.Property(e => e.GdtkSoTienDuChi)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("GDTK_SoTienDuChi");
            entity.Property(e => e.GdtkSoTietKiem)
                .HasMaxLength(20)
                .HasColumnName("GDTK_SoTietKiem");
            entity.Property(e => e.GdtkTrangThai)
                .HasDefaultValueSql("((0))")
                .HasColumnName("GDTK_TrangThai");
            entity.Property(e => e.LaiDaTraCu)
                .HasColumnType("money")
                .HasColumnName("LaiDaTra_Cu");
            entity.Property(e => e.LaiSuatCu)
                .HasColumnType("money")
                .HasColumnName("LaiSuat_Cu");
            entity.Property(e => e.NgayBatDauTinhLaiCu)
                .HasColumnType("datetime")
                .HasColumnName("NgayBatDauTinhLai_Cu");
            entity.Property(e => e.NgayDenHanCu)
                .HasColumnType("datetime")
                .HasColumnName("NgayDenHan_Cu");
            entity.Property(e => e.NgayDuChiCu)
                .HasColumnType("datetime")
                .HasColumnName("NgayDuChi_Cu");
            entity.Property(e => e.NgayKyMoiCu)
                .HasColumnType("datetime")
                .HasColumnName("NgayKyMoi_Cu");
            entity.Property(e => e.SanPhamMaCu)
                .HasMaxLength(20)
                .HasColumnName("SanPham_Ma_Cu");
            entity.Property(e => e.SoDuCu)
                .HasColumnType("money")
                .HasColumnName("SoDu_Cu");
            entity.Property(e => e.StkMa)
                .HasMaxLength(20)
                .HasColumnName("STK_Ma");
            entity.Property(e => e.TienTeMa)
                .HasMaxLength(20)
                .HasDefaultValueSql("('00')")
                .HasColumnName("TienTe_Ma");
            entity.Property(e => e.TienTeTyGia)
                .HasDefaultValueSql("((1))")
                .HasColumnType("money")
                .HasColumnName("TienTe_TyGia");
        });

        modelBuilder.Entity<TguiLaisuatsanpham>(entity =>
        {
            entity.HasKey(e => new { e.LsMa, e.SanPhamMa }).HasName("PK_TGUI_LAISUAT");

            entity.ToTable("TGUI_LAISUATSANPHAM");

            entity.Property(e => e.LsMa)
                .HasMaxLength(20)
                .HasColumnName("LS_Ma");
            entity.Property(e => e.SanPhamMa)
                .HasMaxLength(20)
                .HasColumnName("SanPham_Ma");
            entity.Property(e => e.LsDenNgay)
                .HasColumnType("datetime")
                .HasColumnName("LS_DenNgay");
            entity.Property(e => e.LsGhiChu)
                .HasMaxLength(255)
                .HasColumnName("LS_GhiChu");
            entity.Property(e => e.LsLaiSuat)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("LS_LaiSuat");
            entity.Property(e => e.LsNam)
                .HasColumnType("money")
                .HasColumnName("LS_Nam");
            entity.Property(e => e.LsTuNgay)
                .HasColumnType("datetime")
                .HasColumnName("LS_TuNgay");
        });

        modelBuilder.Entity<TguiLaisuatstg>(entity =>
        {
            entity.HasKey(e => e.LsMa).HasName("PK_TKIEM_LaiSuatSoTienGui");

            entity.ToTable("TGUI_LAISUATSTG");

            entity.Property(e => e.LsMa).HasColumnName("LS_Ma");
            entity.Property(e => e.LsGhiChu)
                .HasMaxLength(255)
                .HasColumnName("LS_GhiChu");
            entity.Property(e => e.LsLaiSuat)
                .HasColumnType("money")
                .HasColumnName("LS_LaiSuat");
            entity.Property(e => e.LsTuNgay)
                .HasColumnType("datetime")
                .HasColumnName("LS_TuNgay");
            entity.Property(e => e.StkMa)
                .HasMaxLength(20)
                .HasColumnName("STK_Ma");

            entity.HasOne(d => d.StkMaNavigation).WithMany(p => p.TguiLaisuatstgs)
                .HasForeignKey(d => d.StkMa)
                .HasConstraintName("FK_TGUI_LAISUATSTG_TGUI_SOTIENGUI");
        });

        modelBuilder.Entity<TguiSanpham>(entity =>
        {
            entity.HasKey(e => e.SanPhamMa).HasName("PK_TGUI_SanPham");

            entity.ToTable("TGUI_SANPHAM");

            entity.Property(e => e.SanPhamMa)
                .HasMaxLength(20)
                .HasColumnName("SanPham_Ma");
            entity.Property(e => e.DvkyHanMa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DVKyHan_Ma");
            entity.Property(e => e.LoaiSpMa)
                .HasMaxLength(20)
                .HasColumnName("LoaiSP_Ma");
            entity.Property(e => e.SanPhamGhiChu)
                .HasMaxLength(255)
                .HasColumnName("SanPham_GhiChu");
            entity.Property(e => e.SanPhamKyHan).HasColumnName("SanPham_KyHan");
            entity.Property(e => e.SanPhamNgayCn)
                .HasColumnType("datetime")
                .HasColumnName("SanPham_NgayCN");
            entity.Property(e => e.SanPhamNgayNhap)
                .HasColumnType("datetime")
                .HasColumnName("SanPham_NgayNhap");
            entity.Property(e => e.SanPhamNguoiCn)
                .HasMaxLength(20)
                .HasColumnName("SanPham_NguoiCN");
            entity.Property(e => e.SanPhamNguoiNhap)
                .HasMaxLength(20)
                .HasColumnName("SanPham_NguoiNhap");
            entity.Property(e => e.SanPhamTen)
                .HasMaxLength(255)
                .HasColumnName("SanPham_Ten");
            entity.Property(e => e.SanPhamTenTat)
                .HasMaxLength(20)
                .HasColumnName("SanPham_TenTat");
            entity.Property(e => e.TienTeMa)
                .HasMaxLength(20)
                .HasColumnName("TienTe_Ma");
            entity.Property(e => e.Tk1)
                .HasMaxLength(20)
                .HasColumnName("TK1");
            entity.Property(e => e.Tk2)
                .HasMaxLength(20)
                .HasColumnName("TK2");
            entity.Property(e => e.Tk3)
                .HasMaxLength(20)
                .HasColumnName("TK3");
            entity.Property(e => e.Tk4)
                .HasMaxLength(20)
                .HasColumnName("TK4");
            entity.Property(e => e.Tk5)
                .HasMaxLength(20)
                .HasColumnName("TK5");
            entity.Property(e => e.Tk6)
                .HasMaxLength(20)
                .HasColumnName("TK6");

            entity.HasOne(d => d.DvkyHanMaNavigation).WithMany(p => p.TguiSanphams)
                .HasForeignKey(d => d.DvkyHanMa)
                .HasConstraintName("FK_TGUI_SANPHAM_DM_DV_Ky_Han");
        });

        modelBuilder.Entity<TguiSotiengui>(entity =>
        {
            entity.HasKey(e => e.StkMa);

            entity.ToTable("TGUI_SOTIENGUI");

            entity.Property(e => e.StkMa)
                .HasMaxLength(20)
                .HasColumnName("STK_Ma");
            entity.Property(e => e.ChiNhanhMa)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("ChiNhanh_Ma");
            entity.Property(e => e.HttlMa)
                .HasMaxLength(20)
                .HasColumnName("HTTL_Ma");
            entity.Property(e => e.KhachHangMa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("KhachHang_Ma");
            entity.Property(e => e.SanPhamMa)
                .HasMaxLength(20)
                .HasColumnName("SanPham_Ma");
            entity.Property(e => e.StkCoTheThayDoiLaiSuat).HasColumnName("STK_CoTheThayDoiLaiSuat");
            entity.Property(e => e.StkDaLaiNhapGoc)
                .HasDefaultValueSql("((0))")
                .HasColumnName("STK_DaLaiNhapGoc");
            entity.Property(e => e.StkDuChi)
                .HasColumnType("money")
                .HasColumnName("STK_DuChi");
            entity.Property(e => e.StkDuChiDenNgay)
                .HasColumnType("datetime")
                .HasColumnName("STK_DuChiDenNgay");
            entity.Property(e => e.StkGhiChu)
                .HasMaxLength(255)
                .HasColumnName("STK_GhiChu");
            entity.Property(e => e.StkLaiDaTra)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("STK_LaiDaTra");
            entity.Property(e => e.StkNgayBatDau)
                .HasColumnType("datetime")
                .HasColumnName("STK_NgayBatDau");
            entity.Property(e => e.StkNgayBatDauTinhLai)
                .HasColumnType("datetime")
                .HasColumnName("STK_NgayBatDauTinhLai");
            entity.Property(e => e.StkNgayCapNhat)
                .HasColumnType("datetime")
                .HasColumnName("STK_NgayCapNhat");
            entity.Property(e => e.StkNgayDenHan)
                .HasColumnType("datetime")
                .HasColumnName("STK_NgayDenHan");
            entity.Property(e => e.StkNgayKyMoi)
                .HasColumnType("datetime")
                .HasColumnName("STK_NgayKyMoi");
            entity.Property(e => e.StkNgayNhap)
                .HasColumnType("datetime")
                .HasColumnName("STK_NgayNhap");
            entity.Property(e => e.StkNgayPhongToa)
                .HasColumnType("datetime")
                .HasColumnName("STK_NgayPhongToa");
            entity.Property(e => e.StkNguoiCapNhat)
                .HasMaxLength(20)
                .HasColumnName("STK_NguoiCapNhat");
            entity.Property(e => e.StkNguoiNhap)
                .HasMaxLength(20)
                .HasColumnName("STK_NguoiNhap");
            entity.Property(e => e.StkPhongToa).HasColumnName("STK_PhongToa");
            entity.Property(e => e.StkSoDu)
                .HasColumnType("money")
                .HasColumnName("STK_SoDu");
            entity.Property(e => e.StkSoTietKiem)
                .HasMaxLength(20)
                .HasColumnName("STK_SoTietKiem");
            entity.Property(e => e.StkTen)
                .HasMaxLength(255)
                .HasColumnName("STK_Ten");
            entity.Property(e => e.StkTkct)
                .HasMaxLength(20)
                .HasColumnName("STK_TKCT");
            entity.Property(e => e.StkTrangThai).HasColumnName("STK_TrangThai");
            entity.Property(e => e.StkTt14).HasColumnName("STK_TT14");
            entity.Property(e => e.TienTeMa)
                .HasMaxLength(20)
                .HasColumnName("TienTe_Ma");

            entity.HasOne(d => d.ChiNhanhMaNavigation).WithMany(p => p.TguiSotienguis)
                .HasForeignKey(d => d.ChiNhanhMa)
                .HasConstraintName("FK_TGUI_SOTIENGUI_DM_CHINHANH");

            entity.HasOne(d => d.SanPhamMaNavigation).WithMany(p => p.TguiSotienguis)
                .HasForeignKey(d => d.SanPhamMa)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_TGUI_SOTIENGUI_TGUI_SANPHAM");
        });

        modelBuilder.Entity<ThanhVienChitietSerial>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ThanhVien_ChitietSerial");

            entity.Property(e => e.GhiChu)
                .HasMaxLength(100)
                .HasDefaultValueSql("('')")
                .HasColumnName("Ghi_chu");
            entity.Property(e => e.KhachhangId)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasColumnName("Khachhang_Id");
            entity.Property(e => e.Ngay).HasColumnType("datetime");
            entity.Property(e => e.SoTien).HasColumnName("So_tien");
            entity.Property(e => e.ThanhvienSerial)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasColumnName("Thanhvien_Serial");
        });

        modelBuilder.Entity<TienluongTemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tienluong_temp");

            entity.Property(e => e.HopDong)
                .HasMaxLength(50)
                .HasColumnName("hop_dong");
            entity.Property(e => e.SoTienLuong).HasColumnName("so_tien_luong");
        });

        modelBuilder.Entity<TietkiemTemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tietkiem_temp");

            entity.Property(e => e.DuChi).HasColumnName("du_chi");
            entity.Property(e => e.NgayBdtl)
                .HasColumnType("datetime")
                .HasColumnName("ngay_bdtl");
            entity.Property(e => e.Stk)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("stk");
        });

        modelBuilder.Entity<TkeBcb03>(entity =>
        {
            entity.HasKey(e => new { e.TenBieu, e.Id, e.Ngay });

            entity.ToTable("TKE_BCB03");

            entity.Property(e => e.TenBieu)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Ngay).HasColumnType("datetime");
            entity.Property(e => e.DaChotSoLieu)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.NamTruocCuoiQuy).HasColumnName("NamTruoc_CuoiQuy");
            entity.Property(e => e.NamTruocLuyKe).HasColumnName("NamTruoc_LuyKe");
            entity.Property(e => e.UsersDate)
                .HasColumnType("datetime")
                .HasColumnName("Users_Date");
            entity.Property(e => e.UsersNew)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Users_New");
        });

        modelBuilder.Entity<TkeBcchitieu>(entity =>
        {
            entity.HasKey(e => new { e.Tenbieu, e.Id, e.Machitieu }).HasName("PK_BC_CHITIEU");

            entity.ToTable("TKE_BCCHITIEU");

            entity.Property(e => e.Tenbieu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TENBIEU");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Machitieu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MACHITIEU");
            entity.Property(e => e.Chitieu)
                .HasMaxLength(300)
                .HasColumnName("CHITIEU");
            entity.Property(e => e.Cot).HasColumnName("COT");
        });

        modelBuilder.Entity<TkeBccongthuc>(entity =>
        {
            entity.HasKey(e => new { e.Tenbieu, e.Id }).HasName("PK_BC_CONGTHUC");

            entity.ToTable("TKE_BCCONGTHUC");

            entity.Property(e => e.Tenbieu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TENBIEU");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Chenhlech)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("CHENHLECH");
            entity.Property(e => e.Chitieu)
                .HasMaxLength(300)
                .HasColumnName("CHITIEU");
            entity.Property(e => e.Congtru)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("CONGTRU");
            entity.Property(e => e.Indam)
                .HasDefaultValueSql("((0))")
                .HasColumnName("INDAM");
            entity.Property(e => e.Nhatsolieu)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("NHATSOLIEU");
            entity.Property(e => e.Stt)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STT");
        });

        modelBuilder.Entity<TkeChitieu>(entity =>
        {
            entity.HasKey(e => e.ChitieuMa).HasName("PK_ITDVAPCF_TKE_CHITIEU");

            entity.ToTable("TKE_CHITIEU");

            entity.Property(e => e.ChitieuMa)
                .HasMaxLength(30)
                .HasDefaultValueSql("('')")
                .HasColumnName("CHITIEU_MA");
            entity.Property(e => e.ChitieuMota)
                .HasMaxLength(255)
                .HasColumnName("CHITIEU_MOTA");
            entity.Property(e => e.ChitieuTen)
                .HasMaxLength(255)
                .HasColumnName("CHITIEU_TEN");
            entity.Property(e => e.CtMathongke)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasColumnName("CT_MATHONGKE");
            entity.Property(e => e.CtgocMa)
                .HasMaxLength(30)
                .HasColumnName("CTGOC_MA");
        });

        modelBuilder.Entity<TkeCtcongthuc>(entity =>
        {
            entity.HasKey(e => e.CtgocMa).HasName("PK_CT_CONGTHUC");

            entity.ToTable("TKE_CTCONGTHUC");

            entity.Property(e => e.CtgocMa)
                .HasMaxLength(20)
                .HasColumnName("CTGOC_MA");
            entity.Property(e => e.Congthuc)
                .HasMaxLength(50)
                .HasColumnName("CONGTHUC");
            entity.Property(e => e.Dieukien)
                .HasMaxLength(400)
                .HasColumnName("DIEUKIEN");
            entity.Property(e => e.Loaidl).HasColumnName("LOAIDL");
        });

        modelBuilder.Entity<TkeCtgoc>(entity =>
        {
            entity.HasKey(e => e.CtgocMa).HasName("PK_ITDVAPCF_TKE_CTGOC");

            entity.ToTable("TKE_CTGOC");

            entity.Property(e => e.CtgocMa)
                .HasMaxLength(20)
                .HasColumnName("CTGOC_MA");
            entity.Property(e => e.CtgocDinhky)
                .HasMaxLength(8)
                .HasColumnName("CTGOC_DINHKY");
            entity.Property(e => e.CtgocMathongke)
                .HasMaxLength(50)
                .HasColumnName("CTGOC_MATHONGKE");
            entity.Property(e => e.CtgocMota)
                .HasMaxLength(255)
                .HasColumnName("CTGOC_MOTA");
            entity.Property(e => e.CtgocTen)
                .HasMaxLength(255)
                .HasColumnName("CTGOC_TEN");
            entity.Property(e => e.NhomctMa)
                .HasMaxLength(20)
                .HasColumnName("NHOMCT_MA");
        });

        modelBuilder.Entity<TkeDmbaocao>(entity =>
        {
            entity.HasKey(e => e.MaBc).HasName("PK_ITDVAPCF_TKE_DMBaoCao");

            entity.ToTable("TKE_DMBAOCAO");

            entity.Property(e => e.MaBc)
                .HasMaxLength(20)
                .HasColumnName("MaBC");
            entity.Property(e => e.Mabieu)
                .HasMaxLength(50)
                .HasColumnName("mabieu");
            entity.Property(e => e.TenBc)
                .HasMaxLength(255)
                .HasColumnName("TenBC");
        });

        modelBuilder.Entity<TkeGiatrichitieu>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TKE_GIATRICHITIEU");

            entity.Property(e => e.ChitieuMa)
                .HasMaxLength(30)
                .HasDefaultValueSql("((0))")
                .HasColumnName("chitieu_ma");
            entity.Property(e => e.Dinhky)
                .HasMaxLength(8)
                .HasColumnName("dinhky");
            entity.Property(e => e.Giatri).HasColumnName("giatri");
        });

        modelBuilder.Entity<TkiemBhtg2252Chitieu>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TKIEM_BHTG2252_CHITIEU");

            entity.Property(e => e.ChiTieu)
                .HasMaxLength(300)
                .HasColumnName("CHI_TIEU");
            entity.Property(e => e.Id)
                .HasMaxLength(20)
                .HasColumnName("ID");
            entity.Property(e => e.SoduCq).HasColumnName("SODU_CQ");
            entity.Property(e => e.SoduCuoi1).HasColumnName("SODU_CUOI1");
            entity.Property(e => e.SoduCuoi2).HasColumnName("SODU_CUOI2");
            entity.Property(e => e.SoduDq).HasColumnName("SODU_DQ");
            entity.Property(e => e.Stt)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("STT");
        });

        modelBuilder.Entity<TkiemBhtgMaubc>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TKIEM_BHTG_MAUBC");

            entity.Property(e => e.ChiTieu)
                .HasMaxLength(300)
                .HasColumnName("CHI_TIEU");
            entity.Property(e => e.Congtru)
                .HasMaxLength(300)
                .HasColumnName("CONGTRU");
            entity.Property(e => e.Id)
                .HasMaxLength(20)
                .HasColumnName("ID");
            entity.Property(e => e.LoaidnMa)
                .HasMaxLength(40)
                .HasColumnName("LOAIDN_MA");
            entity.Property(e => e.Nhatsolieu)
                .HasMaxLength(300)
                .HasColumnName("NHATSOLIEU");
            entity.Property(e => e.Stt)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("STT");
            entity.Property(e => e.Tenbieu)
                .HasMaxLength(50)
                .HasColumnName("TENBIEU");
        });

        modelBuilder.Entity<TkiemChuyentienGiaodich>(entity =>
        {
            entity.HasKey(e => e.Ma).HasName("PK_CHUYENTIEN_GIAODICH");

            entity.ToTable("TKIEM_CHUYENTIEN_GIAODICH");

            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ChiNhanhDauMoiGuiMa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ChiNhanhDauMoiGui_Ma");
            entity.Property(e => e.ChiNhanhDauMoiNhanMa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ChiNhanhDauMoiNhan_Ma");
            entity.Property(e => e.DateModify).HasColumnType("datetime");
            entity.Property(e => e.DateNew).HasColumnType("datetime");
            entity.Property(e => e.DonViKhoiPhatGiaoDichMa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DonViKhoiPhatGiaoDich_Ma");
            entity.Property(e => e.DonViNhanGiaoDichMa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DonViNhanGiaoDich_Ma");
            entity.Property(e => e.HanMucKhachHangThuHuong)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("HanMuc_KhachHang_ThuHuong");
            entity.Property(e => e.KhachHangGuiCmnd)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KhachHangGui_CMND");
            entity.Property(e => e.KhachHangGuiCmndNgayCap)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KhachHangGui_CMND_NgayCap");
            entity.Property(e => e.KhachHangGuiCmndNoiCap)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("KhachHangGui_CMND_NoiCap");
            entity.Property(e => e.KhachHangGuiDiaChi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("KhachHangGui_DiaChi");
            entity.Property(e => e.KhachHangGuiMa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("KhachHangGui_Ma");
            entity.Property(e => e.KhachHangGuiTaiKhoanCaNhan)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KhachHangGui_TaiKhoanCaNhan");
            entity.Property(e => e.KhachHangGuiTen)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("KhachHangGui_Ten");
            entity.Property(e => e.KhachHangNhanCmnd)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KhachHangNhan_CMND");
            entity.Property(e => e.KhachHangNhanCmndNgayCap)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KhachHangNhan_CMND_NgayCap");
            entity.Property(e => e.KhachHangNhanCmndNoiCap)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("KhachHangNhan_CMND_NoiCap");
            entity.Property(e => e.KhachHangNhanDiaChi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("KhachHangNhan_DiaChi");
            entity.Property(e => e.KhachHangNhanMa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KhachHangNhan_Ma");
            entity.Property(e => e.KhachHangNhanTaiKhoanCaNhan)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KhachHangNhan_TaiKhoanCaNhan");
            entity.Property(e => e.KhachHangNhanTen)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KhachHangNhan_Ten");
            entity.Property(e => e.KyHieuChuyenTien)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.LePhiChuyen)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.LoaiGiaoDichChuyenTien)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.LoaiNghiepVuMa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("LoaiNghiepVu_Ma");
            entity.Property(e => e.LoaiTienTe)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.MaPhanLoaiDichVu)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.MaSoThueKhachHangThuHuong)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MaSoThue_KhachHang_ThuHuong");
            entity.Property(e => e.MaXacThuc)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NgayLamViecHeThong)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.NguoKiemSoatGiaoDichDonViNhan)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NguoKiemSoatGiaoDich_DonViNhan");
            entity.Property(e => e.NguoiDuyetGiaoDichDauMoiNhan)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NguoiDuyetGiaoDich_DauMoiNhan");
            entity.Property(e => e.NguoiKiemSoatGiaoDichDauMoiGui)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NguoiKiemSoatGiaoDich_DauMoiGui");
            entity.Property(e => e.NguoiKiemSoatGiaoDichDonViKhoiPhat)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NguoiKiemSoatGiaoDich_DonViKhoiPhat");
            entity.Property(e => e.NoiDungGiaoDich)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.SoButToan)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.SoHieuGiaoDich)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.SoTienGiaoDich).HasColumnType("money");
            entity.Property(e => e.TenFile)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ThoiDiemTaoGiaoDich).HasColumnType("datetime");
            entity.Property(e => e.ThoiGianKiemSoatGiaoDichDvn)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ThoiGianKiemSoatGiaoDich_DVN");
            entity.Property(e => e.ThongTinKqxlgiaoDich)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ThongTinKQXLGiaoDich");
            entity.Property(e => e.TinhTrangGiaoDich)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TrangThaiGiaoDichChuyenTien).HasDefaultValueSql("((0))");
            entity.Property(e => e.UserModify)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.UserNew)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TkiemGiaingan>(entity =>
        {
            entity.HasKey(e => new { e.GnId, e.GiaoDichId });

            entity.ToTable("TKIEM_GIAINGAN", tb =>
                {
                    tb.HasTrigger("trg_GIAODICHTK_DEL");
                    tb.HasTrigger("trg_GIAODICHTK_NganQuy_DEL");
                });

            entity.Property(e => e.GnId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GN_ID");
            entity.Property(e => e.GiaoDichId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GiaoDich_ID");
            entity.Property(e => e.DateModify)
                .HasColumnType("datetime")
                .HasColumnName("Date_Modify");
            entity.Property(e => e.DateNew)
                .HasColumnType("datetime")
                .HasColumnName("Date_New");
            entity.Property(e => e.GiaoDichId2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GiaoDich_ID2");
            entity.Property(e => e.GnGhiChu)
                .HasMaxLength(500)
                .HasColumnName("GN_GhiChu");
            entity.Property(e => e.GnGhiChuDcgr)
                .HasMaxLength(500)
                .HasColumnName("GN_GhiChu_DCGR");
            entity.Property(e => e.GnLoaiChungTu)
                .HasMaxLength(20)
                .HasColumnName("GN_LoaiChungTu");
            entity.Property(e => e.GnNgayGiaiNgan)
                .HasColumnType("smalldatetime")
                .HasColumnName("GN_NgayGiaiNgan");
            entity.Property(e => e.GnSoTien).HasColumnName("GN_SoTien");
            entity.Property(e => e.GnTkco)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GN_TKCo");
            entity.Property(e => e.GnTkno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GN_TKNo");
            entity.Property(e => e.HinhThucGnId).HasColumnName("HinhThucGN_ID");
            entity.Property(e => e.SoChungTu).HasMaxLength(20);
            entity.Property(e => e.UsersModify)
                .HasMaxLength(20)
                .HasColumnName("Users_Modify");
            entity.Property(e => e.UsersNew)
                .HasMaxLength(20)
                .HasColumnName("Users_New");

            entity.HasOne(d => d.GiaoDich).WithMany(p => p.TkiemGiaingans)
                .HasForeignKey(d => d.GiaoDichId)
                .HasConstraintName("FK_TKIEM_GIAINGAN_TKIEM_GIAODICH");
        });

        modelBuilder.Entity<TkiemGiainganKkh>(entity =>
        {
            entity.HasKey(e => new { e.GnId, e.GiaoDichId }).HasName("PK__TKIEM_GI__CA8C50B641AF61F3");

            entity.ToTable("TKIEM_GIAINGAN_KKH");

            entity.Property(e => e.GnId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GN_ID");
            entity.Property(e => e.GiaoDichId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GiaoDich_ID");
            entity.Property(e => e.DateModify)
                .HasColumnType("datetime")
                .HasColumnName("Date_Modify");
            entity.Property(e => e.DateNew)
                .HasColumnType("datetime")
                .HasColumnName("Date_New");
            entity.Property(e => e.GiaoDichId2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GiaoDich_ID2");
            entity.Property(e => e.GnGhiChu)
                .HasMaxLength(500)
                .HasColumnName("GN_GhiChu");
            entity.Property(e => e.GnGhiChuDcgr)
                .HasMaxLength(500)
                .HasColumnName("GN_GhiChu_DCGR");
            entity.Property(e => e.GnLoaiChungTu)
                .HasMaxLength(20)
                .HasColumnName("GN_LoaiChungTu");
            entity.Property(e => e.GnNgayGiaiNgan)
                .HasColumnType("smalldatetime")
                .HasColumnName("GN_NgayGiaiNgan");
            entity.Property(e => e.GnSoTien).HasColumnName("GN_SoTien");
            entity.Property(e => e.GnTkco)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GN_TKCo");
            entity.Property(e => e.GnTkno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GN_TKNo");
            entity.Property(e => e.HinhThucGnId).HasColumnName("HinhThucGN_ID");
            entity.Property(e => e.SoChungTu).HasMaxLength(20);
            entity.Property(e => e.UsersModify)
                .HasMaxLength(20)
                .HasColumnName("Users_Modify");
            entity.Property(e => e.UsersNew)
                .HasMaxLength(20)
                .HasColumnName("Users_New");
        });

        modelBuilder.Entity<TkiemGiaodich>(entity =>
        {
            entity.HasKey(e => e.GdtkMa);

            entity.ToTable("TKIEM_GIAODICH", tb => tb.HasTrigger("trgAfterUpdate_tkiem_giaodich"));

            entity.Property(e => e.GdtkMa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GDTK_Ma");
            entity.Property(e => e.ChiNhanhMa)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ChiNhanh_Ma");
            entity.Property(e => e.DuChiCu)
                .HasColumnType("money")
                .HasColumnName("DuChi_Cu");
            entity.Property(e => e.GdtkDienGiai)
                .HasMaxLength(500)
                .HasDefaultValueSql("('')")
                .HasColumnName("GDTK_DienGiai");
            entity.Property(e => e.GdtkLoaiGiaoDichMa)
                .HasMaxLength(20)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("GDTK_LoaiGiaoDich_Ma");
            entity.Property(e => e.GdtkLoaiso)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValueSql("('TK')")
                .HasColumnName("GDTK_Loaiso");
            entity.Property(e => e.GdtkMa2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GDTK_Ma2");
            entity.Property(e => e.GdtkNgayApDung)
                .HasColumnType("datetime")
                .HasColumnName("GDTK_NgayApDung");
            entity.Property(e => e.GdtkNgayCapNhat)
                .HasColumnType("datetime")
                .HasColumnName("GDTK_NgayCapNhat");
            entity.Property(e => e.GdtkNgayGiaoDich)
                .HasColumnType("datetime")
                .HasColumnName("GDTK_NgayGiaoDich");
            entity.Property(e => e.GdtkNgayNhap)
                .HasColumnType("datetime")
                .HasColumnName("GDTK_NgayNhap");
            entity.Property(e => e.GdtkNguoiCapNhat)
                .HasMaxLength(20)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("GDTK_NguoiCapNhat");
            entity.Property(e => e.GdtkNguoiNhap)
                .HasMaxLength(20)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("GDTK_NguoiNhap");
            entity.Property(e => e.GdtkSoChungTu)
                .HasMaxLength(50)
                .HasColumnName("GDTK_SoChungTu");
            entity.Property(e => e.GdtkSoTien)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("GDTK_SoTien");
            entity.Property(e => e.GdtkSoTienDuChi)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("GDTK_SoTienDuChi");
            entity.Property(e => e.GdtkSoTietKiem)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasColumnName("GDTK_SoTietKiem");
            entity.Property(e => e.GdtkTrangThai)
                .HasDefaultValueSql("((0))")
                .HasColumnName("GDTK_TrangThai");
            entity.Property(e => e.LaiDaTraCu)
                .HasColumnType("money")
                .HasColumnName("LaiDaTra_Cu");
            entity.Property(e => e.LaiSuatCu)
                .HasColumnType("money")
                .HasColumnName("LaiSuat_Cu");
            entity.Property(e => e.NgayBatDauTinhLaiCu)
                .HasColumnType("datetime")
                .HasColumnName("NgayBatDauTinhLai_Cu");
            entity.Property(e => e.NgayDenHanCu)
                .HasColumnType("datetime")
                .HasColumnName("NgayDenHan_Cu");
            entity.Property(e => e.NgayDuChiCu)
                .HasColumnType("datetime")
                .HasColumnName("NgayDuChi_Cu");
            entity.Property(e => e.NgayKyMoiCu)
                .HasColumnType("datetime")
                .HasColumnName("NgayKyMoi_Cu");
            entity.Property(e => e.SanPhamMaCu)
                .HasMaxLength(20)
                .HasColumnName("SanPham_Ma_Cu");
            entity.Property(e => e.SoDuCu)
                .HasColumnType("money")
                .HasColumnName("SoDu_Cu");
            entity.Property(e => e.StkMa)
                .HasMaxLength(20)
                .HasColumnName("STK_Ma");
            entity.Property(e => e.TienTeMa)
                .HasMaxLength(20)
                .HasDefaultValueSql("('00')")
                .HasColumnName("TienTe_Ma");
            entity.Property(e => e.TienTeTyGia)
                .HasDefaultValueSql("((1))")
                .HasColumnType("money")
                .HasColumnName("TienTe_TyGia");
        });

        modelBuilder.Entity<TkiemGiaodichKkh>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TKIEM_GIAODICH_KKH");

            entity.Property(e => e.ChiNhanhMa)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ChiNhanh_Ma");
            entity.Property(e => e.DuChiCu)
                .HasColumnType("money")
                .HasColumnName("DuChi_Cu");
            entity.Property(e => e.GdtkDienGiai)
                .HasMaxLength(500)
                .HasColumnName("GDTK_DienGiai");
            entity.Property(e => e.GdtkLoaiGiaoDichMa)
                .HasMaxLength(20)
                .HasColumnName("GDTK_LoaiGiaoDich_Ma");
            entity.Property(e => e.GdtkLoaiso)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("GDTK_Loaiso");
            entity.Property(e => e.GdtkMa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GDTK_Ma");
            entity.Property(e => e.GdtkMa2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GDTK_Ma2");
            entity.Property(e => e.GdtkNgayApDung)
                .HasColumnType("datetime")
                .HasColumnName("GDTK_NgayApDung");
            entity.Property(e => e.GdtkNgayCapNhat)
                .HasColumnType("datetime")
                .HasColumnName("GDTK_NgayCapNhat");
            entity.Property(e => e.GdtkNgayGiaoDich)
                .HasColumnType("datetime")
                .HasColumnName("GDTK_NgayGiaoDich");
            entity.Property(e => e.GdtkNgayNhap)
                .HasColumnType("datetime")
                .HasColumnName("GDTK_NgayNhap");
            entity.Property(e => e.GdtkNguoiCapNhat)
                .HasMaxLength(20)
                .HasColumnName("GDTK_NguoiCapNhat");
            entity.Property(e => e.GdtkNguoiNhap)
                .HasMaxLength(20)
                .HasColumnName("GDTK_NguoiNhap");
            entity.Property(e => e.GdtkSoChungTu)
                .HasMaxLength(50)
                .HasColumnName("GDTK_SoChungTu");
            entity.Property(e => e.GdtkSoTien)
                .HasColumnType("money")
                .HasColumnName("GDTK_SoTien");
            entity.Property(e => e.GdtkSoTienDuChi)
                .HasColumnType("money")
                .HasColumnName("GDTK_SoTienDuChi");
            entity.Property(e => e.GdtkSoTietKiem)
                .HasMaxLength(20)
                .HasColumnName("GDTK_SoTietKiem");
            entity.Property(e => e.GdtkTrangThai).HasColumnName("GDTK_TrangThai");
            entity.Property(e => e.LaiDaTraCu)
                .HasColumnType("money")
                .HasColumnName("LaiDaTra_Cu");
            entity.Property(e => e.LaiSuatCu)
                .HasColumnType("money")
                .HasColumnName("LaiSuat_Cu");
            entity.Property(e => e.NgayBatDauTinhLaiCu)
                .HasColumnType("datetime")
                .HasColumnName("NgayBatDauTinhLai_Cu");
            entity.Property(e => e.NgayDenHanCu)
                .HasColumnType("datetime")
                .HasColumnName("NgayDenHan_Cu");
            entity.Property(e => e.NgayDuChiCu)
                .HasColumnType("datetime")
                .HasColumnName("NgayDuChi_Cu");
            entity.Property(e => e.NgayKyMoiCu)
                .HasColumnType("datetime")
                .HasColumnName("NgayKyMoi_Cu");
            entity.Property(e => e.SanPhamMaCu)
                .HasMaxLength(20)
                .HasColumnName("SanPham_Ma_Cu");
            entity.Property(e => e.SoDuCu)
                .HasColumnType("money")
                .HasColumnName("SoDu_Cu");
            entity.Property(e => e.StkMa)
                .HasMaxLength(20)
                .HasColumnName("STK_Ma");
            entity.Property(e => e.TienTeMa)
                .HasMaxLength(20)
                .HasColumnName("TienTe_Ma");
            entity.Property(e => e.TienTeTyGia)
                .HasColumnType("money")
                .HasColumnName("TienTe_TyGia");
        });

        modelBuilder.Entity<TkiemGiaodichLng>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TKIEM_GIAODICH_LNG");

            entity.Property(e => e.ChinhanhId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CHINHANH_ID");
            entity.Property(e => e.GdtkMa2)
                .HasMaxLength(50)
                .HasColumnName("GDTK_MA2");
            entity.Property(e => e.GdtkNgayApDung)
                .HasColumnType("datetime")
                .HasColumnName("GDTK_NgayApDung");
            entity.Property(e => e.LsKymoi)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("LS_KYMOI");
            entity.Property(e => e.NgayLng)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_LNG");
            entity.Property(e => e.NgaydenhanNew)
                .HasColumnType("datetime")
                .HasColumnName("NGAYDENHAN_NEW");
            entity.Property(e => e.SoduCu)
                .HasDefaultValueSql("((0))")
                .HasColumnName("SODU_CU");
            entity.Property(e => e.SoduKymoi)
                .HasDefaultValueSql("((0))")
                .HasColumnName("SODU_KYMOI");
            entity.Property(e => e.Sotietkiem)
                .HasMaxLength(50)
                .HasColumnName("SOTIETKIEM");
            entity.Property(e => e.StkMa)
                .HasMaxLength(20)
                .HasColumnName("STK_MA");
            entity.Property(e => e.TienDuchi)
                .HasDefaultValueSql("((0))")
                .HasColumnName("TIEN_DUCHI");
            entity.Property(e => e.TienLng)
                .HasDefaultValueSql("((0))")
                .HasColumnName("TIEN_LNG");
        });

        modelBuilder.Entity<TkiemHinhthuctralai>(entity =>
        {
            entity.HasKey(e => e.HttlMa).HasName("PK_TKIEM_HinhThucTL");

            entity.ToTable("TKIEM_HINHTHUCTRALAI");

            entity.Property(e => e.HttlMa)
                .HasMaxLength(20)
                .HasColumnName("HTTL_Ma");
            entity.Property(e => e.HttlMoTa)
                .HasMaxLength(255)
                .HasColumnName("HTTL_MoTa");
            entity.Property(e => e.HttlTen)
                .HasMaxLength(255)
                .HasColumnName("HTTL_Ten");
        });

        modelBuilder.Entity<TkiemLaisuat>(entity =>
        {
            entity.HasKey(e => new { e.LsMa, e.SanPhamMa });

            entity.ToTable("TKIEM_LAISUAT");

            entity.Property(e => e.LsMa)
                .HasMaxLength(20)
                .HasColumnName("LS_Ma");
            entity.Property(e => e.SanPhamMa)
                .HasMaxLength(20)
                .HasColumnName("SanPham_Ma");
            entity.Property(e => e.LsDenNgay)
                .HasColumnType("datetime")
                .HasColumnName("LS_DenNgay");
            entity.Property(e => e.LsGhiChu)
                .HasMaxLength(255)
                .HasColumnName("LS_GhiChu");
            entity.Property(e => e.LsLaiSuat)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("LS_LaiSuat");
            entity.Property(e => e.LsNam)
                .HasColumnType("money")
                .HasColumnName("LS_Nam");
            entity.Property(e => e.LsNamMax)
                .HasColumnType("money")
                .HasColumnName("LS_Nam_Max");
            entity.Property(e => e.LsTuNgay)
                .HasColumnType("datetime")
                .HasColumnName("LS_TuNgay");

            entity.HasOne(d => d.SanPhamMaNavigation).WithMany(p => p.TkiemLaisuats)
                .HasForeignKey(d => d.SanPhamMa)
                .HasConstraintName("FK_TKIEM_LAISUAT_TKIEM_SANPHAM");
        });

        modelBuilder.Entity<TkiemLaisuatstk>(entity =>
        {
            entity.HasKey(e => e.LsMa).HasName("PK_TKIEM_LaiSuatSoTietKiem");

            entity.ToTable("TKIEM_LAISUATSTK");

            entity.Property(e => e.LsMa).HasColumnName("LS_Ma");
            entity.Property(e => e.LsGhiChu)
                .HasMaxLength(255)
                .HasColumnName("LS_GhiChu");
            entity.Property(e => e.LsLaiSuat)
                .HasColumnType("money")
                .HasColumnName("LS_LaiSuat");
            entity.Property(e => e.LsTuNgay)
                .HasColumnType("datetime")
                .HasColumnName("LS_TuNgay");
            entity.Property(e => e.StkMa)
                .HasMaxLength(20)
                .HasColumnName("STK_Ma");

            entity.HasOne(d => d.StkMaNavigation).WithMany(p => p.TkiemLaisuatstks)
                .HasForeignKey(d => d.StkMa)
                .HasConstraintName("FK_TKIEM_LAISUATSTK_TKIEM_SOTIETKIEM");
        });

        modelBuilder.Entity<TkiemLoaisp>(entity =>
        {
            entity.HasKey(e => e.LoaiSpMa);

            entity.ToTable("TKIEM_LOAISP");

            entity.Property(e => e.LoaiSpMa)
                .HasMaxLength(20)
                .HasColumnName("LoaiSP_Ma");
            entity.Property(e => e.LoaiSpGhiChu)
                .HasMaxLength(255)
                .HasColumnName("LoaiSP_GhiChu");
            entity.Property(e => e.LoaiSpTen)
                .HasMaxLength(255)
                .HasColumnName("LoaiSP_Ten");
        });

        modelBuilder.Entity<TkiemLuukyhanTattoan>(entity =>
        {
            entity.HasKey(e => new { e.KyHanTatToanStt, e.GdtkMa }).HasName("PK_TKIEM_KYHAN_TATTOAN");

            entity.ToTable("TKIEM_LUUKYHAN_TATTOAN");

            entity.Property(e => e.KyHanTatToanStt).HasColumnName("KyHan_TatToan_STT");
            entity.Property(e => e.GdtkMa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GDTK_Ma");
            entity.Property(e => e.ChiTietCachTinhLai).HasMaxLength(200);
            entity.Property(e => e.SanPhamMa)
                .HasMaxLength(20)
                .HasColumnName("SanPham_Ma");
            entity.Property(e => e.SanPhamTen)
                .HasMaxLength(200)
                .HasColumnName("SanPham_Ten");
            entity.Property(e => e.SanPhamThoiGian)
                .HasMaxLength(20)
                .HasColumnName("SanPham_ThoiGian");
            entity.Property(e => e.SoTienLai).HasColumnType("money");
            entity.Property(e => e.ToiNgay).HasColumnType("datetime");
            entity.Property(e => e.TuNgay).HasColumnType("datetime");

            entity.HasOne(d => d.GdtkMaNavigation).WithMany(p => p.TkiemLuukyhanTattoans)
                .HasForeignKey(d => d.GdtkMa)
                .HasConstraintName("FK_TKIEM_LUUKYHAN_TATTOAN_TKIEM_GIAODICH");
        });

        modelBuilder.Entity<TkiemLuukyhanmoi>(entity =>
        {
            entity.HasKey(e => e.GdtkMa);

            entity.ToTable("TKIEM_LUUKYHANMOI");

            entity.Property(e => e.GdtkMa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GDTK_Ma");
            entity.Property(e => e.LaiSuatMoi).HasColumnType("money");
            entity.Property(e => e.NgayBatDauKyMoi).HasColumnType("datetime");
            entity.Property(e => e.NgayBatDauTinhLai).HasColumnType("datetime");
            entity.Property(e => e.SanPhamMa)
                .HasMaxLength(20)
                .HasColumnName("SanPham_Ma");

            entity.HasOne(d => d.GdtkMaNavigation).WithOne(p => p.TkiemLuukyhanmoi)
                .HasForeignKey<TkiemLuukyhanmoi>(d => d.GdtkMa)
                .HasConstraintName("FK_TKIEM_LUUKYHANMOI_TKIEM_GIAODICH");
        });

        modelBuilder.Entity<TkiemPhichuyentien>(entity =>
        {
            entity.HasKey(e => e.IdPhiChuyenTien);

            entity.ToTable("TKIEM_PHICHUYENTIEN");

            entity.Property(e => e.IdPhiChuyenTien).HasColumnName("ID_PhiChuyenTien");
            entity.Property(e => e.CoTaiKhoan).HasColumnType("money");
            entity.Property(e => e.CungDiaBan).HasColumnType("money");
            entity.Property(e => e.KhacDiaBan).HasColumnType("money");
            entity.Property(e => e.KhongCoTaiKhoan).HasColumnType("money");
            entity.Property(e => e.PhiToiDa).HasColumnType("money");
            entity.Property(e => e.PhiToiThieu).HasColumnType("money");
            entity.Property(e => e.SauGio).HasColumnType("money");
            entity.Property(e => e.TruocGio).HasColumnType("money");
            entity.Property(e => e.TuNgay).HasColumnType("datetime");
            entity.Property(e => e.Vat)
                .HasColumnType("money")
                .HasColumnName("VAT");
        });

        modelBuilder.Entity<TkiemPhichuyentienKhoangtien>(entity =>
        {
            entity.HasKey(e => new { e.IdKhoangTien, e.IdPhiChuyenTien });

            entity.ToTable("TKIEM_PHICHUYENTIEN_KHOANGTIEN");

            entity.Property(e => e.IdKhoangTien).HasColumnName("ID_KhoangTien");
            entity.Property(e => e.IdPhiChuyenTien).HasColumnName("ID_PhiChuyenTien");
            entity.Property(e => e.PhiChuyen).HasColumnType("money");
            entity.Property(e => e.Toi).HasColumnType("money");
            entity.Property(e => e.Tu).HasColumnType("money");

            entity.HasOne(d => d.IdPhiChuyenTienNavigation).WithMany(p => p.TkiemPhichuyentienKhoangtiens)
                .HasForeignKey(d => d.IdPhiChuyenTien)
                .HasConstraintName("FK_TKIEM_PHICHUYENTIEN_KHOANGTIEN_TKIEM_PHICHUYENTIEN");
        });

        modelBuilder.Entity<TkiemSanpham>(entity =>
        {
            entity.HasKey(e => e.SanPhamMa).HasName("PK_TKIEM_SanPham");

            entity.ToTable("TKIEM_SANPHAM");

            entity.Property(e => e.SanPhamMa)
                .HasMaxLength(20)
                .HasColumnName("SanPham_Ma");
            entity.Property(e => e.DvkyHanMa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DVKyHan_Ma");
            entity.Property(e => e.IsActive).HasColumnName("Is_Active");
            entity.Property(e => e.LoaiSpMa)
                .HasMaxLength(20)
                .HasColumnName("LoaiSP_Ma");
            entity.Property(e => e.SanPhamGhiChu)
                .HasMaxLength(255)
                .HasColumnName("SanPham_GhiChu");
            entity.Property(e => e.SanPhamKyHan).HasColumnName("SanPham_KyHan");
            entity.Property(e => e.SanPhamNgayCn)
                .HasColumnType("datetime")
                .HasColumnName("SanPham_NgayCN");
            entity.Property(e => e.SanPhamNgayNhap)
                .HasColumnType("datetime")
                .HasColumnName("SanPham_NgayNhap");
            entity.Property(e => e.SanPhamNguoiCn)
                .HasMaxLength(20)
                .HasColumnName("SanPham_NguoiCN");
            entity.Property(e => e.SanPhamNguoiNhap)
                .HasMaxLength(20)
                .HasColumnName("SanPham_NguoiNhap");
            entity.Property(e => e.SanPhamTen)
                .HasMaxLength(255)
                .HasColumnName("SanPham_Ten");
            entity.Property(e => e.SanPhamTenTat)
                .HasMaxLength(20)
                .HasColumnName("SanPham_TenTat");
            entity.Property(e => e.TienTeMa)
                .HasMaxLength(20)
                .HasColumnName("TienTe_Ma");
            entity.Property(e => e.Tk1)
                .HasMaxLength(20)
                .HasColumnName("TK1");
            entity.Property(e => e.Tk2)
                .HasMaxLength(20)
                .HasColumnName("TK2");
            entity.Property(e => e.Tk3)
                .HasMaxLength(20)
                .HasColumnName("TK3");
            entity.Property(e => e.Tk4)
                .HasMaxLength(20)
                .HasColumnName("TK4");
            entity.Property(e => e.Tk5)
                .HasMaxLength(20)
                .HasColumnName("TK5");
            entity.Property(e => e.Tk6)
                .HasMaxLength(20)
                .HasColumnName("TK6");

            entity.HasOne(d => d.DvkyHanMaNavigation).WithMany(p => p.TkiemSanphams)
                .HasForeignKey(d => d.DvkyHanMa)
                .HasConstraintName("FK_TKIEM_SANPHAM_DM_DV_Ky_Han");

            entity.HasOne(d => d.LoaiSpMaNavigation).WithMany(p => p.TkiemSanphams)
                .HasForeignKey(d => d.LoaiSpMa)
                .HasConstraintName("FK_TKIEM_SANPHAM_TKIEM_LOAISP");
        });

        modelBuilder.Entity<TkiemSoTietKiemRep>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Tkiem_SoTietKiemRep");

            entity.Property(e => e.ClientRep)
                .HasMaxLength(100)
                .HasColumnName("Client_Rep");
            entity.Property(e => e.Event).HasMaxLength(50);
            entity.Property(e => e.LyDo).HasColumnName("Ly_do");
            entity.Property(e => e.NgayRep)
                .HasColumnType("datetime")
                .HasColumnName("Ngay_Rep");
            entity.Property(e => e.SoTkNew)
                .HasMaxLength(50)
                .HasColumnName("SoTK_New");
            entity.Property(e => e.SoTkOld)
                .HasMaxLength(50)
                .HasColumnName("SoTK_Old");
            entity.Property(e => e.Stack)
                .ValueGeneratedOnAdd()
                .HasColumnName("STACK");
            entity.Property(e => e.UserRep)
                .HasMaxLength(50)
                .HasColumnName("USER_Rep");
        });

        modelBuilder.Entity<TkiemSotietkiem>(entity =>
        {
            entity.HasKey(e => e.StkMa);

            entity.ToTable("TKIEM_SOTIETKIEM", tb => tb.HasTrigger("trgAfterUpdate_CcAnchiGTCG"));

            entity.Property(e => e.StkMa)
                .HasMaxLength(20)
                .HasColumnName("STK_Ma");
            entity.Property(e => e.ChiNhanhMa)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("ChiNhanh_Ma");
            entity.Property(e => e.HttlMa)
                .HasMaxLength(20)
                .HasColumnName("HTTL_Ma");
            entity.Property(e => e.KhachHangMa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("KhachHang_Ma");
            entity.Property(e => e.MaThongKe0)
                .HasMaxLength(40)
                .HasColumnName("ma_thong_ke0");
            entity.Property(e => e.MaThongKe1)
                .HasMaxLength(40)
                .HasColumnName("ma_thong_ke1");
            entity.Property(e => e.SanPhamMa)
                .HasMaxLength(20)
                .HasColumnName("SanPham_Ma");
            entity.Property(e => e.StkBaohiem)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("STK_BAOHIEM");
            entity.Property(e => e.StkCoTheThayDoiLaiSuat).HasColumnName("STK_CoTheThayDoiLaiSuat");
            entity.Property(e => e.StkDaLaiNhapGoc)
                .HasDefaultValueSql("((0))")
                .HasColumnName("STK_DaLaiNhapGoc");
            entity.Property(e => e.StkDuChi)
                .HasColumnType("money")
                .HasColumnName("STK_DuChi");
            entity.Property(e => e.StkDuChiDenNgay)
                .HasColumnType("datetime")
                .HasColumnName("STK_DuChiDenNgay");
            entity.Property(e => e.StkGhiChu)
                .HasMaxLength(255)
                .HasColumnName("STK_GhiChu");
            entity.Property(e => e.StkGuiGop)
                .HasDefaultValueSql("((0))")
                .HasColumnName("STK_GuiGop");
            entity.Property(e => e.StkLaiDaTra)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("STK_LaiDaTra");
            entity.Property(e => e.StkNgayBatDau)
                .HasColumnType("datetime")
                .HasColumnName("STK_NgayBatDau");
            entity.Property(e => e.StkNgayBatDauTinhLai)
                .HasColumnType("datetime")
                .HasColumnName("STK_NgayBatDauTinhLai");
            entity.Property(e => e.StkNgayCapNhat)
                .HasColumnType("datetime")
                .HasColumnName("STK_NgayCapNhat");
            entity.Property(e => e.StkNgayDenHan)
                .HasColumnType("datetime")
                .HasColumnName("STK_NgayDenHan");
            entity.Property(e => e.StkNgayKyMoi)
                .HasColumnType("datetime")
                .HasColumnName("STK_NgayKyMoi");
            entity.Property(e => e.StkNgayNhap)
                .HasColumnType("datetime")
                .HasColumnName("STK_NgayNhap");
            entity.Property(e => e.StkNgayPhongToa)
                .HasColumnType("datetime")
                .HasColumnName("STK_NgayPhongToa");
            entity.Property(e => e.StkNguoiCapNhat)
                .HasMaxLength(20)
                .HasColumnName("STK_NguoiCapNhat");
            entity.Property(e => e.StkNguoiNhap)
                .HasMaxLength(20)
                .HasColumnName("STK_NguoiNhap");
            entity.Property(e => e.StkPhongToa).HasColumnName("STK_PhongToa");
            entity.Property(e => e.StkSoDu)
                .HasColumnType("money")
                .HasColumnName("STK_SoDu");
            entity.Property(e => e.StkSoTietKiem)
                .HasMaxLength(20)
                .HasColumnName("STK_SoTietKiem");
            entity.Property(e => e.StkTen)
                .HasMaxLength(255)
                .HasColumnName("STK_Ten");
            entity.Property(e => e.StkTkct)
                .HasMaxLength(20)
                .HasColumnName("STK_TKCT");
            entity.Property(e => e.StkTrangThai).HasColumnName("STK_TrangThai");
            entity.Property(e => e.StkTt14).HasColumnName("STK_TT14");
            entity.Property(e => e.TienTeMa)
                .HasMaxLength(20)
                .HasColumnName("TienTe_Ma");

            entity.HasOne(d => d.ChiNhanhMaNavigation).WithMany(p => p.TkiemSotietkiems)
                .HasForeignKey(d => d.ChiNhanhMa)
                .HasConstraintName("FK_TKIEM_SOTIETKIEM_DM_CHINHANH");

            entity.HasOne(d => d.HttlMaNavigation).WithMany(p => p.TkiemSotietkiems)
                .HasForeignKey(d => d.HttlMa)
                .HasConstraintName("FK_TKIEM_SOTIETKIEM_TKIEM_HINHTHUCTRALAI");

            entity.HasOne(d => d.SanPhamMaNavigation).WithMany(p => p.TkiemSotietkiems)
                .HasForeignKey(d => d.SanPhamMa)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_TKIEM_SOTIETKIEM_TKIEM_SANPHAM");
        });

        modelBuilder.Entity<TkiemStkEom>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TKIEM_STK_EOM");

            entity.Property(e => e.ChiNhanhId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ChiNhanh_ID");
            entity.Property(e => e.DaHoanDuChi).HasDefaultValueSql("((0))");
            entity.Property(e => e.DateNew)
                .HasColumnType("datetime")
                .HasColumnName("Date_New");
            entity.Property(e => e.DuChiCu)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.KhMa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KH_Ma");
            entity.Property(e => e.NgaySoLieu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Ngay_SoLieu");
            entity.Property(e => e.SoDu).HasColumnType("money");
            entity.Property(e => e.StkMa)
                .HasMaxLength(20)
                .HasColumnName("STK_Ma");
            entity.Property(e => e.StkSoTietKiem)
                .HasMaxLength(20)
                .HasColumnName("STK_SoTietKiem");
            entity.Property(e => e.StkTkct)
                .HasMaxLength(20)
                .HasColumnName("STK_TKCT");
            entity.Property(e => e.TienDuChi).HasColumnType("money");
        });

        modelBuilder.Entity<TkiemTaikhoanchuyentien>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_TKIEM_THAMSOCHUYENTIEN");

            entity.ToTable("TKIEM_TAIKHOANCHUYENTIEN");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.TenTk1)
                .HasMaxLength(100)
                .HasColumnName("TenTK1");
            entity.Property(e => e.TenTk2)
                .HasMaxLength(100)
                .HasColumnName("TenTK2");
            entity.Property(e => e.TenTk3)
                .HasMaxLength(100)
                .HasColumnName("TenTK3");
            entity.Property(e => e.TenTk4)
                .HasMaxLength(100)
                .HasColumnName("TenTK4");
            entity.Property(e => e.TenTk5)
                .HasMaxLength(100)
                .HasColumnName("TenTK5");
            entity.Property(e => e.Tk1)
                .HasMaxLength(20)
                .HasColumnName("TK1");
            entity.Property(e => e.Tk2)
                .HasMaxLength(20)
                .HasColumnName("TK2");
            entity.Property(e => e.Tk3)
                .HasMaxLength(20)
                .HasColumnName("TK3");
            entity.Property(e => e.Tk4)
                .HasMaxLength(20)
                .HasColumnName("TK4");
            entity.Property(e => e.Tk5)
                .HasMaxLength(20)
                .HasColumnName("TK5");
        });

        modelBuilder.Entity<Tmp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TMP");

            entity.Property(e => e.Hethong).HasColumnName("HETHONG");
            entity.Property(e => e.Tk)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("tk");
        });

        modelBuilder.Entity<TmpAnChi>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TmpAnChi");

            entity.Property(e => e.DanhSach)
                .HasMaxLength(20)
                .HasColumnName("Danh_Sach");
            entity.Property(e => e.Ma).HasMaxLength(20);
        });

        modelBuilder.Entity<TmpChitieuGiatriSldb>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmpChitieuGiatriSLDB");

            entity.Property(e => e.Chenhlech)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("chenhlech");
            entity.Property(e => e.Chitieu)
                .HasMaxLength(100)
                .HasColumnName("chitieu");
            entity.Property(e => e.Congtru)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("congtru");
            entity.Property(e => e.Giatri1)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("giatri1");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Indam).HasColumnName("indam");
            entity.Property(e => e.Nhatsolieu)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("nhatsolieu");
            entity.Property(e => e.Stt)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("stt");
        });

        modelBuilder.Entity<TmpChitieuGiatriTlnv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmpChitieuGiatriTLNV");

            entity.Property(e => e.Chenhlech)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("chenhlech");
            entity.Property(e => e.Chitieu)
                .HasMaxLength(100)
                .HasColumnName("chitieu");
            entity.Property(e => e.Congtru)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("congtru");
            entity.Property(e => e.Giatri1)
                .HasDefaultValueSql("((0))")
                .HasColumnName("giatri1");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Indam).HasColumnName("indam");
            entity.Property(e => e.Nhatsolieu)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("nhatsolieu");
            entity.Property(e => e.Stt)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("stt");
            entity.Property(e => e.Tyle)
                .HasDefaultValueSql("((0))")
                .HasColumnName("tyle");
        });

        modelBuilder.Entity<TmpChitieuhoatdong>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmpChitieuhoatdong");

            entity.Property(e => e.Chenhlech)
                .IsUnicode(false)
                .HasColumnName("chenhlech");
            entity.Property(e => e.Chitieu).HasColumnName("chitieu");
            entity.Property(e => e.Congtru)
                .IsUnicode(false)
                .HasColumnName("congtru");
            entity.Property(e => e.Giatri1)
                .HasDefaultValueSql("((0))")
                .HasColumnName("giatri1");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Indam).HasColumnName("indam");
            entity.Property(e => e.Nhatsolieu)
                .IsUnicode(false)
                .HasColumnName("nhatsolieu");
            entity.Property(e => e.Stt)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("stt");
        });

        modelBuilder.Entity<TmpHd>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmp_hd");

            entity.Property(e => e.HopdongId)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("hopdong_id");
            entity.Property(e => e.SoDuThu).HasColumnName("so_du_thu");
        });

        modelBuilder.Entity<TmpHoSoDuThuKetQua>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmpHoSoDuThu_KetQua");

            entity.Property(e => e.MaNganhId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MaNganh_id");
        });

        modelBuilder.Entity<TmpHoSoDuThuTheoHdtd>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmpHoSoDuThu_TheoHDTD");

            entity.Property(e => e.HosoId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("hoso_id");
        });

        modelBuilder.Entity<TmpHosoTd>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmpHosoTD");

            entity.Property(e => e.HinhThucTstcId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("HinhThucTSTC_ID");
            entity.Property(e => e.HinhThucTstcTen)
                .HasMaxLength(255)
                .HasColumnName("HinhThucTSTC_Ten");
            entity.Property(e => e.HosoTdId)
                .HasMaxLength(20)
                .HasColumnName("HosoTD_ID");
            entity.Property(e => e.KhachHangId)
                .HasMaxLength(20)
                .HasColumnName("KhachHangID");
            entity.Property(e => e.KhuvucMa)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("khuvuc_ma");
            entity.Property(e => e.KhuvucTen)
                .HasMaxLength(255)
                .HasColumnName("khuvuc_ten");
            entity.Property(e => e.LaiDaThu).HasColumnName("lai_da_thu");
            entity.Property(e => e.LaiSuat).HasColumnName("Lai_Suat");
            entity.Property(e => e.LoaiHinhKinhTeId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("loai_hinh_kinh_te_id");
            entity.Property(e => e.LoaiVayId).HasColumnName("Loai_vay_id");
            entity.Property(e => e.MaThongKe0)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ma_thong_ke0");
            entity.Property(e => e.MaThongKe1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ma_thong_ke1");
            entity.Property(e => e.MucDichVay)
                .HasMaxLength(1000)
                .HasColumnName("Muc_dich_vay");
            entity.Property(e => e.MucDichVayId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("muc_dich_vay_id");
            entity.Property(e => e.NganhNgheKdMa)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("NganhNgheKD_Ma");
            entity.Property(e => e.NganhNgheKdTen)
                .HasMaxLength(1000)
                .HasColumnName("NganhNgheKD_Ten");
            entity.Property(e => e.NgayDaoHan)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Ngay_Dao_Han");
            entity.Property(e => e.NgayGiaHan)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Ngay_gia_han");
            entity.Property(e => e.NgayVay)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ngay_vay");
            entity.Property(e => e.NhomNo).HasColumnName("Nhom_no");
            entity.Property(e => e.SanPhamTdId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SanPhamTD_ID");
            entity.Property(e => e.SoDu)
                .HasDefaultValueSql("((0))")
                .HasColumnName("So_Du");
            entity.Property(e => e.SoDuThu).HasColumnName("So_Du_Thu");
            entity.Property(e => e.SoHopDong)
                .HasMaxLength(20)
                .HasColumnName("So_Hop_Dong");
            entity.Property(e => e.TenNguoiVay)
                .HasMaxLength(100)
                .HasColumnName("Ten_Nguoi_Vay");
            entity.Property(e => e.TenNhomTk0)
                .HasMaxLength(255)
                .HasColumnName("TenNhomTK0");
            entity.Property(e => e.TenNhomTk1)
                .HasMaxLength(255)
                .HasColumnName("TenNhomTK1");
            entity.Property(e => e.TenTaiKhoan)
                .HasMaxLength(255)
                .HasColumnName("Ten_tai_khoan");
            entity.Property(e => e.TkTinDung)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TK_Tin_Dung");
            entity.Property(e => e.TstcTriGia).HasColumnName("TSTC_Tri_gia");
        });

        modelBuilder.Entity<TmpHosoTd127>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmpHosoTD_127");

            entity.Property(e => e.HinhThucTstcId)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("HinhThucTSTC_ID");
            entity.Property(e => e.HosotdId)
                .HasMaxLength(50)
                .HasColumnName("hosotd_id");
            entity.Property(e => e.LaiDenNgay)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("lai_den_ngay");
            entity.Property(e => e.LaiSuat)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("lai_suat");
            entity.Property(e => e.NgayDaoHan)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ngay_dao_han");
            entity.Property(e => e.NgayVay)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ngay_vay");
            entity.Property(e => e.NhomNo).HasColumnName("Nhom_No");
            entity.Property(e => e.SoDu).HasColumnName("so_du");
            entity.Property(e => e.SoHopDong)
                .HasMaxLength(50)
                .HasColumnName("so_hop_dong");
        });

        modelBuilder.Entity<TmpHosoTdGiaoDich>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmpHosoTD_GiaoDich");

            entity.Property(e => e.ChinhanhId)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("chinhanh_id");
            entity.Property(e => e.HinhthucGn)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("hinhthucGN");
            entity.Property(e => e.HinhthucTsId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("hinhthucTS_ID");
            entity.Property(e => e.HosoId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("hoso_id");
            entity.Property(e => e.KhachhangId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("khachhang_id");
            entity.Property(e => e.NgayPs)
                .HasColumnType("smalldatetime")
                .HasColumnName("ngay_ps");
            entity.Property(e => e.SoTienPs).HasColumnName("so_tien_ps");
        });

        modelBuilder.Entity<TmpKhachHangTv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmpKhachHangTV");

            entity.Property(e => e.ChinhanhId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CHINHANH_ID");
            entity.Property(e => e.Cmnd)
                .HasMaxLength(20)
                .HasColumnName("CMND");
            entity.Property(e => e.CmndNgay)
                .HasColumnType("datetime")
                .HasColumnName("CMND_NGAY");
            entity.Property(e => e.CpSodu).HasColumnName("CP_SODU");
            entity.Property(e => e.Cptn).HasColumnName("CPTN");
            entity.Property(e => e.Cptx).HasColumnName("CPTX");
            entity.Property(e => e.Cpxl).HasColumnName("CPXL");
            entity.Property(e => e.DiaChi)
                .HasMaxLength(400)
                .HasColumnName("DIA_CHI");
            entity.Property(e => e.DiabanIs).HasColumnName("DIABAN_IS");
            entity.Property(e => e.KhId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KH_ID");
            entity.Property(e => e.KhMa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KH_MA");
            entity.Property(e => e.KvMa)
                .HasMaxLength(20)
                .HasColumnName("KV_MA");
            entity.Property(e => e.LoaihinhId)
                .HasMaxLength(20)
                .HasColumnName("LOAIHINH_ID");
            entity.Property(e => e.TvIs).HasColumnName("TV_IS");
            entity.Property(e => e.TvMa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TV_MA");
            entity.Property(e => e.TvNgay)
                .HasColumnType("datetime")
                .HasColumnName("TV_NGAY");
            entity.Property(e => e.TvSocp)
                .HasMaxLength(20)
                .HasColumnName("TV_SOCP");
            entity.Property(e => e.TvTen)
                .HasMaxLength(255)
                .HasColumnName("TV_TEN");
        });

        modelBuilder.Entity<TmpTaikhoanSodu>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmp_TaikhoanSodu");

            entity.Property(e => e.Duco)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("duco");
            entity.Property(e => e.Duno)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("duno");
            entity.Property(e => e.Matk)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("matk");
        });

        modelBuilder.Entity<TmpTietKiem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmpTietKiem");

            entity.Property(e => e.DvKyhan).HasColumnName("DV_KYHAN");
            entity.Property(e => e.KhMa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("KH_MA");
            entity.Property(e => e.LoaiHinhDnMa)
                .HasMaxLength(20)
                .HasColumnName("LoaiHinhDN_Ma");
            entity.Property(e => e.LsLaisuat)
                .HasColumnType("money")
                .HasColumnName("LS_LAISUAT");
            entity.Property(e => e.SanphamMa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SANPHAM_MA");
            entity.Property(e => e.SokyNg)
                .HasDefaultValueSql("((0))")
                .HasColumnName("SOKY_NG");
            entity.Property(e => e.SpKyhan).HasColumnName("SP_KYHAN");
            entity.Property(e => e.StkMa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("STK_MA");
            entity.Property(e => e.StkNgayBatDauTinhLai)
                .HasColumnType("datetime")
                .HasColumnName("STK_NgayBatDauTinhLai");
            entity.Property(e => e.StkNgaybatdau)
                .HasColumnType("datetime")
                .HasColumnName("STK_NGAYBATDAU");
            entity.Property(e => e.StkNgaydenhan)
                .HasColumnType("datetime")
                .HasColumnName("STK_NGAYDENHAN");
            entity.Property(e => e.StkSodu).HasColumnName("STK_SODU");
            entity.Property(e => e.StkSotk)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("STK_SOTK");
            entity.Property(e => e.StkTkct)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("STK_TKCT");
            entity.Property(e => e.Tt14).HasColumnName("TT14");
        });

        modelBuilder.Entity<Tongduno>(entity =>
        {
            entity.HasKey(e => e.KhachHangId).HasName("PK__Tongduno__16A1551A9362E61E");

            entity.ToTable("Tongduno");

            entity.Property(e => e.KhachHangId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KhachHang_ID");
            entity.Property(e => e.CmtSerial)
                .HasMaxLength(20)
                .HasColumnName("CMT_Serial");
            entity.Property(e => e.DiaChi)
                .HasMaxLength(255)
                .HasColumnName("Dia_Chi");
            entity.Property(e => e.Ten).HasMaxLength(255);
            entity.Property(e => e.TotalDebt).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<TscdDanhSach>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TSCD_DanhSach");

            entity.Property(e => e.ChiNhanhId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ChiNhanh_ID");
            entity.Property(e => e.IsLocked).HasColumnName("Is_locked");
            entity.Property(e => e.LoaiTscd).HasColumnName("Loai_TSCD");
            entity.Property(e => e.MaTscd)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Ma_TSCD");
            entity.Property(e => e.NgayCapNhat).HasColumnType("datetime");
            entity.Property(e => e.TaiKhoanCp)
                .HasMaxLength(20)
                .HasColumnName("TaiKhoan_CP");
            entity.Property(e => e.TaiKhoanKh)
                .HasMaxLength(20)
                .HasColumnName("TaiKhoan_Kh");
            entity.Property(e => e.TaiKhoanTscd)
                .HasMaxLength(20)
                .HasColumnName("TaiKhoan_TSCD");
            entity.Property(e => e.TenTscd).HasColumnName("Ten_TSCD");
            entity.Property(e => e.TscdDvt)
                .HasMaxLength(50)
                .HasColumnName("TSCD_Dvt");
            entity.Property(e => e.TscdGhiChu).HasColumnName("TSCD_GhiChu");
            entity.Property(e => e.TscdGiaTriConLai)
                .HasColumnType("money")
                .HasColumnName("TSCD_GiaTriConLai");
            entity.Property(e => e.TscdGiatriConLai0)
                .HasColumnType("money")
                .HasColumnName("TSCD_GiatriConLai0");
            entity.Property(e => e.TscdHinhThuc).HasColumnName("TSCD_HinhThuc");
            entity.Property(e => e.TscdKhauHao)
                .HasColumnType("money")
                .HasColumnName("TSCD_KhauHao");
            entity.Property(e => e.TscdNgayKhauHao)
                .HasColumnType("datetime")
                .HasColumnName("TSCD_NgayKhauHao");
            entity.Property(e => e.TscdNgayKhauHao0)
                .HasColumnType("datetime")
                .HasColumnName("TSCD_NgayKHauHao0");
            entity.Property(e => e.TscdNgayNhap)
                .HasColumnType("datetime")
                .HasColumnName("TSCD_NgayNhap");
            entity.Property(e => e.TscdNgayXuat)
                .HasColumnType("datetime")
                .HasColumnName("TSCD_NgayXuat");
            entity.Property(e => e.TscdNguoiQly)
                .HasMaxLength(50)
                .HasColumnName("TSCD_NguoiQly");
            entity.Property(e => e.TscdNguoiSd)
                .HasMaxLength(50)
                .HasColumnName("TSCD_NguoiSd");
            entity.Property(e => e.TscdNguyenGia)
                .HasColumnType("money")
                .HasColumnName("TSCD_NguyenGia");
            entity.Property(e => e.TscdNhom)
                .HasMaxLength(50)
                .HasColumnName("TSCD_Nhom");
            entity.Property(e => e.TscdSoKy).HasColumnName("TSCD_SoKy");
            entity.Property(e => e.TscdSoLuong).HasColumnName("TSCD_SoLuong");
            entity.Property(e => e.TscdSoTienKhauHao)
                .HasColumnType("money")
                .HasColumnName("TSCD_SoTienKhauHao");
            entity.Property(e => e.TscdSoTienKhauHao0)
                .HasColumnType("money")
                .HasColumnName("TSCD_SoTienKhauHao0");
            entity.Property(e => e.TscdThoiGianSd).HasColumnName("TSCD_ThoiGianSD");
            entity.Property(e => e.TscdTrangThai).HasColumnName("TSCD_TrangThai");
            entity.Property(e => e.TstcDonViTgsd).HasColumnName("TSTC_DonVi_TGSD");
        });

        modelBuilder.Entity<TscdDanhSachDc>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TSCD_DanhSach_DC");

            entity.Property(e => e.ChiNhanhId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ChiNhanh_ID");
            entity.Property(e => e.MaTscd)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Ma_TSCD");
            entity.Property(e => e.TscdGhiChu).HasColumnName("TSCD_GhiChu");
            entity.Property(e => e.TscdKhauHao)
                .HasColumnType("money")
                .HasColumnName("TSCD_KhauHao");
            entity.Property(e => e.TscdNgay)
                .HasColumnType("datetime")
                .HasColumnName("TSCD_Ngay");
            entity.Property(e => e.TscdSoKy).HasColumnName("TSCD_SoKy");
        });

        modelBuilder.Entity<TscdDmNhom>(entity =>
        {
            entity.HasKey(e => e.Ma).HasName("PK__DM_NhomT__8980EAC06917408A");

            entity.ToTable("TSCD_DM_Nhom");

            entity.Property(e => e.Ma).HasMaxLength(50);
            entity.Property(e => e.GhiChu).HasColumnName("Ghi_Chu");
            entity.Property(e => e.Ten).HasMaxLength(50);
        });

        modelBuilder.Entity<TscdGiaoDich>(entity =>
        {
            entity.HasKey(e => e.GdtsId).HasName("PK__TSCD_Giao_Dich__4D502BD4");

            entity.ToTable("TSCD_Giao_Dich");

            entity.Property(e => e.GdtsId)
                .HasMaxLength(50)
                .HasColumnName("GDTS_ID");
            entity.Property(e => e.ChiNhanhId)
                .HasMaxLength(50)
                .HasColumnName("ChiNhanh_ID");
            entity.Property(e => e.HinhThucGd)
                .HasMaxLength(50)
                .HasDefaultValueSql("('01')")
                .HasColumnName("HinhThuc_GD");
            entity.Property(e => e.LoaiGd)
                .HasMaxLength(10)
                .HasColumnName("LoaiGD");
            entity.Property(e => e.NgayGd)
                .HasColumnType("datetime")
                .HasColumnName("NgayGD");
            entity.Property(e => e.NgayKh)
                .HasColumnType("datetime")
                .HasColumnName("Ngay_kh");
            entity.Property(e => e.NgayKhCu)
                .HasColumnType("datetime")
                .HasColumnName("Ngay_KhCu");
            entity.Property(e => e.NgayNhap).HasColumnType("datetime");
            entity.Property(e => e.NguoiNhap).HasMaxLength(30);
            entity.Property(e => e.Serial)
                .HasMaxLength(40)
                .HasColumnName("serial");
            entity.Property(e => e.SoTien).HasColumnType("money");
            entity.Property(e => e.TaiKhoanCo)
                .HasMaxLength(50)
                .HasColumnName("TaiKhoan_Co");
            entity.Property(e => e.TaiKhoanNo)
                .HasMaxLength(50)
                .HasColumnName("TaiKhoan_No");
            entity.Property(e => e.TscdMa)
                .HasMaxLength(20)
                .HasColumnName("TSCD_Ma");
        });

        modelBuilder.Entity<TstcTmp111>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tstc_tmp_111");

            entity.Property(e => e.MaId)
                .HasMaxLength(50)
                .HasColumnName("ma_id");
            entity.Property(e => e.TenTs).HasColumnName("ten_ts");
        });

        modelBuilder.Entity<Tt04Template>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TT04_Template");

            entity.Property(e => e.ChiTieu)
                .HasMaxLength(500)
                .HasColumnName("chi_tieu");
            entity.Property(e => e.Congtru)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("congtru");
            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ID");
            entity.Property(e => e.Nhatsolieu)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("nhatsolieu");
            entity.Property(e => e.TenBaoCao)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Tt11BieuC00314Lai>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TT11_BieuC00314_Lai");

            entity.Property(e => e.HosotdId)
                .HasMaxLength(50)
                .HasColumnName("Hosotd_ID");
            entity.Property(e => e.LaiCu).HasColumnName("Lai_Cu");
            entity.Property(e => e.LaiGiam).HasColumnName("Lai_giam");
            entity.Property(e => e.LaiMoi).HasColumnName("lai_moi");
            entity.Property(e => e.Ngaybaocao)
                .HasMaxLength(10)
                .HasDefaultValueSql("((20200430))");
        });

        modelBuilder.Entity<Tt11DanhSachBaoCao>(entity =>
        {
            entity.ToTable("TT11_DanhSachBaoCao");

            entity.Property(e => e.Id)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID");
            entity.Property(e => e.Int).HasColumnName("int");
            entity.Property(e => e.KyBaocao).HasMaxLength(50);
            entity.Property(e => e.LoaiBaoCao).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Query)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Query2)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Tt11DunoKinhte>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TT11_DUNO_KINHTE");

            entity.Property(e => e.ChiTieuTong)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CHI_TIEU_TONG");
            entity.Property(e => e.DoanhSoPs).HasColumnName("DOANH_SO_PS");
            entity.Property(e => e.LaiDuThu).HasColumnName("LAI_DU_THU");
            entity.Property(e => e.MaNganh)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MA_NGANH");
            entity.Property(e => e.NganHan)
                .HasColumnType("numeric(20, 0)")
                .HasColumnName("NGAN_HAN");
            entity.Property(e => e.Stt).HasColumnName("STT");
            entity.Property(e => e.TenNganh)
                .HasMaxLength(300)
                .HasColumnName("TEN_NGANH");
            entity.Property(e => e.TongCong)
                .HasColumnType("numeric(20, 0)")
                .HasColumnName("TONG_CONG");
            entity.Property(e => e.TrungDaiHan)
                .HasColumnType("numeric(20, 0)")
                .HasColumnName("TRUNG_DAI_HAN");
        });

        modelBuilder.Entity<Tt11MauExcel>(entity =>
        {
            entity.HasKey(e => e.Tenbieu);

            entity.ToTable("TT11_MauExcel");

            entity.Property(e => e.Tenbieu)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.CellBatdau)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("Cell_Batdau");
            entity.Property(e => e.CellDlps)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("Cell_DLPS");
            entity.Property(e => e.CellDonvitinh)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("Cell_Donvitinh");
            entity.Property(e => e.CellIdkdbc)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Cell_IDKDBC");
            entity.Property(e => e.CellMaQuy)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("Cell_MaQuy");
            entity.Property(e => e.CellNameKdbc)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Cell_NameKDBC");
            entity.Property(e => e.CellNgayDlps)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("Cell_NgayDLPS");
            entity.Property(e => e.CellReadOnly)
                .HasMaxLength(300)
                .HasColumnName("Cell_ReadOnly");
            entity.Property(e => e.CellTenFile)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("Cell_TenFile");
            entity.Property(e => e.CogianHangCot)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("Cogian_HangCot");
            entity.Property(e => e.DateFormat)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('dd/MM/yyyy')")
                .HasColumnName("Date_Format");
            entity.Property(e => e.DinhdangMacdinh).HasDefaultValueSql("((1))");
            entity.Property(e => e.DlpsSheet1)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DLPS_sheet1");
            entity.Property(e => e.DlpsSheet2)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DLPS_sheet2");
            entity.Property(e => e.Donvitinh)
                .HasMaxLength(250)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Duongdan)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.FileMau)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.IntFormat)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('### ### ### ###')")
                .HasColumnName("Int_Format");
            entity.Property(e => e.LuuFile).HasDefaultValueSql("((0))");
            entity.Property(e => e.MoFile).HasDefaultValueSql("((1))");
            entity.Property(e => e.NumericFormat)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('### ### ###.###')")
                .HasColumnName("Numeric_Format");
            entity.Property(e => e.TenSheet)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValueSql("('Sheet1')")
                .HasColumnName("Ten_Sheet");
            entity.Property(e => e.TenSheet2)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("Ten_Sheet2");
        });

        modelBuilder.Entity<Tt21ChiTieu>(entity =>
        {
            entity.HasKey(e => e.MaChiTieu);

            entity.ToTable("TT21_Chi_Tieu");

            entity.Property(e => e.MaChiTieu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ma_chi_tieu");
            entity.Property(e => e.ChiTieu)
                .HasMaxLength(500)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("chi_tieu");
            entity.Property(e => e.InDam).HasColumnName("in_dam");
            entity.Property(e => e.IsUsed)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("is_used");
            entity.Property(e => e.KyBaoCao)
                .HasMaxLength(20)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("ky_bao_cao");
            entity.Property(e => e.MaChiTieuGoc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("ma_chi_tieu_goc");
            entity.Property(e => e.MaTieuNhom1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("ma_tieu_nhom1");
            entity.Property(e => e.MaTieuNhom2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("ma_tieu_nhom2");
            entity.Property(e => e.MaTieuNhom3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("ma_tieu_nhom3");
            entity.Property(e => e.MaTieuNhom4)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("ma_tieu_nhom4");
            entity.Property(e => e.N1).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<Tt21KiemKeTien>(entity =>
        {
            entity.HasKey(e => e.MaId);

            entity.ToTable("TT21_Kiem_Ke_Tien");

            entity.Property(e => e.MaId).HasColumnName("ma_id");
            entity.Property(e => e.Chi1).HasColumnName("chi_1");
            entity.Property(e => e.Chi2).HasColumnName("chi_2");
            entity.Property(e => e.Chi3).HasColumnName("chi_3");
            entity.Property(e => e.Chi4).HasColumnName("chi_4");
            entity.Property(e => e.Chi5).HasColumnName("chi_5");
            entity.Property(e => e.Chi6).HasColumnName("chi_6");
            entity.Property(e => e.Chi7).HasColumnName("chi_7");
            entity.Property(e => e.Chi8).HasColumnName("chi_8");
            entity.Property(e => e.Chi9).HasColumnName("chi_9");
            entity.Property(e => e.LoaiTienId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("loai_tien_id");
            entity.Property(e => e.Ngay)
                .HasColumnType("smalldatetime")
                .HasColumnName("ngay");
            entity.Property(e => e.Thu1).HasColumnName("thu_1");
            entity.Property(e => e.Thu2).HasColumnName("thu_2");
            entity.Property(e => e.Thu3).HasColumnName("thu_3");
            entity.Property(e => e.Thu4).HasColumnName("thu_4");
            entity.Property(e => e.Thu5).HasColumnName("thu_5");
            entity.Property(e => e.Thu6).HasColumnName("thu_6");
            entity.Property(e => e.Thu7).HasColumnName("thu_7");
            entity.Property(e => e.Thu8).HasColumnName("thu_8");
            entity.Property(e => e.Thu9).HasColumnName("thu_9");
            entity.Property(e => e.TonCuoiKy).HasColumnName("ton_cuoi_ky");
            entity.Property(e => e.TonDauKy).HasColumnName("ton_dau_ky");
        });

        modelBuilder.Entity<Tt21LoaiTien>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TT21_Loai_Tien");

            entity.Property(e => e.Active).HasDefaultValueSql("((1))");
            entity.Property(e => e.LoaiTien)
                .HasMaxLength(50)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("loai_tien");
            entity.Property(e => e.LoaiTienId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("loai_tien_id");
            entity.Property(e => e.NumberCrc).HasColumnName("number_crc");
            entity.Property(e => e.Stt)
                .ValueGeneratedOnAdd()
                .HasColumnName("STT");
        });

        modelBuilder.Entity<Tt21LuyKeThanhVienSl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TT21_LuyKe_ThanhVien_SL");

            entity.Property(e => e.Flag)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ThoiGian)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Tt21MauExcel>(entity =>
        {
            entity.HasKey(e => e.Tenbieu);

            entity.ToTable("TT21_MauExcel");

            entity.Property(e => e.Tenbieu)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.CellBatdau)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("Cell_Batdau");
            entity.Property(e => e.CellDonvitinh)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("Cell_Donvitinh");
            entity.Property(e => e.CellMaquy)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("Cell_Maquy");
            entity.Property(e => e.CellSubTitle)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("Cell_SubTitle");
            entity.Property(e => e.CellTitle)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("Cell_Title");
            entity.Property(e => e.CogianHangCot)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("Cogian_HangCot");
            entity.Property(e => e.DateFormat)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('dd/MM/yyyy')")
                .HasColumnName("Date_Format");
            entity.Property(e => e.DinhdangMacdinh).HasDefaultValueSql("((1))");
            entity.Property(e => e.Donvitinh)
                .HasMaxLength(250)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Duongdan)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.FileMau)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.IntFormat)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('### ### ### ###')")
                .HasColumnName("Int_Format");
            entity.Property(e => e.LuuFile).HasDefaultValueSql("((0))");
            entity.Property(e => e.MoFile).HasDefaultValueSql("((1))");
            entity.Property(e => e.NumericFormat)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('### ### ###.###')")
                .HasColumnName("Numeric_Format");
            entity.Property(e => e.TenSheet)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValueSql("('Sheet1')")
                .HasColumnName("Ten_Sheet");
            entity.Property(e => e.Title)
                .HasMaxLength(250)
                .HasDefaultValueSql("('')");
        });

        modelBuilder.Entity<Tt21TempCp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TT21_TempCP");

            entity.Property(e => e.CoPhanThuongXuyen).HasColumnName("co_phan_thuong_xuyen");
            entity.Property(e => e.CoPhanXacLap).HasColumnName("co_phan_xac_lap");
            entity.Property(e => e.LoaiHinhDnMa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("LoaiHinhDN_Ma");
        });

        modelBuilder.Entity<Tt21Template>(entity =>
        {
            entity.ToTable("TT21_Template");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ChiTieu)
                .HasMaxLength(200)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("chi_tieu");
            entity.Property(e => e.Dong)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("dong");
            entity.Property(e => e.InDam).HasColumnName("in_dam");
            entity.Property(e => e.MaMucDichVay)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("ma_muc_dich_vay");
            entity.Property(e => e.Mau)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("mau");
            entity.Property(e => e.N1).HasColumnName("n1");
            entity.Property(e => e.N10).HasColumnName("n10");
            entity.Property(e => e.N11).HasColumnName("n11");
            entity.Property(e => e.N12).HasColumnName("n12");
            entity.Property(e => e.N13).HasColumnName("n13");
            entity.Property(e => e.N14).HasColumnName("n14");
            entity.Property(e => e.N15).HasColumnName("n15");
            entity.Property(e => e.N16).HasColumnName("n16");
            entity.Property(e => e.N17).HasColumnName("n17");
            entity.Property(e => e.N18).HasColumnName("n18");
            entity.Property(e => e.N19).HasColumnName("n19");
            entity.Property(e => e.N2).HasColumnName("n2");
            entity.Property(e => e.N20).HasColumnName("n20");
            entity.Property(e => e.N3).HasColumnName("n3");
            entity.Property(e => e.N4).HasColumnName("n4");
            entity.Property(e => e.N5).HasColumnName("n5");
            entity.Property(e => e.N6).HasColumnName("n6");
            entity.Property(e => e.N7).HasColumnName("n7");
            entity.Property(e => e.N8).HasColumnName("n8");
            entity.Property(e => e.N9).HasColumnName("n9");
            entity.Property(e => e.Stt)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("stt");
        });

        modelBuilder.Entity<Tt21TienGium>(entity =>
        {
            entity.HasKey(e => e.MaId);

            entity.ToTable("TT21_Tien_Gia");

            entity.Property(e => e.MaId).HasColumnName("ma_id");
            entity.Property(e => e.Chinhanhid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("chinhanhid");
            entity.Property(e => e.LoaiTienId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("loai_tien_id");
            entity.Property(e => e.Ngay)
                .HasColumnType("smalldatetime")
                .HasColumnName("ngay");
            entity.Property(e => e.NhapTrongKy).HasColumnName("nhap_trong_ky");
            entity.Property(e => e.TonCuoiKy).HasColumnName("ton_cuoi_ky");
            entity.Property(e => e.TonDauKy).HasColumnName("ton_dau_ky");
            entity.Property(e => e.XuatTrongKy).HasColumnName("xuat_trong_ky");
        });

        modelBuilder.Entity<Tt21TienGuiTt>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TT21_TienGuiTT");

            entity.Property(e => e.DonViKyHan).HasColumnName("don_vi_ky_han");
            entity.Property(e => e.KhachhangId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("khachhang_id");
            entity.Property(e => e.LaiSuat).HasColumnName("lai_suat");
            entity.Property(e => e.LoaiHinhKinhTeId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("loai_hinh_kinh_te_id");
            entity.Property(e => e.LoaiKyHan)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("loai_ky_han");
            entity.Property(e => e.LoaiTienId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("loai_tien_id");
            entity.Property(e => e.Ngay)
                .HasColumnType("smalldatetime")
                .HasColumnName("ngay");
            entity.Property(e => e.NgayDaoHan)
                .HasColumnType("smalldatetime")
                .HasColumnName("ngay_dao_han");
            entity.Property(e => e.NgayGui)
                .HasColumnType("smalldatetime")
                .HasColumnName("ngay_gui");
            entity.Property(e => e.SoDu).HasColumnName("so_du");
            entity.Property(e => e.SoTietKiem)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("so_tiet_kiem");
            entity.Property(e => e.SoTietKiemId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("SoTietKiem_ID");
            entity.Property(e => e.TkTietKiem)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("tk_tiet_kiem");
        });

        modelBuilder.Entity<Tt21TietKiem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TT21_Tiet_Kiem");

            entity.Property(e => e.DonViKyHan).HasColumnName("don_vi_ky_han");
            entity.Property(e => e.KhachhangId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("khachhang_id");
            entity.Property(e => e.LaiSuat).HasColumnName("lai_suat");
            entity.Property(e => e.LoaiHinhKinhTeId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("loai_hinh_kinh_te_id");
            entity.Property(e => e.LoaiKyHan)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("loai_ky_han");
            entity.Property(e => e.LoaiTienId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("loai_tien_id");
            entity.Property(e => e.Ngay)
                .HasColumnType("smalldatetime")
                .HasColumnName("ngay");
            entity.Property(e => e.NgayDaoHan)
                .HasColumnType("smalldatetime")
                .HasColumnName("ngay_dao_han");
            entity.Property(e => e.NgayGui)
                .HasColumnType("smalldatetime")
                .HasColumnName("ngay_gui");
            entity.Property(e => e.SoDu).HasColumnName("so_du");
            entity.Property(e => e.SoTietKiem)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("so_tiet_kiem");
            entity.Property(e => e.SoTietKiemId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("SoTietKiem_ID");
            entity.Property(e => e.TkTietKiem)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("tk_tiet_kiem");
        });

        modelBuilder.Entity<Tt21TinDung>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TT21_Tin_Dung");

            entity.Property(e => e.ChinhanhId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("chinhanh_id");
            entity.Property(e => e.HoNgheo).HasColumnName("ho_ngheo");
            entity.Property(e => e.HosoTdId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("HosoTD_ID");
            entity.Property(e => e.KhachhangId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("khachhang_id");
            entity.Property(e => e.KhuvucMa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("khuvuc_ma");
            entity.Property(e => e.LaiSuat).HasColumnName("lai_suat");
            entity.Property(e => e.LaiSuatUuDai).HasColumnName("lai_suat_uu_dai");
            entity.Property(e => e.LoaiHinhKinhTeId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("loai_hinh_kinh_te_id");
            entity.Property(e => e.LoaiTienId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("loai_tien_id");
            entity.Property(e => e.LoaiVayId).HasColumnName("loai_vay_id");
            entity.Property(e => e.MucDichVayId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("muc_dich_vay_id");
            entity.Property(e => e.NganhKinhTeId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("nganh_kinh_te_id");
            entity.Property(e => e.Ngay)
                .HasColumnType("smalldatetime")
                .HasColumnName("ngay");
            entity.Property(e => e.NgayDaoHan)
                .HasColumnType("smalldatetime")
                .HasColumnName("ngay_dao_han");
            entity.Property(e => e.NgayVay)
                .HasColumnType("smalldatetime")
                .HasColumnName("ngay_vay");
            entity.Property(e => e.NhomNo).HasColumnName("nhom_no");
            entity.Property(e => e.PhuongThucTheChapId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("phuong_thuc_the_chap_id");
            entity.Property(e => e.SoDu).HasColumnName("so_du");
            entity.Property(e => e.ThanhVien).HasColumnName("thanh_vien");
            entity.Property(e => e.TkTinDung)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("tk_tin_dung");
        });

        modelBuilder.Entity<Tt31ChiTieu>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.MaChiTieu }).HasName("PK_TT31_Chi_Tieu_1");

            entity.ToTable("TT31_Chi_Tieu");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.MaChiTieu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ma_chi_tieu");
            entity.Property(e => e.ChiTieu)
                .HasMaxLength(500)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("chi_tieu");
            entity.Property(e => e.InDam).HasColumnName("in_dam");
            entity.Property(e => e.IsUsed)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("is_used");
            entity.Property(e => e.KyBaoCao)
                .HasMaxLength(20)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("ky_bao_cao");
            entity.Property(e => e.MaChiTieuGoc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("ma_chi_tieu_goc");
            entity.Property(e => e.MaTieuNhom1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("ma_tieu_nhom1");
            entity.Property(e => e.MaTieuNhom2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("ma_tieu_nhom2");
            entity.Property(e => e.MaTieuNhom3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("ma_tieu_nhom3");
            entity.Property(e => e.MaTieuNhom4)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("ma_tieu_nhom4");
            entity.Property(e => e.N1).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<Tt31DanhSachBaoCao>(entity =>
        {
            entity.ToTable("TT31_DanhSachBaoCao");

            entity.Property(e => e.Id)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID");
            entity.Property(e => e.Int).HasColumnName("int");
            entity.Property(e => e.KyBaocao).HasMaxLength(50);
            entity.Property(e => e.LoaiBaoCao).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Query)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Tt31Template>(entity =>
        {
            entity.ToTable("TT31_Template");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ChiTieu)
                .HasMaxLength(200)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("chi_tieu");
            entity.Property(e => e.Dong)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("dong");
            entity.Property(e => e.InDam).HasColumnName("in_dam");
            entity.Property(e => e.MaMucDichVay)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("ma_muc_dich_vay");
            entity.Property(e => e.Mau)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("mau");
            entity.Property(e => e.N1).HasColumnName("n1");
            entity.Property(e => e.N10).HasColumnName("n10");
            entity.Property(e => e.N11).HasColumnName("n11");
            entity.Property(e => e.N12).HasColumnName("n12");
            entity.Property(e => e.N13).HasColumnName("n13");
            entity.Property(e => e.N14).HasColumnName("n14");
            entity.Property(e => e.N15).HasColumnName("n15");
            entity.Property(e => e.N16).HasColumnName("n16");
            entity.Property(e => e.N17).HasColumnName("n17");
            entity.Property(e => e.N18).HasColumnName("n18");
            entity.Property(e => e.N19).HasColumnName("n19");
            entity.Property(e => e.N2).HasColumnName("n2");
            entity.Property(e => e.N20).HasColumnName("n20");
            entity.Property(e => e.N3).HasColumnName("n3");
            entity.Property(e => e.N4).HasColumnName("n4");
            entity.Property(e => e.N5).HasColumnName("n5");
            entity.Property(e => e.N6).HasColumnName("n6");
            entity.Property(e => e.N7).HasColumnName("n7");
            entity.Property(e => e.N8).HasColumnName("n8");
            entity.Property(e => e.N9).HasColumnName("n9");
            entity.Property(e => e.Stt)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("stt");
        });

        modelBuilder.Entity<Tt35CanDoiTkChiTieu>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TT35_CanDoiTK_ChiTieu");

            entity.Property(e => e.CanDoiLoai)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CanDoi_Loai");
            entity.Property(e => e.CoCuoiKy).HasColumnName("Co_Cuoi_Ky");
            entity.Property(e => e.CoDauKy).HasColumnName("Co_Dau_Ky");
            entity.Property(e => e.CoTrongKy).HasColumnName("Co_Trong_Ky");
            entity.Property(e => e.Id)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID");
            entity.Property(e => e.MaTk)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Ma_TK");
            entity.Property(e => e.NoCuoiKy).HasColumnName("No_Cuoi_Ky");
            entity.Property(e => e.NoDauKy).HasColumnName("No_Dau_Ky");
            entity.Property(e => e.NoTrongKy).HasColumnName("No_Trong_Ky");
            entity.Property(e => e.TenTaiKhoan).HasColumnName("Ten_TaiKhoan");
        });

        modelBuilder.Entity<Tt35CanDoiTkChiTieu1112>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TT35_CanDoiTK_ChiTieu_1112");

            entity.Property(e => e.CanDoiLoai)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CanDoi_Loai");
            entity.Property(e => e.CoCuoiKy).HasColumnName("Co_Cuoi_Ky");
            entity.Property(e => e.CoDauKy).HasColumnName("Co_Dau_Ky");
            entity.Property(e => e.CoTrongKy).HasColumnName("Co_Trong_Ky");
            entity.Property(e => e.Id)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID");
            entity.Property(e => e.MaTk)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Ma_TK");
            entity.Property(e => e.NoCuoiKy).HasColumnName("No_Cuoi_Ky");
            entity.Property(e => e.NoDauKy).HasColumnName("No_Dau_Ky");
            entity.Property(e => e.NoTrongKy).HasColumnName("No_Trong_Ky");
        });

        modelBuilder.Entity<Tt35CanDoiTkChiTieu5870>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TT35_CanDoiTK_ChiTieu_5870");

            entity.Property(e => e.CanDoiLoai)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasColumnName("CanDoi_Loai");
            entity.Property(e => e.CoCuoiKy).HasColumnName("Co_Cuoi_Ky");
            entity.Property(e => e.CoDauKy).HasColumnName("Co_Dau_Ky");
            entity.Property(e => e.CoTrongKy).HasColumnName("Co_Trong_Ky");
            entity.Property(e => e.Id)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID");
            entity.Property(e => e.MaTk)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Ma_TK");
            entity.Property(e => e.NoCuoiKy).HasColumnName("No_Cuoi_Ky");
            entity.Property(e => e.NoDauKy).HasColumnName("No_Dau_Ky");
            entity.Property(e => e.NoTrongKy).HasColumnName("No_Trong_Ky");
            entity.Property(e => e.TenTaiKhoan).HasColumnName("Ten_TaiKhoan");
        });

        modelBuilder.Entity<Tt35DanhSachBaoCao>(entity =>
        {
            entity.ToTable("TT35_DanhSachBaoCao");

            entity.Property(e => e.Id)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID");
            entity.Property(e => e.Int).HasColumnName("int");
            entity.Property(e => e.KyBaocao).HasMaxLength(50);
            entity.Property(e => e.LoaiBaoCao).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Query)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Query2)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Tt35MauExcel>(entity =>
        {
            entity.HasKey(e => e.Tenbieu);

            entity.ToTable("TT35_MauExcel");

            entity.Property(e => e.Tenbieu)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.CellBatdau)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("Cell_Batdau");
            entity.Property(e => e.CellDlps)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("Cell_DLPS");
            entity.Property(e => e.CellDonvitinh)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("Cell_Donvitinh");
            entity.Property(e => e.CellIdkdbc)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Cell_IDKDBC");
            entity.Property(e => e.CellMaQuy)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("Cell_MaQuy");
            entity.Property(e => e.CellNameKdbc)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Cell_NameKDBC");
            entity.Property(e => e.CellNgayDlps)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("Cell_NgayDLPS");
            entity.Property(e => e.CellReadOnly)
                .HasMaxLength(300)
                .HasColumnName("Cell_ReadOnly");
            entity.Property(e => e.CellTenFile)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("Cell_TenFile");
            entity.Property(e => e.CogianHangCot)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("Cogian_HangCot");
            entity.Property(e => e.DateFormat)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('dd/MM/yyyy')")
                .HasColumnName("Date_Format");
            entity.Property(e => e.DinhdangMacdinh).HasDefaultValueSql("((1))");
            entity.Property(e => e.DlpsSheet1)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DLPS_sheet1");
            entity.Property(e => e.DlpsSheet2)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DLPS_sheet2");
            entity.Property(e => e.Donvitinh)
                .HasMaxLength(250)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Duongdan)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.FileMau)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.IntFormat)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('### ### ### ###')")
                .HasColumnName("Int_Format");
            entity.Property(e => e.LuuFile).HasDefaultValueSql("((0))");
            entity.Property(e => e.MoFile).HasDefaultValueSql("((1))");
            entity.Property(e => e.NumericFormat)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('### ### ###.###')")
                .HasColumnName("Numeric_Format");
            entity.Property(e => e.TenSheet)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValueSql("('Sheet1')")
                .HasColumnName("Ten_Sheet");
            entity.Property(e => e.TenSheet2)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("Ten_Sheet2");
        });

        modelBuilder.Entity<Tt35NganquyTcnv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TT35_NGANQUY_TCNV");

            entity.Property(e => e.Id)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("id");
            entity.Property(e => e.LoaiTien)
                .HasMaxLength(50)
                .HasColumnName("loai_tien");
            entity.Property(e => e.LoaiTienId)
                .HasMaxLength(50)
                .HasColumnName("loai_tien_id");
            entity.Property(e => e.Ma)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("ma");
            entity.Property(e => e.N10ChiNoiBoTctd)
                .HasDefaultValueSql("((0))")
                .HasColumnName("n10_ChiNoiBoTCTD");
            entity.Property(e => e.N11CongChi)
                .HasDefaultValueSql("((0))")
                .HasColumnName("n11_CongChi");
            entity.Property(e => e.N12TonQuyCk)
                .HasDefaultValueSql("((0))")
                .HasColumnName("n12_TonQuyCK");
            entity.Property(e => e.N13TyLeThu)
                .HasDefaultValueSql("((0))")
                .HasColumnName("n13_TyLeThu");
            entity.Property(e => e.N14TyleChi)
                .HasDefaultValueSql("((0))")
                .HasColumnName("n14_TyleChi");
            entity.Property(e => e.N1TonDk)
                .HasDefaultValueSql("((0))")
                .HasColumnName("n1_TonDK");
            entity.Property(e => e.N2ThuNhnn)
                .HasDefaultValueSql("((0))")
                .HasColumnName("n2_ThuNHNN");
            entity.Property(e => e.N3ThuTctdk)
                .HasDefaultValueSql("((0))")
                .HasColumnName("n3_ThuTCTDK");
            entity.Property(e => e.N4ThuKh)
                .HasDefaultValueSql("((0))")
                .HasColumnName("n4_ThuKH");
            entity.Property(e => e.N5ThuNoiBoTctd)
                .HasDefaultValueSql("((0))")
                .HasColumnName("n5_ThuNoiBoTCTD");
            entity.Property(e => e.N6CongThu)
                .HasDefaultValueSql("((0))")
                .HasColumnName("n6_CongThu");
            entity.Property(e => e.N7ChiNopNhnn)
                .HasDefaultValueSql("((0))")
                .HasColumnName("n7_ChiNopNHNN");
            entity.Property(e => e.N8ChiTctdk)
                .HasDefaultValueSql("((0))")
                .HasColumnName("n8_ChiTCTDK");
            entity.Property(e => e.N9ChiKh)
                .HasDefaultValueSql("((0))")
                .HasColumnName("n9_ChiKH");
            entity.Property(e => e.NgayBc)
                .HasColumnType("datetime")
                .HasColumnName("ngay_bc");
        });

        modelBuilder.Entity<Tt35NguoiDung>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TT35_NguoiDung");

            entity.Property(e => e.GhiChu).HasMaxLength(300);
            entity.Property(e => e.IdKdbc)
                .HasMaxLength(50)
                .HasColumnName("ID_KDBC");
            entity.Property(e => e.NameKdbc)
                .HasMaxLength(200)
                .HasColumnName("Name_KDBC");
        });

        modelBuilder.Entity<Tt35RrlsChitieu>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TT35_RRLS_CHITIEU");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.N1QuaHan).HasColumnName("N1_QuaHan");
            entity.Property(e => e.N2KhongChiuLai).HasColumnName("N2_KhongChiuLai");
            entity.Property(e => e.N3Duoi1Thang).HasColumnName("N3_Duoi1Thang");
            entity.Property(e => e.N4Tu1Den3).HasColumnName("N4_Tu1Den3");
            entity.Property(e => e.N5Tren3Den6).HasColumnName("N5_Tren3Den6");
            entity.Property(e => e.N6Tren6Den12).HasColumnName("N6_Tren6Den12");
            entity.Property(e => e.N7Tren12Den60).HasColumnName("N7_Tren12Den60");
            entity.Property(e => e.TenChiTieu)
                .HasMaxLength(500)
                .HasColumnName("ten_chi_tieu");
        });

        modelBuilder.Entity<Tt35RrtkChitieu>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TT35_RRTK_CHITIEU");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.TenChiTieu)
                .HasMaxLength(500)
                .HasColumnName("ten_chi_tieu");
            entity.Property(e => e.TrongHanTren1Nden5N).HasColumnName("TrongHanTren1NDen5N");
        });

        modelBuilder.Entity<Tt35TindungMucdichvayCongthuc>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TT35_TINDUNG_MUCDICHVAY_CONGTHUC");

            entity.Property(e => e.BaoCao)
                .HasMaxLength(50)
                .HasColumnName("bao_cao");
            entity.Property(e => e.ChiTieu).HasColumnName("chi_tieu");
            entity.Property(e => e.CongThuc).HasColumnName("cong_thuc");
            entity.Property(e => e.Id)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("id");
            entity.Property(e => e.Ma)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("ma");
            entity.Property(e => e.MucDichVay)
                .HasMaxLength(200)
                .HasColumnName("muc_dich_vay");
        });

        modelBuilder.Entity<Tt35TkeBccongthuc>(entity =>
        {
            entity.HasKey(e => new { e.Tenbieu, e.Id }).HasName("PK_35_BC_CONGTHUC");

            entity.ToTable("TT35_TKE_BCCONGTHUC");

            entity.Property(e => e.Tenbieu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TENBIEU");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Chenhlech)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("CHENHLECH");
            entity.Property(e => e.Chitieu)
                .HasMaxLength(300)
                .HasColumnName("CHITIEU");
            entity.Property(e => e.Congtru)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("CONGTRU");
            entity.Property(e => e.Indam)
                .HasDefaultValueSql("((0))")
                .HasColumnName("INDAM");
            entity.Property(e => e.Nhatsolieu)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("NHATSOLIEU");
            entity.Property(e => e.Stt)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STT");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK_Users");

            entity.ToTable("USERS");

            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.ChiNhanhId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("ChiNhanh_ID");
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .HasDefaultValueSql("(N' ')");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.FullName)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N' ')");
            entity.Property(e => e.GroupId).HasColumnName("GroupID");
            entity.Property(e => e.IsActivated).HasDefaultValueSql("((1))");
            entity.Property(e => e.Password)
                .HasMaxLength(100)
                .HasDefaultValueSql("(N' ')");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.TaiKhoan)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('1011001.0001.001')");
            entity.Property(e => e.UserName)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N' ')");
        });

        modelBuilder.Entity<UsersPermission>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.PermissionId });

            entity.ToTable("USERS_PERMISSIONS");

            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.PermissionId).HasColumnName("PermissionID");
            entity.Property(e => e.PermissionKey).HasMaxLength(50);

            entity.HasOne(d => d.User).WithMany(p => p.UsersPermissions)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_USERS_PERMISSIONS_USERS");
        });

        modelBuilder.Entity<VTdung477>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_tdung477");

            entity.Property(e => e.ChinhanhId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("chinhanh_id");
            entity.Property(e => e.GiaoDichId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GiaoDich_ID");
            entity.Property(e => e.LoaiGiaoDichId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Loai_Giao_Dich_ID");
            entity.Property(e => e.LoaiHinhDnMa)
                .HasMaxLength(20)
                .HasColumnName("LoaiHinhDN_Ma");
            entity.Property(e => e.MaHttc)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ma_httc");
            entity.Property(e => e.MaLoaigd)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ma_loaigd");
            entity.Property(e => e.MaLoaitstc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ma_loaitstc");
            entity.Property(e => e.MaLoaivay).HasColumnName("ma_loaivay");
            entity.Property(e => e.NganhNgheKdMa)
                .HasMaxLength(20)
                .HasColumnName("NganhNgheKD_Ma");
            entity.Property(e => e.Ngay).HasColumnType("datetime");
            entity.Property(e => e.SoPhatSinh).HasColumnName("so_phat_sinh");
            entity.Property(e => e.TienTeMa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TienTe_Ma");
            entity.Property(e => e.TienTeTyGia).HasColumnName("TienTe_TyGia");
            entity.Property(e => e.TrangThai).HasColumnName("Trang_Thai");
        });

        modelBuilder.Entity<VTkiem477>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_tkiem477");

            entity.Property(e => e.ChiNhanhMa)
                .HasMaxLength(20)
                .HasColumnName("ChiNhanh_Ma");
            entity.Property(e => e.DvkyHanMa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DVKyHan_Ma");
            entity.Property(e => e.GdtkLoaiGiaoDichMa)
                .HasMaxLength(20)
                .HasColumnName("GDTK_LoaiGiaoDich_Ma");
            entity.Property(e => e.GdtkMa)
                .HasMaxLength(20)
                .HasColumnName("GDTK_Ma");
            entity.Property(e => e.GdtkNgayGiaoDich)
                .HasColumnType("datetime")
                .HasColumnName("GDTK_NgayGiaoDich");
            entity.Property(e => e.GdtkSoTien)
                .HasColumnType("money")
                .HasColumnName("GDTK_SoTien");
            entity.Property(e => e.GdtkSoTietKiem)
                .HasMaxLength(20)
                .HasColumnName("GDTK_SoTietKiem");
            entity.Property(e => e.GdtkTrangThai).HasColumnName("GDTK_TrangThai");
            entity.Property(e => e.LoaiHinhDnMa)
                .HasMaxLength(20)
                .HasColumnName("LoaiHinhDN_Ma");
            entity.Property(e => e.NganhNgheKdMa)
                .HasMaxLength(20)
                .HasColumnName("NganhNgheKD_Ma");
            entity.Property(e => e.SanPhamKyHan).HasColumnName("SanPham_KyHan");
            entity.Property(e => e.TienTeMa)
                .HasMaxLength(20)
                .HasColumnName("TienTe_Ma");
            entity.Property(e => e.TienTeTyGia)
                .HasColumnType("money")
                .HasColumnName("TienTe_TyGia");
        });

        modelBuilder.Entity<Vb1112Tstc>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("VB1112_TSTC");

            entity.Property(e => e.CmndCts)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CMND_CTS");
            entity.Property(e => e.CmndVay)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CMND_VAY");
            entity.Property(e => e.DuNo).HasColumnName("DU_NO");
            entity.Property(e => e.HosotdId)
                .HasMaxLength(30)
                .HasColumnName("HOSOTD_ID");
            entity.Property(e => e.KhMa)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("KH_MA");
            entity.Property(e => e.NgayDangKy)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NGAY_DangKy");
            entity.Property(e => e.NgayNhap)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NGAY_NHAP");
            entity.Property(e => e.NgayXuat)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NGAY_XUAT");
            entity.Property(e => e.SoHieuTs)
                .HasMaxLength(50)
                .HasColumnName("SoHieuTS");
            entity.Property(e => e.Stt)
                .ValueGeneratedOnAdd()
                .HasColumnName("STT");
            entity.Property(e => e.TaikhoanHt)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TAIKHOAN_HT");
            entity.Property(e => e.TenVay)
                .HasMaxLength(355)
                .HasColumnName("TEN_VAY");
            entity.Property(e => e.ThoiHanTsBd)
                .HasMaxLength(50)
                .HasColumnName("ThoiHanTS_BD");
            entity.Property(e => e.ThoiHanTsKt)
                .HasMaxLength(100)
                .HasColumnName("ThoiHanTS_KT");
            entity.Property(e => e.ThongtinCts)
                .HasMaxLength(1000)
                .HasColumnName("THONGTIN_CTS");
            entity.Property(e => e.TsGiatri).HasColumnName("TS_GIATRI");
            entity.Property(e => e.TsGiatriBd).HasColumnName("TS_GIATRI_BD");
            entity.Property(e => e.TsGiatrisudung).HasColumnName("TS_GIATRISUDUNG");
            entity.Property(e => e.TsId)
                .HasMaxLength(30)
                .HasColumnName("TS_ID");
            entity.Property(e => e.TsLoai)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TS_LOAI");
            entity.Property(e => e.TsMa)
                .HasMaxLength(30)
                .HasColumnName("TS_MA");
            entity.Property(e => e.TsRr).HasColumnName("TS_RR");
        });

        modelBuilder.Entity<Vb2947DanhSachBaoCao>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("VB2947_DanhSachBaoCao");

            entity.Property(e => e.Id)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID");
            entity.Property(e => e.Int).HasColumnName("int");
            entity.Property(e => e.KyBaocao).HasMaxLength(50);
            entity.Property(e => e.LoaiBaoCao).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Query)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Query2)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Vb2947MauExcel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("VB2947_MauExcel");

            entity.Property(e => e.CellBatdau)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Cell_Batdau");
            entity.Property(e => e.CellDlps)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Cell_DLPS");
            entity.Property(e => e.CellDonvitinh)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Cell_Donvitinh");
            entity.Property(e => e.CellIdkdbc)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Cell_IDKDBC");
            entity.Property(e => e.CellMaQuy)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Cell_MaQuy");
            entity.Property(e => e.CellNameKdbc)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Cell_NameKDBC");
            entity.Property(e => e.CellNgayDlps)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Cell_NgayDLPS");
            entity.Property(e => e.CellReadOnly)
                .HasMaxLength(300)
                .HasColumnName("Cell_ReadOnly");
            entity.Property(e => e.CellTenFile)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Cell_TenFile");
            entity.Property(e => e.CogianHangCot)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Cogian_HangCot");
            entity.Property(e => e.DateFormat)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Date_Format");
            entity.Property(e => e.DlpsSheet1)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DLPS_sheet1");
            entity.Property(e => e.DlpsSheet2)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DLPS_sheet2");
            entity.Property(e => e.Donvitinh).HasMaxLength(250);
            entity.Property(e => e.Duongdan)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.FileMau)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IntFormat)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Int_Format");
            entity.Property(e => e.NumericFormat)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Numeric_Format");
            entity.Property(e => e.TenSheet)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("Ten_Sheet");
            entity.Property(e => e.TenSheet2)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("Ten_Sheet2");
            entity.Property(e => e.Tenbieu)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Vb2947Tietkiem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("VB2947_TIETKIEM");

            entity.Property(e => e.Cmnd)
                .HasMaxLength(20)
                .HasColumnName("CMND");
            entity.Property(e => e.Id)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID");
            entity.Property(e => e.KhId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KH_ID");
            entity.Property(e => e.MaTk)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Ma_TK");
            entity.Property(e => e.NgayDenHan)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.NgayGui)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.SanPhamId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SanPham_ID");
            entity.Property(e => e.SoDu).HasColumnName("So_du");
            entity.Property(e => e.Stt)
                .ValueGeneratedOnAdd()
                .HasColumnName("STT");
        });

        modelBuilder.Entity<Vb2947Tindung>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("VB2947_TINDUNG");

            entity.Property(e => e.GiainganId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GIAINGAN_ID");
            entity.Property(e => e.GiatriTs).HasColumnName("GIATRI_TS");
            entity.Property(e => e.HosoId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("HOSO_ID");
            entity.Property(e => e.KhCmnd)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("KH_CMND");
            entity.Property(e => e.KhachhangId)
                .HasMaxLength(50)
                .HasColumnName("KHACHHANG_ID");
            entity.Property(e => e.KhachhangLoai).HasColumnName("KHACHHANG_LOAI");
            entity.Property(e => e.KhachhangTen)
                .HasMaxLength(100)
                .HasColumnName("KHACHHANG_TEN");
            entity.Property(e => e.Kyhan).HasColumnName("KYHAN");
            entity.Property(e => e.Laisuat).HasColumnName("LAISUAT");
            entity.Property(e => e.LaisuatThucte).HasColumnName("LAISUAT_THUCTE");
            entity.Property(e => e.LoaiGiaodich)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("LOAI_GIAODICH");
            entity.Property(e => e.LoaiKyhan)
                .HasMaxLength(20)
                .HasColumnName("LOAI_KYHAN");
            entity.Property(e => e.LoaiTs)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("LOAI_TS");
            entity.Property(e => e.MaNganh)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MA_NGANH");
            entity.Property(e => e.NgayDuthu)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("NGAY_DUTHU");
            entity.Property(e => e.Ngaydaohan)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("NGAYDAOHAN");
            entity.Property(e => e.Ngaygiaodich)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("NGAYGIAODICH");
            entity.Property(e => e.Ngayvay)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("NGAYVAY");
            entity.Property(e => e.NhomNo).HasColumnName("NHOM_NO");
            entity.Property(e => e.NhomnoQh2)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("NHOMNO_QH_2");
            entity.Property(e => e.NhomnoQhCu)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("NHOMNO_QH_CU");
            entity.Property(e => e.NhomnoTh2)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("NHOMNO_TH_2");
            entity.Property(e => e.NhomnoThCu)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("NHOMNO_TH_CU");
            entity.Property(e => e.SoChungtu)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SO_CHUNGTU");
            entity.Property(e => e.SoDuno).HasColumnName("SO_DUNO");
            entity.Property(e => e.SoHd)
                .HasMaxLength(30)
                .HasColumnName("SO_HD");
            entity.Property(e => e.SoPhatsinh).HasColumnName("SO_PHATSINH");
            entity.Property(e => e.Sotienvay).HasColumnName("SOTIENVAY");
            entity.Property(e => e.Tien2191).HasColumnName("TIEN_2191");
            entity.Property(e => e.TienDuthu).HasColumnName("TIEN_DUTHU");
            entity.Property(e => e.TkKetoan)
                .HasMaxLength(20)
                .HasColumnName("TK_KETOAN");
            entity.Property(e => e.TyleDp).HasColumnName("TYLE_DP");
            entity.Property(e => e.VitriQtd)
                .HasMaxLength(50)
                .HasColumnName("VITRI_QTD");
            entity.Property(e => e.Vontuco).HasColumnName("VONTUCO");
        });

        modelBuilder.Entity<Vb2947Tstc>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("VB2947_TSTC");

            entity.Property(e => e.CmndCts)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CMND_CTS");
            entity.Property(e => e.CmndVay)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CMND_VAY");
            entity.Property(e => e.DuNo).HasColumnName("DU_NO");
            entity.Property(e => e.HosotdId)
                .HasMaxLength(50)
                .HasColumnName("HOSOTD_ID");
            entity.Property(e => e.KhMa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KH_MA");
            entity.Property(e => e.NgayNhap)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NGAY_NHAP");
            entity.Property(e => e.Stt)
                .ValueGeneratedOnAdd()
                .HasColumnName("STT");
            entity.Property(e => e.TaikhoanHt)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TAIKHOAN_HT");
            entity.Property(e => e.TenVay)
                .HasMaxLength(255)
                .HasColumnName("TEN_VAY");
            entity.Property(e => e.ThongtinCts)
                .HasMaxLength(500)
                .HasColumnName("THONGTIN_CTS");
            entity.Property(e => e.TsGiatri).HasColumnName("TS_GIATRI");
            entity.Property(e => e.TsLoai)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("TS_LOAI");
            entity.Property(e => e.TsMa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TS_MA");
            entity.Property(e => e.TsRr)
                .HasDefaultValueSql("((0))")
                .HasColumnName("TS_RR");
        });

        modelBuilder.Entity<VwDmSanPhamTd>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwDm_SanPham_TD");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.DateModify)
                .HasColumnType("datetime")
                .HasColumnName("Date_Modify");
            entity.Property(e => e.DateNew)
                .HasColumnType("datetime")
                .HasColumnName("Date_New");
            entity.Property(e => e.GhiChu)
                .HasMaxLength(255)
                .HasColumnName("Ghi_Chu");
            entity.Property(e => e.HinhThucMa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HinhThuc_Ma");
            entity.Property(e => e.KyHan).HasColumnName("Ky_Han");
            entity.Property(e => e.LaiSuat).HasColumnName("Lai_Suat");
            entity.Property(e => e.LoaiVay).HasColumnName("Loai_Vay");
            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.QuaHan).HasColumnName("Qua_Han");
            entity.Property(e => e.Ten).HasMaxLength(255);
            entity.Property(e => e.TenLoaiVay)
                .HasMaxLength(50)
                .HasColumnName("Ten_Loai_Vay");
            entity.Property(e => e.TenTat)
                .HasMaxLength(20)
                .HasColumnName("Ten_Tat");
            entity.Property(e => e.TienTeMa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TienTe_Ma");
            entity.Property(e => e.TienTeTen)
                .HasMaxLength(250)
                .HasColumnName("TienTe_Ten");
            entity.Property(e => e.Tk1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TK1");
            entity.Property(e => e.Tk2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TK2");
            entity.Property(e => e.Tk3)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TK3");
            entity.Property(e => e.Tk4)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TK4");
            entity.Property(e => e.Tk5)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TK5");
            entity.Property(e => e.Tk6)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TK6");
            entity.Property(e => e.Tk7)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TK7");
            entity.Property(e => e.TkChiDuPhong)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TK_ChiDuPhong");
            entity.Property(e => e.TkDuPhong)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TK_DuPhong");
            entity.Property(e => e.TkDuThu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TK_DuThu");
            entity.Property(e => e.TkLaichuathu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("tk_laichuathu");
            entity.Property(e => e.TkLaiphat)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("tk_laiphat");
            entity.Property(e => e.TkLaithua)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("tk_laithua");
            entity.Property(e => e.TkPhattratruoc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("tk_phattratruoc");
            entity.Property(e => e.TkThuLai)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TK_ThuLai");
            entity.Property(e => e.TkThukhac)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("tk_thukhac");
            entity.Property(e => e.TkTienMat)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TK_TienMat");
            entity.Property(e => e.TkTscamco)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("tk_tscamco");
            entity.Property(e => e.TkTsdb)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TK_TSDB");
            entity.Property(e => e.TkTskdb)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TK_TSKDB");
            entity.Property(e => e.UsersModify)
                .HasMaxLength(20)
                .HasColumnName("Users_Modify");
            entity.Property(e => e.UsersNew)
                .HasMaxLength(20)
                .HasColumnName("Users_New");
        });

        modelBuilder.Entity<VwGiaoDich>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGiao_Dich");

            entity.Property(e => e.ChinhanhId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("chinhanh_id");
            entity.Property(e => e.DateModify)
                .HasColumnType("datetime")
                .HasColumnName("Date_Modify");
            entity.Property(e => e.DateNew)
                .HasColumnType("datetime")
                .HasColumnName("Date_New");
            entity.Property(e => e.DienGiai)
                .HasMaxLength(200)
                .HasColumnName("Dien_Giai");
            entity.Property(e => e.GiaoDichId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GiaoDich_ID");
            entity.Property(e => e.KhId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KH_ID");
            entity.Property(e => e.LoaiChungTuId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Loai_Chung_Tu_ID");
            entity.Property(e => e.LoaiGiaoDichId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Loai_Giao_Dich_ID");
            entity.Property(e => e.MaTkCo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ma_tk_co");
            entity.Property(e => e.MaTkNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ma_tk_no");
            entity.Property(e => e.Ngay).HasColumnType("datetime");
            entity.Property(e => e.ObjectId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("object_id");
            entity.Property(e => e.ObjectSerial)
                .HasMaxLength(20)
                .HasColumnName("object_serial");
            entity.Property(e => e.SoDuToan).HasColumnName("so_du_toan");
            entity.Property(e => e.SoPhatSinh).HasColumnName("so_phat_sinh");
            entity.Property(e => e.TenLoaiChungTu)
                .HasMaxLength(50)
                .HasColumnName("ten_loai_chung_tu");
            entity.Property(e => e.TenLoaiGiaoDich)
                .HasMaxLength(50)
                .HasColumnName("ten_loai_giao_dich");
            entity.Property(e => e.TienTeMa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TienTe_Ma");
            entity.Property(e => e.TienTeTyGia).HasColumnName("TienTe_TyGia");
            entity.Property(e => e.TrangThai).HasColumnName("Trang_Thai");
            entity.Property(e => e.UsersModify)
                .HasMaxLength(20)
                .HasColumnName("Users_Modify");
            entity.Property(e => e.UsersNew)
                .HasMaxLength(20)
                .HasColumnName("Users_New");
        });

        modelBuilder.Entity<VwHstdUpdateMaThongKe>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwHSTD_Update_MaThongKe");

            entity.Property(e => e.HoSoTdId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("HoSoTD_ID");
            entity.Property(e => e.KhuVucMa)
                .HasMaxLength(20)
                .HasColumnName("KhuVuc_Ma");
            entity.Property(e => e.MaThongKe0)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ma_thong_ke0");
            entity.Property(e => e.MaThongKe1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ma_thong_ke1");
            entity.Property(e => e.PhuongThucVayId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PhuongThucVay_ID");
            entity.Property(e => e.Ten).HasMaxLength(255);
            entity.Property(e => e.TenNguoiVay)
                .HasMaxLength(100)
                .HasColumnName("Ten_Nguoi_Vay");
        });

        modelBuilder.Entity<VwKeToanSoDuTaiKhoan>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwKeToan_So_Du_Tai_Khoan");

            entity.Property(e => e.CoCuoiKy).HasColumnName("co_cuoi_ky");
            entity.Property(e => e.CoDauKy).HasColumnName("co_dau_ky");
            entity.Property(e => e.CoDauNam).HasColumnName("co_dau_nam");
            entity.Property(e => e.CoLuyKe).HasColumnName("co_luy_ke");
            entity.Property(e => e.CoTrongKy).HasColumnName("co_trong_ky");
            entity.Property(e => e.LoaiTk)
                .HasMaxLength(5)
                .HasColumnName("Loai_TK");
            entity.Property(e => e.MaId).HasColumnName("ma_id");
            entity.Property(e => e.MaTk)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ma_tk");
            entity.Property(e => e.MaTkTh)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ma_tk_th");
            entity.Property(e => e.Ngay)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.NoCuoiKy).HasColumnName("no_cuoi_ky");
            entity.Property(e => e.NoDauKy).HasColumnName("no_dau_ky");
            entity.Property(e => e.NoDauNam).HasColumnName("no_dau_nam");
            entity.Property(e => e.NoLuyKe).HasColumnName("no_luy_ke");
            entity.Property(e => e.NoTrongKy).HasColumnName("no_trong_ky");
            entity.Property(e => e.TenTk)
                .HasMaxLength(250)
                .HasColumnName("ten_tk");
            entity.Property(e => e.TienTeMa)
                .HasMaxLength(20)
                .HasColumnName("TienTe_Ma");
            entity.Property(e => e.TinhChat).HasColumnName("tinh_chat");
        });

        modelBuilder.Entity<VwKhachHang>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwKhach_Hang");

            entity.Property(e => e.ChinhanhId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CHINHANH_ID");
            entity.Property(e => e.ChucVuMa)
                .HasMaxLength(20)
                .HasColumnName("ChucVu_Ma");
            entity.Property(e => e.CmtNgayCap)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CMT_NgayCap");
            entity.Property(e => e.CmtNoiCap)
                .HasMaxLength(255)
                .HasColumnName("CMT_NoiCap");
            entity.Property(e => e.CmtSerial)
                .HasMaxLength(20)
                .HasColumnName("CMT_Serial");
            entity.Property(e => e.CoPhanThuongNien).HasColumnName("co_phan_thuong_nien");
            entity.Property(e => e.CoPhanThuongXuyen).HasColumnName("co_phan_thuong_xuyen");
            entity.Property(e => e.CoPhanXacLap).HasColumnName("co_phan_xac_lap");
            entity.Property(e => e.DateModify)
                .HasColumnType("datetime")
                .HasColumnName("Date_Modify");
            entity.Property(e => e.DateNew)
                .HasColumnType("datetime")
                .HasColumnName("Date_New");
            entity.Property(e => e.DiaChi)
                .HasMaxLength(255)
                .HasColumnName("Dia_Chi");
            entity.Property(e => e.DiemThuong).HasColumnName("diem_thuong");
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Fax).HasMaxLength(150);
            entity.Property(e => e.GhiChu)
                .HasMaxLength(500)
                .HasColumnName("Ghi_Chu");
            entity.Property(e => e.GioiTinh).HasColumnName("Gioi_Tinh");
            entity.Property(e => e.IsChecked).HasColumnName("Is_Checked");
            entity.Property(e => e.IsLocked).HasColumnName("Is_Locked");
            entity.Property(e => e.KhachHangId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KhachHang_ID");
            entity.Property(e => e.KhuVucMa)
                .HasMaxLength(20)
                .HasColumnName("KhuVuc_Ma");
            entity.Property(e => e.KhuvucTen)
                .HasMaxLength(255)
                .HasColumnName("khuvuc_ten");
            entity.Property(e => e.LoaiHinhDnMa)
                .HasMaxLength(20)
                .HasColumnName("LoaiHinhDN_Ma");
            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.MaSoThue)
                .HasMaxLength(20)
                .HasColumnName("Ma_So_Thue");
            entity.Property(e => e.NganhNgheKdMa)
                .HasMaxLength(20)
                .HasColumnName("NganhNgheKD_Ma");
            entity.Property(e => e.Ngay).HasColumnType("smalldatetime");
            entity.Property(e => e.NgayDkkd)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Ngay_DKKD");
            entity.Property(e => e.NgaySinh)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Ngay_Sinh");
            entity.Property(e => e.NgayTinhDiem)
                .HasColumnType("smalldatetime")
                .HasColumnName("ngay_tinh_diem");
            entity.Property(e => e.NgheNghiepMa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NgheNghiep_Ma");
            entity.Property(e => e.NghenghiepTen)
                .HasMaxLength(50)
                .HasColumnName("nghenghiep_ten");
            entity.Property(e => e.NguoiDaiDien)
                .HasMaxLength(50)
                .HasColumnName("Nguoi_Dai_Dien");
            entity.Property(e => e.PhanLoaiMa).HasColumnName("Phan_Loai_Ma");
            entity.Property(e => e.PhanNhomMa)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("Phan_Nhom_Ma");
            entity.Property(e => e.PhoneMobie)
                .HasMaxLength(150)
                .HasColumnName("Phone_Mobie");
            entity.Property(e => e.PhoneOffice)
                .HasMaxLength(150)
                .HasColumnName("Phone_Office");
            entity.Property(e => e.SoDkkd)
                .HasMaxLength(20)
                .HasColumnName("So_DKKD");
            entity.Property(e => e.Ten).HasMaxLength(255);
            entity.Property(e => e.TenTat)
                .HasMaxLength(20)
                .HasColumnName("Ten_Tat");
            entity.Property(e => e.ThanhVienNgay)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ThanhVien_Ngay");
            entity.Property(e => e.ThanhvienIs).HasColumnName("THANHVIEN_IS");
            entity.Property(e => e.ThanhvienMa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("THANHVIEN_MA");
            entity.Property(e => e.ThanhvienSerial)
                .HasMaxLength(20)
                .HasColumnName("THANHVIEN_SERIAL");
            entity.Property(e => e.UsersModify)
                .HasMaxLength(200)
                .HasColumnName("Users_Modify");
            entity.Property(e => e.UsersNew)
                .HasMaxLength(200)
                .HasColumnName("Users_New");
        });

        modelBuilder.Entity<VwKhachHangCoPhan>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwKhachHang_CoPhan");

            entity.Property(e => e.ChinhanhId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CHINHANH_ID");
            entity.Property(e => e.CmtSerial)
                .HasMaxLength(20)
                .HasColumnName("CMT_Serial");
            entity.Property(e => e.CoPhanGdId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CoPhanGD_ID");
            entity.Property(e => e.DateModify)
                .HasColumnType("datetime")
                .HasColumnName("Date_Modify");
            entity.Property(e => e.DateNew)
                .HasColumnType("datetime")
                .HasColumnName("Date_New");
            entity.Property(e => e.DiaChi)
                .HasMaxLength(255)
                .HasColumnName("Dia_Chi");
            entity.Property(e => e.GhiChu)
                .HasMaxLength(500)
                .HasColumnName("Ghi_Chu");
            entity.Property(e => e.GioiTinh).HasColumnName("Gioi_Tinh");
            entity.Property(e => e.KhachHangId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KhachHang_Id");
            entity.Property(e => e.KhachHangMa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KhachHang_Ma");
            entity.Property(e => e.KhachHangTen)
                .HasMaxLength(255)
                .HasColumnName("KhachHang_Ten");
            entity.Property(e => e.KhuVucMa)
                .HasMaxLength(20)
                .HasColumnName("KhuVuc_Ma");
            entity.Property(e => e.KhuvucTen)
                .HasMaxLength(255)
                .HasColumnName("khuvuc_ten");
            entity.Property(e => e.LaiSuat).HasColumnName("Lai_Suat");
            entity.Property(e => e.LoaiGiaoDich).HasColumnName("Loai_Giao_Dich");
            entity.Property(e => e.LoaiGopVon).HasColumnName("Loai_Gop_Von");
            entity.Property(e => e.LoaiHinhDnMa)
                .HasMaxLength(20)
                .HasColumnName("LoaiHinhDN_Ma");
            entity.Property(e => e.MaTkCo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Ma_Tk_Co");
            entity.Property(e => e.MaTkNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Ma_TK_No");
            entity.Property(e => e.NganhNgheKdMa)
                .HasMaxLength(20)
                .HasColumnName("NganhNgheKD_Ma");
            entity.Property(e => e.Ngay)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.NgayHuongLai)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Ngay_Huong_Lai");
            entity.Property(e => e.PhanLoaiMa).HasColumnName("Phan_Loai_Ma");
            entity.Property(e => e.PhanNhomMa)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("Phan_Nhom_Ma");
            entity.Property(e => e.SoChungTu)
                .HasMaxLength(20)
                .HasColumnName("so_chung_tu");
            entity.Property(e => e.SoPhatSinh).HasColumnName("So_Phat_Sinh");
            entity.Property(e => e.ThanhVienNgay)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ThanhVien_Ngay");
            entity.Property(e => e.ThanhvienIs).HasColumnName("THANHVIEN_IS");
            entity.Property(e => e.ThanhvienMa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("THANHVIEN_MA");
            entity.Property(e => e.ThanhvienSerial)
                .HasMaxLength(20)
                .HasColumnName("THANHVIEN_SERIAL");
            entity.Property(e => e.TrangThai).HasColumnName("Trang_Thai");
            entity.Property(e => e.UsersModify)
                .HasMaxLength(20)
                .HasColumnName("Users_Modify");
            entity.Property(e => e.UsersNew)
                .HasMaxLength(20)
                .HasColumnName("Users_New");
        });

        modelBuilder.Entity<VwKtoanChungTu>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwKTOAN_Chung_Tu");

            entity.Property(e => e.ChiNhanhId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ChiNhanh_id");
            entity.Property(e => e.ChungTuGdId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ChungTuGD_ID");
            entity.Property(e => e.CtuCmtNgay)
                .HasColumnType("smalldatetime")
                .HasColumnName("ctu_cmt_ngay");
            entity.Property(e => e.CtuCmtNoiCap)
                .HasMaxLength(50)
                .HasColumnName("ctu_cmt_noi_cap");
            entity.Property(e => e.CtuCmtSerial)
                .HasMaxLength(50)
                .HasColumnName("ctu_cmt_serial");
            entity.Property(e => e.CtuDiaChi)
                .HasMaxLength(50)
                .HasColumnName("ctu_dia_chi");
            entity.Property(e => e.CtuHoTen)
                .HasMaxLength(50)
                .HasColumnName("ctu_ho_ten");
            entity.Property(e => e.DateModify)
                .HasColumnType("datetime")
                .HasColumnName("Date_Modify");
            entity.Property(e => e.DateNew)
                .HasColumnType("datetime")
                .HasColumnName("Date_New");
            entity.Property(e => e.DienGiai)
                .HasMaxLength(200)
                .HasColumnName("dien_giai");
            entity.Property(e => e.DienGiai0)
                .HasMaxLength(100)
                .HasColumnName("dien_giai0");
            entity.Property(e => e.DienGiai1)
                .HasMaxLength(100)
                .HasColumnName("dien_giai1");
            entity.Property(e => e.DienGiai2)
                .HasMaxLength(100)
                .HasColumnName("dien_giai2");
            entity.Property(e => e.GiaoDichDcId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GiaoDichDC_ID");
            entity.Property(e => e.IsLocked).HasColumnName("Is_Locked");
            entity.Property(e => e.IsSystem).HasColumnName("Is_System");
            entity.Property(e => e.MaChungTu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ma_chung_tu");
            entity.Property(e => e.MaGiaoDich)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ma_giao_dich");
            entity.Property(e => e.MaTkCo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ma_tk_co");
            entity.Property(e => e.MaTkNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ma_tk_no");
            entity.Property(e => e.Ngay)
                .HasColumnType("smalldatetime")
                .HasColumnName("ngay");
            entity.Property(e => e.Serial)
                .HasMaxLength(20)
                .HasColumnName("serial");
            entity.Property(e => e.SoPhatSinh).HasColumnName("so_phat_sinh");
            entity.Property(e => e.TenChungTu)
                .HasMaxLength(50)
                .HasColumnName("ten_chung_tu");
            entity.Property(e => e.TenGiaoDich)
                .HasMaxLength(50)
                .HasColumnName("ten_giao_dich");
            entity.Property(e => e.TenTkCo)
                .HasMaxLength(250)
                .HasColumnName("ten_tk_co");
            entity.Property(e => e.TenTkNo)
                .HasMaxLength(250)
                .HasColumnName("ten_tk_no");
            entity.Property(e => e.TienteMa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("tiente_ma");
            entity.Property(e => e.TienteTen)
                .HasMaxLength(250)
                .HasColumnName("tiente_ten");
            entity.Property(e => e.TienteTyGia).HasColumnName("tiente_ty_gia");
            entity.Property(e => e.TrangThai).HasColumnName("trang_thai");
            entity.Property(e => e.UsersModify)
                .HasMaxLength(20)
                .HasColumnName("Users_Modify");
            entity.Property(e => e.UsersNew)
                .HasMaxLength(20)
                .HasColumnName("Users_New");
        });

        modelBuilder.Entity<VwSoTietKiem>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwSoTietKiem");

            entity.Property(e => e.ChiNhanhMa)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("ChiNhanh_Ma");
            entity.Property(e => e.DvkyHanMa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DVKyHan_Ma");
            entity.Property(e => e.HttlMa)
                .HasMaxLength(20)
                .HasColumnName("HTTL_Ma");
            entity.Property(e => e.KhachHangMa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KhachHang_Ma");
            entity.Property(e => e.LoaiHinhDnMa)
                .HasMaxLength(20)
                .HasColumnName("LoaiHinhDN_Ma");
            entity.Property(e => e.SanPhamKyHan).HasColumnName("SanPham_KyHan");
            entity.Property(e => e.SanPhamMa)
                .HasMaxLength(20)
                .HasColumnName("SanPham_Ma");
            entity.Property(e => e.StkCoTheThayDoiLaiSuat).HasColumnName("STK_CoTheThayDoiLaiSuat");
            entity.Property(e => e.StkDaLaiNhapGoc).HasColumnName("STK_DaLaiNhapGoc");
            entity.Property(e => e.StkDuChi)
                .HasColumnType("money")
                .HasColumnName("STK_DuChi");
            entity.Property(e => e.StkDuChiDenNgay)
                .HasColumnType("datetime")
                .HasColumnName("STK_DuChiDenNgay");
            entity.Property(e => e.StkGhiChu)
                .HasMaxLength(255)
                .HasColumnName("STK_GhiChu");
            entity.Property(e => e.StkLaiDaTra)
                .HasColumnType("money")
                .HasColumnName("STK_LaiDaTra");
            entity.Property(e => e.StkMa)
                .HasMaxLength(20)
                .HasColumnName("STK_Ma");
            entity.Property(e => e.StkNgayBatDau)
                .HasColumnType("datetime")
                .HasColumnName("STK_NgayBatDau");
            entity.Property(e => e.StkNgayBatDauTinhLai)
                .HasColumnType("datetime")
                .HasColumnName("STK_NgayBatDauTinhLai");
            entity.Property(e => e.StkNgayDenHan)
                .HasColumnType("datetime")
                .HasColumnName("STK_NgayDenHan");
            entity.Property(e => e.StkNgayKyMoi)
                .HasColumnType("datetime")
                .HasColumnName("STK_NgayKyMoi");
            entity.Property(e => e.StkPhongToa).HasColumnName("STK_PhongToa");
            entity.Property(e => e.StkSoDu)
                .HasColumnType("money")
                .HasColumnName("STK_SoDu");
            entity.Property(e => e.StkSoTietKiem)
                .HasMaxLength(20)
                .HasColumnName("STK_SoTietKiem");
            entity.Property(e => e.StkTen)
                .HasMaxLength(255)
                .HasColumnName("STK_Ten");
            entity.Property(e => e.StkTkct)
                .HasMaxLength(20)
                .HasColumnName("STK_TKCT");
            entity.Property(e => e.StkTrangThai).HasColumnName("STK_TrangThai");
            entity.Property(e => e.TienTeMa)
                .HasMaxLength(20)
                .HasColumnName("TienTe_Ma");
        });

        modelBuilder.Entity<VwTdungGiaiNgan>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwTDUNG_Giai_Ngan");

            entity.Property(e => e.CmtSerial)
                .HasMaxLength(20)
                .HasColumnName("CMT_Serial");
            entity.Property(e => e.DiaChi)
                .HasMaxLength(255)
                .HasColumnName("Dia_Chi");
            entity.Property(e => e.DienGiai)
                .HasMaxLength(400)
                .HasColumnName("Dien_Giai");
            entity.Property(e => e.DoiTuongId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Doi_Tuong_ID");
            entity.Property(e => e.DonViKyHan).HasColumnName("Don_Vi_Ky_Han");
            entity.Property(e => e.GhiChu)
                .HasMaxLength(500)
                .HasColumnName("Ghi_Chu");
            entity.Property(e => e.GiaiNganId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GiaiNgan_ID");
            entity.Property(e => e.HinhThucGnId).HasColumnName("HinhThucGN_ID");
            entity.Property(e => e.HinhThucTraLaiId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("HinhThucTraLai_ID");
            entity.Property(e => e.HinhThucTstcId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("HinhThucTSTC_ID");
            entity.Property(e => e.HoSoTdId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("HoSoTD_ID");
            entity.Property(e => e.KhachHangId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KhachHang_ID");
            entity.Property(e => e.KhachHangMa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KhachHang_Ma");
            entity.Property(e => e.KhachHangTen)
                .HasMaxLength(255)
                .HasColumnName("KhachHang_Ten");
            entity.Property(e => e.KhuVucMa)
                .HasMaxLength(20)
                .HasColumnName("KhuVuc_Ma");
            entity.Property(e => e.KhuvucTen)
                .HasMaxLength(255)
                .HasColumnName("khuvuc_ten");
            entity.Property(e => e.KieuLaiSuat).HasColumnName("Kieu_Lai_Suat");
            entity.Property(e => e.KyHanVay).HasColumnName("Ky_Han_Vay");
            entity.Property(e => e.LaiSuat).HasColumnName("Lai_Suat");
            entity.Property(e => e.LaiSuatQuaHan).HasColumnName("Lai_Suat_Qua_Han");
            entity.Property(e => e.LaiSuatUuDai).HasColumnName("Lai_Suat_Uu_Dai");
            entity.Property(e => e.LoaiVayId).HasColumnName("Loai_Vay_ID");
            entity.Property(e => e.MaMucDichVay)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ma_muc_dich_vay");
            entity.Property(e => e.MaThongKe0)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ma_thong_ke0");
            entity.Property(e => e.MaThongKe1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ma_thong_ke1");
            entity.Property(e => e.MaTkCo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Ma_TK_Co");
            entity.Property(e => e.MaTkNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Ma_TK_No");
            entity.Property(e => e.MucDichVay)
                .HasMaxLength(255)
                .HasColumnName("Muc_Dich_Vay");
            entity.Property(e => e.Ngay)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.NgayChuyenQuaHan)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Ngay_Chuyen_Qua_Han");
            entity.Property(e => e.NgayDaoHan)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ngay_dao_han");
            entity.Property(e => e.NgayGiaHan)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Ngay_Gia_Han");
            entity.Property(e => e.NgayHopDong)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ngay_hop_dong");
            entity.Property(e => e.NgayTinhLai)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Ngay_Tinh_Lai");
            entity.Property(e => e.NgayVay)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ngay_vay");
            entity.Property(e => e.NhomNo).HasColumnName("Nhom_No");
            entity.Property(e => e.PhuongThucVayId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PhuongThucVay_ID");
            entity.Property(e => e.SanPhamTdId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SanPhamTD_ID");
            entity.Property(e => e.SoDu).HasColumnName("So_Du");
            entity.Property(e => e.SoDuToan).HasColumnName("So_Du_Toan");
            entity.Property(e => e.SoHopDong)
                .HasMaxLength(20)
                .HasColumnName("So_Hop_Dong");
            entity.Property(e => e.SoTien).HasColumnName("So_Tien");
            entity.Property(e => e.SoTienVay).HasColumnName("So_Tien_Vay");
            entity.Property(e => e.TenLoaiVay)
                .HasMaxLength(50)
                .HasColumnName("ten_loai_vay");
            entity.Property(e => e.TenNguoiVay)
                .HasMaxLength(100)
                .HasColumnName("Ten_Nguoi_Vay");
            entity.Property(e => e.ThanhvienSerial)
                .HasMaxLength(20)
                .HasColumnName("THANHVIEN_SERIAL");
            entity.Property(e => e.ThuaThieuKyNay).HasColumnName("Thua_Thieu_Ky_Nay");
            entity.Property(e => e.ThuaThieuKyTruoc).HasColumnName("Thua_Thieu_Ky_Truoc");
            entity.Property(e => e.TkTinDung)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TK_Tin_Dung");
            entity.Property(e => e.TrangThai).HasColumnName("Trang_Thai");
        });

        modelBuilder.Entity<VwTdungHoSoTinDung>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwTDUNG_HoSoTinDung");

            entity.Property(e => e.CmtNgayCap)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CMT_NgayCap");
            entity.Property(e => e.CmtNoiCap)
                .HasMaxLength(255)
                .HasColumnName("CMT_NoiCap");
            entity.Property(e => e.CmtSerial)
                .HasMaxLength(20)
                .HasColumnName("CMT_Serial");
            entity.Property(e => e.DateModify)
                .HasColumnType("datetime")
                .HasColumnName("Date_Modify");
            entity.Property(e => e.DateNew)
                .HasColumnType("datetime")
                .HasColumnName("Date_New");
            entity.Property(e => e.DauVao).HasColumnName("Dau_Vao");
            entity.Property(e => e.DiaChi)
                .HasMaxLength(255)
                .HasColumnName("Dia_Chi");
            entity.Property(e => e.DoiTuongId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Doi_Tuong_ID");
            entity.Property(e => e.DonViKyHan).HasColumnName("Don_Vi_Ky_Han");
            entity.Property(e => e.GhiChu)
                .HasMaxLength(400)
                .HasColumnName("Ghi_Chu");
            entity.Property(e => e.GocDaThu).HasColumnName("Goc_Da_Thu");
            entity.Property(e => e.GocDenNgay)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Goc_Den_Ngay");
            entity.Property(e => e.GocKyCuoi).HasColumnName("Goc_Ky_Cuoi");
            entity.Property(e => e.GocTheoKy).HasColumnName("Goc_Theo_Ky");
            entity.Property(e => e.HinhThucTraLaiId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("HinhThucTraLai_ID");
            entity.Property(e => e.HinhThucTraLaiTen)
                .HasMaxLength(50)
                .HasColumnName("HinhThucTraLai_Ten");
            entity.Property(e => e.HinhThucTstcId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("HinhThucTSTC_ID");
            entity.Property(e => e.HinhThucTstcTen)
                .HasMaxLength(50)
                .HasColumnName("HinhThucTSTC_Ten");
            entity.Property(e => e.HoSoTdId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("HoSoTD_ID");
            entity.Property(e => e.HstdParent)
                .HasMaxLength(20)
                .HasColumnName("HSTD_parent");
            entity.Property(e => e.IsChecked).HasColumnName("Is_Checked");
            entity.Property(e => e.KhachHangId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KhachHang_ID");
            entity.Property(e => e.KhachHangMa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KhachHang_Ma");
            entity.Property(e => e.KhachHangTen)
                .HasMaxLength(255)
                .HasColumnName("KhachHang_Ten");
            entity.Property(e => e.KhuVucMa)
                .HasMaxLength(20)
                .HasColumnName("KhuVuc_Ma");
            entity.Property(e => e.KhuvucTen)
                .HasMaxLength(255)
                .HasColumnName("khuvuc_ten");
            entity.Property(e => e.KieuLaiSuat).HasColumnName("Kieu_Lai_Suat");
            entity.Property(e => e.KyHanVay).HasColumnName("Ky_Han_Vay");
            entity.Property(e => e.LaiDaThu).HasColumnName("Lai_Da_Thu");
            entity.Property(e => e.LaiDenNgay)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Lai_Den_Ngay");
            entity.Property(e => e.LaiDuThu).HasColumnName("Lai_Du_Thu");
            entity.Property(e => e.LaiKyCuoi).HasColumnName("Lai_Ky_Cuoi");
            entity.Property(e => e.LaiPhaiThu).HasColumnName("Lai_Phai_Thu");
            entity.Property(e => e.LaiSuat).HasColumnName("Lai_Suat");
            entity.Property(e => e.LaiSuatQuaHan).HasColumnName("Lai_Suat_Qua_Han");
            entity.Property(e => e.LaiSuatUuDai).HasColumnName("Lai_Suat_Uu_Dai");
            entity.Property(e => e.LaiTheoKy).HasColumnName("Lai_Theo_Ky");
            entity.Property(e => e.LoaiHinhDnMa)
                .HasMaxLength(20)
                .HasColumnName("LoaiHinhDN_Ma");
            entity.Property(e => e.LoaiVayId).HasColumnName("Loai_Vay_ID");
            entity.Property(e => e.MaMucDichVay)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ma_muc_dich_vay");
            entity.Property(e => e.MaThongKe0)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ma_thong_ke0");
            entity.Property(e => e.MaThongKe1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ma_thong_ke1");
            entity.Property(e => e.MucDichVay)
                .HasMaxLength(255)
                .HasColumnName("Muc_Dich_Vay");
            entity.Property(e => e.NganhNgheKdMa)
                .HasMaxLength(20)
                .HasColumnName("NganhNgheKD_Ma");
            entity.Property(e => e.NgayChuyenQuaHan)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Ngay_Chuyen_Qua_Han");
            entity.Property(e => e.NgayDaoHan)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ngay_dao_han");
            entity.Property(e => e.NgayDtdk)
                .HasColumnType("smalldatetime")
                .HasColumnName("Ngay_DTDK");
            entity.Property(e => e.NgayDuThu)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Ngay_Du_Thu");
            entity.Property(e => e.NgayGiaHan)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Ngay_Gia_Han");
            entity.Property(e => e.NgayGiaiNgan)
                .HasColumnType("smalldatetime")
                .HasColumnName("Ngay_Giai_Ngan");
            entity.Property(e => e.NgayHopDong)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ngay_hop_dong");
            entity.Property(e => e.NgayVay)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ngay_vay");
            entity.Property(e => e.NguoiBaoLanh)
                .HasMaxLength(100)
                .HasColumnName("Nguoi_Bao_Lanh");
            entity.Property(e => e.NguoiThuaKe)
                .HasMaxLength(100)
                .HasColumnName("Nguoi_Thua_Ke");
            entity.Property(e => e.NguyenNhanNo)
                .HasMaxLength(20)
                .HasColumnName("Nguyen_Nhan_No");
            entity.Property(e => e.NhomNo).HasColumnName("Nhom_No");
            entity.Property(e => e.NoQuaHan).HasColumnName("No_Qua_Han");
            entity.Property(e => e.PhanLoaiMa).HasColumnName("Phan_Loai_Ma");
            entity.Property(e => e.PhoneMobie)
                .HasMaxLength(150)
                .HasColumnName("Phone_Mobie");
            entity.Property(e => e.PhoneOffice)
                .HasMaxLength(150)
                .HasColumnName("Phone_Office");
            entity.Property(e => e.PhuongThucVayId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PhuongThucVay_ID");
            entity.Property(e => e.PhuongThucVayTen)
                .HasMaxLength(50)
                .HasColumnName("PhuongThucVay_Ten");
            entity.Property(e => e.QuaHan).HasColumnName("Qua_Han");
            entity.Property(e => e.SanPhamTdId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SanPhamTD_ID");
            entity.Property(e => e.SoDu).HasColumnName("So_Du");
            entity.Property(e => e.SoGiaiNgan).HasColumnName("So_Giai_Ngan");
            entity.Property(e => e.SoHopDong)
                .HasMaxLength(20)
                .HasColumnName("So_Hop_Dong");
            entity.Property(e => e.SoKyTraGop).HasColumnName("So_ky_Tra_Gop");
            entity.Property(e => e.SoTienDuPhong).HasColumnName("So_Tien_Du_Phong");
            entity.Property(e => e.SoTienNhan).HasColumnName("So_Tien_Nhan");
            entity.Property(e => e.SoTienNo).HasColumnName("So_Tien_No");
            entity.Property(e => e.SoTienVay).HasColumnName("So_Tien_Vay");
            entity.Property(e => e.Sokheuoc).HasMaxLength(20);
            entity.Property(e => e.TenLoaiVay)
                .HasMaxLength(50)
                .HasColumnName("ten_loai_vay");
            entity.Property(e => e.TenNguoiVay)
                .HasMaxLength(100)
                .HasColumnName("Ten_Nguoi_Vay");
            entity.Property(e => e.TenNhomNo)
                .HasMaxLength(50)
                .HasColumnName("ten_nhom_no");
            entity.Property(e => e.ThanhvienIs).HasColumnName("THANHVIEN_IS");
            entity.Property(e => e.ThanhvienMa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("THANHVIEN_MA");
            entity.Property(e => e.ThanhvienSerial)
                .HasMaxLength(20)
                .HasColumnName("THANHVIEN_SERIAL");
            entity.Property(e => e.Tk1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TK1");
            entity.Property(e => e.Tk2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TK2");
            entity.Property(e => e.Tk3)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TK3");
            entity.Property(e => e.Tk4)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TK4");
            entity.Property(e => e.Tk5)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TK5");
            entity.Property(e => e.Tk7)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TK7");
            entity.Property(e => e.TkChiDuPhong)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TK_ChiDuPhong");
            entity.Property(e => e.TkDuPhong)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TK_DuPhong");
            entity.Property(e => e.TkDuThu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TK_DuThu");
            entity.Property(e => e.TkLaichuathu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("tk_laichuathu");
            entity.Property(e => e.TkLaiphat)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("tk_laiphat");
            entity.Property(e => e.TkLaithua)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("tk_laithua");
            entity.Property(e => e.TkPhattratruoc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("tk_phattratruoc");
            entity.Property(e => e.TkThuLai)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TK_ThuLai");
            entity.Property(e => e.TkThukhac)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("tk_thukhac");
            entity.Property(e => e.TkTienMat)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TK_TienMat");
            entity.Property(e => e.TkTinDung)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TK_Tin_Dung");
            entity.Property(e => e.TkTscamco)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("tk_tscamco");
            entity.Property(e => e.TkTsdb)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TK_TSDB");
            entity.Property(e => e.TkTskdb)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TK_TSKDB");
            entity.Property(e => e.TrangThai).HasColumnName("Trang_Thai");
            entity.Property(e => e.TstcTriGia).HasColumnName("TSTC_Tri_gia");
            entity.Property(e => e.UsersModify)
                .HasMaxLength(50)
                .HasColumnName("Users_Modify");
            entity.Property(e => e.UsersNew)
                .HasMaxLength(50)
                .HasColumnName("Users_New");
        });

        modelBuilder.Entity<VwTdungHstdSoDuByDate>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwTDung_HSTD_SoDuByDate");

            entity.Property(e => e.ChinhanhId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("chinhanh_id");
            entity.Property(e => e.HosoTdId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("HosoTD_ID");
            entity.Property(e => e.KhachHangId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KhachHang_ID");
            entity.Property(e => e.KhuvucMa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("khuvuc_ma");
            entity.Property(e => e.KhuvucTen)
                .HasMaxLength(255)
                .HasColumnName("khuvuc_ten");
            entity.Property(e => e.LaiSuat).HasColumnName("lai_suat");
            entity.Property(e => e.LaiSuatUuDai).HasColumnName("lai_suat_uu_dai");
            entity.Property(e => e.LoaiHinhKinhTeId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("loai_hinh_kinh_te_id");
            entity.Property(e => e.LoaiTienId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("loai_tien_id");
            entity.Property(e => e.LoaiVayId).HasColumnName("loai_vay_id");
            entity.Property(e => e.MucDichVayId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("muc_dich_vay_id");
            entity.Property(e => e.NganhKinhTeId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nganh_kinh_te_id");
            entity.Property(e => e.NgayDaoHan)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ngay_dao_han");
            entity.Property(e => e.NgayVay)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ngay_vay");
            entity.Property(e => e.NhomNo).HasColumnName("nhom_no");
            entity.Property(e => e.PhuongThucTheChapId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("phuong_thuc_the_chap_id");
            entity.Property(e => e.SanPhamTdId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SanPhamTD_ID");
            entity.Property(e => e.SoDu).HasColumnName("so_du");
            entity.Property(e => e.SoHopDong)
                .HasMaxLength(20)
                .HasColumnName("So_Hop_Dong");
            entity.Property(e => e.TenNguoiVay)
                .HasMaxLength(100)
                .HasColumnName("Ten_Nguoi_Vay");
            entity.Property(e => e.TkTinDung)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("tk_tin_dung");
        });

        modelBuilder.Entity<VwTdungTaiSanTheChap>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwTDUNG_TaiSanTheChap");

            entity.Property(e => e.ChuTsHoten)
                .HasMaxLength(50)
                .HasColumnName("ChuTS_Hoten");
            entity.Property(e => e.ChuTsSoCmt)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ChuTS_SoCMT");
            entity.Property(e => e.DoiTuongId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Doi_Tuong_ID");
            entity.Property(e => e.HinhThucTstcId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("HinhThucTSTC_ID");
            entity.Property(e => e.HoSoTdId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("HoSoTD_ID");
            entity.Property(e => e.KhuVucMa)
                .HasMaxLength(20)
                .HasColumnName("KhuVuc_Ma");
            entity.Property(e => e.KhuvucTen)
                .HasMaxLength(255)
                .HasColumnName("khuvuc_ten");
            entity.Property(e => e.LaiSuat).HasColumnName("Lai_Suat");
            entity.Property(e => e.LoaiVayId).HasColumnName("Loai_Vay_ID");
            entity.Property(e => e.NgayDaoHan)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ngay_dao_han");
            entity.Property(e => e.NgayHopDong)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ngay_hop_dong");
            entity.Property(e => e.NgayVay)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ngay_vay");
            entity.Property(e => e.PhuongThucVayId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PhuongThucVay_ID");
            entity.Property(e => e.SanPhamTdId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SanPhamTD_ID");
            entity.Property(e => e.SoDu).HasColumnName("So_Du");
            entity.Property(e => e.SoHopDong)
                .HasMaxLength(20)
                .HasColumnName("So_Hop_Dong");
            entity.Property(e => e.SoTienVay).HasColumnName("So_Tien_Vay");
            entity.Property(e => e.TenNguoiVay)
                .HasMaxLength(100)
                .HasColumnName("Ten_Nguoi_Vay");
            entity.Property(e => e.TkTinDung)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TK_Tin_Dung");
            entity.Property(e => e.TstcGhiChu)
                .HasMaxLength(200)
                .HasColumnName("TSTC_GhiChu");
            entity.Property(e => e.TstcGhiChuXuat)
                .HasMaxLength(200)
                .HasColumnName("TSTC_GhiChu_Xuat");
            entity.Property(e => e.TstcHdtc)
                .HasMaxLength(40)
                .HasColumnName("TSTC_HDTC");
            entity.Property(e => e.TstcId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TSTC_ID");
            entity.Property(e => e.TstcKyHieu)
                .HasMaxLength(50)
                .HasColumnName("TSTC_KyHieu");
            entity.Property(e => e.TstcMaLoai)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TSTC_Ma_Loai");
            entity.Property(e => e.TstcMaNhom)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TSTC_Ma_Nhom");
            entity.Property(e => e.TstcNgayDuyet)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("TSTC_NgayDuyet");
            entity.Property(e => e.TstcNgayXuat)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("TSTC_NgayXuat");
            entity.Property(e => e.TstcSoLuong).HasColumnName("TSTC_SoLuong");
            entity.Property(e => e.TstcTaiKhoan)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TSTC_Tai_Khoan");
            entity.Property(e => e.TstcTen)
                .HasMaxLength(250)
                .HasColumnName("TSTC_Ten");
            entity.Property(e => e.TstcTenLoai)
                .HasMaxLength(50)
                .HasColumnName("tstc_ten_loai");
            entity.Property(e => e.TstcThanhTien).HasColumnName("TSTC_ThanhTien");
            entity.Property(e => e.TstcTrangThai).HasColumnName("TSTC_TrangThai");
            entity.Property(e => e.TstcTrangThaiXuat).HasColumnName("TSTC_TrangThai_Xuat");
            entity.Property(e => e.TstcTyLeDp).HasColumnName("TSTC_TyLeDP");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
