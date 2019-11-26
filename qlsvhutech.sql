USE [QuanLyDoAn]
GO
/****** Object:  Table [dbo].[admin]    Script Date: 11/26/2019 8:17:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[admin](
	[taikhoan] [nchar](20) NOT NULL,
	[matkhua] [nchar](16) NULL,
 CONSTRAINT [PK_ThuKyKhoa] PRIMARY KEY CLUSTERED 
(
	[taikhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[doan]    Script Date: 11/26/2019 8:17:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[doan](
	[mada] [nchar](20) NOT NULL,
	[tenda] [nvarchar](50) NULL,
	[thoigianbd] [date] NULL,
	[thoigiankt] [date] NULL,
 CONSTRAINT [PK_DoAn_1] PRIMARY KEY CLUSTERED 
(
	[mada] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[gvhd]    Script Date: 11/26/2019 8:17:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[gvhd](
	[magv] [nchar](20) NOT NULL,
	[matkhau] [nchar](16) NULL,
	[hotengv] [nvarchar](150) NULL,
	[email] [nvarchar](150) NULL,
	[mada] [nchar](10) NULL,
 CONSTRAINT [PK_GiangVien] PRIMARY KEY CLUSTERED 
(
	[magv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[nhom]    Script Date: 11/26/2019 8:17:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nhom](
	[manhom] [nchar](20) NOT NULL,
	[mssv] [nchar](20) NOT NULL,
 CONSTRAINT [PK_NhomDA_1] PRIMARY KEY CLUSTERED 
(
	[manhom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ptda]    Script Date: 11/26/2019 8:17:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ptda](
	[magv] [nchar](20) NULL,
	[mada] [nchar](20) NOT NULL,
	[mssv] [nchar](20) NOT NULL,
	[diem] [int] NULL,
 CONSTRAINT [PK_pthd] PRIMARY KEY CLUSTERED 
(
	[mada] ASC,
	[mssv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[sinhvien]    Script Date: 11/26/2019 8:17:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sinhvien](
	[mssv] [nchar](20) NOT NULL,
	[matkhau] [nchar](16) NULL,
	[hoten] [nvarchar](150) NULL,
	[email] [nchar](50) NULL,
	[gioitinh] [bit] NULL,
	[manhom] [nchar](20) NULL,
 CONSTRAINT [PK_SinhVien] PRIMARY KEY CLUSTERED 
(
	[mssv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[ptda]  WITH CHECK ADD  CONSTRAINT [FK_ptda_doan] FOREIGN KEY([mada])
REFERENCES [dbo].[doan] ([mada])
GO
ALTER TABLE [dbo].[ptda] CHECK CONSTRAINT [FK_ptda_doan]
GO
ALTER TABLE [dbo].[ptda]  WITH CHECK ADD  CONSTRAINT [FK_ptda_gvhd] FOREIGN KEY([magv])
REFERENCES [dbo].[gvhd] ([magv])
GO
ALTER TABLE [dbo].[ptda] CHECK CONSTRAINT [FK_ptda_gvhd]
GO
ALTER TABLE [dbo].[ptda]  WITH CHECK ADD  CONSTRAINT [FK_ptda_sinhvien] FOREIGN KEY([mssv])
REFERENCES [dbo].[sinhvien] ([mssv])
GO
ALTER TABLE [dbo].[ptda] CHECK CONSTRAINT [FK_ptda_sinhvien]
GO
ALTER TABLE [dbo].[sinhvien]  WITH CHECK ADD  CONSTRAINT [FK_sinhvien_nhom1] FOREIGN KEY([manhom])
REFERENCES [dbo].[nhom] ([manhom])
GO
ALTER TABLE [dbo].[sinhvien] CHECK CONSTRAINT [FK_sinhvien_nhom1]
GO
