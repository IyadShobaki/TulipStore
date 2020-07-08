CREATE PROCEDURE [dbo].[spCart_Insert]
	@ProductName nvarchar(50),
	@ProductId int,
	@Quantity int,
	@Total money,
	@Id int output

AS
begin
	set nocount on;

	insert into dbo.Cart(ProductName, ProductId, Quantity, Total)
	values (@ProductName, @ProductId, @Quantity, @Total);

	set @Id = SCOPE_IDENTITY();
end
