using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class SystemLocalization
{
    public string CultureCode { get; set; } = null!;

    public string MessageId { get; set; } = null!;

    public string SystemCode { get; set; } = null!;

    public string Text { get; set; } = null!;
}
