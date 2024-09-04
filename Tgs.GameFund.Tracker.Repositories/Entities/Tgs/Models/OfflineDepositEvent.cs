using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class OfflineDepositEvent
{
    public Guid Id { get; set; }

    public decimal BonusAmount { get; set; }

    public Guid BrandId { get; set; }

    public decimal BucketAmount { get; set; }

    public DateTime CreatedOn { get; set; }

    public Guid DepositFormId { get; set; }

    public string PlayerCode { get; set; } = null!;

    public Guid PromotionId { get; set; }

    public string Settings { get; set; } = null!;
}
