using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class AgentDailyMarketingStatistic
{
    public Guid AgentId { get; set; }

    public Guid BrandId { get; set; }

    public DateOnly ReportDate { get; set; }

    public int GamingCount { get; set; }

    public int RegisterCount { get; set; }
}
