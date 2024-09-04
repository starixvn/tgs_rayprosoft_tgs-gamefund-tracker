using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class Group
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public string System { get; set; } = null!;

    public virtual ICollection<GroupUser> GroupUsers { get; set; } = new List<GroupUser>();

    public virtual System SystemNavigation { get; set; } = null!;
}
