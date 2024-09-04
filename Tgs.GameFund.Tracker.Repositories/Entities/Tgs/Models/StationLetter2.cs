using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class StationLetter2
{
    public Guid Id { get; set; }

    public Guid? ComeFrom { get; set; }

    public string Content { get; set; } = null!;

    public bool HaveRead { get; set; }

    public string? Quotation { get; set; }

    public DateTime ReceivedOn { get; set; }

    public string Receiver { get; set; } = null!;

    public bool Replied { get; set; }

    public string Sender { get; set; } = null!;

    public DateTime SentOn { get; set; }

    public string Subject { get; set; } = null!;
}
