using System;
using System.Collections.Generic;

namespace apiTest.Models;

public partial class User
{
    public int UserId { get; set; }

    public string UserName { get; set; } = null!;

    public string? Password { get; set; }

    public string FullName { get; set; } = null!;

    public int GroupId { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string Description { get; set; } = null!;

    public string ChiNhanhId { get; set; } = null!;

    public bool? IsActivated { get; set; }

    public string? TaiKhoan { get; set; }

    public virtual ICollection<UsersPermission> UsersPermissions { get; set; } = new List<UsersPermission>();
}
