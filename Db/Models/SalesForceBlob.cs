using System;
using System.Collections.Generic;

namespace signalr.Db.Models;

public partial class SalesForceBlob
{
    public int Id { get; set; }

    public string Data { get; set; } = null!;

    public DateTime? TimeStampUtc { get; set; }
}
