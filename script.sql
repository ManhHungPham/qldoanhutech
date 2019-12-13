USE [QuanLyDoAn]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 12/13/2019 11:43:38 PM ******/
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
/****** Object:  Table [dbo].[Doan]    Script Date: 12/13/2019 11:43:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doan](
	[Mada] [int] NOT NULL,
	[Tenda] [nvarchar](50) NULL,
	[Thoigianbd] [date] NULL,
	[Thoigiankt] [date] NULL,
 CONSTRAINT [PK_DoAn_1] PRIMARY KEY CLUSTERED 
(
	[Mada] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Gvhd]    Script Date: 12/13/2019 11:43:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gvhd](
	[Magv] [int] NOT NULL,
	[Matkhau] [nchar](50) NULL,
	[Hotengv] [nvarchar](150) NULL,
	[Email] [nvarchar](150) NULL,
	[Mada] [int] NULL,
 CONSTRAINT [PK_GiangVien] PRIMARY KEY CLUSTERED 
(
	[Magv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Nhom]    Script Date: 12/13/2019 11:43:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nhom](
	[Manhom] [int] NOT NULL,
	[Tennhom] [nvarchar](50) NULL,
 CONSTRAINT [PK_NhomDA_1] PRIMARY KEY CLUSTERED 
(
	[Manhom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Ptda]    Script Date: 12/13/2019 11:43:38 PM ******/
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
/****** Object:  Table [dbo].[Sinhvien]    Script Date: 12/13/2019 11:43:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Sinhvien](
	[Hoten] [nvarchar](50) NULL,
	[Matkhau] [nvarchar](50) NULL,
	[Email] [nchar](50) NULL,
	[Gioitinh] [bit] NULL,
	[Manhom] [int] NULL,
	[Taikhoan] [nchar](50) NULL,
	[Sdt] [varchar](20) NULL,
	[Hinh] [nvarchar](50) NULL,
	[Id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Sinhvien] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Nhom]  WITH CHECK ADD  CONSTRAINT [FK_Nhom_Sinhvien] FOREIGN KEY([Manhom])
REFERENCES [dbo].[Sinhvien] ([Id])
GO
ALTER TABLE [dbo].[Nhom] CHECK CONSTRAINT [FK_Nhom_Sinhvien]
GO
ALTER TABLE [dbo].[Ptda]  WITH CHECK ADD  CONSTRAINT [FK_ptda_doan] FOREIGN KEY([Mada])
REFERENCES [dbo].[Doan] ([Mada])
GO
ALTER TABLE [dbo].[Ptda] CHECK CONSTRAINT [FK_ptda_doan]
GO
ALTER TABLE [dbo].[Ptda]  WITH CHECK ADD  CONSTRAINT [FK_Ptda_Gvhd1] FOREIGN KEY([Mada])
REFERENCES [dbo].[Gvhd] ([Magv])
GO
ALTER TABLE [dbo].[Ptda] CHECK CONSTRAINT [FK_Ptda_Gvhd1]
GO
ALTER TABLE [dbo].[Ptda]  WITH CHECK ADD  CONSTRAINT [FK_Ptda_Sinhvien] FOREIGN KEY([Mssv])
REFERENCES [dbo].[Sinhvien] ([Id])
GO
ALTER TABLE [dbo].[Ptda] CHECK CONSTRAINT [FK_Ptda_Sinhvien]
GO
