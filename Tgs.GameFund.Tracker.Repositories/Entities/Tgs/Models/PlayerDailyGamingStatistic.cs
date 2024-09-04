using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class PlayerDailyGamingStatistic
{
    public string PlayerCode { get; set; } = null!;

    public DateOnly ReportDate { get; set; }

    public string GpCode { get; set; } = null!;

    public string SubGpCode { get; set; } = null!;

    public decimal WinLoss { get; set; }
}
