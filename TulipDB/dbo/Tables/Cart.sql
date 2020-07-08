﻿CREATE TABLE [dbo].[Cart]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ProductName] NVARCHAR(50) NOT NULL, 
    [ProductId] INT NOT NULL, 
    [Quantity] INT NOT NULL, 
    [Total] MONEY NOT NULL, 
    CONSTRAINT [FK_Cart_Products] FOREIGN KEY ([ProductId]) REFERENCES Products(Id)
)
