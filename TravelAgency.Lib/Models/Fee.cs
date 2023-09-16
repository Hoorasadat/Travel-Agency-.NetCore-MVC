using System;
using System.Collections.Generic;

namespace TravelAgency.Lib.Models;

public partial class Fee
{
    public string FeeId { get; set; } = null!;

    public string FeeName { get; set; } = null!;

    public decimal FeeAmt { get; set; }

    public string? FeeDesc { get; set; }

    public virtual ICollection<BookingDetail> BookingDetails { get; set; } = new List<BookingDetail>();
}
