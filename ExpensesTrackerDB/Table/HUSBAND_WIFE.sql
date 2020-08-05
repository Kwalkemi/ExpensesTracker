﻿CREATE TABLE [DBO].[HUSBAND_WIFE](
	[HUSBAND_WIFE_ID] [INT] IDENTITY(1,1) NOT NULL,
	[HUSBAND_WIFE_TYPE] [VARCHAR](10) NULL,
	[HUSBAND_WIFE_AMT] [INT] NULL,
	[HUSBAND_WIFE_DATE] [VARCHAR](100) NULL,
	[HUSBAND_WIFE_TYPE_ID] [INT] NOT NULL,
	[EXPENSES_CATEGORY_ID] [INT] NULL,
PRIMARY KEY CLUSTERED 
(
	[HUSBAND_WIFE_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [DBO].[HUSBAND_WIFE]  WITH CHECK ADD FOREIGN KEY([EXPENSES_CATEGORY_ID])
REFERENCES [DBO].[EXPENSES_CATEGORY] ([EXPENSES_CATEGORY_ID])
GO

