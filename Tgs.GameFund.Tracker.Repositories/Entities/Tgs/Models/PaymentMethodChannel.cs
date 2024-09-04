using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class PaymentMethodChannel
{
    public Guid Id { get; set; }

    public Guid PaymentId { get; set; }

    public Guid MethodId { get; set; }

    public Guid ChannelId { get; set; }

    public short Status { get; set; }

    public virtual ICollection<BrandPayment> BrandPayments { get; set; } = new List<BrandPayment>();

    public virtual PaymentChannel Channel { get; set; } = null!;

    public virtual PaymentMethod Method { get; set; } = null!;

    public virtual Payment Payment { get; set; } = null!;
}
