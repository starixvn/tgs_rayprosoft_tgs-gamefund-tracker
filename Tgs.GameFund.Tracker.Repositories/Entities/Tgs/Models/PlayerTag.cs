using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class PlayerTag
{
    public string PlayerCode { get; set; } = null!;

    public string Tag { get; set; } = null!;
}
