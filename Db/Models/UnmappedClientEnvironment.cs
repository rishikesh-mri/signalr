using System;
using System.Collections.Generic;

namespace signalr.Db.Models;

public partial class UnmappedClientEnvironment
{
    public int Id { get; set; }

    public string? ClientId { get; set; }

    public string? ApplicationGatewayMapCode { get; set; }

    public string? Application { get; set; }

    public string? DataCenter { get; set; }

    public string? GlobalRegion { get; set; }

    public string? Version { get; set; }

    public string? EnvironmentType { get; set; }

    public string? AssociatedDataCenter { get; set; }

    public bool OnPremise { get; set; }
}
