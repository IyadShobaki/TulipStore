CREATE PROCEDURE [dbo].[spOrders_All]

AS
begin 
	
	set nocount on;

	select [Id], [OrderName], [OrderDate], [NumberOfItems], [OrderPrice]
	from dbo.[Order]

end
