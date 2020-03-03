using Microsoft.EntityFrameworkCore.Migrations;

namespace GAP.Seguros.Data.Migrations
{
    public partial class CambioDeNombreCampos2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DescTipoRiesgo",
                table: "TipoRiesgo",
                newName: "descTipoRiesgo");

            migrationBuilder.RenameColumn(
                name: "DescCubrimiento",
                table: "TipoCubrimiento",
                newName: "descCubrimiento");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "descTipoRiesgo",
                table: "TipoRiesgo",
                newName: "DescTipoRiesgo");

            migrationBuilder.RenameColumn(
                name: "descCubrimiento",
                table: "TipoCubrimiento",
                newName: "DescCubrimiento");
        }
    }
}
