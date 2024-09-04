using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class GameProviderBetLimit
{
    public Guid Id { get; set; }

    public Guid GameProviderId { get; set; }

    public string? CurrencyCode { get; set; }

    public int MinBet { get; set; }

    public int MaxBet { get; set; }

    public int? MaxBetPerMatch { get; set; }

    public string ExternalSetting { get; set; } = null!;

    public virtual Currency? CurrencyCodeNavigation { get; set; }

    public virtual GameProvider GameProvider { get; set; } = null!;

    public virtual ICollection<BrandGroupBetLimit> BrandGroupBetLimits { get; set; } = new List<BrandGroupBetLimit>();
}
