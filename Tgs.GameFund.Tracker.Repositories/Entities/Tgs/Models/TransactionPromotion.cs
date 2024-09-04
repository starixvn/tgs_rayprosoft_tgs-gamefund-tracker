using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class TransactionPromotion
{
    public Guid TransactionId { get; set; }

    public Guid PromotionId { get; set; }

    public Guid PromotionBonusId { get; set; }

    public string? PromotionType { get; set; }

    public virtual Promotion Promotion { get; set; } = null!;
}
