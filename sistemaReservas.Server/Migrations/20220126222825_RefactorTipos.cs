using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sistemaReservas.Server.Migrations
{
    public partial class RefactorTipos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sillas_TiposSilla_TipoIdTipoSilla",
                table: "Sillas");

            migrationBuilder.DropTable(
                name: "TiposSilla");

            migrationBuilder.RenameColumn(
                name: "TipoIdTipoSilla",
                table: "Sillas",
                newName: "TipoIdTipoMesa");

            migrationBuilder.RenameIndex(
                name: "IX_Sillas_TipoIdTipoSilla",
                table: "Sillas",
                newName: "IX_Sillas_TipoIdTipoMesa");

            migrationBuilder.CreateTable(
                name: "TipoMesa",
                columns: table => new
                {
                    IdTipoMesa = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Precio = table.Column<decimal>(type: "TEXT", nullable: false),
                    Color = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoMesa", x => x.IdTipoMesa);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Sillas_TipoMesa_TipoIdTipoMesa",
                table: "Sillas",
                column: "TipoIdTipoMesa",
                principalTable: "TipoMesa",
                principalColumn: "IdTipoMesa",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sillas_TipoMesa_TipoIdTipoMesa",
                table: "Sillas");

            migrationBuilder.DropTable(
                name: "TipoMesa");

            migrationBuilder.RenameColumn(
                name: "TipoIdTipoMesa",
                table: "Sillas",
                newName: "TipoIdTipoSilla");

            migrationBuilder.RenameIndex(
                name: "IX_Sillas_TipoIdTipoMesa",
                table: "Sillas",
                newName: "IX_Sillas_TipoIdTipoSilla");

            migrationBuilder.CreateTable(
                name: "TiposSilla",
                columns: table => new
                {
                    IdTipoSilla = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Precio = table.Column<decimal>(type: "TEXT", nullable: false),
                    Tipo = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposSilla", x => x.IdTipoSilla);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Sillas_TiposSilla_TipoIdTipoSilla",
                table: "Sillas",
                column: "TipoIdTipoSilla",
                principalTable: "TiposSilla",
                principalColumn: "IdTipoSilla",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
