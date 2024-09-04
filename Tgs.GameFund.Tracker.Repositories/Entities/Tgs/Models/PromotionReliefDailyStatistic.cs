using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class PromotionReliefDailyStatistic
{
    public Guid BrandId { get; set; }

    public string PlayerCode { get; set; } = null!;

    public Guid PromotionId { get; set; }

    public DateOnly ReportDate { get; set; }

    public string Settings { get; set; } = null!;

    public decimal TotalWinLoss { get; set; }

    public decimal Bonus { get; set; }

    public decimal BucketAmount { get; set; }

    public DateTime ReportDateTime { get; set; }
}
