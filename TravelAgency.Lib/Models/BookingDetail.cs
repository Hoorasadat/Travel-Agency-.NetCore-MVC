

// Developer: Hoora


namespace TravelAgency.Lib.Models;

public partial class BookingDetail
{
    public int BookingDetailId { get; set; }

    public double? ItineraryNo { get; set; }

    public DateTime? TripStart { get; set; }

    public DateTime? TripEnd { get; set; }

    public string? Description { get; set; }

    public string? Destination { get; set; }

    public decimal? BasePrice { get; set; }

    public decimal? AgencyCommission { get; set; }

    public int? BookingId { get; set; }

    public string? RegionId { get; set; }

    public string? ClassId { get; set; }

    public string? FeeId { get; set; }

    public int? ProductSupplierId { get; set; }

    public virtual Booking? Booking { get; set; }

    public virtual Class? Class { get; set; }

    public virtual Fee? Fee { get; set; }

    public virtual ProductsSupplier? ProductSupplier { get; set; }

    public virtual Region? Region { get; set; }
}
