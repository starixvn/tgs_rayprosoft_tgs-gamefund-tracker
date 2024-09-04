using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class BrandGame
{
    public Guid Id { get; set; }

    public int GameId { get; set; }

    public Guid BrandId { get; set; }

    public short Status { get; set; }

    public short Tag { get; set; }

    public int DisplayOrder { get; set; }

    public bool Rebate { get; set; }

    public decimal EffectiveBettingPercentage { get; set; }

    public virtual Brand Brand { get; set; } = null!;

    public virtual Game Game { get; set; } = null!;

    public virtual ICollection<BrandGroup> BrandGroups { get; set; } = new List<BrandGroup>();
}
