using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class BrandPaymentAuditLog
{
    public Guid Id { get; set; }

    public Guid BrandPaymentId { get; set; }

    public string Before { get; set; } = null!;

    public string After { get; set; } = null!;

    public string? Reason { get; set; }

    public DateTime CreatedOn { get; set; }

    public string CreatedByUsername { get; set; } = null!;

    public short Operation { get; set; }
}
