CREATE PROCEDURE [dbo].[spCart_Delete]
	@Id int
AS
begin
	set nocount on;

	delete 
	from dbo.Cart
	where OrderId = @Id;

end
