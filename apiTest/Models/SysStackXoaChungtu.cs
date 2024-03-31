using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class SysStackXoaChungtu
{
    public int Stack { get; set; }

    /// <summary>
    /// ID của chứng từ tương ứng trường chung_tu ở bảng Sys_So_Chung_Tu_ID
    /// </summary>
    public string? ChungtuId { get; set; }

    /// <summary>
    /// Là số chứng từ được xóa
    /// </summary>
    public string? Sochungtu { get; set; }

    /// <summary>
    /// Nội dung của chứng từ được xóa
    /// </summary>
    public string? Noidung { get; set; }

    public string? UsersName { get; set; }

    public DateTime? DateModify { get; set; }
}
