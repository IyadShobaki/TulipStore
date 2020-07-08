CREATE PROCEDURE [dbo].[spProducts_All]

AS
begin 
	
	set nocount on;

	select [Id], [ProductName], [ProductPrice], [ProductImage]
	from dbo.Products

end
