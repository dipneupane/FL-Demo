Print 'Inserting dafault office customer'
IF NOT EXISTS (SELECT * FROM [dbo].[OfficeCustomer]  WHERE [AspNetUserId] = 2)
BEGIN
INSERT INTO [dbo].[OfficeCustomer] ([CompanyName], [CompanyAddress], [CompanyFax],[BuyerName], [AspNetUserId]) 
VALUES ('XYZ Technologies', 'New Baneswor, Kathmandu', '', 'Manish Neupane', 2)
END