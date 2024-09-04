using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class AccountEventSource
{
    public Guid Id { get; set; }

    public Guid AccountId { get; set; }

    public string ChangeSets { get; set; } = null!;

    public DateTime CreatedOn { get; set; }
}
