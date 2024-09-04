using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Tgs.GameFund.Tracker.Repositories.Entities;

public partial class TgsDbContext : DbContext
{
    public TgsDbContext(DbContextOptions<TgsDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Account> Accounts { get; set; }

    public virtual DbSet<AccountEventSource> AccountEventSources { get; set; }

    public virtual DbSet<AdjustAgentRecord> AdjustAgentRecords { get; set; }

    public virtual DbSet<AdjustPlayerRecord> AdjustPlayerRecords { get; set; }

    public virtual DbSet<AdjustTransferRecord> AdjustTransferRecords { get; set; }

    public virtual DbSet<Agent> Agents { get; set; }

    public virtual DbSet<AgentAuditLog> AgentAuditLogs { get; set; }

    public virtual DbSet<AgentBank> AgentBanks { get; set; }

    public virtual DbSet<AgentBankInfo> AgentBankInfos { get; set; }

    public virtual DbSet<AgentClearCommissionRecord> AgentClearCommissionRecords { get; set; }

    public virtual DbSet<AgentDailyMarketingStatistic> AgentDailyMarketingStatistics { get; set; }

    public virtual DbSet<AgentDailyPaymentStatistic> AgentDailyPaymentStatistics { get; set; }

    public virtual DbSet<AgentDividend> AgentDividends { get; set; }

    public virtual DbSet<AgentDividendCondition> AgentDividendConditions { get; set; }

    public virtual DbSet<AgentDividendContract> AgentDividendContracts { get; set; }

    public virtual DbSet<AgentDividendMultipleLayer> AgentDividendMultipleLayers { get; set; }

    public virtual DbSet<AgentDividendProductFee> AgentDividendProductFees { get; set; }

    public virtual DbSet<AgentDividendRecord> AgentDividendRecords { get; set; }

    public virtual DbSet<AgentDividendSnapshot> AgentDividendSnapshots { get; set; }

    public virtual DbSet<AgentDomain> AgentDomains { get; set; }

    public virtual DbSet<AgentEventSource> AgentEventSources { get; set; }

    public virtual DbSet<AgentLoginRecord> AgentLoginRecords { get; set; }

    public virtual DbSet<AgentProductFee> AgentProductFees { get; set; }

    public virtual DbSet<AgentTransaction> AgentTransactions { get; set; }

    public virtual DbSet<AgentWallet> AgentWallets { get; set; }

    public virtual DbSet<Announcement> Announcements { get; set; }

    public virtual DbSet<ArticleForm> ArticleForms { get; set; }

    public virtual DbSet<BackgroundPaymentStatisticsSetting> BackgroundPaymentStatisticsSettings { get; set; }

    public virtual DbSet<Banner> Banners { get; set; }

    public virtual DbSet<BetLimit> BetLimits { get; set; }

    public virtual DbSet<Brand> Brands { get; set; }

    public virtual DbSet<BrandAgentDividendCondition> BrandAgentDividendConditions { get; set; }

    public virtual DbSet<BrandAllAgent> BrandAllAgents { get; set; }

    public virtual DbSet<BrandAllAgentGameType> BrandAllAgentGameTypes { get; set; }

    public virtual DbSet<BrandAllAgentGameTypeCondition> BrandAllAgentGameTypeConditions { get; set; }

    public virtual DbSet<BrandAllAgentSetting> BrandAllAgentSettings { get; set; }

    public virtual DbSet<BrandBetLimit> BrandBetLimits { get; set; }

    public virtual DbSet<BrandBucketType> BrandBucketTypes { get; set; }

    public virtual DbSet<BrandCommunication> BrandCommunications { get; set; }

    public virtual DbSet<BrandContract> BrandContracts { get; set; }

    public virtual DbSet<BrandContractCondition> BrandContractConditions { get; set; }

    public virtual DbSet<BrandCurrency> BrandCurrencies { get; set; }

    public virtual DbSet<BrandDailyMarketingStatistic> BrandDailyMarketingStatistics { get; set; }

    public virtual DbSet<BrandDailyPaymentStatistic> BrandDailyPaymentStatistics { get; set; }

    public virtual DbSet<BrandDomain> BrandDomains { get; set; }

    public virtual DbSet<BrandGame> BrandGames { get; set; }

    public virtual DbSet<BrandGameCredit> BrandGameCredits { get; set; }

    public virtual DbSet<BrandGameCreditProfit> BrandGameCreditProfits { get; set; }

    public virtual DbSet<BrandGameCreditSuspSetting> BrandGameCreditSuspSettings { get; set; }

    public virtual DbSet<BrandGameCreditTxn> BrandGameCreditTxns { get; set; }

    public virtual DbSet<BrandGameProvider> BrandGameProviders { get; set; }

    public virtual DbSet<BrandGameProviderAggregateAuditLog> BrandGameProviderAggregateAuditLogs { get; set; }

    public virtual DbSet<BrandGameProviderSchedule> BrandGameProviderSchedules { get; set; }

    public virtual DbSet<BrandGroup> BrandGroups { get; set; }

    public virtual DbSet<BrandGroupBetLimit> BrandGroupBetLimits { get; set; }

    public virtual DbSet<BrandLanguage> BrandLanguages { get; set; }

    public virtual DbSet<BrandLiveChat> BrandLiveChats { get; set; }

    public virtual DbSet<BrandMaintenance> BrandMaintenances { get; set; }

    public virtual DbSet<BrandPayment> BrandPayments { get; set; }

    public virtual DbSet<BrandPaymentAuditLog> BrandPaymentAuditLogs { get; set; }

    public virtual DbSet<BrandPaymentAutoWithdraw> BrandPaymentAutoWithdraws { get; set; }

    public virtual DbSet<BrandPaymentAutoWithdrawEventSource> BrandPaymentAutoWithdrawEventSources { get; set; }

    public virtual DbSet<BrandPaymentPlayer> BrandPaymentPlayers { get; set; }

    public virtual DbSet<BrandPaymentSetting> BrandPaymentSettings { get; set; }

    public virtual DbSet<BrandPlayerBankinfoCheckFlag> BrandPlayerBankinfoCheckFlags { get; set; }

    public virtual DbSet<BrandPlayerContractDisplay> BrandPlayerContractDisplays { get; set; }

    public virtual DbSet<BrandProductFee> BrandProductFees { get; set; }

    public virtual DbSet<BrandSm> BrandSms { get; set; }

    public virtual DbSet<Calculate> Calculates { get; set; }

    public virtual DbSet<CalculateChangeLog> CalculateChangeLogs { get; set; }

    public virtual DbSet<Currency> Currencies { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<DepositAccumulateRouletteEvent> DepositAccumulateRouletteEvents { get; set; }

    public virtual DbSet<DepositAccumulateRouletteGameEvent> DepositAccumulateRouletteGameEvents { get; set; }

    public virtual DbSet<DepositForm> DepositForms { get; set; }

    public virtual DbSet<DepositFormEventSource> DepositFormEventSources { get; set; }

    public virtual DbSet<DepositPromotionCalculatePair> DepositPromotionCalculatePairs { get; set; }

    public virtual DbSet<DepositPromotionStatistic> DepositPromotionStatistics { get; set; }

    public virtual DbSet<DistributeRegisterEvent> DistributeRegisterEvents { get; set; }

    public virtual DbSet<DraftForm> DraftForms { get; set; }

    public virtual DbSet<FiveMinutesPaymentStatistic> FiveMinutesPaymentStatistics { get; set; }

    public virtual DbSet<FiveMinutesPaymentStatisticsDeltum> FiveMinutesPaymentStatisticsDelta { get; set; }

    public virtual DbSet<Function> Functions { get; set; }

    public virtual DbSet<FunctionEventSource> FunctionEventSources { get; set; }

    public virtual DbSet<Game> Games { get; set; }

    public virtual DbSet<GameBetsDefault> GameBetsDefaults { get; set; }

    public virtual DbSet<GameBetting> GameBettings { get; set; }

    public virtual DbSet<GameFundTransferTrace> GameFundTransferTraces { get; set; }

    public virtual DbSet<GamePlayerTransformIdnlive> GamePlayerTransformIdnlives { get; set; }

    public virtual DbSet<GameProvider> GameProviders { get; set; }

    public virtual DbSet<GameProviderAggregateAuditLog> GameProviderAggregateAuditLogs { get; set; }

    public virtual DbSet<GameProviderBetLimit> GameProviderBetLimits { get; set; }

    public virtual DbSet<GameProviderConfiguration> GameProviderConfigurations { get; set; }

    public virtual DbSet<GameProviderCurrency> GameProviderCurrencies { get; set; }

    public virtual DbSet<GameProviderFundTransferTransaction> GameProviderFundTransferTransactions { get; set; }

    public virtual DbSet<GameProviderLanguage> GameProviderLanguages { get; set; }

    public virtual DbSet<GameWagerPlayerAccum> GameWagerPlayerAccums { get; set; }

    public virtual DbSet<GameWagerStatCloses2> GameWagerStatCloses2s { get; set; }

    public virtual DbSet<GameWagerStatClosesDefault> GameWagerStatClosesDefaults { get; set; }

    public virtual DbSet<GameWagerStatDailyClose> GameWagerStatDailyCloses { get; set; }

    public virtual DbSet<GameWagerStatDailyZoneClose> GameWagerStatDailyZoneCloses { get; set; }

    public virtual DbSet<GameWagerStatHourlyCloses2> GameWagerStatHourlyCloses2s { get; set; }

    public virtual DbSet<GameWagerStatHourlyClosesDefault> GameWagerStatHourlyClosesDefaults { get; set; }

    public virtual DbSet<GameWagerStatHourlyZoneCloses2> GameWagerStatHourlyZoneCloses2s { get; set; }

    public virtual DbSet<GameWagerStatHourlyZoneClosesDefault> GameWagerStatHourlyZoneClosesDefaults { get; set; }

    public virtual DbSet<Group> Groups { get; set; }

    public virtual DbSet<GroupUser> GroupUsers { get; set; }

    public virtual DbSet<HourPaymentStatistic> HourPaymentStatistics { get; set; }

    public virtual DbSet<Language> Languages { get; set; }

    public virtual DbSet<Licensee> Licensees { get; set; }

    public virtual DbSet<LocalizedString> LocalizedStrings { get; set; }

    public virtual DbSet<MarketType> MarketTypes { get; set; }

    public virtual DbSet<MarketingStatisticsSetting> MarketingStatisticsSettings { get; set; }

    public virtual DbSet<MigrationsHistory> MigrationsHistories { get; set; }

    public virtual DbSet<NotificationContact> NotificationContacts { get; set; }

    public virtual DbSet<OfflineDepositEvent> OfflineDepositEvents { get; set; }

    public virtual DbSet<OfflineLoginRewardEvent> OfflineLoginRewardEvents { get; set; }

    public virtual DbSet<Payment> Payments { get; set; }

    public virtual DbSet<PaymentChannel> PaymentChannels { get; set; }

    public virtual DbSet<PaymentHandlingFee> PaymentHandlingFees { get; set; }

    public virtual DbSet<PaymentMethod> PaymentMethods { get; set; }

    public virtual DbSet<PaymentMethodChannel> PaymentMethodChannels { get; set; }

    public virtual DbSet<Permission> Permissions { get; set; }

    public virtual DbSet<PlatformCredit> PlatformCredits { get; set; }

    public virtual DbSet<PlatformPayRecord> PlatformPayRecords { get; set; }

    public virtual DbSet<Player> Players { get; set; }

    public virtual DbSet<PlayerAgentRelation> PlayerAgentRelations { get; set; }

    public virtual DbSet<PlayerAllAgentRebate> PlayerAllAgentRebates { get; set; }

    public virtual DbSet<PlayerAllAgentRebateContributor> PlayerAllAgentRebateContributors { get; set; }

    public virtual DbSet<PlayerAllAgentRebateRecord> PlayerAllAgentRebateRecords { get; set; }

    public virtual DbSet<PlayerAuditLog> PlayerAuditLogs { get; set; }

    public virtual DbSet<PlayerAuthenticationForm> PlayerAuthenticationForms { get; set; }

    public virtual DbSet<PlayerBankInfo> PlayerBankInfos { get; set; }

    public virtual DbSet<PlayerBankInfoEventSource> PlayerBankInfoEventSources { get; set; }

    public virtual DbSet<PlayerBankInfoTag> PlayerBankInfoTags { get; set; }

    public virtual DbSet<PlayerBankinfoAttribution> PlayerBankinfoAttributions { get; set; }

    public virtual DbSet<PlayerBucket> PlayerBuckets { get; set; }

    public virtual DbSet<PlayerBucketCleanEventSource> PlayerBucketCleanEventSources { get; set; }

    public virtual DbSet<PlayerBucketCleanEventSource2> PlayerBucketCleanEventSource2s { get; set; }

    public virtual DbSet<PlayerBucketCleanForm> PlayerBucketCleanForms { get; set; }

    public virtual DbSet<PlayerBucketCleanForms2> PlayerBucketCleanForms2s { get; set; }

    public virtual DbSet<PlayerBucketEventSource> PlayerBucketEventSources { get; set; }

    public virtual DbSet<PlayerBucketHistory> PlayerBucketHistories { get; set; }

    public virtual DbSet<PlayerBucketMigration> PlayerBucketMigrations { get; set; }

    public virtual DbSet<PlayerDailyGamingStatistic> PlayerDailyGamingStatistics { get; set; }

    public virtual DbSet<PlayerDailyPaymentStatistic> PlayerDailyPaymentStatistics { get; set; }

    public virtual DbSet<PlayerDailyRegisterStatistic> PlayerDailyRegisterStatistics { get; set; }

    public virtual DbSet<PlayerEventSource> PlayerEventSources { get; set; }

    public virtual DbSet<PlayerFavoriteGame> PlayerFavoriteGames { get; set; }

    public virtual DbSet<PlayerGameSetting> PlayerGameSettings { get; set; }

    public virtual DbSet<PlayerIdentity> PlayerIdentities { get; set; }

    public virtual DbSet<PlayerIpRecord> PlayerIpRecords { get; set; }

    public virtual DbSet<PlayerLoginRecord> PlayerLoginRecords { get; set; }

    public virtual DbSet<PlayerParent> PlayerParents { get; set; }

    public virtual DbSet<PlayerPaymentOverview> PlayerPaymentOverviews { get; set; }

    public virtual DbSet<PlayerProperty> PlayerProperties { get; set; }

    public virtual DbSet<PlayerRebate> PlayerRebates { get; set; }

    public virtual DbSet<PlayerSportsBetLimit> PlayerSportsBetLimits { get; set; }

    public virtual DbSet<PlayerTag> PlayerTags { get; set; }

    public virtual DbSet<PlayerVipLevel> PlayerVipLevels { get; set; }

    public virtual DbSet<PlayerVipLevelBirthdayForm> PlayerVipLevelBirthdayForms { get; set; }

    public virtual DbSet<PlayerVipLevelCycleForm> PlayerVipLevelCycleForms { get; set; }

    public virtual DbSet<PlayerVipLevelLog> PlayerVipLevelLogs { get; set; }

    public virtual DbSet<PlayerVipLevelUpgradeForm> PlayerVipLevelUpgradeForms { get; set; }

    public virtual DbSet<Promotion> Promotions { get; set; }

    public virtual DbSet<PromotionBonuse> PromotionBonuses { get; set; }

    public virtual DbSet<PromotionDistribute> PromotionDistributes { get; set; }

    public virtual DbSet<PromotionDistributeLog> PromotionDistributeLogs { get; set; }

    public virtual DbSet<PromotionDistributePlan> PromotionDistributePlans { get; set; }

    public virtual DbSet<PromotionEventSource> PromotionEventSources { get; set; }

    public virtual DbSet<PromotionGroup> PromotionGroups { get; set; }

    public virtual DbSet<PromotionParticipant> PromotionParticipants { get; set; }

    public virtual DbSet<PromotionPlayer> PromotionPlayers { get; set; }

    public virtual DbSet<PromotionPromoteDepositChannel> PromotionPromoteDepositChannels { get; set; }

    public virtual DbSet<PromotionRebateDailyStatistic> PromotionRebateDailyStatistics { get; set; }

    public virtual DbSet<PromotionRebateDistribute> PromotionRebateDistributes { get; set; }

    public virtual DbSet<PromotionReliefDailyStatistic> PromotionReliefDailyStatistics { get; set; }

    public virtual DbSet<PromotionReliefDistribute> PromotionReliefDistributes { get; set; }

    public virtual DbSet<PromotionType> PromotionTypes { get; set; }

    public virtual DbSet<PromotionVipLevel> PromotionVipLevels { get; set; }

    public virtual DbSet<RebatePromotionJoinPlayer> RebatePromotionJoinPlayers { get; set; }

    public virtual DbSet<ReliefPromotionJoinPlayer> ReliefPromotionJoinPlayers { get; set; }

    public virtual DbSet<Reseller> Resellers { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<RouletteSignInEvent> RouletteSignInEvents { get; set; }

    public virtual DbSet<Setting> Settings { get; set; }

    public virtual DbSet<SignInEvent> SignInEvents { get; set; }

    public virtual DbSet<SmsSetting> SmsSettings { get; set; }

    public virtual DbSet<SocialMediaSetting> SocialMediaSettings { get; set; }

    public virtual DbSet<SportMarketType> SportMarketTypes { get; set; }

    public virtual DbSet<SportType> SportTypes { get; set; }

    public virtual DbSet<StationLetter> StationLetters { get; set; }

    public virtual DbSet<StationLetter2> StationLetter2s { get; set; }

    public virtual DbSet<StationLetterDeliveryBox> StationLetterDeliveryBoxes { get; set; }

    public virtual DbSet<StationLetterPlayer> StationLetterPlayers { get; set; }

    public virtual DbSet<SubGameProvider> SubGameProviders { get; set; }

    public virtual DbSet<System> Systems { get; set; }

    public virtual DbSet<SystemLocalization> SystemLocalizations { get; set; }

    public virtual DbSet<Transaction> Transactions { get; set; }

    public virtual DbSet<TransactionPromotion> TransactionPromotions { get; set; }

    public virtual DbSet<TransactionsMgmBackup> TransactionsMgmBackups { get; set; }

    public virtual DbSet<TransferBalanceForm> TransferBalanceForms { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<VipLevel> VipLevels { get; set; }

    public virtual DbSet<VipLevelSnapshot> VipLevelSnapshots { get; set; }

    public virtual DbSet<Wallet> Wallets { get; set; }

    public virtual DbSet<Whitelist> Whitelists { get; set; }

    public virtual DbSet<WithdrawForm> WithdrawForms { get; set; }

    public virtual DbSet<WithdrawFormEventSource> WithdrawFormEventSources { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .HasPostgresExtension("ltree")
            .HasPostgresExtension("pg_trgm");

        modelBuilder.Entity<Account>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_accounts");

            entity.ToTable("accounts", "dbo");

            entity.HasIndex(e => new { e.UserName, e.System, e.BrandId }, "ux_accounts_username_system_brand").IsUnique();

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Algorithm).HasColumnName("algorithm");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
            entity.Property(e => e.PasswordHash).HasColumnName("password_hash");
            entity.Property(e => e.SnapshotId).HasColumnName("snapshot_id");
            entity.Property(e => e.System).HasColumnName("system");
            entity.Property(e => e.UpdatedOn).HasColumnName("updated_on");
            entity.Property(e => e.UserName).HasColumnName("user_name");
        });

        modelBuilder.Entity<AccountEventSource>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_account_event_sources");

            entity.ToTable("account_event_sources", "dbo");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.AccountId).HasColumnName("account_id");
            entity.Property(e => e.ChangeSets)
                .HasColumnType("jsonb")
                .HasColumnName("change_sets");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
        });

        modelBuilder.Entity<AdjustAgentRecord>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_adjust_agent_records_id");

            entity.ToTable("adjust_agent_records", "dbo");

            entity.HasIndex(e => new { e.CreatedOn, e.BrandId, e.AgentId, e.Type }, "ix_adjust_agent_record_multiple_keys");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.AdjustmentType).HasColumnName("adjustment_type");
            entity.Property(e => e.AgentId).HasColumnName("agent_id");
            entity.Property(e => e.Amount)
                .HasPrecision(18, 6)
                .HasColumnName("amount");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.CreatedByUsername)
                .HasMaxLength(32)
                .HasColumnName("created_by_username");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
            entity.Property(e => e.Remark).HasColumnName("remark");
            entity.Property(e => e.TransactionId).HasColumnName("transaction_id");
            entity.Property(e => e.TransferTarget).HasColumnName("transfer_target");
            entity.Property(e => e.TransferType).HasColumnName("transfer_type");
            entity.Property(e => e.Type).HasColumnName("type");
        });

        modelBuilder.Entity<AdjustPlayerRecord>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_adjust_player_record_id");

            entity.ToTable("adjust_player_records", "dbo");

            entity.HasIndex(e => new { e.CreatedOn, e.BrandId, e.PlayerCode, e.Type }, "ix_adjust_player_record_multiple_keys");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.AdjustmentType).HasColumnName("adjustment_type");
            entity.Property(e => e.Amount)
                .HasPrecision(18, 6)
                .HasColumnName("amount");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.BucketAmount)
                .HasPrecision(18, 6)
                .HasColumnName("bucket_amount");
            entity.Property(e => e.CreatedByUsername)
                .HasMaxLength(32)
                .HasColumnName("created_by_username");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
            entity.Property(e => e.IncludeInNetProfit).HasColumnName("include_in_net_profit");
            entity.Property(e => e.PlayerCode).HasColumnName("player_code");
            entity.Property(e => e.Remark).HasColumnName("remark");
            entity.Property(e => e.TransactionId).HasColumnName("transaction_id");
            entity.Property(e => e.TransactionRecordedOn)
                .HasDefaultValueSql("'0001-01-01 00:00:00+00'::timestamp with time zone")
                .HasColumnName("transaction_recorded_on");
            entity.Property(e => e.TransferTarget).HasColumnName("transfer_target");
            entity.Property(e => e.TransferType).HasColumnName("transfer_type");
            entity.Property(e => e.Type).HasColumnName("type");
        });

        modelBuilder.Entity<AdjustTransferRecord>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_adjust_transfer_record_id");

            entity.ToTable("adjust_transfer_records", "dbo");

            entity.HasIndex(e => new { e.CreatedOn, e.TransferType, e.TransferFromUsername, e.TransferToUsername }, "ix_adjust_transfer_record_multiple_keys");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Amount)
                .HasPrecision(18, 6)
                .HasColumnName("amount");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
            entity.Property(e => e.TransactionFromId).HasColumnName("transaction_from_id");
            entity.Property(e => e.TransactionToId).HasColumnName("transaction_to_id");
            entity.Property(e => e.TransferFromUsername).HasColumnName("transfer_from_username");
            entity.Property(e => e.TransferToUsername).HasColumnName("transfer_to_username");
            entity.Property(e => e.TransferType).HasColumnName("transfer_type");
        });

        modelBuilder.Entity<Agent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_agents");

            entity.ToTable("agents", "dbo");

            entity.HasIndex(e => e.BrandId, "ix_agents_brand_id");

            entity.HasIndex(e => e.Path, "ix_agents_gist_path").HasMethod("gist");

            entity.HasIndex(e => e.ParentAgentId, "ix_agents_parent_agent_id");

            entity.HasIndex(e => new { e.Username, e.BrandId }, "ux_agents_brand_username").IsUnique();

            entity.HasIndex(e => e.InvitationCode, "ux_agents_invitation_code").IsUnique();

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.AgentStatus).HasColumnName("agent_status");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.CardGameRebatePercentage)
                .HasPrecision(18, 6)
                .HasColumnName("card_game_rebate_percentage");
            entity.Property(e => e.CommissionPercentage)
                .HasPrecision(18, 6)
                .HasColumnName("commission_percentage");
            entity.Property(e => e.CreatedByUsername).HasColumnName("created_by_username");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
            entity.Property(e => e.DefaultWalletId).HasColumnName("default_wallet_id");
            entity.Property(e => e.DividendPercentage)
                .HasPrecision(18, 6)
                .HasColumnName("dividend_percentage");
            entity.Property(e => e.Email)
                .HasMaxLength(64)
                .HasColumnName("email");
            entity.Property(e => e.InvitationCode)
                .HasMaxLength(6)
                .HasColumnName("invitation_code");
            entity.Property(e => e.LevelType).HasColumnName("level_type");
            entity.Property(e => e.LiveDealerRebatePercentage)
                .HasPrecision(18, 6)
                .HasColumnName("live_dealer_rebate_percentage");
            entity.Property(e => e.LotteryRebatePercentage)
                .HasPrecision(18, 6)
                .HasColumnName("lottery_rebate_percentage");
            entity.Property(e => e.NegativeAgentDividendCarryForward)
                .HasDefaultValue(true)
                .HasColumnName("negative_agent_dividend_carry_forward");
            entity.Property(e => e.ParentAgentId).HasColumnName("parent_agent_id");
            entity.Property(e => e.Password).HasColumnName("password");
            entity.Property(e => e.Path)
                .HasDefaultValueSql("''::ltree")
                .HasColumnName("path");
            entity.Property(e => e.Phone)
                .HasMaxLength(32)
                .HasColumnName("phone");
            entity.Property(e => e.Qq)
                .HasMaxLength(64)
                .HasColumnName("qq");
            entity.Property(e => e.RealName)
                .HasMaxLength(32)
                .HasColumnName("real_name");
            entity.Property(e => e.RegisteredOn).HasColumnName("registered_on");
            entity.Property(e => e.Remarks).HasColumnName("remarks");
            entity.Property(e => e.Salt).HasColumnName("salt");
            entity.Property(e => e.SlotRebatePercentage)
                .HasPrecision(18, 6)
                .HasColumnName("slot_rebate_percentage");
            entity.Property(e => e.SnapshotEventId).HasColumnName("snapshot_event_id");
            entity.Property(e => e.SportsRebatePercentage)
                .HasPrecision(18, 6)
                .HasColumnName("sports_rebate_percentage");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.UpdatedByUsername).HasColumnName("updated_by_username");
            entity.Property(e => e.UpdatedOn).HasColumnName("updated_on");
            entity.Property(e => e.Username)
                .HasMaxLength(32)
                .HasColumnName("username");
            entity.Property(e => e.VirtualSportsRebatePercentage)
                .HasPrecision(18, 6)
                .HasColumnName("virtual_sports_rebate_percentage");
            entity.Property(e => e.WalletId).HasColumnName("wallet_id");
            entity.Property(e => e.Wechat)
                .HasMaxLength(64)
                .HasColumnName("wechat");
            entity.Property(e => e.WithdrawPassword).HasColumnName("withdraw_password");
            entity.Property(e => e.WithdrawSalt).HasColumnName("withdraw_salt");

            entity.HasOne(d => d.Brand).WithMany(p => p.Agents)
                .HasForeignKey(d => d.BrandId)
                .HasConstraintName("fk_agents_brands_brand_id");

            entity.HasOne(d => d.ParentAgent).WithMany(p => p.InverseParentAgent)
                .HasForeignKey(d => d.ParentAgentId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_agents_parent_agent_id");
        });

        modelBuilder.Entity<AgentAuditLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_agent_audit_logs");

            entity.ToTable("agent_audit_logs", "dbo");

            entity.HasIndex(e => e.AgentId, "ix_agent_audit_logs_agent_id");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.AgentId).HasColumnName("agent_id");
            entity.Property(e => e.CreatedByUsername)
                .HasMaxLength(32)
                .HasColumnName("created_by_username");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
            entity.Property(e => e.Operation).HasColumnName("operation");

            entity.HasOne(d => d.Agent).WithMany(p => p.AgentAuditLogs)
                .HasForeignKey(d => d.AgentId)
                .HasConstraintName("fk_agent_audit_logs_agent_id");
        });

        modelBuilder.Entity<AgentBank>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_agent_banks");

            entity.ToTable("agent_banks", "dbo");

            entity.HasIndex(e => e.AgentId, "ix_agent_bankers_agent_id");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.AgentId).HasColumnName("agent_id");
            entity.Property(e => e.BankAccount)
                .HasMaxLength(32)
                .HasColumnName("bank_account");
            entity.Property(e => e.BankName)
                .HasMaxLength(32)
                .HasColumnName("bank_name");
            entity.Property(e => e.CreatedByUsername).HasColumnName("created_by_username");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
            entity.Property(e => e.RealName)
                .HasMaxLength(32)
                .HasColumnName("real_name");
            entity.Property(e => e.UpdatedByUsername).HasColumnName("updated_by_username");
            entity.Property(e => e.UpdatedOn).HasColumnName("updated_on");

            entity.HasOne(d => d.Agent).WithMany(p => p.AgentBanks)
                .HasForeignKey(d => d.AgentId)
                .HasConstraintName("fk_agent_banks_agents_agent_id");
        });

        modelBuilder.Entity<AgentBankInfo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_agent_bank_infos");

            entity.ToTable("agent_bank_infos", "dbo");

            entity.HasIndex(e => e.AgentId, "ix_agent_bank_infos_agent_id");

            entity.HasIndex(e => e.BrandId, "ix_agent_bank_infos_brand_id");

            entity.HasIndex(e => e.PaymentChannelId, "ix_agent_bank_infos_payment_channel_id");

            entity.HasIndex(e => e.PlayerCode, "ix_agent_bank_infos_player_code");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.AgentId).HasColumnName("agent_id");
            entity.Property(e => e.BankType).HasColumnName("bank_type");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.CreatedByUsername)
                .HasMaxLength(32)
                .HasColumnName("created_by_username");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
            entity.Property(e => e.Detail)
                .HasColumnType("jsonb")
                .HasColumnName("detail");
            entity.Property(e => e.PaymentChannelId).HasColumnName("payment_channel_id");
            entity.Property(e => e.PlayerCode)
                .HasMaxLength(16)
                .HasColumnName("player_code");
            entity.Property(e => e.UpdatedByUsername)
                .HasMaxLength(32)
                .HasColumnName("updated_by_username");
            entity.Property(e => e.UpdatedOn).HasColumnName("updated_on");

            entity.HasOne(d => d.Brand).WithMany(p => p.AgentBankInfos)
                .HasForeignKey(d => d.BrandId)
                .HasConstraintName("fk_agent_bank_infos_brands_brand_id");

            entity.HasOne(d => d.PaymentChannel).WithMany(p => p.AgentBankInfos)
                .HasForeignKey(d => d.PaymentChannelId)
                .HasConstraintName("fk_agent_bank_infos_payment_channels_payment_channel_id");

            entity.HasOne(d => d.PlayerCodeNavigation).WithMany(p => p.AgentBankInfos)
                .HasForeignKey(d => d.PlayerCode)
                .HasConstraintName("fk_agent_bank_infos_players_player_temp_id");
        });

        modelBuilder.Entity<AgentClearCommissionRecord>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_agent_clear_commission_records_id");

            entity.ToTable("agent_clear_commission_records", "dbo");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.AgentDividendId).HasColumnName("agent_dividend_id");
            entity.Property(e => e.ClearByUserId).HasColumnName("clear_by_user_id");
            entity.Property(e => e.CommissionAmount).HasColumnName("commission_amount");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
        });

        modelBuilder.Entity<AgentDailyMarketingStatistic>(entity =>
        {
            entity.HasKey(e => new { e.ReportDate, e.BrandId, e.AgentId }).HasName("pk_agent_daily_marketing_statistics");

            entity.ToTable("agent_daily_marketing_statistics", "dbo");

            entity.Property(e => e.ReportDate).HasColumnName("report_date");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.AgentId).HasColumnName("agent_id");
            entity.Property(e => e.GamingCount).HasColumnName("gaming_count");
            entity.Property(e => e.RegisterCount).HasColumnName("register_count");
        });

        modelBuilder.Entity<AgentDailyPaymentStatistic>(entity =>
        {
            entity.HasKey(e => new { e.ReportDate, e.BrandId, e.AgentId }).HasName("pk_agent_daily_payment_statistics");

            entity.ToTable("agent_daily_payment_statistics", "dbo");

            entity.Property(e => e.ReportDate).HasColumnName("report_date");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.AgentId).HasColumnName("agent_id");
            entity.Property(e => e.DailyDepositAmount).HasColumnName("daily_deposit_amount");
            entity.Property(e => e.DailyDepositHandlingFee).HasColumnName("daily_deposit_handling_fee");
            entity.Property(e => e.DailyWithdrawAmount).HasColumnName("daily_withdraw_amount");
            entity.Property(e => e.DailyWithdrawHandlingFee).HasColumnName("daily_withdraw_handling_fee");
            entity.Property(e => e.DepositPlayers)
                .HasDefaultValue(0)
                .HasColumnName("deposit_players");
            entity.Property(e => e.FirstDepositPlayers).HasColumnName("first_deposit_players");
            entity.Property(e => e.UndepositAgainPlayers).HasColumnName("undeposit_again_players");
        });

        modelBuilder.Entity<AgentDividend>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_agent_dividends_id");

            entity.ToTable("agent_dividends", "dbo");

            entity.HasIndex(e => new { e.AgentId, e.BrandId, e.CreatedOn }, "ix_agent_dividends_agent_id_brand_id_created_on");

            entity.HasIndex(e => new { e.AgentId, e.SentOn }, "ix_agent_dividends_agent_id_sent_on");

            entity.HasIndex(e => new { e.BrandId, e.From, e.To }, "ix_agent_dividends_brand_id_from_to");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActiveNumber)
                .HasDefaultValue(0)
                .HasColumnName("active_number");
            entity.Property(e => e.AgentAdjustAmount)
                .HasPrecision(18, 6)
                .HasColumnName("agent_adjust_amount");
            entity.Property(e => e.AgentDividendAmount)
                .HasPrecision(18, 6)
                .HasColumnName("agent_dividend_amount");
            entity.Property(e => e.AgentDividendPercentage)
                .HasPrecision(9, 6)
                .HasColumnName("agent_dividend_percentage");
            entity.Property(e => e.AgentId).HasColumnName("agent_id");
            entity.Property(e => e.ArcadeWinLoss)
                .HasPrecision(18, 6)
                .HasColumnName("arcade_win_loss");
            entity.Property(e => e.BeforeDividendAmount)
                .HasPrecision(18, 6)
                .HasColumnName("before_dividend_amount");
            entity.Property(e => e.BetAmount)
                .HasPrecision(18, 6)
                .HasColumnName("bet_amount");
            entity.Property(e => e.BonusAdjustAmount).HasColumnName("bonus_adjust_amount");
            entity.Property(e => e.BonusAmount)
                .HasPrecision(18, 6)
                .HasColumnName("bonus_amount");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.CardGameWinLoss)
                .HasPrecision(18, 6)
                .HasColumnName("card_game_win_loss");
            entity.Property(e => e.CompanyAdjustAmount)
                .HasPrecision(18, 6)
                .HasColumnName("company_adjust_amount");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
            entity.Property(e => e.DepositAmount)
                .HasPrecision(18, 6)
                .HasColumnName("deposit_amount");
            entity.Property(e => e.DepositHandlingFee)
                .HasPrecision(18, 6)
                .HasColumnName("deposit_handling_fee");
            entity.Property(e => e.ESportsWinLoss)
                .HasPrecision(18, 6)
                .HasColumnName("e_sports_win_loss");
            entity.Property(e => e.FishingWinLoss)
                .HasPrecision(18, 6)
                .HasColumnName("fishing_win_loss");
            entity.Property(e => e.From).HasColumnName("from");
            entity.Property(e => e.LiveDealerWinLoss)
                .HasPrecision(18, 6)
                .HasColumnName("live_dealer_win_loss");
            entity.Property(e => e.LotteryWinLoss)
                .HasPrecision(18, 6)
                .HasColumnName("lottery_win_loss");
            entity.Property(e => e.NegativeAgentDividendCarryForward)
                .HasDefaultValue(true)
                .HasColumnName("negative_agent_dividend_carry_forward");
            entity.Property(e => e.NetProfit)
                .HasPrecision(18, 6)
                .HasColumnName("net_profit");
            entity.Property(e => e.NoIncludeNetProfitAgentAdjustAmount)
                .HasPrecision(18, 6)
                .HasColumnName("no_include_net_profit_agent_adjust_amount");
            entity.Property(e => e.NoIncludeNetProfitBonusAdjustAmount)
                .HasPrecision(18, 6)
                .HasColumnName("no_include_net_profit_bonus_adjust_amount");
            entity.Property(e => e.NoIncludeNetProfitCompanyAdjustAmount)
                .HasPrecision(18, 6)
                .HasColumnName("no_include_net_profit_company_adjust_amount");
            entity.Property(e => e.OriginalTurnover)
                .HasPrecision(18, 6)
                .HasColumnName("original_turnover");
            entity.Property(e => e.PromotionAmount)
                .HasPrecision(18, 6)
                .HasColumnName("promotion_amount");
            entity.Property(e => e.RebateAmount)
                .HasPrecision(18, 6)
                .HasColumnName("rebate_amount");
            entity.Property(e => e.ReferencedAgentDividendId).HasColumnName("referenced_agent_dividend_id");
            entity.Property(e => e.SentOn).HasColumnName("sent_on");
            entity.Property(e => e.SlotWinLoss)
                .HasPrecision(18, 6)
                .HasColumnName("slot_win_loss");
            entity.Property(e => e.SportsWinLoss)
                .HasPrecision(18, 6)
                .HasColumnName("sports_win_loss");
            entity.Property(e => e.TableGameWinLoss)
                .HasPrecision(18, 6)
                .HasColumnName("table_game_win_loss");
            entity.Property(e => e.To).HasColumnName("to");
            entity.Property(e => e.Turnover)
                .HasPrecision(18, 6)
                .HasColumnName("turnover");
            entity.Property(e => e.ValidBetAmount)
                .HasPrecision(18, 6)
                .HasColumnName("valid_bet_amount");
            entity.Property(e => e.VirtualSportsWinLoss)
                .HasPrecision(18, 6)
                .HasColumnName("virtual_sports_win_loss");
            entity.Property(e => e.WinLossAmount)
                .HasPrecision(18, 6)
                .HasColumnName("win_loss_amount");
            entity.Property(e => e.WithdrawHandlingFee)
                .HasPrecision(18, 6)
                .HasColumnName("withdraw_handling_fee");
            entity.Property(e => e.WithdrawalAmount)
                .HasPrecision(18, 6)
                .HasColumnName("withdrawal_amount");
        });

        modelBuilder.Entity<AgentDividendCondition>(entity =>
        {
            entity.HasKey(e => new { e.Rank, e.AgentId }).HasName("pk_agent_dividend_conditions_rank_agent_id");

            entity.ToTable("agent_dividend_conditions", "dbo");

            entity.HasIndex(e => e.AgentId, "ix_agent_dividend_conditions_agent_id");

            entity.Property(e => e.Rank).HasColumnName("rank");
            entity.Property(e => e.AgentId).HasColumnName("agent_id");
            entity.Property(e => e.ActiveNumber).HasColumnName("active_number");
            entity.Property(e => e.ContractId).HasColumnName("contract_id");
            entity.Property(e => e.DividendPercentage)
                .HasPrecision(9, 6)
                .HasColumnName("dividend_percentage");
            entity.Property(e => e.NetProfit)
                .HasPrecision(18, 6)
                .HasColumnName("net_profit");
            entity.Property(e => e.WinLossAmount)
                .HasPrecision(18, 6)
                .HasColumnName("win_loss_amount");

            entity.HasOne(d => d.Agent).WithMany(p => p.AgentDividendConditions)
                .HasForeignKey(d => d.AgentId)
                .HasConstraintName("fk_agents_dividend_conditions_agent_id");
        });

        modelBuilder.Entity<AgentDividendContract>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_agent_dividend_contracts_id");

            entity.ToTable("agent_dividend_contracts", "dbo");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.AgentId).HasColumnName("agent_id");
            entity.Property(e => e.BetDays).HasColumnName("bet_days");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.ContractDividendType).HasColumnName("contract_dividend_type");
            entity.Property(e => e.ContractStatus).HasColumnName("contract_status");
            entity.Property(e => e.CreatedByUsername)
                .HasMaxLength(64)
                .HasColumnName("created_by_username");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
            entity.Property(e => e.DefaultBrandContractId).HasColumnName("default_brand_contract_id");
            entity.Property(e => e.DepositAmount)
                .HasPrecision(18, 6)
                .HasColumnName("deposit_amount");
            entity.Property(e => e.GameTypes)
                .HasDefaultValueSql("ARRAY[]::text[]")
                .HasColumnName("game_types");
            entity.Property(e => e.GradeIntervalLimit)
                .HasPrecision(18, 6)
                .HasColumnName("grade_interval_limit");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasColumnName("name");
            entity.Property(e => e.UpdatedByUsername)
                .HasMaxLength(64)
                .HasColumnName("updated_by_username");
            entity.Property(e => e.UpdatedOn).HasColumnName("updated_on");
            entity.Property(e => e.ValidBetAmount)
                .HasPrecision(18, 6)
                .HasColumnName("valid_bet_amount");
        });

        modelBuilder.Entity<AgentDividendMultipleLayer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_agent_dividend_multiple_layers_id");

            entity.ToTable("agent_dividend_multiple_layers", "dbo");

            entity.HasIndex(e => e.AgentDividendId, "ix_agent_dividend_multiple_layers_agent_dividend_id");

            entity.HasIndex(e => new { e.AgentId, e.DividendProviderAgentId }, "ix_agent_dividend_multiple_layers_agent_id_dividend_provider_ag");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActualDividendPercentage)
                .HasPrecision(18, 6)
                .HasColumnName("actual_dividend_percentage");
            entity.Property(e => e.AgentCoveredBonus)
                .HasPrecision(18, 6)
                .HasColumnName("agent_covered_bonus");
            entity.Property(e => e.AgentCoveredBonusAdjust)
                .HasPrecision(18, 6)
                .HasColumnName("agent_covered_bonus_adjust");
            entity.Property(e => e.AgentDividendId).HasColumnName("agent_dividend_id");
            entity.Property(e => e.AgentDividendPercentage)
                .HasPrecision(18, 6)
                .HasColumnName("agent_dividend_percentage");
            entity.Property(e => e.AgentDividendSnapshotId).HasColumnName("agent_dividend_snapshot_id");
            entity.Property(e => e.AgentId).HasColumnName("agent_id");
            entity.Property(e => e.Dividend)
                .HasPrecision(18, 6)
                .HasColumnName("dividend");
            entity.Property(e => e.DividendProviderAgentId).HasColumnName("dividend_provider_agent_id");
            entity.Property(e => e.DividendProviderId)
                .HasDefaultValue(0)
                .HasColumnName("dividend_provider_id");
            entity.Property(e => e.Layer).HasColumnName("layer");

            entity.HasOne(d => d.AgentDividend).WithMany(p => p.AgentDividendMultipleLayers)
                .HasForeignKey(d => d.AgentDividendId)
                .HasConstraintName("fk_agents_dividends_agent_dividend_multiple_layers_agent_divide");
        });

        modelBuilder.Entity<AgentDividendProductFee>(entity =>
        {
            entity.HasKey(e => e.AgentDividendId).HasName("pk_agent_dividend_product_fees_id");

            entity.ToTable("agent_dividend_product_fees", "dbo");

            entity.HasIndex(e => e.AgentDividendId, "ix_agent_dividend_product_fees_agent_dividend_id");

            entity.Property(e => e.AgentDividendId).HasColumnName("agent_dividend_id");
            entity.Property(e => e.AgentId).HasColumnName("agent_id");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.CardGamePercentage)
                .HasPrecision(18, 6)
                .HasColumnName("card_game_percentage");
            entity.Property(e => e.CardGameWinLossAmount)
                .HasPrecision(18, 6)
                .HasColumnName("card_game_win_loss_amount");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
            entity.Property(e => e.From)
                .HasDefaultValueSql("'-infinity'::timestamp with time zone")
                .HasColumnName("from");
            entity.Property(e => e.LiveDealerPercentage)
                .HasPrecision(18, 6)
                .HasColumnName("live_dealer_percentage");
            entity.Property(e => e.LiveDealerWinLossAmount)
                .HasPrecision(18, 6)
                .HasColumnName("live_dealer_win_loss_amount");
            entity.Property(e => e.LotteryPercentage)
                .HasPrecision(18, 6)
                .HasColumnName("lottery_percentage");
            entity.Property(e => e.LotteryWinLossAmount)
                .HasPrecision(18, 6)
                .HasColumnName("lottery_win_loss_amount");
            entity.Property(e => e.SlotPercentage)
                .HasPrecision(18, 6)
                .HasColumnName("slot_percentage");
            entity.Property(e => e.SlotWinLossAmount)
                .HasPrecision(18, 6)
                .HasColumnName("slot_win_loss_amount");
            entity.Property(e => e.SportsPercentage)
                .HasPrecision(18, 6)
                .HasColumnName("sports_percentage");
            entity.Property(e => e.SportsWinLossAmount)
                .HasPrecision(18, 6)
                .HasColumnName("sports_win_loss_amount");
            entity.Property(e => e.To)
                .HasDefaultValueSql("'-infinity'::timestamp with time zone")
                .HasColumnName("to");
            entity.Property(e => e.VirtualSportsPercentage)
                .HasPrecision(18, 6)
                .HasColumnName("virtual_sports_percentage");
            entity.Property(e => e.VirtualSportsWinLossAmount)
                .HasPrecision(18, 6)
                .HasColumnName("virtual_sports_win_loss_amount");
        });

        modelBuilder.Entity<AgentDividendRecord>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_agent_dividend_records_id");

            entity.ToTable("agent_dividend_records", "dbo");

            entity.HasIndex(e => new { e.BrandId, e.AgentId }, "ix_agent_dividend_records_brand_id_agent_id");

            entity.HasIndex(e => e.AgentDividendId, "ux_agent_dividend_records").IsUnique();

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.ActualAgentDividendAmount)
                .HasPrecision(18, 6)
                .HasColumnName("actual_agent_dividend_amount");
            entity.Property(e => e.AgentDividendAmount)
                .HasPrecision(18, 6)
                .HasColumnName("agent_dividend_amount");
            entity.Property(e => e.AgentDividendId).HasColumnName("agent_dividend_id");
            entity.Property(e => e.AgentId).HasColumnName("agent_id");
            entity.Property(e => e.ApprovedOn).HasColumnName("approved_on");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
            entity.Property(e => e.NegativeAgentDividendAmount)
                .HasPrecision(18, 6)
                .HasColumnName("negative_agent_dividend_amount");
            entity.Property(e => e.NegativeAgentDividendCarryForward)
                .HasDefaultValue(false)
                .HasColumnName("negative_agent_dividend_carry_forward");
            entity.Property(e => e.Remark).HasColumnName("remark");
            entity.Property(e => e.SentByUsername)
                .HasMaxLength(64)
                .HasColumnName("sent_by_username");
            entity.Property(e => e.Status)
                .HasDefaultValue((short)0)
                .HasColumnName("status");
            entity.Property(e => e.UpdatedOn)
                .HasDefaultValueSql("'-infinity'::timestamp with time zone")
                .HasColumnName("updated_on");
        });

        modelBuilder.Entity<AgentDividendSnapshot>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_agent_dividend_snapshots_id");

            entity.ToTable("agent_dividend_snapshots", "dbo");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
            entity.Property(e => e.Data)
                .HasColumnType("jsonb")
                .HasColumnName("data");
        });

        modelBuilder.Entity<AgentDomain>(entity =>
        {
            entity.HasKey(e => new { e.AgentId, e.DomainName }).HasName("pk_agent_domains");

            entity.ToTable("agent_domains", "dbo");

            entity.Property(e => e.AgentId).HasColumnName("agent_id");
            entity.Property(e => e.DomainName)
                .HasMaxLength(256)
                .HasColumnName("domain_name");

            entity.HasOne(d => d.Agent).WithMany(p => p.AgentDomains)
                .HasForeignKey(d => d.AgentId)
                .HasConstraintName("fk_agent_domains_agents_agent_id");
        });

        modelBuilder.Entity<AgentEventSource>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_agent_event_source");

            entity.ToTable("agent_event_source", "dbo");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Action).HasColumnName("action");
            entity.Property(e => e.AgentId).HasColumnName("agent_id");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.ChangeSets)
                .HasColumnType("jsonb")
                .HasColumnName("change_sets");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
            entity.Property(e => e.ModifyUser).HasColumnName("modify_user");
        });

        modelBuilder.Entity<AgentLoginRecord>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_agent_login_records");

            entity.ToTable("agent_login_records", "dbo");

            entity.HasIndex(e => e.AgentId, "ix_agent_login_records_agent_id");

            entity.HasIndex(e => e.BrandId, "ix_agent_login_records_brand_id");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.AgentId).HasColumnName("agent_id");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
            entity.Property(e => e.ExpiredOn).HasColumnName("expired_on");
            entity.Property(e => e.IpAddress).HasColumnName("ip_address");
            entity.Property(e => e.Status).HasColumnName("status");

            entity.HasOne(d => d.Agent).WithMany(p => p.AgentLoginRecords)
                .HasForeignKey(d => d.AgentId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_agent_login_records_agent_id");

            entity.HasOne(d => d.Brand).WithMany(p => p.AgentLoginRecords)
                .HasForeignKey(d => d.BrandId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_agent_login_records_brands_brand_id");
        });

        modelBuilder.Entity<AgentProductFee>(entity =>
        {
            entity.HasKey(e => e.AgentId).HasName("pk_agent_product_fees");

            entity.ToTable("agent_product_fees", "dbo");

            entity.Property(e => e.AgentId)
                .ValueGeneratedNever()
                .HasColumnName("agent_id");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.CreatedByUsername).HasColumnName("created_by_username");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
            entity.Property(e => e.CurrentCardGamePercentage)
                .HasPrecision(18, 6)
                .HasColumnName("current_card_game_percentage");
            entity.Property(e => e.CurrentLiveDealerPercentage)
                .HasPrecision(18, 6)
                .HasColumnName("current_live_dealer_percentage");
            entity.Property(e => e.CurrentLotteryPercentage)
                .HasPrecision(18, 6)
                .HasColumnName("current_lottery_percentage");
            entity.Property(e => e.CurrentSlotPercentage)
                .HasPrecision(18, 6)
                .HasColumnName("current_slot_percentage");
            entity.Property(e => e.CurrentSportsPercentage)
                .HasPrecision(18, 6)
                .HasColumnName("current_sports_percentage");
            entity.Property(e => e.CurrentVirtualSportsPercentage)
                .HasPrecision(18, 6)
                .HasColumnName("current_virtual_sports_percentage");
            entity.Property(e => e.NextCardGamePercentage)
                .HasPrecision(18, 6)
                .HasColumnName("next_card_game_percentage");
            entity.Property(e => e.NextLiveDealerPercentage)
                .HasPrecision(18, 6)
                .HasColumnName("next_live_dealer_percentage");
            entity.Property(e => e.NextLotteryPercentage)
                .HasPrecision(18, 6)
                .HasColumnName("next_lottery_percentage");
            entity.Property(e => e.NextSlotPercentage)
                .HasPrecision(18, 6)
                .HasColumnName("next_slot_percentage");
            entity.Property(e => e.NextSportsPercentage)
                .HasPrecision(18, 6)
                .HasColumnName("next_sports_percentage");
            entity.Property(e => e.NextVirtualSportsPercentage)
                .HasPrecision(18, 6)
                .HasColumnName("next_virtual_sports_percentage");
            entity.Property(e => e.PreviousCardGamePercentage)
                .HasPrecision(18, 6)
                .HasColumnName("previous_card_game_percentage");
            entity.Property(e => e.PreviousLiveDealerPercentage)
                .HasPrecision(18, 6)
                .HasColumnName("previous_live_dealer_percentage");
            entity.Property(e => e.PreviousLotteryPercentage)
                .HasPrecision(18, 6)
                .HasColumnName("previous_lottery_percentage");
            entity.Property(e => e.PreviousSlotPercentage)
                .HasPrecision(18, 6)
                .HasColumnName("previous_slot_percentage");
            entity.Property(e => e.PreviousSportsPercentage)
                .HasPrecision(18, 6)
                .HasColumnName("previous_sports_percentage");
            entity.Property(e => e.PreviousVirtualSportsPercentage)
                .HasPrecision(18, 6)
                .HasColumnName("previous_virtual_sports_percentage");
            entity.Property(e => e.UpdatedByUsername).HasColumnName("updated_by_username");
            entity.Property(e => e.UpdatedOn).HasColumnName("updated_on");
        });

        modelBuilder.Entity<AgentTransaction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_agent_transactions");

            entity.ToTable("agent_transactions", "dbo");

            entity.HasIndex(e => e.AgentId, "ix_agent_transactions_agent_id");

            entity.HasIndex(e => e.BrandId, "ix_agent_transactions_brand_id");

            entity.HasIndex(e => e.WalletId, "ix_agent_transactions_wallet_id");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.AgentId).HasColumnName("agent_id");
            entity.Property(e => e.Amount)
                .HasPrecision(18, 6)
                .HasColumnName("amount");
            entity.Property(e => e.Balance)
                .HasPrecision(18, 6)
                .HasColumnName("balance");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.ExternalTransactionId).HasColumnName("external_transaction_id");
            entity.Property(e => e.LockAmount)
                .HasPrecision(18, 6)
                .HasColumnName("lock_amount");
            entity.Property(e => e.LockedBalance)
                .HasPrecision(18, 6)
                .HasColumnName("locked_balance");
            entity.Property(e => e.RecordedOn).HasColumnName("recorded_on");
            entity.Property(e => e.SentOn).HasColumnName("sent_on");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.WalletId).HasColumnName("wallet_id");

            entity.HasOne(d => d.Brand).WithMany(p => p.AgentTransactions)
                .HasForeignKey(d => d.BrandId)
                .HasConstraintName("fk_agent_transactions_brands_brand_id");

            entity.HasOne(d => d.Wallet).WithMany(p => p.AgentTransactions)
                .HasForeignKey(d => d.WalletId)
                .HasConstraintName("fk_agent_transaction_wallet_id");
        });

        modelBuilder.Entity<AgentWallet>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_agent_wallets");

            entity.ToTable("agent_wallets", "dbo");

            entity.HasIndex(e => e.AgentId, "ix_agent_wallets_agent_id");

            entity.HasIndex(e => e.CurrencyCode, "ix_agent_wallets_currency_code");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.AgentId).HasColumnName("agent_id");
            entity.Property(e => e.Balance)
                .HasPrecision(18, 6)
                .HasColumnName("balance");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(16)
                .HasColumnName("currency_code");
            entity.Property(e => e.UpdatedOn).HasColumnName("updated_on");

            entity.HasOne(d => d.Agent).WithMany(p => p.AgentWallets)
                .HasForeignKey(d => d.AgentId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_agent_wallet_agent_id");

            entity.HasOne(d => d.CurrencyCodeNavigation).WithMany(p => p.AgentWallets)
                .HasForeignKey(d => d.CurrencyCode)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_agent_wallets_currencies_currency_code");
        });

        modelBuilder.Entity<Announcement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_announcements");

            entity.ToTable("announcements", "dbo");

            entity.HasIndex(e => e.BrandId, "ix_announcements_brand_id");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.Content)
                .HasMaxLength(8000)
                .HasColumnName("content");
            entity.Property(e => e.CreatedByUsername)
                .HasMaxLength(32)
                .HasColumnName("created_by_username");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
            entity.Property(e => e.DisplayOrder).HasColumnName("display_order");
            entity.Property(e => e.From).HasColumnName("from");
            entity.Property(e => e.Localization)
                .HasDefaultValueSql("'{}'::jsonb")
                .HasColumnType("jsonb")
                .HasColumnName("localization");
            entity.Property(e => e.Remarks)
                .HasMaxLength(512)
                .HasColumnName("remarks");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Subject)
                .HasMaxLength(256)
                .HasColumnName("subject");
            entity.Property(e => e.To).HasColumnName("to");
            entity.Property(e => e.Type)
                .HasDefaultValueSql("'Marquee'::text")
                .HasColumnName("type");
            entity.Property(e => e.UpdatedByUsername)
                .HasMaxLength(32)
                .HasColumnName("updated_by_username");
            entity.Property(e => e.UpdatedOn).HasColumnName("updated_on");
            entity.Property(e => e.VerifiedByUsername)
                .HasMaxLength(32)
                .HasColumnName("verified_by_username");

            entity.HasOne(d => d.Brand).WithMany(p => p.Announcements)
                .HasForeignKey(d => d.BrandId)
                .HasConstraintName("fk_announcements_brands_brand_id");
        });

        modelBuilder.Entity<ArticleForm>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_article_forms");

            entity.ToTable("article_forms", "dbo");

            entity.HasIndex(e => e.BrandId, "ix_article_forms_brand_id");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.LocalizedArticles)
                .HasColumnType("jsonb")
                .HasColumnName("localized_articles");
            entity.Property(e => e.Modifier).HasColumnName("modifier");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.UpdatedOn).HasColumnName("updated_on");

            entity.HasOne(d => d.Brand).WithMany(p => p.ArticleForms)
                .HasForeignKey(d => d.BrandId)
                .HasConstraintName("fk_article_forms_brands");
        });

        modelBuilder.Entity<BackgroundPaymentStatisticsSetting>(entity =>
        {
            entity.HasKey(e => e.RecordKey).HasName("pk_background_payment_statistics_settings");

            entity.ToTable("background_payment_statistics_settings", "dbo");

            entity.Property(e => e.RecordKey).HasColumnName("record_key");
            entity.Property(e => e.ProcessedTime).HasColumnName("processed_time");
        });

        modelBuilder.Entity<Banner>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_banners");

            entity.ToTable("banners", "dbo");

            entity.HasIndex(e => e.BrandId, "ix_banners_brand_id");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.BeginTime).HasColumnName("begin_time");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.CreatedByUserName).HasColumnName("created_by_user_name");
            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_on");
            entity.Property(e => e.DisplayOrder)
                .HasDefaultValue(1)
                .HasColumnName("display_order");
            entity.Property(e => e.EndTime).HasColumnName("end_time");
            entity.Property(e => e.IsEnabled)
                .HasDefaultValue(false)
                .HasColumnName("is_enabled");
            entity.Property(e => e.Localization)
                .HasColumnType("jsonb")
                .HasColumnName("localization");
            entity.Property(e => e.Remark).HasColumnName("remark");
            entity.Property(e => e.Status)
                .HasDefaultValue(0)
                .HasColumnName("status");
            entity.Property(e => e.Title).HasColumnName("title");
            entity.Property(e => e.UpdatedByUserName).HasColumnName("updated_by_user_name");
            entity.Property(e => e.UpdatedOn)
                .HasDefaultValueSql("now()")
                .HasColumnName("updated_on");

            entity.HasOne(d => d.Brand).WithMany(p => p.Banners)
                .HasForeignKey(d => d.BrandId)
                .HasConstraintName("fk_banners_brands_brand_id");
        });

        modelBuilder.Entity<BetLimit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_bet_limits");

            entity.ToTable("bet_limits", "dbo");

            entity.HasIndex(e => e.CurrencyCode, "ix_bet_limits_currency_code");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedByUsername)
                .HasMaxLength(32)
                .HasColumnName("created_by_username");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(16)
                .HasColumnName("currency_code");
            entity.Property(e => e.MaxBet).HasColumnName("max_bet");
            entity.Property(e => e.MaxBetPerMatch).HasColumnName("max_bet_per_match");
            entity.Property(e => e.MinBet).HasColumnName("min_bet");
            entity.Property(e => e.UpdatedByUsername)
                .HasMaxLength(32)
                .HasColumnName("updated_by_username");
            entity.Property(e => e.UpdatedOn).HasColumnName("updated_on");

            entity.HasOne(d => d.CurrencyCodeNavigation).WithMany(p => p.BetLimits)
                .HasForeignKey(d => d.CurrencyCode)
                .HasConstraintName("fk_bet_limits_currencies_currency_code");
        });

        modelBuilder.Entity<Brand>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_brands");

            entity.ToTable("brands", "dbo");

            entity.HasIndex(e => new { e.Code, e.Name, e.Description, e.OperationalEmail }, "ix_brands_code_name_description_operational_email");

            entity.HasIndex(e => e.LicenseeId, "ix_brands_licensee_id");

            entity.HasIndex(e => new { e.Code, e.Name, e.Description, e.OperationalEmail }, "ix_trgm_brands_code_name_description_operational_email")
                .HasMethod("gin")
                .HasOperators(new[] { "gin_trgm_ops", "gin_trgm_ops", "gin_trgm_ops", "gin_trgm_ops" });

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.AgentDividendType)
                .HasDefaultValue((short)0)
                .HasColumnName("agent_dividend_type");
            entity.Property(e => e.ApiKey)
                .HasMaxLength(64)
                .HasColumnName("api_key");
            entity.Property(e => e.AutoClearWageringRequirement)
                .HasDefaultValue(false)
                .HasColumnName("auto_clear_wagering_requirement");
            entity.Property(e => e.AutoClearWageringRequirementBalance)
                .HasPrecision(18, 6)
                .HasColumnName("auto_clear_wagering_requirement_balance");
            entity.Property(e => e.AutoSentAgentBonus).HasColumnName("auto_sent_agent_bonus");
            entity.Property(e => e.AutoSentPlayerBonus).HasColumnName("auto_sent_player_bonus");
            entity.Property(e => e.CheckDividendActiveCount)
                .HasDefaultValue(false)
                .HasColumnName("check_dividend_active_count");
            entity.Property(e => e.ClientId)
                .HasMaxLength(128)
                .HasColumnName("client_id");
            entity.Property(e => e.Code)
                .HasMaxLength(16)
                .HasColumnName("code");
            entity.Property(e => e.CreatedByUsername)
                .HasMaxLength(32)
                .HasColumnName("created_by_username");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
            entity.Property(e => e.CurrentSettlementFrom)
                .HasDefaultValueSql("'0001-01-01 00:00:00+00'::timestamp with time zone")
                .HasColumnName("current_settlement_from");
            entity.Property(e => e.CurrentSettlementTo)
                .HasDefaultValueSql("'0001-01-01 00:00:00+00'::timestamp with time zone")
                .HasColumnName("current_settlement_to");
            entity.Property(e => e.DepositHandlingFeeRateTenPercentile).HasColumnName("deposit_handling_fee_rate_ten_percentile");
            entity.Property(e => e.DepositPaymentLockEnabled)
                .HasDefaultValue(false)
                .HasColumnName("deposit_payment_lock_enabled");
            entity.Property(e => e.Description)
                .HasMaxLength(256)
                .HasColumnName("description");
            entity.Property(e => e.EnableAgentSms)
                .HasDefaultValue(false)
                .HasColumnName("enable_agent_sms");
            entity.Property(e => e.EnableBankInfoRegisterFlow)
                .HasDefaultValue(false)
                .HasColumnName("enable_bank_info_register_flow");
            entity.Property(e => e.EnableEmailRegisterFlow)
                .HasDefaultValue(false)
                .HasColumnName("enable_email_register_flow");
            entity.Property(e => e.EnablePlatformAccountFundCheck)
                .HasDefaultValue(false)
                .HasColumnName("enable_platform_account_fund_check");
            entity.Property(e => e.EnablePlayerAgent)
                .HasDefaultValue(false)
                .HasColumnName("enable_player_agent");
            entity.Property(e => e.EnablePlayerIdentity)
                .HasDefaultValue(false)
                .HasColumnName("enable_player_identity");
            entity.Property(e => e.EnableSms)
                .HasDefaultValue(false)
                .HasColumnName("enable_sms");
            entity.Property(e => e.EnableSmsRegisterFlow)
                .HasDefaultValue(false)
                .HasColumnName("enable_sms_register_flow");
            entity.Property(e => e.LicenseeId).HasColumnName("licensee_id");
            entity.Property(e => e.LogoInfo)
                .HasColumnType("jsonb")
                .HasColumnName("logo_info");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.NextSettlementFrom)
                .HasDefaultValueSql("'0001-01-01 00:00:00+00'::timestamp with time zone")
                .HasColumnName("next_settlement_from");
            entity.Property(e => e.NextSettlementTo)
                .HasDefaultValueSql("'0001-01-01 00:00:00+00'::timestamp with time zone")
                .HasColumnName("next_settlement_to");
            entity.Property(e => e.OperationalEmail)
                .HasMaxLength(128)
                .HasColumnName("operational_email");
            entity.Property(e => e.PlatformCharge)
                .HasPrecision(9, 6)
                .HasColumnName("platform_charge");
            entity.Property(e => e.PlayerRegisterFlowSettings)
                .HasColumnType("jsonb")
                .HasColumnName("player_register_flow_settings");
            entity.Property(e => e.PreviousSettlementFrom)
                .HasDefaultValueSql("'0001-01-01 00:00:00+00'::timestamp with time zone")
                .HasColumnName("previous_settlement_from");
            entity.Property(e => e.PreviousSettlementTo)
                .HasDefaultValueSql("'0001-01-01 00:00:00+00'::timestamp with time zone")
                .HasColumnName("previous_settlement_to");
            entity.Property(e => e.SecretKey)
                .HasMaxLength(32)
                .HasColumnName("secret_key");
            entity.Property(e => e.SettlementDay).HasColumnName("settlement_day");
            entity.Property(e => e.SettlementIntervalType)
                .HasDefaultValue((short)0)
                .HasColumnName("settlement_interval_type");
            entity.Property(e => e.SmsVendorCode).HasColumnName("sms_vendor_code");
            entity.Property(e => e.SmsVendorSettings)
                .HasColumnType("jsonb")
                .HasColumnName("sms_vendor_settings");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.TimeSpanMinutes)
                .HasDefaultValue(480)
                .HasColumnName("time_span_minutes");
            entity.Property(e => e.TimeZoneId)
                .HasMaxLength(256)
                .HasColumnName("time_zone_id");
            entity.Property(e => e.UpdatedByUsername)
                .HasMaxLength(32)
                .HasColumnName("updated_by_username");
            entity.Property(e => e.UpdatedOn).HasColumnName("updated_on");
            entity.Property(e => e.WithdrawHandlingFeeRateTenPercentile).HasColumnName("withdraw_handling_fee_rate_ten_percentile");

            entity.HasOne(d => d.Licensee).WithMany(p => p.Brands)
                .HasForeignKey(d => d.LicenseeId)
                .HasConstraintName("fk_brands_licensees_licensee_id");
        });

        modelBuilder.Entity<BrandAgentDividendCondition>(entity =>
        {
            entity.HasKey(e => new { e.Rank, e.BrandId }).HasName("pk_brand_agent_dividend_conditions_rank_brand_id");

            entity.ToTable("brand_agent_dividend_conditions", "dbo");

            entity.HasIndex(e => e.BrandId, "ix_brand_agent_dividend_conditions_brand_id");

            entity.Property(e => e.Rank).HasColumnName("rank");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.ActiveNumber).HasColumnName("active_number");
            entity.Property(e => e.DividendPercentage)
                .HasPrecision(9, 6)
                .HasColumnName("dividend_percentage");
            entity.Property(e => e.NetProfit)
                .HasPrecision(18, 6)
                .HasColumnName("net_profit");

            entity.HasOne(d => d.Brand).WithMany(p => p.BrandAgentDividendConditions)
                .HasForeignKey(d => d.BrandId)
                .HasConstraintName("fk_brand_agent_dividend_conditions_brands_brand_id");
        });

        modelBuilder.Entity<BrandAllAgent>(entity =>
        {
            entity.HasKey(e => e.BrandId).HasName("pk_brand_all_agents");

            entity.ToTable("brand_all_agents", "dbo");

            entity.Property(e => e.BrandId)
                .ValueGeneratedNever()
                .HasColumnName("brand_id");
        });

        modelBuilder.Entity<BrandAllAgentGameType>(entity =>
        {
            entity.HasKey(e => new { e.BrandId, e.AllAgentGameType }).HasName("pk_brand_all_agent_game_types");

            entity.ToTable("brand_all_agent_game_types", "dbo");

            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.AllAgentGameType).HasColumnName("all_agent_game_type");
            entity.Property(e => e.HasValidBet).HasColumnName("has_valid_bet");
            entity.Property(e => e.HasWinLoss).HasColumnName("has_win_loss");
            entity.Property(e => e.Switch).HasColumnName("switch");
        });

        modelBuilder.Entity<BrandAllAgentGameTypeCondition>(entity =>
        {
            entity.HasKey(e => new { e.BrandId, e.AllAgentGameType, e.Rank, e.AllAgentRebateType }).HasName("pk_brand_all_agent_game_type_conditions");

            entity.ToTable("brand_all_agent_game_type_conditions", "dbo");

            entity.HasIndex(e => new { e.BrandId, e.AllAgentGameType, e.Rank, e.AllAgentRebateType }, "pk_brand_all_agent_game_type_conditions_ccnew").IsUnique();

            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.AllAgentGameType).HasColumnName("all_agent_game_type");
            entity.Property(e => e.Rank).HasColumnName("rank");
            entity.Property(e => e.AllAgentRebateType).HasColumnName("all_agent_rebate_type");
            entity.Property(e => e.ActiveNumber).HasColumnName("active_number");
            entity.Property(e => e.NetProfit)
                .HasPrecision(18, 6)
                .HasColumnName("net_profit");
            entity.Property(e => e.RebatePercentage)
                .HasPrecision(18, 6)
                .HasColumnName("rebate_percentage");
        });

        modelBuilder.Entity<BrandAllAgentSetting>(entity =>
        {
            entity.HasKey(e => e.BrandId).HasName("pk_brand_all_agent_settings");

            entity.ToTable("brand_all_agent_settings", "dbo");

            entity.Property(e => e.BrandId)
                .ValueGeneratedNever()
                .HasColumnName("brand_id");
            entity.Property(e => e.SettlementIntervalType).HasColumnName("settlement_interval_type");
            entity.Property(e => e.Switch).HasColumnName("switch");
        });

        modelBuilder.Entity<BrandBetLimit>(entity =>
        {
            entity.HasKey(e => new { e.BrandId, e.BetLimitId }).HasName("pk_brand_bet_limits");

            entity.ToTable("brand_bet_limits", "dbo");

            entity.HasIndex(e => e.BetLimitId, "ix_brand_bet_limits_bet_limit_id");

            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.BetLimitId).HasColumnName("bet_limit_id");
            entity.Property(e => e.IsDefault).HasColumnName("is_default");

            entity.HasOne(d => d.BetLimit).WithMany(p => p.BrandBetLimits)
                .HasForeignKey(d => d.BetLimitId)
                .HasConstraintName("fk_brand_bet_limits_bet_limits_bet_limit_id");

            entity.HasOne(d => d.Brand).WithMany(p => p.BrandBetLimits)
                .HasForeignKey(d => d.BrandId)
                .HasConstraintName("fk_brand_bet_limits_brands_brand_id");
        });

        modelBuilder.Entity<BrandBucketType>(entity =>
        {
            entity.HasKey(e => e.BrandId).HasName("pk_brand_bucket_types");

            entity.ToTable("brand_bucket_types", "dbo");

            entity.Property(e => e.BrandId)
                .ValueGeneratedNever()
                .HasColumnName("brand_id");
            entity.Property(e => e.BucketTypes)
                .HasColumnType("jsonb")
                .HasColumnName("bucket_types");

            entity.HasOne(d => d.Brand).WithOne(p => p.BrandBucketType)
                .HasForeignKey<BrandBucketType>(d => d.BrandId)
                .HasConstraintName("fk_brands");
        });

        modelBuilder.Entity<BrandCommunication>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_brand_communications");

            entity.ToTable("brand_communications", "dbo");

            entity.HasIndex(e => e.BrandId, "ix_brand_communications_brand_id");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.AppId)
                .HasMaxLength(128)
                .HasColumnName("app_id");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.Phone)
                .HasMaxLength(32)
                .HasColumnName("phone");
            entity.Property(e => e.QrCodeUrl)
                .HasMaxLength(1024)
                .HasColumnName("qr_code_url");
            entity.Property(e => e.Type)
                .HasMaxLength(64)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("type");

            entity.HasOne(d => d.Brand).WithMany(p => p.BrandCommunications)
                .HasForeignKey(d => d.BrandId)
                .HasConstraintName("fk_brand_communications_brands_brand_id");
        });

        modelBuilder.Entity<BrandContract>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_brand_contracts_id");

            entity.ToTable("brand_contracts", "dbo");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.BetDays).HasColumnName("bet_days");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.ContractDividendType).HasColumnName("contract_dividend_type");
            entity.Property(e => e.ContractStatus).HasColumnName("contract_status");
            entity.Property(e => e.CreatedByUsername)
                .HasMaxLength(64)
                .HasColumnName("created_by_username");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
            entity.Property(e => e.DepositAmount)
                .HasPrecision(18, 6)
                .HasColumnName("deposit_amount");
            entity.Property(e => e.GameTypes).HasColumnName("game_types");
            entity.Property(e => e.GradeIntervalLimit)
                .HasPrecision(18, 6)
                .HasColumnName("grade_interval_limit");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasColumnName("name");
            entity.Property(e => e.UpdatedByUsername)
                .HasMaxLength(64)
                .HasColumnName("updated_by_username");
            entity.Property(e => e.UpdatedOn).HasColumnName("updated_on");
            entity.Property(e => e.ValidBetAmount)
                .HasPrecision(18, 6)
                .HasColumnName("valid_bet_amount");
        });

        modelBuilder.Entity<BrandContractCondition>(entity =>
        {
            entity.HasKey(e => new { e.Rank, e.BrandContractId }).HasName("pk_brand_contract_conditions_rank_brand_contract_id");

            entity.ToTable("brand_contract_conditions", "dbo");

            entity.HasIndex(e => e.BrandContractId, "ix_brand_contract_conditions_brand_contract_id");

            entity.Property(e => e.Rank).HasColumnName("rank");
            entity.Property(e => e.BrandContractId).HasColumnName("brand_contract_id");
            entity.Property(e => e.ActiveNumber).HasColumnName("active_number");
            entity.Property(e => e.DividendPercentage)
                .HasPrecision(9, 6)
                .HasColumnName("dividend_percentage");
            entity.Property(e => e.NetProfit)
                .HasPrecision(18, 6)
                .HasColumnName("net_profit");
            entity.Property(e => e.WinLossAmount)
                .HasPrecision(18, 6)
                .HasColumnName("win_loss_amount");

            entity.HasOne(d => d.BrandContract).WithMany(p => p.BrandContractConditions)
                .HasForeignKey(d => d.BrandContractId)
                .HasConstraintName("fk_brand_contract_conditions_brand_contract_brand_contract_id");
        });

        modelBuilder.Entity<BrandCurrency>(entity =>
        {
            entity.HasKey(e => new { e.BrandId, e.CurrencyCode }).HasName("pk_brand_currencies");

            entity.ToTable("brand_currencies", "dbo");

            entity.HasIndex(e => e.CurrencyCode, "ix_brand_currencies_currency_code");

            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(16)
                .HasColumnName("currency_code");
            entity.Property(e => e.BrandCurrencyCode)
                .HasMaxLength(32)
                .HasColumnName("brand_currency_code");

            entity.HasOne(d => d.Brand).WithMany(p => p.BrandCurrencies)
                .HasForeignKey(d => d.BrandId)
                .HasConstraintName("fk_brand_currencies_brands_brand_id");

            entity.HasOne(d => d.CurrencyCodeNavigation).WithMany(p => p.BrandCurrencies)
                .HasForeignKey(d => d.CurrencyCode)
                .HasConstraintName("fk_brand_currencies_currencies_currency_code");
        });

        modelBuilder.Entity<BrandDailyMarketingStatistic>(entity =>
        {
            entity.HasKey(e => new { e.ReportDate, e.BrandId }).HasName("pk_brand_daily_marketing_statistics");

            entity.ToTable("brand_daily_marketing_statistics", "dbo");

            entity.Property(e => e.ReportDate).HasColumnName("report_date");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.DirectlyPlayerGamingCount)
                .HasComment("無直屬代理的玩家遊戲人數")
                .HasColumnName("directly_player_gaming_count");
            entity.Property(e => e.DirectlyPlayerRegisterCount)
                .HasComment("無直屬代理的玩家註冊人數")
                .HasColumnName("directly_player_register_count");
            entity.Property(e => e.TotalPlayerGamingCount)
                .HasComment("玩家總遊戲人數")
                .HasColumnName("total_player_gaming_count");
            entity.Property(e => e.TotalPlayerRegisterCount)
                .HasComment("玩家總註冊人數")
                .HasColumnName("total_player_register_count");
        });

        modelBuilder.Entity<BrandDailyPaymentStatistic>(entity =>
        {
            entity.HasKey(e => new { e.ReportDate, e.BrandId }).HasName("pk_brand_daily_payment_statistics");

            entity.ToTable("brand_daily_payment_statistics", "dbo");

            entity.Property(e => e.ReportDate).HasColumnName("report_date");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.DailyDepositAmount).HasColumnName("daily_deposit_amount");
            entity.Property(e => e.DailyDepositApprovedCount).HasColumnName("daily_deposit_approved_count");
            entity.Property(e => e.DailyDepositHandlingFee).HasColumnName("daily_deposit_handling_fee");
            entity.Property(e => e.DailyDepositRejectCount).HasColumnName("daily_deposit_reject_count");
            entity.Property(e => e.DailyDepositTotalCount).HasColumnName("daily_deposit_total_count");
            entity.Property(e => e.DailyWithdrawAmount).HasColumnName("daily_withdraw_amount");
            entity.Property(e => e.DailyWithdrawHandlingFee).HasColumnName("daily_withdraw_handling_fee");
            entity.Property(e => e.DepositPlayers).HasColumnName("deposit_players");
            entity.Property(e => e.FirstDepositPlayers).HasColumnName("first_deposit_players");
            entity.Property(e => e.UndepositAgainPlayers).HasColumnName("undeposit_again_players");
        });

        modelBuilder.Entity<BrandDomain>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_brand_domains");

            entity.ToTable("brand_domains", "dbo");

            entity.HasIndex(e => e.BrandId, "ix_brand_domains_brand_id");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.Url)
                .HasMaxLength(128)
                .HasColumnName("url");

            entity.HasOne(d => d.Brand).WithMany(p => p.BrandDomains)
                .HasForeignKey(d => d.BrandId)
                .HasConstraintName("fk_brand_domains_brands_brand_id");
        });

        modelBuilder.Entity<BrandGame>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_brand_games");

            entity.ToTable("brand_games", "dbo");

            entity.HasIndex(e => new { e.BrandId, e.GameId }, "ak_brand_games_brand_id_game_id").IsUnique();

            entity.HasIndex(e => new { e.BrandId, e.GameId }, "ak_brand_games_brand_id_game_id_ccnew").IsUnique();

            entity.HasIndex(e => e.GameId, "ix_brand_games_game_id");

            entity.HasIndex(e => e.GameId, "ix_brand_games_game_id_ccnew");

            entity.HasIndex(e => e.Id, "pk_brand_games_ccnew").IsUnique();

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.DisplayOrder).HasColumnName("display_order");
            entity.Property(e => e.EffectiveBettingPercentage)
                .HasPrecision(18, 6)
                .HasColumnName("effective_betting_percentage");
            entity.Property(e => e.GameId).HasColumnName("game_id");
            entity.Property(e => e.Rebate).HasColumnName("rebate");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Tag).HasColumnName("tag");

            entity.HasOne(d => d.Brand).WithMany(p => p.BrandGames)
                .HasForeignKey(d => d.BrandId)
                .HasConstraintName("fk_brand_games_brands_brand_id");

            entity.HasOne(d => d.Game).WithMany(p => p.BrandGames)
                .HasForeignKey(d => d.GameId)
                .HasConstraintName("fk_brand_games_games_game_id");
        });

        modelBuilder.Entity<BrandGameCredit>(entity =>
        {
            entity.HasKey(e => new { e.Month, e.ResellerId, e.LicenseeId, e.BrandId }).HasName("pk_brand_game_credits");

            entity.ToTable("brand_game_credits", "dbo");

            entity.HasIndex(e => new { e.Month, e.BrandId }, "ix_brand_game_credits_brand_id");

            entity.HasIndex(e => new { e.Month, e.LicenseeId }, "ix_brand_game_credits_licensee_id");

            entity.HasIndex(e => e.Month, "ix_brand_game_credits_month");

            entity.HasIndex(e => new { e.Month, e.ResellerId }, "ix_brand_game_credits_reseller_id");

            entity.Property(e => e.Month)
                .HasDefaultValueSql("'1990-01-01'::date")
                .HasComment("月份")
                .HasColumnName("month");
            entity.Property(e => e.ResellerId)
                .HasComment("公司識別碼")
                .HasColumnName("reseller_id");
            entity.Property(e => e.LicenseeId)
                .HasComment("分公司識別碼")
                .HasColumnName("licensee_id");
            entity.Property(e => e.BrandId)
                .HasComment("平台識別碼")
                .HasColumnName("brand_id");
            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasComment("創建時間")
                .HasColumnName("created_on");
            entity.Property(e => e.CreditAmount)
                .HasPrecision(18, 6)
                .HasComment("上分額度")
                .HasColumnName("credit_amount");
            entity.Property(e => e.DebitAmount)
                .HasPrecision(18, 6)
                .HasComment("下分額度")
                .HasColumnName("debit_amount");
            entity.Property(e => e.InitialAmount)
                .HasPrecision(18, 6)
                .HasComment("初始額度")
                .HasColumnName("initial_amount");
            entity.Property(e => e.ProfitAmount)
                .HasPrecision(18, 6)
                .HasComment("利潤額度")
                .HasColumnName("profit_amount");
            entity.Property(e => e.UpdatedOn)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasComment("修改時間")
                .HasColumnName("updated_on");
        });

        modelBuilder.Entity<BrandGameCreditProfit>(entity =>
        {
            entity.HasKey(e => new { e.BrandId, e.Month, e.GameProviderId }).HasName("pk_brand_game_credit_profits");

            entity.ToTable("brand_game_credit_profits", "dbo");

            entity.HasIndex(e => new { e.BrandId, e.Month }, "ix_brand_game_credit_profits_brand_id");

            entity.Property(e => e.BrandId)
                .HasComment("平台識別碼")
                .HasColumnName("brand_id");
            entity.Property(e => e.Month)
                .HasDefaultValueSql("'1990-01-01'::date")
                .HasComment("月份")
                .HasColumnName("month");
            entity.Property(e => e.GameProviderId)
                .HasComment("遊戲供應商識別碼")
                .HasColumnName("game_provider_id");
            entity.Property(e => e.Bet)
                .HasPrecision(18, 6)
                .HasComment("下注")
                .HasColumnName("bet");
            entity.Property(e => e.Commission)
                .HasPrecision(18, 6)
                .HasComment("傭金")
                .HasColumnName("commission");
            entity.Property(e => e.Count)
                .HasDefaultValue(0)
                .HasComment("筆數")
                .HasColumnName("count");
            entity.Property(e => e.ProfitAmount)
                .HasPrecision(18, 6)
                .HasComment("利潤額度")
                .HasColumnName("profit_amount");
            entity.Property(e => e.Settle)
                .HasPrecision(18, 6)
                .HasComment("結算(包含本金)")
                .HasColumnName("settle");
            entity.Property(e => e.Turnover)
                .HasPrecision(18, 6)
                .HasComment("有效投注")
                .HasColumnName("turnover");
            entity.Property(e => e.ValidBet)
                .HasPrecision(18, 6)
                .HasComment("實際/有效下注")
                .HasColumnName("valid_bet");
            entity.Property(e => e.WinLoss)
                .HasPrecision(18, 6)
                .HasComment("玩家損益/淨利")
                .HasColumnName("win_loss");
        });

        modelBuilder.Entity<BrandGameCreditSuspSetting>(entity =>
        {
            entity.HasKey(e => e.BrandId).HasName("pk_brand_game_credit_susp_settings");

            entity.ToTable("brand_game_credit_susp_settings", "dbo");

            entity.Property(e => e.BrandId)
                .ValueGeneratedNever()
                .HasComment("平台識別碼")
                .HasColumnName("brand_id");
            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasComment("創建時間")
                .HasColumnName("created_on");
            entity.Property(e => e.Credit)
                .HasPrecision(18, 6)
                .HasComment("信用額度")
                .HasColumnName("credit");
            entity.Property(e => e.CreditNotification)
                .HasDefaultValueSql("'{}'::jsonb")
                .HasComment("信用額度通知")
                .HasColumnType("jsonb")
                .HasColumnName("credit_notification");
            entity.Property(e => e.HighNotification)
                .HasDefaultValueSql("'{}'::jsonb")
                .HasComment("高度風險通知")
                .HasColumnType("jsonb")
                .HasColumnName("high_notification");
            entity.Property(e => e.HighRisk)
                .HasPrecision(18, 6)
                .HasDefaultValueSql("95.0")
                .HasComment("高度風險")
                .HasColumnName("high_risk");
            entity.Property(e => e.LowNotification)
                .HasDefaultValueSql("'{}'::jsonb")
                .HasComment("低度風險通知")
                .HasColumnType("jsonb")
                .HasColumnName("low_notification");
            entity.Property(e => e.LowRisk)
                .HasPrecision(18, 6)
                .HasDefaultValueSql("60.0")
                .HasComment("低度風險")
                .HasColumnName("low_risk");
            entity.Property(e => e.ManualNotification)
                .HasDefaultValueSql("'{}'::jsonb")
                .HasComment("手動通知")
                .HasColumnType("jsonb")
                .HasColumnName("manual_notification");
            entity.Property(e => e.ModerateNotification)
                .HasDefaultValueSql("'{}'::jsonb")
                .HasComment("中度風險通知")
                .HasColumnType("jsonb")
                .HasColumnName("moderate_notification");
            entity.Property(e => e.ModerateRisk)
                .HasPrecision(18, 6)
                .HasDefaultValueSql("80.0")
                .HasComment("中度風險")
                .HasColumnName("moderate_risk");
            entity.Property(e => e.UpdatedOn)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasComment("修改時間")
                .HasColumnName("updated_on");
        });

        modelBuilder.Entity<BrandGameCreditTxn>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_brand_game_credit_txns");

            entity.ToTable("brand_game_credit_txns", "dbo");

            entity.HasIndex(e => e.BrandId, "ix_brand_game_credit_txns_brand_id");

            entity.HasIndex(e => new { e.CreatedOn, e.BrandId }, "ix_brand_game_credit_txns_created_on_brand_id");

            entity.HasIndex(e => new { e.CreatedOn, e.BrandId, e.Type }, "ix_brand_game_credit_txns_created_on_brand_id_type");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasComment("識別碼")
                .HasColumnName("id");
            entity.Property(e => e.Amount)
                .HasPrecision(18, 6)
                .HasComment("額度")
                .HasColumnName("amount");
            entity.Property(e => e.BrandId)
                .HasComment("平台識別碼")
                .HasColumnName("brand_id");
            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasComment("創建時間")
                .HasColumnName("created_on");
            entity.Property(e => e.CreatedUserId)
                .HasComment("創建使用者識別碼")
                .HasColumnName("created_user_id");
            entity.Property(e => e.CreatedUsername)
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasComment("創建使用者名稱")
                .HasColumnName("created_username");
            entity.Property(e => e.Expansions)
                .HasDefaultValueSql("'{}'::jsonb")
                .HasComment("擴充")
                .HasColumnType("jsonb")
                .HasColumnName("expansions");
            entity.Property(e => e.Money)
                .HasPrecision(18, 6)
                .HasComment("金錢")
                .HasColumnName("money");
            entity.Property(e => e.Remark)
                .HasDefaultValueSql("''::text")
                .HasComment("備註")
                .HasColumnName("remark");
            entity.Property(e => e.Type)
                .HasDefaultValue(1)
                .HasComment("交易類型")
                .HasColumnName("type");
        });

        modelBuilder.Entity<BrandGameProvider>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_brand_game_providers");

            entity.ToTable("brand_game_providers", "dbo");

            entity.HasIndex(e => e.DefaultLanguageCode, "ix_brand_game_providers_default_language_code");

            entity.HasIndex(e => e.GameProviderConfigurationId, "ix_brand_game_providers_game_provider_configuration_id");

            entity.HasIndex(e => e.GameProviderId, "ix_brand_game_providers_game_provider_id");

            entity.HasIndex(e => new { e.BrandId, e.GameProviderId }, "ux_brand_game_providers_brand_id_game_provider_id").IsUnique();

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.DefaultLanguageCode)
                .HasMaxLength(6)
                .HasColumnName("default_language_code");
            entity.Property(e => e.DesktopQueryString)
                .HasMaxLength(512)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("desktop_query_string");
            entity.Property(e => e.GameProviderConfigurationId).HasColumnName("game_provider_configuration_id");
            entity.Property(e => e.GameProviderId).HasColumnName("game_provider_id");
            entity.Property(e => e.IsManualChangeStatus).HasColumnName("is_manual_change_status");
            entity.Property(e => e.MobileQueryString)
                .HasMaxLength(512)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("mobile_query_string");
            entity.Property(e => e.Status).HasColumnName("status");

            entity.HasOne(d => d.Brand).WithMany(p => p.BrandGameProviders)
                .HasForeignKey(d => d.BrandId)
                .HasConstraintName("fk_brand_game_providers_brands_brand_id");

            entity.HasOne(d => d.DefaultLanguageCodeNavigation).WithMany(p => p.BrandGameProviders)
                .HasForeignKey(d => d.DefaultLanguageCode)
                .HasConstraintName("fk_brand_game_providers_languages_default_language_code");

            entity.HasOne(d => d.GameProviderConfiguration).WithMany(p => p.BrandGameProviders)
                .HasForeignKey(d => d.GameProviderConfigurationId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_brand_game_providers_game_provider_configurations_game_provi");

            entity.HasOne(d => d.GameProvider).WithMany(p => p.BrandGameProviders)
                .HasForeignKey(d => d.GameProviderId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_brand_game_providers_game_providers_game_provider_id");
        });

        modelBuilder.Entity<BrandGameProviderAggregateAuditLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_brand_game_provider_aggregate_audit_log_id");

            entity.ToTable("brand_game_provider_aggregate_audit_logs", "dbo");

            entity.HasIndex(e => new { e.CreatedOn, e.CreatedByUserId, e.BrandId }, "ix_brand_game_provider_aggregate_audit_log_multiple_keys");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.CreatedByUserId).HasColumnName("created_by_user_id");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
        });

        modelBuilder.Entity<BrandGameProviderSchedule>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_brand_game_provider_schedule");

            entity.ToTable("brand_game_provider_schedules", "dbo");

            entity.HasIndex(e => e.BrandGameProviderId, "ix_brand_game_provider_schedule_brand_game_provider_id");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.BrandGameProviderId).HasColumnName("brand_game_provider_id");
            entity.Property(e => e.DayOfWeek).HasColumnName("day_of_week");
            entity.Property(e => e.From).HasColumnName("from");
            entity.Property(e => e.IsDefault).HasColumnName("is_default");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.To).HasColumnName("to");

            entity.HasOne(d => d.BrandGameProvider).WithMany(p => p.BrandGameProviderSchedules)
                .HasForeignKey(d => d.BrandGameProviderId)
                .HasConstraintName("fk_brand_game_provider_schedule_brand_game_providers_id");
        });

        modelBuilder.Entity<BrandGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_brand_groups");

            entity.ToTable("brand_groups", "dbo");

            entity.HasIndex(e => e.BrandId, "ix_brand_groups_brand_id");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.CreatedByUsername)
                .HasMaxLength(32)
                .HasColumnName("created_by_username");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.IsSports).HasColumnName("is_sports");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.UpdatedByUsername)
                .HasMaxLength(32)
                .HasColumnName("updated_by_username");
            entity.Property(e => e.UpdatedOn).HasColumnName("updated_on");

            entity.HasOne(d => d.Brand).WithMany(p => p.BrandGroups)
                .HasForeignKey(d => d.BrandId)
                .HasConstraintName("fk_brand_groups_brands_brand_id");

            entity.HasMany(d => d.BrandGames).WithMany(p => p.BrandGroups)
                .UsingEntity<Dictionary<string, object>>(
                    "BrandGroupGame",
                    r => r.HasOne<BrandGame>().WithMany()
                        .HasForeignKey("BrandGameId")
                        .HasConstraintName("fk_brand_group_games_brand_games_brand_game_id"),
                    l => l.HasOne<BrandGroup>().WithMany()
                        .HasForeignKey("BrandGroupId")
                        .HasConstraintName("fk_brand_group_games_brand_groups_brand_group_id"),
                    j =>
                    {
                        j.HasKey("BrandGroupId", "BrandGameId").HasName("pk_brand_group_games");
                        j.ToTable("brand_group_games", "dbo");
                        j.HasIndex(new[] { "BrandGameId" }, "ix_brand_group_games_brand_game_id");
                        j.IndexerProperty<Guid>("BrandGroupId").HasColumnName("brand_group_id");
                        j.IndexerProperty<Guid>("BrandGameId").HasColumnName("brand_game_id");
                    });
        });

        modelBuilder.Entity<BrandGroupBetLimit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_brand_group_bet_limits");

            entity.ToTable("brand_group_bet_limits", "dbo");

            entity.HasIndex(e => new { e.BrandGroupId, e.BetLimitId }, "ak_brand_group_bet_limits_brand_group_id_bet_limit_id").IsUnique();

            entity.HasIndex(e => e.BetLimitId, "ix_brand_group_bet_limits_bet_limit_id");

            entity.HasIndex(e => e.BrandGroupId, "ix_brand_group_bet_limits_brand_group_id");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.BetLimitId).HasColumnName("bet_limit_id");
            entity.Property(e => e.BrandGroupId).HasColumnName("brand_group_id");

            entity.HasOne(d => d.BetLimit).WithMany(p => p.BrandGroupBetLimits)
                .HasForeignKey(d => d.BetLimitId)
                .HasConstraintName("fk_brand_group_bet_limits_bet_limits_bet_limit_id");

            entity.HasOne(d => d.BrandGroup).WithMany(p => p.BrandGroupBetLimits)
                .HasForeignKey(d => d.BrandGroupId)
                .HasConstraintName("fk_brand_group_bet_limits_brand_groups_brand_group_id");

            entity.HasMany(d => d.GameProviderBetLimits).WithMany(p => p.BrandGroupBetLimits)
                .UsingEntity<Dictionary<string, object>>(
                    "BrandGroupGameProviderBetLimit",
                    r => r.HasOne<GameProviderBetLimit>().WithMany()
                        .HasForeignKey("GameProviderBetLimitId")
                        .HasConstraintName("fk_brand_group_game_provider_bet_limits_game_provider_bet_limit"),
                    l => l.HasOne<BrandGroupBetLimit>().WithMany()
                        .HasForeignKey("BrandGroupBetLimitId")
                        .HasConstraintName("fk_brand_group_game_provider_bet_limits_brand_group_bet_limits_"),
                    j =>
                    {
                        j.HasKey("BrandGroupBetLimitId", "GameProviderBetLimitId").HasName("pk_brand_group_game_provider_bet_limits");
                        j.ToTable("brand_group_game_provider_bet_limits", "dbo");
                        j.HasIndex(new[] { "GameProviderBetLimitId" }, "ix_brand_group_game_provider_bet_limits_game_provider_bet_limit");
                        j.IndexerProperty<Guid>("BrandGroupBetLimitId").HasColumnName("brand_group_bet_limit_id");
                        j.IndexerProperty<Guid>("GameProviderBetLimitId").HasColumnName("game_provider_bet_limit_id");
                    });
        });

        modelBuilder.Entity<BrandLanguage>(entity =>
        {
            entity.HasKey(e => new { e.BrandId, e.CultureCode }).HasName("pk_brand_languages");

            entity.ToTable("brand_languages", "dbo");

            entity.HasIndex(e => e.CultureCode, "ix_brand_languages_culture_code");

            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.CultureCode)
                .HasMaxLength(6)
                .HasColumnName("culture_code");
            entity.Property(e => e.BrandCultureCode)
                .HasMaxLength(6)
                .HasColumnName("brand_culture_code");

            entity.HasOne(d => d.Brand).WithMany(p => p.BrandLanguages)
                .HasForeignKey(d => d.BrandId)
                .HasConstraintName("fk_brand_languages_brands_brand_id");

            entity.HasOne(d => d.CultureCodeNavigation).WithMany(p => p.BrandLanguages)
                .HasForeignKey(d => d.CultureCode)
                .HasConstraintName("fk_brand_languages_languages_culture_code");
        });

        modelBuilder.Entity<BrandLiveChat>(entity =>
        {
            entity.HasKey(e => e.BrandId).HasName("pk_brand_live_chats");

            entity.ToTable("brand_live_chats", "dbo");

            entity.Property(e => e.BrandId)
                .ValueGeneratedNever()
                .HasColumnName("brand_id");
            entity.Property(e => e.ChatName)
                .HasMaxLength(128)
                .HasColumnName("chat_name");
            entity.Property(e => e.ChatSetting)
                .HasColumnType("jsonb")
                .HasColumnName("chat_setting");

            entity.HasOne(d => d.Brand).WithOne(p => p.BrandLiveChat)
                .HasForeignKey<BrandLiveChat>(d => d.BrandId)
                .HasConstraintName("fk_brand_live_chats_brands_brand_id");
        });

        modelBuilder.Entity<BrandMaintenance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_brand_maintenance");

            entity.ToTable("brand_maintenance", "dbo");

            entity.HasIndex(e => e.BrandId, "ix_brand_maintenance_brand_id").IsUnique();

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.BeginTime).HasColumnName("begin_time");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.Content)
                .HasMaxLength(2000)
                .HasColumnName("content");
            entity.Property(e => e.EndTime).HasColumnName("end_time");

            entity.HasOne(d => d.Brand).WithOne(p => p.BrandMaintenance)
                .HasForeignKey<BrandMaintenance>(d => d.BrandId)
                .HasConstraintName("fk_brand_maintenance_brands_brand_id");
        });

        modelBuilder.Entity<BrandPayment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_brand_payments");

            entity.ToTable("brand_payments", "dbo");

            entity.HasIndex(e => e.BrandId, "ix_brand_payments_brand_id");

            entity.HasIndex(e => e.PaymentMethodChannelId, "ix_brand_payments_payment_method_channel_id");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.AllPlayers).HasColumnName("all_players");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.ChannelName)
                .HasMaxLength(50)
                .HasColumnName("channel_name");
            entity.Property(e => e.CreatedByUsername)
                .HasMaxLength(32)
                .HasColumnName("created_by_username");
            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_on");
            entity.Property(e => e.DepositedAmountMax)
                .HasPrecision(18, 6)
                .HasColumnName("deposited_amount_max");
            entity.Property(e => e.DepositedAmountMin)
                .HasPrecision(18, 6)
                .HasColumnName("deposited_amount_min");
            entity.Property(e => e.DepositedAmountUnlimited).HasColumnName("deposited_amount_unlimited");
            entity.Property(e => e.DisplayOrder).HasColumnName("display_order");
            entity.Property(e => e.ExtendedData)
                .HasColumnType("jsonb")
                .HasColumnName("extended_data");
            entity.Property(e => e.HandlingFeeRateTenPercentile)
                .HasPrecision(18, 6)
                .HasColumnName("handling_fee_rate_ten_percentile");
            entity.Property(e => e.IdentityAuthentication).HasColumnName("identity_authentication");
            entity.Property(e => e.PaymentMethodChannelId).HasColumnName("payment_method_channel_id");
            entity.Property(e => e.PaymentStatus).HasColumnName("payment_status");
            entity.Property(e => e.PhoneAuthentication).HasColumnName("phone_authentication");
            entity.Property(e => e.PlayerListCondition).HasColumnName("player_list_condition");
            entity.Property(e => e.Reason)
                .HasMaxLength(4000)
                .HasColumnName("reason");
            entity.Property(e => e.ReducePlayerAmount)
                .HasDefaultValue(false)
                .HasColumnName("reduce_player_amount");
            entity.Property(e => e.TransferLimitFrom)
                .HasPrecision(18, 6)
                .HasColumnName("transfer_limit_from");
            entity.Property(e => e.TransferLimitTo)
                .HasPrecision(18, 6)
                .HasColumnName("transfer_limit_to");
            entity.Property(e => e.TransferType).HasColumnName("transfer_type");
            entity.Property(e => e.UpdatedByUsername)
                .HasMaxLength(32)
                .HasColumnName("updated_by_username");
            entity.Property(e => e.UpdatedOn)
                .HasDefaultValueSql("now()")
                .HasColumnName("updated_on");

            entity.HasOne(d => d.Brand).WithMany(p => p.BrandPayments)
                .HasForeignKey(d => d.BrandId)
                .HasConstraintName("fk_brand_payments_brands_brand_id");

            entity.HasOne(d => d.PaymentMethodChannel).WithMany(p => p.BrandPayments)
                .HasForeignKey(d => d.PaymentMethodChannelId)
                .HasConstraintName("fk_brand_payments_payment_method_channels_id");

            entity.HasMany(d => d.VipLevels).WithMany(p => p.BrandPayments)
                .UsingEntity<Dictionary<string, object>>(
                    "BrandPaymentVipLevel",
                    r => r.HasOne<VipLevel>().WithMany()
                        .HasForeignKey("VipLevelId")
                        .HasConstraintName("fk_brand_payment_vip_levels_vip_levels_vip_level_id"),
                    l => l.HasOne<BrandPayment>().WithMany()
                        .HasForeignKey("BrandPaymentId")
                        .HasConstraintName("fk_brand_payment_vip_levels_brand_payments_brand_payment_id"),
                    j =>
                    {
                        j.HasKey("BrandPaymentId", "VipLevelId").HasName("pk_brand_payment_vip_levels");
                        j.ToTable("brand_payment_vip_levels", "dbo");
                        j.HasIndex(new[] { "VipLevelId" }, "ix_brand_payment_vip_levels_vip_level_id");
                        j.IndexerProperty<Guid>("BrandPaymentId").HasColumnName("brand_payment_id");
                        j.IndexerProperty<Guid>("VipLevelId").HasColumnName("vip_level_id");
                    });
        });

        modelBuilder.Entity<BrandPaymentAuditLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_brand_payment_audit_logs");

            entity.ToTable("brand_payment_audit_logs", "dbo");

            entity.HasIndex(e => e.BrandPaymentId, "ix_brand_payment_audit_logs_brand_payment_id");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.After)
                .HasColumnType("jsonb")
                .HasColumnName("after");
            entity.Property(e => e.Before)
                .HasColumnType("jsonb")
                .HasColumnName("before");
            entity.Property(e => e.BrandPaymentId).HasColumnName("brand_payment_id");
            entity.Property(e => e.CreatedByUsername)
                .HasMaxLength(32)
                .HasColumnName("created_by_username");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
            entity.Property(e => e.Operation).HasColumnName("operation");
            entity.Property(e => e.Reason)
                .HasMaxLength(4000)
                .HasColumnName("reason");
        });

        modelBuilder.Entity<BrandPaymentAutoWithdraw>(entity =>
        {
            entity.HasKey(e => e.BrandId).HasName("pk_brand_payment_auto_withdraw");

            entity.ToTable("brand_payment_auto_withdraw", "dbo");

            entity.Property(e => e.BrandId)
                .ValueGeneratedNever()
                .HasColumnName("brand_id");
            entity.Property(e => e.AmountUpperLimit)
                .HasPrecision(18, 6)
                .HasColumnName("amount_upper_limit");
            entity.Property(e => e.BrandPaymentCandidates)
                .HasColumnType("jsonb")
                .HasColumnName("brand_payment_candidates");
            entity.Property(e => e.EnableAutoWithdraw)
                .HasDefaultValue(false)
                .HasColumnName("enable_auto_withdraw");
            entity.Property(e => e.SnapshotEventId).HasColumnName("snapshot_event_id");
        });

        modelBuilder.Entity<BrandPaymentAutoWithdrawEventSource>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_brand_payment_auto_withdraw_event_source");

            entity.ToTable("brand_payment_auto_withdraw_event_source", "dbo");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.ChangeSets)
                .HasColumnType("jsonb")
                .HasColumnName("change_sets");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
            entity.Property(e => e.ModifyUser).HasColumnName("modify_user");
        });

        modelBuilder.Entity<BrandPaymentPlayer>(entity =>
        {
            entity.HasKey(e => new { e.BrandPaymentId, e.PlayerCode }).HasName("pk_brand_payment_players");

            entity.ToTable("brand_payment_players", "dbo");

            entity.HasIndex(e => e.PlayerCode, "ix_brand_payment_players_player_code");

            entity.Property(e => e.BrandPaymentId).HasColumnName("brand_payment_id");
            entity.Property(e => e.PlayerCode)
                .HasMaxLength(16)
                .HasColumnName("player_code");
            entity.Property(e => e.ListType).HasColumnName("list_type");

            entity.HasOne(d => d.BrandPayment).WithMany(p => p.BrandPaymentPlayers)
                .HasForeignKey(d => d.BrandPaymentId)
                .HasConstraintName("fk_brand_payment_players_brand_payments_brand_payment_id");

            entity.HasOne(d => d.PlayerCodeNavigation).WithMany(p => p.BrandPaymentPlayers)
                .HasForeignKey(d => d.PlayerCode)
                .HasConstraintName("fk_brand_payment_players_players_player_code");
        });

        modelBuilder.Entity<BrandPaymentSetting>(entity =>
        {
            entity.HasKey(e => e.BrandId).HasName("pk_brand_payment_settings");

            entity.ToTable("brand_payment_settings", "dbo");

            entity.Property(e => e.BrandId)
                .ValueGeneratedNever()
                .HasColumnName("brand_id");
            entity.Property(e => e.PlayerBankInfoCountLimit).HasColumnName("player_bank_info_count_limit");

            entity.HasOne(d => d.Brand).WithOne(p => p.BrandPaymentSetting)
                .HasForeignKey<BrandPaymentSetting>(d => d.BrandId)
                .HasConstraintName("fk_brands");
        });

        modelBuilder.Entity<BrandPlayerBankinfoCheckFlag>(entity =>
        {
            entity.HasKey(e => e.BrandId).HasName("pk_brand_player_bankinfo_check_flags");

            entity.ToTable("brand_player_bankinfo_check_flags", "dbo");

            entity.Property(e => e.BrandId)
                .ValueGeneratedNever()
                .HasColumnName("brand_id");
            entity.Property(e => e.IsEnabled).HasColumnName("is_enabled");
        });

        modelBuilder.Entity<BrandPlayerContractDisplay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_brand_player_contract_display");

            entity.ToTable("brand_player_contract_display", "dbo");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(256)
                .HasColumnName("created_by");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
            entity.Property(e => e.IsVisualized).HasColumnName("is_visualized");
            entity.Property(e => e.Name)
                .HasMaxLength(128)
                .HasColumnName("name");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(256)
                .HasColumnName("updated_by");
            entity.Property(e => e.UpdatedOn).HasColumnName("updated_on");
        });

        modelBuilder.Entity<BrandProductFee>(entity =>
        {
            entity.HasKey(e => e.BrandId).HasName("pk_brand_product_fees");

            entity.ToTable("brand_product_fees", "dbo");

            entity.Property(e => e.BrandId)
                .ValueGeneratedNever()
                .HasColumnName("brand_id");
            entity.Property(e => e.CardGamePercentage)
                .HasPrecision(18, 6)
                .HasColumnName("card_game_percentage");
            entity.Property(e => e.CreatedByUsername).HasColumnName("created_by_username");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
            entity.Property(e => e.LiveDealerPercentage)
                .HasPrecision(18, 6)
                .HasColumnName("live_dealer_percentage");
            entity.Property(e => e.LotteryPercentage)
                .HasPrecision(18, 6)
                .HasColumnName("lottery_percentage");
            entity.Property(e => e.SlotPercentage)
                .HasPrecision(18, 6)
                .HasColumnName("slot_percentage");
            entity.Property(e => e.SportsPercentage)
                .HasPrecision(18, 6)
                .HasColumnName("sports_percentage");
            entity.Property(e => e.UpdatedByUsername).HasColumnName("updated_by_username");
            entity.Property(e => e.UpdatedOn).HasColumnName("updated_on");
            entity.Property(e => e.VirtualSportsPercentage)
                .HasPrecision(18, 6)
                .HasColumnName("virtual_sports_percentage");
        });

        modelBuilder.Entity<BrandSm>(entity =>
        {
            entity.HasKey(e => new { e.BrandId, e.SmsSettingId }).HasName("pk_brand_sms");

            entity.ToTable("brand_sms", "dbo");

            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.SmsSettingId).HasColumnName("sms_setting_id");
        });

        modelBuilder.Entity<Calculate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_calculate");

            entity.ToTable("calculate", "dbo");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Balance).HasColumnName("balance");
            entity.Property(e => e.Deleted)
                .HasDefaultValue(false)
                .HasColumnName("deleted");
            entity.Property(e => e.SnapshotId).HasColumnName("snapshot_id");
        });

        modelBuilder.Entity<CalculateChangeLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_calculate_change_log");

            entity.ToTable("calculate_change_log", "dbo");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Balance).HasColumnName("balance");
            entity.Property(e => e.CalculateId).HasColumnName("calculate_id");
            entity.Property(e => e.Change).HasColumnName("change");
            entity.Property(e => e.Deleted)
                .HasDefaultValue(false)
                .HasColumnName("deleted");
            entity.Property(e => e.RecordedOn).HasColumnName("recorded_on");
        });

        modelBuilder.Entity<Currency>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("pk_currencies");

            entity.ToTable("currencies", "dbo");

            entity.Property(e => e.Code)
                .HasMaxLength(16)
                .HasColumnName("code");
            entity.Property(e => e.CreatedByUsername)
                .HasMaxLength(32)
                .HasColumnName("created_by_username");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasColumnName("name");
            entity.Property(e => e.NativeName)
                .HasMaxLength(64)
                .HasColumnName("native_name");
            entity.Property(e => e.Symbol)
                .HasMaxLength(6)
                .HasColumnName("symbol");
            entity.Property(e => e.UpdatedByUsername)
                .HasMaxLength(32)
                .HasColumnName("updated_by_username");
            entity.Property(e => e.UpdatedOn).HasColumnName("updated_on");
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_departments");

            entity.ToTable("departments", "dbo");

            entity.HasIndex(e => e.BrandId, "ix_departments_brand_id");

            entity.HasIndex(e => e.LicenseeId, "ix_departments_licensee_id");

            entity.HasIndex(e => e.ResellerId, "ix_departments_reseller_id");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.CreatedByUsername)
                .HasMaxLength(32)
                .HasColumnName("created_by_username");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
            entity.Property(e => e.Description)
                .HasMaxLength(128)
                .HasColumnName("description");
            entity.Property(e => e.LicenseeId).HasColumnName("licensee_id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.ResellerId).HasColumnName("reseller_id");
            entity.Property(e => e.UpdatedByUsername)
                .HasMaxLength(32)
                .HasColumnName("updated_by_username");
            entity.Property(e => e.UpdatedOn).HasColumnName("updated_on");

            entity.HasOne(d => d.Brand).WithMany(p => p.Departments)
                .HasForeignKey(d => d.BrandId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_departments_brands_brand_id");

            entity.HasOne(d => d.Licensee).WithMany(p => p.Departments)
                .HasForeignKey(d => d.LicenseeId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_departments_licensees_licensee_id");

            entity.HasOne(d => d.Reseller).WithMany(p => p.Departments)
                .HasForeignKey(d => d.ResellerId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_departments_resellers_reseller_id");
        });

        modelBuilder.Entity<DepositAccumulateRouletteEvent>(entity =>
        {
            entity.HasKey(e => new { e.PlayerCode, e.PromotionId, e.Date }).HasName("pk_deposit_accumulate_roulette_events");

            entity.ToTable("deposit_accumulate_roulette_events", "dbo");

            entity.HasIndex(e => e.BrandId, "ix_deposit_accumulate_roulette_events_brand_id");

            entity.HasIndex(e => e.PromotionId, "ix_deposit_accumulate_roulette_events_promotion_id");

            entity.Property(e => e.PlayerCode)
                .HasMaxLength(16)
                .HasColumnName("player_code");
            entity.Property(e => e.PromotionId).HasColumnName("promotion_id");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.RouletteCount)
                .HasDefaultValue(0)
                .HasColumnName("roulette_count");
            entity.Property(e => e.TotalDepositAmount)
                .HasPrecision(18, 6)
                .HasColumnName("total_deposit_amount");

            entity.HasOne(d => d.Brand).WithMany(p => p.DepositAccumulateRouletteEvents)
                .HasForeignKey(d => d.BrandId)
                .HasConstraintName("fk_deposit_accumulate_roulette_events_brands_brand_id");

            entity.HasOne(d => d.PlayerCodeNavigation).WithMany(p => p.DepositAccumulateRouletteEvents)
                .HasForeignKey(d => d.PlayerCode)
                .HasConstraintName("fk_deposit_accumulate_roulette_events_players_player_code");

            entity.HasOne(d => d.Promotion).WithMany(p => p.DepositAccumulateRouletteEvents)
                .HasForeignKey(d => d.PromotionId)
                .HasConstraintName("fk_deposit_accumulate_roulette_events_promotions_promotion_id");
        });

        modelBuilder.Entity<DepositAccumulateRouletteGameEvent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_deposit_accumulate_roulette_game_events");

            entity.ToTable("deposit_accumulate_roulette_game_events", "dbo");

            entity.HasIndex(e => e.BrandId, "ix_deposit_accumulate_roulette_game_events_brand_id");

            entity.HasIndex(e => e.PlayerCode, "ix_deposit_accumulate_roulette_game_events_player_code");

            entity.HasIndex(e => e.PromotionId, "ix_deposit_accumulate_roulette_game_events_promotion_id");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Bonus)
                .HasPrecision(18, 6)
                .HasColumnName("bonus");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.Bucket).HasColumnName("bucket");
            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_on");
            entity.Property(e => e.Date)
                .HasDefaultValueSql("'-infinity'::date")
                .HasColumnName("date");
            entity.Property(e => e.ItemIndex).HasColumnName("item_index");
            entity.Property(e => e.PlayerCode)
                .HasMaxLength(16)
                .HasColumnName("player_code");
            entity.Property(e => e.PromotionId).HasColumnName("promotion_id");
            entity.Property(e => e.RouletteCount)
                .HasDefaultValue(0)
                .HasColumnName("roulette_count");

            entity.HasOne(d => d.Brand).WithMany(p => p.DepositAccumulateRouletteGameEvents)
                .HasForeignKey(d => d.BrandId)
                .HasConstraintName("fk_game_events_brands_brand_id");

            entity.HasOne(d => d.PlayerCodeNavigation).WithMany(p => p.DepositAccumulateRouletteGameEvents)
                .HasForeignKey(d => d.PlayerCode)
                .HasConstraintName("fk_game_events_players_brand_id");

            entity.HasOne(d => d.Promotion).WithMany(p => p.DepositAccumulateRouletteGameEvents)
                .HasForeignKey(d => d.PromotionId)
                .HasConstraintName("fk_game_events_promotions_promotion_id");
        });

        modelBuilder.Entity<DepositForm>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_deposit_forms");

            entity.ToTable("deposit_forms", "dbo");

            entity.HasIndex(e => e.BrandId, "ix_deposit_forms_brandId");

            entity.HasIndex(e => e.BrandPaymentId, "ix_deposit_forms_brand_payment_id");

            entity.HasIndex(e => new { e.BrandId, e.CreatedOn, e.Status }, "ix_deposit_forms_created_on");

            entity.HasIndex(e => e.PlayerCode, "ix_deposit_forms_playerCode");

            entity.HasIndex(e => new { e.BrandId, e.ThirdPartyOrderNo, e.Status }, "ix_deposit_forms_third_party_order_no");

            entity.HasIndex(e => new { e.BrandId, e.UpdatedOn, e.Status }, "ix_deposit_forms_updated_on");

            entity.HasIndex(e => new { e.BrandId, e.OrderNo }, "ux_deposit_forms_order_no").IsUnique();

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.ActualAmount)
                .HasPrecision(18, 6)
                .HasColumnName("actual_amount");
            entity.Property(e => e.Amount)
                .HasPrecision(18, 6)
                .HasColumnName("amount");
            entity.Property(e => e.ApplyInfo)
                .HasColumnType("jsonb")
                .HasColumnName("apply_info");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.BrandPaymentId).HasColumnName("brand_payment_id");
            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_on");
            entity.Property(e => e.HandlingFee)
                .HasPrecision(18, 6)
                .HasColumnName("handling_fee");
            entity.Property(e => e.OrderNo)
                .HasMaxLength(50)
                .HasColumnName("order_no");
            entity.Property(e => e.PaymentReturn)
                .HasColumnType("jsonb")
                .HasColumnName("payment_return");
            entity.Property(e => e.PlayerCode)
                .HasMaxLength(16)
                .HasColumnName("player_code");
            entity.Property(e => e.PromotionId).HasColumnName("promotion_id");
            entity.Property(e => e.PromotionPlayerId).HasColumnName("promotion_player_id");
            entity.Property(e => e.Remark).HasColumnName("remark");
            entity.Property(e => e.ReviewedOn).HasColumnName("reviewed_on");
            entity.Property(e => e.ReviewedUserId).HasColumnName("reviewed_user_id");
            entity.Property(e => e.ReviewedUserName).HasColumnName("reviewed_user_name");
            entity.Property(e => e.SnapshotEventId).HasColumnName("snapshot_event_id");
            entity.Property(e => e.Status)
                .HasDefaultValue(0)
                .HasColumnName("status");
            entity.Property(e => e.ThirdPartyOrderNo).HasColumnName("third_party_order_no");
            entity.Property(e => e.UpdatedOn)
                .HasDefaultValueSql("now()")
                .HasColumnName("updated_on");

            entity.HasOne(d => d.Brand).WithMany(p => p.DepositForms)
                .HasForeignKey(d => d.BrandId)
                .HasConstraintName("fk_deposit_froms_brands_id");

            entity.HasOne(d => d.BrandPayment).WithMany(p => p.DepositForms)
                .HasForeignKey(d => d.BrandPaymentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_deposit_forms_brand_payments_id");

            entity.HasOne(d => d.PlayerCodeNavigation).WithMany(p => p.DepositForms)
                .HasForeignKey(d => d.PlayerCode)
                .HasConstraintName("fk_deposit_forms_players_player_code");
        });

        modelBuilder.Entity<DepositFormEventSource>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_deposit_form_event_source");

            entity.ToTable("deposit_form_event_source", "dbo");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Action).HasColumnName("action");
            entity.Property(e => e.ChangeSets)
                .HasColumnType("jsonb")
                .HasColumnName("change_sets");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
            entity.Property(e => e.FormId).HasColumnName("form_id");
            entity.Property(e => e.ModifyUser).HasColumnName("modify_user");
        });

        modelBuilder.Entity<DepositPromotionCalculatePair>(entity =>
        {
            entity.HasKey(e => e.PromotionId).HasName("pk_deposit_promotion_calculate_pairs");

            entity.ToTable("deposit_promotion_calculate_pairs", "dbo");

            entity.Property(e => e.PromotionId)
                .ValueGeneratedNever()
                .HasColumnName("promotion_id");
            entity.Property(e => e.CalculateId).HasColumnName("calculate_id");
        });

        modelBuilder.Entity<DepositPromotionStatistic>(entity =>
        {
            entity.HasKey(e => new { e.PromotionId, e.PlayerCode }).HasName("pk_deposit_promotion_statistics");

            entity.ToTable("deposit_promotion_statistics", "dbo");

            entity.Property(e => e.PromotionId).HasColumnName("promotion_id");
            entity.Property(e => e.PlayerCode).HasColumnName("player_code");
            entity.Property(e => e.ProcessedDate).HasColumnName("processed_date");
            entity.Property(e => e.TotalDepositCount).HasColumnName("total_deposit_count");
        });

        modelBuilder.Entity<DistributeRegisterEvent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_distribute_register_events");

            entity.ToTable("distribute_register_events", "dbo");

            entity.HasIndex(e => e.BrandId, "ix_distribute_register_events_brand_id");

            entity.HasIndex(e => e.PlayerCode, "ix_distribute_register_events_player_code");

            entity.HasIndex(e => e.PromotionId, "ix_distribute_register_events_promotion_id");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Bonus)
                .HasPrecision(18, 6)
                .HasColumnName("bonus");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_on");
            entity.Property(e => e.PlayerCode)
                .HasMaxLength(16)
                .HasColumnName("player_code");
            entity.Property(e => e.PromotionId).HasColumnName("promotion_id");

            entity.HasOne(d => d.Brand).WithMany(p => p.DistributeRegisterEvents)
                .HasForeignKey(d => d.BrandId)
                .HasConstraintName("fk_distribute_register_events_brands_brand_id");

            entity.HasOne(d => d.PlayerCodeNavigation).WithMany(p => p.DistributeRegisterEvents)
                .HasForeignKey(d => d.PlayerCode)
                .HasConstraintName("fk_distribute_register_events_players_brand_id");

            entity.HasOne(d => d.Promotion).WithMany(p => p.DistributeRegisterEvents)
                .HasForeignKey(d => d.PromotionId)
                .HasConstraintName("fk_distribute_register_events_promotions_promotion_id");
        });

        modelBuilder.Entity<DraftForm>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_draft_forms");

            entity.ToTable("draft_forms", "dbo");

            entity.HasIndex(e => e.BrandId, "ix_draft_forms_brand_id");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.LocalizedArticles)
                .HasColumnType("jsonb")
                .HasColumnName("localized_articles");
            entity.Property(e => e.Modifier).HasColumnName("modifier");
            entity.Property(e => e.PublishDate).HasColumnName("publish_date");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.UpdatedOn).HasColumnName("updated_on");

            entity.HasOne(d => d.Brand).WithMany(p => p.DraftForms)
                .HasForeignKey(d => d.BrandId)
                .HasConstraintName("fk_draft_forms_brands");
        });

        modelBuilder.Entity<FiveMinutesPaymentStatistic>(entity =>
        {
            entity.HasKey(e => new { e.TimePoint, e.UserId, e.UserType }).HasName("pk_five_minutes_payment_statistics");

            entity.ToTable("five_minutes_payment_statistics", "dbo");

            entity.Property(e => e.TimePoint).HasColumnName("time_point");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.UserType).HasColumnName("user_type");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.DepositAmount).HasColumnName("deposit_amount");
            entity.Property(e => e.DepositCount).HasColumnName("deposit_count");
            entity.Property(e => e.DepositHandlingFee).HasColumnName("deposit_handling_fee");
            entity.Property(e => e.FirstDepositAmount).HasColumnName("first_deposit_amount");
            entity.Property(e => e.FirstDepositHandlingFee).HasColumnName("first_deposit_handling_fee");
            entity.Property(e => e.FirstDepositOn).HasColumnName("first_deposit_on");
            entity.Property(e => e.FirstWithdrawAmount).HasColumnName("first_withdraw_amount");
            entity.Property(e => e.FirstWithdrawHandlingFee).HasColumnName("first_withdraw_handling_fee");
            entity.Property(e => e.FirstWithdrawOn).HasColumnName("first_withdraw_on");
            entity.Property(e => e.WithdrawAmount).HasColumnName("withdraw_amount");
            entity.Property(e => e.WithdrawCount).HasColumnName("withdraw_count");
            entity.Property(e => e.WithdrawHandlingFee).HasColumnName("withdraw_handling_fee");
        });

        modelBuilder.Entity<FiveMinutesPaymentStatisticsDeltum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_five_minutes_payment_statistics_delta");

            entity.ToTable("five_minutes_payment_statistics_delta", "dbo");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.DepositAmount).HasColumnName("deposit_amount");
            entity.Property(e => e.DepositCount)
                .HasDefaultValue(0)
                .HasColumnName("deposit_count");
            entity.Property(e => e.DepositHandlingFee).HasColumnName("deposit_handling_fee");
            entity.Property(e => e.TimePoint).HasColumnName("time_point");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.UserType).HasColumnName("user_type");
            entity.Property(e => e.WithdrawAmount).HasColumnName("withdraw_amount");
            entity.Property(e => e.WithdrawCount)
                .HasDefaultValue(0)
                .HasColumnName("withdraw_count");
            entity.Property(e => e.WithdrawHandlingFee).HasColumnName("withdraw_handling_fee");
        });

        modelBuilder.Entity<Function>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_functions");

            entity.ToTable("functions", "dbo");

            entity.HasIndex(e => new { e.Name, e.System }, "ak_functions_name_system").IsUnique();

            entity.HasIndex(e => e.System, "ix_functions_system");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
            entity.Property(e => e.Features)
                .HasColumnType("jsonb")
                .HasColumnName("features");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.SnapshotId).HasColumnName("snapshot_id");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.System).HasColumnName("system");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.UpdatedOn).HasColumnName("updated_on");

            entity.HasOne(d => d.SystemNavigation).WithMany(p => p.Functions)
                .HasForeignKey(d => d.System)
                .HasConstraintName("fk_systems");
        });

        modelBuilder.Entity<FunctionEventSource>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_function_event_sources");

            entity.ToTable("function_event_sources", "dbo");

            entity.HasIndex(e => e.FunctionId, "ix_function_event_sources_function_id");

            entity.HasIndex(e => e.System, "ix_function_event_sources_system");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.ChangeSets)
                .HasColumnType("jsonb")
                .HasColumnName("change_sets");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
            entity.Property(e => e.FunctionId).HasColumnName("function_id");
            entity.Property(e => e.System).HasColumnName("system");

            entity.HasOne(d => d.Function).WithMany(p => p.FunctionEventSources)
                .HasForeignKey(d => d.FunctionId)
                .HasConstraintName("fk_functions");

            entity.HasOne(d => d.SystemNavigation).WithMany(p => p.FunctionEventSources)
                .HasForeignKey(d => d.System)
                .HasConstraintName("fk_systems");
        });

        modelBuilder.Entity<Game>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_games");

            entity.ToTable("games", "dbo");

            entity.HasIndex(e => e.GameProviderId, "ix_games_game_provider_id");

            entity.HasIndex(e => e.Name, "ix_games_name");

            entity.HasIndex(e => e.SubGameProviderCode, "ix_games_sub_game_provider_code");

            entity.HasIndex(e => e.Name, "ix_trgm_games_name")
                .HasMethod("gin")
                .HasOperators(new[] { "gin_trgm_ops" });

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.AvailableCurrencies)
                .HasMaxLength(1024)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("available_currencies");
            entity.Property(e => e.AvailableToBrand).HasColumnName("available_to_brand");
            entity.Property(e => e.Code)
                .HasMaxLength(128)
                .HasColumnName("code");
            entity.Property(e => e.CreatedByUsername)
                .HasMaxLength(32)
                .HasColumnName("created_by_username");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
            entity.Property(e => e.Description)
                .HasMaxLength(128)
                .HasColumnName("description");
            entity.Property(e => e.EndpointPath)
                .HasMaxLength(2048)
                .HasColumnName("endpoint_path");
            entity.Property(e => e.ExternalId)
                .HasMaxLength(32)
                .HasColumnName("external_id");
            entity.Property(e => e.GameProviderId).HasColumnName("game_provider_id");
            entity.Property(e => e.HasTurnoverOnTieBet).HasColumnName("has_turnover_on_tie_bet");
            entity.Property(e => e.Html5).HasColumnName("html5");
            entity.Property(e => e.Localization)
                .HasColumnType("jsonb")
                .HasColumnName("localization");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.PlatformType).HasColumnName("platform_type");
            entity.Property(e => e.RuleUrl)
                .HasMaxLength(512)
                .HasColumnName("rule_url");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.SubGame).HasColumnName("sub_game");
            entity.Property(e => e.SubGameProviderCode)
                .HasMaxLength(16)
                .HasColumnName("sub_game_provider_code");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.UpdatedByUsername)
                .HasMaxLength(32)
                .HasColumnName("updated_by_username");
            entity.Property(e => e.UpdatedOn).HasColumnName("updated_on");

            entity.HasOne(d => d.GameProvider).WithMany(p => p.Games)
                .HasForeignKey(d => d.GameProviderId)
                .HasConstraintName("fk_games_game_providers_game_provider_id");

            entity.HasOne(d => d.SubGameProviderCodeNavigation).WithMany(p => p.Games)
                .HasForeignKey(d => d.SubGameProviderCode)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_games_sub_game_providers_sub_game_provider_code");
        });

        modelBuilder.Entity<GameBetsDefault>(entity =>
        {
            entity.HasKey(e => new { e.ExternalCreatedOn, e.GameProviderId, e.GameId, e.WalletId, e.ExternalBetId }).HasName("game_bets_default_pkey");

            entity.ToTable("game_bets_default", "dbo");

            entity.HasIndex(e => new { e.ExternalCreatedOn, e.BrandId }, "game_bets_default_external_created_on_brand_id_idx");

            entity.HasIndex(e => new { e.ExternalCreatedOn, e.ClosedOn, e.BrandId }, "game_bets_default_external_created_on_closed_on_brand_id_idx");

            entity.HasIndex(e => new { e.ExternalCreatedOn, e.ClosedOn }, "game_bets_default_external_created_on_closed_on_idx");

            entity.HasIndex(e => new { e.ExternalCreatedOn, e.ClosedOn, e.PlayerCode }, "game_bets_default_external_created_on_closed_on_player_code_idx");

            entity.HasIndex(e => new { e.ExternalCreatedOn, e.CurrencyCode }, "game_bets_default_external_created_on_currency_code_idx");

            entity.HasIndex(e => new { e.ExternalCreatedOn, e.ExternalBetId }, "game_bets_default_external_created_on_external_bet_id_idx");

            entity.HasIndex(e => new { e.ExternalCreatedOn, e.ExternalRoundId }, "game_bets_default_external_created_on_external_round_id_idx");

            entity.HasIndex(e => new { e.ExternalCreatedOn, e.GameId }, "game_bets_default_external_created_on_game_id_idx");

            entity.HasIndex(e => new { e.ExternalCreatedOn, e.GameProviderConfigurationId }, "game_bets_default_external_created_on_game_provider_configu_idx");

            entity.HasIndex(e => new { e.ExternalCreatedOn, e.GameProviderId }, "game_bets_default_external_created_on_game_provider_id_idx");

            entity.HasIndex(e => new { e.ExternalCreatedOn, e.Id }, "game_bets_default_external_created_on_id_idx");

            entity.HasIndex(e => e.ExternalCreatedOn, "game_bets_default_external_created_on_idx");

            entity.HasIndex(e => new { e.ExternalCreatedOn, e.LicenseeId }, "game_bets_default_external_created_on_licensee_id_idx");

            entity.HasIndex(e => new { e.ExternalCreatedOn, e.PlayerCode }, "game_bets_default_external_created_on_player_code_idx");

            entity.HasIndex(e => new { e.ExternalCreatedOn, e.ResellerId }, "game_bets_default_external_created_on_reseller_id_idx");

            entity.HasIndex(e => new { e.ExternalCreatedOn, e.WalletId }, "game_bets_default_external_created_on_wallet_id_idx");

            entity.HasIndex(e => new { e.GameProviderId, e.GameId, e.WalletId, e.ExternalBetId }, "game_bets_default_game_provider_id_game_id_wallet_id_extern_idx");

            entity.Property(e => e.ExternalCreatedOn)
                .HasDefaultValueSql("'1970-01-01 00:00:00+00'::timestamp with time zone")
                .HasComment("三方下注/創建時間")
                .HasColumnName("external_created_on");
            entity.Property(e => e.GameProviderId)
                .HasComment("遊戲供應商識別碼")
                .HasColumnName("game_provider_id");
            entity.Property(e => e.GameId)
                .HasComment("遊戲識別碼")
                .HasColumnName("game_id");
            entity.Property(e => e.WalletId)
                .HasComment("錢包識別碼")
                .HasColumnName("wallet_id");
            entity.Property(e => e.ExternalBetId)
                .HasMaxLength(255)
                .HasComment("三方投注單別碼")
                .HasColumnName("external_bet_id");
            entity.Property(e => e.AdditionalData)
                .HasDefaultValueSql("'{}'::jsonb")
                .HasComment("附加數據")
                .HasColumnType("jsonb")
                .HasColumnName("additional_data");
            entity.Property(e => e.Bet)
                .HasPrecision(18, 6)
                .HasComment("下注")
                .HasColumnName("bet");
            entity.Property(e => e.BetState)
                .HasDefaultValue(0)
                .HasComment("注單狀態")
                .HasColumnName("bet_state");
            entity.Property(e => e.BetType)
                .HasDefaultValue(0)
                .HasComment("注單類型")
                .HasColumnName("bet_type");
            entity.Property(e => e.BrandId)
                .HasComment("平台識別碼")
                .HasColumnName("brand_id");
            entity.Property(e => e.CashoutState)
                .HasDefaultValue(0)
                .HasComment("兌現狀態")
                .HasColumnName("cashout_state");
            entity.Property(e => e.ClosedOn)
                .HasDefaultValueSql("'1970-01-01 00:00:00+00'::timestamp with time zone")
                .HasComment("結束時間")
                .HasColumnName("closed_on");
            entity.Property(e => e.Commission)
                .HasPrecision(18, 6)
                .HasComment("傭金")
                .HasColumnName("commission");
            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasComment("創建時間")
                .HasColumnName("created_on");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(16)
                .HasComment("貨幣代碼")
                .HasColumnName("currency_code");
            entity.Property(e => e.CurrencyRatio)
                .HasPrecision(18, 6)
                .HasComment("貨幣比例")
                .HasColumnName("currency_ratio");
            entity.Property(e => e.ExternalClosedOn)
                .HasDefaultValueSql("'1970-01-01 00:00:00+00'::timestamp with time zone")
                .HasComment("三方結算/結束時間")
                .HasColumnName("external_closed_on");
            entity.Property(e => e.ExternalPayoffOn)
                .HasDefaultValueSql("'1970-01-01 00:00:00+00'::timestamp with time zone")
                .HasComment("三方派彩時間")
                .HasColumnName("external_payoff_on");
            entity.Property(e => e.ExternalResettleOn)
                .HasDefaultValueSql("'1970-01-01 00:00:00+00'::timestamp with time zone")
                .HasComment("三方重新結算時間")
                .HasColumnName("external_resettle_on");
            entity.Property(e => e.ExternalRoundId)
                .HasMaxLength(255)
                .HasComment("三方局/回合識別碼")
                .HasColumnName("external_round_id");
            entity.Property(e => e.FreeGameState)
                .HasDefaultValue(0)
                .HasComment("免費遊戲狀態")
                .HasColumnName("free_game_state");
            entity.Property(e => e.GambleState)
                .HasDefaultValue(0)
                .HasComment("博取遊戲狀態")
                .HasColumnName("gamble_state");
            entity.Property(e => e.GameProviderConfigurationId)
                .HasComment("遊戲供應商設定識別碼")
                .HasColumnName("game_provider_configuration_id");
            entity.Property(e => e.Id)
                .HasComment("識別碼")
                .HasColumnName("id");
            entity.Property(e => e.Jackpot)
                .HasPrecision(18, 6)
                .HasComment("彩金")
                .HasColumnName("jackpot");
            entity.Property(e => e.JackpotState)
                .HasDefaultValue(0)
                .HasComment("彩金狀態")
                .HasColumnName("jackpot_state");
            entity.Property(e => e.LicenseeId)
                .HasComment("分公司識別碼")
                .HasColumnName("licensee_id");
            entity.Property(e => e.PlayerCode)
                .HasComment("玩家代碼")
                .HasColumnName("player_code");
            entity.Property(e => e.ResellerId)
                .HasComment("公司識別碼")
                .HasColumnName("reseller_id");
            entity.Property(e => e.ResetOn)
                .HasDefaultValueSql("'1970-01-01 00:00:00+00'::timestamp with time zone")
                .HasComment("重置時間")
                .HasColumnName("reset_on");
            entity.Property(e => e.ResetState)
                .HasDefaultValue(0)
                .HasComment("重置狀態")
                .HasColumnName("reset_state");
            entity.Property(e => e.ResettleState)
                .HasDefaultValue(0)
                .HasComment("重新結算狀態")
                .HasColumnName("resettle_state");
            entity.Property(e => e.Settle)
                .HasPrecision(18, 6)
                .HasComment("結算(包含本金)")
                .HasColumnName("settle");
            entity.Property(e => e.Turnover)
                .HasPrecision(18, 6)
                .HasComment("有效投注")
                .HasColumnName("turnover");
            entity.Property(e => e.UpdatedOn)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasComment("修改時間")
                .HasColumnName("updated_on");
            entity.Property(e => e.ValidBet)
                .HasPrecision(18, 6)
                .HasComment("實際/有效下注")
                .HasColumnName("valid_bet");
            entity.Property(e => e.WinLoss)
                .HasPrecision(18, 6)
                .HasComment("玩家損益/淨利")
                .HasColumnName("win_loss");
        });

        modelBuilder.Entity<GameBetting>(entity =>
        {
            entity.HasKey(e => new { e.GameProviderId, e.GameId, e.WalletId, e.ExternalBetId }).HasName("pk_game_betting");

            entity.ToTable("game_betting", "dbo");

            entity.Property(e => e.GameProviderId)
                .HasComment("遊戲供應商識別碼")
                .HasColumnName("game_provider_id");
            entity.Property(e => e.GameId)
                .HasComment("遊戲識別碼")
                .HasColumnName("game_id");
            entity.Property(e => e.WalletId)
                .HasComment("錢包識別碼")
                .HasColumnName("wallet_id");
            entity.Property(e => e.ExternalBetId)
                .HasMaxLength(255)
                .HasComment("三方投注單別碼")
                .HasColumnName("external_bet_id");
            entity.Property(e => e.AdditionalData)
                .HasDefaultValueSql("'{}'::jsonb")
                .HasComment("附加數據")
                .HasColumnType("jsonb")
                .HasColumnName("additional_data");
            entity.Property(e => e.Bet)
                .HasPrecision(18, 6)
                .HasComment("下注")
                .HasColumnName("bet");
            entity.Property(e => e.BetType)
                .HasDefaultValue(0)
                .HasComment("注單類型")
                .HasColumnName("bet_type");
            entity.Property(e => e.BrandId)
                .HasComment("平台識別碼")
                .HasColumnName("brand_id");
            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasComment("創建時間")
                .HasColumnName("created_on");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(16)
                .HasComment("貨幣代碼")
                .HasColumnName("currency_code");
            entity.Property(e => e.CurrencyRatio)
                .HasPrecision(18, 6)
                .HasComment("貨幣比例")
                .HasColumnName("currency_ratio");
            entity.Property(e => e.ExternalRoundId)
                .HasMaxLength(255)
                .HasComment("三方局/回合識別碼")
                .HasColumnName("external_round_id");
            entity.Property(e => e.GameProviderConfigurationId)
                .HasComment("遊戲供應商設定識別碼")
                .HasColumnName("game_provider_configuration_id");
            entity.Property(e => e.Id)
                .HasComment("識別碼")
                .HasColumnName("id");
            entity.Property(e => e.LicenseeId)
                .HasComment("分公司識別碼")
                .HasColumnName("licensee_id");
            entity.Property(e => e.PlayerCode)
                .HasComment("玩家代碼")
                .HasColumnName("player_code");
            entity.Property(e => e.ResellerId)
                .HasComment("公司識別碼")
                .HasColumnName("reseller_id");
            entity.Property(e => e.UpdatedOn)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasComment("修改時間")
                .HasColumnName("updated_on");
            entity.Property(e => e.ValidBet)
                .HasPrecision(18, 6)
                .HasComment("實際/有效下注")
                .HasColumnName("valid_bet");
        });

        modelBuilder.Entity<GameFundTransferTrace>(entity =>
        {
            entity.HasKey(e => new { e.GameProviderId, e.WalletId, e.PlayerCode }).HasName("pk_game_fund_transfer_trace");

            entity.ToTable("game_fund_transfer_trace", "dbo");

            entity.HasIndex(e => e.GameProviderId, "ix_game_fund_transfer_trace_game_provider_id");

            entity.HasIndex(e => e.PlayerCode, "ix_game_fund_transfer_trace_player_code");

            entity.HasIndex(e => e.WalletId, "ix_game_fund_transfer_trace_wallet_id");

            entity.Property(e => e.GameProviderId).HasColumnName("game_provider_id");
            entity.Property(e => e.WalletId).HasColumnName("wallet_id");
            entity.Property(e => e.PlayerCode).HasColumnName("player_code");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
            entity.Property(e => e.UpdatedOn).HasColumnName("updated_on");
        });

        modelBuilder.Entity<GamePlayerTransformIdnlive>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_game_player_transform_idnlive");

            entity.ToTable("game_player_transform_idnlive", "dbo");

            entity.HasIndex(e => e.PlayerCode, "ix_game_player_transform_idnlive_player_code").IsUnique();

            entity.Property(e => e.Id)
                .HasIdentityOptions(10000001L, null, null, null, null, null)
                .HasColumnName("id");
            entity.Property(e => e.Configuration)
                .HasColumnType("jsonb")
                .HasColumnName("configuration");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
            entity.Property(e => e.PlayerCode)
                .HasColumnType("character varying")
                .HasColumnName("player_code");
            entity.Property(e => e.UpdatedOn).HasColumnName("updated_on");

            entity.HasOne(d => d.PlayerCodeNavigation).WithOne(p => p.GamePlayerTransformIdnlive)
                .HasForeignKey<GamePlayerTransformIdnlive>(d => d.PlayerCode)
                .HasConstraintName("fk_game_player_transform_idnlive_players_player_code");
        });

        modelBuilder.Entity<GameProvider>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_game_providers");

            entity.ToTable("game_providers", "dbo");

            entity.HasIndex(e => e.Name, "ix_game_providers_name");

            entity.HasIndex(e => e.Name, "ix_trgm_game_providers_name")
                .HasMethod("gin")
                .HasOperators(new[] { "gin_trgm_ops" });

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.AllowKickPlayer).HasColumnName("allow_kick_player");
            entity.Property(e => e.AutoCloseRound).HasColumnName("auto_close_round");
            entity.Property(e => e.Code)
                .HasMaxLength(16)
                .HasColumnName("code");
            entity.Property(e => e.CreatedByUsername)
                .HasMaxLength(32)
                .HasColumnName("created_by_username");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
            entity.Property(e => e.Description)
                .HasMaxLength(128)
                .HasColumnName("description");
            entity.Property(e => e.Localization)
                .HasColumnType("jsonb")
                .HasColumnName("localization");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.PlaceBetTimeout)
                .HasDefaultValue((short)0)
                .HasColumnName("place_bet_timeout");
            entity.Property(e => e.SettleBetTimeout)
                .HasDefaultValue((short)0)
                .HasColumnName("settle_bet_timeout");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.SupportTestPlayer).HasColumnName("support_test_player");
            entity.Property(e => e.TransferWallet)
                .HasDefaultValue(false)
                .HasColumnName("transfer_wallet");
            entity.Property(e => e.UniqueId).HasColumnName("unique_id");
            entity.Property(e => e.UpdatedByUsername)
                .HasMaxLength(32)
                .HasColumnName("updated_by_username");
            entity.Property(e => e.UpdatedOn).HasColumnName("updated_on");
        });

        modelBuilder.Entity<GameProviderAggregateAuditLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_game_provider_aggregate_audit_log_id");

            entity.ToTable("game_provider_aggregate_audit_logs", "dbo");

            entity.HasIndex(e => e.CreatedOn, "ix_game_provider_aggregate_audit_log_created_on");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedByUserId).HasColumnName("created_by_user_id");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
            entity.Property(e => e.GameProviderId).HasColumnName("game_provider_id");
        });

        modelBuilder.Entity<GameProviderBetLimit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_game_provider_bet_limits");

            entity.ToTable("game_provider_bet_limits", "dbo");

            entity.HasIndex(e => e.CurrencyCode, "ix_game_provider_bet_limits_currency_code");

            entity.HasIndex(e => e.GameProviderId, "ix_game_provider_bet_limits_game_provider_id");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(16)
                .HasColumnName("currency_code");
            entity.Property(e => e.ExternalSetting)
                .HasMaxLength(255)
                .HasColumnName("external_setting");
            entity.Property(e => e.GameProviderId).HasColumnName("game_provider_id");
            entity.Property(e => e.MaxBet).HasColumnName("max_bet");
            entity.Property(e => e.MaxBetPerMatch).HasColumnName("max_bet_per_match");
            entity.Property(e => e.MinBet).HasColumnName("min_bet");

            entity.HasOne(d => d.CurrencyCodeNavigation).WithMany(p => p.GameProviderBetLimits)
                .HasForeignKey(d => d.CurrencyCode)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_game_provider_bet_limits_currencies_currency_code");

            entity.HasOne(d => d.GameProvider).WithMany(p => p.GameProviderBetLimits)
                .HasForeignKey(d => d.GameProviderId)
                .HasConstraintName("fk_game_provider_bet_limits_game_providers_game_provider_id");
        });

        modelBuilder.Entity<GameProviderConfiguration>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_game_provider_configurations");

            entity.ToTable("game_provider_configurations", "dbo");

            entity.HasIndex(e => e.GameProviderId, "ix_game_provider_configurations_game_provider_id");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.ClientId)
                .HasMaxLength(128)
                .HasColumnName("client_id");
            entity.Property(e => e.ConfigurationData).HasColumnName("configuration_data");
            entity.Property(e => e.CreatedByUsername)
                .HasMaxLength(32)
                .HasColumnName("created_by_username");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
            entity.Property(e => e.Description)
                .HasMaxLength(256)
                .HasColumnName("description");
            entity.Property(e => e.DesktopEndpoint)
                .HasMaxLength(1024)
                .HasColumnName("desktop_endpoint");
            entity.Property(e => e.GameProviderId).HasColumnName("game_provider_id");
            entity.Property(e => e.IsDefault).HasColumnName("is_default");
            entity.Property(e => e.MobileEndpoint)
                .HasMaxLength(1024)
                .HasColumnName("mobile_endpoint");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasColumnName("name");
            entity.Property(e => e.SecretKey)
                .HasMaxLength(64)
                .HasColumnName("secret_key");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.UpdatedByUsername)
                .HasMaxLength(32)
                .HasColumnName("updated_by_username");
            entity.Property(e => e.UpdatedOn).HasColumnName("updated_on");

            entity.HasOne(d => d.GameProvider).WithMany(p => p.GameProviderConfigurations)
                .HasForeignKey(d => d.GameProviderId)
                .HasConstraintName("fk_game_provider_configurations_game_providers_game_provider_id");
        });

        modelBuilder.Entity<GameProviderCurrency>(entity =>
        {
            entity.HasKey(e => new { e.GameProviderId, e.CurrencyCode }).HasName("pk_game_provider_currencies");

            entity.ToTable("game_provider_currencies", "dbo");

            entity.HasIndex(e => e.CurrencyCode, "ix_game_provider_currencies_currency_code");

            entity.Property(e => e.GameProviderId).HasColumnName("game_provider_id");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(16)
                .HasColumnName("currency_code");
            entity.Property(e => e.GameProviderCurrencyCode)
                .HasMaxLength(16)
                .HasColumnName("game_provider_currency_code");

            entity.HasOne(d => d.CurrencyCodeNavigation).WithMany(p => p.GameProviderCurrencies)
                .HasForeignKey(d => d.CurrencyCode)
                .HasConstraintName("fk_game_provider_currencies_currencies_currency_code");

            entity.HasOne(d => d.GameProvider).WithMany(p => p.GameProviderCurrencies)
                .HasForeignKey(d => d.GameProviderId)
                .HasConstraintName("fk_game_provider_currencies_game_providers_game_provider_id");
        });

        modelBuilder.Entity<GameProviderFundTransferTransaction>(entity =>
        {
            entity.HasKey(e => e.GameProviderFundTransferTransactionId).HasName("pk_game_provider_fund_transfer_transaction_id");

            entity.ToTable("game_provider_fund_transfer_transactions", "dbo");

            entity.HasIndex(e => e.PlayerCode, "ix_game_provider_fund_transfer_transactions_player_code");

            entity.HasIndex(e => e.TransactionId, "ix_game_provider_fund_transfer_transactions_transaction_id");

            entity.HasIndex(e => e.WalletId, "ix_game_provider_fund_transfer_transactions_wallet_id");

            entity.Property(e => e.GameProviderFundTransferTransactionId)
                .ValueGeneratedNever()
                .HasColumnName("game_provider_fund_transfer_transaction_id");
            entity.Property(e => e.Amount)
                .HasPrecision(18, 6)
                .HasColumnName("amount");
            entity.Property(e => e.Balance)
                .HasPrecision(18, 6)
                .HasColumnName("balance");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
            entity.Property(e => e.Description)
                .HasMaxLength(256)
                .HasColumnName("description");
            entity.Property(e => e.FromWallet).HasColumnName("from_wallet");
            entity.Property(e => e.FundSource).HasColumnName("fund_source");
            entity.Property(e => e.GameProviderId).HasColumnName("game_provider_id");
            entity.Property(e => e.GameProviderTransactionId).HasColumnName("game_provider_transaction_id");
            entity.Property(e => e.PlayerCode).HasColumnName("player_code");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.ToWallet).HasColumnName("to_wallet");
            entity.Property(e => e.TransactionId).HasColumnName("transaction_id");
            entity.Property(e => e.UpdatedOn).HasColumnName("updated_on");
            entity.Property(e => e.WalletId).HasColumnName("wallet_id");
        });

        modelBuilder.Entity<GameProviderLanguage>(entity =>
        {
            entity.HasKey(e => new { e.GameProviderId, e.CultureCode }).HasName("pk_game_provider_languages");

            entity.ToTable("game_provider_languages", "dbo");

            entity.HasIndex(e => e.CultureCode, "ix_game_provider_languages_culture_code");

            entity.Property(e => e.GameProviderId).HasColumnName("game_provider_id");
            entity.Property(e => e.CultureCode)
                .HasMaxLength(6)
                .HasColumnName("culture_code");
            entity.Property(e => e.GameProviderCultureCode)
                .HasMaxLength(8)
                .HasColumnName("game_provider_culture_code");

            entity.HasOne(d => d.CultureCodeNavigation).WithMany(p => p.GameProviderLanguages)
                .HasForeignKey(d => d.CultureCode)
                .HasConstraintName("fk_game_provider_languages_languages_culture_code");

            entity.HasOne(d => d.GameProvider).WithMany(p => p.GameProviderLanguages)
                .HasForeignKey(d => d.GameProviderId)
                .HasConstraintName("fk_game_provider_languages_game_providers_game_provider_id");
        });

        modelBuilder.Entity<GameWagerPlayerAccum>(entity =>
        {
            entity.HasKey(e => new { e.AccumOn, e.ResellerId, e.LicenseeId, e.BrandId, e.PlayerCode }).HasName("pk_game_wager_player_accums");

            entity.ToTable("game_wager_player_accums", "dbo");

            entity.HasIndex(e => e.AccumOn, "ix_game_wager_player_accums_accum_on");

            entity.HasIndex(e => new { e.AccumOn, e.BrandId }, "ix_game_wager_player_accums_brand_id");

            entity.HasIndex(e => new { e.AccumOn, e.LicenseeId }, "ix_game_wager_player_accums_licensee_id");

            entity.HasIndex(e => new { e.AccumOn, e.PlayerCode }, "ix_game_wager_player_accums_player_code");

            entity.HasIndex(e => new { e.AccumOn, e.ResellerId }, "ix_game_wager_player_accums_reseller_id");

            entity.Property(e => e.AccumOn)
                .HasComment("累積時間")
                .HasColumnName("accum_on");
            entity.Property(e => e.ResellerId)
                .HasComment("公司識別碼")
                .HasColumnName("reseller_id");
            entity.Property(e => e.LicenseeId)
                .HasComment("分公司識別碼")
                .HasColumnName("licensee_id");
            entity.Property(e => e.BrandId)
                .HasComment("平台識別碼")
                .HasColumnName("brand_id");
            entity.Property(e => e.PlayerCode)
                .HasMaxLength(16)
                .HasComment("玩家代碼")
                .HasColumnName("player_code");
            entity.Property(e => e.Bet)
                .HasPrecision(18, 6)
                .HasComment("下注")
                .HasColumnName("bet");
            entity.Property(e => e.Commission)
                .HasPrecision(18, 6)
                .HasComment("傭金")
                .HasColumnName("commission");
            entity.Property(e => e.Count)
                .HasDefaultValue(0)
                .HasComment("筆數")
                .HasColumnName("count");
            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasComment("創建時間")
                .HasColumnName("created_on");
            entity.Property(e => e.Settle)
                .HasPrecision(18, 6)
                .HasComment("結算(包含本金)")
                .HasColumnName("settle");
            entity.Property(e => e.Turnover)
                .HasPrecision(18, 6)
                .HasComment("有效投注")
                .HasColumnName("turnover");
            entity.Property(e => e.UpdatedOn)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasComment("修改時間")
                .HasColumnName("updated_on");
            entity.Property(e => e.ValidBet)
                .HasPrecision(18, 6)
                .HasComment("實際/有效下注")
                .HasColumnName("valid_bet");
            entity.Property(e => e.WinLoss)
                .HasPrecision(18, 6)
                .HasComment("玩家損益/淨利")
                .HasColumnName("win_loss");
        });

        modelBuilder.Entity<GameWagerStatCloses2>(entity =>
        {
            entity.HasKey(e => new { e.StatOn, e.ResellerId, e.LicenseeId, e.BrandId, e.PlayerCode, e.GameProviderId, e.GameId }).HasName("pk_game_wager_stat_closes2");

            entity.ToTable("game_wager_stat_closes2", "dbo");

            entity.Property(e => e.StatOn)
                .HasComment("統計時間")
                .HasColumnName("stat_on");
            entity.Property(e => e.ResellerId)
                .HasComment("公司識別碼")
                .HasColumnName("reseller_id");
            entity.Property(e => e.LicenseeId)
                .HasComment("分公司識別碼")
                .HasColumnName("licensee_id");
            entity.Property(e => e.BrandId)
                .HasComment("平台識別碼")
                .HasColumnName("brand_id");
            entity.Property(e => e.PlayerCode)
                .HasMaxLength(16)
                .HasComment("玩家代碼")
                .HasColumnName("player_code");
            entity.Property(e => e.GameProviderId)
                .HasComment("遊戲供應商識別碼")
                .HasColumnName("game_provider_id");
            entity.Property(e => e.GameId)
                .HasComment("遊戲識別碼")
                .HasColumnName("game_id");
            entity.Property(e => e.Bet)
                .HasPrecision(18, 6)
                .HasComment("下注")
                .HasColumnName("bet");
            entity.Property(e => e.Commission)
                .HasPrecision(18, 6)
                .HasComment("傭金")
                .HasColumnName("commission");
            entity.Property(e => e.Count)
                .HasDefaultValue(0)
                .HasComment("筆數")
                .HasColumnName("count");
            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasComment("創建時間")
                .HasColumnName("created_on");
            entity.Property(e => e.Settle)
                .HasPrecision(18, 6)
                .HasComment("結算(包含本金)")
                .HasColumnName("settle");
            entity.Property(e => e.Turnover)
                .HasPrecision(18, 6)
                .HasComment("有效投注")
                .HasColumnName("turnover");
            entity.Property(e => e.UpdatedOn)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasComment("修改時間")
                .HasColumnName("updated_on");
            entity.Property(e => e.ValidBet)
                .HasPrecision(18, 6)
                .HasComment("實際/有效下注")
                .HasColumnName("valid_bet");
            entity.Property(e => e.WinLoss)
                .HasPrecision(18, 6)
                .HasComment("玩家損益/淨利")
                .HasColumnName("win_loss");
        });

        modelBuilder.Entity<GameWagerStatClosesDefault>(entity =>
        {
            entity.HasKey(e => new { e.StatOn, e.ResellerId, e.LicenseeId, e.BrandId, e.PlayerCode, e.GameProviderId, e.GameId }).HasName("game_wager_stat_closes_default_pkey");

            entity.ToTable("game_wager_stat_closes_default", "dbo");

            entity.HasIndex(e => new { e.StatOn, e.BrandId }, "game_wager_stat_closes_default_stat_on_brand_id_idx");

            entity.HasIndex(e => new { e.StatOn, e.GameId }, "game_wager_stat_closes_default_stat_on_game_id_idx");

            entity.HasIndex(e => new { e.StatOn, e.GameProviderId }, "game_wager_stat_closes_default_stat_on_game_provider_id_idx");

            entity.HasIndex(e => e.StatOn, "game_wager_stat_closes_default_stat_on_idx");

            entity.HasIndex(e => new { e.StatOn, e.LicenseeId }, "game_wager_stat_closes_default_stat_on_licensee_id_idx");

            entity.HasIndex(e => new { e.StatOn, e.PlayerCode }, "game_wager_stat_closes_default_stat_on_player_code_idx");

            entity.HasIndex(e => new { e.StatOn, e.ResellerId }, "game_wager_stat_closes_default_stat_on_reseller_id_idx");

            entity.Property(e => e.StatOn)
                .HasComment("統計時間")
                .HasColumnName("stat_on");
            entity.Property(e => e.ResellerId)
                .HasComment("公司識別碼")
                .HasColumnName("reseller_id");
            entity.Property(e => e.LicenseeId)
                .HasComment("分公司識別碼")
                .HasColumnName("licensee_id");
            entity.Property(e => e.BrandId)
                .HasComment("平台識別碼")
                .HasColumnName("brand_id");
            entity.Property(e => e.PlayerCode)
                .HasMaxLength(16)
                .HasComment("玩家代碼")
                .HasColumnName("player_code");
            entity.Property(e => e.GameProviderId)
                .HasComment("遊戲供應商識別碼")
                .HasColumnName("game_provider_id");
            entity.Property(e => e.GameId)
                .HasComment("遊戲識別碼")
                .HasColumnName("game_id");
            entity.Property(e => e.Bet)
                .HasPrecision(18, 6)
                .HasComment("下注")
                .HasColumnName("bet");
            entity.Property(e => e.Commission)
                .HasPrecision(18, 6)
                .HasComment("傭金")
                .HasColumnName("commission");
            entity.Property(e => e.Count)
                .HasDefaultValue(0)
                .HasComment("筆數")
                .HasColumnName("count");
            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasComment("創建時間")
                .HasColumnName("created_on");
            entity.Property(e => e.Settle)
                .HasPrecision(18, 6)
                .HasComment("結算(包含本金)")
                .HasColumnName("settle");
            entity.Property(e => e.Turnover)
                .HasPrecision(18, 6)
                .HasComment("有效投注")
                .HasColumnName("turnover");
            entity.Property(e => e.UpdatedOn)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasComment("修改時間")
                .HasColumnName("updated_on");
            entity.Property(e => e.ValidBet)
                .HasPrecision(18, 6)
                .HasComment("實際/有效下注")
                .HasColumnName("valid_bet");
            entity.Property(e => e.WinLoss)
                .HasPrecision(18, 6)
                .HasComment("玩家損益/淨利")
                .HasColumnName("win_loss");
        });

        modelBuilder.Entity<GameWagerStatDailyClose>(entity =>
        {
            entity.HasKey(e => new { e.StatOn, e.ResellerId, e.LicenseeId, e.BrandId, e.PlayerCode, e.GameProviderId, e.GameId }).HasName("pk_game_wager_stat_daily_closes");

            entity.ToTable("game_wager_stat_daily_closes", "dbo");

            entity.HasIndex(e => new { e.StatOn, e.BrandId }, "ix_game_wager_stat_d_c_brand_id");

            entity.HasIndex(e => new { e.StatOn, e.StatDayOn, e.BrandId }, "ix_game_wager_stat_d_c_d_brand_id");

            entity.HasIndex(e => new { e.StatOn, e.StatDayOn, e.GameId }, "ix_game_wager_stat_d_c_d_game_id");

            entity.HasIndex(e => new { e.StatOn, e.StatDayOn, e.GameProviderId }, "ix_game_wager_stat_d_c_d_game_provider_id");

            entity.HasIndex(e => new { e.StatOn, e.StatDayOn, e.LicenseeId }, "ix_game_wager_stat_d_c_d_licensee_id");

            entity.HasIndex(e => new { e.StatOn, e.StatDayOn, e.PlayerCode }, "ix_game_wager_stat_d_c_d_player_code");

            entity.HasIndex(e => new { e.StatOn, e.StatDayOn, e.ResellerId }, "ix_game_wager_stat_d_c_d_reseller_id");

            entity.HasIndex(e => new { e.StatOn, e.StatDayOn }, "ix_game_wager_stat_d_c_d_stat_day_on");

            entity.HasIndex(e => new { e.StatOn, e.GameId }, "ix_game_wager_stat_d_c_game_id");

            entity.HasIndex(e => new { e.StatOn, e.GameProviderId }, "ix_game_wager_stat_d_c_game_provider_id");

            entity.HasIndex(e => new { e.StatOn, e.LicenseeId }, "ix_game_wager_stat_d_c_licensee_id");

            entity.HasIndex(e => new { e.StatOn, e.PlayerCode }, "ix_game_wager_stat_d_c_player_code");

            entity.HasIndex(e => new { e.StatOn, e.ResellerId }, "ix_game_wager_stat_d_c_reseller_id");

            entity.HasIndex(e => e.StatOn, "ix_game_wager_stat_d_c_stat_on");

            entity.Property(e => e.StatOn)
                .HasComment("統計時間")
                .HasColumnName("stat_on");
            entity.Property(e => e.ResellerId)
                .HasComment("公司識別碼")
                .HasColumnName("reseller_id");
            entity.Property(e => e.LicenseeId)
                .HasComment("分公司識別碼")
                .HasColumnName("licensee_id");
            entity.Property(e => e.BrandId)
                .HasComment("平台識別碼")
                .HasColumnName("brand_id");
            entity.Property(e => e.PlayerCode)
                .HasMaxLength(16)
                .HasComment("玩家代碼")
                .HasColumnName("player_code");
            entity.Property(e => e.GameProviderId)
                .HasComment("遊戲供應商識別碼")
                .HasColumnName("game_provider_id");
            entity.Property(e => e.GameId)
                .HasComment("遊戲識別碼")
                .HasColumnName("game_id");
            entity.Property(e => e.Bet)
                .HasPrecision(18, 6)
                .HasComment("下注")
                .HasColumnName("bet");
            entity.Property(e => e.Commission)
                .HasPrecision(18, 6)
                .HasComment("傭金")
                .HasColumnName("commission");
            entity.Property(e => e.Count)
                .HasDefaultValue(0)
                .HasComment("筆數")
                .HasColumnName("count");
            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasComment("創建時間")
                .HasColumnName("created_on");
            entity.Property(e => e.Settle)
                .HasPrecision(18, 6)
                .HasComment("結算(包含本金)")
                .HasColumnName("settle");
            entity.Property(e => e.StatDayOn)
                .HasDefaultValueSql("'1990-01-01'::date")
                .HasComment("統計日時間")
                .HasColumnName("stat_day_on");
            entity.Property(e => e.StatTimeSpan)
                .HasComment("統計時間跨度")
                .HasColumnName("stat_time_span");
            entity.Property(e => e.Turnover)
                .HasPrecision(18, 6)
                .HasComment("有效投注")
                .HasColumnName("turnover");
            entity.Property(e => e.UpdatedOn)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasComment("修改時間")
                .HasColumnName("updated_on");
            entity.Property(e => e.ValidBet)
                .HasPrecision(18, 6)
                .HasComment("實際/有效下注")
                .HasColumnName("valid_bet");
            entity.Property(e => e.WinLoss)
                .HasPrecision(18, 6)
                .HasComment("玩家損益/淨利")
                .HasColumnName("win_loss");
        });

        modelBuilder.Entity<GameWagerStatDailyZoneClose>(entity =>
        {
            entity.HasKey(e => new { e.StatOn, e.ResellerId, e.LicenseeId, e.BrandId, e.PlayerCode, e.GameProviderId, e.GameId }).HasName("pk_game_wager_stat_daily_zone_closes");

            entity.ToTable("game_wager_stat_daily_zone_closes", "dbo");

            entity.HasIndex(e => new { e.StatOn, e.BrandId }, "ix_game_wager_stat_d_z_c_brand_id");

            entity.HasIndex(e => new { e.StatOn, e.StatDayOn, e.BrandId }, "ix_game_wager_stat_d_z_c_d_brand_id");

            entity.HasIndex(e => new { e.StatOn, e.StatDayOn, e.GameId }, "ix_game_wager_stat_d_z_c_d_game_id");

            entity.HasIndex(e => new { e.StatOn, e.StatDayOn, e.GameProviderId }, "ix_game_wager_stat_d_z_c_d_game_provider_id");

            entity.HasIndex(e => new { e.StatOn, e.StatDayOn, e.LicenseeId }, "ix_game_wager_stat_d_z_c_d_licensee_id");

            entity.HasIndex(e => new { e.StatOn, e.StatDayOn, e.PlayerCode }, "ix_game_wager_stat_d_z_c_d_player_code");

            entity.HasIndex(e => new { e.StatOn, e.StatDayOn, e.ResellerId }, "ix_game_wager_stat_d_z_c_d_reseller_id");

            entity.HasIndex(e => new { e.StatOn, e.StatDayOn }, "ix_game_wager_stat_d_z_c_d_stat_day_on");

            entity.HasIndex(e => new { e.StatOn, e.GameId }, "ix_game_wager_stat_d_z_c_game_id");

            entity.HasIndex(e => new { e.StatOn, e.GameProviderId }, "ix_game_wager_stat_d_z_c_game_provider_id");

            entity.HasIndex(e => new { e.StatOn, e.LicenseeId }, "ix_game_wager_stat_d_z_c_licensee_id");

            entity.HasIndex(e => new { e.StatOn, e.PlayerCode }, "ix_game_wager_stat_d_z_c_player_code");

            entity.HasIndex(e => new { e.StatOn, e.ResellerId }, "ix_game_wager_stat_d_z_c_reseller_id");

            entity.HasIndex(e => e.StatOn, "ix_game_wager_stat_d_z_c_stat_on");

            entity.Property(e => e.StatOn)
                .HasComment("統計時間")
                .HasColumnName("stat_on");
            entity.Property(e => e.ResellerId)
                .HasComment("公司識別碼")
                .HasColumnName("reseller_id");
            entity.Property(e => e.LicenseeId)
                .HasComment("分公司識別碼")
                .HasColumnName("licensee_id");
            entity.Property(e => e.BrandId)
                .HasComment("平台識別碼")
                .HasColumnName("brand_id");
            entity.Property(e => e.PlayerCode)
                .HasMaxLength(16)
                .HasComment("玩家代碼")
                .HasColumnName("player_code");
            entity.Property(e => e.GameProviderId)
                .HasComment("遊戲供應商識別碼")
                .HasColumnName("game_provider_id");
            entity.Property(e => e.GameId)
                .HasComment("遊戲識別碼")
                .HasColumnName("game_id");
            entity.Property(e => e.Bet)
                .HasPrecision(18, 6)
                .HasComment("下注")
                .HasColumnName("bet");
            entity.Property(e => e.Commission)
                .HasPrecision(18, 6)
                .HasComment("傭金")
                .HasColumnName("commission");
            entity.Property(e => e.Count)
                .HasDefaultValue(0)
                .HasComment("筆數")
                .HasColumnName("count");
            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasComment("創建時間")
                .HasColumnName("created_on");
            entity.Property(e => e.Settle)
                .HasPrecision(18, 6)
                .HasComment("結算(包含本金)")
                .HasColumnName("settle");
            entity.Property(e => e.StatDayOn)
                .HasDefaultValueSql("'1990-01-01'::date")
                .HasComment("統計日時間")
                .HasColumnName("stat_day_on");
            entity.Property(e => e.StatTimeSpan)
                .HasComment("統計時間跨度")
                .HasColumnName("stat_time_span");
            entity.Property(e => e.Turnover)
                .HasPrecision(18, 6)
                .HasComment("有效投注")
                .HasColumnName("turnover");
            entity.Property(e => e.UpdatedOn)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasComment("修改時間")
                .HasColumnName("updated_on");
            entity.Property(e => e.ValidBet)
                .HasPrecision(18, 6)
                .HasComment("實際/有效下注")
                .HasColumnName("valid_bet");
            entity.Property(e => e.WinLoss)
                .HasPrecision(18, 6)
                .HasComment("玩家損益/淨利")
                .HasColumnName("win_loss");
        });

        modelBuilder.Entity<GameWagerStatHourlyCloses2>(entity =>
        {
            entity.HasKey(e => new { e.StatOn, e.ResellerId, e.LicenseeId, e.BrandId, e.PlayerCode, e.GameProviderId, e.GameId }).HasName("pk_game_wager_stat_hourly_closes2");

            entity.ToTable("game_wager_stat_hourly_closes2", "dbo");

            entity.Property(e => e.StatOn)
                .HasComment("統計時間")
                .HasColumnName("stat_on");
            entity.Property(e => e.ResellerId)
                .HasComment("公司識別碼")
                .HasColumnName("reseller_id");
            entity.Property(e => e.LicenseeId)
                .HasComment("分公司識別碼")
                .HasColumnName("licensee_id");
            entity.Property(e => e.BrandId)
                .HasComment("平台識別碼")
                .HasColumnName("brand_id");
            entity.Property(e => e.PlayerCode)
                .HasMaxLength(16)
                .HasComment("玩家代碼")
                .HasColumnName("player_code");
            entity.Property(e => e.GameProviderId)
                .HasComment("遊戲供應商識別碼")
                .HasColumnName("game_provider_id");
            entity.Property(e => e.GameId)
                .HasComment("遊戲識別碼")
                .HasColumnName("game_id");
            entity.Property(e => e.Bet)
                .HasPrecision(18, 6)
                .HasComment("下注")
                .HasColumnName("bet");
            entity.Property(e => e.Commission)
                .HasPrecision(18, 6)
                .HasComment("傭金")
                .HasColumnName("commission");
            entity.Property(e => e.Count)
                .HasDefaultValue(0)
                .HasComment("筆數")
                .HasColumnName("count");
            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasComment("創建時間")
                .HasColumnName("created_on");
            entity.Property(e => e.Settle)
                .HasPrecision(18, 6)
                .HasComment("結算(包含本金)")
                .HasColumnName("settle");
            entity.Property(e => e.StatDayOn)
                .HasDefaultValueSql("'1990-01-01'::date")
                .HasComment("統計日時間")
                .HasColumnName("stat_day_on");
            entity.Property(e => e.StatHourOn)
                .HasComment("統計小時時間")
                .HasColumnName("stat_hour_on");
            entity.Property(e => e.StatTimeSpan)
                .HasComment("統計時間跨度")
                .HasColumnName("stat_time_span");
            entity.Property(e => e.Turnover)
                .HasPrecision(18, 6)
                .HasComment("有效投注")
                .HasColumnName("turnover");
            entity.Property(e => e.UpdatedOn)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasComment("修改時間")
                .HasColumnName("updated_on");
            entity.Property(e => e.ValidBet)
                .HasPrecision(18, 6)
                .HasComment("實際/有效下注")
                .HasColumnName("valid_bet");
            entity.Property(e => e.WinLoss)
                .HasPrecision(18, 6)
                .HasComment("玩家損益/淨利")
                .HasColumnName("win_loss");
        });

        modelBuilder.Entity<GameWagerStatHourlyClosesDefault>(entity =>
        {
            entity.HasKey(e => new { e.StatOn, e.ResellerId, e.LicenseeId, e.BrandId, e.PlayerCode, e.GameProviderId, e.GameId }).HasName("game_wager_stat_hourly_closes_default_pkey");

            entity.ToTable("game_wager_stat_hourly_closes_default", "dbo");

            entity.HasIndex(e => new { e.StatOn, e.StatDayOn, e.BrandId }, "game_wager_stat_hourly_closes__stat_on_stat_day_on_brand_id_idx");

            entity.HasIndex(e => new { e.StatOn, e.StatDayOn, e.GameId }, "game_wager_stat_hourly_closes_d_stat_on_stat_day_on_game_id_idx");

            entity.HasIndex(e => new { e.StatOn, e.GameProviderId }, "game_wager_stat_hourly_closes_defa_stat_on_game_provider_id_idx");

            entity.HasIndex(e => new { e.StatOn, e.BrandId }, "game_wager_stat_hourly_closes_default_stat_on_brand_id_idx");

            entity.HasIndex(e => new { e.StatOn, e.GameId }, "game_wager_stat_hourly_closes_default_stat_on_game_id_idx");

            entity.HasIndex(e => e.StatOn, "game_wager_stat_hourly_closes_default_stat_on_idx");

            entity.HasIndex(e => new { e.StatOn, e.LicenseeId }, "game_wager_stat_hourly_closes_default_stat_on_licensee_id_idx");

            entity.HasIndex(e => new { e.StatOn, e.PlayerCode }, "game_wager_stat_hourly_closes_default_stat_on_player_code_idx");

            entity.HasIndex(e => new { e.StatOn, e.ResellerId }, "game_wager_stat_hourly_closes_default_stat_on_reseller_id_idx");

            entity.HasIndex(e => new { e.StatOn, e.StatDayOn }, "game_wager_stat_hourly_closes_default_stat_on_stat_day_on_idx");

            entity.HasIndex(e => new { e.StatOn, e.StatDayOn, e.GameProviderId }, "game_wager_stat_hourly_closes_stat_on_stat_day_on_game_prov_idx");

            entity.HasIndex(e => new { e.StatOn, e.StatDayOn, e.LicenseeId }, "game_wager_stat_hourly_closes_stat_on_stat_day_on_licensee__idx");

            entity.HasIndex(e => new { e.StatOn, e.StatDayOn, e.PlayerCode }, "game_wager_stat_hourly_closes_stat_on_stat_day_on_player_co_idx");

            entity.HasIndex(e => new { e.StatOn, e.StatDayOn, e.ResellerId }, "game_wager_stat_hourly_closes_stat_on_stat_day_on_reseller__idx");

            entity.HasIndex(e => new { e.StatOn, e.StatDayOn, e.StatHourOn, e.GameId }, "game_wager_stat_hourly_closes_stat_on_stat_day_on_stat_hou_idx1");

            entity.HasIndex(e => new { e.StatOn, e.StatDayOn, e.StatHourOn, e.GameProviderId }, "game_wager_stat_hourly_closes_stat_on_stat_day_on_stat_hou_idx2");

            entity.HasIndex(e => new { e.StatOn, e.StatDayOn, e.StatHourOn, e.LicenseeId }, "game_wager_stat_hourly_closes_stat_on_stat_day_on_stat_hou_idx3");

            entity.HasIndex(e => new { e.StatOn, e.StatDayOn, e.StatHourOn, e.PlayerCode }, "game_wager_stat_hourly_closes_stat_on_stat_day_on_stat_hou_idx4");

            entity.HasIndex(e => new { e.StatOn, e.StatDayOn, e.StatHourOn, e.ResellerId }, "game_wager_stat_hourly_closes_stat_on_stat_day_on_stat_hou_idx5");

            entity.HasIndex(e => new { e.StatOn, e.StatDayOn, e.StatHourOn }, "game_wager_stat_hourly_closes_stat_on_stat_day_on_stat_hou_idx6");

            entity.HasIndex(e => new { e.StatOn, e.StatDayOn, e.StatHourOn, e.BrandId }, "game_wager_stat_hourly_closes_stat_on_stat_day_on_stat_hour_idx");

            entity.Property(e => e.StatOn)
                .HasComment("統計時間")
                .HasColumnName("stat_on");
            entity.Property(e => e.ResellerId)
                .HasComment("公司識別碼")
                .HasColumnName("reseller_id");
            entity.Property(e => e.LicenseeId)
                .HasComment("分公司識別碼")
                .HasColumnName("licensee_id");
            entity.Property(e => e.BrandId)
                .HasComment("平台識別碼")
                .HasColumnName("brand_id");
            entity.Property(e => e.PlayerCode)
                .HasMaxLength(16)
                .HasComment("玩家代碼")
                .HasColumnName("player_code");
            entity.Property(e => e.GameProviderId)
                .HasComment("遊戲供應商識別碼")
                .HasColumnName("game_provider_id");
            entity.Property(e => e.GameId)
                .HasComment("遊戲識別碼")
                .HasColumnName("game_id");
            entity.Property(e => e.Bet)
                .HasPrecision(18, 6)
                .HasComment("下注")
                .HasColumnName("bet");
            entity.Property(e => e.Commission)
                .HasPrecision(18, 6)
                .HasComment("傭金")
                .HasColumnName("commission");
            entity.Property(e => e.Count)
                .HasDefaultValue(0)
                .HasComment("筆數")
                .HasColumnName("count");
            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasComment("創建時間")
                .HasColumnName("created_on");
            entity.Property(e => e.Settle)
                .HasPrecision(18, 6)
                .HasComment("結算(包含本金)")
                .HasColumnName("settle");
            entity.Property(e => e.StatDayOn)
                .HasDefaultValueSql("'1990-01-01'::date")
                .HasComment("統計日時間")
                .HasColumnName("stat_day_on");
            entity.Property(e => e.StatHourOn)
                .HasComment("統計小時時間")
                .HasColumnName("stat_hour_on");
            entity.Property(e => e.StatTimeSpan)
                .HasComment("統計時間跨度")
                .HasColumnName("stat_time_span");
            entity.Property(e => e.Turnover)
                .HasPrecision(18, 6)
                .HasComment("有效投注")
                .HasColumnName("turnover");
            entity.Property(e => e.UpdatedOn)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasComment("修改時間")
                .HasColumnName("updated_on");
            entity.Property(e => e.ValidBet)
                .HasPrecision(18, 6)
                .HasComment("實際/有效下注")
                .HasColumnName("valid_bet");
            entity.Property(e => e.WinLoss)
                .HasPrecision(18, 6)
                .HasComment("玩家損益/淨利")
                .HasColumnName("win_loss");
        });

        modelBuilder.Entity<GameWagerStatHourlyZoneCloses2>(entity =>
        {
            entity.HasKey(e => new { e.StatOn, e.ResellerId, e.LicenseeId, e.BrandId, e.PlayerCode, e.GameProviderId, e.GameId }).HasName("pk_game_wager_stat_hourly_zone_closes2");

            entity.ToTable("game_wager_stat_hourly_zone_closes2", "dbo");

            entity.Property(e => e.StatOn)
                .HasComment("統計時間")
                .HasColumnName("stat_on");
            entity.Property(e => e.ResellerId)
                .HasComment("公司識別碼")
                .HasColumnName("reseller_id");
            entity.Property(e => e.LicenseeId)
                .HasComment("分公司識別碼")
                .HasColumnName("licensee_id");
            entity.Property(e => e.BrandId)
                .HasComment("平台識別碼")
                .HasColumnName("brand_id");
            entity.Property(e => e.PlayerCode)
                .HasMaxLength(16)
                .HasComment("玩家代碼")
                .HasColumnName("player_code");
            entity.Property(e => e.GameProviderId)
                .HasComment("遊戲供應商識別碼")
                .HasColumnName("game_provider_id");
            entity.Property(e => e.GameId)
                .HasComment("遊戲識別碼")
                .HasColumnName("game_id");
            entity.Property(e => e.Bet)
                .HasPrecision(18, 6)
                .HasComment("下注")
                .HasColumnName("bet");
            entity.Property(e => e.Commission)
                .HasPrecision(18, 6)
                .HasComment("傭金")
                .HasColumnName("commission");
            entity.Property(e => e.Count)
                .HasDefaultValue(0)
                .HasComment("筆數")
                .HasColumnName("count");
            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasComment("創建時間")
                .HasColumnName("created_on");
            entity.Property(e => e.Settle)
                .HasPrecision(18, 6)
                .HasComment("結算(包含本金)")
                .HasColumnName("settle");
            entity.Property(e => e.StatDayOn)
                .HasDefaultValueSql("'1990-01-01'::date")
                .HasComment("統計日時間")
                .HasColumnName("stat_day_on");
            entity.Property(e => e.StatHourOn)
                .HasComment("統計小時時間")
                .HasColumnName("stat_hour_on");
            entity.Property(e => e.StatTimeSpan)
                .HasComment("統計時間跨度")
                .HasColumnName("stat_time_span");
            entity.Property(e => e.Turnover)
                .HasPrecision(18, 6)
                .HasComment("有效投注")
                .HasColumnName("turnover");
            entity.Property(e => e.UpdatedOn)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasComment("修改時間")
                .HasColumnName("updated_on");
            entity.Property(e => e.ValidBet)
                .HasPrecision(18, 6)
                .HasComment("實際/有效下注")
                .HasColumnName("valid_bet");
            entity.Property(e => e.WinLoss)
                .HasPrecision(18, 6)
                .HasComment("玩家損益/淨利")
                .HasColumnName("win_loss");
        });

        modelBuilder.Entity<GameWagerStatHourlyZoneClosesDefault>(entity =>
        {
            entity.HasKey(e => new { e.StatOn, e.ResellerId, e.LicenseeId, e.BrandId, e.PlayerCode, e.GameProviderId, e.GameId }).HasName("game_wager_stat_hourly_zone_closes_default_pkey");

            entity.ToTable("game_wager_stat_hourly_zone_closes_default", "dbo");

            entity.HasIndex(e => new { e.StatOn, e.StatDayOn, e.GameProviderId }, "game_wager_stat_hourly_zone_c_stat_on_stat_day_on_game_prov_idx");

            entity.HasIndex(e => new { e.StatOn, e.StatDayOn, e.LicenseeId }, "game_wager_stat_hourly_zone_c_stat_on_stat_day_on_licensee__idx");

            entity.HasIndex(e => new { e.StatOn, e.StatDayOn, e.PlayerCode }, "game_wager_stat_hourly_zone_c_stat_on_stat_day_on_player_co_idx");

            entity.HasIndex(e => new { e.StatOn, e.StatDayOn, e.ResellerId }, "game_wager_stat_hourly_zone_c_stat_on_stat_day_on_reseller__idx");

            entity.HasIndex(e => new { e.StatOn, e.StatDayOn, e.StatHourOn, e.GameId }, "game_wager_stat_hourly_zone_c_stat_on_stat_day_on_stat_hou_idx1");

            entity.HasIndex(e => new { e.StatOn, e.StatDayOn, e.StatHourOn, e.GameProviderId }, "game_wager_stat_hourly_zone_c_stat_on_stat_day_on_stat_hou_idx2");

            entity.HasIndex(e => new { e.StatOn, e.StatDayOn, e.StatHourOn, e.LicenseeId }, "game_wager_stat_hourly_zone_c_stat_on_stat_day_on_stat_hou_idx3");

            entity.HasIndex(e => new { e.StatOn, e.StatDayOn, e.StatHourOn, e.PlayerCode }, "game_wager_stat_hourly_zone_c_stat_on_stat_day_on_stat_hou_idx4");

            entity.HasIndex(e => new { e.StatOn, e.StatDayOn, e.StatHourOn, e.ResellerId }, "game_wager_stat_hourly_zone_c_stat_on_stat_day_on_stat_hou_idx5");

            entity.HasIndex(e => new { e.StatOn, e.StatDayOn, e.StatHourOn }, "game_wager_stat_hourly_zone_c_stat_on_stat_day_on_stat_hou_idx6");

            entity.HasIndex(e => new { e.StatOn, e.StatDayOn, e.StatHourOn, e.BrandId }, "game_wager_stat_hourly_zone_c_stat_on_stat_day_on_stat_hour_idx");

            entity.HasIndex(e => new { e.StatOn, e.StatDayOn, e.BrandId }, "game_wager_stat_hourly_zone_cl_stat_on_stat_day_on_brand_id_idx");

            entity.HasIndex(e => new { e.StatOn, e.StatDayOn, e.GameId }, "game_wager_stat_hourly_zone_clo_stat_on_stat_day_on_game_id_idx");

            entity.HasIndex(e => new { e.StatOn, e.LicenseeId }, "game_wager_stat_hourly_zone_closes_defa_stat_on_licensee_id_idx");

            entity.HasIndex(e => new { e.StatOn, e.PlayerCode }, "game_wager_stat_hourly_zone_closes_defa_stat_on_player_code_idx");

            entity.HasIndex(e => new { e.StatOn, e.ResellerId }, "game_wager_stat_hourly_zone_closes_defa_stat_on_reseller_id_idx");

            entity.HasIndex(e => new { e.StatOn, e.StatDayOn }, "game_wager_stat_hourly_zone_closes_defa_stat_on_stat_day_on_idx");

            entity.HasIndex(e => new { e.StatOn, e.BrandId }, "game_wager_stat_hourly_zone_closes_default_stat_on_brand_id_idx");

            entity.HasIndex(e => new { e.StatOn, e.GameId }, "game_wager_stat_hourly_zone_closes_default_stat_on_game_id_idx");

            entity.HasIndex(e => e.StatOn, "game_wager_stat_hourly_zone_closes_default_stat_on_idx");

            entity.HasIndex(e => new { e.StatOn, e.GameProviderId }, "game_wager_stat_hourly_zone_closes_stat_on_game_provider_id_idx");

            entity.Property(e => e.StatOn)
                .HasComment("統計時間")
                .HasColumnName("stat_on");
            entity.Property(e => e.ResellerId)
                .HasComment("公司識別碼")
                .HasColumnName("reseller_id");
            entity.Property(e => e.LicenseeId)
                .HasComment("分公司識別碼")
                .HasColumnName("licensee_id");
            entity.Property(e => e.BrandId)
                .HasComment("平台識別碼")
                .HasColumnName("brand_id");
            entity.Property(e => e.PlayerCode)
                .HasMaxLength(16)
                .HasComment("玩家代碼")
                .HasColumnName("player_code");
            entity.Property(e => e.GameProviderId)
                .HasComment("遊戲供應商識別碼")
                .HasColumnName("game_provider_id");
            entity.Property(e => e.GameId)
                .HasComment("遊戲識別碼")
                .HasColumnName("game_id");
            entity.Property(e => e.Bet)
                .HasPrecision(18, 6)
                .HasComment("下注")
                .HasColumnName("bet");
            entity.Property(e => e.Commission)
                .HasPrecision(18, 6)
                .HasComment("傭金")
                .HasColumnName("commission");
            entity.Property(e => e.Count)
                .HasDefaultValue(0)
                .HasComment("筆數")
                .HasColumnName("count");
            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasComment("創建時間")
                .HasColumnName("created_on");
            entity.Property(e => e.Settle)
                .HasPrecision(18, 6)
                .HasComment("結算(包含本金)")
                .HasColumnName("settle");
            entity.Property(e => e.StatDayOn)
                .HasDefaultValueSql("'1990-01-01'::date")
                .HasComment("統計日時間")
                .HasColumnName("stat_day_on");
            entity.Property(e => e.StatHourOn)
                .HasComment("統計小時時間")
                .HasColumnName("stat_hour_on");
            entity.Property(e => e.StatTimeSpan)
                .HasComment("統計時間跨度")
                .HasColumnName("stat_time_span");
            entity.Property(e => e.Turnover)
                .HasPrecision(18, 6)
                .HasComment("有效投注")
                .HasColumnName("turnover");
            entity.Property(e => e.UpdatedOn)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasComment("修改時間")
                .HasColumnName("updated_on");
            entity.Property(e => e.ValidBet)
                .HasPrecision(18, 6)
                .HasComment("實際/有效下注")
                .HasColumnName("valid_bet");
            entity.Property(e => e.WinLoss)
                .HasPrecision(18, 6)
                .HasComment("玩家損益/淨利")
                .HasColumnName("win_loss");
        });

        modelBuilder.Entity<Group>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_groups");

            entity.ToTable("groups", "dbo");

            entity.HasIndex(e => new { e.Name, e.System }, "ak_groups_name_system").IsUnique();

            entity.HasIndex(e => e.System, "ix_groups_system");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.System).HasColumnName("system");

            entity.HasOne(d => d.SystemNavigation).WithMany(p => p.Groups)
                .HasForeignKey(d => d.System)
                .HasConstraintName("fk_systems");
        });

        modelBuilder.Entity<GroupUser>(entity =>
        {
            entity.HasKey(e => new { e.GroupId, e.UserId, e.System }).HasName("pk_group_users");

            entity.ToTable("group_users", "dbo");

            entity.HasIndex(e => e.System, "ix_group_users_system");

            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.System).HasColumnName("system");

            entity.HasOne(d => d.Group).WithMany(p => p.GroupUsers)
                .HasForeignKey(d => d.GroupId)
                .HasConstraintName("fk_groups");

            entity.HasOne(d => d.SystemNavigation).WithMany(p => p.GroupUsers)
                .HasForeignKey(d => d.System)
                .HasConstraintName("fk_systems");
        });

        modelBuilder.Entity<HourPaymentStatistic>(entity =>
        {
            entity.HasKey(e => new { e.TimePoint, e.UserId, e.UserType }).HasName("pk_hour_payment_statistics");

            entity.ToTable("hour_payment_statistics", "dbo");

            entity.Property(e => e.TimePoint).HasColumnName("time_point");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.UserType).HasColumnName("user_type");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.DepositAmount).HasColumnName("deposit_amount");
            entity.Property(e => e.DepositCount).HasColumnName("deposit_count");
            entity.Property(e => e.DepositHandlingFee).HasColumnName("deposit_handling_fee");
            entity.Property(e => e.FirstDepositAmount).HasColumnName("first_deposit_amount");
            entity.Property(e => e.FirstDepositHandlingFee).HasColumnName("first_deposit_handling_fee");
            entity.Property(e => e.FirstDepositOn).HasColumnName("first_deposit_on");
            entity.Property(e => e.FirstWithdrawAmount).HasColumnName("first_withdraw_amount");
            entity.Property(e => e.FirstWithdrawHandlingFee).HasColumnName("first_withdraw_handling_fee");
            entity.Property(e => e.FirstWithdrawOn).HasColumnName("first_withdraw_on");
            entity.Property(e => e.WithdrawAmount).HasColumnName("withdraw_amount");
            entity.Property(e => e.WithdrawCount).HasColumnName("withdraw_count");
            entity.Property(e => e.WithdrawHandlingFee).HasColumnName("withdraw_handling_fee");
        });

        modelBuilder.Entity<Language>(entity =>
        {
            entity.HasKey(e => e.CultureCode).HasName("pk_languages");

            entity.ToTable("languages", "dbo");

            entity.Property(e => e.CultureCode)
                .HasMaxLength(6)
                .HasColumnName("culture_code");
            entity.Property(e => e.CreatedByUsername)
                .HasMaxLength(32)
                .HasColumnName("created_by_username");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
            entity.Property(e => e.LanguageCode)
                .HasMaxLength(10)
                .HasColumnName("language_code");
            entity.Property(e => e.LocalizedName)
                .HasMaxLength(64)
                .HasColumnName("localized_name");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasColumnName("name");
            entity.Property(e => e.UpdatedByUsername)
                .HasMaxLength(32)
                .HasColumnName("updated_by_username");
            entity.Property(e => e.UpdatedOn).HasColumnName("updated_on");
        });

        modelBuilder.Entity<Licensee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_licensees");

            entity.ToTable("licensees", "dbo");

            entity.HasIndex(e => new { e.Code, e.Name, e.Description, e.OperationalEmail }, "ix_licensees_code_name_description_operational_email");

            entity.HasIndex(e => e.ResellerId, "ix_licensees_reseller_id");

            entity.HasIndex(e => new { e.Code, e.Name, e.Description, e.OperationalEmail }, "ix_trgm_licensees_code_name_description_operational_email")
                .HasMethod("gin")
                .HasOperators(new[] { "gin_trgm_ops", "gin_trgm_ops", "gin_trgm_ops", "gin_trgm_ops" });

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(16)
                .HasColumnName("code");
            entity.Property(e => e.CreatedByUsername)
                .HasMaxLength(32)
                .HasColumnName("created_by_username");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
            entity.Property(e => e.Description)
                .HasMaxLength(256)
                .HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.OperationalEmail)
                .HasMaxLength(128)
                .HasColumnName("operational_email");
            entity.Property(e => e.ResellerId).HasColumnName("reseller_id");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.UpdatedByUsername)
                .HasMaxLength(32)
                .HasColumnName("updated_by_username");
            entity.Property(e => e.UpdatedOn).HasColumnName("updated_on");

            entity.HasOne(d => d.Reseller).WithMany(p => p.Licensees)
                .HasForeignKey(d => d.ResellerId)
                .HasConstraintName("fk_licensees_resellers_reseller_id");

            entity.HasMany(d => d.BetLimits).WithMany(p => p.Licensees)
                .UsingEntity<Dictionary<string, object>>(
                    "LicenseeBetLimit",
                    r => r.HasOne<BetLimit>().WithMany()
                        .HasForeignKey("BetLimitId")
                        .HasConstraintName("fk_licensee_bet_limits_bet_limits_bet_limit_id"),
                    l => l.HasOne<Licensee>().WithMany()
                        .HasForeignKey("LicenseeId")
                        .HasConstraintName("fk_licensee_bet_limits_licensees_licensee_id"),
                    j =>
                    {
                        j.HasKey("LicenseeId", "BetLimitId").HasName("pk_licensee_bet_limits");
                        j.ToTable("licensee_bet_limits", "dbo");
                        j.HasIndex(new[] { "BetLimitId" }, "ix_licensee_bet_limits_bet_limit_id");
                        j.IndexerProperty<Guid>("LicenseeId").HasColumnName("licensee_id");
                        j.IndexerProperty<int>("BetLimitId").HasColumnName("bet_limit_id");
                    });

            entity.HasMany(d => d.CultureCodes).WithMany(p => p.Licensees)
                .UsingEntity<Dictionary<string, object>>(
                    "LicenseeLanguage",
                    r => r.HasOne<Language>().WithMany()
                        .HasForeignKey("CultureCode")
                        .HasConstraintName("fk_licensee_languages_languages_culture_code"),
                    l => l.HasOne<Licensee>().WithMany()
                        .HasForeignKey("LicenseeId")
                        .HasConstraintName("fk_licensee_languages_licensees_licensee_id"),
                    j =>
                    {
                        j.HasKey("LicenseeId", "CultureCode").HasName("pk_licensee_languages");
                        j.ToTable("licensee_languages", "dbo");
                        j.HasIndex(new[] { "CultureCode" }, "ix_licensee_languages_culture_code");
                        j.IndexerProperty<Guid>("LicenseeId").HasColumnName("licensee_id");
                        j.IndexerProperty<string>("CultureCode")
                            .HasMaxLength(6)
                            .HasColumnName("culture_code");
                    });

            entity.HasMany(d => d.CurrencyCodes).WithMany(p => p.Licensees)
                .UsingEntity<Dictionary<string, object>>(
                    "LicenseeCurrency",
                    r => r.HasOne<Currency>().WithMany()
                        .HasForeignKey("CurrencyCode")
                        .HasConstraintName("fk_licensee_currencies_currencies_currency_code"),
                    l => l.HasOne<Licensee>().WithMany()
                        .HasForeignKey("LicenseeId")
                        .HasConstraintName("fk_licensee_currencies_licensees_licensee_id"),
                    j =>
                    {
                        j.HasKey("LicenseeId", "CurrencyCode").HasName("pk_licensee_currencies");
                        j.ToTable("licensee_currencies", "dbo");
                        j.HasIndex(new[] { "CurrencyCode" }, "ix_licensee_currencies_currency_code");
                        j.IndexerProperty<Guid>("LicenseeId").HasColumnName("licensee_id");
                        j.IndexerProperty<string>("CurrencyCode")
                            .HasMaxLength(16)
                            .HasColumnName("currency_code");
                    });

            entity.HasMany(d => d.GameProviders).WithMany(p => p.Licensees)
                .UsingEntity<Dictionary<string, object>>(
                    "LicenseeGameProvider",
                    r => r.HasOne<GameProvider>().WithMany()
                        .HasForeignKey("GameProviderId")
                        .HasConstraintName("fk_licensee_game_providers_game_providers_game_provider_id"),
                    l => l.HasOne<Licensee>().WithMany()
                        .HasForeignKey("LicenseeId")
                        .HasConstraintName("fk_licensee_game_providers_licensees_licensee_id"),
                    j =>
                    {
                        j.HasKey("LicenseeId", "GameProviderId").HasName("pk_licensee_game_providers");
                        j.ToTable("licensee_game_providers", "dbo");
                        j.HasIndex(new[] { "GameProviderId" }, "ix_licensee_game_providers_game_provider_id");
                        j.IndexerProperty<Guid>("LicenseeId").HasColumnName("licensee_id");
                        j.IndexerProperty<Guid>("GameProviderId").HasColumnName("game_provider_id");
                    });
        });

        modelBuilder.Entity<LocalizedString>(entity =>
        {
            entity.HasKey(e => new { e.Key, e.CultureCode, e.Context }).HasName("pk_localized_strings");

            entity.ToTable("localized_strings", "dbo");

            entity.HasIndex(e => e.CultureCode, "ix_localized_strings_culture_code");

            entity.Property(e => e.Key)
                .HasMaxLength(64)
                .HasColumnName("key");
            entity.Property(e => e.CultureCode)
                .HasMaxLength(6)
                .HasColumnName("culture_code");
            entity.Property(e => e.Context)
                .HasMaxLength(64)
                .HasColumnName("context");
            entity.Property(e => e.Translation)
                .HasMaxLength(1024)
                .HasColumnName("translation");

            entity.HasOne(d => d.CultureCodeNavigation).WithMany(p => p.LocalizedStrings)
                .HasForeignKey(d => d.CultureCode)
                .HasConstraintName("fk_localized_strings_languages_culture_code");
        });

        modelBuilder.Entity<MarketType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_market_types");

            entity.ToTable("market_types", "dbo");

            entity.HasIndex(e => new { e.GameProviderId, e.Code }, "ak_market_types_game_provider_id_code").IsUnique();

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(64)
                .HasColumnName("code");
            entity.Property(e => e.ExternalId)
                .HasMaxLength(16)
                .HasColumnName("external_id");
            entity.Property(e => e.GameProviderId).HasColumnName("game_provider_id");

            entity.HasOne(d => d.GameProvider).WithMany(p => p.MarketTypes)
                .HasForeignKey(d => d.GameProviderId)
                .HasConstraintName("fk_market_types_game_providers_game_provider_id");
        });

        modelBuilder.Entity<MarketingStatisticsSetting>(entity =>
        {
            entity.HasKey(e => e.RecordKey).HasName("pk_marketing_statistics_settings");

            entity.ToTable("marketing_statistics_settings", "dbo");

            entity.Property(e => e.RecordKey).HasColumnName("record_key");
            entity.Property(e => e.ProcessedTime).HasColumnName("processed_time");
        });

        modelBuilder.Entity<MigrationsHistory>(entity =>
        {
            entity.HasKey(e => e.MigrationId).HasName("pk___migrations_history");

            entity.ToTable("__migrations_history", "dbo");

            entity.Property(e => e.MigrationId)
                .HasMaxLength(150)
                .HasColumnName("migration_id");
            entity.Property(e => e.ProductVersion)
                .HasMaxLength(32)
                .HasColumnName("product_version");
        });

        modelBuilder.Entity<NotificationContact>(entity =>
        {
            entity.HasKey(e => new { e.ResellerId, e.LicenseeId, e.BrandId, e.Type }).HasName("pk_notification_contacts");

            entity.ToTable("notification_contacts", "dbo");

            entity.HasIndex(e => new { e.BrandId, e.Type }, "ix_notification_contacts_brand_id");

            entity.HasIndex(e => new { e.LicenseeId, e.Type }, "ix_notification_contacts_licensee_id");

            entity.HasIndex(e => new { e.ResellerId, e.Type }, "ix_notification_contacts_reseller_id");

            entity.HasIndex(e => e.Type, "ix_notification_contacts_typ");

            entity.Property(e => e.ResellerId)
                .HasComment("總公司識別碼")
                .HasColumnName("reseller_id");
            entity.Property(e => e.LicenseeId)
                .HasComment("公司識別碼")
                .HasColumnName("licensee_id");
            entity.Property(e => e.BrandId)
                .HasComment("平台識別碼")
                .HasColumnName("brand_id");
            entity.Property(e => e.Type)
                .HasDefaultValue(1)
                .HasComment("通知類型(信箱、Skype、Telegram)")
                .HasColumnName("type");
            entity.Property(e => e.Contacts)
                .HasDefaultValueSql("'{}'::jsonb")
                .HasComment("聯絡方式")
                .HasColumnType("jsonb")
                .HasColumnName("contacts");
            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasComment("創建時間")
                .HasColumnName("created_on");
            entity.Property(e => e.UpdatedOn)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasComment("修改時間")
                .HasColumnName("updated_on");
        });

        modelBuilder.Entity<OfflineDepositEvent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_offline_deposit_events");

            entity.ToTable("offline_deposit_events", "dbo");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.BonusAmount).HasColumnName("bonus_amount");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.BucketAmount).HasColumnName("bucket_amount");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
            entity.Property(e => e.DepositFormId).HasColumnName("deposit_form_id");
            entity.Property(e => e.PlayerCode).HasColumnName("player_code");
            entity.Property(e => e.PromotionId).HasColumnName("promotion_id");
            entity.Property(e => e.Settings)
                .HasColumnType("jsonb")
                .HasColumnName("settings");
        });

        modelBuilder.Entity<OfflineLoginRewardEvent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_offline_login_reward_events");

            entity.ToTable("offline_login_reward_events", "dbo");

            entity.HasIndex(e => e.BrandId, "ix_offline_login_reward_events_brand_id");

            entity.HasIndex(e => e.PlayerCode, "ix_offline_login_reward_events_player_code");

            entity.HasIndex(e => e.PromotionId, "ix_offline_login_reward_events_promotion_id");

            entity.HasIndex(e => new { e.PlayerCode, e.PromotionId }, "ux_offline_login_reward_events_player_code_promotion_id").IsUnique();

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Bonus)
                .HasPrecision(18, 6)
                .HasColumnName("bonus");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.Bucket)
                .HasPrecision(18, 6)
                .HasColumnName("bucket");
            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_on");
            entity.Property(e => e.LoggedOn).HasColumnName("logged_on");
            entity.Property(e => e.PlayerCode)
                .HasMaxLength(16)
                .HasColumnName("player_code");
            entity.Property(e => e.PromotionId).HasColumnName("promotion_id");

            entity.HasOne(d => d.Brand).WithMany(p => p.OfflineLoginRewardEvents)
                .HasForeignKey(d => d.BrandId)
                .HasConstraintName("fk_offline_login_reward_events_brands_brand_id");

            entity.HasOne(d => d.PlayerCodeNavigation).WithMany(p => p.OfflineLoginRewardEvents)
                .HasForeignKey(d => d.PlayerCode)
                .HasConstraintName("fk_offline_login_reward_events_players_brand_id");

            entity.HasOne(d => d.Promotion).WithMany(p => p.OfflineLoginRewardEvents)
                .HasForeignKey(d => d.PromotionId)
                .HasConstraintName("fk_offline_login_reward_events_promotions_promotion_id");
        });

        modelBuilder.Entity<Payment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_payments");

            entity.ToTable("payments", "dbo");

            entity.HasIndex(e => e.Name, "ix_payments_name");

            entity.HasIndex(e => e.Name, "ix_trgm_payments_name")
                .HasMethod("gin")
                .HasOperators(new[] { "gin_trgm_ops" });

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .HasColumnName("code");
            entity.Property(e => e.CreatedByUsername)
                .HasMaxLength(32)
                .HasColumnName("created_by_username");
            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_on");
            entity.Property(e => e.Description)
                .HasMaxLength(128)
                .HasColumnName("description");
            entity.Property(e => e.ExtendData)
                .HasColumnType("jsonb")
                .HasColumnName("extend_data");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Status)
                .HasDefaultValue((short)0)
                .HasColumnName("status");
            entity.Property(e => e.UpdatedByUsername)
                .HasMaxLength(32)
                .HasColumnName("updated_by_username");
            entity.Property(e => e.UpdatedOn)
                .HasDefaultValueSql("now()")
                .HasColumnName("updated_on");
        });

        modelBuilder.Entity<PaymentChannel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_payment_channels");

            entity.ToTable("payment_channels", "dbo");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .HasColumnName("code");
            entity.Property(e => e.Description)
                .HasMaxLength(128)
                .HasColumnName("description");
        });

        modelBuilder.Entity<PaymentHandlingFee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_payment_handling_fees_id");

            entity.ToTable("payment_handling_fees", "dbo");

            entity.HasIndex(e => e.BrandId, "ix_payment_handling_fees_brand_id");

            entity.HasIndex(e => e.FormId, "ix_payment_handling_fees_form_id");

            entity.HasIndex(e => new { e.RecordedOn, e.FormId }, "ix_payment_handling_fees_recorded_on_form_id");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.ApprovedOn)
                .HasDefaultValueSql("'0001-01-01 00:00:00'::timestamp without time zone")
                .HasColumnName("approved_on");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("'0001-01-01 00:00:00'::timestamp without time zone")
                .HasColumnName("created_on");
            entity.Property(e => e.Fee).HasColumnName("fee");
            entity.Property(e => e.FormId).HasColumnName("form_id");
            entity.Property(e => e.RecordedOn)
                .HasDefaultValueSql("now()")
                .HasColumnName("recorded_on");
            entity.Property(e => e.Remark)
                .HasColumnType("jsonb")
                .HasColumnName("remark");
            entity.Property(e => e.Type)
                .HasDefaultValueSql("''::text")
                .HasColumnName("type");
            entity.Property(e => e.UserId)
                .HasDefaultValueSql("''::text")
                .HasColumnName("user_id");
            entity.Property(e => e.UserType)
                .HasDefaultValue(0)
                .HasColumnName("user_type");

            entity.HasOne(d => d.Brand).WithMany(p => p.PaymentHandlingFees)
                .HasForeignKey(d => d.BrandId)
                .HasConstraintName("fk_payment_handling_fees_brands_brand_id");
        });

        modelBuilder.Entity<PaymentMethod>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_payment_methods");

            entity.ToTable("payment_methods", "dbo");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.BankType).HasColumnName("bank_type");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .HasColumnName("code");
            entity.Property(e => e.Description)
                .HasMaxLength(128)
                .HasColumnName("description");
        });

        modelBuilder.Entity<PaymentMethodChannel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_payment_method_channels");

            entity.ToTable("payment_method_channels", "dbo");

            entity.HasIndex(e => new { e.PaymentId, e.MethodId, e.ChannelId }, "ak_payment_method_channels_payment_id_method_id_channed_id").IsUnique();

            entity.HasIndex(e => e.ChannelId, "ix_payment_method_channels_channel_id");

            entity.HasIndex(e => e.MethodId, "ix_payment_method_channels_method_id");

            entity.HasIndex(e => e.PaymentId, "ix_payment_method_channels_payment_id");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.ChannelId).HasColumnName("channel_id");
            entity.Property(e => e.MethodId).HasColumnName("method_id");
            entity.Property(e => e.PaymentId).HasColumnName("payment_id");
            entity.Property(e => e.Status)
                .HasDefaultValue((short)0)
                .HasColumnName("status");

            entity.HasOne(d => d.Channel).WithMany(p => p.PaymentMethodChannels)
                .HasForeignKey(d => d.ChannelId)
                .HasConstraintName("fk_payment_method_channels_payment_channels_id");

            entity.HasOne(d => d.Method).WithMany(p => p.PaymentMethodChannels)
                .HasForeignKey(d => d.MethodId)
                .HasConstraintName("fk_payment_method_channels_payment_methods_id");

            entity.HasOne(d => d.Payment).WithMany(p => p.PaymentMethodChannels)
                .HasForeignKey(d => d.PaymentId)
                .HasConstraintName("fk_payment_method_channels_payments_id");
        });

        modelBuilder.Entity<Permission>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_permissions");

            entity.ToTable("permissions", "dbo");

            entity.HasIndex(e => e.FkFunctions, "ix_permissions_fk_functions");

            entity.HasIndex(e => e.System, "ix_permissions_system");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Action).HasColumnName("action");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
            entity.Property(e => e.FkFunctions).HasColumnName("fk_functions");
            entity.Property(e => e.FunctionId).HasColumnName("function_id");
            entity.Property(e => e.Identity).HasColumnName("identity");
            entity.Property(e => e.IdentityType).HasColumnName("identity_type");
            entity.Property(e => e.Order).HasColumnName("order");
            entity.Property(e => e.System).HasColumnName("system");

            entity.HasOne(d => d.FkFunctionsNavigation).WithMany(p => p.Permissions)
                .HasForeignKey(d => d.FkFunctions)
                .HasConstraintName("fk_permissions_functions_function_id");

            entity.HasOne(d => d.SystemNavigation).WithMany(p => p.Permissions)
                .HasForeignKey(d => d.System)
                .HasConstraintName("fk_systems");
        });

        modelBuilder.Entity<PlatformCredit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_platform_credits");

            entity.ToTable("platform_credits", "dbo");

            entity.HasIndex(e => e.BrandId, "ix_platform_credits_brand_id").IsUnique();

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Balance)
                .HasPrecision(18, 6)
                .HasColumnName("balance");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.CreatedByUsername)
                .HasMaxLength(32)
                .HasColumnName("created_by_username");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
            entity.Property(e => e.Credit)
                .HasPrecision(18, 6)
                .HasColumnName("credit");
            entity.Property(e => e.UpdatedByUsername)
                .HasMaxLength(32)
                .HasColumnName("updated_by_username");
            entity.Property(e => e.UpdatedOn).HasColumnName("updated_on");

            entity.HasOne(d => d.Brand).WithOne(p => p.PlatformCredit)
                .HasForeignKey<PlatformCredit>(d => d.BrandId)
                .HasConstraintName("fk_platform_credits_brands_brand_id");
        });

        modelBuilder.Entity<PlatformPayRecord>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_platform_pay_records");

            entity.ToTable("platform_pay_records", "dbo");

            entity.HasIndex(e => e.PlatformCreditId, "ix_brand_credits_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Balance)
                .HasPrecision(18, 6)
                .HasColumnName("balance");
            entity.Property(e => e.CreatedByUsername)
                .HasMaxLength(32)
                .HasColumnName("created_by_username");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
            entity.Property(e => e.PayAmount)
                .HasPrecision(18, 6)
                .HasColumnName("pay_amount");
            entity.Property(e => e.PlatformCreditId).HasColumnName("platform_credit_id");

            entity.HasOne(d => d.PlatformCredit).WithMany(p => p.PlatformPayRecords)
                .HasForeignKey(d => d.PlatformCreditId)
                .HasConstraintName("fk_platform_credits_brand_quotas_id");
        });

        modelBuilder.Entity<Player>(entity =>
        {
            entity.HasKey(e => e.PlayerCode).HasName("pk_player_code");

            entity.ToTable("players", "dbo");

            entity.HasIndex(e => new { e.BrandId, e.AreaCode, e.Phone }, "ix_all_brand_phone");

            entity.HasIndex(e => e.AgentId, "ix_players_agent_id");

            entity.HasIndex(e => e.BetLimitId, "ix_players_bet_limit_id");

            entity.HasIndex(e => e.Username, "ix_players_username");

            entity.HasIndex(e => e.VipId, "ix_players_vip_id");

            entity.HasIndex(e => e.Username, "ix_trgm_players_username")
                .HasMethod("gin")
                .HasOperators(new[] { "gin_trgm_ops" });

            entity.HasIndex(e => new { e.AreaCode, e.Phone, e.BrandId }, "ux_phone_21gen")
                .IsUnique()
                .HasFilter("(brand_id = '3897abaf-d203-40d9-8e07-67adc559f272'::uuid)");

            entity.HasIndex(e => new { e.AreaCode, e.Phone, e.BrandId }, "ux_phone_21genth")
                .IsUnique()
                .HasFilter("(brand_id = '5b2a397b-e335-40c0-bd36-879db76e4e22'::uuid)");

            entity.HasIndex(e => new { e.AreaCode, e.Phone, e.BrandId }, "ux_phone_28bet")
                .IsUnique()
                .HasFilter("(brand_id = '904952bb-0a6e-4f28-a850-15467d04e268'::uuid)");

            entity.HasIndex(e => new { e.AreaCode, e.Phone, e.BrandId }, "ux_phone_28win")
                .IsUnique()
                .HasFilter("(brand_id = '0189d435-7209-0000-0001-07e701fc9932'::uuid)");

            entity.HasIndex(e => new { e.AreaCode, e.Phone, e.BrandId }, "ux_phone_bin")
                .IsUnique()
                .HasFilter("(brand_id = 'ee84d331-560d-406d-bf27-4aed88d2e1bd'::uuid)");

            entity.HasIndex(e => new { e.AreaCode, e.Phone, e.BrandId }, "ux_phone_crmyr")
                .IsUnique()
                .HasFilter("(brand_id = 'fcf72615-89b5-44f2-b628-3ba4e5f7f64d'::uuid)");

            entity.HasIndex(e => new { e.AreaCode, e.Phone, e.BrandId }, "ux_phone_gmo")
                .IsUnique()
                .HasFilter("(brand_id = '68b16666-7825-4674-994e-995fd3559835'::uuid)");

            entity.HasIndex(e => new { e.AreaCode, e.Phone, e.BrandId }, "ux_phone_gpi")
                .IsUnique()
                .HasFilter("(brand_id = '4e86719f-243f-46f6-b010-5c758b7285af'::uuid)");

            entity.HasIndex(e => new { e.AreaCode, e.Phone, e.BrandId }, "ux_phone_gpi2")
                .IsUnique()
                .HasFilter("(brand_id = '074acd8c-4b3c-4fdc-86fd-7a944f314247'::uuid)");

            entity.HasIndex(e => new { e.AreaCode, e.Phone, e.BrandId }, "ux_phone_gpi_hkd")
                .IsUnique()
                .HasFilter("(brand_id = 'c24701f0-8a93-4011-ad50-0c57be14ca2d'::uuid)");

            entity.HasIndex(e => new { e.AreaCode, e.Phone, e.BrandId }, "ux_phone_gpi_idr")
                .IsUnique()
                .HasFilter("(brand_id = '8e690525-735d-468d-9888-0eb2cc707d0f'::uuid)");

            entity.HasIndex(e => new { e.AreaCode, e.Phone, e.BrandId }, "ux_phone_gpi_myr")
                .IsUnique()
                .HasFilter("(brand_id = '3be9e58c-a35b-431a-a90c-dd7bfaabe941'::uuid)");

            entity.HasIndex(e => new { e.AreaCode, e.Phone, e.BrandId }, "ux_phone_gpi_thb")
                .IsUnique()
                .HasFilter("(brand_id = '1e2da6e7-d14c-4d36-af69-7d0601a8c3bc'::uuid)");

            entity.HasIndex(e => new { e.AreaCode, e.Phone, e.BrandId }, "ux_phone_gpi_vndk")
                .IsUnique()
                .HasFilter("(brand_id = 'e889db8c-1753-4a70-9324-97e2fdfe5aa5'::uuid)");

            entity.HasIndex(e => new { e.AreaCode, e.Phone, e.BrandId }, "ux_phone_gpivndk")
                .IsUnique()
                .HasFilter("(brand_id = '83338b26-5f70-4b0a-bf80-a401962abf49'::uuid)");

            entity.HasIndex(e => new { e.AreaCode, e.Phone, e.BrandId }, "ux_phone_gptb")
                .IsUnique()
                .HasFilter("(brand_id = '36ec34e7-d6c7-4521-bcc5-a343c20c238f'::uuid)");

            entity.HasIndex(e => new { e.AreaCode, e.Phone, e.BrandId }, "ux_phone_hk28")
                .IsUnique()
                .HasFilter("(brand_id = '55ee3ece-2818-40e9-add9-095aabd721cd'::uuid)");

            entity.HasIndex(e => new { e.AreaCode, e.Phone, e.BrandId }, "ux_phone_hkjp")
                .IsUnique()
                .HasFilter("(brand_id = '7afda97e-54a3-4c0f-b955-8c4b78b1f6b8'::uuid)");

            entity.HasIndex(e => new { e.AreaCode, e.Phone, e.BrandId }, "ux_phone_hkjp2")
                .IsUnique()
                .HasFilter("(brand_id = '4674b8d5-99f5-4ad3-83f5-9e65e2532be3'::uuid)");

            entity.HasIndex(e => new { e.AreaCode, e.Phone, e.BrandId }, "ux_phone_jiliph")
                .IsUnique()
                .HasFilter("(brand_id = '018e829d-3baa-0000-0001-07e86ea40957'::uuid)");

            entity.HasIndex(e => new { e.AreaCode, e.Phone, e.BrandId }, "ux_phone_m9th")
                .IsUnique()
                .HasFilter("(brand_id = '0e98b273-3a17-40b1-8dce-91373cf07873'::uuid)");

            entity.HasIndex(e => new { e.AreaCode, e.Phone, e.BrandId }, "ux_phone_m9thb")
                .IsUnique()
                .HasFilter("(brand_id = 'f0f6b216-f857-4bb1-93f1-8f361c92cd7e'::uuid)");

            entity.HasIndex(e => new { e.AreaCode, e.Phone, e.BrandId }, "ux_phone_mess8")
                .IsUnique()
                .HasFilter("(brand_id = 'c76d8585-46ce-4f1d-aba5-9149d9294224'::uuid)");

            entity.HasIndex(e => new { e.AreaCode, e.Phone, e.BrandId }, "ux_phone_mgm")
                .IsUnique()
                .HasFilter("(brand_id = '23cf2276-b895-44b3-a511-83a66228f29b'::uuid)");

            entity.HasIndex(e => new { e.AreaCode, e.Phone, e.BrandId }, "ux_phone_moph")
                .IsUnique()
                .HasFilter("(brand_id = '018c8032-7619-0000-0001-07e79a3a768c'::uuid)");

            entity.HasIndex(e => new { e.AreaCode, e.Phone, e.BrandId }, "ux_phone_movn2")
                .IsUnique()
                .HasFilter("(brand_id = '018c7b95-a0da-0000-0001-07e72b374e32'::uuid)");

            entity.HasIndex(e => new { e.AreaCode, e.Phone, e.BrandId }, "ux_phone_piso")
                .IsUnique()
                .HasFilter("(brand_id = '2c56e031-f470-4a4a-9f7d-9e61d7d1d89f'::uuid)");

            entity.HasIndex(e => new { e.AreaCode, e.Phone, e.BrandId }, "ux_phone_sky")
                .IsUnique()
                .HasFilter("(brand_id = 'f656b537-b7e8-43c3-9f22-bb87125a5a34'::uuid)");

            entity.HasIndex(e => new { e.AreaCode, e.Phone, e.BrandId }, "ux_phone_test1")
                .IsUnique()
                .HasFilter("(brand_id = '4bcddfd4-658c-41a7-88cf-c4577fea90df'::uuid)");

            entity.HasIndex(e => new { e.AreaCode, e.Phone, e.BrandId }, "ux_phone_tgs")
                .IsUnique()
                .HasFilter("(brand_id = 'd71ac5ed-b7d9-49f2-a129-8709fa4cc02a'::uuid)");

            entity.HasIndex(e => new { e.AreaCode, e.Phone, e.BrandId }, "ux_phone_tgs503")
                .IsUnique()
                .HasFilter("(brand_id = '692bf3b6-17ea-4463-9e63-0f712363ac10'::uuid)");

            entity.HasIndex(e => new { e.AreaCode, e.Phone, e.BrandId }, "ux_phone_tgs_1169")
                .IsUnique()
                .HasFilter("(brand_id = '07d89dff-7111-4de6-8633-ebf6b222ebd7'::uuid)");

            entity.HasIndex(e => new { e.AreaCode, e.Phone, e.BrandId }, "ux_phone_tiger")
                .IsUnique()
                .HasFilter("(brand_id = '46a5c7f4-bcbc-43c0-829f-b59e4bdd630f'::uuid)");

            entity.HasIndex(e => new { e.AreaCode, e.Phone, e.BrandId }, "ux_phone_v226")
                .IsUnique()
                .HasFilter("(brand_id = '018d10c4-2337-0000-0001-07e805d64aad'::uuid)");

            entity.HasIndex(e => new { e.AreaCode, e.Phone, e.BrandId }, "ux_phone_webet")
                .IsUnique()
                .HasFilter("(brand_id = '1c474540-b105-4dde-9ee2-5052464d86f2'::uuid)");

            entity.HasIndex(e => new { e.AreaCode, e.Phone, e.BrandId }, "ux_phone_wlg")
                .IsUnique()
                .HasFilter("(brand_id = '092e2abf-bb29-4ed5-9b17-e4d87c863c59'::uuid)");

            entity.HasIndex(e => new { e.AreaCode, e.Phone, e.BrandId }, "ux_phone_wlghk")
                .IsUnique()
                .HasFilter("(brand_id = '69d2e95c-4adb-4f86-be9b-5386c513ca9a'::uuid)");

            entity.HasIndex(e => new { e.AreaCode, e.Phone, e.BrandId }, "ux_phone_wlgvn")
                .IsUnique()
                .HasFilter("(brand_id = 'c7102141-e08e-45cc-97a4-9225e07c5cd1'::uuid)");

            entity.Property(e => e.PlayerCode)
                .HasMaxLength(16)
                .HasColumnName("player_code");
            entity.Property(e => e.AccumulatedDeposit)
                .HasPrecision(18, 6)
                .HasColumnName("accumulated_deposit");
            entity.Property(e => e.AgentId).HasColumnName("agent_id");
            entity.Property(e => e.AreaCode)
                .HasMaxLength(10)
                .HasColumnName("area_code");
            entity.Property(e => e.BetLimitId).HasColumnName("bet_limit_id");
            entity.Property(e => e.Birthdate).HasColumnName("birthdate");
            entity.Property(e => e.Birthday)
                .HasMaxLength(4)
                .HasComputedColumnSql("(lpad((date_part('month'::text, birthdate))::text, 2, '0'::text) || lpad((date_part('day'::text, birthdate))::text, 2, '0'::text))", true)
                .HasColumnName("birthday");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.DefaultWalletCurrencyCode)
                .HasMaxLength(16)
                .HasColumnName("default_wallet_currency_code");
            entity.Property(e => e.DefaultWalletId).HasColumnName("default_wallet_id");
            entity.Property(e => e.Email)
                .HasMaxLength(64)
                .HasColumnName("email");
            entity.Property(e => e.FirstDepositOn).HasColumnName("first_deposit_on");
            entity.Property(e => e.FirstPromotionOn).HasColumnName("first_promotion_on");
            entity.Property(e => e.IdNumber)
                .HasMaxLength(50)
                .HasColumnName("id_number");
            entity.Property(e => e.IdentityAuthentication).HasColumnName("identity_authentication");
            entity.Property(e => e.LastActiveOn).HasColumnName("last_active_on");
            entity.Property(e => e.Password).HasColumnName("password");
            entity.Property(e => e.Phone)
                .HasMaxLength(32)
                .HasColumnName("phone");
            entity.Property(e => e.PhoneAuthentication).HasColumnName("phone_authentication");
            entity.Property(e => e.Qq)
                .HasMaxLength(64)
                .HasColumnName("qq");
            entity.Property(e => e.RealName)
                .HasMaxLength(256)
                .HasColumnName("real_name");
            entity.Property(e => e.RegisteredOn).HasColumnName("registered_on");
            entity.Property(e => e.Remark).HasColumnName("remark");
            entity.Property(e => e.Salt).HasColumnName("salt");
            entity.Property(e => e.SnapshotEventId).HasColumnName("snapshot_event_id");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.UpdatedByUsername).HasColumnName("updated_by_username");
            entity.Property(e => e.UpdatedOn).HasColumnName("updated_on");
            entity.Property(e => e.Username)
                .HasMaxLength(32)
                .HasColumnName("username");
            entity.Property(e => e.VipId).HasColumnName("vip_id");
            entity.Property(e => e.Wechat)
                .HasMaxLength(64)
                .HasColumnName("wechat");
            entity.Property(e => e.WithdrawPassword).HasColumnName("withdraw_password");
            entity.Property(e => e.WithdrawSalt).HasColumnName("withdraw_salt");

            entity.HasOne(d => d.Agent).WithMany(p => p.Players)
                .HasForeignKey(d => d.AgentId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_players_agents_agent_id");

            entity.HasOne(d => d.BetLimit).WithMany(p => p.Players)
                .HasForeignKey(d => d.BetLimitId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_players_bet_limits_bet_limit_id");

            entity.HasOne(d => d.Brand).WithMany(p => p.Players)
                .HasForeignKey(d => d.BrandId)
                .HasConstraintName("fk_players_brands_brand_id");

            entity.HasOne(d => d.Vip).WithMany(p => p.Players)
                .HasForeignKey(d => d.VipId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_players_vip_levels_vip_id");
        });

        modelBuilder.Entity<PlayerAgentRelation>(entity =>
        {
            entity.HasKey(e => e.PlayerCode).HasName("pk_player_agent_relations_player_code");

            entity.ToTable("player_agent_relations", "dbo");

            entity.HasIndex(e => e.AgentId, "ix_player_agent_relations_agent_id").IsUnique();

            entity.HasIndex(e => e.BrandId, "ix_player_agent_relations_brand_id");

            entity.Property(e => e.PlayerCode)
                .HasMaxLength(16)
                .HasColumnName("player_code");
            entity.Property(e => e.AgentId).HasColumnName("agent_id");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.Status).HasColumnName("status");

            entity.HasOne(d => d.Agent).WithOne(p => p.PlayerAgentRelation)
                .HasForeignKey<PlayerAgentRelation>(d => d.AgentId)
                .HasConstraintName("fk_player_agents_agents_agent_id");

            entity.HasOne(d => d.Brand).WithMany(p => p.PlayerAgentRelations)
                .HasForeignKey(d => d.BrandId)
                .HasConstraintName("fk_player_agents_brands_brand_id");

            entity.HasOne(d => d.PlayerCodeNavigation).WithOne(p => p.PlayerAgentRelation)
                .HasForeignKey<PlayerAgentRelation>(d => d.PlayerCode)
                .HasConstraintName("fk_player_agents_players_player_code");
        });

        modelBuilder.Entity<PlayerAllAgentRebate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_player_all_agent_rebates_id");

            entity.ToTable("player_all_agent_rebates", "dbo");

            entity.HasIndex(e => new { e.BrandId, e.ReportDate, e.PlayerCode }, "ix_player_all_agent_rebates_brand_id_report_date_player_code");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActiveNumber).HasColumnName("active_number");
            entity.Property(e => e.ActualConditionAmount)
                .HasPrecision(18, 6)
                .HasColumnName("actual_condition_amount");
            entity.Property(e => e.ActualPlayerNumber).HasColumnName("actual_player_number");
            entity.Property(e => e.AllAgentGameType).HasColumnName("all_agent_game_type");
            entity.Property(e => e.AllAgentRebateType).HasColumnName("all_agent_rebate_type");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.ConditionAmount)
                .HasPrecision(18, 6)
                .HasColumnName("condition_amount");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
            entity.Property(e => e.GameType).HasColumnName("game_type");
            entity.Property(e => e.PlayerCode)
                .HasMaxLength(16)
                .HasColumnName("player_code");
            entity.Property(e => e.Rank).HasColumnName("rank");
            entity.Property(e => e.RebateAmount)
                .HasPrecision(18, 6)
                .HasColumnName("rebate_amount");
            entity.Property(e => e.RebatePercentage)
                .HasPrecision(9, 6)
                .HasColumnName("rebate_percentage");
            entity.Property(e => e.ReportDate).HasColumnName("report_date");
            entity.Property(e => e.SentOn).HasColumnName("sent_on");
        });

        modelBuilder.Entity<PlayerAllAgentRebateContributor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_player_all_agent_rebates_contributor_id");

            entity.ToTable("player_all_agent_rebate_contributors", "dbo");

            entity.HasIndex(e => new { e.SettleDate, e.PlayerCode, e.ChildPlayerCode }, "ix_player_all_agent_rebate_contributors_settle_date_player_code");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.CardGameTurnover)
                .HasPrecision(18, 6)
                .HasColumnName("card_game_turnover");
            entity.Property(e => e.CardGameTurnoverRebate)
                .HasPrecision(18, 6)
                .HasColumnName("card_game_turnover_rebate");
            entity.Property(e => e.CardGameWinLoss)
                .HasPrecision(18, 6)
                .HasColumnName("card_game_win_loss");
            entity.Property(e => e.CardGameWinLossRebate)
                .HasPrecision(18, 6)
                .HasColumnName("card_game_win_loss_rebate");
            entity.Property(e => e.ChildPlayerCode)
                .HasMaxLength(16)
                .HasColumnName("child_player_code");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
            entity.Property(e => e.From)
                .HasDefaultValueSql("now()")
                .HasColumnName("from");
            entity.Property(e => e.LiveDealerTurnover)
                .HasPrecision(18, 6)
                .HasColumnName("live_dealer_turnover");
            entity.Property(e => e.LiveDealerTurnoverRebate)
                .HasPrecision(18, 6)
                .HasColumnName("live_dealer_turnover_rebate");
            entity.Property(e => e.LiveDealerWinLoss)
                .HasPrecision(18, 6)
                .HasColumnName("live_dealer_win_loss");
            entity.Property(e => e.LiveDealerWinLossRebate)
                .HasPrecision(18, 6)
                .HasColumnName("live_dealer_win_loss_rebate");
            entity.Property(e => e.LotteryTurnover)
                .HasPrecision(18, 6)
                .HasColumnName("lottery_turnover");
            entity.Property(e => e.LotteryTurnoverRebate)
                .HasPrecision(18, 6)
                .HasColumnName("lottery_turnover_rebate");
            entity.Property(e => e.LotteryWinLoss)
                .HasPrecision(18, 6)
                .HasColumnName("lottery_win_loss");
            entity.Property(e => e.LotteryWinLossRebate)
                .HasPrecision(18, 6)
                .HasColumnName("lottery_win_loss_rebate");
            entity.Property(e => e.PlayerCode)
                .HasMaxLength(16)
                .HasColumnName("player_code");
            entity.Property(e => e.SentOn).HasColumnName("sent_on");
            entity.Property(e => e.SettleDate).HasColumnName("settle_date");
            entity.Property(e => e.SlotTurnover)
                .HasPrecision(18, 6)
                .HasColumnName("slot_turnover");
            entity.Property(e => e.SlotTurnoverRebate)
                .HasPrecision(18, 6)
                .HasColumnName("slot_turnover_rebate");
            entity.Property(e => e.SlotWinLoss)
                .HasPrecision(18, 6)
                .HasColumnName("slot_win_loss");
            entity.Property(e => e.SlotWinLossRebate)
                .HasPrecision(18, 6)
                .HasColumnName("slot_win_loss_rebate");
            entity.Property(e => e.SportsTurnover)
                .HasPrecision(18, 6)
                .HasColumnName("sports_turnover");
            entity.Property(e => e.SportsTurnoverRebate)
                .HasPrecision(18, 6)
                .HasColumnName("sports_turnover_rebate");
            entity.Property(e => e.SportsWinLoss)
                .HasPrecision(18, 6)
                .HasColumnName("sports_win_loss");
            entity.Property(e => e.SportsWinLossRebate)
                .HasPrecision(18, 6)
                .HasColumnName("sports_win_loss_rebate");
            entity.Property(e => e.To)
                .HasDefaultValueSql("now()")
                .HasColumnName("to");
            entity.Property(e => e.VirtualSportsTurnover)
                .HasPrecision(18, 6)
                .HasColumnName("virtual_sports_turnover");
            entity.Property(e => e.VirtualSportsTurnoverRebate)
                .HasPrecision(18, 6)
                .HasColumnName("virtual_sports_turnover_rebate");
            entity.Property(e => e.VirtualSportsWinLoss)
                .HasPrecision(18, 6)
                .HasColumnName("virtual_sports_win_loss");
            entity.Property(e => e.VirtualSportsWinLossRebate)
                .HasPrecision(18, 6)
                .HasColumnName("virtual_sports_win_loss_rebate");
        });

        modelBuilder.Entity<PlayerAllAgentRebateRecord>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_player_all_agent_rebate_records_id");

            entity.ToTable("player_all_agent_rebate_records", "dbo");

            entity.HasIndex(e => new { e.SettleDate, e.BrandId, e.PlayerCode }, "ix_player_all_agent_rebate_records_settle_date_brand_id_player_");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.ActiveNumber).HasColumnName("active_number");
            entity.Property(e => e.ActualConditionAmount)
                .HasPrecision(18, 6)
                .HasColumnName("actual_condition_amount");
            entity.Property(e => e.ActualPlayerNumber).HasColumnName("actual_player_number");
            entity.Property(e => e.AllAgentGameType).HasColumnName("all_agent_game_type");
            entity.Property(e => e.AllAgentRebateType).HasColumnName("all_agent_rebate_type");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.ConditionAmount)
                .HasPrecision(18, 6)
                .HasColumnName("condition_amount");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
            entity.Property(e => e.From)
                .HasDefaultValueSql("now()")
                .HasColumnName("from");
            entity.Property(e => e.PlayerCode)
                .HasMaxLength(16)
                .HasColumnName("player_code");
            entity.Property(e => e.Rank).HasColumnName("rank");
            entity.Property(e => e.RebateAmount)
                .HasPrecision(18, 6)
                .HasColumnName("rebate_amount");
            entity.Property(e => e.RebatePercentage)
                .HasPrecision(9, 6)
                .HasColumnName("rebate_percentage");
            entity.Property(e => e.SettleDate).HasColumnName("settle_date");
            entity.Property(e => e.To)
                .HasDefaultValueSql("now()")
                .HasColumnName("to");
        });

        modelBuilder.Entity<PlayerAuditLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_player_audit_logs");

            entity.ToTable("player_audit_logs", "dbo");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CreatedByUsername)
                .HasMaxLength(32)
                .HasColumnName("created_by_username");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
            entity.Property(e => e.ModuleName)
                .HasMaxLength(256)
                .HasColumnName("module_name");
            entity.Property(e => e.Operation)
                .HasMaxLength(256)
                .HasColumnName("operation");
            entity.Property(e => e.Username)
                .HasMaxLength(32)
                .HasColumnName("username");
        });

        modelBuilder.Entity<PlayerAuthenticationForm>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_player_authentication_forms");

            entity.ToTable("player_authentication_forms", "dbo");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
            entity.Property(e => e.Data)
                .HasColumnType("jsonb")
                .HasColumnName("data");
            entity.Property(e => e.PlayerCode)
                .HasMaxLength(16)
                .HasColumnName("player_code");
            entity.Property(e => e.Remark).HasColumnName("remark");
            entity.Property(e => e.ReviewedOn).HasColumnName("reviewed_on");
            entity.Property(e => e.ReviewedUserId).HasColumnName("reviewed_user_id");
            entity.Property(e => e.ReviewedUserName).HasColumnName("reviewed_user_name");
            entity.Property(e => e.Status)
                .HasDefaultValue(0)
                .HasColumnName("status");
        });

        modelBuilder.Entity<PlayerBankInfo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_player_bank_infos");

            entity.ToTable("player_bank_infos", "dbo");

            entity.HasIndex(e => e.BrandId, "ix_player_bank_infos_brand_id");

            entity.HasIndex(e => new { e.BrandId, e.BankType, e.BankInfoHash }, "ix_player_bank_infos_hash");

            entity.HasIndex(e => e.PaymentChannelId, "ix_player_bank_infos_payment_channel_id");

            entity.HasIndex(e => e.PlayerCode, "ix_player_bank_infos_player_code");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.BankInfoHash).HasColumnName("bank_info_hash");
            entity.Property(e => e.BankType).HasColumnName("bank_type");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.CreatedByUsername)
                .HasMaxLength(32)
                .HasColumnName("created_by_username");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
            entity.Property(e => e.Default)
                .HasDefaultValue(false)
                .HasColumnName("default");
            entity.Property(e => e.Detail)
                .HasColumnType("jsonb")
                .HasColumnName("detail");
            entity.Property(e => e.PaymentChannelId).HasColumnName("payment_channel_id");
            entity.Property(e => e.PlayerCode)
                .HasMaxLength(16)
                .HasColumnName("player_code");
            entity.Property(e => e.SnapshotId).HasColumnName("snapshot_id");
            entity.Property(e => e.UpdatedByUsername)
                .HasMaxLength(32)
                .HasColumnName("updated_by_username");
            entity.Property(e => e.UpdatedOn).HasColumnName("updated_on");

            entity.HasOne(d => d.Brand).WithMany(p => p.PlayerBankInfos)
                .HasForeignKey(d => d.BrandId)
                .HasConstraintName("fk_player_bank_infos_brands_brand_id");

            entity.HasOne(d => d.PaymentChannel).WithMany(p => p.PlayerBankInfos)
                .HasForeignKey(d => d.PaymentChannelId)
                .HasConstraintName("fk_player_bank_infos_payment_channels_payment_channel_id");

            entity.HasOne(d => d.PlayerCodeNavigation).WithMany(p => p.PlayerBankInfos)
                .HasForeignKey(d => d.PlayerCode)
                .HasConstraintName("fk_player_bank_infos_players_player_code");
        });

        modelBuilder.Entity<PlayerBankInfoEventSource>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_player_bank_info_event_source");

            entity.ToTable("player_bank_info_event_source", "dbo");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.BankInfoId).HasColumnName("bank_info_id");
            entity.Property(e => e.ChangeAction).HasColumnName("change_action");
            entity.Property(e => e.ChangeSets)
                .HasColumnType("jsonb")
                .HasColumnName("change_sets");
            entity.Property(e => e.ModifiedOn).HasColumnName("modified_on");
            entity.Property(e => e.Modifier).HasColumnName("modifier");
        });

        modelBuilder.Entity<PlayerBankInfoTag>(entity =>
        {
            entity.HasKey(e => new { e.BrandId, e.BankInfoId, e.TagType }).HasName("pk_player_bank_info_tags");

            entity.ToTable("player_bank_info_tags", "dbo");

            entity.HasIndex(e => e.BankInfoId, "ix_player_bank_info_tags_bank_info_id");

            entity.HasIndex(e => e.PlayerCode, "ix_player_bank_info_tags_player_code");

            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.BankInfoId).HasColumnName("bank_info_id");
            entity.Property(e => e.TagType).HasColumnName("tag_type");
            entity.Property(e => e.PlayerCode)
                .HasMaxLength(16)
                .HasColumnName("player_code");
            entity.Property(e => e.Tag).HasColumnName("tag");

            entity.HasOne(d => d.BankInfo).WithMany(p => p.PlayerBankInfoTags)
                .HasForeignKey(d => d.BankInfoId)
                .HasConstraintName("fk_player_bank_info_tags_player_bank_infos_bank_info_id");

            entity.HasOne(d => d.PlayerCodeNavigation).WithMany(p => p.PlayerBankInfoTags)
                .HasForeignKey(d => d.PlayerCode)
                .HasConstraintName("fk_player_bank_info_tags_players_player_code");
        });

        modelBuilder.Entity<PlayerBankinfoAttribution>(entity =>
        {
            entity.HasKey(e => new { e.BrandId, e.BankInfoHash }).HasName("pk_player_bankinfo_attributions");

            entity.ToTable("player_bankinfo_attributions", "dbo");

            entity.HasIndex(e => e.PlayerCode, "ix_player_bankinfo_attributions_player_code");

            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.BankInfoHash).HasColumnName("bank_info_hash");
            entity.Property(e => e.PlayerCode)
                .HasMaxLength(16)
                .HasColumnName("player_code");

            entity.HasOne(d => d.Brand).WithMany(p => p.PlayerBankinfoAttributions)
                .HasForeignKey(d => d.BrandId)
                .HasConstraintName("fk_brands_brand_id");

            entity.HasOne(d => d.PlayerCodeNavigation).WithMany(p => p.PlayerBankinfoAttributions)
                .HasForeignKey(d => d.PlayerCode)
                .HasConstraintName("fk_players_player_code");
        });

        modelBuilder.Entity<PlayerBucket>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_player_buckets");

            entity.ToTable("player_buckets", "dbo");

            entity.HasIndex(e => e.PlayerCode, "ix_player_buckets_player_code");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.BucketAmount)
                .HasPrecision(18, 6)
                .HasColumnName("bucket_amount");
            entity.Property(e => e.BucketType).HasColumnName("bucket_type");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
            entity.Property(e => e.CurrentBucketAmount)
                .HasPrecision(18, 6)
                .HasColumnName("current_bucket_amount");
            entity.Property(e => e.IsFull).HasColumnName("is_full");
            entity.Property(e => e.PlayerCode)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("player_code");
            entity.Property(e => e.SnapshotId).HasColumnName("snapshot_id");
        });

        modelBuilder.Entity<PlayerBucketCleanEventSource>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_player_bucket_clean_event_source");

            entity.ToTable("player_bucket_clean_event_source", "dbo");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.ChangeSets)
                .HasColumnType("jsonb")
                .HasColumnName("change_sets");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
            entity.Property(e => e.FormId).HasColumnName("form_id");
        });

        modelBuilder.Entity<PlayerBucketCleanEventSource2>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_player_bucket_clean_event_source2");

            entity.ToTable("player_bucket_clean_event_source2", "dbo");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.ChangeSets)
                .HasColumnType("jsonb")
                .HasColumnName("change_sets");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
            entity.Property(e => e.FormId).HasColumnName("form_id");
        });

        modelBuilder.Entity<PlayerBucketCleanForm>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_player_bucket_clean_forms");

            entity.ToTable("player_bucket_clean_forms", "dbo");

            entity.HasIndex(e => e.BrandId, "ix_player_bucket_clean_forms_brand_id");

            entity.HasIndex(e => e.PlayerCode, "ix_player_bucket_clean_forms_player_code");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.BucketAnchorId).HasColumnName("bucket_anchor_id");
            entity.Property(e => e.CleaningBalance).HasColumnName("cleaning_balance");
            entity.Property(e => e.CleaningBucketAmount).HasColumnName("cleaning_bucket_amount");
            entity.Property(e => e.ClearWageringRequirementBalance).HasColumnName("clear_wagering_requirement_balance");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
            entity.Property(e => e.CurrentBalance).HasColumnName("current_balance");
            entity.Property(e => e.CurrentBucketAmount).HasColumnName("current_bucket_amount");
            entity.Property(e => e.DepositFormId).HasColumnName("deposit_form_id");
            entity.Property(e => e.GameBalanceReturn)
                .HasColumnType("jsonb")
                .HasColumnName("game_balance_return");
            entity.Property(e => e.PlayerCode)
                .HasMaxLength(16)
                .HasColumnName("player_code");
            entity.Property(e => e.SnapshotId).HasColumnName("snapshot_id");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.WalletId).HasColumnName("wallet_id");

            entity.HasOne(d => d.Brand).WithMany(p => p.PlayerBucketCleanForms)
                .HasForeignKey(d => d.BrandId)
                .HasConstraintName("fk_player_bucket_clean_forms_brands");

            entity.HasOne(d => d.PlayerCodeNavigation).WithMany(p => p.PlayerBucketCleanForms)
                .HasForeignKey(d => d.PlayerCode)
                .HasConstraintName("fk_player_bucket_clean_forms_players");
        });

        modelBuilder.Entity<PlayerBucketCleanForms2>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_player_bucket_clean_forms2");

            entity.ToTable("player_bucket_clean_forms2", "dbo");

            entity.HasIndex(e => e.BrandId, "ix_player_bucket_clean_forms2_brand_id");

            entity.HasIndex(e => e.PlayerCode, "ix_player_bucket_clean_forms2_player_code");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.CleaningBalance).HasColumnName("cleaning_balance");
            entity.Property(e => e.CleaningBucketAmounts)
                .HasColumnType("jsonb")
                .HasColumnName("cleaning_bucket_amounts");
            entity.Property(e => e.ClearWageringRequirementBalance).HasColumnName("clear_wagering_requirement_balance");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
            entity.Property(e => e.CurrentBalance).HasColumnName("current_balance");
            entity.Property(e => e.CurrentBucketAmounts)
                .HasColumnType("jsonb")
                .HasColumnName("current_bucket_amounts");
            entity.Property(e => e.DepositFormId).HasColumnName("deposit_form_id");
            entity.Property(e => e.GameBalanceReturn)
                .HasColumnType("jsonb")
                .HasColumnName("game_balance_return");
            entity.Property(e => e.PlayerCode)
                .HasMaxLength(16)
                .HasColumnName("player_code");
            entity.Property(e => e.SnapshotId).HasColumnName("snapshot_id");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.WalletId).HasColumnName("wallet_id");

            entity.HasOne(d => d.Brand).WithMany(p => p.PlayerBucketCleanForms2s)
                .HasForeignKey(d => d.BrandId)
                .HasConstraintName("fk_player_bucket_clean_forms_brands2");

            entity.HasOne(d => d.PlayerCodeNavigation).WithMany(p => p.PlayerBucketCleanForms2s)
                .HasForeignKey(d => d.PlayerCode)
                .HasConstraintName("fk_player_bucket_clean_forms_players2");
        });

        modelBuilder.Entity<PlayerBucketEventSource>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_player_bucket_event_source");

            entity.ToTable("player_bucket_event_source", "dbo");

            entity.HasIndex(e => e.BucketId, "ix_player_bucket_event_source_bucket_id");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.BucketId).HasColumnName("bucket_id");
            entity.Property(e => e.ChangeAmount).HasColumnName("change_amount");
            entity.Property(e => e.ChangeSets)
                .HasColumnType("jsonb")
                .HasColumnName("change_sets");
            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_on");
            entity.Property(e => e.ExternalId).HasColumnName("external_id");
            entity.Property(e => e.FillType).HasColumnName("fill_type");
            entity.Property(e => e.Remark).HasColumnName("remark");
        });

        modelBuilder.Entity<PlayerBucketHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_player_bucket_histories");

            entity.ToTable("player_bucket_histories", "dbo");

            entity.HasIndex(e => e.PlayerCode, "ix_player_bucket_histories_player_code");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
            entity.Property(e => e.From).HasColumnName("from");
            entity.Property(e => e.PlayerBucketId).HasColumnName("player_bucket_id");
            entity.Property(e => e.PlayerCode)
                .HasMaxLength(16)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("player_code");
            entity.Property(e => e.RoundData)
                .HasDefaultValueSql("'{}'::jsonb")
                .HasColumnType("jsonb")
                .HasColumnName("round_data");
            entity.Property(e => e.To).HasColumnName("to");
            entity.Property(e => e.Turnover)
                .HasPrecision(18, 6)
                .HasColumnName("turnover");
        });

        modelBuilder.Entity<PlayerBucketMigration>(entity =>
        {
            entity.HasKey(e => e.PlayerCode).HasName("pk_player_bucket_migrations");

            entity.ToTable("player_bucket_migrations", "dbo");

            entity.Property(e => e.PlayerCode).HasColumnName("player_code");
        });

        modelBuilder.Entity<PlayerDailyGamingStatistic>(entity =>
        {
            entity.HasKey(e => new { e.ReportDate, e.PlayerCode, e.GpCode, e.SubGpCode }).HasName("pk_player_daily_gaming_statistics");

            entity.ToTable("player_daily_gaming_statistics", "dbo");

            entity.Property(e => e.ReportDate).HasColumnName("report_date");
            entity.Property(e => e.PlayerCode).HasColumnName("player_code");
            entity.Property(e => e.GpCode).HasColumnName("gp_code");
            entity.Property(e => e.SubGpCode).HasColumnName("sub_gp_code");
            entity.Property(e => e.WinLoss).HasColumnName("win_loss");
        });

        modelBuilder.Entity<PlayerDailyPaymentStatistic>(entity =>
        {
            entity.HasKey(e => new { e.ReportDate, e.PlayerCode }).HasName("pk_player_daily_payment_statistics");

            entity.ToTable("player_daily_payment_statistics", "dbo");

            entity.Property(e => e.ReportDate).HasColumnName("report_date");
            entity.Property(e => e.PlayerCode).HasColumnName("player_code");
            entity.Property(e => e.DailyDepositAmount).HasColumnName("daily_deposit_amount");
            entity.Property(e => e.DailyDepositCount).HasColumnName("daily_deposit_count");
            entity.Property(e => e.DailyDepositHandlingFee).HasColumnName("daily_deposit_handling_fee");
            entity.Property(e => e.DailyWithdrawAmount).HasColumnName("daily_withdraw_amount");
            entity.Property(e => e.DailyWithdrawCount).HasColumnName("daily_withdraw_count");
            entity.Property(e => e.DailyWithdrawHandlingFee).HasColumnName("daily_withdraw_handling_fee");
            entity.Property(e => e.FirstDepositAmount).HasColumnName("first_deposit_amount");
            entity.Property(e => e.FirstDepositHandlingFee).HasColumnName("first_deposit_handling_fee");
            entity.Property(e => e.FirstDepositOn).HasColumnName("first_deposit_on");
            entity.Property(e => e.FirstWithdrawAmount).HasColumnName("first_withdraw_amount");
            entity.Property(e => e.FirstWithdrawHandlingFee).HasColumnName("first_withdraw_handling_fee");
            entity.Property(e => e.FirstWithdrawOn).HasColumnName("first_withdraw_on");
            entity.Property(e => e.TotalDepositAmount).HasColumnName("total_deposit_amount");
            entity.Property(e => e.TotalDepositCount).HasColumnName("total_deposit_count");
            entity.Property(e => e.TotalDepositHandlingFee).HasColumnName("total_deposit_handling_fee");
            entity.Property(e => e.TotalWithdrawAmount).HasColumnName("total_withdraw_amount");
            entity.Property(e => e.TotalWithdrawCount).HasColumnName("total_withdraw_count");
            entity.Property(e => e.TotalWithdrawHandlingFee).HasColumnName("total_withdraw_handling_fee");
        });

        modelBuilder.Entity<PlayerDailyRegisterStatistic>(entity =>
        {
            entity.HasKey(e => new { e.ReportDate, e.PlayerCode }).HasName("pk_player_daily_register_statistics");

            entity.ToTable("player_daily_register_statistics", "dbo");

            entity.Property(e => e.ReportDate).HasColumnName("report_date");
            entity.Property(e => e.PlayerCode).HasColumnName("player_code");
            entity.Property(e => e.DailyLoginCount).HasColumnName("daily_login_count");
            entity.Property(e => e.LastLoginOn).HasColumnName("last_login_on");
            entity.Property(e => e.TotalLoginCount).HasColumnName("total_login_count");
        });

        modelBuilder.Entity<PlayerEventSource>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_player_event_source");

            entity.ToTable("player_event_source", "dbo");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Action).HasColumnName("action");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.ChangeSets)
                .HasColumnType("jsonb")
                .HasColumnName("change_sets");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
            entity.Property(e => e.ModifyUser).HasColumnName("modify_user");
            entity.Property(e => e.PlayerCode).HasColumnName("player_code");
        });

        modelBuilder.Entity<PlayerFavoriteGame>(entity =>
        {
            entity.HasKey(e => new { e.PlayerCode, e.GameId }).HasName("pk_player_favorite_games");

            entity.ToTable("player_favorite_games", "dbo");

            entity.HasIndex(e => e.BrandId, "ix_player_favorite_games_brand_id");

            entity.Property(e => e.PlayerCode)
                .HasMaxLength(16)
                .HasColumnName("player_code");
            entity.Property(e => e.GameId).HasColumnName("game_id");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.GameType).HasColumnName("game_type");
            entity.Property(e => e.SubGameProviderCode)
                .HasMaxLength(16)
                .HasColumnName("sub_game_provider_code");

            entity.HasOne(d => d.Brand).WithMany(p => p.PlayerFavoriteGames)
                .HasForeignKey(d => d.BrandId)
                .HasConstraintName("fk_player_favorite_games_brand_brand_id");

            entity.HasOne(d => d.PlayerCodeNavigation).WithMany(p => p.PlayerFavoriteGames)
                .HasForeignKey(d => d.PlayerCode)
                .HasConstraintName("fk_player_favorite_games_player_player_code");
        });

        modelBuilder.Entity<PlayerGameSetting>(entity =>
        {
            entity.HasKey(e => e.PlayerCode).HasName("pk_player_game_settings");

            entity.ToTable("player_game_settings", "dbo");

            entity.Property(e => e.PlayerCode)
                .HasMaxLength(16)
                .HasColumnName("player_code");
            entity.Property(e => e.IsAutoTransferToGame)
                .HasDefaultValue(false)
                .HasColumnName("is_auto_transfer_to_game");

            entity.HasOne(d => d.PlayerCodeNavigation).WithOne(p => p.PlayerGameSetting)
                .HasForeignKey<PlayerGameSetting>(d => d.PlayerCode)
                .HasConstraintName("fk_player_game_settings_players");
        });

        modelBuilder.Entity<PlayerIdentity>(entity =>
        {
            entity.HasKey(e => e.PlayerCode).HasName("pk_player_identity");

            entity.ToTable("player_identity", "dbo");

            entity.Property(e => e.PlayerCode)
                .HasMaxLength(16)
                .HasColumnName("player_code");
            entity.Property(e => e.PlayerAuthenticationFormId).HasColumnName("player_authentication_form_id");

            entity.HasOne(d => d.PlayerCodeNavigation).WithOne(p => p.PlayerIdentity)
                .HasForeignKey<PlayerIdentity>(d => d.PlayerCode)
                .HasConstraintName("fk_player_identity_players_player_code");
        });

        modelBuilder.Entity<PlayerIpRecord>(entity =>
        {
            entity.HasKey(e => new { e.PlayerCode, e.IpType }).HasName("pk_player_ip_records");

            entity.ToTable("player_ip_records", "dbo");

            entity.Property(e => e.PlayerCode)
                .HasMaxLength(16)
                .HasColumnName("player_code");
            entity.Property(e => e.IpType).HasColumnName("ip_type");
            entity.Property(e => e.Host)
                .HasMaxLength(250)
                .HasColumnName("host");
            entity.Property(e => e.Ip)
                .HasMaxLength(64)
                .HasColumnName("ip");
            entity.Property(e => e.RecordOn)
                .HasDefaultValueSql("now()")
                .HasColumnName("record_on");

            entity.HasOne(d => d.PlayerCodeNavigation).WithMany(p => p.PlayerIpRecords)
                .HasForeignKey(d => d.PlayerCode)
                .HasConstraintName("fk_player_ip_records_players_player_code");
        });

        modelBuilder.Entity<PlayerLoginRecord>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_player_login_records");

            entity.ToTable("player_login_records", "dbo");

            entity.HasIndex(e => e.BrandId, "ix_player_login_records_brand_id");

            entity.HasIndex(e => e.PlayerCode, "ix_player_login_records_player_code");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
            entity.Property(e => e.ExpiredOn).HasColumnName("expired_on");
            entity.Property(e => e.IpAddress).HasColumnName("ip_address");
            entity.Property(e => e.PlatformType).HasColumnName("platform_type");
            entity.Property(e => e.PlayerCode)
                .HasMaxLength(16)
                .HasColumnName("player_code");
            entity.Property(e => e.Status).HasColumnName("status");

            entity.HasOne(d => d.Brand).WithMany(p => p.PlayerLoginRecords)
                .HasForeignKey(d => d.BrandId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_player_login_records_brands_brand_id");

            entity.HasOne(d => d.PlayerCodeNavigation).WithMany(p => p.PlayerLoginRecords)
                .HasForeignKey(d => d.PlayerCode)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_player_login_records_players_player_code");
        });

        modelBuilder.Entity<PlayerParent>(entity =>
        {
            entity.HasKey(e => e.PlayerCode).HasName("pk_player_parent_code");

            entity.ToTable("player_parents", "dbo");

            entity.HasIndex(e => e.ParentPlayerCode, "ix_parent_player_code");

            entity.Property(e => e.PlayerCode)
                .HasMaxLength(16)
                .HasColumnName("player_code");
            entity.Property(e => e.ParentPlayerCode)
                .HasMaxLength(16)
                .HasColumnName("parent_player_code");
        });

        modelBuilder.Entity<PlayerPaymentOverview>(entity =>
        {
            entity.HasKey(e => e.PlayerCode).HasName("pk_player_payment_overview");

            entity.ToTable("player_payment_overview", "dbo");

            entity.Property(e => e.PlayerCode).HasColumnName("player_code");
            entity.Property(e => e.FirstDepositAmount).HasColumnName("first_deposit_amount");
            entity.Property(e => e.FirstDepositHandlingFee).HasColumnName("first_deposit_handling_fee");
            entity.Property(e => e.FirstDepositOn).HasColumnName("first_deposit_on");
            entity.Property(e => e.FirstWithdrawAmount).HasColumnName("first_withdraw_amount");
            entity.Property(e => e.FirstWithdrawHandlingFee).HasColumnName("first_withdraw_handling_fee");
            entity.Property(e => e.FirstWithdrawOn).HasColumnName("first_withdraw_on");
            entity.Property(e => e.RecordedBy).HasColumnName("recorded_by");
            entity.Property(e => e.TotalDepositAmount).HasColumnName("total_deposit_amount");
            entity.Property(e => e.TotalDepositCount)
                .HasDefaultValue(0)
                .HasColumnName("total_deposit_count");
            entity.Property(e => e.TotalWithdrawAmount).HasColumnName("total_withdraw_amount");
            entity.Property(e => e.TotalWithdrawCount)
                .HasDefaultValue(0)
                .HasColumnName("total_withdraw_count");
        });

        modelBuilder.Entity<PlayerProperty>(entity =>
        {
            entity.HasKey(e => new { e.BrandId, e.PlayerCode, e.Name }).HasName("pk_player_properties");

            entity.ToTable("player_properties", "dbo");

            entity.HasIndex(e => e.PlayerCode, "ix_player_properties_player_code");

            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.PlayerCode)
                .HasMaxLength(16)
                .HasColumnName("player_code");
            entity.Property(e => e.Name)
                .HasMaxLength(256)
                .HasColumnName("name");
            entity.Property(e => e.Value)
                .HasMaxLength(512)
                .HasColumnName("value");

            entity.HasOne(d => d.Brand).WithMany(p => p.PlayerProperties)
                .HasForeignKey(d => d.BrandId)
                .HasConstraintName("fk_brand_player_property_brand_id");

            entity.HasOne(d => d.PlayerCodeNavigation).WithMany(p => p.PlayerProperties)
                .HasForeignKey(d => d.PlayerCode)
                .HasConstraintName("fk_player_player_property_player_code");
        });

        modelBuilder.Entity<PlayerRebate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_player_rebates_id");

            entity.ToTable("player_rebates", "dbo");

            entity.HasIndex(e => new { e.BrandId, e.ReportDate }, "ix_player_rebates_brand_id_report_date");

            entity.HasIndex(e => new { e.BrandId, e.ReportDate, e.AgentId }, "ix_player_rebates_brand_id_report_date_agent_id");

            entity.HasIndex(e => new { e.BrandId, e.ReportDate, e.PlayerCode }, "ix_player_rebates_brand_id_report_date_player_code");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AgentId).HasColumnName("agent_id");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.CardGameRebateAmount)
                .HasPrecision(18, 6)
                .HasColumnName("card_game_rebate_amount");
            entity.Property(e => e.CardGameTurnover)
                .HasPrecision(18, 6)
                .HasColumnName("card_game_turnover");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
            entity.Property(e => e.LiveDealerRebateAmount)
                .HasPrecision(18, 6)
                .HasColumnName("live_dealer_rebate_amount");
            entity.Property(e => e.LiveDealerTurnover)
                .HasPrecision(18, 6)
                .HasColumnName("live_dealer_turnover");
            entity.Property(e => e.LotteryRebateAmount)
                .HasPrecision(18, 6)
                .HasColumnName("lottery_rebate_amount");
            entity.Property(e => e.LotteryTurnover)
                .HasPrecision(18, 6)
                .HasColumnName("lottery_turnover");
            entity.Property(e => e.PlayerCode)
                .HasMaxLength(16)
                .HasColumnName("player_code");
            entity.Property(e => e.RebateAmount)
                .HasPrecision(18, 6)
                .HasColumnName("rebate_amount");
            entity.Property(e => e.ReportDate).HasColumnName("report_date");
            entity.Property(e => e.SentByUsername).HasColumnName("sent_by_username");
            entity.Property(e => e.SentOn).HasColumnName("sent_on");
            entity.Property(e => e.SlotRebateAmount)
                .HasPrecision(18, 6)
                .HasColumnName("slot_rebate_amount");
            entity.Property(e => e.SlotTurnover)
                .HasPrecision(18, 6)
                .HasColumnName("slot_turnover");
            entity.Property(e => e.SportsRebateAmount)
                .HasPrecision(18, 6)
                .HasColumnName("sports_rebate_amount");
            entity.Property(e => e.SportsTurnover)
                .HasPrecision(18, 6)
                .HasColumnName("sports_turnover");
            entity.Property(e => e.VipCardGameRebatePercentage)
                .HasPrecision(18, 6)
                .HasColumnName("vip_card_game_rebate_percentage");
            entity.Property(e => e.VipLiveDealerRebatePercentage)
                .HasPrecision(18, 6)
                .HasColumnName("vip_live_dealer_rebate_percentage");
            entity.Property(e => e.VipLotteryRebatePercentage)
                .HasPrecision(18, 6)
                .HasColumnName("vip_lottery_rebate_percentage");
            entity.Property(e => e.VipSlotRebatePercentage)
                .HasPrecision(18, 6)
                .HasColumnName("vip_slot_rebate_percentage");
            entity.Property(e => e.VipSportsRebatePercentage)
                .HasPrecision(18, 6)
                .HasColumnName("vip_sports_rebate_percentage");
            entity.Property(e => e.VipVirtualSportsRebatePercentage)
                .HasPrecision(18, 6)
                .HasColumnName("vip_virtual_sports_rebate_percentage");
            entity.Property(e => e.VirtualSportsRebateAmount)
                .HasPrecision(18, 6)
                .HasColumnName("virtual_sports_rebate_amount");
            entity.Property(e => e.VirtualSportsTurnover)
                .HasPrecision(18, 6)
                .HasColumnName("virtual_sports_turnover");
        });

        modelBuilder.Entity<PlayerSportsBetLimit>(entity =>
        {
            entity.HasKey(e => new { e.PlayerCode, e.SportMarketTypeId }).HasName("pk_player_sports_bet_limits");

            entity.ToTable("player_sports_bet_limits", "dbo");

            entity.HasIndex(e => e.SportMarketTypeId, "ix_player_sports_bet_limits_sport_market_id");

            entity.Property(e => e.PlayerCode)
                .HasMaxLength(16)
                .HasColumnName("player_code");
            entity.Property(e => e.SportMarketTypeId).HasColumnName("sport_market_type_id");
            entity.Property(e => e.MaxBet).HasColumnName("max_bet");
            entity.Property(e => e.MaxBetPerMatch).HasColumnName("max_bet_per_match");
            entity.Property(e => e.MinBet).HasColumnName("min_bet");

            entity.HasOne(d => d.PlayerCodeNavigation).WithMany(p => p.PlayerSportsBetLimits)
                .HasForeignKey(d => d.PlayerCode)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_player_sports_bet_limits_players_player_code");

            entity.HasOne(d => d.SportMarketType).WithMany(p => p.PlayerSportsBetLimits)
                .HasForeignKey(d => d.SportMarketTypeId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_player_sports_bet_limits_sport_market_types_sport_market_typ");
        });

        modelBuilder.Entity<PlayerTag>(entity =>
        {
            entity.HasKey(e => new { e.Tag, e.PlayerCode }).HasName("pk_tag_player_code_tag");

            entity.ToTable("player_tags", "dbo");

            entity.Property(e => e.Tag).HasColumnName("tag");
            entity.Property(e => e.PlayerCode)
                .HasMaxLength(16)
                .HasColumnName("player_code");
        });

        modelBuilder.Entity<PlayerVipLevel>(entity =>
        {
            entity.HasKey(e => e.PlayerCode).HasName("pk_player_vip_levels");

            entity.ToTable("player_vip_levels", "dbo");

            entity.Property(e => e.PlayerCode)
                .HasMaxLength(16)
                .HasComment("玩家代碼")
                .HasColumnName("player_code");
            entity.Property(e => e.AutoState)
                .HasDefaultValue(0)
                .HasComment("自動狀態(0:啟用 1:停用)")
                .HasColumnName("auto_state");
            entity.Property(e => e.VipLevel)
                .HasDefaultValue(1)
                .HasComment("VipLevel等級")
                .HasColumnName("vip_level");
            entity.Property(e => e.VipLevelId)
                .HasComment("VipLevel識別碼")
                .HasColumnName("vip_level_id");
        });

        modelBuilder.Entity<PlayerVipLevelBirthdayForm>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_player_vip_level_birthday_forms");

            entity.ToTable("player_vip_level_birthday_forms", "dbo");

            entity.HasIndex(e => e.CreatedOn, "ix_player_vip_level_b_f_created_on");

            entity.HasIndex(e => new { e.PlayerCode, e.Birthday }, "uni_player_vip_level_b_f_player_code_birthday").IsUnique();

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasComment("識別碼")
                .HasColumnName("id");
            entity.Property(e => e.ActualAmount)
                .HasPrecision(18, 6)
                .HasComment("實際金額")
                .HasColumnName("actual_amount");
            entity.Property(e => e.Amount)
                .HasPrecision(18, 6)
                .HasComment("金額")
                .HasColumnName("amount");
            entity.Property(e => e.AutoState)
                .HasDefaultValue(true)
                .HasComment("自動狀態(True:自動;False:手動)")
                .HasColumnName("auto_state");
            entity.Property(e => e.Birthday)
                .HasComment("生日")
                .HasColumnName("birthday");
            entity.Property(e => e.BrandId)
                .HasComment("平台識別碼")
                .HasColumnName("brand_id");
            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasComment("創建時間")
                .HasColumnName("created_on");
            entity.Property(e => e.CreatedUserId)
                .HasComment("創建使用者識別碼")
                .HasColumnName("created_user_id");
            entity.Property(e => e.CreatedUsername)
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasComment("創建使用者名稱")
                .HasColumnName("created_username");
            entity.Property(e => e.PlayerCode)
                .HasMaxLength(16)
                .HasComment("玩家代碼")
                .HasColumnName("player_code");
            entity.Property(e => e.Remark)
                .HasDefaultValueSql("''::text")
                .HasComment("備註")
                .HasColumnName("remark");
            entity.Property(e => e.SnapshotVipLevel)
                .HasDefaultValueSql("'{}'::jsonb")
                .HasComment("Snapshot Vip Level")
                .HasColumnType("jsonb")
                .HasColumnName("snapshot_vip_level");
            entity.Property(e => e.State)
                .HasComment("狀態")
                .HasColumnName("state");
            entity.Property(e => e.UpdatedOn)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasComment("更新時間")
                .HasColumnName("updated_on");
            entity.Property(e => e.UpdatedUserId)
                .HasComment("更新使用者識別碼")
                .HasColumnName("updated_user_id");
            entity.Property(e => e.UpdatedUsername)
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasComment("更新使用者名稱")
                .HasColumnName("updated_username");
            entity.Property(e => e.VipLevel)
                .HasDefaultValue(0)
                .HasComment("Vip等級")
                .HasColumnName("vip_level");
        });

        modelBuilder.Entity<PlayerVipLevelCycleForm>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_player_vip_level_cycle_forms");

            entity.ToTable("player_vip_level_cycle_forms", "dbo");

            entity.HasIndex(e => e.CreatedOn, "ix_player_vip_level_cycle_f_created_on");

            entity.HasIndex(e => new { e.PlayerCode, e.CycleType, e.CycleOn }, "uni_player_vip_level_cycle_f_player_code_cycle").IsUnique();

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasComment("識別碼")
                .HasColumnName("id");
            entity.Property(e => e.ActualAmount)
                .HasPrecision(18, 6)
                .HasComment("實際金額")
                .HasColumnName("actual_amount");
            entity.Property(e => e.Amount)
                .HasPrecision(18, 6)
                .HasComment("金額")
                .HasColumnName("amount");
            entity.Property(e => e.AutoState)
                .HasDefaultValue(true)
                .HasComment("自動狀態(True:自動;False:手動)")
                .HasColumnName("auto_state");
            entity.Property(e => e.BrandId)
                .HasComment("平台識別碼")
                .HasColumnName("brand_id");
            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasComment("創建時間")
                .HasColumnName("created_on");
            entity.Property(e => e.CreatedUserId)
                .HasComment("創建使用者識別碼")
                .HasColumnName("created_user_id");
            entity.Property(e => e.CreatedUsername)
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasComment("創建使用者名稱")
                .HasColumnName("created_username");
            entity.Property(e => e.CycleOn)
                .HasComment("週期日期")
                .HasColumnName("cycle_on");
            entity.Property(e => e.CycleType)
                .HasComment("週期類型(1:日 2:周 3:月)")
                .HasColumnName("cycle_type");
            entity.Property(e => e.FromOn)
                .HasComment("起始日期")
                .HasColumnName("from_on");
            entity.Property(e => e.PlayerCode)
                .HasMaxLength(16)
                .HasComment("玩家代碼")
                .HasColumnName("player_code");
            entity.Property(e => e.Remark)
                .HasDefaultValueSql("''::text")
                .HasComment("備註")
                .HasColumnName("remark");
            entity.Property(e => e.SnapshotVipLevel)
                .HasDefaultValueSql("'{}'::jsonb")
                .HasComment("Snapshot Vip Level")
                .HasColumnType("jsonb")
                .HasColumnName("snapshot_vip_level");
            entity.Property(e => e.State)
                .HasComment("狀態")
                .HasColumnName("state");
            entity.Property(e => e.ToOn)
                .HasComment("結束日期")
                .HasColumnName("to_on");
            entity.Property(e => e.UpdatedOn)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasComment("更新時間")
                .HasColumnName("updated_on");
            entity.Property(e => e.UpdatedUserId)
                .HasComment("更新使用者識別碼")
                .HasColumnName("updated_user_id");
            entity.Property(e => e.UpdatedUsername)
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasComment("更新使用者名稱")
                .HasColumnName("updated_username");
            entity.Property(e => e.VipLevel)
                .HasComment("Vip等級")
                .HasColumnName("vip_level");
        });

        modelBuilder.Entity<PlayerVipLevelLog>(entity =>
        {
            entity.HasKey(e => new { e.CreatedOn, e.Id }).HasName("pk_player_vip_level_logs");

            entity.ToTable("player_vip_level_logs", "dbo");

            entity.HasIndex(e => e.CreatedOn, "ix_player_vip_level_logs_created_on");

            entity.HasIndex(e => new { e.CreatedOn, e.PlayerCode }, "ix_player_vip_level_logs_created_on_player_code");

            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasComment("創建時間")
                .HasColumnName("created_on");
            entity.Property(e => e.Id)
                .HasComment("識別碼")
                .HasColumnName("id");
            entity.Property(e => e.After)
                .HasDefaultValueSql("'{}'::jsonb")
                .HasComment("之後")
                .HasColumnType("jsonb")
                .HasColumnName("after");
            entity.Property(e => e.Before)
                .HasDefaultValueSql("'{}'::jsonb")
                .HasComment("之前")
                .HasColumnType("jsonb")
                .HasColumnName("before");
            entity.Property(e => e.CreatedUserId)
                .HasComment("創建使用者識別碼")
                .HasColumnName("created_user_id");
            entity.Property(e => e.CreatedUsername)
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasComment("創建使用者名稱")
                .HasColumnName("created_username");
            entity.Property(e => e.PlayerCode)
                .HasMaxLength(16)
                .HasComment("玩家代碼")
                .HasColumnName("player_code");
            entity.Property(e => e.Remark)
                .HasDefaultValueSql("''::text")
                .HasComment("備註")
                .HasColumnName("remark");
            entity.Property(e => e.Type)
                .HasDefaultValue(1)
                .HasComment("日誌類型")
                .HasColumnName("type");
        });

        modelBuilder.Entity<PlayerVipLevelUpgradeForm>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_player_vip_level_upgrade_forms");

            entity.ToTable("player_vip_level_upgrade_forms", "dbo");

            entity.HasIndex(e => e.CreatedOn, "ix_player_vip_level_u_f_created_on");

            entity.HasIndex(e => new { e.PlayerCode, e.VipLevel }, "ix_player_vip_level_u_f_player_code_vip_level");

            entity.HasIndex(e => new { e.PlayerCode, e.VipLevel, e.RepeatTimes }, "uni_player_vip_level_u_f_player_code_vip_level").IsUnique();

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasComment("識別碼")
                .HasColumnName("id");
            entity.Property(e => e.ActualAmount)
                .HasPrecision(18, 6)
                .HasComment("實際金額")
                .HasColumnName("actual_amount");
            entity.Property(e => e.Amount)
                .HasPrecision(18, 6)
                .HasComment("金額")
                .HasColumnName("amount");
            entity.Property(e => e.AutoState)
                .HasDefaultValue(true)
                .HasComment("自動狀態(True:自動;False:手動)")
                .HasColumnName("auto_state");
            entity.Property(e => e.BrandId)
                .HasComment("平台識別碼")
                .HasColumnName("brand_id");
            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasComment("創建時間")
                .HasColumnName("created_on");
            entity.Property(e => e.CreatedUserId)
                .HasComment("創建使用者識別碼")
                .HasColumnName("created_user_id");
            entity.Property(e => e.CreatedUsername)
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasComment("創建使用者名稱")
                .HasColumnName("created_username");
            entity.Property(e => e.PlayerCode)
                .HasMaxLength(16)
                .HasComment("玩家代碼")
                .HasColumnName("player_code");
            entity.Property(e => e.Remark)
                .HasDefaultValueSql("''::text")
                .HasComment("備註")
                .HasColumnName("remark");
            entity.Property(e => e.RepeatTimes)
                .HasDefaultValue(0)
                .HasComment("重複次數")
                .HasColumnName("repeat_times");
            entity.Property(e => e.SnapshotVipLevel)
                .HasDefaultValueSql("'{}'::jsonb")
                .HasComment("Snapshot Vip Level")
                .HasColumnType("jsonb")
                .HasColumnName("snapshot_vip_level");
            entity.Property(e => e.State)
                .HasComment("狀態")
                .HasColumnName("state");
            entity.Property(e => e.UpdatedOn)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasComment("更新時間")
                .HasColumnName("updated_on");
            entity.Property(e => e.UpdatedUserId)
                .HasComment("更新使用者識別碼")
                .HasColumnName("updated_user_id");
            entity.Property(e => e.UpdatedUsername)
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasComment("更新使用者名稱")
                .HasColumnName("updated_username");
            entity.Property(e => e.VipLevel)
                .HasComment("Vip等級")
                .HasColumnName("vip_level");
        });

        modelBuilder.Entity<Promotion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_promotions_id");

            entity.ToTable("promotions", "dbo");

            entity.HasIndex(e => e.BrandId, "ix_promotions_brand_id");

            entity.HasIndex(e => e.VipLevelId, "ix_promotions_vip_level_id");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.AmountUsed)
                .HasPrecision(18, 6)
                .HasColumnName("amount_used");
            entity.Property(e => e.AmountUsedSnapshotId).HasColumnName("amount_used_snapshot_id");
            entity.Property(e => e.AutoSentPlayerBonus).HasColumnName("auto_sent_player_bonus");
            entity.Property(e => e.BonusAmountLimit)
                .HasPrecision(18, 6)
                .HasColumnName("bonus_amount_limit");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.CampaignDetail)
                .HasDefaultValueSql("'{}'::jsonb")
                .HasColumnType("jsonb")
                .HasColumnName("campaign_detail");
            entity.Property(e => e.Content).HasColumnName("content");
            entity.Property(e => e.CreatedByUsername).HasColumnName("created_by_username");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
            entity.Property(e => e.DesktopBanner)
                .HasMaxLength(128)
                .HasColumnName("desktop_banner");
            entity.Property(e => e.DisplayOrder)
                .HasDefaultValue(1)
                .HasColumnName("display_order");
            entity.Property(e => e.From).HasColumnName("from");
            entity.Property(e => e.GameType).HasColumnName("game_type");
            entity.Property(e => e.Localization)
                .HasColumnType("jsonb")
                .HasColumnName("localization");
            entity.Property(e => e.MobileBanner)
                .HasMaxLength(128)
                .HasColumnName("mobile_banner");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasColumnName("name");
            entity.Property(e => e.Percentage)
                .HasPrecision(9, 6)
                .HasColumnName("percentage");
            entity.Property(e => e.PromotionType).HasColumnName("promotion_type");
            entity.Property(e => e.SettlementIntervalType).HasColumnName("settlement_interval_type");
            entity.Property(e => e.SnapshotEventId).HasColumnName("snapshot_event_id");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.SubSubject)
                .HasMaxLength(2048)
                .HasColumnName("sub_subject");
            entity.Property(e => e.Terms).HasColumnName("terms");
            entity.Property(e => e.To).HasColumnName("to");
            entity.Property(e => e.TotalAmountLimit)
                .HasPrecision(18, 6)
                .HasColumnName("total_amount_limit");
            entity.Property(e => e.TurnoverMultiple)
                .HasPrecision(18, 6)
                .HasColumnName("turnover_multiple");
            entity.Property(e => e.Unlimited).HasColumnName("unlimited");
            entity.Property(e => e.UpdatedByUsername).HasColumnName("updated_by_username");
            entity.Property(e => e.UpdatedOn).HasColumnName("updated_on");
            entity.Property(e => e.VipLevelId).HasColumnName("vip_level_id");

            entity.HasOne(d => d.Brand).WithMany(p => p.Promotions)
                .HasForeignKey(d => d.BrandId)
                .HasConstraintName("fk_promotions_brands_brand_id");

            entity.HasOne(d => d.VipLevel).WithMany(p => p.Promotions)
                .HasForeignKey(d => d.VipLevelId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_promotions_vip_levels_vip_level_id");

            entity.HasMany(d => d.GameProviders).WithMany(p => p.Promotions)
                .UsingEntity<Dictionary<string, object>>(
                    "PromotionGameProvider",
                    r => r.HasOne<GameProvider>().WithMany()
                        .HasForeignKey("GameProviderId")
                        .HasConstraintName("fk_promotion_game_provider_game_provider_id"),
                    l => l.HasOne<Promotion>().WithMany()
                        .HasForeignKey("PromotionId")
                        .HasConstraintName("fk_promotion_game_provider_promotion_id"),
                    j =>
                    {
                        j.HasKey("PromotionId", "GameProviderId").HasName("pk_promotion_game_providers");
                        j.ToTable("promotion_game_providers", "dbo");
                        j.HasIndex(new[] { "GameProviderId" }, "ix_promotion_game_provider_game_provider_id");
                        j.IndexerProperty<Guid>("PromotionId").HasColumnName("promotion_id");
                        j.IndexerProperty<Guid>("GameProviderId").HasColumnName("game_provider_id");
                    });
        });

        modelBuilder.Entity<PromotionBonuse>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_promotion_bonus_id");

            entity.ToTable("promotion_bonuses", "dbo");

            entity.HasIndex(e => e.BrandId, "ix_promotion_bonus_brand_id");

            entity.HasIndex(e => new { e.BrandId, e.From, e.To }, "ix_promotion_bonus_brand_id_from_to");

            entity.HasIndex(e => e.PromotionId, "ix_promotion_bonus_promotion_id");

            entity.HasIndex(e => new { e.PromotionId, e.From, e.To }, "ix_promotion_bonus_promotion_id_from_to");

            entity.HasIndex(e => new { e.PromotionId, e.From, e.To }, "ux_promotion_bonuses_relief_money_daily")
                .IsUnique()
                .HasFilter("(promotion_type = 'ReliefMoneyDaily'::text)");

            entity.HasIndex(e => new { e.PromotionId, e.From, e.To }, "ux_promotion_bonuses_relief_money_monthly")
                .IsUnique()
                .HasFilter("(promotion_type = 'ReliefMoneyMonthly'::text)");

            entity.HasIndex(e => new { e.PromotionId, e.From, e.To }, "ux_promotion_bonuses_relief_money_weekly")
                .IsUnique()
                .HasFilter("(promotion_type = 'ReliefMoneyWeekly'::text)");

            entity.HasIndex(e => new { e.PromotionId, e.From, e.To }, "ux_promotion_bonuses_turnover_rebate_daily")
                .IsUnique()
                .HasFilter("(promotion_type = 'TurnoverRebate'::text)");

            entity.HasIndex(e => new { e.PromotionId, e.From, e.To }, "ux_promotion_bonuses_turnover_rebate_weekly")
                .IsUnique()
                .HasFilter("(promotion_type = 'TurnoverRebateWeekly'::text)");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.BonusAmountLimit)
                .HasPrecision(18, 6)
                .HasColumnName("bonus_amount_limit");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
            entity.Property(e => e.Detail)
                .HasColumnType("jsonb")
                .HasColumnName("detail");
            entity.Property(e => e.From).HasColumnName("from");
            entity.Property(e => e.GameType).HasColumnName("game_type");
            entity.Property(e => e.Percentage)
                .HasPrecision(9, 6)
                .HasColumnName("percentage");
            entity.Property(e => e.PromotionId).HasColumnName("promotion_id");
            entity.Property(e => e.PromotionType).HasColumnName("promotion_type");
            entity.Property(e => e.To).HasColumnName("to");
            entity.Property(e => e.TotalAmountLimit)
                .HasPrecision(18, 6)
                .HasColumnName("total_amount_limit");
            entity.Property(e => e.TurnoverMultiple).HasColumnName("turnover_multiple");

            entity.HasOne(d => d.Promotion).WithMany(p => p.PromotionBonuses)
                .HasForeignKey(d => d.PromotionId)
                .HasConstraintName("fk_promotion_bonus_promotion_id");
        });

        modelBuilder.Entity<PromotionDistribute>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_promotion_distributes");

            entity.ToTable("promotion_distributes", "dbo");

            entity.HasIndex(e => new { e.PlayerCode, e.PlanId }, "ux_promotion_distributes")
                .IsUnique()
                .HasFilter("(plan_id IS NOT NULL)");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.BonusAmount).HasColumnName("bonus_amount");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.Bucket).HasColumnName("bucket");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
            entity.Property(e => e.Distributor).HasColumnName("distributor");
            entity.Property(e => e.PlanId).HasColumnName("plan_id");
            entity.Property(e => e.PlayerCode).HasColumnName("player_code");
            entity.Property(e => e.PromotionId).HasColumnName("promotion_id");
            entity.Property(e => e.ReferenceId).HasColumnName("reference_id");
            entity.Property(e => e.SentOn).HasColumnName("sent_on");
        });

        modelBuilder.Entity<PromotionDistributeLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_promotion_distribute_logs");

            entity.ToTable("promotion_distribute_logs", "dbo");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Action).HasColumnName("action");
            entity.Property(e => e.ChangeSets)
                .HasColumnType("jsonb")
                .HasColumnName("change_sets");
            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_on");
            entity.Property(e => e.DistributeId).HasColumnName("distribute_id");
        });

        modelBuilder.Entity<PromotionDistributePlan>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_promotion_distribute_plans");

            entity.ToTable("promotion_distribute_plans", "dbo");

            entity.HasIndex(e => new { e.BrandId, e.PromotionId, e.ConditionHash }, "ux_promotion_distrubute_plans").IsUnique();

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.ConditionHash).HasColumnName("condition_hash");
            entity.Property(e => e.Detail)
                .HasColumnType("jsonb")
                .HasColumnName("detail");
            entity.Property(e => e.PromotionId).HasColumnName("promotion_id");
        });

        modelBuilder.Entity<PromotionEventSource>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_promotion_event_source");

            entity.ToTable("promotion_event_source", "dbo");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Action).HasColumnName("action");
            entity.Property(e => e.ChangeSets)
                .HasColumnType("jsonb")
                .HasColumnName("change_sets");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
            entity.Property(e => e.ModifyUser).HasColumnName("modify_user");
            entity.Property(e => e.PromotionId).HasColumnName("promotion_id");
        });

        modelBuilder.Entity<PromotionGroup>(entity =>
        {
            entity.HasKey(e => e.Name).HasName("pk_promotion_groups");

            entity.ToTable("promotion_groups", "dbo");

            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Translate)
                .HasColumnType("jsonb")
                .HasColumnName("translate");
        });

        modelBuilder.Entity<PromotionParticipant>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_promotion_participants_id");

            entity.ToTable("promotion_participants", "dbo");

            entity.HasIndex(e => e.PlayerCode, "ix_promotion_participant_player_code");

            entity.HasIndex(e => e.PromotionId, "ix_promotion_participants_promotion_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("'0001-01-01 00:00:00+00'::timestamp with time zone")
                .HasColumnName("created_on");
            entity.Property(e => e.PlayerCode)
                .HasMaxLength(16)
                .HasColumnName("player_code");
            entity.Property(e => e.PromotionId).HasColumnName("promotion_id");

            entity.HasOne(d => d.PlayerCodeNavigation).WithMany(p => p.PromotionParticipants)
                .HasForeignKey(d => d.PlayerCode)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_promotion_participant_player_code");

            entity.HasOne(d => d.Promotion).WithMany(p => p.PromotionParticipants)
                .HasForeignKey(d => d.PromotionId)
                .HasConstraintName("fk_promotion_participant_promotion_id");
        });

        modelBuilder.Entity<PromotionPlayer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_promotion_player_id");

            entity.ToTable("promotion_players", "dbo");

            entity.HasIndex(e => new { e.PlayerCode, e.PromotionBonusId }, "ix_promotion_player_multiple_keys");

            entity.HasIndex(e => e.PlayerCode, "ix_promotion_player_promotion_id");

            entity.HasIndex(e => e.PromotionBonusId, "ix_promotion_players_promotion_bonus_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BonusAmount)
                .HasPrecision(18, 6)
                .HasColumnName("bonus_amount");
            entity.Property(e => e.BucketAmountByManual)
                .HasPrecision(18, 6)
                .HasColumnName("bucket_amount_by_manual");
            entity.Property(e => e.PlayerCode)
                .HasMaxLength(16)
                .HasColumnName("player_code");
            entity.Property(e => e.PromotionBonusId).HasColumnName("promotion_bonus_id");
            entity.Property(e => e.SentByUsername).HasColumnName("sent_by_username");
            entity.Property(e => e.SentOn).HasColumnName("sent_on");

            entity.HasOne(d => d.PlayerCodeNavigation).WithMany(p => p.PromotionPlayers)
                .HasForeignKey(d => d.PlayerCode)
                .HasConstraintName("fk_promotion_bonus_player_code");

            entity.HasOne(d => d.PromotionBonus).WithMany(p => p.PromotionPlayers)
                .HasForeignKey(d => d.PromotionBonusId)
                .HasConstraintName("fk_promotion_bonus_promotion_brand_id");
        });

        modelBuilder.Entity<PromotionPromoteDepositChannel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_promotion_promote_deposit_channels");

            entity.ToTable("promotion_promote_deposit_channels", "dbo");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Bonus).HasColumnName("bonus");
            entity.Property(e => e.BucketAmount).HasColumnName("bucket_amount");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
            entity.Property(e => e.DistributePlanId).HasColumnName("distribute_plan_id");
            entity.Property(e => e.FormId).HasColumnName("form_id");
            entity.Property(e => e.PlayerCode).HasColumnName("player_code");
            entity.Property(e => e.PromotionId).HasColumnName("promotion_id");
            entity.Property(e => e.VipLevel).HasColumnName("vip_level");
        });

        modelBuilder.Entity<PromotionRebateDailyStatistic>(entity =>
        {
            entity.HasKey(e => new { e.ReportDate, e.BrandId, e.PromotionId, e.PlayerCode }).HasName("pk_promotion_rebate_daily_statistics");

            entity.ToTable("promotion_rebate_daily_statistics", "dbo");

            entity.Property(e => e.ReportDate).HasColumnName("report_date");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.PromotionId).HasColumnName("promotion_id");
            entity.Property(e => e.PlayerCode).HasColumnName("player_code");
            entity.Property(e => e.Bonus)
                .HasPrecision(18, 6)
                .HasColumnName("bonus");
            entity.Property(e => e.BucketAmount)
                .HasPrecision(18, 6)
                .HasColumnName("bucket_amount");
            entity.Property(e => e.ReportDateTime)
                .HasDefaultValueSql("'-infinity'::timestamp with time zone")
                .HasColumnName("report_date_time");
            entity.Property(e => e.Settings)
                .HasDefaultValueSql("'{}'::jsonb")
                .HasColumnType("jsonb")
                .HasColumnName("settings");
            entity.Property(e => e.TotalTurnover)
                .HasPrecision(18, 6)
                .HasColumnName("total_turnover");
        });

        modelBuilder.Entity<PromotionRebateDistribute>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_promotion_rebate_distributes");

            entity.ToTable("promotion_rebate_distributes", "dbo");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Bonus)
                .HasPrecision(18, 6)
                .HasColumnName("bonus");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.BucketAmount)
                .HasPrecision(18, 6)
                .HasColumnName("bucket_amount");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
            entity.Property(e => e.DistributeDate).HasColumnName("distribute_date");
            entity.Property(e => e.PlayerCode).HasColumnName("player_code");
            entity.Property(e => e.PromotionId).HasColumnName("promotion_id");
            entity.Property(e => e.Settings)
                .HasDefaultValueSql("'{}'::jsonb")
                .HasColumnType("jsonb")
                .HasColumnName("settings");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<PromotionReliefDailyStatistic>(entity =>
        {
            entity.HasKey(e => new { e.ReportDate, e.BrandId, e.PromotionId, e.PlayerCode }).HasName("pk_promotion_relief_daily_statistics");

            entity.ToTable("promotion_relief_daily_statistics", "dbo");

            entity.Property(e => e.ReportDate).HasColumnName("report_date");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.PromotionId).HasColumnName("promotion_id");
            entity.Property(e => e.PlayerCode).HasColumnName("player_code");
            entity.Property(e => e.Bonus)
                .HasPrecision(18, 6)
                .HasColumnName("bonus");
            entity.Property(e => e.BucketAmount)
                .HasPrecision(18, 6)
                .HasColumnName("bucket_amount");
            entity.Property(e => e.ReportDateTime)
                .HasDefaultValueSql("'-infinity'::timestamp with time zone")
                .HasColumnName("report_date_time");
            entity.Property(e => e.Settings)
                .HasDefaultValueSql("'{}'::jsonb")
                .HasColumnType("jsonb")
                .HasColumnName("settings");
            entity.Property(e => e.TotalWinLoss)
                .HasPrecision(18, 6)
                .HasColumnName("total_win_loss");
        });

        modelBuilder.Entity<PromotionReliefDistribute>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_promotion_relief_distributes");

            entity.ToTable("promotion_relief_distributes", "dbo");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Bonus)
                .HasPrecision(18, 6)
                .HasColumnName("bonus");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.BucketAmount)
                .HasPrecision(18, 6)
                .HasColumnName("bucket_amount");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
            entity.Property(e => e.DistributeDate).HasColumnName("distribute_date");
            entity.Property(e => e.PlayerCode).HasColumnName("player_code");
            entity.Property(e => e.PromotionId).HasColumnName("promotion_id");
            entity.Property(e => e.Settings)
                .HasDefaultValueSql("'{}'::jsonb")
                .HasColumnType("jsonb")
                .HasColumnName("settings");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<PromotionType>(entity =>
        {
            entity.HasKey(e => e.Name).HasName("pk_promotion_types");

            entity.ToTable("promotion_types", "dbo");

            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Extend)
                .HasColumnType("jsonb")
                .HasColumnName("extend");
            entity.Property(e => e.Translate)
                .HasColumnType("jsonb")
                .HasColumnName("translate");
        });

        modelBuilder.Entity<PromotionVipLevel>(entity =>
        {
            entity.HasKey(e => new { e.PromotionId, e.VipLevelId }).HasName("pk_promotion_vip_levels");

            entity.ToTable("promotion_vip_levels", "dbo");

            entity.HasIndex(e => e.Level, "ix_promotion_vip_level_vip_level_id");

            entity.HasIndex(e => e.VipLevelId, "ix_promotion_vip_levels_vip_level_id");

            entity.Property(e => e.PromotionId).HasColumnName("promotion_id");
            entity.Property(e => e.VipLevelId).HasColumnName("vip_level_id");
            entity.Property(e => e.Level).HasColumnName("level");

            entity.HasOne(d => d.Promotion).WithMany(p => p.PromotionVipLevels)
                .HasForeignKey(d => d.PromotionId)
                .HasConstraintName("fk_promotion_vip_level_promotion_id");

            entity.HasOne(d => d.VipLevel).WithMany(p => p.PromotionVipLevels)
                .HasForeignKey(d => d.VipLevelId)
                .HasConstraintName("fk_promotion_vip_level_vip_level_id");
        });

        modelBuilder.Entity<RebatePromotionJoinPlayer>(entity =>
        {
            entity.HasKey(e => new { e.PromotionId, e.PlayerCode }).HasName("pk_rebate_promotion_join_players");

            entity.ToTable("rebate_promotion_join_players", "dbo");

            entity.HasIndex(e => e.PlayerCode, "ix_rebate_promotion_join_players_player_code");

            entity.Property(e => e.PromotionId).HasColumnName("promotion_id");
            entity.Property(e => e.PlayerCode)
                .HasMaxLength(16)
                .HasColumnName("player_code");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");

            entity.HasOne(d => d.PlayerCodeNavigation).WithMany(p => p.RebatePromotionJoinPlayers)
                .HasForeignKey(d => d.PlayerCode)
                .HasConstraintName("fk_players_rebate_promotion_join_players");

            entity.HasOne(d => d.Promotion).WithMany(p => p.RebatePromotionJoinPlayers)
                .HasForeignKey(d => d.PromotionId)
                .HasConstraintName("fk_promotions_rebate_promotion_join_players");
        });

        modelBuilder.Entity<ReliefPromotionJoinPlayer>(entity =>
        {
            entity.HasKey(e => new { e.PromotionId, e.PlayerCode }).HasName("pk_relief_promotion_join_players");

            entity.ToTable("relief_promotion_join_players", "dbo");

            entity.HasIndex(e => e.PlayerCode, "ix_relief_promotion_join_players_player_code");

            entity.Property(e => e.PromotionId).HasColumnName("promotion_id");
            entity.Property(e => e.PlayerCode)
                .HasMaxLength(16)
                .HasColumnName("player_code");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");

            entity.HasOne(d => d.PlayerCodeNavigation).WithMany(p => p.ReliefPromotionJoinPlayers)
                .HasForeignKey(d => d.PlayerCode)
                .HasConstraintName("fk_players_rebate_promotion_join_players");

            entity.HasOne(d => d.Promotion).WithMany(p => p.ReliefPromotionJoinPlayers)
                .HasForeignKey(d => d.PromotionId)
                .HasConstraintName("fk_promotions_rebate_promotion_join_players");
        });

        modelBuilder.Entity<Reseller>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_resellers");

            entity.ToTable("resellers", "dbo");

            entity.HasIndex(e => new { e.Code, e.Name, e.Description, e.OperationalEmail }, "ix_resellers_code_name_description_operational_email");

            entity.HasIndex(e => new { e.Code, e.Name, e.Description, e.OperationalEmail }, "ix_trgm_resellers_code_name_description_operational_email")
                .HasMethod("gin")
                .HasOperators(new[] { "gin_trgm_ops", "gin_trgm_ops", "gin_trgm_ops", "gin_trgm_ops" });

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.BusinessType).HasColumnName("business_type");
            entity.Property(e => e.Code)
                .HasMaxLength(16)
                .HasColumnName("code");
            entity.Property(e => e.CreatedByUsername)
                .HasMaxLength(32)
                .HasColumnName("created_by_username");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
            entity.Property(e => e.Description)
                .HasMaxLength(256)
                .HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.OperationalEmail)
                .HasMaxLength(128)
                .HasColumnName("operational_email");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.UpdatedByUsername)
                .HasMaxLength(32)
                .HasColumnName("updated_by_username");
            entity.Property(e => e.UpdatedOn).HasColumnName("updated_on");

            entity.HasMany(d => d.BetLimits).WithMany(p => p.Resellers)
                .UsingEntity<Dictionary<string, object>>(
                    "ResellerBetLimit",
                    r => r.HasOne<BetLimit>().WithMany()
                        .HasForeignKey("BetLimitId")
                        .HasConstraintName("fk_reseller_bet_limits_resellers_bet_limit_id"),
                    l => l.HasOne<Reseller>().WithMany()
                        .HasForeignKey("ResellerId")
                        .HasConstraintName("fk_reseller_bet_limits_resellers_reseller_id"),
                    j =>
                    {
                        j.HasKey("ResellerId", "BetLimitId").HasName("pk_reseller_bet_limits");
                        j.ToTable("reseller_bet_limits", "dbo");
                        j.HasIndex(new[] { "BetLimitId" }, "ix_reseller_bet_limits_bet_limit_id");
                        j.IndexerProperty<Guid>("ResellerId").HasColumnName("reseller_id");
                        j.IndexerProperty<int>("BetLimitId").HasColumnName("bet_limit_id");
                    });

            entity.HasMany(d => d.CultureCodes).WithMany(p => p.Resellers)
                .UsingEntity<Dictionary<string, object>>(
                    "ResellerLanguage",
                    r => r.HasOne<Language>().WithMany()
                        .HasForeignKey("CultureCode")
                        .HasConstraintName("fk_reseller_languages_languages_culture_code"),
                    l => l.HasOne<Reseller>().WithMany()
                        .HasForeignKey("ResellerId")
                        .HasConstraintName("fk_reseller_languages_resellers_reseller_id"),
                    j =>
                    {
                        j.HasKey("ResellerId", "CultureCode").HasName("pk_reseller_languages");
                        j.ToTable("reseller_languages", "dbo");
                        j.HasIndex(new[] { "CultureCode" }, "ix_reseller_languages_culture_code");
                        j.IndexerProperty<Guid>("ResellerId").HasColumnName("reseller_id");
                        j.IndexerProperty<string>("CultureCode")
                            .HasMaxLength(6)
                            .HasColumnName("culture_code");
                    });

            entity.HasMany(d => d.CurrencyCodes).WithMany(p => p.Resellers)
                .UsingEntity<Dictionary<string, object>>(
                    "ResellerCurrency",
                    r => r.HasOne<Currency>().WithMany()
                        .HasForeignKey("CurrencyCode")
                        .HasConstraintName("fk_reseller_currencies_currencies_currency_code"),
                    l => l.HasOne<Reseller>().WithMany()
                        .HasForeignKey("ResellerId")
                        .HasConstraintName("fk_reseller_currencies_resellers_reseller_id"),
                    j =>
                    {
                        j.HasKey("ResellerId", "CurrencyCode").HasName("pk_reseller_currencies");
                        j.ToTable("reseller_currencies", "dbo");
                        j.HasIndex(new[] { "CurrencyCode" }, "ix_reseller_currencies_currency_code");
                        j.IndexerProperty<Guid>("ResellerId").HasColumnName("reseller_id");
                        j.IndexerProperty<string>("CurrencyCode")
                            .HasMaxLength(16)
                            .HasColumnName("currency_code");
                    });

            entity.HasMany(d => d.GameProviders).WithMany(p => p.Resellers)
                .UsingEntity<Dictionary<string, object>>(
                    "ResellerGameProvider",
                    r => r.HasOne<GameProvider>().WithMany()
                        .HasForeignKey("GameProviderId")
                        .HasConstraintName("fk_reseller_game_providers_game_providers_game_provider_id"),
                    l => l.HasOne<Reseller>().WithMany()
                        .HasForeignKey("ResellerId")
                        .HasConstraintName("fk_reseller_game_providers_game_resellers_reseller_id"),
                    j =>
                    {
                        j.HasKey("ResellerId", "GameProviderId").HasName("pk_reseller_game_providers");
                        j.ToTable("reseller_game_providers", "dbo");
                        j.HasIndex(new[] { "GameProviderId" }, "ix_reseller_game_providers_game_provider_id");
                        j.IndexerProperty<Guid>("ResellerId").HasColumnName("reseller_id");
                        j.IndexerProperty<Guid>("GameProviderId").HasColumnName("game_provider_id");
                    });
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_roles");

            entity.ToTable("roles", "dbo");

            entity.HasIndex(e => e.Name, "ix_roles_name");

            entity.HasIndex(e => e.Name, "ix_trgm_roles_name")
                .HasMethod("gin")
                .HasOperators(new[] { "gin_trgm_ops" });

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.CreatedByUsername)
                .HasMaxLength(32)
                .HasColumnName("created_by_username");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
            entity.Property(e => e.Description)
                .HasMaxLength(128)
                .HasColumnName("description");
            entity.Property(e => e.DisplayName)
                .HasMaxLength(50)
                .HasColumnName("display_name");
            entity.Property(e => e.IsRoot).HasColumnName("is_root");
            entity.Property(e => e.LicenseeId).HasColumnName("licensee_id");
            entity.Property(e => e.MenuSetting)
                .HasColumnType("jsonb")
                .HasColumnName("menu_setting");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.ResellerId).HasColumnName("reseller_id");
            entity.Property(e => e.RoleType).HasColumnName("role_type");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.UpdatedByUsername)
                .HasMaxLength(32)
                .HasColumnName("updated_by_username");
            entity.Property(e => e.UpdatedOn).HasColumnName("updated_on");
        });

        modelBuilder.Entity<RouletteSignInEvent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_roulette_sign_in_events");

            entity.ToTable("roulette_sign_in_events", "dbo");

            entity.HasIndex(e => e.BrandId, "ix_roulette_sign_in_events_brand_id");

            entity.HasIndex(e => e.PlayerCode, "ix_roulette_sign_in_events_player_code");

            entity.HasIndex(e => e.PromotionId, "ix_roulette_sign_in_events_promotion_id");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Bonus)
                .HasPrecision(18, 6)
                .HasColumnName("bonus");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_on");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.ItemIndex).HasColumnName("item_index");
            entity.Property(e => e.PlayerCode)
                .HasMaxLength(16)
                .HasColumnName("player_code");
            entity.Property(e => e.PromotionId).HasColumnName("promotion_id");

            entity.HasOne(d => d.Brand).WithMany(p => p.RouletteSignInEvents)
                .HasForeignKey(d => d.BrandId)
                .HasConstraintName("fk_roulette_sign_in_events_brands_brand_id");

            entity.HasOne(d => d.PlayerCodeNavigation).WithMany(p => p.RouletteSignInEvents)
                .HasForeignKey(d => d.PlayerCode)
                .HasConstraintName("fk_roulette_sign_in_events_players_brand_id");

            entity.HasOne(d => d.Promotion).WithMany(p => p.RouletteSignInEvents)
                .HasForeignKey(d => d.PromotionId)
                .HasConstraintName("fk_roulette_sign_in_events_promotions_promotion_id");
        });

        modelBuilder.Entity<Setting>(entity =>
        {
            entity.HasKey(e => e.Key).HasName("pk_settings");

            entity.ToTable("settings", "dbo");

            entity.Property(e => e.Key)
                .HasMaxLength(32)
                .HasColumnName("key");
            entity.Property(e => e.CreatedByUsername)
                .HasMaxLength(32)
                .HasColumnName("created_by_username");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
            entity.Property(e => e.Description)
                .HasMaxLength(256)
                .HasColumnName("description");
            entity.Property(e => e.UpdatedByUsername)
                .HasMaxLength(32)
                .HasColumnName("updated_by_username");
            entity.Property(e => e.UpdatedOn).HasColumnName("updated_on");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<SignInEvent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_sign_in_events");

            entity.ToTable("sign_in_events", "dbo");

            entity.HasIndex(e => e.BrandId, "ix_sign_in_events_brand_id");

            entity.HasIndex(e => e.PlayerCode, "ix_sign_in_events_player_code");

            entity.HasIndex(e => e.PromotionId, "ix_sign_in_events_promotion_id");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.Combo)
                .HasDefaultValue(1)
                .HasColumnName("combo");
            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_on");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.PlayerCode)
                .HasMaxLength(16)
                .HasColumnName("player_code");
            entity.Property(e => e.PromotionId).HasColumnName("promotion_id");

            entity.HasOne(d => d.Brand).WithMany(p => p.SignInEvents)
                .HasForeignKey(d => d.BrandId)
                .HasConstraintName("fk_sign_in_events_brands_brand_id");

            entity.HasOne(d => d.PlayerCodeNavigation).WithMany(p => p.SignInEvents)
                .HasForeignKey(d => d.PlayerCode)
                .HasConstraintName("fk_sign_in_events_players_brand_id");

            entity.HasOne(d => d.Promotion).WithMany(p => p.SignInEvents)
                .HasForeignKey(d => d.PromotionId)
                .HasConstraintName("fk_sign_in_events_promotions_promotion_id");
        });

        modelBuilder.Entity<SmsSetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_sms_settings");

            entity.ToTable("sms_settings", "dbo");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .HasColumnName("code");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(256)
                .HasColumnName("created_by");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
            entity.Property(e => e.Name)
                .HasMaxLength(256)
                .HasColumnName("name");
            entity.Property(e => e.Setting)
                .HasColumnType("jsonb")
                .HasColumnName("setting");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(256)
                .HasColumnName("updated_by");
            entity.Property(e => e.UpdatedOn).HasColumnName("updated_on");
        });

        modelBuilder.Entity<SocialMediaSetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_social_media_settings");

            entity.ToTable("social_media_settings", "dbo");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(256)
                .HasColumnName("created_by");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
            entity.Property(e => e.Name)
                .HasMaxLength(256)
                .HasColumnName("name");
            entity.Property(e => e.Order).HasColumnName("order");
            entity.Property(e => e.Type)
                .HasMaxLength(128)
                .HasColumnName("type");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(256)
                .HasColumnName("updated_by");
            entity.Property(e => e.UpdatedOn).HasColumnName("updated_on");
            entity.Property(e => e.Url).HasColumnName("url");
        });

        modelBuilder.Entity<SportMarketType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_sport_market_types");

            entity.ToTable("sport_market_types", "dbo");

            entity.HasIndex(e => new { e.SportTypeId, e.MarketTypeId }, "ak_sport_market_types_sport_type_id_market_type_id").IsUnique();

            entity.HasIndex(e => e.MarketTypeId, "ix_sport_market_types_market_type_id");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.MarketTypeId).HasColumnName("market_type_id");
            entity.Property(e => e.SportTypeId).HasColumnName("sport_type_id");

            entity.HasOne(d => d.MarketType).WithMany(p => p.SportMarketTypes)
                .HasForeignKey(d => d.MarketTypeId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_sport_market_types_market_types_market_type_id");

            entity.HasOne(d => d.SportType).WithMany(p => p.SportMarketTypes)
                .HasForeignKey(d => d.SportTypeId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_sport_market_types_sport_types_sport_type_id");
        });

        modelBuilder.Entity<SportType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_sport_types");

            entity.ToTable("sport_types", "dbo");

            entity.HasIndex(e => new { e.GameProviderId, e.Code }, "ak_sport_types_game_provider_id_code").IsUnique();

            entity.HasIndex(e => e.GameProviderId, "ix_sport_types_game_provider_id");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(64)
                .HasColumnName("code");
            entity.Property(e => e.ExternalId)
                .HasMaxLength(16)
                .HasColumnName("external_id");
            entity.Property(e => e.GameProviderId).HasColumnName("game_provider_id");

            entity.HasOne(d => d.GameProvider).WithMany(p => p.SportTypes)
                .HasForeignKey(d => d.GameProviderId)
                .HasConstraintName("fk_sport_types_game_providers_game_provider_id");
        });

        modelBuilder.Entity<StationLetter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_station_letters");

            entity.ToTable("station_letters", "dbo");

            entity.HasIndex(e => e.BrandId, "ix_station_letters_brand_id");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.AssignedAllPlayers).HasColumnName("assigned_all_players");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.Content)
                .HasMaxLength(4000)
                .HasColumnName("content");
            entity.Property(e => e.CreatedByUsername)
                .HasMaxLength(32)
                .HasColumnName("created_by_username");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
            entity.Property(e => e.Localization)
                .HasDefaultValueSql("'{}'::jsonb")
                .HasColumnType("jsonb")
                .HasColumnName("localization");
            entity.Property(e => e.Remarks)
                .HasMaxLength(512)
                .HasColumnName("remarks");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Subject)
                .HasMaxLength(256)
                .HasColumnName("subject");
            entity.Property(e => e.UpdatedByUsername)
                .HasMaxLength(32)
                .HasColumnName("updated_by_username");
            entity.Property(e => e.UpdatedOn).HasColumnName("updated_on");
            entity.Property(e => e.VerifiedByUsername)
                .HasMaxLength(256)
                .HasColumnName("verified_by_username");

            entity.HasOne(d => d.Brand).WithMany(p => p.StationLetters)
                .HasForeignKey(d => d.BrandId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_station_letters_brands_brand_id");
        });

        modelBuilder.Entity<StationLetter2>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_station_letter2");

            entity.ToTable("station_letter2", "dbo");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.ComeFrom).HasColumnName("come_from");
            entity.Property(e => e.Content).HasColumnName("content");
            entity.Property(e => e.HaveRead)
                .HasDefaultValue(false)
                .HasColumnName("have_read");
            entity.Property(e => e.Quotation).HasColumnName("quotation");
            entity.Property(e => e.ReceivedOn).HasColumnName("received_on");
            entity.Property(e => e.Receiver).HasColumnName("receiver");
            entity.Property(e => e.Replied)
                .HasDefaultValue(false)
                .HasColumnName("replied");
            entity.Property(e => e.Sender).HasColumnName("sender");
            entity.Property(e => e.SentOn).HasColumnName("sent_on");
            entity.Property(e => e.Subject).HasColumnName("subject");
        });

        modelBuilder.Entity<StationLetterDeliveryBox>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_station_letter_delivery_box");

            entity.ToTable("station_letter_delivery_box", "dbo");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.ComeFrom).HasColumnName("come_from");
            entity.Property(e => e.Content).HasColumnName("content");
            entity.Property(e => e.Operator)
                .HasDefaultValueSql("''::text")
                .HasColumnName("operator");
            entity.Property(e => e.Receiver).HasColumnName("receiver");
            entity.Property(e => e.ReceiverType).HasColumnName("receiver_type");
            entity.Property(e => e.Sender).HasColumnName("sender");
            entity.Property(e => e.SentOn).HasColumnName("sent_on");
            entity.Property(e => e.Subject).HasColumnName("subject");
        });

        modelBuilder.Entity<StationLetterPlayer>(entity =>
        {
            entity.HasKey(e => new { e.StationLetterId, e.PlayerCode }).HasName("pk_station_letter_players");

            entity.ToTable("station_letter_players", "dbo");

            entity.HasIndex(e => e.PlayerCode, "ix_station_letter_players_player_code");

            entity.Property(e => e.StationLetterId).HasColumnName("station_letter_id");
            entity.Property(e => e.PlayerCode)
                .HasMaxLength(16)
                .HasColumnName("player_code");
            entity.Property(e => e.IsRead).HasColumnName("is_read");
            entity.Property(e => e.ReadOn).HasColumnName("read_on");

            entity.HasOne(d => d.PlayerCodeNavigation).WithMany(p => p.StationLetterPlayers)
                .HasForeignKey(d => d.PlayerCode)
                .HasConstraintName("fk_station_letter_players_players_player_code");

            entity.HasOne(d => d.StationLetter).WithMany(p => p.StationLetterPlayers)
                .HasForeignKey(d => d.StationLetterId)
                .HasConstraintName("fk_station_letter_players_station_letters_station_letter_id");
        });

        modelBuilder.Entity<SubGameProvider>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("pk_sub_game_providers");

            entity.ToTable("sub_game_providers", "dbo");

            entity.HasIndex(e => e.GameProviderId, "ix_sub_game_providers_game_provider_id");

            entity.Property(e => e.Code)
                .HasMaxLength(16)
                .HasColumnName("code");
            entity.Property(e => e.CreatedByUsername)
                .HasMaxLength(32)
                .HasColumnName("created_by_username");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
            entity.Property(e => e.Description)
                .HasMaxLength(128)
                .HasColumnName("description");
            entity.Property(e => e.GameProviderId).HasColumnName("game_provider_id");
            entity.Property(e => e.Localization)
                .HasColumnType("jsonb")
                .HasColumnName("localization");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.UpdatedByUsername)
                .HasMaxLength(32)
                .HasColumnName("updated_by_username");
            entity.Property(e => e.UpdatedOn).HasColumnName("updated_on");

            entity.HasOne(d => d.GameProvider).WithMany(p => p.SubGameProviders)
                .HasForeignKey(d => d.GameProviderId)
                .HasConstraintName("fk_sub_game_providers_game_providers_game_provider_id");
        });

        modelBuilder.Entity<System>(entity =>
        {
            entity.HasKey(e => e.Name).HasName("pk_systems");

            entity.ToTable("systems", "dbo");

            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<SystemLocalization>(entity =>
        {
            entity.HasKey(e => new { e.SystemCode, e.CultureCode, e.MessageId }).HasName("pk_system_localizations");

            entity.ToTable("system_localizations", "dbo");

            entity.Property(e => e.SystemCode).HasColumnName("system_code");
            entity.Property(e => e.CultureCode).HasColumnName("culture_code");
            entity.Property(e => e.MessageId).HasColumnName("message_id");
            entity.Property(e => e.Text).HasColumnName("text");
        });

        modelBuilder.Entity<Transaction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_transactions");

            entity.ToTable("transactions", "dbo");

            entity.HasIndex(e => e.BrandId, "ix_transactions_brand_id");

            entity.HasIndex(e => e.PlayerCode, "ix_transactions_player_code");

            entity.HasIndex(e => e.WalletId, "ix_transactions_wallet_id");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Amount)
                .HasPrecision(18, 6)
                .HasColumnName("amount");
            entity.Property(e => e.Balance)
                .HasPrecision(18, 6)
                .HasColumnName("balance");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.CreatedByUserId).HasColumnName("created_by_user_id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.ExternalTransactionId).HasColumnName("external_transaction_id");
            entity.Property(e => e.LockAmount)
                .HasPrecision(18, 6)
                .HasColumnName("lock_amount");
            entity.Property(e => e.LockedBalance)
                .HasPrecision(18, 6)
                .HasColumnName("locked_balance");
            entity.Property(e => e.PlayerCode).HasColumnName("player_code");
            entity.Property(e => e.RecordedOn).HasColumnName("recorded_on");
            entity.Property(e => e.SentOn).HasColumnName("sent_on");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.WalletId).HasColumnName("wallet_id");

            entity.HasOne(d => d.Brand).WithMany(p => p.Transactions)
                .HasForeignKey(d => d.BrandId)
                .HasConstraintName("fk_transactions_brands_brand_id");

            entity.HasOne(d => d.Wallet).WithMany(p => p.Transactions)
                .HasForeignKey(d => d.WalletId)
                .HasConstraintName("fk_transactions_wallets_wallet_id");
        });

        modelBuilder.Entity<TransactionPromotion>(entity =>
        {
            entity.HasKey(e => new { e.TransactionId, e.PromotionId }).HasName("pk_transaction_promotions");

            entity.ToTable("transaction_promotions", "dbo");

            entity.HasIndex(e => e.PromotionId, "ix_transaction_Promotion_id");

            entity.HasIndex(e => e.TransactionId, "ix_transactions_transaction_id");

            entity.Property(e => e.TransactionId).HasColumnName("transaction_id");
            entity.Property(e => e.PromotionId).HasColumnName("promotion_id");
            entity.Property(e => e.PromotionBonusId).HasColumnName("promotion_bonus_id");
            entity.Property(e => e.PromotionType).HasColumnName("promotion_type");

            entity.HasOne(d => d.Promotion).WithMany(p => p.TransactionPromotions)
                .HasForeignKey(d => d.PromotionId)
                .HasConstraintName("fk_transaction_promotion_promotion_id");
        });

        modelBuilder.Entity<TransactionsMgmBackup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("transactions_mgm_backup", "dbo");

            entity.Property(e => e.Amount)
                .HasPrecision(18, 6)
                .HasColumnName("amount");
            entity.Property(e => e.Balance)
                .HasPrecision(18, 6)
                .HasColumnName("balance");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.CreatedByUserId).HasColumnName("created_by_user_id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.ExternalTransactionId).HasColumnName("external_transaction_id");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.PlayerCode).HasColumnName("player_code");
            entity.Property(e => e.RecordedOn).HasColumnName("recorded_on");
            entity.Property(e => e.SentOn).HasColumnName("sent_on");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.WalletId).HasColumnName("wallet_id");
        });

        modelBuilder.Entity<TransferBalanceForm>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_transfer_balance_forms");

            entity.ToTable("transfer_balance_forms", "dbo");

            entity.HasIndex(e => e.BrandId, "ix_transfer_balance_forms_brand_id");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Amount)
                .HasPrecision(18, 6)
                .HasColumnName("amount");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_on");
            entity.Property(e => e.CreatedUserId)
                .HasDefaultValueSql("''::text")
                .HasColumnName("created_user_id");
            entity.Property(e => e.Drawee).HasColumnName("drawee");
            entity.Property(e => e.DraweeType).HasColumnName("drawee_type");
            entity.Property(e => e.IncludeInNetProfit)
                .HasDefaultValue(false)
                .HasColumnName("include_in_net_profit");
            entity.Property(e => e.Payee).HasColumnName("payee");
            entity.Property(e => e.PayeeType).HasColumnName("payee_type");

            entity.HasOne(d => d.Brand).WithMany(p => p.TransferBalanceForms)
                .HasForeignKey(d => d.BrandId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_transfer_balance_forms_brands_brand_id");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_users");

            entity.ToTable("users", "dbo");

            entity.HasIndex(e => e.Username, "ix_trgm_users_username")
                .HasMethod("gin")
                .HasOperators(new[] { "gin_trgm_ops" });

            entity.HasIndex(e => e.DepartmentId, "ix_users_department_id");

            entity.HasIndex(e => e.RoleId, "ix_users_role_id");

            entity.HasIndex(e => e.Username, "ix_users_username");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CreatedByUsername)
                .HasMaxLength(32)
                .HasColumnName("created_by_username");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
            entity.Property(e => e.DepartmentId).HasColumnName("department_id");
            entity.Property(e => e.LastLoginIp)
                .HasMaxLength(128)
                .HasColumnName("last_login_ip");
            entity.Property(e => e.LastLoginTime).HasColumnName("last_login_time");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .HasColumnName("name");
            entity.Property(e => e.Password).HasColumnName("password");
            entity.Property(e => e.RoleId).HasColumnName("role_id");
            entity.Property(e => e.Salt).HasColumnName("salt");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.TimeZone)
                .HasMaxLength(256)
                .HasColumnName("time_zone");
            entity.Property(e => e.UpdatedByUsername)
                .HasMaxLength(32)
                .HasColumnName("updated_by_username");
            entity.Property(e => e.UpdatedOn).HasColumnName("updated_on");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .HasColumnName("username");

            entity.HasOne(d => d.Department).WithMany(p => p.Users)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("fk_users_departments_department_id");

            entity.HasOne(d => d.Role).WithMany(p => p.Users)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("fk_users_roles_role_id");
        });

        modelBuilder.Entity<VipLevel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_vip_levels");

            entity.ToTable("vip_levels", "dbo");

            entity.HasIndex(e => e.BrandId, "ix_vip_levels_brand_id");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.BirthReward)
                .HasPrecision(18, 6)
                .HasColumnName("birth_reward");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.CardGameRebatePercentage)
                .HasPrecision(18, 6)
                .HasColumnName("card_game_rebate_percentage");
            entity.Property(e => e.CreatedByUsername)
                .HasMaxLength(32)
                .HasColumnName("created_by_username");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
            entity.Property(e => e.Level).HasColumnName("level");
            entity.Property(e => e.LevelKeepAccumulateBetAmount)
                .HasPrecision(18, 6)
                .HasColumnName("level_keep_accumulate_bet_amount");
            entity.Property(e => e.LevelKeepAccumulateDeposit)
                .HasPrecision(18, 6)
                .HasColumnName("level_keep_accumulate_deposit");
            entity.Property(e => e.LevelKeepCondition).HasColumnName("level_keep_condition");
            entity.Property(e => e.LevelUpAccumulateBetAmount)
                .HasPrecision(18, 6)
                .HasColumnName("level_up_accumulate_bet_amount");
            entity.Property(e => e.LevelUpAccumulateDeposit)
                .HasPrecision(18, 6)
                .HasColumnName("level_up_accumulate_deposit");
            entity.Property(e => e.LiveDealerRebatePercentage)
                .HasPrecision(18, 6)
                .HasColumnName("live_dealer_rebate_percentage");
            entity.Property(e => e.LotteryRebatePercentage)
                .HasPrecision(18, 6)
                .HasColumnName("lottery_rebate_percentage");
            entity.Property(e => e.PromotionReward)
                .HasPrecision(18, 6)
                .HasColumnName("promotion_reward");
            entity.Property(e => e.QuarterlyReward)
                .HasPrecision(18, 6)
                .HasColumnName("quarterly_reward");
            entity.Property(e => e.SlotRebatePercentage)
                .HasPrecision(18, 6)
                .HasColumnName("slot_rebate_percentage");
            entity.Property(e => e.SportsRebatePercentage)
                .HasPrecision(18, 6)
                .HasColumnName("sports_rebate_percentage");
            entity.Property(e => e.UpdatedByUsername)
                .HasMaxLength(32)
                .HasColumnName("updated_by_username");
            entity.Property(e => e.UpdatedOn).HasColumnName("updated_on");
            entity.Property(e => e.VirtualSportsRebatePercentage)
                .HasPrecision(18, 6)
                .HasColumnName("virtual_sports_rebate_percentage");
            entity.Property(e => e.WithdrawTotalAmountPerDay)
                .HasPrecision(18, 6)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("withdraw_total_amount_per_day");
            entity.Property(e => e.WithdrawTransactionsPerDay)
                .HasDefaultValueSql("'-1'::integer")
                .HasColumnName("withdraw_transactions_per_day");

            entity.HasOne(d => d.Brand).WithMany(p => p.VipLevels)
                .HasForeignKey(d => d.BrandId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_vip_levels_brands_brand_id");
        });

        modelBuilder.Entity<VipLevelSnapshot>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_vip_level_snapshots");

            entity.ToTable("vip_level_snapshots", "dbo");

            entity.HasIndex(e => e.BrandId, "ix_vip_level_snapshots_brand_id");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasComment("識別碼")
                .HasColumnName("id");
            entity.Property(e => e.BrandId)
                .HasComment("平台識別碼")
                .HasColumnName("brand_id");
            entity.Property(e => e.Data)
                .HasComment("資料")
                .HasColumnType("jsonb")
                .HasColumnName("data");
            entity.Property(e => e.EffectiveOn)
                .HasComment("生效時間")
                .HasColumnName("effective_on");
            entity.Property(e => e.SnapshotOn)
                .HasComment("快照時間")
                .HasColumnName("snapshot_on");
            entity.Property(e => e.SnapshotUserId)
                .HasComment("快照使用者識別碼")
                .HasColumnName("snapshot_user_id");
            entity.Property(e => e.SnapshotUsername)
                .HasMaxLength(50)
                .HasComment("快照使用者名稱")
                .HasColumnName("snapshot_username");
        });

        modelBuilder.Entity<Wallet>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_wallets");

            entity.ToTable("wallets", "dbo");

            entity.HasIndex(e => e.CurrencyCode, "ix_wallets_currency_code");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Balance)
                .HasPrecision(18, 6)
                .HasColumnName("balance");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.CashType)
                .HasDefaultValueSql("'Player'::text")
                .HasColumnName("cash_type");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(16)
                .HasColumnName("currency_code");
            entity.Property(e => e.ExternalCurrencyCode)
                .HasMaxLength(16)
                .HasColumnName("external_currency_code");
            entity.Property(e => e.LockedBalance)
                .HasPrecision(18, 6)
                .HasColumnName("locked_balance");
            entity.Property(e => e.PlayerCode).HasColumnName("player_code");
            entity.Property(e => e.SnapshotId).HasColumnName("snapshot_id");
            entity.Property(e => e.UpdatedOn).HasColumnName("updated_on");

            entity.HasOne(d => d.CurrencyCodeNavigation).WithMany(p => p.Wallets)
                .HasForeignKey(d => d.CurrencyCode)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_wallets_currencies_currency_code");
        });

        modelBuilder.Entity<Whitelist>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_whitelists");

            entity.ToTable("whitelists", "dbo");

            entity.HasIndex(e => e.BrandId, "ix_whitelists_brand_id");

            entity.HasIndex(e => e.LicenseeId, "ix_whitelists_licensee_id");

            entity.HasIndex(e => e.ResellerId, "ix_whitelists_reseller_id");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.CreatedByUsername)
                .HasMaxLength(32)
                .HasColumnName("created_by_username");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
            entity.Property(e => e.Description)
                .HasMaxLength(256)
                .HasColumnName("description");
            entity.Property(e => e.InternalNote)
                .HasMaxLength(256)
                .HasColumnName("internal_note");
            entity.Property(e => e.IpAddress)
                .HasMaxLength(64)
                .HasColumnName("ip_address");
            entity.Property(e => e.LicenseeId).HasColumnName("licensee_id");
            entity.Property(e => e.ResellerId).HasColumnName("reseller_id");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.UpdatedByUsername)
                .HasMaxLength(32)
                .HasColumnName("updated_by_username");
            entity.Property(e => e.UpdatedOn).HasColumnName("updated_on");

            entity.HasOne(d => d.Brand).WithMany(p => p.Whitelists)
                .HasForeignKey(d => d.BrandId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_whitelists_brands_brand_id");

            entity.HasOne(d => d.Licensee).WithMany(p => p.Whitelists)
                .HasForeignKey(d => d.LicenseeId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_whitelists_licensees_licensee_id");

            entity.HasOne(d => d.Reseller).WithMany(p => p.Whitelists)
                .HasForeignKey(d => d.ResellerId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_whitelists_resellers_reseller_id");
        });

        modelBuilder.Entity<WithdrawForm>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_withdraw_forms");

            entity.ToTable("withdraw_forms", "dbo");

            entity.HasIndex(e => e.BrandId, "ix_withdraw_forms_brand_id");

            entity.HasIndex(e => new { e.BrandId, e.CreatedOn, e.Status }, "ix_withdraw_forms_created_on");

            entity.HasIndex(e => new { e.BrandId, e.ThirdPartyOrderNo, e.Status }, "ix_withdraw_forms_third_party_order_no");

            entity.HasIndex(e => new { e.BrandId, e.UpdatedOn, e.Status }, "ix_withdraw_forms_updated_on");

            entity.HasIndex(e => e.BrandPaymentId, "ix_withdraw_froms_brand_payment_id");

            entity.HasIndex(e => new { e.BrandId, e.OrderNo }, "ux_withdraw_forms_order_no").IsUnique();

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.ActualAmount)
                .HasPrecision(18, 6)
                .HasColumnName("actual_amount");
            entity.Property(e => e.Amount)
                .HasPrecision(18, 6)
                .HasColumnName("amount");
            entity.Property(e => e.ApplyInfo)
                .HasColumnType("jsonb")
                .HasColumnName("apply_info");
            entity.Property(e => e.BankInfo)
                .HasColumnType("jsonb")
                .HasColumnName("bank_info");
            entity.Property(e => e.BankInfoId).HasColumnName("bank_info_id");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.BrandPaymentId).HasColumnName("brand_payment_id");
            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_on");
            entity.Property(e => e.HandlingFee)
                .HasPrecision(18, 6)
                .HasColumnName("handling_fee");
            entity.Property(e => e.Note).HasColumnName("note");
            entity.Property(e => e.OrderNo)
                .HasMaxLength(50)
                .HasColumnName("order_no");
            entity.Property(e => e.PaidOn).HasColumnName("paid_on");
            entity.Property(e => e.PaidUserId).HasColumnName("paid_user_id");
            entity.Property(e => e.PaidUserName).HasColumnName("paid_user_name");
            entity.Property(e => e.PaymentReturn)
                .HasColumnType("jsonb")
                .HasColumnName("payment_return");
            entity.Property(e => e.PlayerRemark).HasColumnName("player_remark");
            entity.Property(e => e.Remark).HasColumnName("remark");
            entity.Property(e => e.ReviewedOn).HasColumnName("reviewed_on");
            entity.Property(e => e.ReviewedUserId).HasColumnName("reviewed_user_id");
            entity.Property(e => e.ReviewedUserName).HasColumnName("reviewed_user_name");
            entity.Property(e => e.SnapshotEventId).HasColumnName("snapshot_event_id");
            entity.Property(e => e.Status)
                .HasDefaultValue(0)
                .HasColumnName("status");
            entity.Property(e => e.ThirdPartyOrderNo).HasColumnName("third_party_order_no");
            entity.Property(e => e.UpdatedOn)
                .HasDefaultValueSql("now()")
                .HasColumnName("updated_on");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.UserName).HasColumnName("user_name");
            entity.Property(e => e.UserType)
                .HasDefaultValue(0)
                .HasColumnName("user_type");

            entity.HasOne(d => d.Brand).WithMany(p => p.WithdrawForms)
                .HasForeignKey(d => d.BrandId)
                .HasConstraintName("fk_withdraw_forms_brands_brand_id");

            entity.HasOne(d => d.BrandPayment).WithMany(p => p.WithdrawForms)
                .HasForeignKey(d => d.BrandPaymentId)
                .HasConstraintName("fk_withdraw_forms_brand_payments_brand_payment_id");
        });

        modelBuilder.Entity<WithdrawFormEventSource>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_withdraw_form_event_source");

            entity.ToTable("withdraw_form_event_source", "dbo");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Action).HasColumnName("action");
            entity.Property(e => e.ChangeSets)
                .HasColumnType("jsonb")
                .HasColumnName("change_sets");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
            entity.Property(e => e.FormId).HasColumnName("form_id");
            entity.Property(e => e.ModifyUser).HasColumnName("modify_user");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
