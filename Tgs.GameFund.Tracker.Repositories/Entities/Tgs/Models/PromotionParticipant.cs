using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class PromotionParticipant
{
    public Guid PromotionId { get; set; }

    public string? PlayerCode { get; set; }

    public int Id { get; set; }

    public DateTime CreatedOn { get; set; }

    public virtual Player? PlayerCodeNavigation { get; set; }

    public virtual Promotion Promotion { get; set; } = null!;
}
