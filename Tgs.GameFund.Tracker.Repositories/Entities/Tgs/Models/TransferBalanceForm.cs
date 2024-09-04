using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class TransferBalanceForm
{
    public Guid Id { get; set; }

    public decimal Amount { get; set; }

    public Guid BrandId { get; set; }

    public DateTime CreatedOn { get; set; }

    public string Drawee { get; set; } = null!;

    public string DraweeType { get; set; } = null!;

    public string Payee { get; set; } = null!;

    public string PayeeType { get; set; } = null!;

    public bool IncludeInNetProfit { get; set; }

    public string CreatedUserId { get; set; } = null!;

    public virtual Brand Brand { get; set; } = null!;
}
