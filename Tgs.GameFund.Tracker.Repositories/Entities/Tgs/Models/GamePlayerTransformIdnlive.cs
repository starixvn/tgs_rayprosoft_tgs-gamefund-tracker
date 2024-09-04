using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class GamePlayerTransformIdnlive
{
    public int Id { get; set; }

    public string PlayerCode { get; set; } = null!;

    public string Configuration { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public DateTime UpdatedOn { get; set; }

    public virtual Player PlayerCodeNavigation { get; set; } = null!;
}
