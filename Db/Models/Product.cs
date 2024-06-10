using System;
using System.Collections.Generic;

namespace signalr.Db.Models;

public partial class Product
{
    public int Id { get; set; }

    public string LicenseCode { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int Type { get; set; }

    public string? IconFilePath { get; set; }

    public string? IconFileName { get; set; }

    public string? IconLocationUrl { get; set; }

    public string? IconBackground { get; set; }

    public bool GroupingOn { get; set; }

    public DateTime Created { get; set; }

    public string? DefaultUrl { get; set; }

    public bool IsPartner { get; set; }

    public string? LogoFileName { get; set; }

    public string? LogoLocationUrl { get; set; }

    public string? LogoFilePath { get; set; }

    public virtual ICollection<ClientProduct> ClientProducts { get; set; } = new List<ClientProduct>();

    public virtual ICollection<Environment> Environments { get; set; } = new List<Environment>();
}
