using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheLoanProviders.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "upass",
                table: "login",
                newName: "newuserpass");

            migrationBuilder.RenameColumn(
                name: "uname",
                table: "login",
                newName: "newusername");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "newuserpass",
                table: "login",
                newName: "upass");

            migrationBuilder.RenameColumn(
                name: "newusername",
                table: "login",
                newName: "uname");
        }
    }
}
