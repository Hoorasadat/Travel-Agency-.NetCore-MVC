

// Developer: Hoora


using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelAgency.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "Affiliations",
            //    columns: table => new
            //    {
            //        AffilitationId = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
            //        AffName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        AffDesc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("aaaaaAffiliations_PK", x => x.AffilitationId)
            //            .Annotation("SqlServer:Clustered", false);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Agencies",
            //    columns: table => new
            //    {
            //        AgencyId = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        AgncyAddress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        AgncyCity = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        AgncyProv = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        AgncyPostal = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        AgncyCountry = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        AgncyPhone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        AgncyFax = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Agencies", x => x.AgencyId);
            //    });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            //migrationBuilder.CreateTable(
            //    name: "Classes",
            //    columns: table => new
            //    {
            //        ClassId = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
            //        ClassName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
            //        ClassDesc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("aaaaaClasses_PK", x => x.ClassId)
            //            .Annotation("SqlServer:Clustered", false);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Employees",
            //    columns: table => new
            //    {
            //        EmpFirstName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
            //        EmpMiddleInitial = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
            //        EmpLastName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
            //        EmpBusPhone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
            //        EmpEmail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        EmpPosition = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Fees",
            //    columns: table => new
            //    {
            //        FeeId = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
            //        FeeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        FeeAmt = table.Column<decimal>(type: "money", nullable: false),
            //        FeeDesc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("aaaaaFees_PK", x => x.FeeId)
            //            .Annotation("SqlServer:Clustered", false);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Packages",
            //    columns: table => new
            //    {
            //        PackageId = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        PkgName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        PkgStartDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        PkgEndDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        PkgDesc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        PkgBasePrice = table.Column<decimal>(type: "money", nullable: false),
            //        PkgAgencyCommission = table.Column<decimal>(type: "money", nullable: true, defaultValueSql: "((0))")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("aaaaaPackages_PK", x => x.PackageId)
            //            .Annotation("SqlServer:Clustered", false);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Products",
            //    columns: table => new
            //    {
            //        ProductId = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        ProdName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("aaaaaProducts_PK", x => x.ProductId)
            //            .Annotation("SqlServer:Clustered", false);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Regions",
            //    columns: table => new
            //    {
            //        RegionId = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
            //        RegionName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("aaaaaRegions_PK", x => x.RegionId)
            //            .Annotation("SqlServer:Clustered", false);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Rewards",
            //    columns: table => new
            //    {
            //        RewardId = table.Column<int>(type: "int", nullable: false),
            //        RwdName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        RwdDesc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("aaaaaRewards_PK", x => x.RewardId)
            //            .Annotation("SqlServer:Clustered", false);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Suppliers",
            //    columns: table => new
            //    {
            //        SupplierId = table.Column<int>(type: "int", nullable: false),
            //        SupName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("aaaaaSuppliers_PK", x => x.SupplierId)
            //            .Annotation("SqlServer:Clustered", false);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "TripTypes",
            //    columns: table => new
            //    {
            //        TripTypeId = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
            //        TTName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("aaaaaTripTypes_PK", x => x.TripTypeId)
            //            .Annotation("SqlServer:Clustered", false);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Agents",
            //    columns: table => new
            //    {
            //        AgentId = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        AgtFirstName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
            //        AgtMiddleInitial = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
            //        AgtLastName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
            //        AgtBusPhone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
            //        AgtEmail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        AgtPosition = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
            //        AgencyId = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Agents", x => x.AgentId);
            //        table.ForeignKey(
            //            name: "FK_Agents_Agencies",
            //            column: x => x.AgencyId,
            //            principalTable: "Agencies",
            //            principalColumn: "AgencyId");
            //    });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            //migrationBuilder.CreateTable(
            //    name: "Products_Suppliers",
            //    columns: table => new
            //    {
            //        ProductSupplierId = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        ProductId = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
            //        SupplierId = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("aaaaaProducts_Suppliers_PK", x => x.ProductSupplierId)
            //            .Annotation("SqlServer:Clustered", false);
            //        table.ForeignKey(
            //            name: "Products_Suppliers_FK00",
            //            column: x => x.ProductId,
            //            principalTable: "Products",
            //            principalColumn: "ProductId");
            //        table.ForeignKey(
            //            name: "Products_Suppliers_FK01",
            //            column: x => x.SupplierId,
            //            principalTable: "Suppliers",
            //            principalColumn: "SupplierId");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "SupplierContacts",
            //    columns: table => new
            //    {
            //        SupplierContactId = table.Column<int>(type: "int", nullable: false),
            //        SupConFirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        SupConLastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        SupConCompany = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
            //        SupConAddress = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
            //        SupConCity = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
            //        SupConProv = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
            //        SupConPostal = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
            //        SupConCountry = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
            //        SupConBusPhone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        SupConFax = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        SupConEmail = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
            //        SupConURL = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
            //        AffiliationId = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
            //        SupplierId = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("aaaaaSupplierContacts_PK", x => x.SupplierContactId)
            //            .Annotation("SqlServer:Clustered", false);
            //        table.ForeignKey(
            //            name: "SupplierContacts_FK00",
            //            column: x => x.AffiliationId,
            //            principalTable: "Affiliations",
            //            principalColumn: "AffilitationId");
            //        table.ForeignKey(
            //            name: "SupplierContacts_FK01",
            //            column: x => x.SupplierId,
            //            principalTable: "Suppliers",
            //            principalColumn: "SupplierId");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Customers",
            //    columns: table => new
            //    {
            //        CustomerId = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        CustFirstName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
            //        CustLastName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
            //        CustAddress = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
            //        CustCity = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        CustProv = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
            //        CustPostal = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: false),
            //        CustCountry = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
            //        CustHomePhone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
            //        CustBusPhone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
            //        CustEmail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        AgentId = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("aaaaaCustomers_PK", x => x.CustomerId)
            //            .Annotation("SqlServer:Clustered", false);
            //        table.ForeignKey(
            //            name: "FK_Customers_Agents",
            //            column: x => x.AgentId,
            //            principalTable: "Agents",
            //            principalColumn: "AgentId");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Packages_Products_Suppliers",
            //    columns: table => new
            //    {
            //        PackageProductSupplierId = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        PackageId = table.Column<int>(type: "int", nullable: false),
            //        ProductSupplierId = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__Packages__53E8ED99E6BD9C8D", x => x.PackageProductSupplierId);
            //        table.ForeignKey(
            //            name: "Packages_Products_Supplie_FK00",
            //            column: x => x.PackageId,
            //            principalTable: "Packages",
            //            principalColumn: "PackageId");
            //        table.ForeignKey(
            //            name: "Packages_Products_Supplie_FK01",
            //            column: x => x.ProductSupplierId,
            //            principalTable: "Products_Suppliers",
            //            principalColumn: "ProductSupplierId");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Bookings",
            //    columns: table => new
            //    {
            //        BookingId = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        BookingDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        BookingNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        TravelerCount = table.Column<double>(type: "float", nullable: true),
            //        CustomerId = table.Column<int>(type: "int", nullable: true),
            //        TripTypeId = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
            //        PackageId = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("aaaaaBookings_PK", x => x.BookingId)
            //            .Annotation("SqlServer:Clustered", false);
            //        table.ForeignKey(
            //            name: "Bookings_FK00",
            //            column: x => x.CustomerId,
            //            principalTable: "Customers",
            //            principalColumn: "CustomerId");
            //        table.ForeignKey(
            //            name: "Bookings_FK01",
            //            column: x => x.PackageId,
            //            principalTable: "Packages",
            //            principalColumn: "PackageId");
            //        table.ForeignKey(
            //            name: "Bookings_FK02",
            //            column: x => x.TripTypeId,
            //            principalTable: "TripTypes",
            //            principalColumn: "TripTypeId");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "CreditCards",
            //    columns: table => new
            //    {
            //        CreditCardId = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        CCName = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
            //        CCNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        CCExpiry = table.Column<DateTime>(type: "datetime", nullable: false),
            //        CustomerId = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("aaaaaCreditCards_PK", x => x.CreditCardId)
            //            .Annotation("SqlServer:Clustered", false);
            //        table.ForeignKey(
            //            name: "CreditCards_FK00",
            //            column: x => x.CustomerId,
            //            principalTable: "Customers",
            //            principalColumn: "CustomerId");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Customers_Rewards",
            //    columns: table => new
            //    {
            //        CustomerId = table.Column<int>(type: "int", nullable: false),
            //        RewardId = table.Column<int>(type: "int", nullable: false),
            //        RwdNumber = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("aaaaaCustomers_Rewards_PK", x => new { x.CustomerId, x.RewardId })
            //            .Annotation("SqlServer:Clustered", false);
            //        table.ForeignKey(
            //            name: "Customers_Rewards_FK00",
            //            column: x => x.CustomerId,
            //            principalTable: "Customers",
            //            principalColumn: "CustomerId");
            //        table.ForeignKey(
            //            name: "Customers_Rewards_FK01",
            //            column: x => x.RewardId,
            //            principalTable: "Rewards",
            //            principalColumn: "RewardId");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "BookingDetails",
            //    columns: table => new
            //    {
            //        BookingDetailId = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        ItineraryNo = table.Column<double>(type: "float", nullable: true),
            //        TripStart = table.Column<DateTime>(type: "datetime", nullable: true),
            //        TripEnd = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
            //        Destination = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
            //        BasePrice = table.Column<decimal>(type: "money", nullable: true),
            //        AgencyCommission = table.Column<decimal>(type: "money", nullable: true),
            //        BookingId = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
            //        RegionId = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
            //        ClassId = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
            //        FeeId = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
            //        ProductSupplierId = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("aaaaaBookingDetails_PK", x => x.BookingDetailId)
            //            .Annotation("SqlServer:Clustered", false);
            //        table.ForeignKey(
            //            name: "FK_BookingDetails_Bookings",
            //            column: x => x.BookingId,
            //            principalTable: "Bookings",
            //            principalColumn: "BookingId");
            //        table.ForeignKey(
            //            name: "FK_BookingDetails_Classes",
            //            column: x => x.ClassId,
            //            principalTable: "Classes",
            //            principalColumn: "ClassId");
            //        table.ForeignKey(
            //            name: "FK_BookingDetails_Fees",
            //            column: x => x.FeeId,
            //            principalTable: "Fees",
            //            principalColumn: "FeeId");
            //        table.ForeignKey(
            //            name: "FK_BookingDetails_Products_Suppliers",
            //            column: x => x.ProductSupplierId,
            //            principalTable: "Products_Suppliers",
            //            principalColumn: "ProductSupplierId");
            //        table.ForeignKey(
            //            name: "FK_BookingDetails_Regions",
            //            column: x => x.RegionId,
            //            principalTable: "Regions",
            //            principalColumn: "RegionId");
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_Agents_AgencyId",
            //    table: "Agents",
            //    column: "AgencyId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            //migrationBuilder.CreateIndex(
            //    name: "Agency Fee Code",
            //    table: "BookingDetails",
            //    column: "FeeId");

            //migrationBuilder.CreateIndex(
            //    name: "BookingId",
            //    table: "BookingDetails",
            //    column: "BookingId");

            //migrationBuilder.CreateIndex(
            //    name: "BookingsBookingDetails",
            //    table: "BookingDetails",
            //    column: "BookingId");

            //migrationBuilder.CreateIndex(
            //    name: "ClassesBookingDetails",
            //    table: "BookingDetails",
            //    column: "ClassId");

            //migrationBuilder.CreateIndex(
            //    name: "Dest ID",
            //    table: "BookingDetails",
            //    column: "RegionId");

            //migrationBuilder.CreateIndex(
            //    name: "DestinationsBookingDetails",
            //    table: "BookingDetails",
            //    column: "RegionId");

            //migrationBuilder.CreateIndex(
            //    name: "FeesBookingDetails",
            //    table: "BookingDetails",
            //    column: "FeeId");

            //migrationBuilder.CreateIndex(
            //    name: "Products_SuppliersBookingDetails",
            //    table: "BookingDetails",
            //    column: "ProductSupplierId");

            //migrationBuilder.CreateIndex(
            //    name: "ProductSupplierId",
            //    table: "BookingDetails",
            //    column: "ProductSupplierId");

            //migrationBuilder.CreateIndex(
            //    name: "BookingsCustomerId",
            //    table: "Bookings",
            //    column: "CustomerId");

            //migrationBuilder.CreateIndex(
            //    name: "CustomersBookings",
            //    table: "Bookings",
            //    column: "CustomerId");

            //migrationBuilder.CreateIndex(
            //    name: "PackageId",
            //    table: "Bookings",
            //    column: "PackageId");

            //migrationBuilder.CreateIndex(
            //    name: "PackagesBookings",
            //    table: "Bookings",
            //    column: "PackageId");

            //migrationBuilder.CreateIndex(
            //    name: "TripTypesBookings",
            //    table: "Bookings",
            //    column: "TripTypeId");

            //migrationBuilder.CreateIndex(
            //    name: "CustomersCreditCards",
            //    table: "CreditCards",
            //    column: "CustomerId");

            //migrationBuilder.CreateIndex(
            //    name: "EmployeesCustomers",
            //    table: "Customers",
            //    column: "AgentId");

            //migrationBuilder.CreateIndex(
            //    name: "CustomersCustomers_Rewards",
            //    table: "Customers_Rewards",
            //    column: "CustomerId");

            //migrationBuilder.CreateIndex(
            //    name: "RewardsCustomers_Rewards",
            //    table: "Customers_Rewards",
            //    column: "RewardId");

            //migrationBuilder.CreateIndex(
            //    name: "PackagesPackages_Products_Suppliers",
            //    table: "Packages_Products_Suppliers",
            //    column: "PackageId");

            //migrationBuilder.CreateIndex(
            //    name: "Products_SuppliersPackages_Products_Suppliers",
            //    table: "Packages_Products_Suppliers",
            //    column: "ProductSupplierId");

            //migrationBuilder.CreateIndex(
            //    name: "ProductSupplierId",
            //    table: "Packages_Products_Suppliers",
            //    column: "ProductSupplierId");

            //migrationBuilder.CreateIndex(
            //    name: "UQ__Packages__29CA8E956814CAE7",
            //    table: "Packages_Products_Suppliers",
            //    columns: new[] { "PackageId", "ProductSupplierId" },
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "ProductId",
            //    table: "Products",
            //    column: "ProductId");

            //migrationBuilder.CreateIndex(
            //    name: "Product Supplier ID",
            //    table: "Products_Suppliers",
            //    column: "SupplierId");

            //migrationBuilder.CreateIndex(
            //    name: "ProductId",
            //    table: "Products_Suppliers",
            //    column: "ProductId");

            //migrationBuilder.CreateIndex(
            //    name: "ProductsProducts_Suppliers1",
            //    table: "Products_Suppliers",
            //    column: "ProductId");

            //migrationBuilder.CreateIndex(
            //    name: "ProductSupplierId",
            //    table: "Products_Suppliers",
            //    column: "ProductSupplierId");

            //migrationBuilder.CreateIndex(
            //    name: "SuppliersProducts_Suppliers1",
            //    table: "Products_Suppliers",
            //    column: "SupplierId");

            //migrationBuilder.CreateIndex(
            //    name: "AffiliationsSupCon",
            //    table: "SupplierContacts",
            //    column: "AffiliationId");

            //migrationBuilder.CreateIndex(
            //    name: "SuppliersSupCon",
            //    table: "SupplierContacts",
            //    column: "SupplierId");

            //migrationBuilder.CreateIndex(
            //    name: "SupplierId",
            //    table: "Suppliers",
            //    column: "SupplierId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            //migrationBuilder.DropTable(
            //    name: "BookingDetails");

            //migrationBuilder.DropTable(
            //    name: "CreditCards");

            //migrationBuilder.DropTable(
            //    name: "Customers_Rewards");

            //migrationBuilder.DropTable(
            //    name: "Employees");

            //migrationBuilder.DropTable(
            //    name: "Packages_Products_Suppliers");

            //migrationBuilder.DropTable(
            //    name: "SupplierContacts");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            //migrationBuilder.DropTable(
            //    name: "Bookings");

            //migrationBuilder.DropTable(
            //    name: "Classes");

            //migrationBuilder.DropTable(
            //    name: "Fees");

            //migrationBuilder.DropTable(
            //    name: "Regions");

            //migrationBuilder.DropTable(
            //    name: "Rewards");

            //migrationBuilder.DropTable(
            //    name: "Products_Suppliers");

            //migrationBuilder.DropTable(
            //    name: "Affiliations");

            //migrationBuilder.DropTable(
            //    name: "Customers");

            //migrationBuilder.DropTable(
            //    name: "Packages");

            //migrationBuilder.DropTable(
            //    name: "TripTypes");

            //migrationBuilder.DropTable(
            //    name: "Products");

            //migrationBuilder.DropTable(
            //    name: "Suppliers");

            //migrationBuilder.DropTable(
            //    name: "Agents");

            //migrationBuilder.DropTable(
            //    name: "Agencies");
        }
    }
}
