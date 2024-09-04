using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class DepositAccumulateRouletteGameEvent
{
    public Guid Id { get; set; }

    public decimal Bonus { get; set; }

    public Guid BrandId { get; set; }

    public DateTime CreatedOn { get; set; }

    public int ItemIndex { get; set; }

    public string PlayerCode { get; set; } = null!;

    public Guid PromotionId { get; set; }

    public DateOnly Date { get; set; }

    public decimal Bucket { get; set; }

    public int RouletteCount { get; set; }

    public virtual Brand Brand { get; set; } = null!;

    public virtual Player PlayerCodeNavigation { get; set; } = null!;

    public virtual Promotion Promotion { get; set; } = null!;
}
