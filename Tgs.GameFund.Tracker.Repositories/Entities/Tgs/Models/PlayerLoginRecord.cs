using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class PlayerLoginRecord
{
    public Guid Id { get; set; }

    public string PlayerCode { get; set; } = null!;

    public Guid BrandId { get; set; }

    public short Status { get; set; }

    public short PlatformType { get; set; }

    public string? IpAddress { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime ExpiredOn { get; set; }

    public virtual Brand Brand { get; set; } = null!;

    public virtual Player PlayerCodeNavigation { get; set; } = null!;
}
