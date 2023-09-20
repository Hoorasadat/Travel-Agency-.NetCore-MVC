

// Developer: Jashish


namespace TravelAgency.Lib.Models;

public partial class ProductsSupplier
{
    public int ProductSupplierId { get; set; }

    public int? ProductId { get; set; }

    public int? SupplierId { get; set; }

    public virtual ICollection<BookingDetail> BookingDetails { get; set; } = new List<BookingDetail>();

    public virtual ICollection<PackagesProductsSupplier> PackagesProductsSuppliers { get; set; } = new List<PackagesProductsSupplier>();

    public virtual Product? Product { get; set; }

    public virtual Supplier? Supplier { get; set; }
}
