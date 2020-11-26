﻿CREATE PROCEDURE [dbo].[EXPENSES_TRACKER_PROCEDURE]
AS
BEGIN
	SELECT  EXPENSES_ITEM, EXPENSES_DATE, EXPENSES_AMT, B.EXPENSES_CATEGORY_NAME,
		 C.CODE_VALUE_DESCRIPTION AS EXPENSES_TYPE,EXPENSES_TRACKER_ID FROM DBO.EXPENSES_TRACKER A
		 LEFT JOIN EXPENSES_CATEGORY B
		ON A.EXPENSES_CATEGORY_ID = B.EXPENSES_CATEGORY_ID 
		INNER JOIN CODE_VALUE C
		ON C.CODE_ID = A.EXPENSES_TYPE_ID AND C.CODE_VALUE = A.EXPENSES_TYPE_VALUE
		WHERE EXPENSES_CATEGORY_TABLE_VALUE = 'EXPN' OR A.EXPENSES_CATEGORY_ID IS NULL 
		ORDER BY A.EXPENSES_TRACKER_ID DESC
END