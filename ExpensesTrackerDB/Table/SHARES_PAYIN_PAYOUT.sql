﻿CREATE TABLE [dbo].[SHARES_PAYIN_PAYOUT](
	[SHARES_TRANSACTION_ID] [int] IDENTITY(1,1) NOT NULL,
	[SHARES_TRANSACTION_CODE_ID] [int] NOT NULL,
	[SHARES_TRANSACTION_CODE_VALUE] [varchar](200) NOT NULL,
	[SHARES_TRANSACTION_AMT] [decimal](6, 2) NOT NULL,
	[SHARES_TRANSACTION_DATE] [date] NOT NULL,
	[USER_ID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[SHARES_TRANSACTION_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


ALTER TABLE [dbo].[SHARES_PAYIN_PAYOUT]  WITH CHECK ADD FOREIGN KEY([USER_ID])
REFERENCES [dbo].[Login_Info] ([Login_Info_Id])
GO