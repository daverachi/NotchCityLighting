CREATE TABLE [dbo].[Address]
(
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[Address] NVARCHAR(150) NULL, 
    [City] NVARCHAR(100) NULL, 
    [StateId] INT NULL, 
    [ZipCode] NVARCHAR(15) NULL, 
    [PhoneNumber] NVARCHAR(15) NULL,
	[CreateDateTime] DATETIME NOT NULL, 
    [ModifiedDateTime] DATETIME NULL, 
    [IsActive] BIT NOT NULL, 
    CONSTRAINT [FK_Address_State] FOREIGN KEY (StateId) REFERENCES [State]([Id]),
)
GO 

CREATE UNIQUE INDEX [IX_Address_Id] ON [dbo].[Address] (Id)