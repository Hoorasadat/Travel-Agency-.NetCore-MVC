using System;
using System.Collections.Generic;

namespace TravelAgency.Lib.Models;

public partial class Customer
{
    public int CustomerId { get; set; }

    public string CustFirstName { get; set; } = null!;

    public string CustLastName { get; set; } = null!;

    public string CustAddress { get; set; } = null!;

    public string CustCity { get; set; } = null!;

    public string CustProv { get; set; } = null!;

    public string CustPostal { get; set; } = null!;

    public string? CustCountry { get; set; }

    public string? CustHomePhone { get; set; }

    public string CustBusPhone { get; set; } = null!;

    public string CustEmail { get; set; } = null!;

    public int? AgentId { get; set; }

    public virtual Agent? Agent { get; set; }

    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();

    public virtual ICollection<CreditCard> CreditCards { get; set; } = new List<CreditCard>();

    public virtual ICollection<CustomersReward> CustomersRewards { get; set; } = new List<CustomersReward>();
}
