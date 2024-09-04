using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class System
{
    public string Name { get; set; } = null!;

    public virtual ICollection<FunctionEventSource> FunctionEventSources { get; set; } = new List<FunctionEventSource>();

    public virtual ICollection<Function> Functions { get; set; } = new List<Function>();

    public virtual ICollection<GroupUser> GroupUsers { get; set; } = new List<GroupUser>();

    public virtual ICollection<Group> Groups { get; set; } = new List<Group>();

    public virtual ICollection<Permission> Permissions { get; set; } = new List<Permission>();
}
