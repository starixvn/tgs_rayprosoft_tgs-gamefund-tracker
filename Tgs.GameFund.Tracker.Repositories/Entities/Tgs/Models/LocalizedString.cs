using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class LocalizedString
{
    public string Context { get; set; } = null!;

    public string Key { get; set; } = null!;

    public string CultureCode { get; set; } = null!;

    public string Translation { get; set; } = null!;

    public virtual Language CultureCodeNavigation { get; set; } = null!;
}
