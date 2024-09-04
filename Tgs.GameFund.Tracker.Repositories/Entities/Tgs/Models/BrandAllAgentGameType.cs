using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class BrandAllAgentGameType
{
    public Guid BrandId { get; set; }

    public short AllAgentGameType { get; set; }

    public bool Switch { get; set; }

    public bool HasValidBet { get; set; }

    public bool HasWinLoss { get; set; }
}
