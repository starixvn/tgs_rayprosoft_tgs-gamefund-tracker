using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class GameProviderCurrency
{
    public Guid GameProviderId { get; set; }

    public string CurrencyCode { get; set; } = null!;

    public string GameProviderCurrencyCode { get; set; } = null!;

    public virtual Currency CurrencyCodeNavigation { get; set; } = null!;

    public virtual GameProvider GameProvider { get; set; } = null!;
}
