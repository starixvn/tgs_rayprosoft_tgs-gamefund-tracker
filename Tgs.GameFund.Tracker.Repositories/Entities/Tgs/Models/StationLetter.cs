using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class StationLetter
{
    public Guid Id { get; set; }

    public Guid BrandId { get; set; }

    public string? Subject { get; set; }

    public string? Content { get; set; }

    public string? Remarks { get; set; }

    public bool AssignedAllPlayers { get; set; }

    public int Status { get; set; }

    public string? VerifiedByUsername { get; set; }

    public string CreatedByUsername { get; set; } = null!;

    public string UpdatedByUsername { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public DateTime UpdatedOn { get; set; }

    public string Localization { get; set; } = null!;

    public virtual Brand Brand { get; set; } = null!;

    public virtual ICollection<StationLetterPlayer> StationLetterPlayers { get; set; } = new List<StationLetterPlayer>();
}
