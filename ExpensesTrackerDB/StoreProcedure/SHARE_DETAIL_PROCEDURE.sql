﻿CREATE PROCEDURE [DBO].[SHARE_DETAIL_PROCEDURE]
@SHARETRACKERID INT
AS

SELECT * FROM
(
SELECT 'BUY' AS RECORD_TYPE, SHARES_BUY_DATE AS TRADING_DATE,
SHARES_PRICE_AMT AS SHARES_AMT,
SHARES_QUANTITY AS SHARES_QTY,
SHARES_CHARGES_AMT AS SHARES_CHARGES,
(SHARES_PRICE_AMT * SHARES_QUANTITY) + ISNULL(BUY.SHARES_CHARGES_AMT,0) AS TOTAL,
SHARES_TRACKER_BUY_ID AS ID
 FROM [DBO].[SHARES_TRACKER_HEADER] HDR
INNER JOIN [DBO].[SHARES_TRACKER_BUY] BUY
ON HDR.SHARES_TRACKER_HEADER_ID = BUY.SHARES_TRACKER_HEADER_ID
WHERE HDR.SHARES_TRACKER_HEADER_ID = @SHARETRACKERID

UNION

SELECT 'SELL' AS RECORD_TYPE, SHARES_SELL_DATE AS TRADING_DATE,
SHARES_PRICE_AMT AS SHARES_AMT,
SHARES_QUANTITY AS SHARES_QTY,
SHARES_CHARGES_AMT AS SHARES_CHARGES,
(SHARES_PRICE_AMT * SHARES_QUANTITY) - ISNULL(SELL.SHARES_CHARGES_AMT,0) AS TOTAL,
SHARES_TRACKER_SELL_ID AS ID
 FROM [DBO].[SHARES_TRACKER_HEADER] HDR
LEFT JOIN [DBO].[SHARES_TRACKER_SELL] SELL
ON HDR.SHARES_TRACKER_HEADER_ID = SELL.SHARES_TRACKER_HEADER_ID
WHERE HDR.SHARES_TRACKER_HEADER_ID = @SHARETRACKERID
) TDR ORDER BY RECORD_TYPE ,ID  ASC



GO
