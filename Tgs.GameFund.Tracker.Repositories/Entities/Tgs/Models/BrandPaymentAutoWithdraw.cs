using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class BrandPaymentAutoWithdraw
{
    public Guid BrandId { get; set; }

    public decimal AmountUpperLimit { get; set; }

    public string BrandPaymentCandidates { get; set; } = null!;

    public bool EnableAutoWithdraw { get; set; }

    public Guid SnapshotEventId { get; set; }
}
