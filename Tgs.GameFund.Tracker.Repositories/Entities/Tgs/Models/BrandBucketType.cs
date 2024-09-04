using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class BrandBucketType
{
    public Guid BrandId { get; set; }

    public string BucketTypes { get; set; } = null!;

    public virtual Brand Brand { get; set; } = null!;
}
