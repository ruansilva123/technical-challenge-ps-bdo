using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CorporateResources.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InsertInitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Name", "CreationDate", "UpdateDate", "IsActive" },
                values: new object[,]
                {
                    { "Joinville", DateTime.Now, DateTime.Now, true },
                    { "Pomerode", DateTime.Now, DateTime.Now, true },
                    { "Curitiba", DateTime.Now, DateTime.Now, true },
                    { "Campinas", DateTime.Now, DateTime.Now, true }
                });

            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "Name", "CreationDate", "UpdateDate", "IsActive" },
                values: new object[,]
                {
                    { "Santa Catarina", DateTime.Now, DateTime.Now, true },
                    { "Paraná", DateTime.Now, DateTime.Now, true },
                    { "São Paulo", DateTime.Now, DateTime.Now, true }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Name", "CreationDate", "UpdateDate", "IsActive" },
                values: new object[,]
                {
                    { "Brazil", DateTime.Now, DateTime.Now, true }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "CreationDate", "UpdateDate", "IsActive", "CountryId", "StateId", "CityId" },
                values: new object[,]
                {
                    { DateTime.Now, DateTime.Now, true, 1, 1, 1 },
                    { DateTime.Now, DateTime.Now, true, 1, 1, 2 },
                    { DateTime.Now, DateTime.Now, true, 1, 2, 3 },
                    { DateTime.Now, DateTime.Now, true, 1, 3, 4 },
                });

            migrationBuilder.InsertData(
                table: "ResourceCategories",
                columns: new[] { "Name", "Description", "CreationDate", "UpdateDate", "IsActive" },
                values: new object[,]
                {
                    { "Meeting Room", "Avaible meeting rooms to reservate", DateTime.Now, DateTime.Now, true },
                    { "Equipments", "Avaible equipments to reservate", DateTime.Now, DateTime.Now, true },
                    { "Vehicles", "Avaible vehicles to reservate", DateTime.Now, DateTime.Now, true }
                });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Name", "Description", "CreationDate", "UpdateDate", "IsActive", "LocationId", "CategoryId" },
                values: new object[,]
                {
                    { "Golf GTI", "Avaible car to reservate", DateTime.Now, DateTime.Now, true, 1, 3 },
                    { "Honda Civic", "Avaible car to reservate", DateTime.Now, DateTime.Now, true, 3, 3 },
                    { "Honda City", "Avaible car to reservate", DateTime.Now, DateTime.Now, true, 2, 3 },
                    { "Volvo XC60", "Avaible car to reservate", DateTime.Now, DateTime.Now, true, 1, 3 },
                    { "Sony F65", "Avaible camera to reservate", DateTime.Now, DateTime.Now, true, 4, 2 },
                    { "Mirante", "Avaible meeting room to reservate", DateTime.Now, DateTime.Now, true, 1, 1 },
                    { "Cidade das Flores", "Avaible meeting room to reservate", DateTime.Now, DateTime.Now, true, 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "StartReservation", "EndReservation", "CreationDate", "UpdateDate", "IsActive", "ResourceId", "Responsible" },
                values: new object[,]
                {
                    { DateTime.Now, DateTime.Now, DateTime.Now, DateTime.Now, true, 1, "Ruan Carlos da Silva" },
                    { DateTime.Now, DateTime.Now, DateTime.Now, DateTime.Now, true, 2, "Ruan Carlos da Silva" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
