﻿CREATE TABLE [dbo].[ASSET_DETAIL](
	[ASSET_DETAIL_ID] [int] IDENTITY(1,1) NOT NULL,
	[ASSET_HEADER_ID] [int] NULL,
	[ASSET_DESCIPTION] [varchar](1000) NULL,
	[ASSET_AMOUNT] [decimal](10, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[ASSET_DETAIL_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[ASSET_DETAIL]  WITH CHECK ADD FOREIGN KEY([ASSET_HEADER_ID])
REFERENCES [dbo].[ASSET_HEADER] ([ASSET_HEADER_ID])
GO