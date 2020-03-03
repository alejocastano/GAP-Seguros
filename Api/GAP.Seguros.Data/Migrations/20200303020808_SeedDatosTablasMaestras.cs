using Microsoft.EntityFrameworkCore.Migrations;

namespace GAP.Seguros.Data.Migrations
{
    public partial class SeedDatosTablasMaestras : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cliente",
                columns: new[] { "idCliente", "identificacion", "nombre" },
                values: new object[,]
                {
                    { 1, "1020423358", "Juan Perez" },
                    { 2, "3336655", "Alejandra Velez" },
                    { 3, "4445588", "Fernanda Uribe" },
                    { 4, "88899663", "Fernando Muñoz" },
                    { 5, "111223344", "Alejandro Castaño" },
                    { 6, "33322445", "Luis Murcia" }
                });

            migrationBuilder.InsertData(
                table: "TipoCubrimiento",
                columns: new[] { "idTipoCubrimiento", "tipoCubrimiento" },
                values: new object[,]
                {
                    { (byte)1, "Terremoto" },
                    { (byte)2, "Incendio" },
                    { (byte)3, "Robo" },
                    { (byte)4, "Pérdida" },
                    { (byte)5, "Terremoto" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cliente",
                keyColumn: "idCliente",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cliente",
                keyColumn: "idCliente",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cliente",
                keyColumn: "idCliente",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cliente",
                keyColumn: "idCliente",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cliente",
                keyColumn: "idCliente",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cliente",
                keyColumn: "idCliente",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TipoCubrimiento",
                keyColumn: "idTipoCubrimiento",
                keyValue: (byte)1);

            migrationBuilder.DeleteData(
                table: "TipoCubrimiento",
                keyColumn: "idTipoCubrimiento",
                keyValue: (byte)2);

            migrationBuilder.DeleteData(
                table: "TipoCubrimiento",
                keyColumn: "idTipoCubrimiento",
                keyValue: (byte)3);

            migrationBuilder.DeleteData(
                table: "TipoCubrimiento",
                keyColumn: "idTipoCubrimiento",
                keyValue: (byte)4);

            migrationBuilder.DeleteData(
                table: "TipoCubrimiento",
                keyColumn: "idTipoCubrimiento",
                keyValue: (byte)5);
        }
    }
}
