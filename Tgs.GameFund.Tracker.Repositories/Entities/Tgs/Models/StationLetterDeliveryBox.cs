using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class StationLetterDeliveryBox
{
    public Guid Id { get; set; }

    public Guid? ComeFrom { get; set; }

    public string Content { get; set; } = null!;

    public string? Receiver { get; set; }

    public string ReceiverType { get; set; } = null!;

    public string Sender { get; set; } = null!;

    public DateTime SentOn { get; set; }

    public string Subject { get; set; } = null!;

    public string Operator { get; set; } = null!;
}
