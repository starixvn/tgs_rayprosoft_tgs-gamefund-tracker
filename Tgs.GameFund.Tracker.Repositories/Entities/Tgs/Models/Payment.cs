using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class Payment
{
    public Guid Id { get; set; }

    public string? Description { get; set; }

    public string? ExtendData { get; set; }

    public short Status { get; set; }

    public string Code { get; set; } = null!;

    public string? Name { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime UpdatedOn { get; set; }

    public string CreatedByUsername { get; set; } = null!;

    public string UpdatedByUsername { get; set; } = null!;

    public virtual ICollection<PaymentMethodChannel> PaymentMethodChannels { get; set; } = new List<PaymentMethodChannel>();
}
