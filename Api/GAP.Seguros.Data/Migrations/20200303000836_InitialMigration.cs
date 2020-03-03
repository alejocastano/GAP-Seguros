using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GAP.Seguros.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    idCliente = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    identificacion = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    nombre = table.Column<string>(unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.idCliente);
                });

            migrationBuilder.CreateTable(
                name: "TipoCubrimiento",
                columns: table => new
                {
                    idTipoCubrimiento = table.Column<byte>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tipoCubrimiento = table.Column<string>(unicode: false, maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoCubrimiento", x => x.idTipoCubrimiento);
                });

            migrationBuilder.CreateTable(
                name: "TipoRiesgo",
                columns: table => new
                {
                    idTipoRiesgo = table.Column<byte>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tipoRiesgo = table.Column<string>(unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoRiesgo", x => x.idTipoRiesgo);
                });

            migrationBuilder.CreateTable(
                name: "Poliza",
                columns: table => new
                {
                    idPoliza = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    inicioVigencia = table.Column<DateTime>(type: "date", nullable: true),
                    periodoCobertura = table.Column<byte>(nullable: true),
                    precio = table.Column<decimal>(type: "money", nullable: true),
                    cobertura = table.Column<decimal>(type: "decimal(18, 0)", nullable: true),
                    idTipoRiesgo = table.Column<byte>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Poliza", x => x.idPoliza);
                    table.ForeignKey(
                        name: "FK_Poliza_TipoRiesgo",
                        column: x => x.idTipoRiesgo,
                        principalTable: "TipoRiesgo",
                        principalColumn: "idTipoRiesgo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClientePoliza",
                columns: table => new
                {
                    idClientePoliza = table.Column<short>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idCliente = table.Column<int>(nullable: true),
                    idPoliza = table.Column<int>(nullable: true),
                    activo = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientePoliza", x => x.idClientePoliza);
                    table.ForeignKey(
                        name: "FK_ClientePoliza_Cliente",
                        column: x => x.idCliente,
                        principalTable: "Cliente",
                        principalColumn: "idCliente",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClientePoliza_Poliza",
                        column: x => x.idPoliza,
                        principalTable: "Poliza",
                        principalColumn: "idPoliza",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PolizaTiposCubrimiento",
                columns: table => new
                {
                    idPolizaTiposCubrimiento = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idTipoCubrimiento = table.Column<byte>(nullable: true),
                    idPoliza = table.Column<int>(nullable: true)
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
                name: "IX_ClientePoliza_idCliente",
                table: "ClientePoliza",
                column: "idCliente");

            migrationBuilder.CreateIndex(
                name: "IX_ClientePoliza_idPoliza",
                table: "ClientePoliza",
                column: "idPoliza");

            migrationBuilder.CreateIndex(
                name: "IX_Poliza_idTipoRiesgo",
                table: "Poliza",
                column: "idTipoRiesgo");

            migrationBuilder.CreateIndex(
                name: "IX_PolizaTiposCubrimiento_idPoliza",
                table: "PolizaTiposCubrimiento",
                column: "idPoliza");

            migrationBuilder.CreateIndex(
                name: "IX_PolizaTiposCubrimiento_idTipoCubrimiento",
                table: "PolizaTiposCubrimiento",
                column: "idTipoCubrimiento");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientePoliza");

            migrationBuilder.DropTable(
                name: "PolizaTiposCubrimiento");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Poliza");

            migrationBuilder.DropTable(
                name: "TipoCubrimiento");

            migrationBuilder.DropTable(
                name: "TipoRiesgo");
        }
    }
}
