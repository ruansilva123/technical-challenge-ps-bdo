using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CorporateResourcesAPI.Migrations
{
    /// <inheritdoc />
    public partial class InsertInitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "CreationDate", "UpdateDate", "IsActive", "City", "State", "Country" },
                values: new object[,]
                {
                    { DateTime.Now, DateTime.Now, true, "Joinville", "Santa Catarina", "Brazil" },
                    { DateTime.Now, DateTime.Now, true, "Pomerode", "Santa Catarina", "Brazil" },
                    { DateTime.Now, DateTime.Now, true, "Curitiba", "Paraná", "Brazil" },
                    { DateTime.Now, DateTime.Now, true, "Campinas", "São Paulo", "Brazil" },
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
