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


IF NOT EXISTS(SELECT 1 FROM CODE_VALUE WHERE CODE_ID = 1 AND CODE_VALUE = 'USER')
BEGIN
 INSERT INTO CODE_VALUE VALUES(1, 'USER', 'USER ID', NULL,NULL)
END
Go