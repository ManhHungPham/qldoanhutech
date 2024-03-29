USE [QuanLyDoAn]
GO
/****** Object:  Table [dbo].[Doan]    Script Date: 12/21/2019 12:57:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Doan](
	[Mada] [int] NULL,
	[Id_da] [int] IDENTITY(1,1) NOT NULL,
	[Tenda] [nvarchar](50) NULL,
	[Mota] [nvarchar](max) NULL,
	[Magv] [varchar](5) NULL,
	[Maloai] [varchar](5) NULL,
 CONSTRAINT [PK_DoAn_1] PRIMARY KEY CLUSTERED 
(
	[Id_da] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Gvhd]    Script Date: 12/21/2019 12:57:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Gvhd](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Magv] [varchar](5) NOT NULL,
	[Matkhau] [varchar](10) NULL,
	[Hotengv] [nvarchar](150) NULL,
	[Email] [nvarchar](150) NULL,
	[Role] [int] NULL,
 CONSTRAINT [PK_GiangVien] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LoaiDA]    Script Date: 12/21/2019 12:57:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LoaiDA](
	[Id_lda] [int] IDENTITY(1,1) NOT NULL,
	[Maloai] [varchar](5) NOT NULL,
	[Tenloai] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_LoaiDA] PRIMARY KEY CLUSTERED 
(
	[Id_lda] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Role]    Script Date: 12/21/2019 12:57:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[MaRole] [int] IDENTITY(1,1) NOT NULL,
	[TenRole] [nvarchar](50) NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[MaRole] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Sinhvien]    Script Date: 12/21/2019 12:57:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Sinhvien](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Hoten] [nvarchar](50) NULL,
	[Matkhau] [nvarchar](50) NULL,
	[Email] [nchar](50) NULL,
	[Gioitinh] [bit] NULL,
	[Mssv] [nchar](50) NULL,
	[Sdt] [varchar](20) NULL,
	[Hinh] [nvarchar](50) NULL,
	[Role] [int] NULL,
	[Magv] [varchar](5) NULL,
 CONSTRAINT [PK_Sinhvien] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Doan]  WITH CHECK ADD  CONSTRAINT [FK_Doan_Sinhvien] FOREIGN KEY([Mada])
REFERENCES [dbo].[Sinhvien] ([Id])
GO
ALTER TABLE [dbo].[Doan] CHECK CONSTRAINT [FK_Doan_Sinhvien]
GO
