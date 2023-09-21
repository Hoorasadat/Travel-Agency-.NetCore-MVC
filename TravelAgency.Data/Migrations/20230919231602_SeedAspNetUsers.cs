

// Developer: Hoora


using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelAgency.Data.Migrations
{
    public partial class SeedAspNetUsers : Migration
    {

        private string[] CommonUserColumns = new[]
        {
            "Id",
            "UserName",
            "NormalizedUserName",
            "Email",
            "NormalizedEmail",
            "EmailConfirmed",
            "PasswordHash",
            "SecurityStamp",
            "ConcurrencyStamp",
            "PhoneNumber",
            "PhoneNumberConfirmed",
            "TwoFactorEnabled",
            "LockoutEnabled",
            "AccessFailedCount"
        };

        private void SeedUserData(MigrationBuilder migrationBuilder, string userId, string userName, string normalizedUserName,
                                    string email, string normalizedEmail, string passwordHash, string phoneNumber)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: CommonUserColumns,
                values: new object[]
                {
                    userId,
                    userName,
                    normalizedUserName,
                    email,
                    normalizedEmail,
                    true,
                    passwordHash, // Use the hashed password here
                    string.Empty,
                    Guid.NewGuid().ToString(),
                    phoneNumber,
                    true,
                    false,
                    true,
                    4
                }
            );
        }

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            SeedUserData(migrationBuilder, "104", "lenison", "LENISON", "laetiaenison@example.com", "LAETIAENISON@EXAMPLE.COM", "AQAAAAEAACcQAAAAEPA1pSc93QhsSo2/bB0zqPkXJl7mAJf6P/4l+tRa+MbylXnz0ND7xATZNjO/gGRr3A==", "4032791223");
            SeedUserData(migrationBuilder, "105", "amoskowitz", "AMOSKOWITZ", "angelmoskowitz@example.com", "ANGELMOSKOWITZ@EXAMPLE.COM", "AQAAAAEAACcQAAAAEPA1pSc93QhsSo2/bB0zqPkXJl7mAJf6P/4l+tRa+MbylXnz0ND7xATZNjO/gGRr3A==", "4032794228");
            SeedUserData(migrationBuilder, "106", "jolvsade", "JOLVSADE", "juditholvsade@example.com", "JUDITHOLVSADE@EXAMPLE.COM", "AQAAAAEAACcQAAAAEGZKRiRUW6qYFnzErA/ca7Rx++3Nxc0eU+cL+vQhxBhCEWT1Mf4vbaA3uNVZStVKug==", "4032795652");
            SeedUserData(migrationBuilder, "107", "cmierzwa", "CMIERZWA", "catherinemierzwa@example.com", "CATHERINEMIERZWA@EXAMPLE.COM", "AQAAAAEAACcQAAAAEBlfd5nnEM8f9vGR2+VjnZbjgu8SoGV0GDJSCigCzaJuGtQuahVf8nfjrokes9IWHQ==", "4032796878");
            SeedUserData(migrationBuilder, "108", "jsehti", "JSEHTI", "judysehti@example.com", "JUDYSEHTI@EXAMPLE.COM", "AQAAAAEAACcQAAAAEB+lrh00S56dzRQPGeel2uDS9WHgzvnXmhMXbaTXE0QYqLM9B3i8TdCYeRpO4PIGpg==", "4032795111");
            SeedUserData(migrationBuilder, "109", "lwalter", "LWALTER", "larrywalter@example.com", "LARRYWALTER@EXAMPLE.COM", "AQAAAAEAACcQAAAAENS4tMu2PfkSQGau2nB0GhyP4IhQlpZvSZ3NdR0DLKm74fnw5VNn1gMaanmoL5HV/w==", "4032793254");
            SeedUserData(migrationBuilder, "114", "llaporte", "LLAPORTE", "winsomelaporte@example.com", "WINSOMELAPORTE@EXAMPLE.COM", "AQAAAAEAACcQAAAAEDndxv+ZkZRNh0nWAl6Am4wBbv565NOKw88XR3kI8HPYQe66HUocOfUs/JqexX2HfA==", "4032691125");
            SeedUserData(migrationBuilder, "117", "nkuehn", "NKUEHN", "nancykuehn@example.com", "NANCYKUEHN@EXAMPLE.COM", "AQAAAAEAACcQAAAAEAXiPZBscgZDJ/+UUn+lgS+4ei0c0Mby0rewqP47hXsW13ijQJSq0sCMP+Ae/7vkBA==", "4032693965");
            SeedUserData(migrationBuilder, "118", "hlopez", "HLOPEZ", "hiedilopez@example.com", "HIEDILOPEZ@EXAMPLE.COM", "AQAAAAEAACcQAAAAEJ0aCqeYbIJ84fdjieraohJu35zdjW+bPyWk/p8tSMpUw+1cgSAkbRkp5FWn5UbbRQ==", "4032699856");
            SeedUserData(migrationBuilder, "119", "mabdou", "MABDOU", "mardigabdou@example.com", "MARDIGABDOU@EXAMPLE.COM", "AQAAAAEAACcQAAAAECGUCUWfCIFvYHthlVcBVgwksawUdqs/QaJ0nzAQCxhvkKVKmYMUQG0Ez9QyJ7K7oA==", "4032691429");
            SeedUserData(migrationBuilder, "120", "ralexander", "RALEXANDER", "ralphalexander@example.com", "RALPHALEXANDER@EXAMPLE.COM", "AQAAAAEAACcQAAAAEOvKYYILEi4yOSolHoSzNVYBN+nTKSnOZ/9Nif12YvMDnPpFkr8Q516ZDvVB7ROg/g==", "4032691634");
            SeedUserData(migrationBuilder, "121", "spineda", "SPINEDA", "seanpineda@example.com", "SEANPINEDA@EXAMPLE.COM", "AQAAAAEAACcQAAAAEN189DkCEP9+BRa8AwIZ28B78i52niKNNfX7xMn5GMMyYRduZbfOhaLnqc3bbWhgeQ==", "4032691954");
            SeedUserData(migrationBuilder, "122", "jlippen", "JLIPPEN", "julitalippen@example.com", "JULITALIPPEN@EXAMPLE.COM", "AQAAAAEAACcQAAAAEJINyZ7DIYc0m/fMQ0T0aynDgazraeCgSbtbJTI1y7hZnppyRgsba7t4x9PFSsQTyw==", "4032551956");
            SeedUserData(migrationBuilder, "123", "pradicola", "PRADICOLA", "pierpradicola@example.com", "PIERPRADICOLA@EXAMPLE.COM", "AQAAAAEAACcQAAAAECtDlpQSIQPOZ72tLOnDcGTw3q3NQgNeS7FuHq2EXAE4oKf1Ic8SMcZeVHtX7ooZFg==", "4032551677");
            SeedUserData(migrationBuilder, "127", "gaung", "GAUNG", "garyaung@example.com", "GARYAUNG@EXAMPLE.COM", "AQAAAAEAACcQAAAAEIersV0ZNSbYvJ0Co4UebJ5AVhfJ+TyDdRViBxL70LI4DuqT0CNID4IZBABO4lzE9A==", "4032807858");
            SeedUserData(migrationBuilder, "128", "jrunyan", "JRUNYAN", "jeffrunyan@example.com", "JEFFRUNYAN@EXAMPLE.COM", "AQAAAAEAACcQAAAAEPj2Yd3h1p5QbdvuPwiz9jBWOeECbkXp/xt/zqaZU848vF40fGDEy/jS3JHVvNO28w==", "4032809635");
            SeedUserData(migrationBuilder, "130", "loates", "LOATES", "lulaloates@example.com", "LULALOATES@EXAMPLE.COM", "AQAAAAEAACcQAAAAEOtMeA/ayWB1aIoa1yFdmzy3tbj6sNNd//GFvqAeMNSclzAiPyYPWUx7njTXyk6lPg==", "4032439653");
            SeedUserData(migrationBuilder, "133", "jreed", "JREED", "jamesreed@example.com", "JAMESREED@EXAMPLE.COM", "AQAAAAEAACcQAAAAEH6L5gxbx5SsxmOk0BFbNqE90Yi65PQVuyOl6UTNGk9ZHJKuyu3PbI6Wh5CFlXeKDg==", "4032432358");
            SeedUserData(migrationBuilder, "135", "mmasser", "MMASSER", "michellemasser@example.com", "MICHELLEMASSER@EXAMPLE.COM", "AQAAAAEAACcQAAAAECBJfYCQ0a2+SbiZG1nltDM174WUMrICogt8nZ8jaM5dE2CmSfQ1CaRSncH3WyxyMA==", "4032441586");
            SeedUserData(migrationBuilder, "138", "jsmith", "JSMITH", "johnsmith@example.com", "JOHNSMITH@EXAMPLE.COM", "AQAAAAEAACcQAAAAENUyn2OkVn+vzsV87EOZayc8shQEgOfKd4Gk3Wcg7S9nYnllehfNV0mLS7nJq9kmzQ==", "4032449653");
            SeedUserData(migrationBuilder, "139", "agarshman", "AGARSHMAN", "angeloagarshman@example.com", "ANGELOAGARSHMAN@EXAMPLE.COM", "AQAAAAEAACcQAAAAEPOSBcQbKYBIT1CF3BEDJKlTDh2jVdjnnpX5go3FlUQBoi8wbkQoB/UGDltHaTIoBA==", "4032259966");
            SeedUserData(migrationBuilder, "140", "dbaltazar", "DBALTAZAR", "derrickbaltazar@example.com", "DERRICKBALTAZAR@EXAMPLE.COM", "AQAAAAEAACcQAAAAEMEYRiM1rQ2+EdflE9t7G46xVRhsxI+vpoGTbx5vEElguC21JN3p9vbaIrS/Xp1qVw==", "4032255231");
            SeedUserData(migrationBuilder, "141", "rboyd", "RBOYD", "robertboyd@example.com", "ROBERTBOYD@EXAMPLE.COM", "AQAAAAEAACcQAAAAEIEgy8Y6tY+vCaLBSTdLPNHtlmqQfLkrAmhqq2cLn0dx2Hk95N+0vLypvRtTaNJP9Q==", "4032255647");
            SeedUserData(migrationBuilder, "142", "mwaldman", "MWALDMAN", "monicawaldman@example.com", "MONICAWALDMAN@EXAMPLE.COM", "AQAAAAEAACcQAAAAEGrSgVBpfUnXrqrtkENyauNWSbyqvjw1xfoeSs1Gp6ynNWK1N7TKJklXhgNPMh380g==", "4032255629");
            SeedUserData(migrationBuilder, "143", "gbiers", "GBIERS", "gerardbiers@example.com", "GERARDBIERS@EXAMPLE.COM", "AQAAAAEAACcQAAAAEFuq2DBDVTCRxRmr+hNMIWXX533pcD+7v1aKrvtNJSq+o90dIoyPkhJBZ5hAWtVONA==", "4032251952");
        }


        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
