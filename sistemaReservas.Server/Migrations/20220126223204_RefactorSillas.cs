using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sistemaReservas.Server.Migrations
{
    public partial class RefactorSillas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sillas_TipoMesa_TipoIdTipoMesa",
                table: "Sillas");

            migrationBuilder.DropIndex(
                name: "IX_Sillas_TipoIdTipoMesa",
                table: "Sillas");

            migrationBuilder.DropColumn(
                name: "TipoIdTipoMesa",
                table: "Sillas");

            migrationBuilder.AddColumn<int>(
                name: "CategoriaIdTipoMesa",
                table: "Mesas",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Mesas_CategoriaIdTipoMesa",
                table: "Mesas",
                column: "CategoriaIdTipoMesa");

            migrationBuilder.AddForeignKey(
                name: "FK_Mesas_TipoMesa_CategoriaIdTipoMesa",
                table: "Mesas",
                column: "CategoriaIdTipoMesa",
                principalTable: "TipoMesa",
                principalColumn: "IdTipoMesa",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mesas_TipoMesa_CategoriaIdTipoMesa",
                table: "Mesas");

            migrationBuilder.DropIndex(
                name: "IX_Mesas_CategoriaIdTipoMesa",
                table: "Mesas");

            migrationBuilder.DropColumn(
                name: "CategoriaIdTipoMesa",
                table: "Mesas");

            migrationBuilder.AddColumn<int>(
                name: "TipoIdTipoMesa",
                table: "Sillas",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Sillas_TipoIdTipoMesa",
                table: "Sillas",
                column: "TipoIdTipoMesa");

            migrationBuilder.AddForeignKey(
                name: "FK_Sillas_TipoMesa_TipoIdTipoMesa",
                table: "Sillas",
                column: "TipoIdTipoMesa",
                principalTable: "TipoMesa",
                principalColumn: "IdTipoMesa",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
