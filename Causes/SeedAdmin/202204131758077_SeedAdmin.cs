// When creating a project we can use these lines in a migration, to create a default admin and guest users

/*        public override void Up()
        {
            Sql(@"
        INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'9c00880e-6932-4928-b6da-f42557912833', N'guest@guest.com', 0, N'AEnK6QtSjRtqTGu2ql51z1OFbEm8IPhuF+z1avPMuwqAV7TUZZiFb0vIll85rcqLbw==', N'b7f263e9-3903-4ef5-a125-b6dd42260f4a', NULL, 0, 0, NULL, 1, 0, N'guest@guest.com')
        INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'c05d4530-a1a2-4218-a381-eb676b9adaf7', N'admin@admin.com', 0, N'AA3pPxhrhJvR4Z9E9rYcgMxYTLSqVs4ihP4lpV9Ehouq4W94dQjtr4uh34szukO4iQ==', N'e7402020-3b08-4015-a80d-4513cff5742d', NULL, 0, 0, NULL, 1, 0, N'admin@admin.com')
        INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'fc89c6a6-59af-476f-bede-83bd98c16ce6', N'CanManageCauses')
        INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'c05d4530-a1a2-4218-a381-eb676b9adaf7', N'fc89c6a6-59af-476f-bede-83bd98c16ce6')


");
 */
