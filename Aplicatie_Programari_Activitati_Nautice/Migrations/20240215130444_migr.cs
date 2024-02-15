using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aplicatie_Programari_Activitati_Nautice.Migrations
{
    public partial class migr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PretTotal",
                table: "Programare");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "PretTotal",
                table: "Programare",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
