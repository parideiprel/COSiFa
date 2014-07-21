CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Catalogo] VARCHAR(4) NOT NULL, 
    [OreSap] DECIMAL(5, 1) NOT NULL, 
    [OreDisegno] DECIMAL(5, 1) NOT NULL, 
    [Utente] VARCHAR(10) NOT NULL
)
