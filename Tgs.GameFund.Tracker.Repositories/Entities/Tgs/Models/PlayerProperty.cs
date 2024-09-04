using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class PlayerProperty
{
    public Guid BrandId { get; set; }

    public string Name { get; set; } = null!;

    public string PlayerCode { get; set; } = null!;

    public string Value { get; set; } = null!;

    public virtual Brand Brand { get; set; } = null!;

    public virtual Player PlayerCodeNavigation { get; set; } = null!;
}
