using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class CalculateChangeLog
{
    public Guid Id { get; set; }

    public Guid CalculateId { get; set; }

    public decimal Change { get; set; }

    public decimal Balance { get; set; }

    public DateTime RecordedOn { get; set; }

    public bool Deleted { get; set; }
}
