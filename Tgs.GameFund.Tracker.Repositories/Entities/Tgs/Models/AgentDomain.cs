using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class AgentDomain
{
    public Guid AgentId { get; set; }

    public string DomainName { get; set; } = null!;

    public virtual Agent Agent { get; set; } = null!;
}
