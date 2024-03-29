USE [EcologyDB]
GO
/****** Object:  Table [dbo].[Subject_Subject]    Script Date: 12/22/2020 22:52:07 ******/
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
/****** Object:  Table [dbo].[Subject_Product]    Script Date: 12/22/2020 22:52:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Subject_Product](
	[SubjectID] [varchar](50) NULL,
	[ProductID] [varchar](50) NULL,
	[Quantity] [numeric](18, 6) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Subject_Offer]    Script Date: 12/22/2020 22:52:07 ******/
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
/****** Object:  Table [dbo].[Subject]    Script Date: 12/22/2020 22:52:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Subject](
	[id] [varchar](50) NULL,
	[name] [varchar](50) NULL,
	[flag] [int] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Product]    Script Date: 12/22/2020 22:52:07 ******/
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
	[quantity] [numeric](18, 6) NULL,
	[flag] [int] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Offer_Product]    Script Date: 12/22/2020 22:52:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Offer_Product](
	[OfferID] [varchar](50) NULL,
	[ProductID] [varchar](50) NULL,
	[Quantity] [numeric](18, 6) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Offer]    Script Date: 12/22/2020 22:52:07 ******/
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
	[doneTime] [datetime] NULL,
	[flag] [int] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
