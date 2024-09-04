using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class BrandPaymentPlayer
{
    public string PlayerCode { get; set; } = null!;

    public Guid BrandPaymentId { get; set; }

    public short ListType { get; set; }

    public virtual BrandPayment BrandPayment { get; set; } = null!;

    public virtual Player PlayerCodeNavigation { get; set; } = null!;
}
