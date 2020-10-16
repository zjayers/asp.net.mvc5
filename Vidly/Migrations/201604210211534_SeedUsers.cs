using System.Data.Entity.Migrations;

namespace Vidly.Migrations
{
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'c5768331-4c17-42ca-863a-c8a299df2867', N'administrator@vidly.com', 0, N'ACLWmvWBsHlp9f5UMtf11MhhsPiNG+aG9VrKrUk+ZWAm/NKnw4eVbiLIhB57UoijiA==', N'13fbe8ea-234f-4d61-9314-bbd05d9d2bd1', NULL, 0, 0, NULL, 1, 0, N'administrator@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b38fafbd-3156-440a-88ab-851b2433fefc', N'guest@vidly.com', 0, N'AAW9NIqUYk2fzp4xEofrNRiTM0FFUYrdZvL86YXBk4OVCjikqSAWUQytHgek+Cl4yA==', N'bb97d846-7e91-4b40-a1cd-94e996ffa47c', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'df696c9b-fa26-4f46-b2b1-ad753ea50361', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'c5768331-4c17-42ca-863a-c8a299df2867', N'df696c9b-fa26-4f46-b2b1-ad753ea50361')
");
        }

        public override void Down()
        {
        }
    }
}