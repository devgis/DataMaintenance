USE [EcologyDB]
GO
/****** Object:  Table [dbo].[Subject_Subject]    Script Date: 12/19/2020 20:36:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Subject_Subject](
	[SubjectID] [varchar](50) NULL,
	[SubSubjectID] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Subject_Product]    Script Date: 12/19/2020 20:36:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Subject_Product](
	[SubjectID] [varchar](50) NULL,
	[ProductID] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Subject_Offer]    Script Date: 12/19/2020 20:36:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Subject_Offer](
	[SubjectID] [varchar](50) NULL,
	[OfferID] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Subject]    Script Date: 12/19/2020 20:36:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Subject](
	[id] [varchar](50) NULL,
	[name] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Product]    Script Date: 12/19/2020 20:36:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Product](
	[id] [varchar](50) NULL,
	[name] [varchar](50) NULL,
	[price] [numeric](18, 6) NULL,
	[quantity] [numeric](18, 6) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Product] ([id], [name], [price], [quantity]) VALUES (N'f5473a15-31b6-4ad3-932e-235c53d6bf18', N'test1', CAST(1.100000 AS Numeric(18, 6)), CAST(2.300000 AS Numeric(18, 6)))
INSERT [dbo].[Product] ([id], [name], [price], [quantity]) VALUES (N'62fe3e0e-93b9-4cf0-9b09-05595f73468f', N'test2', CAST(3.200000 AS Numeric(18, 6)), CAST(34.320000 AS Numeric(18, 6)))
/****** Object:  Table [dbo].[Offer_Product]    Script Date: 12/19/2020 20:36:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Offer_Product](
	[OfferID] [varchar](50) NULL,
	[ProductID] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Offer_Product] ([OfferID], [ProductID]) VALUES (N'18fe25ac-648d-4de4-9467-6bd3a43bc868', N'f5473a15-31b6-4ad3-932e-235c53d6bf18')
INSERT [dbo].[Offer_Product] ([OfferID], [ProductID]) VALUES (N'18fe25ac-648d-4de4-9467-6bd3a43bc868', N'62fe3e0e-93b9-4cf0-9b09-05595f73468f')
INSERT [dbo].[Offer_Product] ([OfferID], [ProductID]) VALUES (N'dc6b923e-5e1e-493e-a0dc-80ec0e27b95f', N'f5473a15-31b6-4ad3-932e-235c53d6bf18')
INSERT [dbo].[Offer_Product] ([OfferID], [ProductID]) VALUES (N'ea07a955-3a76-4914-b364-e90d52701d60', N'62fe3e0e-93b9-4cf0-9b09-05595f73468f')
INSERT [dbo].[Offer_Product] ([OfferID], [ProductID]) VALUES (N'577db7cb-1de7-4a8d-a69c-aba2028abc36', N'f5473a15-31b6-4ad3-932e-235c53d6bf18')
/****** Object:  Table [dbo].[Offer]    Script Date: 12/19/2020 20:36:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Offer](
	[id] [varchar](50) NULL,
	[subjectname] [varchar](50) NULL,
	[startTime] [datetime] NULL,
	[state] [int] NULL,
	[doneTime] [datetime] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Offer] ([id], [subjectname], [startTime], [state], [doneTime]) VALUES (N'18fe25ac-648d-4de4-9467-6bd3a43bc868', N'fff', CAST(0x0000AC96009CE312 AS DateTime), 1000, CAST(0x0000AC96009CE315 AS DateTime))
INSERT [dbo].[Offer] ([id], [subjectname], [startTime], [state], [doneTime]) VALUES (N'577db7cb-1de7-4a8d-a69c-aba2028abc36', N'ccc', CAST(0x0000AC9600D608E6 AS DateTime), 1000, CAST(0x0000AC9600D608E7 AS DateTime))
INSERT [dbo].[Offer] ([id], [subjectname], [startTime], [state], [doneTime]) VALUES (N'dc6b923e-5e1e-493e-a0dc-80ec0e27b95f', N'dd', CAST(0x0000AC9600E3ADCD AS DateTime), 1000, CAST(0x0000AC9600E3ADCE AS DateTime))
INSERT [dbo].[Offer] ([id], [subjectname], [startTime], [state], [doneTime]) VALUES (N'ea07a955-3a76-4914-b364-e90d52701d60', N'ff', CAST(0x0000AC9600E4E2BE AS DateTime), 1000, CAST(0x0000AC9600E4E2BF AS DateTime))
