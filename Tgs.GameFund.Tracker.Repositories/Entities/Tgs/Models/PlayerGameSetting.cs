using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class PlayerGameSetting
{
    public string PlayerCode { get; set; } = null!;

    public bool IsAutoTransferToGame { get; set; }

    public virtual Player PlayerCodeNavigation { get; set; } = null!;
}
