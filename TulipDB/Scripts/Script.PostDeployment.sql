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
    values ('Hot Sale Fashion Simple Shirts', 24.99, '~/Images/mensimpleshirt.jpg'),
    ('Wrangler Slim Men Blue Jeans', 29.99,  '~/Images/menbluejeans.jpg'),
    ('Cyamo Short Peat', 19.99, '~/Images/menshort.jpg'),
    ('New Fashion Casual Blazer', 39.99,  '~/Images/menblazer.jpg'),
    ('Carven Navy', 49.99, '~/Images/mennavy.jpg'),
    ('Men Denim Jeans', 33.99,'~/Images/mendenimjeans.jpg');

end