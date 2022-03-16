using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sistemaReservas.Server.Migrations
{
    public partial class EstadoSillas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Estado",
                table: "Sillas",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Sillas");
        }
    }
}
