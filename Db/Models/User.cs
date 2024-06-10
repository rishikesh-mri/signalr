using System;
using System.Collections.Generic;

namespace signalr.Db.Models;

public partial class User
{
    public string UserId { get; set; } = null!;

    public string FamilyName { get; set; } = null!;

    public string GivenName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public bool Active { get; set; }

    public DateTime LastModifiedDateTime { get; set; }

    public bool GlobalAgadmin { get; set; }

    public virtual ICollection<ClientUser> ClientUsers { get; set; } = new List<ClientUser>();

    public virtual ICollection<UserClientEnvironment> UserClientEnvironments { get; set; } = new List<UserClientEnvironment>();

    public virtual ICollection<UserDefinedApplication> UserDefinedApplications { get; set; } = new List<UserDefinedApplication>();

    public virtual ICollection<UserFeatureFlag> UserFeatureFlags { get; set; } = new List<UserFeatureFlag>();
}
