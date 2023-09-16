using System;
using System.Collections.Generic;

namespace TravelAgency.Lib.Models;

public partial class PackagesProductsSupplier
{
    public int PackageProductSupplierId { get; set; }

    public int PackageId { get; set; }

    public int ProductSupplierId { get; set; }

    public virtual Package Package { get; set; } = null!;

    public virtual ProductsSupplier ProductSupplier { get; set; } = null!;
}
