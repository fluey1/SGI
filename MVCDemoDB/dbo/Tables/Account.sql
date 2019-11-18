CREATE TABLE [dbo].[Account]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [AccountId] INT NOT NULL, 
    [Name] VARCHAR(100) NOT NULL, 
    [Street] VARCHAR(100) NULL, 
    [City] VARCHAR(50) NULL, 
    [StateProvince] VARCHAR(50) NULL, 
    [Country] VARCHAR(50) NULL
)
