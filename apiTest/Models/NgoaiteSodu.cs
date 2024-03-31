using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class NgoaiteSodu
{
    public string MaTk { get; set; } = null!;

    public DateTime Ngay { get; set; }

    public double? NoDauKy { get; set; }

    public double? CoDauKy { get; set; }

    public double? NoTrongKy { get; set; }

    public double? CoTrongKy { get; set; }

    public double? NoCuoiKy { get; set; }

    public double? CoCuoiKy { get; set; }

    public double NoDauNam { get; set; }

    public double CoDauNam { get; set; }

    public double NoLuyKe { get; set; }

    public double CoLuyKe { get; set; }

    public string UsersNew { get; set; } = null!;

    public DateTime? DateNew { get; set; }

    public string UsersModify { get; set; } = null!;

    public DateTime? DateModify { get; set; }

    public string ChinhanhId { get; set; } = null!;
}
