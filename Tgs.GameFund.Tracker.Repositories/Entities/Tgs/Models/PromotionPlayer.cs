using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class PromotionPlayer
{
    public int Id { get; set; }

    public string PlayerCode { get; set; } = null!;

    public Guid PromotionBonusId { get; set; }

    public decimal BonusAmount { get; set; }

    public DateTime? SentOn { get; set; }

    public string? SentByUsername { get; set; }

    public decimal BucketAmountByManual { get; set; }

    public virtual Player PlayerCodeNavigation { get; set; } = null!;

    public virtual PromotionBonuse PromotionBonus { get; set; } = null!;
}
