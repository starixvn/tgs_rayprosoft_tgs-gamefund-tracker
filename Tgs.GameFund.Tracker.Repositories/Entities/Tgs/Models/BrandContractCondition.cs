using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class BrandContractCondition
{
    public Guid BrandContractId { get; set; }

    public int Rank { get; set; }

    public int ActiveNumber { get; set; }

    public decimal DividendPercentage { get; set; }

    public decimal NetProfit { get; set; }

    public decimal WinLossAmount { get; set; }

    public virtual BrandContract BrandContract { get; set; } = null!;
}
