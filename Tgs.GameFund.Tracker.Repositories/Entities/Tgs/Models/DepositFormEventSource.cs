using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class DepositFormEventSource
{
    public Guid Id { get; set; }

    public string Action { get; set; } = null!;

    public string ChangeSets { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string? ModifyUser { get; set; }

    public Guid FormId { get; set; }
}
