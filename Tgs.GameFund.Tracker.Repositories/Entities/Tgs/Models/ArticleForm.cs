using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class ArticleForm
{
    public Guid Id { get; set; }

    public Guid BrandId { get; set; }

    public string Description { get; set; } = null!;

    public string LocalizedArticles { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string Modifier { get; set; } = null!;

    public DateTime UpdatedOn { get; set; }

    public virtual Brand Brand { get; set; } = null!;
}
