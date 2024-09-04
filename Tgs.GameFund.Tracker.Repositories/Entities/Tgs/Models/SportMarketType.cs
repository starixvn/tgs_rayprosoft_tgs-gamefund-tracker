using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class SportMarketType
{
    public Guid Id { get; set; }

    public Guid SportTypeId { get; set; }

    public Guid MarketTypeId { get; set; }

    public virtual MarketType MarketType { get; set; } = null!;

    public virtual ICollection<PlayerSportsBetLimit> PlayerSportsBetLimits { get; set; } = new List<PlayerSportsBetLimit>();

    public virtual SportType SportType { get; set; } = null!;
}
