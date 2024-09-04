using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class PlayerBucketEventSource
{
    public Guid Id { get; set; }

    public Guid BucketId { get; set; }

    public decimal ChangeAmount { get; set; }

    public string ChangeSets { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string? ExternalId { get; set; }

    public string FillType { get; set; } = null!;

    public string? Remark { get; set; }
}
