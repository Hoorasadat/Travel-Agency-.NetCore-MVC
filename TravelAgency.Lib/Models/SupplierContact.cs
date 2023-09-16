using System;
using System.Collections.Generic;

namespace TravelAgency.Lib.Models;

public partial class SupplierContact
{
    public int SupplierContactId { get; set; }

    public string? SupConFirstName { get; set; }

    public string? SupConLastName { get; set; }

    public string? SupConCompany { get; set; }

    public string? SupConAddress { get; set; }

    public string? SupConCity { get; set; }

    public string? SupConProv { get; set; }

    public string? SupConPostal { get; set; }

    public string? SupConCountry { get; set; }

    public string? SupConBusPhone { get; set; }

    public string? SupConFax { get; set; }

    public string? SupConEmail { get; set; }

    public string? SupConUrl { get; set; }

    public string? AffiliationId { get; set; }

    public int? SupplierId { get; set; }

    public virtual Affiliation? Affiliation { get; set; }

    public virtual Supplier? Supplier { get; set; }
}
