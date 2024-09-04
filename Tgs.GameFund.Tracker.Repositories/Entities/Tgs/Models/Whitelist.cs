using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class Whitelist
{
    public Guid Id { get; set; }

    public Guid? ResellerId { get; set; }

    public Guid? LicenseeId { get; set; }

    public Guid? BrandId { get; set; }

    public string IpAddress { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string InternalNote { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public DateTime UpdatedOn { get; set; }

    public string CreatedByUsername { get; set; } = null!;

    public string UpdatedByUsername { get; set; } = null!;

    public short Type { get; set; }

    public virtual Brand? Brand { get; set; }

    public virtual Licensee? Licensee { get; set; }

    public virtual Reseller? Reseller { get; set; }
}
