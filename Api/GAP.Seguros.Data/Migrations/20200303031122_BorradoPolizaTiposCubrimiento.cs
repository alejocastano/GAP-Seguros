using Microsoft.EntityFrameworkCore.Migrations;

namespace GAP.Seguros.Data.Migrations
{
    public partial class BorradoPolizaTiposCubrimiento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PolizaTiposCubrimiento");

            migrationBuilder.AddColumn<byte>(
                name: "IdTipoCubrimiento",
                table: "Poliza",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Poliza_IdTipoCubrimiento",
                table: "Poliza",
                column: "IdTipoCubrimiento");

            migrationBuilder.AddForeignKey(
                name: "FK_Poliza_TipoCubrimiento",
                table: "Poliza",
                column: "IdTipoCubrimiento",
                principalTable: "TipoCubrimiento",
                principalColumn: "idTipoCubrimiento",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Poliza_TipoCubrimiento",
                table: "Poliza");

            migrationBuilder.DropIndex(
                name: "IX_Poliza_IdTipoCubrimiento",
                table: "Poliza");

            migrationBuilder.DropColumn(
                name: "IdTipoCubrimiento",
                table: "Poliza");

            migrationBuilder.CreateTable(
                name: "PolizaTiposCubrimiento",
                columns: table => new
                {
                    idPolizaTiposCubrimiento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idPoliza = table.Column<int>(type: "int", nullable: true),
                    idTipoCubrimiento = table.Column<byte>(type: "tinyint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PolizaTiposCubrimiento", x => x.idPolizaTiposCubrimiento);
                    table.ForeignKey(
                        name: "FK_PolizaTiposCubrimiento_Poliza",
                        column: x => x.idPoliza,
                        principalTable: "Poliza",
                        principalColumn: "idPoliza",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PolizaTiposCubrimiento_TipoCubrimiento",
                        column: x => x.idTipoCubrimiento,
                        principalTable: "TipoCubrimiento",
                        principalColumn: "idTipoCubrimiento",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PolizaTiposCubrimiento_idPoliza",
                table: "PolizaTiposCubrimiento",
                column: "idPoliza");

            migrationBuilder.CreateIndex(
                name: "IX_PolizaTiposCubrimiento_idTipoCubrimiento",
                table: "PolizaTiposCubrimiento",
                column: "idTipoCubrimiento");
        }
    }
}
