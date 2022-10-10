using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UserManagement.Data.Migrations
{
    public partial class AssignAdminUserToAllRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [Security].[UserRoles] (UserId, RoleId) SELECT '871a07cf-14a2-4b67-b4cb-8368212a34f5', Id FROM [Security].[Roles] ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [Security].[UserRoles] WHERE UserId = '871a07cf-14a2-4b67-b4cb-8368212a34f5' ");
        }
    }
}
