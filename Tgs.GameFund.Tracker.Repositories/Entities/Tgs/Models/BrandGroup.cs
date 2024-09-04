using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class BrandGroup
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public Guid BrandId { get; set; }

    public string? Description { get; set; }

    public bool IsSports { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime UpdatedOn { get; set; }

    public string CreatedByUsername { get; set; } = null!;

    public string UpdatedByUsername { get; set; } = null!;

    public virtual Brand Brand { get; set; } = null!;

    public virtual ICollection<BrandGroupBetLimit> BrandGroupBetLimits { get; set; } = new List<BrandGroupBetLimit>();

    public virtual ICollection<BrandGame> BrandGames { get; set; } = new List<BrandGame>();
}
