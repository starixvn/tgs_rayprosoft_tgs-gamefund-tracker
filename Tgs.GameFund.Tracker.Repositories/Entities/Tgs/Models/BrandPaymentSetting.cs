using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class BrandPaymentSetting
{
    public Guid BrandId { get; set; }

    public int? PlayerBankInfoCountLimit { get; set; }

    public virtual Brand Brand { get; set; } = null!;
}
