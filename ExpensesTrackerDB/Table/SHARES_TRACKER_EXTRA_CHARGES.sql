﻿CREATE TABLE [dbo].[SHARES_TRACKER_EXTRA_CHARGES](
	[SHARES_TRACKER_EXTRA_CHARGES_ID] [int] IDENTITY(1,1) NOT NULL,
	[SHARES_EXTRA_CHARGES_AMT] [decimal](6, 2) NULL,
	[SHARES_EXTRA_CHARGES_DESCRIPTION] [varchar](500) NOT NULL,
	[SHARES_CHARGES_DATE] [date] NULL,
	[SHARES_TRACKER_HEADER_ID] [int] NULL,
	[IS_CONSIDER] [bit] NULL,
	[USER_ID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[SHARES_TRACKER_EXTRA_CHARGES_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[SHARES_TRACKER_EXTRA_CHARGES] ADD FOREIGN KEY([SHARES_TRACKER_HEADER_ID])
REFERENCES [dbo].[SHARES_TRACKER_HEADER] ([SHARES_TRACKER_HEADER_ID])
GO

ALTER TABLE [dbo].[SHARES_TRACKER_EXTRA_CHARGES] ADD FOREIGN KEY([USER_ID])
REFERENCES [dbo].[Login_Info] ([Login_Info_Id])
GO