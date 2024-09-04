using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class Language
{
    public string CultureCode { get; set; } = null!;

    public string LanguageCode { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string LocalizedName { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public DateTime UpdatedOn { get; set; }

    public string CreatedByUsername { get; set; } = null!;

    public string UpdatedByUsername { get; set; } = null!;

    public virtual ICollection<BrandGameProvider> BrandGameProviders { get; set; } = new List<BrandGameProvider>();

    public virtual ICollection<BrandLanguage> BrandLanguages { get; set; } = new List<BrandLanguage>();

    public virtual ICollection<GameProviderLanguage> GameProviderLanguages { get; set; } = new List<GameProviderLanguage>();

    public virtual ICollection<LocalizedString> LocalizedStrings { get; set; } = new List<LocalizedString>();

    public virtual ICollection<Licensee> Licensees { get; set; } = new List<Licensee>();

    public virtual ICollection<Reseller> Resellers { get; set; } = new List<Reseller>();
}
