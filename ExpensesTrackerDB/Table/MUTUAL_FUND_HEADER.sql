﻿CREATE TABLE [dbo].[MUTUAL_FUND_HEADER](
	[MUTUAL_FUND_HEADER_ID] [int] IDENTITY(1,1) NOT NULL,
	[MUTUAL_FUND_NAME] [varchar](300) NOT NULL,
	[MUTUAL_FUND_CREATED_DATE] [date] NULL,
	[USER_ID] [int] NOT NULL,
	[DEMAT_ACCOUNT_ID] [int] NOT NULL,
	[DEMAT_ACCOUNT_VALUE] [varchar](200) NULL,
	[EXIT_LOAD] [int] NULL,
	[IS_SIP] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[MUTUAL_FUND_HEADER_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[MUTUAL_FUND_HEADER]  ADD FOREIGN KEY([USER_ID])
REFERENCES [dbo].[LOGIN_INFO] ([LOGIN_INFO_ID])
GO
