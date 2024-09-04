using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class Banner
{
    public Guid Id { get; set; }

    public DateTime BeginTime { get; set; }

    public Guid BrandId { get; set; }

    public string CreatedByUserName { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public DateTime? EndTime { get; set; }

    public bool IsEnabled { get; set; }

    public string? Localization { get; set; }

    public int Status { get; set; }

    public string Title { get; set; } = null!;

    public string UpdatedByUserName { get; set; } = null!;

    public DateTime UpdatedOn { get; set; }

    public string? Remark { get; set; }

    public int DisplayOrder { get; set; }

    public virtual Brand Brand { get; set; } = null!;
}
