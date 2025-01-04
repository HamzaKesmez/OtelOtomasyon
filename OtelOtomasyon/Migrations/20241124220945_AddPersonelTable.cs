using Microsoft.EntityFrameworkCore.Migrations;

namespace OtelOtomasyon.Migrations
{
    public partial class AddPersonelTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Parola",
                table: "Personeller",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Parola",
                table: "Personeller");
        }
    }
}
