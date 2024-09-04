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

    public virtual DbSet<GameFundTransferTrace> GameFundTransferTraces { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .HasPostgresExtension("ltree")
            .HasPostgresExtension("pg_trgm");

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

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
