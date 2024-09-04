using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class PlayerIdentity
{
    public string PlayerCode { get; set; } = null!;

    public Guid PlayerAuthenticationFormId { get; set; }

    public virtual Player PlayerCodeNavigation { get; set; } = null!;
}
