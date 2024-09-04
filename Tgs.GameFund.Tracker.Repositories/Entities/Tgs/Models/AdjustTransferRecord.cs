using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class AdjustTransferRecord
{
    public Guid Id { get; set; }

    public Guid TransactionFromId { get; set; }

    public Guid TransactionToId { get; set; }

    public short TransferType { get; set; }

    public string TransferFromUsername { get; set; } = null!;

    public string TransferToUsername { get; set; } = null!;

    public decimal Amount { get; set; }

    public DateTime CreatedOn { get; set; }
}
