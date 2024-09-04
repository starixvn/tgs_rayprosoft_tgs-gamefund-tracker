using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class AgentDividendSnapshot
{
    public Guid Id { get; set; }

    public string Data { get; set; } = null!;

    public DateTime CreatedOn { get; set; }
}
