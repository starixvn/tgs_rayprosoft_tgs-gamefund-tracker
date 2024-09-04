using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class AgentBank
{
    public Guid Id { get; set; }

    public string RealName { get; set; } = null!;

    public string BankName { get; set; } = null!;

    public string BankAccount { get; set; } = null!;

    public Guid AgentId { get; set; }

    public string? CreatedByUsername { get; set; }

    public string? UpdatedByUsername { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime UpdatedOn { get; set; }

    public virtual Agent Agent { get; set; } = null!;
}
