using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using signalr.Db.Models;

namespace signalr.Db;

public partial class WfeRedmzFfSettingsContext : DbContext
{
    public WfeRedmzFfSettingsContext()
    {
    }

    public WfeRedmzFfSettingsContext(DbContextOptions<WfeRedmzFfSettingsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AccessLogging> AccessLoggings { get; set; }

    public virtual DbSet<ApiLog> ApiLogs { get; set; }

    public virtual DbSet<Application> Applications { get; set; }

    public virtual DbSet<ApplicationPassword> ApplicationPasswords { get; set; }

    public virtual DbSet<AspnetKey> AspnetKeys { get; set; }

    public virtual DbSet<AuthenticationLog> AuthenticationLogs { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<CategoryClientUser> CategoryClientUsers { get; set; }

    public virtual DbSet<CategoryEnvironmentClientUser> CategoryEnvironmentClientUsers { get; set; }

    public virtual DbSet<ClientDomain> ClientDomains { get; set; }

    public virtual DbSet<ClientEnvironment> ClientEnvironments { get; set; }

    public virtual DbSet<ClientFeatureFlag> ClientFeatureFlags { get; set; }

    public virtual DbSet<ClientProduct> ClientProducts { get; set; }

    public virtual DbSet<ClientTable> ClientTables { get; set; }

    public virtual DbSet<ClientUser> ClientUsers { get; set; }

    public virtual DbSet<Configuration> Configurations { get; set; }


    public virtual DbSet<Models.Environment> Environments { get; set; }

    public virtual DbSet<FeatureFlag> FeatureFlags { get; set; }

    public virtual DbSet<FederatedIdentityProvider> FederatedIdentityProviders { get; set; }

    public virtual DbSet<IdentityPolicy> IdentityPolicies { get; set; }

    public virtual DbSet<LoggedInUserCache> LoggedInUserCaches { get; set; }

    public virtual DbSet<MigrationHistory> MigrationHistories { get; set; }

    public virtual DbSet<NotAllowedEmailDomain> NotAllowedEmailDomains { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<SalesForceBlob> SalesForceBlobs { get; set; }

    public virtual DbSet<ServiceEndpoint> ServiceEndpoints { get; set; }

    public virtual DbSet<ServiceType> ServiceTypes { get; set; }

    public virtual DbSet<UnmappedClientEnvironment> UnmappedClientEnvironments { get; set; }

    public virtual DbSet<UnmappedClientUser> UnmappedClientUsers { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserClientEnvironment> UserClientEnvironments { get; set; }

    public virtual DbSet<UserDefinedApplication> UserDefinedApplications { get; set; }

    public virtual DbSet<UserFeatureFlag> UserFeatureFlags { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=WFE_REDMZ_FF_Settings;Integrated Security=True;MultipleActiveResultSets=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AccessLogging>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AccessLo__3214EC07A92A9269");

            entity.ToTable("AccessLogging");

            entity.Property(e => e.Action).IsUnicode(false);
            entity.Property(e => e.ClientId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ClientID");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.DateStored)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Exception).IsUnicode(false);
            entity.Property(e => e.LogLevel)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Logger)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Message).IsUnicode(false);
            entity.Property(e => e.Referer).IsUnicode(false);
            entity.Property(e => e.RequestHeader).IsUnicode(false);
            entity.Property(e => e.SourceIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SourceIP");
            entity.Property(e => e.Thread)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.UserAgent).IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ApiLog>(entity =>
        {
            entity.Property(e => e.Exception).IsUnicode(false);
            entity.Property(e => e.Level)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.Message).IsUnicode(false);
            entity.Property(e => e.MessageTemplate).IsUnicode(false);
            entity.Property(e => e.Properties).IsUnicode(false);
            entity.Property(e => e.TimeStamp).HasColumnType("datetime");
        });

        modelBuilder.Entity<Application>(entity =>
        {
            entity.HasKey(e => e.ApplicationId).HasName("PK_dbo.Applications");

            entity.HasIndex(e => e.ApplicationName, "IX_ApplicationName").IsUnique();

            entity.Property(e => e.ApplicationName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(1024)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ApplicationPassword>(entity =>
        {
            entity.HasKey(e => e.PasswordId).HasName("PK_dbo.ApplicationPasswords");

            entity.HasIndex(e => new { e.ActivateDate, e.DeactivateDate, e.IsSuspended }, "IX_ActivePassword");

            entity.HasIndex(e => e.ApplicationId, "IX_ApplicationPasswords_ApplicationID");

            entity.Property(e => e.ActivateDate).HasColumnType("datetime");
            entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");
            entity.Property(e => e.DeactivateDate).HasColumnType("datetime");
            entity.Property(e => e.Password)
                .HasMaxLength(1024)
                .IsUnicode(false);
            entity.Property(e => e.SuspendReason)
                .HasMaxLength(1024)
                .IsUnicode(false);
            entity.Property(e => e.SuspendedBy)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.Application).WithMany(p => p.ApplicationPasswords).HasForeignKey(d => d.ApplicationId);
        });

        modelBuilder.Entity<AspnetKey>(entity =>
        {
            entity.HasKey(e => e.FriendlyName).HasName("PK_dbo.AspnetKeys");

            entity.HasIndex(e => e.FriendlyName, "IX_FriendlyName");

            entity.Property(e => e.FriendlyName).HasMaxLength(200);
            entity.Property(e => e.XmlData).HasMaxLength(4000);
        });

        modelBuilder.Entity<AuthenticationLog>(entity =>
        {
            entity.ToTable("AuthenticationLog");

            entity.Property(e => e.Domain)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Endpoint)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FederatedIdPid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FederatedIdPId");
            entity.Property(e => e.FederationMriClientId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LoggingOrigin)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LoginHint)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MriclientId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MRIClientId");
            entity.Property(e => e.OauthId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OAuthId");
            entity.Property(e => e.RequestedId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RequestedLogo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Scope)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.ToTable("Category");

            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<CategoryClientUser>(entity =>
        {
            entity.HasKey(e => new { e.CategoryId, e.ClientUserId });

            entity.ToTable("CategoryClientUser");

            entity.HasIndex(e => e.ClientUserId, "IX_CategoryClientUser_ClientUserId");

            entity.HasOne(d => d.Category).WithMany(p => p.CategoryClientUsers).HasForeignKey(d => d.CategoryId);

            entity.HasOne(d => d.ClientUser).WithMany(p => p.CategoryClientUsers).HasForeignKey(d => d.ClientUserId);
        });

        modelBuilder.Entity<CategoryEnvironmentClientUser>(entity =>
        {
            entity.ToTable("CategoryEnvironmentClientUser");

            entity.HasIndex(e => new { e.EnvironmentId, e.ClientUserId }, "AK_CategoryEnvironmentClientUser_EnvironmentId_ClientUserId").IsUnique();

            entity.HasIndex(e => e.CategoryId, "IX_CategoryEnvironmentClientUser_CategoryId");

            entity.HasIndex(e => e.ClientUserId, "IX_CategoryEnvironmentClientUser_ClientUserId");

            entity.HasOne(d => d.Category).WithMany(p => p.CategoryEnvironmentClientUsers).HasForeignKey(d => d.CategoryId);

            entity.HasOne(d => d.ClientUser).WithMany(p => p.CategoryEnvironmentClientUsers).HasForeignKey(d => d.ClientUserId);

            entity.HasOne(d => d.Environment).WithMany(p => p.CategoryEnvironmentClientUsers).HasForeignKey(d => d.EnvironmentId);
        });

        modelBuilder.Entity<ClientDomain>(entity =>
        {
            entity.ToTable("ClientDomain");

            entity.HasIndex(e => e.ClientId, "IX_ClientDomain_ClientId");

            entity.Property(e => e.ClientId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Domain)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Client).WithMany(p => p.ClientDomains).HasForeignKey(d => d.ClientId);

            entity.HasMany(d => d.FederatedIdentityProviders).WithMany(p => p.ClientDomains)
                .UsingEntity<Dictionary<string, object>>(
                    "ClientDomainFederatedIdentityProvider",
                    r => r.HasOne<FederatedIdentityProvider>().WithMany().HasForeignKey("FederatedIdentityProviderId"),
                    l => l.HasOne<ClientDomain>().WithMany()
                        .HasForeignKey("ClientDomainId")
                        .OnDelete(DeleteBehavior.ClientSetNull),
                    j =>
                    {
                        j.HasKey("ClientDomainId", "FederatedIdentityProviderId");
                        j.ToTable("ClientDomainFederatedIdentityProvider");
                        j.HasIndex(new[] { "FederatedIdentityProviderId" }, "IX_ClientDomainFederatedIdentityProvider_FederatedIdentityProviderId");
                    });
        });

        modelBuilder.Entity<ClientEnvironment>(entity =>
        {
            entity.HasKey(e => e.ClientEnvironmentId).HasName("PK__ClientEn__6FC940E0B8F05F12");

            entity.ToTable("ClientEnvironment");

            entity.Property(e => e.ClientId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ForceIdentityProviderId).HasMaxLength(255);

            entity.HasOne(d => d.Client).WithMany(p => p.ClientEnvironments).HasForeignKey(d => d.ClientId);

            entity.HasOne(d => d.Environment).WithMany(p => p.ClientEnvironments).HasForeignKey(d => d.EnvironmentId);
        });

        modelBuilder.Entity<ClientFeatureFlag>(entity =>
        {
            entity.ToTable("ClientFeatureFlag");

            entity.HasIndex(e => new { e.ClientId, e.FeatureFlagId }, "AK_ClientFeatureFlag_ClientId_FeatureFlagId").IsUnique();

            entity.HasIndex(e => e.FeatureFlagId, "IX_ClientFeatureFlag_FeatureFlagId");

            entity.Property(e => e.ClientId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FeatureFlagId)
                .IsUnicode(false)
                .HasDefaultValue("");

            entity.HasOne(d => d.Client).WithMany(p => p.ClientFeatureFlags).HasForeignKey(d => d.ClientId);

            entity.HasOne(d => d.FeatureFlag).WithMany(p => p.ClientFeatureFlags).HasForeignKey(d => d.FeatureFlagId);
        });

        modelBuilder.Entity<ClientProduct>(entity =>
        {
            entity.ToTable("ClientProduct");

            entity.HasIndex(e => e.ClientId, "IX_ClientProduct_ClientId");

            entity.HasIndex(e => e.ProductId, "IX_ClientProduct_ProductId");

            entity.Property(e => e.ClientId)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Client).WithMany(p => p.ClientProducts).HasForeignKey(d => d.ClientId);

            entity.HasOne(d => d.Product).WithMany(p => p.ClientProducts).HasForeignKey(d => d.ProductId);
        });

        modelBuilder.Entity<ClientTable>(entity =>
        {
            entity.HasKey(e => e.ClientId).HasName("PK__ClientTa__E67E1A2430651A8A");

            entity.ToTable("ClientTable");

            entity.HasIndex(e => e.OktaMfaPolicyId, "IX_ClientTable_OktaMfaPolicyId");

            entity.HasIndex(e => e.OktaPasswordPolicyId, "IX_ClientTable_OktaPasswordPolicyId");

            entity.HasIndex(e => e.OktaSignOnPolicyId, "IX_ClientTable_OktaSignOnPolicyId");

            entity.Property(e => e.ClientId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.ClientName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ClientShortName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.LogoFileName).HasMaxLength(255);
            entity.Property(e => e.LogoFilePath).HasMaxLength(500);
            entity.Property(e => e.LogoLocationUrl)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.OktaMfaPolicyId).IsUnicode(false);
            entity.Property(e => e.OktaPasswordPolicyId).IsUnicode(false);
            entity.Property(e => e.OktaSignOnPolicyId).IsUnicode(false);
            entity.Property(e => e.Sso).HasColumnName("SSO");

            entity.HasOne(d => d.OktaMfaPolicy).WithMany(p => p.ClientTableOktaMfaPolicies).HasForeignKey(d => d.OktaMfaPolicyId);

            entity.HasOne(d => d.OktaPasswordPolicy).WithMany(p => p.ClientTableOktaPasswordPolicies).HasForeignKey(d => d.OktaPasswordPolicyId);

            entity.HasOne(d => d.OktaSignOnPolicy).WithMany(p => p.ClientTableOktaSignOnPolicies).HasForeignKey(d => d.OktaSignOnPolicyId);
        });

        modelBuilder.Entity<ClientUser>(entity =>
        {
            entity.ToTable("ClientUser");

            entity.HasIndex(e => new { e.UserId, e.ClientId }, "AK_UserId_ClientId").IsUnique();

            entity.HasIndex(e => e.ClientId, "IX_ClientUser_ClientId");

            entity.HasIndex(e => e.UserId, "IX_ClientUser_UserId");

            entity.Property(e => e.ClientId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Dsc).HasColumnName("DSC");
            entity.Property(e => e.Dscplus).HasColumnName("DSCPlus");
            entity.Property(e => e.UserId)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.HasOne(d => d.Client).WithMany(p => p.ClientUsers)
                .HasForeignKey(d => d.ClientId)
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(d => d.User).WithMany(p => p.ClientUsers)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<Configuration>(entity =>
        {
            entity.HasKey(e => e.Key).HasName("PK_dbo.Configuration");

            entity.ToTable("Configuration");

            entity.Property(e => e.Key).HasMaxLength(100);
        });

        modelBuilder.Entity<Models.Environment>(entity =>
        {
            entity.HasKey(e => e.EnvironmentId).HasName("PK__Environm__4B909A4910B8E909");

            entity.ToTable("Environment");

            entity.HasIndex(e => e.ProductId, "IX_Environment_ProductId");

            entity.Property(e => e.CitrixAppName).IsUnicode(false);
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EnvironmentDescription).HasMaxLength(100);
            entity.Property(e => e.EnvironmentName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EnvironmentOauthId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EnvironmentOAuthId");
            entity.Property(e => e.EnvironmentPath)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.EnvironmentType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IconBackground)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.IconFileName).HasMaxLength(255);
            entity.Property(e => e.IconFilePath).HasMaxLength(500);
            entity.Property(e => e.IconInitials).HasMaxLength(3);
            entity.Property(e => e.IconLocationUrl)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.LogoFileName).HasMaxLength(255);
            entity.Property(e => e.LogoFilePath).HasMaxLength(500);
            entity.Property(e => e.LogoLocationUrl)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.ProductLicenseCode).IsUnicode(false);
            entity.Property(e => e.Version)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Product).WithMany(p => p.Environments)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.SetNull);
        });

        modelBuilder.Entity<FeatureFlag>(entity =>
        {
            entity.ToTable("FeatureFlag");

            entity.Property(e => e.Id).IsUnicode(false);
        });

        modelBuilder.Entity<FederatedIdentityProvider>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.FederatedIdentityProvider");

            entity.ToTable("FederatedIdentityProvider");

            entity.HasIndex(e => e.ClientId, "IX_FederatedIdentityProvider_ClientId");

            entity.Property(e => e.ClientId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NavigationHint)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ProviderId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Usage)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.Client).WithMany(p => p.FederatedIdentityProviders).HasForeignKey(d => d.ClientId);
        });

        modelBuilder.Entity<IdentityPolicy>(entity =>
        {
            entity.HasKey(e => e.PolicyId);

            entity.ToTable("IdentityPolicy");

            entity.Property(e => e.PolicyId).IsUnicode(false);
            entity.Property(e => e.Description).IsUnicode(false);
            entity.Property(e => e.PolicyName).IsUnicode(false);
            entity.Property(e => e.PolicyType).IsUnicode(false);
        });

        modelBuilder.Entity<LoggedInUserCache>(entity =>
        {
            entity.HasKey(e => e.UserId);

            entity.ToTable("LoggedInUserCache");

            entity.Property(e => e.UserId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ClientId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FederatedIdentityProvider)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<MigrationHistory>(entity =>
        {
            entity.HasKey(e => new { e.MigrationId, e.ContextKey }).HasName("PK_dbo.__MigrationHistory");

            entity.ToTable("__MigrationHistory");

            entity.Property(e => e.MigrationId).HasMaxLength(150);
            entity.Property(e => e.ContextKey).HasMaxLength(300);
            entity.Property(e => e.ProductVersion).HasMaxLength(32);
        });

        modelBuilder.Entity<NotAllowedEmailDomain>(entity =>
        {
            entity.Property(e => e.Domain).IsUnicode(false);
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.ToTable("Product");

            entity.HasIndex(e => e.LicenseCode, "IX_Product_LicenseCode").IsUnique();

            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DefaultUrl)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.GroupingOn).HasDefaultValue(true);
            entity.Property(e => e.IconBackground)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.IconFileName).HasMaxLength(255);
            entity.Property(e => e.IconFilePath).HasMaxLength(500);
            entity.Property(e => e.IconLocationUrl)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.LicenseCode)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LogoFileName).HasMaxLength(255);
            entity.Property(e => e.LogoFilePath).HasMaxLength(500);
            entity.Property(e => e.LogoLocationUrl)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<SalesForceBlob>(entity =>
        {
            entity.ToTable("SalesForceBlob");

            entity.Property(e => e.Data).IsUnicode(false);
            entity.Property(e => e.TimeStampUtc)
                .HasDefaultValue(new DateTime(1, 1, 1, 2, 0, 0, 0, DateTimeKind.Local))
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<ServiceEndpoint>(entity =>
        {
            entity.HasKey(e => e.ServiceEndpointId).HasName("PK_dbo.ServiceEndpoint");

            entity.ToTable("ServiceEndpoint");

            entity.HasIndex(e => new { e.ServiceTypeId, e.EnvironmentId }, "IX_ServiceEndpoint_ServiceType").IsUnique();

            entity.Property(e => e.ServiceEndpointId).HasColumnName("ServiceEndpointID");
            entity.Property(e => e.EnvironmentId).HasColumnName("EnvironmentID");
            entity.Property(e => e.ServiceTypeId).HasColumnName("ServiceTypeID");
            entity.Property(e => e.Url)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("URL");

            entity.HasOne(d => d.Environment).WithMany(p => p.ServiceEndpoints).HasForeignKey(d => d.EnvironmentId);

            entity.HasOne(d => d.ServiceType).WithMany(p => p.ServiceEndpoints).HasForeignKey(d => d.ServiceTypeId);
        });

        modelBuilder.Entity<ServiceType>(entity =>
        {
            entity.HasKey(e => e.ServiceTypeId).HasName("PK_dbo.ServiceType");

            entity.ToTable("ServiceType");

            entity.HasIndex(e => e.ServiceTypeName, "IX_ServiceTypeName").IsUnique();

            entity.Property(e => e.ServiceTypeId).HasColumnName("ServiceTypeID");
            entity.Property(e => e.ServiceTypeName)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UnmappedClientEnvironment>(entity =>
        {
            entity.ToTable("UnmappedClientEnvironment");

            entity.Property(e => e.Application).IsUnicode(false);
            entity.Property(e => e.ApplicationGatewayMapCode).IsUnicode(false);
            entity.Property(e => e.AssociatedDataCenter).IsUnicode(false);
            entity.Property(e => e.ClientId).IsUnicode(false);
            entity.Property(e => e.DataCenter).IsUnicode(false);
            entity.Property(e => e.EnvironmentType).IsUnicode(false);
            entity.Property(e => e.GlobalRegion).IsUnicode(false);
            entity.Property(e => e.Version).IsUnicode(false);
        });

        modelBuilder.Entity<UnmappedClientUser>(entity =>
        {
            entity.ToTable("UnmappedClientUser");

            entity.Property(e => e.ClientId).IsUnicode(false);
            entity.Property(e => e.Dsc).HasColumnName("DSC");
            entity.Property(e => e.Dscplus).HasColumnName("DSCPlus");
            entity.Property(e => e.UserEmail).IsUnicode(false);
            entity.Property(e => e.UserName).IsUnicode(false);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("User");

            entity.Property(e => e.UserId)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FamilyName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.GivenName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.GlobalAgadmin).HasColumnName("GlobalAGAdmin");
            entity.Property(e => e.LastModifiedDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<UserClientEnvironment>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.ClientEnvironmentId }).HasName("PK_dbo.UserClientEnvironment");

            entity.ToTable("UserClientEnvironment");

            entity.HasIndex(e => e.ClientEnvironmentId, "IX_UserClientEnvironment_ClientEnvironmentId");

            entity.Property(e => e.UserId)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.HasOne(d => d.ClientEnvironment).WithMany(p => p.UserClientEnvironments).HasForeignKey(d => d.ClientEnvironmentId);

            entity.HasOne(d => d.User).WithMany(p => p.UserClientEnvironments).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<UserDefinedApplication>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.ClientId, e.EnvironmentId });

            entity.ToTable("UserDefinedApplication");

            entity.HasIndex(e => e.ClientId, "IX_UserDefinedApplication_ClientId");

            entity.HasIndex(e => e.EnvironmentId, "IX_UserDefinedApplication_EnvironmentId");

            entity.Property(e => e.UserId)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ClientId)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Client).WithMany(p => p.UserDefinedApplications).HasForeignKey(d => d.ClientId);

            entity.HasOne(d => d.Environment).WithMany(p => p.UserDefinedApplications).HasForeignKey(d => d.EnvironmentId);

            entity.HasOne(d => d.User).WithMany(p => p.UserDefinedApplications).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<UserFeatureFlag>(entity =>
        {
            entity.ToTable("UserFeatureFlag");

            entity.HasIndex(e => new { e.UserId, e.FeatureFlagId, e.ClientId }, "AK_UserFeatureFlag_UserId_FeatureFlagId_ClientId").IsUnique();

            entity.HasIndex(e => e.ClientId, "IX_UserFeatureFlag_ClientId");

            entity.HasIndex(e => e.FeatureFlagId, "IX_UserFeatureFlag_FeatureFlagId");

            entity.HasIndex(e => e.UserId, "IX_UserFeatureFlag_UserId");

            entity.Property(e => e.ClientId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.FeatureFlagId)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.UserId)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.HasOne(d => d.Client).WithMany(p => p.UserFeatureFlags).HasForeignKey(d => d.ClientId);

            entity.HasOne(d => d.FeatureFlag).WithMany(p => p.UserFeatureFlags).HasForeignKey(d => d.FeatureFlagId);

            entity.HasOne(d => d.User).WithMany(p => p.UserFeatureFlags).HasForeignKey(d => d.UserId);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
