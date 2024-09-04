using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class TransactionsMgmBackup
{
    public Guid? Id { get; set; }

    public string? PlayerCode { get; set; }

    public Guid? WalletId { get; set; }

    public Guid? BrandId { get; set; }

    public string? ExternalTransactionId { get; set; }

    public decimal? Amount { get; set; }

    public decimal? Balance { get; set; }

    public string? Description { get; set; }

    public short? Type { get; set; }

    public DateTime? RecordedOn { get; set; }

    public DateTime? SentOn { get; set; }

    public Guid? CreatedByUserId { get; set; }
}
