using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class BrandCurrency
{
    public Guid BrandId { get; set; }

    public string CurrencyCode { get; set; } = null!;

    public string BrandCurrencyCode { get; set; } = null!;

    public virtual Brand Brand { get; set; } = null!;

    public virtual Currency CurrencyCodeNavigation { get; set; } = null!;
}
