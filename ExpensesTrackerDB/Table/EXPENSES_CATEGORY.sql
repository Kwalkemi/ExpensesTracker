﻿CREATE TABLE [DBO].[EXPENSES_CATEGORY](
	[EXPENSES_CATEGORY_ID] [INT] IDENTITY(1,1) NOT NULL,
	[EXPENSES_CATEGORY_NAME] [VARCHAR](500) NOT NULL,
	[EXPENSES_CATEGORY_TABLE_ID] [INT] NOT NULL,
	[EXPENSES_CATEGORY_TABLE_VALUE] [VARCHAR](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[EXPENSES_CATEGORY_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
