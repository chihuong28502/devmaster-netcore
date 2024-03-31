using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class TkiemHinhthuctralai
{
    public string HttlMa { get; set; } = null!;

    public string? HttlTen { get; set; }

    public string? HttlMoTa { get; set; }

    public virtual ICollection<TkiemSotietkiem> TkiemSotietkiems { get; set; } = new List<TkiemSotietkiem>();
}
