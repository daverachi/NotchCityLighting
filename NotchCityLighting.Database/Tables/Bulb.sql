CREATE TABLE [dbo].[Bulb]
(
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [Wattage] INT NULL, 
    [Manufacturer] NVARCHAR(50) NULL, 
    [GlassTypeId] INT NULL,
	[CreateDateTime] DATETIME NOT NULL, 
    [ModifiedDateTime] DATETIME NULL, 
    [IsActive] BIT NOT NULL, 
    CONSTRAINT [FK_Bulb_GlassType] FOREIGN KEY ([GlassTypeId]) REFERENCES [GlassType]([Id]),
)
GO

CREATE UNIQUE INDEX [IX_Bulb_Id] ON [dbo].[Bulb] (Id)