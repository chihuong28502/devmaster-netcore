using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class Permission
{
    public int PermissionId { get; set; }

    public string? PermissionName { get; set; }

    public int PermissionParent { get; set; }

    public string? PermissionDescription { get; set; }

    public string? PermissionKey { get; set; }

    public int? Active { get; set; }

    public bool? IsControlInfor { get; set; }
}
