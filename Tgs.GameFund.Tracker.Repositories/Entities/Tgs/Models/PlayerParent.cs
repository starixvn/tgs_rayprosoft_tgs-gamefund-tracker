using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class PlayerParent
{
    public string PlayerCode { get; set; } = null!;

    public string ParentPlayerCode { get; set; } = null!;
}
