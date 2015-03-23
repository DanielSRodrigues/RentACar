CREATE TABLE [dbo].[Car]
(
	[Id] BIGINT NOT NULL PRIMARY KEY, 
    [Model] VARCHAR(50) NOT NULL, 
    [Year] BIGINT NOT NULL, 
    [Mileage] BIGINT NOT NULL, 
    [Board] NCHAR(10) NOT NULL
)
