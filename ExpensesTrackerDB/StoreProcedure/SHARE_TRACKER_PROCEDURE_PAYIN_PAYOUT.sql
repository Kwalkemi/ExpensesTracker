﻿CREATE PROCEDURE [DBO].[SHARE_TRACKER_PROCEDURE_PAYIN_PAYOUT]
@USERID INT
AS
SELECT SHARES_TRANSACTION_ID, SHARES_TRANSACTION_CODE_ID, 
SHARES_TRANSACTION_CODE_VALUE, SHARES_TRANSACTION_AMT, 
SHARES_TRANSACTION_DATE FROM DBO.SHARES_PAYIN_PAYOUT
WHERE USER_ID = @USERID
GO