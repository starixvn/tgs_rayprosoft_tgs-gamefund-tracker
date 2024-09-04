using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class DepositPromotionStatistic
{
    public Guid PromotionId { get; set; }

    public string PlayerCode { get; set; } = null!;

    public DateTime ProcessedDate { get; set; }

    public int TotalDepositCount { get; set; }
}
