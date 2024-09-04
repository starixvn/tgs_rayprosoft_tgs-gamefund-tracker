using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class BrandMaintenance
{
    public Guid Id { get; set; }

    public TimeOnly BeginTime { get; set; }

    public Guid BrandId { get; set; }

    public string? Content { get; set; }

    public TimeOnly EndTime { get; set; }

    public virtual Brand Brand { get; set; } = null!;
}
