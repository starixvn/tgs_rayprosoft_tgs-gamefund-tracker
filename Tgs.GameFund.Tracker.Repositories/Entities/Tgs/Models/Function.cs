using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class Function
{
    public Guid Id { get; set; }

    public DateTime CreatedOn { get; set; }

    public string Features { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string System { get; set; } = null!;

    public string Type { get; set; } = null!;

    public DateTime UpdatedOn { get; set; }

    public Guid SnapshotId { get; set; }

    public virtual ICollection<FunctionEventSource> FunctionEventSources { get; set; } = new List<FunctionEventSource>();

    public virtual ICollection<Permission> Permissions { get; set; } = new List<Permission>();

    public virtual System SystemNavigation { get; set; } = null!;
}
