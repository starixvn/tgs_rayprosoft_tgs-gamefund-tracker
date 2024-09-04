using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class BrandCommunication
{
    public Guid Id { get; set; }

    public Guid BrandId { get; set; }

    public string Type { get; set; } = null!;

    public string? Phone { get; set; }

    public string? AppId { get; set; }

    public string? QrCodeUrl { get; set; }

    public virtual Brand Brand { get; set; } = null!;
}
