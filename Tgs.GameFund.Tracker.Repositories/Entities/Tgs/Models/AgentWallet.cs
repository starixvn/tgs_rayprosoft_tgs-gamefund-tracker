using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class AgentWallet
{
    public Guid Id { get; set; }

    public Guid AgentId { get; set; }

    public string CurrencyCode { get; set; } = null!;

    public decimal Balance { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime UpdatedOn { get; set; }

    public virtual Agent Agent { get; set; } = null!;

    public virtual ICollection<AgentTransaction> AgentTransactions { get; set; } = new List<AgentTransaction>();

    public virtual Currency CurrencyCodeNavigation { get; set; } = null!;
}
