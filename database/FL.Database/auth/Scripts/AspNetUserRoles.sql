Print 'Inserting AspNetUserRoles'
IF NOT EXISTS (SELECT * FROM [auth].[AspNetUserRoles]  WHERE [UserId] = '1')
BEGIN
INSERT INTO [auth].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (1, 1)
END

IF NOT EXISTS (SELECT * FROM [auth].[AspNetUserRoles]  WHERE [UserId] = '2')
BEGIN
INSERT INTO [auth].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (2, 2)
END
