using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class PlayerFavoriteGame
{
    public int GameId { get; set; }

    public string PlayerCode { get; set; } = null!;

    public Guid BrandId { get; set; }

    public int GameType { get; set; }

    public string SubGameProviderCode { get; set; } = null!;

    public virtual Brand Brand { get; set; } = null!;

    public virtual Player PlayerCodeNavigation { get; set; } = null!;
}
