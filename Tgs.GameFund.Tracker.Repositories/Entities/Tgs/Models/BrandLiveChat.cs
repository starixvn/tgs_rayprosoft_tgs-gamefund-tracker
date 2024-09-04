using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class BrandLiveChat
{
    public Guid BrandId { get; set; }

    public string? ChatName { get; set; }

    public string? ChatSetting { get; set; }

    public virtual Brand Brand { get; set; } = null!;
}
