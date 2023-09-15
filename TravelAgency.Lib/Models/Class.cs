using System;
using System.Collections.Generic;

namespace TravelAgency.Lib.Models;

public partial class Class
{
    public string ClassId { get; set; } = null!;

    public string ClassName { get; set; } = null!;

    public string? ClassDesc { get; set; }

    public virtual ICollection<BookingDetail> BookingDetails { get; set; } = new List<BookingDetail>();
}
