using System;
using System.Collections.Generic;

namespace TravelAgency.Lib.Models;

public partial class CustomersReward
{
    public int CustomerId { get; set; }

    public int RewardId { get; set; }

    public string RwdNumber { get; set; } = null!;

    public virtual Customer Customer { get; set; } = null!;

    public virtual Reward Reward { get; set; } = null!;
}
