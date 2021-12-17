using Microsoft.EntityFrameworkCore.Migrations;

namespace Criptomonedas.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "ValorMaximo",
                table: "CriptoItems",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorActual",
                table: "CriptoItems",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "ValorMaximo",
                table: "CriptoItems",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<double>(
                name: "ValorActual",
                table: "CriptoItems",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }
    }
}
