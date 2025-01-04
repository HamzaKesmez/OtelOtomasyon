using Microsoft.EntityFrameworkCore.Migrations;

namespace OtelOtomasyon.Migrations
{
    public partial class OdaTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KatNo",
                table: "Odalar",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KatNo",
                table: "Odalar");
        }
    }
}
