using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class BrandAgentDividendCondition
{
    public int Rank { get; set; }

    public Guid BrandId { get; set; }

    public decimal NetProfit { get; set; }

    public int ActiveNumber { get; set; }

    public decimal DividendPercentage { get; set; }

    public virtual Brand Brand { get; set; } = null!;
}
