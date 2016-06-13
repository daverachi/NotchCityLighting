CREATE TABLE [dbo].[Store]
(
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [Name] NVARCHAR(100) NOT NULL, 
    [AddressId] INT NOT NULL, 
	[CreateDateTime] DATETIME NOT NULL, 
    [ModifiedDateTime] DATETIME NULL, 
    [IsActive] BIT NOT NULL, 
    CONSTRAINT [FK_Store_Address] FOREIGN KEY (AddressId) REFERENCES [Address]([Id]),
)
GO 

CREATE UNIQUE INDEX [IX_Store_Id] ON [dbo].[Store] (Id)