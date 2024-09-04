using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class Reseller
{
    public Guid Id { get; set; }

    public short Status { get; set; }

    public string? Description { get; set; }

    public string? OperationalEmail { get; set; }

    public short BusinessType { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public DateTime UpdatedOn { get; set; }

    public string CreatedByUsername { get; set; } = null!;

    public string UpdatedByUsername { get; set; } = null!;

    public virtual ICollection<Department> Departments { get; set; } = new List<Department>();

    public virtual ICollection<Licensee> Licensees { get; set; } = new List<Licensee>();

    public virtual ICollection<Whitelist> Whitelists { get; set; } = new List<Whitelist>();

    public virtual ICollection<BetLimit> BetLimits { get; set; } = new List<BetLimit>();

    public virtual ICollection<Language> CultureCodes { get; set; } = new List<Language>();

    public virtual ICollection<Currency> CurrencyCodes { get; set; } = new List<Currency>();

    public virtual ICollection<GameProvider> GameProviders { get; set; } = new List<GameProvider>();
}
