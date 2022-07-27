using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheLoanProviders.Migrations
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "newuserfname",
                table: "login",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "newuserfname",
                table: "login");
        }
    }
}
