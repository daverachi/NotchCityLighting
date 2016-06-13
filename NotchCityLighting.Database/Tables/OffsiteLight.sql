CREATE TABLE [dbo].[OffsiteLight]
(
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [LightId] INT NOT NULL, 
    [AddressId] INT NOT NULL, 
    [CreateDateTime] DATETIME NOT NULL, 
    [ModifiedDateTime] DATETIME NULL, 
    [IsActive] BIT NOT NULL, 
    CONSTRAINT [FK_OffsiteLight_Light] FOREIGN KEY (LightId) REFERENCES [Light]([Id]),
    CONSTRAINT [FK_OffsiteLight_Address] FOREIGN KEY (AddressId) REFERENCES [Address]([Id]),
)
GO

CREATE UNIQUE INDEX [IX_OffsiteLight_Id] ON [dbo].[OffsiteLight] (Id)