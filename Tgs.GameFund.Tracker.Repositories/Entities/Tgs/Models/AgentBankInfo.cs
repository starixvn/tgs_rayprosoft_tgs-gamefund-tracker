using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class AgentBankInfo
{
    public Guid Id { get; set; }

    public Guid AgentId { get; set; }

    public string BankType { get; set; } = null!;

    public Guid BrandId { get; set; }

    public string CreatedByUsername { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string? Detail { get; set; }

    public Guid PaymentChannelId { get; set; }

    public string? PlayerCode { get; set; }

    public string UpdatedByUsername { get; set; } = null!;

    public DateTime UpdatedOn { get; set; }

    public virtual Brand Brand { get; set; } = null!;

    public virtual PaymentChannel PaymentChannel { get; set; } = null!;

    public virtual Player? PlayerCodeNavigation { get; set; }
}
