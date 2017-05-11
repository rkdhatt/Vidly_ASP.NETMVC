namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'3a0510ba-a95f-4536-8023-700e661981ad', N'admin@vidly.com', 0, N'ANDTe+OoqaRgBiJIIv4QVkc5ihIG0rT6lJohOdza6H/43a5MZ18LF/cq/bXZBLRYSg==', N'4871cece-96d7-46ed-9ae7-00f5b5f50d8d', NULL, 0, 0, NULL, 1, 0, N'admin_@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'c16cb0b3-8966-441d-a9a2-e1d8c3df0265', N'guest@vidly.com', 0, N'ADHnID6lotUlCG83Mra70wvF8V/wLBHq6h02adCUSf5vsFDzqAk7wiY2ghn7+pOc4w==', N'127d2a25-5ccc-4233-bdce-67c8bd8e181d', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'59720c12-2ed5-4d81-bb81-98bd1f5fc804', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'3a0510ba-a95f-4536-8023-700e661981ad', N'59720c12-2ed5-4d81-bb81-98bd1f5fc804')

            ");
        }
        
        public override void Down()
        {
        }
    }
}
