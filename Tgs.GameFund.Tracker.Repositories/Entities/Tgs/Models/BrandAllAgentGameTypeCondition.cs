using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class BrandAllAgentGameTypeCondition
{
    public int AllAgentGameType { get; set; }

    public short AllAgentRebateType { get; set; }

    public int Rank { get; set; }

    public Guid BrandId { get; set; }

    public decimal NetProfit { get; set; }

    public int ActiveNumber { get; set; }

    public decimal RebatePercentage { get; set; }
}
