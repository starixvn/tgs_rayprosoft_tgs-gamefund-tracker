using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class BetLimit
{
    public int Id { get; set; }

    public string CurrencyCode { get; set; } = null!;

    public int MinBet { get; set; }

    public int MaxBet { get; set; }

    public int MaxBetPerMatch { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime UpdatedOn { get; set; }

    public string CreatedByUsername { get; set; } = null!;

    public string UpdatedByUsername { get; set; } = null!;

    public virtual ICollection<BrandBetLimit> BrandBetLimits { get; set; } = new List<BrandBetLimit>();

    public virtual ICollection<BrandGroupBetLimit> BrandGroupBetLimits { get; set; } = new List<BrandGroupBetLimit>();

    public virtual Currency CurrencyCodeNavigation { get; set; } = null!;

    public virtual ICollection<Player> Players { get; set; } = new List<Player>();

    public virtual ICollection<Licensee> Licensees { get; set; } = new List<Licensee>();

    public virtual ICollection<Reseller> Resellers { get; set; } = new List<Reseller>();
}
