using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class BrandGameProviderSchedule
{
    public Guid Id { get; set; }

    public Guid BrandGameProviderId { get; set; }

    public DateTime From { get; set; }

    public DateTime To { get; set; }

    public short Status { get; set; }

    public int? DayOfWeek { get; set; }

    public bool IsDefault { get; set; }

    public virtual BrandGameProvider BrandGameProvider { get; set; } = null!;
}
