using Microsoft.EntityFrameworkCore.Migrations;
using static UserManagement.Data.Enums;

#nullable disable

namespace UserManagement.Data.Migrations
{
    public partial class SeedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "NormalizedName", "ConcurrencyStamp" },
                values: new object[] { Guid.NewGuid().ToString(), Roles.User.ToString(), Roles.User.ToString().ToUpper(), Guid.NewGuid().ToString() },
                schema: "Security"
            );
            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "NormalizedName", "ConcurrencyStamp" },
                values: new object[] { Guid.NewGuid().ToString(), Roles.Admin.ToString(), Roles.Admin.ToString().ToUpper(), Guid.NewGuid().ToString() },
                schema: "Security"
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [Security].[Roles]");
        }
    }
}
