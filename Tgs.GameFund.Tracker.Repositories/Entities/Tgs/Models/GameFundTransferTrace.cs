using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class GameFundTransferTrace
{
    public Guid GameProviderId { get; set; }

    public Guid WalletId { get; set; }

    public string PlayerCode { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public DateTime UpdatedOn { get; set; }
}
