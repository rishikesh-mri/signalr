using System;
using System.Collections.Generic;

namespace signalr.Db.Models;

public partial class Environment
{
    public int EnvironmentId { get; set; }

    public string? EnvironmentName { get; set; }

    public string EnvironmentType { get; set; } = null!;

    public string EnvironmentPath { get; set; } = null!;

    public DateTime Created { get; set; }

    public bool Removed { get; set; }

    public string? IconBackground { get; set; }

    public string? IconFileName { get; set; }

    public string? IconFilePath { get; set; }

    public string? IconLocationUrl { get; set; }

    public string? EnvironmentOauthId { get; set; }

    public string? EnvironmentDescription { get; set; }

    public int EnvironmentOwnerType { get; set; }

    public string? IconInitials { get; set; }

    public int? ProductId { get; set; }

    public string? ProductLicenseCode { get; set; }

    public string? Version { get; set; }

    public bool Shared { get; set; }

    public string? CitrixAppName { get; set; }

    public string? LogoFileName { get; set; }

    public string? LogoLocationUrl { get; set; }

    public string? LogoFilePath { get; set; }

    public virtual ICollection<CategoryEnvironmentClientUser> CategoryEnvironmentClientUsers { get; set; } = new List<CategoryEnvironmentClientUser>();

    public virtual ICollection<ClientEnvironment> ClientEnvironments { get; set; } = new List<ClientEnvironment>();

    public virtual Product? Product { get; set; }

    public virtual ICollection<ServiceEndpoint> ServiceEndpoints { get; set; } = new List<ServiceEndpoint>();

    public virtual ICollection<UserDefinedApplication> UserDefinedApplications { get; set; } = new List<UserDefinedApplication>();
}
