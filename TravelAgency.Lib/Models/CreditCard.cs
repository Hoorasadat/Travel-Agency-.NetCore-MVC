

// Developer: Ansh


namespace TravelAgency.Lib.Models;

public partial class CreditCard
{
    public int CreditCardId { get; set; }

    public string Ccname { get; set; } = null!;

    public string Ccnumber { get; set; } = null!;

    public DateTime Ccexpiry { get; set; }

    public int CustomerId { get; set; }

    public virtual Customer Customer { get; set; } = null!;
}
