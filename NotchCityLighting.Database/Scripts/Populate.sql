/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
MERGE INTO MaterialType AS Target 
	USING (VALUES 
			(1, 'Plastic', 1, GETDATE()), 
			(2, 'Brass', 1, GETDATE()), 
			(3, 'Aluminum', 1, GETDATE()),
			(4, 'Copper', 1, GETDATE()), 
			(5, 'Steel', 1, GETDATE()) 
	) 
AS 
	Source (Id, Name, IsActive, CreateDateTime) 
ON 
	Target.Id = Source.Id 
WHEN 
	NOT MATCHED BY TARGET THEN 
INSERT 
	(Id, Name, IsActive, CreateDateTime) 
VALUES 
	(Id, Name, IsActive, CreateDateTime);

MERGE INTO GlassType AS Target 
	USING (VALUES 
			(1, 'Clear', 1, GETDATE()), 
			(2, 'Frosted', 1, GETDATE()), 
			(3, 'Smoked', 1, GETDATE())
	) 
AS 
	Source (Id, Name, IsActive, CreateDateTime) 
ON 
	Target.Id = Source.Id 
WHEN 
	NOT MATCHED BY TARGET THEN 
INSERT 
	(Id, Name, IsActive, CreateDateTime) 
VALUES 
	(Id, Name, IsActive, CreateDateTime);