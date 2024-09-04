using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class PromotionVipLevel
{
    public Guid PromotionId { get; set; }

    public Guid VipLevelId { get; set; }

    public int Level { get; set; }

    public virtual Promotion Promotion { get; set; } = null!;

    public virtual VipLevel VipLevel { get; set; } = null!;
}
