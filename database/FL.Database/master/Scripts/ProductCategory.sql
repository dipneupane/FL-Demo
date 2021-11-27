Print 'Inserting dafault categories'
IF NOT EXISTS (SELECT * FROM [master].[ProductCategory]  WHERE [Name] = 'CorporateFurniture')
BEGIN
INSERT INTO [master].[ProductCategory] ([Slug], [Name]) VALUES ('corporate-furniture', 'CorporateFurniture')
END

IF NOT EXISTS (SELECT * FROM [master].[ProductCategory]  WHERE [Name] = 'HomeOfficeFurniture')
BEGIN
INSERT INTO [master].[ProductCategory] ([Slug], [Name]) VALUES ('home-office-furniture', 'HomeOfficeFurniture')
END

IF NOT EXISTS (SELECT * FROM [master].[ProductCategory]  WHERE [Name] = 'SchoolFurniture')
BEGIN
INSERT INTO [master].[ProductCategory] ([Slug], [Name]) VALUES ('school-furniture', 'SchoolFurniture')
END