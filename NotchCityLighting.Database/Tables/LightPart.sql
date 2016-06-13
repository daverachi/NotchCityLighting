CREATE TABLE [dbo].[LightPart]
(
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [LightId] INT NOT NULL, 
    [PartId] INT NOT NULL, 
    [CreateDateTime] DATETIME NOT NULL, 
    CONSTRAINT [FK_LightPart_Light] FOREIGN KEY ([LightId]) REFERENCES [Light]([Id]),
	CONSTRAINT [FK_LightPart_Part] FOREIGN KEY ([PartId]) REFERENCES [Part]([Id])
)
GO

CREATE UNIQUE INDEX [IX_LightPart_Id] ON [dbo].[LightPart] (Id)
