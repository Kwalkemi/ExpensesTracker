﻿CREATE PROCEDURE [dbo].[SHARE_TRACKER_PROCEDURE_SERVICE]
@USER_ID INT,
@MONTH INT, 
@YEAR INT
AS
WITH SHARETRACKERBUY(SHARES_ID, AMOUNT)
AS
(
SELECT HDR.SHARES_TRACKER_HEADER_ID AS SHARES_ID, ISNULL(SUM((BUY.SHARES_PRICE_AMT * BUY.SHARES_QUANTITY)+ ISNULL(BUY.SHARES_CHARGES_AMT,0)),0) AS AMOUNT FROM SHARES_TRACKER_HEADER HDR 
INNER JOIN SHARES_TRACKER_BUY BUY
ON HDR.SHARES_TRACKER_HEADER_ID = BUY.SHARES_TRACKER_HEADER_ID 
 GROUP BY HDR.SHARES_TRACKER_HEADER_ID
),
SHARETRACKERSELL(SHARES_ID, AMOUNT)
AS
(
SELECT HDR.SHARES_TRACKER_HEADER_ID AS SHARES_ID, ISNULL(SUM((SEL.SHARES_PRICE_AMT * SEL.SHARES_QUANTITY) - ISNULL(SEL.SHARES_CHARGES_AMT,0)),0) AS AMOUNT FROM SHARES_TRACKER_HEADER HDR 
INNER JOIN SHARES_TRACKER_SELL SEL
ON HDR.SHARES_TRACKER_HEADER_ID = SEL.SHARES_TRACKER_HEADER_ID 
GROUP BY HDR.SHARES_TRACKER_HEADER_ID
)
SELECT  SHARE_YEAR, SHARE_MONTH,SERVICE_CODE_VALUE ,SUM(SHARE_AMT) AS PROFIT_LOSS FROM (
SELECT (B.AMOUNT - A.AMOUNT) AS SHARE_AMT, 
 (SELECT MONTH(MAX(SHARES_SELL_DATE)) FROM SHARES_TRACKER_SELL WHERE SHARES_TRACKER_HEADER_ID = HD.SHARES_TRACKER_HEADER_ID) AS SHARE_MONTH,
(SELECT YEAR(MAX(SHARES_SELL_DATE)) FROM SHARES_TRACKER_SELL WHERE SHARES_TRACKER_HEADER_ID = HD.SHARES_TRACKER_HEADER_ID) AS SHARE_YEAR,
SERVICE_CODE_VALUE
FROM SHARES_TRACKER_HEADER HD
LEFT JOIN SHARETRACKERBUY A
ON SHARES_TRACKER_HEADER_ID = A.SHARES_ID
LEFT JOIN SHARETRACKERSELL B
ON A.SHARES_ID = B.SHARES_ID
WHERE HD.USER_ID = @USER_ID 
) AS MAIN
Where Share_Year = @YEAR and SHARE_MONTH = @MONTH
GROUP BY SHARE_YEAR, SHARE_MONTH, SERVICE_CODE_VALUE
HAVING SUM(SHARE_AMT) IS NOT NULL
ORDER BY SHARE_YEAR desc, SHARE_MONTH DESC
