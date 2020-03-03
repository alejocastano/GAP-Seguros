using Microsoft.EntityFrameworkCore.Migrations;

namespace GAP.Seguros.Data.Migrations
{
    public partial class CambioDeNombreCampos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "tipoRiesgo",
                table: "TipoRiesgo",
                newName: "DescTipoRiesgo");

            migrationBuilder.RenameColumn(
                name: "tipoCubrimiento",
                table: "TipoCubrimiento",
                newName: "DescCubrimiento");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DescTipoRiesgo",
                table: "TipoRiesgo",
                newName: "tipoRiesgo");

            migrationBuilder.RenameColumn(
                name: "DescCubrimiento",
                table: "TipoCubrimiento",
                newName: "tipoCubrimiento");
        }
    }
}
