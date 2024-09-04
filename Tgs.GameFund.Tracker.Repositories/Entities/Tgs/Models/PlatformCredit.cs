using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class PlatformCredit
{
    public Guid Id { get; set; }

    public Guid BrandId { get; set; }

    public decimal Credit { get; set; }

    public decimal Balance { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime UpdatedOn { get; set; }

    public string CreatedByUsername { get; set; } = null!;

    public string UpdatedByUsername { get; set; } = null!;

    public virtual Brand Brand { get; set; } = null!;

    public virtual ICollection<PlatformPayRecord> PlatformPayRecords { get; set; } = new List<PlatformPayRecord>();
}
