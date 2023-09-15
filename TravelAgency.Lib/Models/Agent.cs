using System;
using System.Collections.Generic;

namespace TravelAgency.Lib.Models;

public partial class Agent
{
    public int AgentId { get; set; }

    public string? AgtFirstName { get; set; }

    public string? AgtMiddleInitial { get; set; }

    public string? AgtLastName { get; set; }

    public string? AgtBusPhone { get; set; }

    public string? AgtEmail { get; set; }

    public string? AgtPosition { get; set; }

    public int? AgencyId { get; set; }

    public virtual Agency? Agency { get; set; }

    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();
}
