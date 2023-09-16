using System;
using System.Collections.Generic;

namespace TravelAgency.Lib.Models;

public partial class Agency
{
    public int AgencyId { get; set; }

    public string? AgncyAddress { get; set; }

    public string? AgncyCity { get; set; }

    public string? AgncyProv { get; set; }

    public string? AgncyPostal { get; set; }

    public string? AgncyCountry { get; set; }

    public string? AgncyPhone { get; set; }

    public string? AgncyFax { get; set; }

    public virtual ICollection<Agent> Agents { get; set; } = new List<Agent>();
}
