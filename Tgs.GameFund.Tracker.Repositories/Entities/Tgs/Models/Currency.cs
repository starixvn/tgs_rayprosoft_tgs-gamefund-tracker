using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class Currency
{
    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? NativeName { get; set; }

    public string? Symbol { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime UpdatedOn { get; set; }

    public string CreatedByUsername { get; set; } = null!;

    public string UpdatedByUsername { get; set; } = null!;

    public virtual ICollection<AgentWallet> AgentWallets { get; set; } = new List<AgentWallet>();

    public virtual ICollection<BetLimit> BetLimits { get; set; } = new List<BetLimit>();

    public virtual ICollection<BrandCurrency> BrandCurrencies { get; set; } = new List<BrandCurrency>();

    public virtual ICollection<GameProviderBetLimit> GameProviderBetLimits { get; set; } = new List<GameProviderBetLimit>();

    public virtual ICollection<GameProviderCurrency> GameProviderCurrencies { get; set; } = new List<GameProviderCurrency>();

    public virtual ICollection<Wallet> Wallets { get; set; } = new List<Wallet>();

    public virtual ICollection<Licensee> Licensees { get; set; } = new List<Licensee>();

    public virtual ICollection<Reseller> Resellers { get; set; } = new List<Reseller>();
}
