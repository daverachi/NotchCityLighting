﻿CREATE TABLE [dbo].[State]
(
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [Name] NVARCHAR(50) NOT NULL, 
)
GO 

CREATE UNIQUE INDEX [IX_State_Id] ON [dbo].[State] (Id)