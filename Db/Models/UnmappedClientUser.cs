using System;
using System.Collections.Generic;

namespace signalr.Db.Models;

public partial class UnmappedClientUser
{
    public int Id { get; set; }

    public string? ClientId { get; set; }

    public string? UserEmail { get; set; }

    public string? UserName { get; set; }

    public bool ProductAdmin { get; set; }

    public bool Dsc { get; set; }

    public bool Dscplus { get; set; }
}
