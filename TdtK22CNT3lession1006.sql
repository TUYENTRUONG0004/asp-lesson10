USE [TdtK22CNT3lession1006]
GO
/****** Object:  Table [dbo].[TdtAccount]    Script Date: 03/07/2024 9:10:49 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TdtAccount](
	[TdtID] [int] NOT NULL,
	[TdtUserName] [nvarchar](50) NULL,
	[TdtPassword] [nvarchar](50) NULL,
	[TdtFullName] [nvarchar](50) NULL,
	[TdtEmail] [nvarchar](50) NULL,
	[TdtPhone] [nvarchar](50) NULL,
	[TdtActive] [bit] NULL,
 CONSTRAINT [PK_TdtAccount] PRIMARY KEY CLUSTERED 
(
	[TdtID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[TdtAccount] ([TdtID], [TdtUserName], [TdtPassword], [TdtFullName], [TdtEmail], [TdtPhone], [TdtActive]) VALUES (1, N'TruongTuyen', N'123456@', N'Truong Dinh Tuyen', N'loc4571@gmail.com', N'0919089085', 1)
GO
