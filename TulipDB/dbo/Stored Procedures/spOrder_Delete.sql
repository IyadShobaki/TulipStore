CREATE PROCEDURE [dbo].[spOrder_Delete]
	@Id int
AS
begin
	set nocount on;

	delete 
	from dbo.[Order]
	where Id = @Id;

end
