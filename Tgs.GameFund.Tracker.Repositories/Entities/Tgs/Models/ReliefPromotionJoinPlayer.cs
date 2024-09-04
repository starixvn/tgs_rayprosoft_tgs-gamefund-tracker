using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class ReliefPromotionJoinPlayer
{
    public string PlayerCode { get; set; } = null!;

    public Guid PromotionId { get; set; }

    public DateTime CreatedOn { get; set; }

    public virtual Player PlayerCodeNavigation { get; set; } = null!;

    public virtual Promotion Promotion { get; set; } = null!;
}
