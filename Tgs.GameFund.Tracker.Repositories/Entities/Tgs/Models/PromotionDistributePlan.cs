using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class PromotionDistributePlan
{
    public Guid Id { get; set; }

    public Guid BrandId { get; set; }

    public long ConditionHash { get; set; }

    public string? Detail { get; set; }

    public Guid PromotionId { get; set; }
}
