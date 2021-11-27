Print 'Inserting dafault color'
IF NOT EXISTS (SELECT * FROM [master].[Color]  WHERE [Name] = 'Red')
BEGIN
INSERT INTO [master].[Color] ([Name], [ColorCode]) VALUES ('Red', '#ff4c4c')
END

IF NOT EXISTS (SELECT * FROM [master].[Color]  WHERE [Name] = 'Yellow')
BEGIN
INSERT INTO [master].[Color] ([Name], [ColorCode]) VALUES ('Yellow', '#ffdd00')
END

IF NOT EXISTS (SELECT * FROM [master].[Color]  WHERE [Name] = 'Black')
BEGIN
INSERT INTO [master].[Color] ([Name], [ColorCode]) VALUES ('Black', '#050f2c')
END

IF NOT EXISTS (SELECT * FROM [master].[Color]  WHERE [Name] = 'SkyBlue')
BEGIN
INSERT INTO [master].[Color] ([Name], [ColorCode]) VALUES ('SkyBlue', '#3369e7')
END