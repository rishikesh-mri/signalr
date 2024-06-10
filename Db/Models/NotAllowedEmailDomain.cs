using System;
using System.Collections.Generic;

namespace signalr.Db.Models;

public partial class NotAllowedEmailDomain
{
    public string Domain { get; set; } = null!;

    public int Id { get; set; }
}
