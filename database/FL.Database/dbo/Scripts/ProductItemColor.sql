Print 'Inserting dafault product item color'
IF NOT EXISTS (SELECT * FROM [dbo].[ProductItemColor]  WHERE [ProductItemId] = 1 AND [ColorId] = 1)
BEGIN
INSERT INTO [dbo].[ProductItemColor] ([ProductItemId], [ColorId]) VALUES (1, 1)
END

IF NOT EXISTS (SELECT * FROM [dbo].[ProductItemColor]  WHERE [ProductItemId] = 1 AND [ColorId] = 2)
BEGIN
INSERT INTO [dbo].[ProductItemColor] ([ProductItemId], [ColorId]) VALUES (1, 2)
END

IF NOT EXISTS (SELECT * FROM [dbo].[ProductItemColor]  WHERE [ProductItemId] = 2 AND [ColorId] = 1)
BEGIN
INSERT INTO [dbo].[ProductItemColor] ([ProductItemId], [ColorId]) VALUES (2, 1)
END

IF NOT EXISTS (SELECT * FROM [dbo].[ProductItemColor]  WHERE [ProductItemId] = 2 AND [ColorId] = 2)
BEGIN
INSERT INTO [dbo].[ProductItemColor] ([ProductItemId], [ColorId]) VALUES (2, 2)
END

IF NOT EXISTS (SELECT * FROM [dbo].[ProductItemColor]  WHERE [ProductItemId] = 3 AND [ColorId] = 2)
BEGIN
INSERT INTO [dbo].[ProductItemColor] ([ProductItemId], [ColorId]) VALUES (3, 2)
END

IF NOT EXISTS (SELECT * FROM [dbo].[ProductItemColor]  WHERE [ProductItemId] = 3 AND [ColorId] = 3)
BEGIN
INSERT INTO [dbo].[ProductItemColor] ([ProductItemId], [ColorId]) VALUES (3, 3)
END

IF NOT EXISTS (SELECT * FROM [dbo].[ProductItemColor]  WHERE [ProductItemId] = 4 AND [ColorId] = 3)
BEGIN
INSERT INTO [dbo].[ProductItemColor] ([ProductItemId], [ColorId]) VALUES (4, 3)
END

IF NOT EXISTS (SELECT * FROM [dbo].[ProductItemColor]  WHERE [ProductItemId] = 4 AND [ColorId] = 4)
BEGIN
INSERT INTO [dbo].[ProductItemColor] ([ProductItemId], [ColorId]) VALUES (4, 4)
END

IF NOT EXISTS (SELECT * FROM [dbo].[ProductItemColor]  WHERE [ProductItemId] = 5 AND [ColorId] = 4)
BEGIN
INSERT INTO [dbo].[ProductItemColor] ([ProductItemId], [ColorId]) VALUES (5, 4)
END

IF NOT EXISTS (SELECT * FROM [dbo].[ProductItemColor]  WHERE [ProductItemId] = 6 AND [ColorId] = 4)
BEGIN
INSERT INTO [dbo].[ProductItemColor] ([ProductItemId], [ColorId]) VALUES (6, 4)
END

