using Microsoft.EntityFrameworkCore.Migrations;

namespace GAP.Seguros.Data.Migrations
{
    public partial class SeedTipoRiesgo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TipoRiesgo",
                columns: new[] { "idTipoRiesgo", "tipoRiesgo" },
                values: new object[,]
                {
                    { (byte)1, "Bajo" },
                    { (byte)2, "Medio" },
                    { (byte)3, "Medio-Alto" },
                    { (byte)4, "Alto" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TipoRiesgo",
                keyColumn: "idTipoRiesgo",
                keyValue: (byte)1);

            migrationBuilder.DeleteData(
                table: "TipoRiesgo",
                keyColumn: "idTipoRiesgo",
                keyValue: (byte)2);

            migrationBuilder.DeleteData(
                table: "TipoRiesgo",
                keyColumn: "idTipoRiesgo",
                keyValue: (byte)3);

            migrationBuilder.DeleteData(
                table: "TipoRiesgo",
                keyColumn: "idTipoRiesgo",
                keyValue: (byte)4);
        }
    }
}
