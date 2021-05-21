﻿CREATE TABLE [dbo].[ASSET_HEADER](
	[ASSET_HEADER_ID] [int] IDENTITY(1,1) NOT NULL,
	[ASSET_TOTAL_AMOUNT] [decimal](10, 2) NULL,
	[USER_LOGIN_ID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ASSET_HEADER_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[ASSET_HEADER]  WITH CHECK ADD FOREIGN KEY([USER_LOGIN_ID])
REFERENCES [dbo].[LOGIN_INFO] ([LOGIN_INFO_ID])
GO
