USE [QuanLyDoAn]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 12/19/2019 8:19:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[Taikhoan] [nchar](20) NOT NULL,
	[Matkhau] [nchar](16) NULL,
 CONSTRAINT [PK_ThuKyKhoa] PRIMARY KEY CLUSTERED 
(
	[Taikhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Doan]    Script Date: 12/19/2019 8:19:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Doan](
	[Mada] [int] IDENTITY(1,1) NOT NULL,
	[Tenda] [nvarchar](50) NULL,
	[Mota] [nvarchar](max) NULL,
	[Id] [int] NULL,
	[Magv] [varchar](5) NULL,
 CONSTRAINT [PK_DoAn_1] PRIMARY KEY CLUSTERED 
(
	[Mada] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Gvhd]    Script Date: 12/19/2019 8:19:10 PM ******/
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
/****** Object:  Table [dbo].[Nhom]    Script Date: 12/19/2019 8:19:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nhom](
	[Manhom] [int] NOT NULL,
	[Tennhom] [nvarchar](50) NULL,
	[Id] [int] NULL,
 CONSTRAINT [PK_Nhom] PRIMARY KEY CLUSTERED 
(
	[Manhom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Ptda]    Script Date: 12/19/2019 8:19:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ptda](
	[Magv] [int] NULL,
	[Mada] [int] NOT NULL,
	[Mssv] [int] NOT NULL,
	[Diem] [int] NULL,
 CONSTRAINT [PK_pthd] PRIMARY KEY CLUSTERED 
(
	[Mada] ASC,
	[Mssv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Role]    Script Date: 12/19/2019 8:19:10 PM ******/
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
/****** Object:  Table [dbo].[Sinhvien]    Script Date: 12/19/2019 8:19:10 PM ******/
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
ALTER TABLE [dbo].[Doan]  WITH CHECK ADD  CONSTRAINT [FK_Doan_Sinhvien] FOREIGN KEY([Id])
REFERENCES [dbo].[Sinhvien] ([Id])
GO
ALTER TABLE [dbo].[Doan] CHECK CONSTRAINT [FK_Doan_Sinhvien]
GO
ALTER TABLE [dbo].[Nhom]  WITH CHECK ADD  CONSTRAINT [FK_Nhom_Sinhvien1] FOREIGN KEY([Id])
REFERENCES [dbo].[Sinhvien] ([Id])
GO
ALTER TABLE [dbo].[Nhom] CHECK CONSTRAINT [FK_Nhom_Sinhvien1]
GO
