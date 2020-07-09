CREATE PROCEDURE [dbo].[spOrder_Update]
	@Id int,
	@NumberOfItems int,
	@OrderPrice money
AS
begin
	set nocount on;

	update dbo.[Order]
	set NumberOfItems = @NumberOfItems, OrderPrice = @OrderPrice
	where Id = @Id;

end
