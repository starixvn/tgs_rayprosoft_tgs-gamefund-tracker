using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class PromotionPromoteDepositChannel
{
    public Guid Id { get; set; }

    public decimal Bonus { get; set; }

    public decimal BucketAmount { get; set; }

    public DateTime CreatedOn { get; set; }

    public Guid DistributePlanId { get; set; }

    public Guid FormId { get; set; }

    public string PlayerCode { get; set; } = null!;

    public Guid PromotionId { get; set; }

    public int VipLevel { get; set; }
}
