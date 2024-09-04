using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class StationLetterPlayer
{
    public Guid StationLetterId { get; set; }

    public string PlayerCode { get; set; } = null!;

    public bool IsRead { get; set; }

    public DateTime? ReadOn { get; set; }

    public virtual Player PlayerCodeNavigation { get; set; } = null!;

    public virtual StationLetter StationLetter { get; set; } = null!;
}
