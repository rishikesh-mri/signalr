using System;
using System.Collections.Generic;

namespace signalr.Db.Models;

public partial class UserFeatureFlag
{
    public int Id { get; set; }

    public string UserId { get; set; } = null!;

    public string ClientId { get; set; } = null!;

    public bool Enabled { get; set; }

    public string FeatureFlagId { get; set; } = null!;

    public virtual ClientTable Client { get; set; } = null!;

    public virtual FeatureFlag FeatureFlag { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
