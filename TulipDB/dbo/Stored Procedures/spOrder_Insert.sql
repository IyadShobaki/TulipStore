CREATE PROCEDURE [dbo].[spOrder_Insert]
	@OrderName nvarchar(50),
	@OrderDate datetime2(7),
	@NumberOfItems int,
	@OrderPrice money,
	@Id int output
AS
begin
	set nocount on;

	insert into dbo.[Order](OrderName, OrderDate, NumberOfItems, OrderPrice)
	values (@OrderName, @OrderDate, @NumberOfItems, @OrderPrice);

	set @Id = SCOPE_IDENTITY();

end
