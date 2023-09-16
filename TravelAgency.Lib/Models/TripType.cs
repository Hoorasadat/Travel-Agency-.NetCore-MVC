using System;
using System.Collections.Generic;

namespace TravelAgency.Lib.Models;

public partial class TripType
{
    public string TripTypeId { get; set; } = null!;

    public string? Ttname { get; set; }

    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();
}
