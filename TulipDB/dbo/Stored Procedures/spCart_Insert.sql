CREATE PROCEDURE [dbo].[spCart_Insert]
	@ProductName nvarchar(50),
	@ProductId int,
	@Quantity int,
	@Total money,
	@OrderId int,
	@Id int output

AS
begin
	set nocount on;

	insert into dbo.Cart(ProductName, ProductId, Quantity, Total, OrderId)
	values (@ProductName, @ProductId, @Quantity, @Total, @OrderId);

	set @Id = SCOPE_IDENTITY();
end
