using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class ImagesStore
{
    public int ImageId { get; set; }

    public string KhachHangId { get; set; } = null!;

    public string OriginalPath { get; set; } = null!;

    public byte[] ImageData { get; set; } = null!;

    public int ImageType { get; set; }
}
