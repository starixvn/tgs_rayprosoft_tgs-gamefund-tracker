using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class GameProviderLanguage
{
    public Guid GameProviderId { get; set; }

    public string CultureCode { get; set; } = null!;

    public string GameProviderCultureCode { get; set; } = null!;

    public virtual Language CultureCodeNavigation { get; set; } = null!;

    public virtual GameProvider GameProvider { get; set; } = null!;
}
