using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class AgentClearCommissionRecord
{
    public Guid Id { get; set; }

    public int AgentDividendId { get; set; }

    public decimal CommissionAmount { get; set; }

    public Guid ClearByUserId { get; set; }

    public DateTime CreatedOn { get; set; }
}
