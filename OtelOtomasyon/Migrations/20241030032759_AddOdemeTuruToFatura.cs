using Microsoft.EntityFrameworkCore.Migrations;

namespace OtelOtomasyon.Migrations
{
    public partial class AddOdemeTuruToFatura : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OdemeTurId",
                table: "Faturalar",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Faturalar_OdemeTurId",
                table: "Faturalar",
                column: "OdemeTurId");

            migrationBuilder.AddForeignKey(
                name: "FK_Faturalar_Odemeler_OdemeTurId",
                table: "Faturalar",
                column: "OdemeTurId",
                principalTable: "Odemeler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Faturalar_Odemeler_OdemeTurId",
                table: "Faturalar");

            migrationBuilder.DropIndex(
                name: "IX_Faturalar_OdemeTurId",
                table: "Faturalar");

            migrationBuilder.DropColumn(
                name: "OdemeTurId",
                table: "Faturalar");
        }
    }
}
