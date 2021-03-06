USE [TKB]
GO
/****** Object:  Table [dbo].[MonHoc]    Script Date: 04/04/2017 16:43:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonHoc](
	[IDMon] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](100) NULL,
	[Khoi6] [bit] NULL,
	[Khoi7] [bit] NULL,
	[Khoi8] [bit] NULL,
	[Khoi9] [bit] NULL,
	[SoTietK6] [int] NULL,
	[SoTietK7] [int] NULL,
	[SoTietK8] [int] NULL,
	[SoTietK9] [int] NULL,
	[SoBuoiK6] [int] NULL,
	[SoBuoiK7] [int] NULL,
	[SoBuoiK8] [int] NULL,
	[SoBuoiK9] [int] NULL,
	[Kep] [bit] NULL,
	[Phu] [bit] NULL,
 CONSTRAINT [PK_MonHoc] PRIMARY KEY CLUSTERED 
(
	[IDMon] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuyenTruyCap]    Script Date: 04/04/2017 16:43:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuyenTruyCap](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenDN] [nvarchar](50) NULL,
	[MatKhau] [nvarchar](50) NULL,
	[Quyen] [nvarchar](50) NULL,
 CONSTRAINT [PK_QuyenTruyCap] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhongHoc]    Script Date: 04/04/2017 16:43:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhongHoc](
	[IDPH] [int] IDENTITY(1,1) NOT NULL,
	[TenPH] [nvarchar](50) NULL,
	[SucChua] [int] NULL,
	[ViTri] [nvarchar](50) NULL,
 CONSTRAINT [PK_PhongHoc] PRIMARY KEY CLUSTERED 
(
	[IDPH] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThoiKhoaBieu]    Script Date: 04/04/2017 16:43:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThoiKhoaBieu](
	[IDTKB] [int] IDENTITY(1,1) NOT NULL,
	[IDGV] [int] NULL,
	[IDLop] [int] NULL,
	[IDMon] [int] NULL,
	[Thu] [int] NULL,
	[Tiet] [int] NULL,
 CONSTRAINT [PK_ThoiKhoaBieu] PRIMARY KEY CLUSTERED 
(
	[IDTKB] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GiaoVien]    Script Date: 04/04/2017 16:43:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiaoVien](
	[IDGV] [int] IDENTITY(1,1) NOT NULL,
	[IDMon] [int] NULL,
	[ChuyenKhoi] [int] NULL,
	[TenGV] [nvarchar](100) NULL,
	[NamSinh] [nchar](10) NULL,
	[GioiTinh] [bit] NULL,
	[SoTiet] [int] NULL,
	[SoDT] [nchar](20) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[Username] [nvarchar](100) NULL,
	[Password] [nvarchar](100) NULL,
 CONSTRAINT [PK_GiaoVien] PRIMARY KEY CLUSTERED 
(
	[IDGV] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LopHoc]    Script Date: 04/04/2017 16:43:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LopHoc](
	[IDLop] [int] IDENTITY(1,1) NOT NULL,
	[IDGV] [int] NULL,
	[IDPH] [int] NULL,
	[Nam] [int] NULL,
	[Khoi] [int] NULL,
	[TenLop] [nvarchar](50) NULL,
	[SiSo] [int] NULL,
	[BuoiHoc] [int] NULL,
 CONSTRAINT [PK_LopHoc] PRIMARY KEY CLUSTERED 
(
	[IDLop] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_GiaoVien_MonHoc]    Script Date: 04/04/2017 16:43:34 ******/
ALTER TABLE [dbo].[GiaoVien]  WITH CHECK ADD  CONSTRAINT [FK_GiaoVien_MonHoc] FOREIGN KEY([IDMon])
REFERENCES [dbo].[MonHoc] ([IDMon])
GO
ALTER TABLE [dbo].[GiaoVien] CHECK CONSTRAINT [FK_GiaoVien_MonHoc]
GO
/****** Object:  ForeignKey [FK_LopHoc_GiaoVien]    Script Date: 04/04/2017 16:43:38 ******/
ALTER TABLE [dbo].[LopHoc]  WITH CHECK ADD  CONSTRAINT [FK_LopHoc_GiaoVien] FOREIGN KEY([IDGV])
REFERENCES [dbo].[GiaoVien] ([IDGV])
GO
ALTER TABLE [dbo].[LopHoc] CHECK CONSTRAINT [FK_LopHoc_GiaoVien]
GO
/****** Object:  ForeignKey [FK_LopHoc_PhongHoc]    Script Date: 04/04/2017 16:43:38 ******/
ALTER TABLE [dbo].[LopHoc]  WITH CHECK ADD  CONSTRAINT [FK_LopHoc_PhongHoc] FOREIGN KEY([IDPH])
REFERENCES [dbo].[PhongHoc] ([IDPH])
GO
ALTER TABLE [dbo].[LopHoc] CHECK CONSTRAINT [FK_LopHoc_PhongHoc]
GO
/****** Object:  ForeignKey [FK_ThoiKhoaBieu_GiaoVien]    Script Date: 04/04/2017 16:43:53 ******/
ALTER TABLE [dbo].[ThoiKhoaBieu]  WITH CHECK ADD  CONSTRAINT [FK_ThoiKhoaBieu_GiaoVien] FOREIGN KEY([IDGV])
REFERENCES [dbo].[GiaoVien] ([IDGV])
GO
ALTER TABLE [dbo].[ThoiKhoaBieu] CHECK CONSTRAINT [FK_ThoiKhoaBieu_GiaoVien]
GO
/****** Object:  ForeignKey [FK_ThoiKhoaBieu_LopHoc]    Script Date: 04/04/2017 16:43:54 ******/
ALTER TABLE [dbo].[ThoiKhoaBieu]  WITH CHECK ADD  CONSTRAINT [FK_ThoiKhoaBieu_LopHoc] FOREIGN KEY([IDLop])
REFERENCES [dbo].[LopHoc] ([IDLop])
GO
ALTER TABLE [dbo].[ThoiKhoaBieu] CHECK CONSTRAINT [FK_ThoiKhoaBieu_LopHoc]
GO
/****** Object:  ForeignKey [FK_ThoiKhoaBieu_MonHoc]    Script Date: 04/04/2017 16:43:54 ******/
ALTER TABLE [dbo].[ThoiKhoaBieu]  WITH CHECK ADD  CONSTRAINT [FK_ThoiKhoaBieu_MonHoc] FOREIGN KEY([IDMon])
REFERENCES [dbo].[MonHoc] ([IDMon])
GO
ALTER TABLE [dbo].[ThoiKhoaBieu] CHECK CONSTRAINT [FK_ThoiKhoaBieu_MonHoc]
GO
