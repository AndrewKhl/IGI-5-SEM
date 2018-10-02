using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAuction.Migrations
{
    public partial class new_cost : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "StartPrice",
                table: "Lots",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<double>(
                name: "RedemptionPrice",
                table: "Lots",
                nullable: false,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "StartPrice",
                table: "Lots",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<int>(
                name: "RedemptionPrice",
                table: "Lots",
                nullable: false,
                oldClrType: typeof(double));
        }
    }
}
