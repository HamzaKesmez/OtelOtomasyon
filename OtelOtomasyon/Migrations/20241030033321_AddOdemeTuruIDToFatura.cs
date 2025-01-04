using Microsoft.EntityFrameworkCore.Migrations;

namespace OtelOtomasyon.Migrations
{
    public partial class AddOdemeTuruIDToFatura : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OdemeTuruID",
                table: "Faturalar",
                nullable: true // Eğer zorunluysa, `nullable: false` ve default değer verebilirsiniz.
            );

            migrationBuilder.CreateIndex(
                name: "IX_Faturalar_OdemeTuruID",
                table: "Faturalar",
                column: "OdemeTuruID"
            );

            migrationBuilder.AddForeignKey(
                name: "FK_Faturalar_Odemeler_OdemeTuruID",
                table: "Faturalar",
                column: "OdemeTuruID",
                principalTable: "Odemeler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Faturalar_Odemeler_OdemeTuruID",
                table: "Faturalar"
            );

            migrationBuilder.DropIndex(
                name: "IX_Faturalar_OdemeTuruID",
                table: "Faturalar"
            );

            migrationBuilder.DropColumn(
                name: "OdemeTuruID",
                table: "Faturalar"
            );
        }
    }
}
