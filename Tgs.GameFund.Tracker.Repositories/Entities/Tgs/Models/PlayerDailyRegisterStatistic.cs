using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class PlayerDailyRegisterStatistic
{
    public string PlayerCode { get; set; } = null!;

    public DateOnly ReportDate { get; set; }

    public int DailyLoginCount { get; set; }

    public DateTime? LastLoginOn { get; set; }

    public int TotalLoginCount { get; set; }
}
