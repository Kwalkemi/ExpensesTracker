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


IF NOT EXISTS(SELECT 1 FROM CODE_ID WHERE CODE_ID = 1)
BEGIN
 INSERT INTO CODE_ID VALUES(1, 'CONFIGURABLE VALUES')
END
GO

IF NOT EXISTS(SELECT 1 FROM CODE_ID WHERE CODE_ID = 2)
BEGIN
 INSERT INTO CODE_ID VALUES(2, 'HUSBAND WIFE TYPE CODE ID')
END
GO

IF NOT EXISTS(SELECT 1 FROM CODE_ID WHERE CODE_ID = 3)
BEGIN
 INSERT INTO CODE_ID VALUES(3, 'EXPENSES TABLE NAME CODE VALUE')
END
GO

IF NOT EXISTS(SELECT 1 FROM CODE_ID WHERE CODE_ID = 4)
BEGIN
 INSERT INTO CODE_ID VALUES(4, 'EXPENSES TYPE VALUE')
END
GO

IF NOT EXISTS(SELECT 1 FROM CODE_ID WHERE CODE_ID = 5)
BEGIN
 INSERT INTO CODE_ID VALUES(5, 'SHARES TYPE VALUE')
END
GO

IF NOT EXISTS(SELECT 1 FROM CODE_ID WHERE CODE_ID = 6)
BEGIN
 INSERT INTO CODE_ID VALUES(6, 'SHARES TRANSACTION TYPE')
END
GO

IF NOT EXISTS(SELECT 1 FROM CODE_ID WHERE CODE_ID = 7)
BEGIN
 INSERT INTO CODE_ID VALUES(7, 'SERVICES CODE TYPE')
END
GO

IF NOT EXISTS(SELECT 1 FROM CODE_ID WHERE CODE_ID = 8)
BEGIN
 INSERT INTO CODE_ID VALUES(8, 'DEMAT ACCOUNT NAME')
END
GO