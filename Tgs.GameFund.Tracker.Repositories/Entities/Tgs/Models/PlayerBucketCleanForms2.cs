using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class PlayerBucketCleanForms2
{
    public Guid Id { get; set; }

    public Guid BrandId { get; set; }

    public decimal? CleaningBalance { get; set; }

    public string? CleaningBucketAmounts { get; set; }

    public decimal ClearWageringRequirementBalance { get; set; }

    public DateTime CreatedOn { get; set; }

    public decimal CurrentBalance { get; set; }

    public string CurrentBucketAmounts { get; set; } = null!;

    public Guid DepositFormId { get; set; }

    public string? GameBalanceReturn { get; set; }

    public string PlayerCode { get; set; } = null!;

    public Guid SnapshotId { get; set; }

    public string Status { get; set; } = null!;

    public Guid WalletId { get; set; }

    public virtual Brand Brand { get; set; } = null!;

    public virtual Player PlayerCodeNavigation { get; set; } = null!;
}
