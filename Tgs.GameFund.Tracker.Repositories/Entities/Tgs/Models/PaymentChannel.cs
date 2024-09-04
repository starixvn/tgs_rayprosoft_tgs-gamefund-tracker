using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class PaymentChannel
{
    public Guid Id { get; set; }

    public string Code { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<AgentBankInfo> AgentBankInfos { get; set; } = new List<AgentBankInfo>();

    public virtual ICollection<PaymentMethodChannel> PaymentMethodChannels { get; set; } = new List<PaymentMethodChannel>();

    public virtual ICollection<PlayerBankInfo> PlayerBankInfos { get; set; } = new List<PlayerBankInfo>();
}
