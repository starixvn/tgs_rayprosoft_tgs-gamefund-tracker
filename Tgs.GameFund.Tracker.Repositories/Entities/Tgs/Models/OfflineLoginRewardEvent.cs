using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class OfflineLoginRewardEvent
{
    public Guid Id { get; set; }

    public decimal Bonus { get; set; }

    public Guid BrandId { get; set; }

    public decimal Bucket { get; set; }

    public DateTime CreatedOn { get; set; }

    public string PlayerCode { get; set; } = null!;

    public Guid PromotionId { get; set; }

    public DateTime LoggedOn { get; set; }

    public virtual Brand Brand { get; set; } = null!;

    public virtual Player PlayerCodeNavigation { get; set; } = null!;

    public virtual Promotion Promotion { get; set; } = null!;
}
