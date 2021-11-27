Print 'Inserting dafault product items'
IF NOT EXISTS (SELECT * FROM [dbo].[ProductItem]  WHERE [Slug] = 'sofa')
BEGIN
INSERT INTO [dbo].[ProductItem] ([ProductCategoryId], [Slug], [Name], [Description], [Size], [Weight], [Price]) 
VALUES (1, 'sofa', 'Sofa', 'Descriptions here', '36” width x 34” height', '134 lb', 12000)
END

IF NOT EXISTS (SELECT * FROM [dbo].[ProductItem]  WHERE [Slug] = 'deck-chair')
BEGIN
INSERT INTO [dbo].[ProductItem] ([ProductCategoryId], [Slug], [Name], [Description], [Size], [Weight], [Price]) 
VALUES (1, 'deck-chair', 'Deck chair', 'Descriptions here', '36” width x 34” height', '134 lb', 14500)
END


IF NOT EXISTS (SELECT * FROM [dbo].[ProductItem]  WHERE [Slug] = 'executive-chair')
BEGIN
INSERT INTO [dbo].[ProductItem] ([ProductCategoryId], [Slug], [Name], [Description], [Size], [Weight], [Price]) 
VALUES (2, 'executive-chair', 'Executive chair', 'Descriptions here', '36” width x 34” height', '134 lb', 11000)
END

IF NOT EXISTS (SELECT * FROM [dbo].[ProductItem]  WHERE [Slug] = 'upholstered-bench')
BEGIN
INSERT INTO [dbo].[ProductItem] ([ProductCategoryId], [Slug], [Name], [Description], [Size], [Weight], [Price]) 
VALUES (2, 'upholstered-bench', 'Upholstered bench', 'Descriptions here', '36” width x 34” height', '134 lb', 8500)
END


IF NOT EXISTS (SELECT * FROM [dbo].[ProductItem]  WHERE [Slug] = 'student-chair')
BEGIN
INSERT INTO [dbo].[ProductItem] ([ProductCategoryId], [Slug], [Name], [Description], [Size], [Weight], [Price]) 
VALUES (3, 'student-chair', 'Student chair', 'Descriptions here', '36” width x 34” height', '134 lb', 4500)
END

IF NOT EXISTS (SELECT * FROM [dbo].[ProductItem]  WHERE [Slug] = 'waiting-room-seat')
BEGIN
INSERT INTO [dbo].[ProductItem] ([ProductCategoryId], [Slug], [Name], [Description], [Size], [Weight], [Price]) 
VALUES (3, 'waiting-room-seat', 'Waiting room seat', 'Descriptions here', '36” width x 34” height', '134 lb', 7500)
END