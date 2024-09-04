using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class BrandGameProviderAggregateAuditLog
{
    public int Id { get; set; }

    public Guid? BrandId { get; set; }

    public Guid CreatedByUserId { get; set; }

    public DateTime CreatedOn { get; set; }
}
