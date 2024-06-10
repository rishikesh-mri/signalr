using System;
using System.Collections.Generic;

namespace signalr.Db.Models;

public partial class AuthenticationLog
{
    public int Id { get; set; }

    public string? MriclientId { get; set; }

    public string? OauthId { get; set; }

    public string? Endpoint { get; set; }

    public string? Scope { get; set; }

    public string? Domain { get; set; }

    public string? LoggingOrigin { get; set; }

    public string? BasicAuthUser { get; set; }

    public bool AllowNoClientId { get; set; }

    public bool EmailFederation { get; set; }

    public string? FederationMriClientId { get; set; }

    public string? LoginHint { get; set; }

    public bool PromptForMriClientId { get; set; }

    public string? RequestedId { get; set; }

    public string? RequestedLogo { get; set; }

    public bool TryGetFederationClientIdFromCookie { get; set; }

    public string? FederatedIdPid { get; set; }
}
