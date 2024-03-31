using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class UsersPermission
{
    public int UserId { get; set; }

    public int PermissionId { get; set; }

    public string? PermissionKey { get; set; }

    public virtual User User { get; set; } = null!;
}
