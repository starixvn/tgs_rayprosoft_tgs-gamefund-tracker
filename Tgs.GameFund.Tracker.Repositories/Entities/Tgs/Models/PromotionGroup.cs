using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class PromotionGroup
{
    public string Name { get; set; } = null!;

    public string? Translate { get; set; }
}
