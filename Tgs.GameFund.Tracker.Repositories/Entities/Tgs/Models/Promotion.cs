using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class Promotion
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public DateTime From { get; set; }

    public DateTime To { get; set; }

    public short Status { get; set; }

    public bool AutoSentPlayerBonus { get; set; }

    public Guid BrandId { get; set; }

    public string PromotionType { get; set; } = null!;

    public string? SettlementIntervalType { get; set; }

    public decimal TotalAmountLimit { get; set; }

    public decimal AmountUsed { get; set; }

    public short Unlimited { get; set; }

    public short? GameType { get; set; }

    public decimal Percentage { get; set; }

    public decimal BonusAmountLimit { get; set; }

    public decimal TurnoverMultiple { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime UpdatedOn { get; set; }

    public string? CreatedByUsername { get; set; }

    public string? UpdatedByUsername { get; set; }

    public Guid? VipLevelId { get; set; }

    public string? Content { get; set; }

    public string? DesktopBanner { get; set; }

    public string? Localization { get; set; }

    public string? MobileBanner { get; set; }

    public string? SubSubject { get; set; }

    public string? Terms { get; set; }

    public string CampaignDetail { get; set; } = null!;

    public int DisplayOrder { get; set; }

    public Guid? AmountUsedSnapshotId { get; set; }

    public Guid? SnapshotEventId { get; set; }

    public virtual Brand Brand { get; set; } = null!;

    public virtual ICollection<DepositAccumulateRouletteEvent> DepositAccumulateRouletteEvents { get; set; } = new List<DepositAccumulateRouletteEvent>();

    public virtual ICollection<DepositAccumulateRouletteGameEvent> DepositAccumulateRouletteGameEvents { get; set; } = new List<DepositAccumulateRouletteGameEvent>();

    public virtual ICollection<DistributeRegisterEvent> DistributeRegisterEvents { get; set; } = new List<DistributeRegisterEvent>();

    public virtual ICollection<OfflineLoginRewardEvent> OfflineLoginRewardEvents { get; set; } = new List<OfflineLoginRewardEvent>();

    public virtual ICollection<PromotionBonuse> PromotionBonuses { get; set; } = new List<PromotionBonuse>();

    public virtual ICollection<PromotionParticipant> PromotionParticipants { get; set; } = new List<PromotionParticipant>();

    public virtual ICollection<PromotionVipLevel> PromotionVipLevels { get; set; } = new List<PromotionVipLevel>();

    public virtual ICollection<RebatePromotionJoinPlayer> RebatePromotionJoinPlayers { get; set; } = new List<RebatePromotionJoinPlayer>();

    public virtual ICollection<ReliefPromotionJoinPlayer> ReliefPromotionJoinPlayers { get; set; } = new List<ReliefPromotionJoinPlayer>();

    public virtual ICollection<RouletteSignInEvent> RouletteSignInEvents { get; set; } = new List<RouletteSignInEvent>();

    public virtual ICollection<SignInEvent> SignInEvents { get; set; } = new List<SignInEvent>();

    public virtual ICollection<TransactionPromotion> TransactionPromotions { get; set; } = new List<TransactionPromotion>();

    public virtual VipLevel? VipLevel { get; set; }

    public virtual ICollection<GameProvider> GameProviders { get; set; } = new List<GameProvider>();
}
