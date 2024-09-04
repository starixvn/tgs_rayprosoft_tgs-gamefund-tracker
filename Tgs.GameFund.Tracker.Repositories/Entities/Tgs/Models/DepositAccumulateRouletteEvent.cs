using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class DepositAccumulateRouletteEvent
{
    public Guid BrandId { get; set; }

    public DateOnly Date { get; set; }

    public string PlayerCode { get; set; } = null!;

    public Guid PromotionId { get; set; }

    public int RouletteCount { get; set; }

    public decimal TotalDepositAmount { get; set; }

    public virtual Brand Brand { get; set; } = null!;

    public virtual Player PlayerCodeNavigation { get; set; } = null!;

    public virtual Promotion Promotion { get; set; } = null!;
}
