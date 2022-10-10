using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UserManagement.Data.Migrations
{
    public partial class AddAdminUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [Security].[users] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [FirstName], [LastName], [ProfilePicture]) VALUES (N'871a07cf-14a2-4b67-b4cb-8368212a34f5', N'admin', N'ADMIN', N'admin@test.com', N'ADMIN@TEST.COM', 0, N'AQAAAAEAACcQAAAAEI7WcOehXqatS9pe+EOra6/EYvLMnk+8nakeQTSoY2xVTwCIYkde1RQ5oIo86kJPWw==', N'K3LJWUVSHV3GTS3ALWLY5T647YDTD6MU', N'b9efbb1a-922e-45c8-a838-25ad3c1decb6', NULL, 0, 0, NULL, 1, 0, N'Mohamed', N'Nabil', NULL)\r\n");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [Sequrity].[Users] WHERE Id = '871a07cf-14a2-4b67-b4cb-8368212a34f5'");
        }
    }
}
