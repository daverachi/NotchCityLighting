CREATE TABLE [dbo].[GlassType]
(
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [CreateDateTime] DATETIME NOT NULL,
)
GO

CREATE UNIQUE INDEX [IX_GlassType_Id] ON [dbo].[GlassType] (Id)