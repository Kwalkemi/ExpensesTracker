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

-- CODE ID 1
IF NOT EXISTS(SELECT 1 FROM CODE_VALUE WHERE CODE_ID = 1 AND CODE_VALUE = 'USER')
BEGIN
 INSERT INTO CODE_VALUE VALUES(1, 'USER', 'USER ID', NULL,NULL)
END
GO

-- CODE ID 2
IF NOT EXISTS(SELECT 1 FROM CODE_VALUE WHERE CODE_ID = 2 AND CODE_VALUE = 'HUSB')
BEGIN
 INSERT INTO CODE_VALUE VALUES(2, 'HUSB', 'HUSBAND CODE ID', NULL,NULL)
END
GO

IF NOT EXISTS(SELECT 1 FROM CODE_VALUE WHERE CODE_ID = 2 AND CODE_VALUE = 'WIFE')
BEGIN
 INSERT INTO CODE_VALUE VALUES(2, 'WIFE', 'WIFE CODE ID', NULL,NULL)
END
GO

-- CODE ID 3
IF NOT EXISTS(SELECT 1 FROM CODE_VALUE WHERE CODE_ID = 3 AND CODE_VALUE = 'HUWF')
BEGIN
 INSERT INTO CODE_VALUE VALUES(3, 'HUWF', 'HUSBAND WIFE TABLE', NULL,NULL)
END
GO

IF NOT EXISTS(SELECT 1 FROM CODE_VALUE WHERE CODE_ID = 3 AND CODE_VALUE = 'EXPN')
BEGIN
 INSERT INTO CODE_VALUE VALUES(3, 'EXPN', 'EXPENSES TABLE', NULL,NULL)
END
GO