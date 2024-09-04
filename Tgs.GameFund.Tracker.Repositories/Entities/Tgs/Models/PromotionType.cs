using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class PromotionType
{
    public string Name { get; set; } = null!;

    public string? Extend { get; set; }

    public string? Translate { get; set; }
}
