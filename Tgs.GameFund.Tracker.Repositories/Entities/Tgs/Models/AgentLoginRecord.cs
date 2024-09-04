using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class AgentLoginRecord
{
    public Guid Id { get; set; }

    public Guid AgentId { get; set; }

    public Guid BrandId { get; set; }

    public short Status { get; set; }

    public string? IpAddress { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime ExpiredOn { get; set; }

    public virtual Agent Agent { get; set; } = null!;

    public virtual Brand Brand { get; set; } = null!;
}
