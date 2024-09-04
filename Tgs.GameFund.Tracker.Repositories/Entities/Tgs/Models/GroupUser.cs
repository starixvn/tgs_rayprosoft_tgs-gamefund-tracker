using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class GroupUser
{
    public Guid GroupId { get; set; }

    public string System { get; set; } = null!;

    public string UserId { get; set; } = null!;

    public virtual Group Group { get; set; } = null!;

    public virtual System SystemNavigation { get; set; } = null!;
}
