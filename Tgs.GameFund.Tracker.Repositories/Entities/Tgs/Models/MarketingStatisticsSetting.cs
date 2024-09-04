using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class MarketingStatisticsSetting
{
    public string RecordKey { get; set; } = null!;

    public DateTime ProcessedTime { get; set; }
}
