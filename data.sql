USE [master]
GO
/****** Object:  Database [QuanLySuKien]    Script Date: 7/8/2024 11:05:15 PM ******/
CREATE DATABASE [QuanLySuKien];
USE [QuanLySuKien]
GO
/****** Object:  Table [dbo].[LoiMoiSuKien]    Script Date: 7/8/2024 11:05:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoiMoiSuKien](
	[UsernameNguoiMoi] [nvarchar](50) NOT NULL,
	[UsernameNguoiNhan] [nvarchar](50) NOT NULL,
	[IdSuKien] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NguoiDung]    Script Date: 7/8/2024 11:05:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguoiDung](
	[Fullname] [nvarchar](50) NOT NULL,
	[Username] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_NguoiDung] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SuKien]    Script Date: 7/8/2024 11:05:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SuKien](
	[ID] [int] NOT NULL,
	[TenSuKien] [nvarchar](250) NOT NULL,
	[ThoiGian] [date] NOT NULL,
	[DiaDiem] [nvarchar](250) NOT NULL,
	[MoTa] [nvarchar](250) NOT NULL,
	[Owner] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_SuKien] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThamGiaSuKien]    Script Date: 7/8/2024 11:05:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThamGiaSuKien](
	[IdSuKien] [int] NOT NULL,
	[UsernameNguoiThamGia] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[YeuCauSuKien]    Script Date: 7/8/2024 11:05:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[YeuCauSuKien](
	[IdSuKien] [int] NOT NULL,
	[UsernameYeuCau] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[LoiMoiSuKien] ([UsernameNguoiMoi], [UsernameNguoiNhan], [IdSuKien]) VALUES (N'admin', N'guest', 1)
GO
INSERT [dbo].[NguoiDung] ([Fullname], [Username], [Password]) VALUES (N'admin', N'admin', N'123456')
INSERT [dbo].[NguoiDung] ([Fullname], [Username], [Password]) VALUES (N'Khách', N'guest', N'123456')
INSERT [dbo].[NguoiDung] ([Fullname], [Username], [Password]) VALUES (N'Khách mới', N'khachmoi', N'123456')
GO
INSERT [dbo].[SuKien] ([ID], [TenSuKien], [ThoiGian], [DiaDiem], [MoTa], [Owner]) VALUES (1, N'Sự kiện người mới', CAST(N'2024-01-01' AS Date), N'Hà Nội', N'Sự kiện cho người mới 2024', N'admin')
INSERT [dbo].[SuKien] ([ID], [TenSuKien], [ThoiGian], [DiaDiem], [MoTa], [Owner]) VALUES (2, N'Sự kiện gì cho ai vậy', CAST(N'2024-07-26' AS Date), N'Hà Nội', N'Big city', N'admin')
INSERT [dbo].[SuKien] ([ID], [TenSuKien], [ThoiGian], [DiaDiem], [MoTa], [Owner]) VALUES (3, N'Sự kiện cho khách mời', CAST(N'2024-07-31' AS Date), N'HCM', N'Tổ chức tại HCM', N'guest')
GO
INSERT [dbo].[ThamGiaSuKien] ([IdSuKien], [UsernameNguoiThamGia]) VALUES (1, N'admin')
INSERT [dbo].[ThamGiaSuKien] ([IdSuKien], [UsernameNguoiThamGia]) VALUES (2, N'admin')
INSERT [dbo].[ThamGiaSuKien] ([IdSuKien], [UsernameNguoiThamGia]) VALUES (3, N'guest')
GO
INSERT [dbo].[YeuCauSuKien] ([IdSuKien], [UsernameYeuCau]) VALUES (2, N'guest')
GO
USE [master]
GO
ALTER DATABASE [QuanLySuKien] SET  READ_WRITE 
GO
