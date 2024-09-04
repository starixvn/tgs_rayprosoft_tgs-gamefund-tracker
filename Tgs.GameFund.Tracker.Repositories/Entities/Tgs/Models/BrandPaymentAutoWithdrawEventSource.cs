using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class BrandPaymentAutoWithdrawEventSource
{
    public Guid Id { get; set; }

    public Guid BrandId { get; set; }

    public string ChangeSets { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifyUser { get; set; } = null!;
}
