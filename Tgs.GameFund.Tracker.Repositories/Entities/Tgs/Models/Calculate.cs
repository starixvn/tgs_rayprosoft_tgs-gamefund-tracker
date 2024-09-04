using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class Calculate
{
    public Guid Id { get; set; }

    public decimal Balance { get; set; }

    public Guid SnapshotId { get; set; }

    public bool Deleted { get; set; }
}
