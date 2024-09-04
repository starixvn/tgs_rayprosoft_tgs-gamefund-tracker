using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class BrandSm
{
    public Guid BrandId { get; set; }

    public Guid SmsSettingId { get; set; }
}
