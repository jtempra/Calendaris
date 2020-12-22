using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Calendaris.Server.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CalendarisFestes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data = table.Column<DateTime>(type: "Date", nullable: false),
                    Festa = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Tipus = table.Column<int>(type: "int", nullable: false),
                    Observacions = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalendarisFestes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Convenis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codi = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Nom = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    HoresAnuals = table.Column<int>(type: "int", nullable: false),
                    DataInici = table.Column<DateTime>(type: "Date", nullable: false),
                    DataFinal = table.Column<DateTime>(type: "Date", nullable: false),
                    Observacions = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Convenis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Treballadors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codi = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Nom = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    PrimerCognom = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    SegonCognom = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    NIF = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    NSS = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    Adreça = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    CP = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    Poblacio = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Provincia = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Telefon1 = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    Telefon2 = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    Telefon3 = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    Mobil1 = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    Mobil2 = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    Mobil3 = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    Email1 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Email2 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Email3 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Centre = table.Column<int>(type: "int", nullable: false),
                    Departament = table.Column<int>(type: "int", nullable: false),
                    DataAlta = table.Column<DateTime>(type: "Date", nullable: false),
                    DataBaixa = table.Column<DateTime>(type: "Date", nullable: true),
                    Observacions = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Treballadors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CalendarisTreballador",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TreballadorId = table.Column<int>(type: "int", nullable: true),
                    Any = table.Column<int>(type: "int", nullable: false),
                    DataConfeccio = table.Column<DateTime>(type: "Date", nullable: false),
                    Observacions = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalendarisTreballador", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CalendarisTreballador_Treballadors_TreballadorId",
                        column: x => x.TreballadorId,
                        principalTable: "Treballadors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ConvenisTreballador",
                columns: table => new
                {
                    ConveniId = table.Column<int>(type: "int", nullable: false),
                    TreballadorId = table.Column<int>(type: "int", nullable: false),
                    DataInici = table.Column<DateTime>(type: "Date", nullable: false),
                    DataFinal = table.Column<DateTime>(type: "Date", nullable: false),
                    Observacions = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConvenisTreballador", x => new { x.ConveniId, x.TreballadorId });
                    table.ForeignKey(
                        name: "FK_ConvenisTreballador_Convenis_ConveniId",
                        column: x => x.ConveniId,
                        principalTable: "Convenis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConvenisTreballador_Treballadors_TreballadorId",
                        column: x => x.TreballadorId,
                        principalTable: "Treballadors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlantillesCalendari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TreballadorId = table.Column<int>(type: "int", nullable: true),
                    DataInici = table.Column<DateTime>(type: "Date", nullable: false),
                    DataFinal = table.Column<DateTime>(type: "Date", nullable: true),
                    Observacions = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlantillesCalendari", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlantillesCalendari_Treballadors_TreballadorId",
                        column: x => x.TreballadorId,
                        principalTable: "Treballadors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DetallsCalendariTreballador",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataInicial = table.Column<DateTime>(type: "Date", nullable: false),
                    DataFinal = table.Column<DateTime>(type: "Date", nullable: false),
                    HoraInici1 = table.Column<DateTime>(type: "DateTime", nullable: false),
                    HoraFinal1 = table.Column<DateTime>(type: "DateTime", nullable: false),
                    HoraInici2 = table.Column<DateTime>(type: "DateTime", nullable: false),
                    HoraFinal2 = table.Column<DateTime>(type: "DateTime", nullable: false),
                    HoraInici3 = table.Column<DateTime>(type: "DateTime", nullable: false),
                    HoraFinal3 = table.Column<DateTime>(type: "DateTime", nullable: false),
                    Vacances = table.Column<bool>(type: "bit", nullable: false),
                    Observacions = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    CalendariTreballadorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetallsCalendariTreballador", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetallsCalendariTreballador_CalendarisTreballador_CalendariTreballadorId",
                        column: x => x.CalendariTreballadorId,
                        principalTable: "CalendarisTreballador",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DetallsPlantillaCalendari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataInicial = table.Column<DateTime>(type: "Date", nullable: false),
                    DataFinal = table.Column<DateTime>(type: "Date", nullable: false),
                    HoraInici1 = table.Column<DateTime>(type: "DateTime", nullable: false),
                    HoraFinal1 = table.Column<DateTime>(type: "DateTime", nullable: false),
                    HoraInici2 = table.Column<DateTime>(type: "DateTime", nullable: false),
                    HoraFinal2 = table.Column<DateTime>(type: "DateTime", nullable: false),
                    HoraInici3 = table.Column<DateTime>(type: "DateTime", nullable: false),
                    HoraFinal3 = table.Column<DateTime>(type: "DateTime", nullable: false),
                    Vacances = table.Column<bool>(type: "bit", nullable: false),
                    Observacions = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    PlantillaCalendariId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetallsPlantillaCalendari", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetallsPlantillaCalendari_PlantillesCalendari_PlantillaCalendariId",
                        column: x => x.PlantillaCalendariId,
                        principalTable: "PlantillesCalendari",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "CalendarisFestes",
                columns: new[] { "Id", "Data", "Festa", "Observacions", "Tipus" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cap d'Any", null, 2 },
                    { 2, new DateTime(2021, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Reis", null, 2 },
                    { 3, new DateTime(2021, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Divendres Sant", null, 2 },
                    { 4, new DateTime(2021, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dilluns de Pasqua", null, 2 },
                    { 5, new DateTime(2021, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Primer de Maig", null, 2 },
                    { 6, new DateTime(2021, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sant Joan", null, 2 },
                    { 7, new DateTime(2021, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Diada Nacional de CAT", null, 2 },
                    { 8, new DateTime(2021, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fiesta Nasiona Nyorda", null, 3 },
                    { 9, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tots Sants", null, 2 },
                    { 10, new DateTime(2021, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dia de la Constitucion Nyorda", null, 3 },
                    { 11, new DateTime(2021, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "La Immaculada", null, 2 },
                    { 12, new DateTime(2021, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nadal", null, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CalendarisTreballador_TreballadorId",
                table: "CalendarisTreballador",
                column: "TreballadorId");

            migrationBuilder.CreateIndex(
                name: "IX_ConvenisTreballador_TreballadorId",
                table: "ConvenisTreballador",
                column: "TreballadorId");

            migrationBuilder.CreateIndex(
                name: "IX_DetallsCalendariTreballador_CalendariTreballadorId",
                table: "DetallsCalendariTreballador",
                column: "CalendariTreballadorId");

            migrationBuilder.CreateIndex(
                name: "IX_DetallsPlantillaCalendari_PlantillaCalendariId",
                table: "DetallsPlantillaCalendari",
                column: "PlantillaCalendariId");

            migrationBuilder.CreateIndex(
                name: "IX_PlantillesCalendari_TreballadorId",
                table: "PlantillesCalendari",
                column: "TreballadorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CalendarisFestes");

            migrationBuilder.DropTable(
                name: "ConvenisTreballador");

            migrationBuilder.DropTable(
                name: "DetallsCalendariTreballador");

            migrationBuilder.DropTable(
                name: "DetallsPlantillaCalendari");

            migrationBuilder.DropTable(
                name: "Convenis");

            migrationBuilder.DropTable(
                name: "CalendarisTreballador");

            migrationBuilder.DropTable(
                name: "PlantillesCalendari");

            migrationBuilder.DropTable(
                name: "Treballadors");
        }
    }
}
