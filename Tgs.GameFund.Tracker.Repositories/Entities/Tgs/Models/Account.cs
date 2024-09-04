using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class Account
{
    public Guid Id { get; set; }

    public string Algorithm { get; set; } = null!;

    public Guid BrandId { get; set; }

    public DateTime CreatedOn { get; set; }

    public string PasswordHash { get; set; } = null!;

    public string System { get; set; } = null!;

    public DateTime UpdatedOn { get; set; }

    public string UserName { get; set; } = null!;

    public Guid SnapshotId { get; set; }
}
