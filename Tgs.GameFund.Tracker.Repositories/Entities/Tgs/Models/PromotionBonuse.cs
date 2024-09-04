using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class PromotionBonuse
{
    public Guid Id { get; set; }

    public Guid BrandId { get; set; }

    public Guid PromotionId { get; set; }

    public DateTime From { get; set; }

    public DateTime To { get; set; }

    public string PromotionType { get; set; } = null!;

    public decimal TotalAmountLimit { get; set; }

    public short? GameType { get; set; }

    public decimal Percentage { get; set; }

    public decimal BonusAmountLimit { get; set; }

    public decimal TurnoverMultiple { get; set; }

    public DateTime CreatedOn { get; set; }

    public string? Detail { get; set; }

    public virtual Promotion Promotion { get; set; } = null!;

    public virtual ICollection<PromotionPlayer> PromotionPlayers { get; set; } = new List<PromotionPlayer>();
}
