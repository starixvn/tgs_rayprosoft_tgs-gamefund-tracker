using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class BrandBetLimit
{
    public Guid BrandId { get; set; }

    public int BetLimitId { get; set; }

    public bool IsDefault { get; set; }

    public virtual BetLimit BetLimit { get; set; } = null!;

    public virtual Brand Brand { get; set; } = null!;
}
