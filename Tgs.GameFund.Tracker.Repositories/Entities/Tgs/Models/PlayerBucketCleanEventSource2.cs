using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class PlayerBucketCleanEventSource2
{
    public Guid Id { get; set; }

    public string ChangeSets { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public Guid FormId { get; set; }
}
