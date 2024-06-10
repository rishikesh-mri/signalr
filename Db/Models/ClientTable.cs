using System;
using System.Collections.Generic;

namespace signalr.Db.Models;

public partial class ClientTable
{
    public string ClientId { get; set; } = null!;

    public string ClientName { get; set; } = null!;

    public string? ClientShortName { get; set; }

    public bool IsAdmin { get; set; }

    public bool Active { get; set; }

    public bool Sso { get; set; }

    public string? HomeRealm { get; set; }

    public bool ScimInitialized { get; set; }

    public string? LogoFileName { get; set; }

    public string? LogoLocationUrl { get; set; }

    public string? LogoFilePath { get; set; }

    public string? OktaMfaPolicyId { get; set; }

    public string? OktaPasswordPolicyId { get; set; }

    public string? OktaSignOnPolicyId { get; set; }

    public bool RequireEmailFederation { get; set; }

    public virtual ICollection<ClientDomain> ClientDomains { get; set; } = new List<ClientDomain>();

    public virtual ICollection<ClientEnvironment> ClientEnvironments { get; set; } = new List<ClientEnvironment>();

    public virtual ICollection<ClientFeatureFlag> ClientFeatureFlags { get; set; } = new List<ClientFeatureFlag>();

    public virtual ICollection<ClientProduct> ClientProducts { get; set; } = new List<ClientProduct>();

    public virtual ICollection<ClientUser> ClientUsers { get; set; } = new List<ClientUser>();

    public virtual ICollection<FederatedIdentityProvider> FederatedIdentityProviders { get; set; } = new List<FederatedIdentityProvider>();

    public virtual IdentityPolicy? OktaMfaPolicy { get; set; }

    public virtual IdentityPolicy? OktaPasswordPolicy { get; set; }

    public virtual IdentityPolicy? OktaSignOnPolicy { get; set; }

    public virtual ICollection<UserDefinedApplication> UserDefinedApplications { get; set; } = new List<UserDefinedApplication>();

    public virtual ICollection<UserFeatureFlag> UserFeatureFlags { get; set; } = new List<UserFeatureFlag>();
}
