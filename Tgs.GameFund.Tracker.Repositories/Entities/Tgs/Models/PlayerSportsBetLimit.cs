using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class PlayerSportsBetLimit
{
    public string PlayerCode { get; set; } = null!;

    public Guid SportMarketTypeId { get; set; }

    public int MinBet { get; set; }

    public int MaxBet { get; set; }

    public int MaxBetPerMatch { get; set; }

    public virtual Player PlayerCodeNavigation { get; set; } = null!;

    public virtual SportMarketType SportMarketType { get; set; } = null!;
}
