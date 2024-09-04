using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class PlayerBankInfoEventSource
{
    public Guid Id { get; set; }

    public Guid BankInfoId { get; set; }

    public string ChangeAction { get; set; } = null!;

    public string ChangeSets { get; set; } = null!;

    public string? Modifier { get; set; }

    public DateTime ModifiedOn { get; set; }
}
