CREATE PROCEDURE [dbo].[spCart_All]
	@Id int
AS
begin
	
	set nocount on;

	select [Id], [ProductName], [ProductId], [Quantity], [Total], [OrderId]
	from dbo.Cart
	where [OrderId] = @Id;

end
