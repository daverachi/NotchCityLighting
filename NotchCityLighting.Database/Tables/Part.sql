CREATE TABLE [dbo].[Part]
(
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Description] NVARCHAR(150) NULL, 
    [MaterialType] INT NOT NULL, 
	[Photo] NVARCHAR(MAX) NULL,
	[IsActive] BIT NOT NULL,
    [CreateDateTime] DATETIME NULL, 
    [ModifiedDateTime] DATETIME NOT NULL, 
    CONSTRAINT [FK_LampPart_MaterialType] FOREIGN KEY ([MaterialType]) REFERENCES [MaterialType]([Id])
)
GO

CREATE UNIQUE INDEX [IX_Part_Id] ON [dbo].[Part] (Id)
