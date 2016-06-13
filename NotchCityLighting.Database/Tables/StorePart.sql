CREATE TABLE [dbo].[StorePart]
(
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [StoreId] INT NOT NULL,
	[PartId] INT NULL, 
	[BulbId] INT NULL, 
    [PartNumber] NVARCHAR(100) NULL, 
    [Price] MONEY NULL, 
    [Url] NVARCHAR(MAX) NULL, 

    [CreateDateTime] DATETIME NOT NULL, 
    [ModifiedDateTime] DATETIME NULL, 
    [IsActive] BIT NOT NULL, 
    CONSTRAINT [FK_StorePart_Store] FOREIGN KEY (StoreId) REFERENCES [Store]([Id]),
    CONSTRAINT [FK_StorePart_Part] FOREIGN KEY (PartId) REFERENCES [Part]([Id]),
    CONSTRAINT [FK_StorePart_Bulb] FOREIGN KEY (BulbId) REFERENCES [Bulb]([Id]),
)
GO 

CREATE UNIQUE INDEX [IX_StorePart_Id] ON [dbo].[StorePart] (Id)