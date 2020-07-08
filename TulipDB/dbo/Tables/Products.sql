﻿CREATE TABLE [dbo].[Products]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ProductName] NVARCHAR(50) NOT NULL,  
    [ProductPrice] MONEY NOT NULL, 
    [ProductImage] IMAGE NOT NULL
)
