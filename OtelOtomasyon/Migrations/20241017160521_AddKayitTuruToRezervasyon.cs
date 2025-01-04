using Microsoft.EntityFrameworkCore.Migrations;

namespace OtelOtomasyon.Migrations
{
    public partial class AddKayitTuruToRezervasyon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KayitTuruID",
                table: "Rezervasyonlar",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KayitTuruID",
                table: "Rezervasyonlar");
        }
    }
}
