CREATE TABLE [dbo].[MaterialType]
(
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [Name] NVARCHAR(25) NOT NULL, 
    [IsActive] BIT NOT NULL, 
    [CreateDateTime] DATETIME NOT NULL, 
    [ModifiedDateTime] DATETIME NULL
)
GO

CREATE UNIQUE INDEX [IX_MaterialType_Id] ON [dbo].[MaterialType] (Id)