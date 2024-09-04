using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class GameProvider
{
    public Guid Id { get; set; }

    public short Status { get; set; }

    public string? Description { get; set; }

    public bool AutoCloseRound { get; set; }

    public bool SupportTestPlayer { get; set; }

    public bool AllowKickPlayer { get; set; }

    public short PlaceBetTimeout { get; set; }

    public short SettleBetTimeout { get; set; }

    public int UniqueId { get; set; }

    public bool TransferWallet { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public DateTime UpdatedOn { get; set; }

    public string CreatedByUsername { get; set; } = null!;

    public string UpdatedByUsername { get; set; } = null!;

    public string? Localization { get; set; }

    public virtual ICollection<BrandGameProvider> BrandGameProviders { get; set; } = new List<BrandGameProvider>();

    public virtual ICollection<GameProviderBetLimit> GameProviderBetLimits { get; set; } = new List<GameProviderBetLimit>();

    public virtual ICollection<GameProviderConfiguration> GameProviderConfigurations { get; set; } = new List<GameProviderConfiguration>();

    public virtual ICollection<GameProviderCurrency> GameProviderCurrencies { get; set; } = new List<GameProviderCurrency>();

    public virtual ICollection<GameProviderLanguage> GameProviderLanguages { get; set; } = new List<GameProviderLanguage>();

    public virtual ICollection<Game> Games { get; set; } = new List<Game>();

    public virtual ICollection<MarketType> MarketTypes { get; set; } = new List<MarketType>();

    public virtual ICollection<SportType> SportTypes { get; set; } = new List<SportType>();

    public virtual ICollection<SubGameProvider> SubGameProviders { get; set; } = new List<SubGameProvider>();

    public virtual ICollection<Licensee> Licensees { get; set; } = new List<Licensee>();

    public virtual ICollection<Promotion> Promotions { get; set; } = new List<Promotion>();

    public virtual ICollection<Reseller> Resellers { get; set; } = new List<Reseller>();
}
