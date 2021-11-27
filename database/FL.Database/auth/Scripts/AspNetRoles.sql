Print 'Inserting AspNetRoles'
IF NOT EXISTS (SELECT * FROM [auth].[AspNetRoles]  WHERE [Name] = 'Admin')
BEGIN
INSERT INTO [auth].[AspNetRoles] ([Name], [NormalizedName], [ConcurrencyStamp]) VALUES ('Admin', 'ADMIN', '02458bfb-1a30-4f32-452a-a0ee910e6f6d')
END
IF NOT EXISTS (SELECT * FROM [auth].[AspNetRoles]  WHERE [Name] = 'Customer')
BEGIN
INSERT INTO [auth].[AspNetRoles] ([Name], [NormalizedName], [ConcurrencyStamp]) VALUES ('Customer', 'CUSTOMER', '02458bfb-1a30-4f32-452a-a0ee910e6d1d')
END