using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class BrandAllAgentSetting
{
    public Guid BrandId { get; set; }

    public bool Switch { get; set; }

    public short? SettlementIntervalType { get; set; }
}
