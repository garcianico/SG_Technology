USE [SG_Technology]
GO

/****** Object:  Table [dbo].[Account_Transaction]    Script Date: 23/1/2024 20:40:23 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Account_Transaction](
	[transaction_id] [int] IDENTITY(1,1) NOT NULL,
	[account_id] [int] NOT NULL,
	[trans_type] [int] NOT NULL,
	[trans_date] [datetime] NOT NULL,
	[amount] [decimal](18, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[transaction_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Account_Transaction] ADD  DEFAULT ((0.00)) FOR [amount]
GO


