using System;
using System.Collections.Generic;

namespace signalr.Db.Models;

public partial class AccessLogging
{
    public long Id { get; set; }

    public DateTime? Date { get; set; }

    public string? Thread { get; set; }

    public string? LogLevel { get; set; }

    public string? Logger { get; set; }

    public string? SourceIp { get; set; }

    public string? Referer { get; set; }

    public string? RequestHeader { get; set; }

    public string? Action { get; set; }

    public string? UserAgent { get; set; }

    public string? Message { get; set; }

    public string? Exception { get; set; }

    public DateTime? DateStored { get; set; }

    public string? ClientId { get; set; }

    public string? UserName { get; set; }
}
