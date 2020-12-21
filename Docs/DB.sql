USE [master]
GO
/****** Object:  Database [EcologyDB]    Script Date: 12/21/2020 22:00:35 ******/
CREATE DATABASE [EcologyDB] ON  PRIMARY 
( NAME = N'EcologyDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\EcologyDB.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'EcologyDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\EcologyDB_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [EcologyDB] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EcologyDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [EcologyDB] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [EcologyDB] SET ANSI_NULLS OFF
GO
ALTER DATABASE [EcologyDB] SET ANSI_PADDING OFF
GO
ALTER DATABASE [EcologyDB] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [EcologyDB] SET ARITHABORT OFF
GO
ALTER DATABASE [EcologyDB] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [EcologyDB] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [EcologyDB] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [EcologyDB] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [EcologyDB] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [EcologyDB] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [EcologyDB] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [EcologyDB] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [EcologyDB] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [EcologyDB] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [EcologyDB] SET  DISABLE_BROKER
GO
ALTER DATABASE [EcologyDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [EcologyDB] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [EcologyDB] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [EcologyDB] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [EcologyDB] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [EcologyDB] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [EcologyDB] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [EcologyDB] SET  READ_WRITE
GO
ALTER DATABASE [EcologyDB] SET RECOVERY FULL
GO
ALTER DATABASE [EcologyDB] SET  MULTI_USER
GO
ALTER DATABASE [EcologyDB] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [EcologyDB] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'EcologyDB', N'ON'
GO
USE [EcologyDB]
GO
/****** Object:  Table [dbo].[Subject_Subject]    Script Date: 12/21/2020 22:00:36 ******/
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
INSERT [dbo].[Subject_Subject] ([SubjectID], [SubSubjectID]) VALUES (N'6b1e58a1-5892-4a63-964a-67026b14a004', N'ba1c8e20-03cd-475e-84ae-96dd44823828')
/****** Object:  Table [dbo].[Subject_Product]    Script Date: 12/21/2020 22:00:36 ******/
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
INSERT [dbo].[Subject_Product] ([SubjectID], [ProductID], [Quantity]) VALUES (N'6b1e58a1-5892-4a63-964a-67026b14a004', N'f5473a15-31b6-4ad3-932e-235c53d6bf18', CAST(3.000000 AS Numeric(18, 6)))
INSERT [dbo].[Subject_Product] ([SubjectID], [ProductID], [Quantity]) VALUES (N'ba1c8e20-03cd-475e-84ae-96dd44823828', N'f5473a15-31b6-4ad3-932e-235c53d6bf18', CAST(2.300000 AS Numeric(18, 6)))
/****** Object:  Table [dbo].[Subject_Offer]    Script Date: 12/21/2020 22:00:36 ******/
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
INSERT [dbo].[Subject_Offer] ([SubjectID], [OfferID]) VALUES (N'6b1e58a1-5892-4a63-964a-67026b14a004', N'18fe25ac-648d-4de4-9467-6bd3a43bc868')
INSERT [dbo].[Subject_Offer] ([SubjectID], [OfferID]) VALUES (N'6b1e58a1-5892-4a63-964a-67026b14a004', N'577db7cb-1de7-4a8d-a69c-aba2028abc36')
/****** Object:  Table [dbo].[Subject]    Script Date: 12/21/2020 22:00:36 ******/
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
INSERT [dbo].[Subject] ([id], [name]) VALUES (N'6b1e58a1-5892-4a63-964a-67026b14a004', N'test')
INSERT [dbo].[Subject] ([id], [name]) VALUES (N'ba1c8e20-03cd-475e-84ae-96dd44823828', N'test2')
/****** Object:  Table [dbo].[Product]    Script Date: 12/21/2020 22:00:36 ******/
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
INSERT [dbo].[Product] ([id], [name], [price], [quantity]) VALUES (N'42713c4b-4812-43e2-bea9-e8bd23e2ee4c', N'test3', CAST(2.000000 AS Numeric(18, 6)), CAST(3.000000 AS Numeric(18, 6)))
INSERT [dbo].[Product] ([id], [name], [price], [quantity]) VALUES (N'4a2c934a-3fd8-4a91-b15e-ac1a014d450c', N'test4', CAST(4.000000 AS Numeric(18, 6)), CAST(4.000000 AS Numeric(18, 6)))
INSERT [dbo].[Product] ([id], [name], [price], [quantity]) VALUES (N'd10210db-89c1-4006-8ef2-ad672b6e6454', N'test5', CAST(5.000000 AS Numeric(18, 6)), CAST(5.000000 AS Numeric(18, 6)))
INSERT [dbo].[Product] ([id], [name], [price], [quantity]) VALUES (N'6ce554fe-dd32-4a11-924e-fa2653deaaa7', N'test6', CAST(6.000000 AS Numeric(18, 6)), CAST(6.000000 AS Numeric(18, 6)))
/****** Object:  Table [dbo].[Offer_Product]    Script Date: 12/21/2020 22:00:36 ******/
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
INSERT [dbo].[Offer_Product] ([OfferID], [ProductID], [Quantity]) VALUES (N'18fe25ac-648d-4de4-9467-6bd3a43bc868', N'f5473a15-31b6-4ad3-932e-235c53d6bf18', CAST(2.000000 AS Numeric(18, 6)))
INSERT [dbo].[Offer_Product] ([OfferID], [ProductID], [Quantity]) VALUES (N'18fe25ac-648d-4de4-9467-6bd3a43bc868', N'62fe3e0e-93b9-4cf0-9b09-05595f73468f', CAST(1.000000 AS Numeric(18, 6)))
INSERT [dbo].[Offer_Product] ([OfferID], [ProductID], [Quantity]) VALUES (N'dc6b923e-5e1e-493e-a0dc-80ec0e27b95f', N'f5473a15-31b6-4ad3-932e-235c53d6bf18', CAST(1.000000 AS Numeric(18, 6)))
INSERT [dbo].[Offer_Product] ([OfferID], [ProductID], [Quantity]) VALUES (N'ea07a955-3a76-4914-b364-e90d52701d60', N'f5473a15-31b6-4ad3-932e-235c53d6bf18', CAST(2.300000 AS Numeric(18, 6)))
INSERT [dbo].[Offer_Product] ([OfferID], [ProductID], [Quantity]) VALUES (N'577db7cb-1de7-4a8d-a69c-aba2028abc36', N'f5473a15-31b6-4ad3-932e-235c53d6bf18', CAST(1.000000 AS Numeric(18, 6)))
INSERT [dbo].[Offer_Product] ([OfferID], [ProductID], [Quantity]) VALUES (N'c8bb8131-b7a4-4ee3-b547-c21b07314cf2', N'f5473a15-31b6-4ad3-932e-235c53d6bf18', CAST(2.300000 AS Numeric(18, 6)))
INSERT [dbo].[Offer_Product] ([OfferID], [ProductID], [Quantity]) VALUES (N'ea07a955-3a76-4914-b364-e90d52701d60', N'42713c4b-4812-43e2-bea9-e8bd23e2ee4c', CAST(3.000000 AS Numeric(18, 6)))
INSERT [dbo].[Offer_Product] ([OfferID], [ProductID], [Quantity]) VALUES (N'ea07a955-3a76-4914-b364-e90d52701d60', N'4a2c934a-3fd8-4a91-b15e-ac1a014d450c', CAST(4.000000 AS Numeric(18, 6)))
INSERT [dbo].[Offer_Product] ([OfferID], [ProductID], [Quantity]) VALUES (N'ea07a955-3a76-4914-b364-e90d52701d60', N'd10210db-89c1-4006-8ef2-ad672b6e6454', CAST(5.000000 AS Numeric(18, 6)))
INSERT [dbo].[Offer_Product] ([OfferID], [ProductID], [Quantity]) VALUES (N'ea07a955-3a76-4914-b364-e90d52701d60', N'6ce554fe-dd32-4a11-924e-fa2653deaaa7', CAST(6.000000 AS Numeric(18, 6)))
INSERT [dbo].[Offer_Product] ([OfferID], [ProductID], [Quantity]) VALUES (N'c8bb8131-b7a4-4ee3-b547-c21b07314cf2', N'62fe3e0e-93b9-4cf0-9b09-05595f73468f', CAST(34.320000 AS Numeric(18, 6)))
INSERT [dbo].[Offer_Product] ([OfferID], [ProductID], [Quantity]) VALUES (N'c8bb8131-b7a4-4ee3-b547-c21b07314cf2', N'42713c4b-4812-43e2-bea9-e8bd23e2ee4c', CAST(3.000000 AS Numeric(18, 6)))
INSERT [dbo].[Offer_Product] ([OfferID], [ProductID], [Quantity]) VALUES (N'c8bb8131-b7a4-4ee3-b547-c21b07314cf2', N'4a2c934a-3fd8-4a91-b15e-ac1a014d450c', CAST(4.000000 AS Numeric(18, 6)))
INSERT [dbo].[Offer_Product] ([OfferID], [ProductID], [Quantity]) VALUES (N'c8bb8131-b7a4-4ee3-b547-c21b07314cf2', N'd10210db-89c1-4006-8ef2-ad672b6e6454', CAST(5.000000 AS Numeric(18, 6)))
INSERT [dbo].[Offer_Product] ([OfferID], [ProductID], [Quantity]) VALUES (N'c8bb8131-b7a4-4ee3-b547-c21b07314cf2', N'6ce554fe-dd32-4a11-924e-fa2653deaaa7', CAST(6.000000 AS Numeric(18, 6)))
/****** Object:  Table [dbo].[Offer]    Script Date: 12/21/2020 22:00:36 ******/
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
INSERT [dbo].[Offer] ([id], [subjectname], [startTime], [state], [doneTime]) VALUES (N'c8bb8131-b7a4-4ee3-b547-c21b07314cf2', N'fff', CAST(0x0000AC98015D3474 AS DateTime), 1000, CAST(0x0000AC98015D3476 AS DateTime))
