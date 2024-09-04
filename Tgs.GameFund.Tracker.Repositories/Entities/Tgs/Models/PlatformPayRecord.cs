using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class PlatformPayRecord
{
    public int Id { get; set; }

    public Guid PlatformCreditId { get; set; }

    public decimal PayAmount { get; set; }

    public decimal Balance { get; set; }

    public string CreatedByUsername { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public virtual PlatformCredit PlatformCredit { get; set; } = null!;
}
