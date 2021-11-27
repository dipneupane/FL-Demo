Print 'Inserting dafault student customer'
IF NOT EXISTS (SELECT * FROM [dbo].[StudentCustomer]  WHERE [AspNetUserId] = 2)
BEGIN
INSERT INTO [dbo].[StudentCustomer] ([Name], [School], [Address], [AspNetUserId]) 
VALUES ('Vikrant Kumar', 'Pioneers Academy', 'Waling, Syangja', 2)
END