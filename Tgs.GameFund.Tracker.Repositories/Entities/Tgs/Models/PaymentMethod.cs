using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class PaymentMethod
{
    public Guid Id { get; set; }

    public string BankType { get; set; } = null!;

    public string Code { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<PaymentMethodChannel> PaymentMethodChannels { get; set; } = new List<PaymentMethodChannel>();
}
