using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class BrandGroupBetLimit
{
    public Guid Id { get; set; }

    public int BetLimitId { get; set; }

    public Guid BrandGroupId { get; set; }

    public virtual BetLimit BetLimit { get; set; } = null!;

    public virtual BrandGroup BrandGroup { get; set; } = null!;

    public virtual ICollection<GameProviderBetLimit> GameProviderBetLimits { get; set; } = new List<GameProviderBetLimit>();
}
