

// Developer: Hoora


using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TravelAgency.Lib.Models;

namespace TravelAgency.Data.Data;

public partial class TravelExpertsContext : IdentityDbContext<IdentityUser>
{
    public TravelExpertsContext()
    {
    }

    public TravelExpertsContext(DbContextOptions<TravelExpertsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Affiliation> Affiliations { get; set; }

    public virtual DbSet<Agency> Agencies { get; set; }

    public virtual DbSet<Agent> Agents { get; set; }

    public virtual DbSet<Booking> Bookings { get; set; }

    public virtual DbSet<BookingDetail> BookingDetails { get; set; }

    public virtual DbSet<Class> Classes { get; set; }

    public virtual DbSet<CreditCard> CreditCards { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<CustomersReward> CustomersRewards { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Fee> Fees { get; set; }

    public virtual DbSet<Package> Packages { get; set; }

    public virtual DbSet<PackagesProductsSupplier> PackagesProductsSuppliers { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductsSupplier> ProductsSuppliers { get; set; }

    public virtual DbSet<Region> Regions { get; set; }

    public virtual DbSet<Reward> Rewards { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    public virtual DbSet<SupplierContact> SupplierContacts { get; set; }

    public virtual DbSet<TripType> TripTypes { get; set; }        

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<IdentityUserRole<string>>().HasKey(r => new { r.UserId, r.RoleId });
        modelBuilder.Entity<IdentityUserLogin<string>>().HasKey(l => new { l.LoginProvider, l.ProviderKey });


        modelBuilder.Entity<Affiliation>(entity =>
        {
            entity.HasKey(e => e.AffilitationId)
                .HasName("aaaaaAffiliations_PK")
                .IsClustered(false);

            entity.Property(e => e.AffilitationId).HasMaxLength(10);
            entity.Property(e => e.AffDesc).HasMaxLength(50);
            entity.Property(e => e.AffName).HasMaxLength(50);
        });

        modelBuilder.Entity<Agency>(entity =>
        {
            entity.Property(e => e.AgncyAddress).HasMaxLength(50);
            entity.Property(e => e.AgncyCity).HasMaxLength(50);
            entity.Property(e => e.AgncyCountry).HasMaxLength(50);
            entity.Property(e => e.AgncyFax).HasMaxLength(50);
            entity.Property(e => e.AgncyPhone).HasMaxLength(50);
            entity.Property(e => e.AgncyPostal).HasMaxLength(50);
            entity.Property(e => e.AgncyProv).HasMaxLength(50);
        });

        modelBuilder.Entity<Agent>(entity =>
        {
            entity.Property(e => e.AgtBusPhone).HasMaxLength(20);
            entity.Property(e => e.AgtEmail).HasMaxLength(50);
            entity.Property(e => e.AgtFirstName).HasMaxLength(20);
            entity.Property(e => e.AgtLastName).HasMaxLength(20);
            entity.Property(e => e.AgtMiddleInitial).HasMaxLength(5);
            entity.Property(e => e.AgtPosition).HasMaxLength(20);

            entity.HasOne(d => d.Agency).WithMany(p => p.Agents)
                .HasForeignKey(d => d.AgencyId)
                .HasConstraintName("FK_Agents_Agencies");
        });

        modelBuilder.Entity<Booking>(entity =>
        {
            entity.HasKey(e => e.BookingId)
                .HasName("aaaaaBookings_PK")
                .IsClustered(false);

            entity.HasIndex(e => e.CustomerId, "BookingsCustomerId");

            entity.HasIndex(e => e.CustomerId, "CustomersBookings");

            entity.HasIndex(e => e.PackageId, "PackageId");

            entity.HasIndex(e => e.PackageId, "PackagesBookings");

            entity.HasIndex(e => e.TripTypeId, "TripTypesBookings");

            entity.Property(e => e.BookingDate).HasColumnType("datetime");
            entity.Property(e => e.BookingNo).HasMaxLength(50);
            entity.Property(e => e.PackageId).HasDefaultValueSql("((0))");
            entity.Property(e => e.TripTypeId).HasMaxLength(1);

            entity.HasOne(d => d.Customer).WithMany(p => p.Bookings)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("Bookings_FK00");

            entity.HasOne(d => d.Package).WithMany(p => p.Bookings)
                .HasForeignKey(d => d.PackageId)
                .HasConstraintName("Bookings_FK01");

            entity.HasOne(d => d.TripType).WithMany(p => p.Bookings)
                .HasForeignKey(d => d.TripTypeId)
                .HasConstraintName("Bookings_FK02");
        });

        modelBuilder.Entity<BookingDetail>(entity =>
        {
            entity.HasKey(e => e.BookingDetailId)
                .HasName("aaaaaBookingDetails_PK")
                .IsClustered(false);

            entity.HasIndex(e => e.FeeId, "Agency Fee Code");

            entity.HasIndex(e => e.BookingId, "BookingId");

            entity.HasIndex(e => e.BookingId, "BookingsBookingDetails");

            entity.HasIndex(e => e.ClassId, "ClassesBookingDetails");

            entity.HasIndex(e => e.RegionId, "Dest ID");

            entity.HasIndex(e => e.RegionId, "DestinationsBookingDetails");

            entity.HasIndex(e => e.FeeId, "FeesBookingDetails");

            entity.HasIndex(e => e.ProductSupplierId, "ProductSupplierId");

            entity.HasIndex(e => e.ProductSupplierId, "Products_SuppliersBookingDetails");

            entity.Property(e => e.AgencyCommission).HasColumnType("money");
            entity.Property(e => e.BasePrice).HasColumnType("money");
            entity.Property(e => e.BookingId).HasDefaultValueSql("((0))");
            entity.Property(e => e.ClassId).HasMaxLength(5);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Destination).HasMaxLength(255);
            entity.Property(e => e.FeeId).HasMaxLength(10);
            entity.Property(e => e.ProductSupplierId).HasDefaultValueSql("((0))");
            entity.Property(e => e.RegionId).HasMaxLength(5);
            entity.Property(e => e.TripEnd).HasColumnType("datetime");
            entity.Property(e => e.TripStart).HasColumnType("datetime");

            entity.HasOne(d => d.Booking).WithMany(p => p.BookingDetails)
                .HasForeignKey(d => d.BookingId)
                .HasConstraintName("FK_BookingDetails_Bookings");

            entity.HasOne(d => d.Class).WithMany(p => p.BookingDetails)
                .HasForeignKey(d => d.ClassId)
                .HasConstraintName("FK_BookingDetails_Classes");

            entity.HasOne(d => d.Fee).WithMany(p => p.BookingDetails)
                .HasForeignKey(d => d.FeeId)
                .HasConstraintName("FK_BookingDetails_Fees");

            entity.HasOne(d => d.ProductSupplier).WithMany(p => p.BookingDetails)
                .HasForeignKey(d => d.ProductSupplierId)
                .HasConstraintName("FK_BookingDetails_Products_Suppliers");

            entity.HasOne(d => d.Region).WithMany(p => p.BookingDetails)
                .HasForeignKey(d => d.RegionId)
                .HasConstraintName("FK_BookingDetails_Regions");
        });

        modelBuilder.Entity<Class>(entity =>
        {
            entity.HasKey(e => e.ClassId)
                .HasName("aaaaaClasses_PK")
                .IsClustered(false);

            entity.Property(e => e.ClassId).HasMaxLength(5);
            entity.Property(e => e.ClassDesc).HasMaxLength(50);
            entity.Property(e => e.ClassName).HasMaxLength(20);
        });

        modelBuilder.Entity<CreditCard>(entity =>
        {
            entity.HasKey(e => e.CreditCardId)
                .HasName("aaaaaCreditCards_PK")
                .IsClustered(false);

            entity.HasIndex(e => e.CustomerId, "CustomersCreditCards");

            entity.Property(e => e.Ccexpiry)
                .HasColumnType("datetime")
                .HasColumnName("CCExpiry");
            entity.Property(e => e.Ccname)
                .HasMaxLength(10)
                .HasColumnName("CCName");
            entity.Property(e => e.Ccnumber)
                .HasMaxLength(50)
                .HasColumnName("CCNumber");

            entity.HasOne(d => d.Customer).WithMany(p => p.CreditCards)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("CreditCards_FK00");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.CustomerId)
                .HasName("aaaaaCustomers_PK")
                .IsClustered(false);

            entity.HasIndex(e => e.AgentId, "EmployeesCustomers");

            entity.Property(e => e.CustAddress).HasMaxLength(75);
            entity.Property(e => e.CustBusPhone).HasMaxLength(20);
            entity.Property(e => e.CustCity).HasMaxLength(50);
            entity.Property(e => e.CustCountry).HasMaxLength(25);
            entity.Property(e => e.CustEmail).HasMaxLength(50);
            entity.Property(e => e.CustFirstName).HasMaxLength(25);
            entity.Property(e => e.CustHomePhone).HasMaxLength(20);
            entity.Property(e => e.CustLastName).HasMaxLength(25);
            entity.Property(e => e.CustPostal).HasMaxLength(7);
            entity.Property(e => e.CustProv).HasMaxLength(2);

            entity.HasOne(d => d.Agent).WithMany(p => p.Customers)
                .HasForeignKey(d => d.AgentId)
                .HasConstraintName("FK_Customers_Agents");
        });

        modelBuilder.Entity<CustomersReward>(entity =>
        {
            entity.HasKey(e => new { e.CustomerId, e.RewardId })
                .HasName("aaaaaCustomers_Rewards_PK")
                .IsClustered(false);

            entity.ToTable("Customers_Rewards");

            entity.HasIndex(e => e.CustomerId, "CustomersCustomers_Rewards");

            entity.HasIndex(e => e.RewardId, "RewardsCustomers_Rewards");

            entity.Property(e => e.RwdNumber).HasMaxLength(25);

            entity.HasOne(d => d.Customer).WithMany(p => p.CustomersRewards)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Customers_Rewards_FK00");

            entity.HasOne(d => d.Reward).WithMany(p => p.CustomersRewards)
                .HasForeignKey(d => d.RewardId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Customers_Rewards_FK01");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.EmpBusPhone).HasMaxLength(20);
            entity.Property(e => e.EmpEmail).HasMaxLength(50);
            entity.Property(e => e.EmpFirstName).HasMaxLength(20);
            entity.Property(e => e.EmpLastName).HasMaxLength(20);
            entity.Property(e => e.EmpMiddleInitial).HasMaxLength(5);
            entity.Property(e => e.EmpPosition).HasMaxLength(20);
        });

        modelBuilder.Entity<Fee>(entity =>
        {
            entity.HasKey(e => e.FeeId)
                .HasName("aaaaaFees_PK")
                .IsClustered(false);

            entity.Property(e => e.FeeId).HasMaxLength(10);
            entity.Property(e => e.FeeAmt).HasColumnType("money");
            entity.Property(e => e.FeeDesc).HasMaxLength(50);
            entity.Property(e => e.FeeName).HasMaxLength(50);
        });

        modelBuilder.Entity<Package>(entity =>
        {
            entity.HasKey(e => e.PackageId)
                .HasName("aaaaaPackages_PK")
                .IsClustered(false);

            entity.Property(e => e.PkgAgencyCommission)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.PkgBasePrice).HasColumnType("money");
            entity.Property(e => e.PkgDesc).HasMaxLength(50);
            entity.Property(e => e.PkgEndDate).HasColumnType("datetime");
            entity.Property(e => e.PkgName).HasMaxLength(50);
            entity.Property(e => e.PkgStartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<PackagesProductsSupplier>(entity =>
        {
            entity.HasKey(e => e.PackageProductSupplierId).HasName("PK__Packages__53E8ED99E6BD9C8D");

            entity.ToTable("Packages_Products_Suppliers");

            entity.HasIndex(e => e.PackageId, "PackagesPackages_Products_Suppliers");

            entity.HasIndex(e => e.ProductSupplierId, "ProductSupplierId");

            entity.HasIndex(e => e.ProductSupplierId, "Products_SuppliersPackages_Products_Suppliers");

            entity.HasIndex(e => new { e.PackageId, e.ProductSupplierId }, "UQ__Packages__29CA8E956814CAE7").IsUnique();

            entity.HasOne(d => d.Package).WithMany(p => p.PackagesProductsSuppliers)
                .HasForeignKey(d => d.PackageId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Packages_Products_Supplie_FK00");

            entity.HasOne(d => d.ProductSupplier).WithMany(p => p.PackagesProductsSuppliers)
                .HasForeignKey(d => d.ProductSupplierId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Packages_Products_Supplie_FK01");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProductId)
                .HasName("aaaaaProducts_PK")
                .IsClustered(false);

            entity.HasIndex(e => e.ProductId, "ProductId");

            entity.Property(e => e.ProdName).HasMaxLength(50);
        });

        modelBuilder.Entity<ProductsSupplier>(entity =>
        {
            entity.HasKey(e => e.ProductSupplierId)
                .HasName("aaaaaProducts_Suppliers_PK")
                .IsClustered(false);

            entity.ToTable("Products_Suppliers");

            entity.HasIndex(e => e.SupplierId, "Product Supplier ID");

            entity.HasIndex(e => e.ProductId, "ProductId");

            entity.HasIndex(e => e.ProductSupplierId, "ProductSupplierId");

            entity.HasIndex(e => e.ProductId, "ProductsProducts_Suppliers1");

            entity.HasIndex(e => e.SupplierId, "SuppliersProducts_Suppliers1");

            entity.Property(e => e.ProductId).HasDefaultValueSql("((0))");

            entity.HasOne(d => d.Product).WithMany(p => p.ProductsSuppliers)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("Products_Suppliers_FK00");

            entity.HasOne(d => d.Supplier).WithMany(p => p.ProductsSuppliers)
                .HasForeignKey(d => d.SupplierId)
                .HasConstraintName("Products_Suppliers_FK01");
        });

        modelBuilder.Entity<Region>(entity =>
        {
            entity.HasKey(e => e.RegionId)
                .HasName("aaaaaRegions_PK")
                .IsClustered(false);

            entity.Property(e => e.RegionId).HasMaxLength(5);
            entity.Property(e => e.RegionName).HasMaxLength(25);
        });

        modelBuilder.Entity<Reward>(entity =>
        {
            entity.HasKey(e => e.RewardId)
                .HasName("aaaaaRewards_PK")
                .IsClustered(false);

            entity.Property(e => e.RewardId).ValueGeneratedNever();
            entity.Property(e => e.RwdDesc).HasMaxLength(50);
            entity.Property(e => e.RwdName).HasMaxLength(50);
        });

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.HasKey(e => e.SupplierId)
                .HasName("aaaaaSuppliers_PK")
                .IsClustered(false);

            entity.HasIndex(e => e.SupplierId, "SupplierId");

            entity.Property(e => e.SupplierId).ValueGeneratedNever();
            entity.Property(e => e.SupName).HasMaxLength(255);
        });

        modelBuilder.Entity<SupplierContact>(entity =>
        {
            entity.HasKey(e => e.SupplierContactId)
                .HasName("aaaaaSupplierContacts_PK")
                .IsClustered(false);

            entity.HasIndex(e => e.AffiliationId, "AffiliationsSupCon");

            entity.HasIndex(e => e.SupplierId, "SuppliersSupCon");

            entity.Property(e => e.SupplierContactId).ValueGeneratedNever();
            entity.Property(e => e.AffiliationId).HasMaxLength(10);
            entity.Property(e => e.SupConAddress).HasMaxLength(255);
            entity.Property(e => e.SupConBusPhone).HasMaxLength(50);
            entity.Property(e => e.SupConCity).HasMaxLength(255);
            entity.Property(e => e.SupConCompany).HasMaxLength(255);
            entity.Property(e => e.SupConCountry).HasMaxLength(255);
            entity.Property(e => e.SupConEmail).HasMaxLength(255);
            entity.Property(e => e.SupConFax).HasMaxLength(50);
            entity.Property(e => e.SupConFirstName).HasMaxLength(50);
            entity.Property(e => e.SupConLastName).HasMaxLength(50);
            entity.Property(e => e.SupConPostal).HasMaxLength(255);
            entity.Property(e => e.SupConProv).HasMaxLength(255);
            entity.Property(e => e.SupConUrl)
                .HasMaxLength(255)
                .HasColumnName("SupConURL");
            entity.Property(e => e.SupplierId).HasDefaultValueSql("((0))");

            entity.HasOne(d => d.Affiliation).WithMany(p => p.SupplierContacts)
                .HasForeignKey(d => d.AffiliationId)
                .HasConstraintName("SupplierContacts_FK00");

            entity.HasOne(d => d.Supplier).WithMany(p => p.SupplierContacts)
                .HasForeignKey(d => d.SupplierId)
                .HasConstraintName("SupplierContacts_FK01");
        });

        modelBuilder.Entity<TripType>(entity =>
        {
            entity.HasKey(e => e.TripTypeId)
                .HasName("aaaaaTripTypes_PK")
                .IsClustered(false);

            entity.Property(e => e.TripTypeId).HasMaxLength(1);
            entity.Property(e => e.Ttname)
                .HasMaxLength(25)
                .HasColumnName("TTName");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
