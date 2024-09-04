using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class Announcement
{
    public Guid Id { get; set; }

    public string? Subject { get; set; }

    public string? Content { get; set; }

    public string? Remarks { get; set; }

    public Guid BrandId { get; set; }

    public int Status { get; set; }

    public DateTime From { get; set; }

    public DateTime To { get; set; }

    public short DisplayOrder { get; set; }

    public string? VerifiedByUsername { get; set; }

    public string CreatedByUsername { get; set; } = null!;

    public string UpdatedByUsername { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public DateTime UpdatedOn { get; set; }

    public string Localization { get; set; } = null!;

    public string Type { get; set; } = null!;

    public virtual Brand Brand { get; set; } = null!;
}
