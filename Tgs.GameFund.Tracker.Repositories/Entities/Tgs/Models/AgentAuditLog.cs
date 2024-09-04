using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class AgentAuditLog
{
    public Guid Id { get; set; }

    public Guid AgentId { get; set; }

    public short Operation { get; set; }

    public string CreatedByUsername { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public virtual Agent Agent { get; set; } = null!;
}
