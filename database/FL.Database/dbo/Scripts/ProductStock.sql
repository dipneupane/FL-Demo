Print 'Inserting dafault product stocks'
IF NOT EXISTS (SELECT * FROM [dbo].[ProductStock]  WHERE [ProductItemId] = 1)
BEGIN
INSERT INTO [dbo].[ProductStock] ([ProductItemId], [Quantity], [UpdatedDate]) 
VALUES (1, 12, '2021-01-12')
END

IF NOT EXISTS (SELECT * FROM [dbo].[ProductStock]  WHERE [ProductItemId] = 2)
BEGIN
INSERT INTO [dbo].[ProductStock] ([ProductItemId], [Quantity], [UpdatedDate]) 
VALUES (2, 18, '2021-11-13')
END

IF NOT EXISTS (SELECT * FROM [dbo].[ProductStock]  WHERE [ProductItemId] = 3)
BEGIN
INSERT INTO [dbo].[ProductStock] ([ProductItemId], [Quantity], [UpdatedDate]) 
VALUES (3, 7, '2021-11-13')
END

IF NOT EXISTS (SELECT * FROM [dbo].[ProductStock]  WHERE [ProductItemId] = 4)
BEGIN
INSERT INTO [dbo].[ProductStock] ([ProductItemId], [Quantity], [UpdatedDate]) 
VALUES (4,23, '2021-11-29')
END

IF NOT EXISTS (SELECT * FROM [dbo].[ProductStock]  WHERE [ProductItemId] = 5)
BEGIN
INSERT INTO [dbo].[ProductStock] ([ProductItemId], [Quantity], [UpdatedDate]) 
VALUES (5,10, '2021-11-12')
END

IF NOT EXISTS (SELECT * FROM [dbo].[ProductStock]  WHERE [ProductItemId] = 6)
BEGIN
INSERT INTO [dbo].[ProductStock] ([ProductItemId], [Quantity], [UpdatedDate]) 
VALUES (6, 13, '2021-11-23')
END