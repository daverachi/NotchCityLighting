CREATE TABLE [dbo].[Light]
(
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Description] NVARCHAR(250) NULL, 
	[Photo] NVARCHAR(MAX) NULL,
    [SalePrice] MONEY NULL, 
    [SoldPrice] MONEY NULL, 
    [CreateDateTime] DATETIME NOT NULL,
	[ModifiedDateTime] DATETIME NULL, 
    [SoldDateTime] DATETIME NULL,
	[IsActive] BIT NOT NULL 
)
GO

CREATE UNIQUE INDEX [IX_Light_Id] ON [dbo].[Light] (Id)
