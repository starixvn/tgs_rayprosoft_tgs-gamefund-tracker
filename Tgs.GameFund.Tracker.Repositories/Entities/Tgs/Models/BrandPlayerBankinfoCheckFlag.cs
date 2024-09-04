using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class BrandPlayerBankinfoCheckFlag
{
    public Guid BrandId { get; set; }

    public bool IsEnabled { get; set; }
}
