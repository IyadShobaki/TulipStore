CREATE TABLE [dbo].[Order]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [OrderName] NVARCHAR(50) NOT NULL, 
    [OrderDate] DATETIME2 NOT NULL, 
    [NumberOfItems] INT NOT NULL, 
    [OrderPrice] MONEY NOT NULL
)
