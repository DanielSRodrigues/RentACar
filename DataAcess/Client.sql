﻿CREATE TABLE [dbo].[Client]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] VARCHAR(150) NULL, 
    [CPF] NCHAR(12) NULL, 
    [Adress] NVARCHAR(150) NULL
)
