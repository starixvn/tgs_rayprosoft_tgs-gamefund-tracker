using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class DepositPromotionCalculatePair
{
    public Guid PromotionId { get; set; }

    public Guid CalculateId { get; set; }
}
