CREATE PROCEDURE [dbo].[spOrder_GetMaxID]

AS
begin 
	
	set nocount on;

	select [Id], [OrderName], [OrderDate], [NumberOfItems], [OrderPrice]
	from dbo.[Order]
	where Id = (select max(Id) from dbo.[Order]);

end
