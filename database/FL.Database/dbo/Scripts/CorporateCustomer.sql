Print 'Inserting dafault corporate customer'
IF NOT EXISTS (SELECT * FROM [dbo].[CorporateCustomer]  WHERE [AspNetUserId] = 2)
BEGIN
INSERT INTO [dbo].[CorporateCustomer] ([CompanyName], [CompanyAddress], [CompanyPhone], [CompanyFax], [ShippingMethodTypeId], [BuyerName], [AspNetUserId]) 
VALUES ('ABC Technologies', 'Battisputali, Kathmandu', '9840093812','', 2, 'John Doe', 2)
END