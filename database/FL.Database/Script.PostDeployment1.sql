/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

GO
:r .\auth\Scripts\AspNetUsers.sql
:r .\auth\Scripts\AspNetRoles.sql
:r .\auth\Scripts\AspNetUserRoles.sql

:r .\master\Scripts\Color.sql
:r .\master\Scripts\ProductCategory.sql

:r .\dbo\Scripts\CorporateCustomer.sql
:r .\dbo\Scripts\OfficeCustomer.sql
:r .\dbo\Scripts\StudentCustomer.sql
:r .\dbo\Scripts\ProductItem.sql
:r .\dbo\Scripts\ProductItemColor.sql
:r .\dbo\Scripts\ProductStock.sql

