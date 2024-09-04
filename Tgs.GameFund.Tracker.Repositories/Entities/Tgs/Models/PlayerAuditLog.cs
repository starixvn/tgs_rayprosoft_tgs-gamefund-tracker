using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class PlayerAuditLog
{
    public Guid Id { get; set; }

    public string ModuleName { get; set; } = null!;

    public string Username { get; set; } = null!;

    public string? Operation { get; set; }

    public string CreatedByUsername { get; set; } = null!;

    public DateTime CreatedOn { get; set; }
}
