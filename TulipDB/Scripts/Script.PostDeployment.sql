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
if not exists (select * from dbo.Products)
begin
    
    insert into dbo.Products(ProductName, ProductPrice, ProductImage)
    values ('Hot Sale Fashion Simple Shirts', 24.99, (SELECT * FROM OPENROWSET(BULK N'D:\tulip\mensimpleshirt.jpg', SINGLE_BLOB) as T1)),
    ('Wrangler Slim Men Blue Jeans', 29.99,  (SELECT * FROM OPENROWSET(BULK N'D:\tulip\menbluejeans.jpg', SINGLE_BLOB) as T1)),
    ('Cyamo Short Peat', 19.99, (SELECT * FROM OPENROWSET(BULK N'D:\tulip\menshort.jpg', SINGLE_BLOB) as T1)),
    ('New Fashion Casual Blazer', 39.99,   (SELECT * FROM OPENROWSET(BULK N'D:\tulip\menblazer.jpg', SINGLE_BLOB) as T1)),
    ('Carven Navy', 49.99, (SELECT * FROM OPENROWSET(BULK N'D:\tulip\mennavy.jpg', SINGLE_BLOB) as T1)),
    ('Men Denim Jeans', 33.99,  (SELECT * FROM OPENROWSET(BULK N'D:\tulip\mendenimjeans.jpg', SINGLE_BLOB) as T1));

end