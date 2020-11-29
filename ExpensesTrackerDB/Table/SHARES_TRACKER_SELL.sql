﻿CREATE TABLE [DBO].[SHARES_TRACKER_SELL](
	[SHARES_TRACKER_SELL_ID] [INT] IDENTITY(1,1) NOT NULL,
	[SHARES_TRACKER_HEADER_ID] [INT] NOT NULL,
	[SHARES_PRICE_AMT] [DECIMAL](6, 2) NOT NULL,
	[SHARES_QUANTITY] [INT] NOT NULL,
	[SHARES_SELL_DATE] [DATE] NULL,
	[SHARES_CHARGES_AMT] [DECIMAL](6, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[SHARES_TRACKER_SELL_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [DBO].[SHARES_TRACKER_SELL]  WITH CHECK ADD FOREIGN KEY([SHARES_TRACKER_HEADER_ID])
REFERENCES [DBO].[SHARES_TRACKER_HEADER] ([SHARES_TRACKER_HEADER_ID])
GO
