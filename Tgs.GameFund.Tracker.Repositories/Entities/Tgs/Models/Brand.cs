using System;
using System.Collections.Generic;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class Brand
{
    public Guid Id { get; set; }

    public short Status { get; set; }

    public string? Description { get; set; }

    public string? OperationalEmail { get; set; }

    public string? TimeZoneId { get; set; }

    public Guid LicenseeId { get; set; }

    public string ClientId { get; set; } = null!;

    public string SecretKey { get; set; } = null!;

    public string ApiKey { get; set; } = null!;

    public short SettlementIntervalType { get; set; }

    public DateTime PreviousSettlementFrom { get; set; }

    public DateTime PreviousSettlementTo { get; set; }

    public DateTime CurrentSettlementFrom { get; set; }

    public DateTime CurrentSettlementTo { get; set; }

    public DateTime NextSettlementFrom { get; set; }

    public DateTime NextSettlementTo { get; set; }

    public bool AutoSentPlayerBonus { get; set; }

    public bool AutoSentAgentBonus { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public DateTime UpdatedOn { get; set; }

    public string CreatedByUsername { get; set; } = null!;

    public string UpdatedByUsername { get; set; } = null!;

    public int? SettlementDay { get; set; }

    public string? LogoInfo { get; set; }

    public bool EnableSms { get; set; }

    public string? SmsVendorCode { get; set; }

    public string? SmsVendorSettings { get; set; }

    public decimal PlatformCharge { get; set; }

    public bool CheckDividendActiveCount { get; set; }

    public bool EnableSmsRegisterFlow { get; set; }

    public short AgentDividendType { get; set; }

    public bool EnableAgentSms { get; set; }

    public bool EnablePlayerIdentity { get; set; }

    public bool AutoClearWageringRequirement { get; set; }

    public decimal AutoClearWageringRequirementBalance { get; set; }

    public decimal DepositHandlingFeeRateTenPercentile { get; set; }

    public decimal WithdrawHandlingFeeRateTenPercentile { get; set; }

    public bool EnableEmailRegisterFlow { get; set; }

    public string? PlayerRegisterFlowSettings { get; set; }

    public bool EnableBankInfoRegisterFlow { get; set; }

    public bool DepositPaymentLockEnabled { get; set; }

    public int? TimeSpanMinutes { get; set; }

    public bool EnablePlayerAgent { get; set; }

    public bool EnablePlatformAccountFundCheck { get; set; }

    public virtual ICollection<AgentBankInfo> AgentBankInfos { get; set; } = new List<AgentBankInfo>();

    public virtual ICollection<AgentLoginRecord> AgentLoginRecords { get; set; } = new List<AgentLoginRecord>();

    public virtual ICollection<AgentTransaction> AgentTransactions { get; set; } = new List<AgentTransaction>();

    public virtual ICollection<Agent> Agents { get; set; } = new List<Agent>();

    public virtual ICollection<Announcement> Announcements { get; set; } = new List<Announcement>();

    public virtual ICollection<ArticleForm> ArticleForms { get; set; } = new List<ArticleForm>();

    public virtual ICollection<Banner> Banners { get; set; } = new List<Banner>();

    public virtual ICollection<BrandAgentDividendCondition> BrandAgentDividendConditions { get; set; } = new List<BrandAgentDividendCondition>();

    public virtual ICollection<BrandBetLimit> BrandBetLimits { get; set; } = new List<BrandBetLimit>();

    public virtual BrandBucketType? BrandBucketType { get; set; }

    public virtual ICollection<BrandCommunication> BrandCommunications { get; set; } = new List<BrandCommunication>();

    public virtual ICollection<BrandCurrency> BrandCurrencies { get; set; } = new List<BrandCurrency>();

    public virtual ICollection<BrandDomain> BrandDomains { get; set; } = new List<BrandDomain>();

    public virtual ICollection<BrandGameProvider> BrandGameProviders { get; set; } = new List<BrandGameProvider>();

    public virtual ICollection<BrandGame> BrandGames { get; set; } = new List<BrandGame>();

    public virtual ICollection<BrandGroup> BrandGroups { get; set; } = new List<BrandGroup>();

    public virtual ICollection<BrandLanguage> BrandLanguages { get; set; } = new List<BrandLanguage>();

    public virtual BrandLiveChat? BrandLiveChat { get; set; }

    public virtual BrandMaintenance? BrandMaintenance { get; set; }

    public virtual BrandPaymentSetting? BrandPaymentSetting { get; set; }

    public virtual ICollection<BrandPayment> BrandPayments { get; set; } = new List<BrandPayment>();

    public virtual ICollection<Department> Departments { get; set; } = new List<Department>();

    public virtual ICollection<DepositAccumulateRouletteEvent> DepositAccumulateRouletteEvents { get; set; } = new List<DepositAccumulateRouletteEvent>();

    public virtual ICollection<DepositAccumulateRouletteGameEvent> DepositAccumulateRouletteGameEvents { get; set; } = new List<DepositAccumulateRouletteGameEvent>();

    public virtual ICollection<DepositForm> DepositForms { get; set; } = new List<DepositForm>();

    public virtual ICollection<DistributeRegisterEvent> DistributeRegisterEvents { get; set; } = new List<DistributeRegisterEvent>();

    public virtual ICollection<DraftForm> DraftForms { get; set; } = new List<DraftForm>();

    public virtual Licensee Licensee { get; set; } = null!;

    public virtual ICollection<OfflineLoginRewardEvent> OfflineLoginRewardEvents { get; set; } = new List<OfflineLoginRewardEvent>();

    public virtual ICollection<PaymentHandlingFee> PaymentHandlingFees { get; set; } = new List<PaymentHandlingFee>();

    public virtual PlatformCredit? PlatformCredit { get; set; }

    public virtual ICollection<PlayerAgentRelation> PlayerAgentRelations { get; set; } = new List<PlayerAgentRelation>();

    public virtual ICollection<PlayerBankInfo> PlayerBankInfos { get; set; } = new List<PlayerBankInfo>();

    public virtual ICollection<PlayerBankinfoAttribution> PlayerBankinfoAttributions { get; set; } = new List<PlayerBankinfoAttribution>();

    public virtual ICollection<PlayerBucketCleanForm> PlayerBucketCleanForms { get; set; } = new List<PlayerBucketCleanForm>();

    public virtual ICollection<PlayerBucketCleanForms2> PlayerBucketCleanForms2s { get; set; } = new List<PlayerBucketCleanForms2>();

    public virtual ICollection<PlayerFavoriteGame> PlayerFavoriteGames { get; set; } = new List<PlayerFavoriteGame>();

    public virtual ICollection<PlayerLoginRecord> PlayerLoginRecords { get; set; } = new List<PlayerLoginRecord>();

    public virtual ICollection<PlayerProperty> PlayerProperties { get; set; } = new List<PlayerProperty>();

    public virtual ICollection<Player> Players { get; set; } = new List<Player>();

    public virtual ICollection<Promotion> Promotions { get; set; } = new List<Promotion>();

    public virtual ICollection<RouletteSignInEvent> RouletteSignInEvents { get; set; } = new List<RouletteSignInEvent>();

    public virtual ICollection<SignInEvent> SignInEvents { get; set; } = new List<SignInEvent>();

    public virtual ICollection<StationLetter> StationLetters { get; set; } = new List<StationLetter>();

    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();

    public virtual ICollection<TransferBalanceForm> TransferBalanceForms { get; set; } = new List<TransferBalanceForm>();

    public virtual ICollection<VipLevel> VipLevels { get; set; } = new List<VipLevel>();

    public virtual ICollection<Whitelist> Whitelists { get; set; } = new List<Whitelist>();

    public virtual ICollection<WithdrawForm> WithdrawForms { get; set; } = new List<WithdrawForm>();
}
