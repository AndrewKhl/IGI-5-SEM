using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAuction.Migrations
{
    public partial class user : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Cash",
                table: "Users",
                nullable: false,
                oldClrType: typeof(decimal));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Cash",
                table: "Users",
                nullable: false,
                oldClrType: typeof(double));
        }
    }
}
