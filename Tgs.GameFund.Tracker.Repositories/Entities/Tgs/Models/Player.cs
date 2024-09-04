using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class Player
{
    public string PlayerCode { get; set; } = null!;

    public string? IdNumber { get; set; }

    public string Username { get; set; } = null!;

    public string? RealName { get; set; }

    public byte[] Password { get; set; } = null!;

    public byte[] Salt { get; set; } = null!;

    public byte[] WithdrawPassword { get; set; } = null!;

    public byte[] WithdrawSalt { get; set; } = null!;

    public Guid DefaultWalletId { get; set; }

    public string DefaultWalletCurrencyCode { get; set; } = null!;

    public Guid BrandId { get; set; }

    public DateTime? RegisteredOn { get; set; }

    public DateTime LastActiveOn { get; set; }

    public short Status { get; set; }

    public int BetLimitId { get; set; }

    public short Type { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public string? Qq { get; set; }

    public string? Wechat { get; set; }

    public Guid? AgentId { get; set; }

    public bool IdentityAuthentication { get; set; }

    public bool PhoneAuthentication { get; set; }

    public decimal AccumulatedDeposit { get; set; }

    public Guid? VipId { get; set; }

    public string? UpdatedByUsername { get; set; }

    public DateTime UpdatedOn { get; set; }

    public DateTime? FirstDepositOn { get; set; }

    public string? AreaCode { get; set; }

    public DateTime? FirstPromotionOn { get; set; }

    public string? Remark { get; set; }

    public DateOnly? Birthdate { get; set; }

    public string? Birthday { get; set; }

    public Guid? SnapshotEventId { get; set; }

    public virtual Agent? Agent { get; set; }

    public virtual ICollection<AgentBankInfo> AgentBankInfos { get; set; } = new List<AgentBankInfo>();

    public virtual BetLimit BetLimit { get; set; } = null!;

    public virtual Brand Brand { get; set; } = null!;

    public virtual ICollection<BrandPaymentPlayer> BrandPaymentPlayers { get; set; } = new List<BrandPaymentPlayer>();

    public virtual ICollection<DepositAccumulateRouletteEvent> DepositAccumulateRouletteEvents { get; set; } = new List<DepositAccumulateRouletteEvent>();

    public virtual ICollection<DepositAccumulateRouletteGameEvent> DepositAccumulateRouletteGameEvents { get; set; } = new List<DepositAccumulateRouletteGameEvent>();

    public virtual ICollection<DepositForm> DepositForms { get; set; } = new List<DepositForm>();

    public virtual ICollection<DistributeRegisterEvent> DistributeRegisterEvents { get; set; } = new List<DistributeRegisterEvent>();

    public virtual GamePlayerTransformIdnlive? GamePlayerTransformIdnlive { get; set; }

    public virtual ICollection<OfflineLoginRewardEvent> OfflineLoginRewardEvents { get; set; } = new List<OfflineLoginRewardEvent>();

    public virtual PlayerAgentRelation? PlayerAgentRelation { get; set; }

    public virtual ICollection<PlayerBankInfoTag> PlayerBankInfoTags { get; set; } = new List<PlayerBankInfoTag>();

    public virtual ICollection<PlayerBankInfo> PlayerBankInfos { get; set; } = new List<PlayerBankInfo>();

    public virtual ICollection<PlayerBankinfoAttribution> PlayerBankinfoAttributions { get; set; } = new List<PlayerBankinfoAttribution>();

    public virtual ICollection<PlayerBucketCleanForm> PlayerBucketCleanForms { get; set; } = new List<PlayerBucketCleanForm>();

    public virtual ICollection<PlayerBucketCleanForms2> PlayerBucketCleanForms2s { get; set; } = new List<PlayerBucketCleanForms2>();

    public virtual ICollection<PlayerFavoriteGame> PlayerFavoriteGames { get; set; } = new List<PlayerFavoriteGame>();

    public virtual PlayerGameSetting? PlayerGameSetting { get; set; }

    public virtual PlayerIdentity? PlayerIdentity { get; set; }

    public virtual ICollection<PlayerIpRecord> PlayerIpRecords { get; set; } = new List<PlayerIpRecord>();

    public virtual ICollection<PlayerLoginRecord> PlayerLoginRecords { get; set; } = new List<PlayerLoginRecord>();

    public virtual ICollection<PlayerProperty> PlayerProperties { get; set; } = new List<PlayerProperty>();

    public virtual ICollection<PlayerSportsBetLimit> PlayerSportsBetLimits { get; set; } = new List<PlayerSportsBetLimit>();

    public virtual ICollection<PromotionParticipant> PromotionParticipants { get; set; } = new List<PromotionParticipant>();

    public virtual ICollection<PromotionPlayer> PromotionPlayers { get; set; } = new List<PromotionPlayer>();

    public virtual ICollection<RebatePromotionJoinPlayer> RebatePromotionJoinPlayers { get; set; } = new List<RebatePromotionJoinPlayer>();

    public virtual ICollection<ReliefPromotionJoinPlayer> ReliefPromotionJoinPlayers { get; set; } = new List<ReliefPromotionJoinPlayer>();

    public virtual ICollection<RouletteSignInEvent> RouletteSignInEvents { get; set; } = new List<RouletteSignInEvent>();

    public virtual ICollection<SignInEvent> SignInEvents { get; set; } = new List<SignInEvent>();

    public virtual ICollection<StationLetterPlayer> StationLetterPlayers { get; set; } = new List<StationLetterPlayer>();

    public virtual VipLevel? Vip { get; set; }
}
