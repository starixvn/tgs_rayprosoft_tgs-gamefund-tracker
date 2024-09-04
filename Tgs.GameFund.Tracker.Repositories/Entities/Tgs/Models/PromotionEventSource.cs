using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class PromotionEventSource
{
    public Guid Id { get; set; }

    public string Action { get; set; } = null!;

    public string ChangeSets { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public Guid PromotionId { get; set; }

    public string? ModifyUser { get; set; }
}
