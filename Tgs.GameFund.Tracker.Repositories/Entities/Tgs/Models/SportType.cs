using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class SportType
{
    public Guid Id { get; set; }

    public Guid GameProviderId { get; set; }

    public string Code { get; set; } = null!;

    public string ExternalId { get; set; } = null!;

    public virtual GameProvider GameProvider { get; set; } = null!;

    public virtual ICollection<SportMarketType> SportMarketTypes { get; set; } = new List<SportMarketType>();
}
