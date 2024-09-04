using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class BrandDomain
{
    public Guid Id { get; set; }

    public string Url { get; set; } = null!;

    public Guid BrandId { get; set; }

    public virtual Brand Brand { get; set; } = null!;
}
