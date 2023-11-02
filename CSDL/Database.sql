USE [master]
GO
/****** Object:  Database [QL_VanPhongPham]    Script Date: 31/10/2023 20:26:26 ******/
CREATE DATABASE [QL_CuaHangTienLoi_New]
GO
USE [QL_CuaHangTienLoi_New]
GO
/****** Object:  Table [dbo].[CHITIETHDBAN]    Script Date: 31/10/2023 20:26:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETHDBAN](
	[MAHDBAN] [nvarchar](30) NOT NULL,
	[MASP] [nvarchar](10) NOT NULL,
	[SOLUONGMUA] [int] NOT NULL,
	[DONGIA] [float] NOT NULL,
	[GIAMGIA] [float] NOT NULL,
	[THANHTIEN] [float] NOT NULL,
 CONSTRAINT [PK_CHITIETHDBAN] PRIMARY KEY CLUSTERED 
(
	[MAHDBAN] ASC,
	[MASP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CHITIETNHAPHANG]    Script Date: 31/10/2023 20:26:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETNHAPHANG](
	[ID] [char](5) NOT NULL,
	[MANHAPHANG] [char](25) NOT NULL,
	[MASP] [nvarchar](10) NOT NULL,
	[GIA] [float] NOT NULL,
	[SOLUONG] [int] NOT NULL,
	[TONG] [float] NOT NULL,
 CONSTRAINT [PK_CHITIETNHAPHANG] PRIMARY KEY CLUSTERED 
(
	[ID] ASC,
	[MANHAPHANG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CHUCVU]    Script Date: 31/10/2023 20:26:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHUCVU](
	[MACHUCVU] [nvarchar](10) NOT NULL,
	[TENCHUCVU] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_CHUCVU] PRIMARY KEY CLUSTERED 
(
	[MACHUCVU] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HDBAN]    Script Date: 31/10/2023 20:26:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HDBAN](
	[MAHDBAN] [nvarchar](30) NOT NULL,
	[MANHANVIEN] [nvarchar](10) NOT NULL,
	[NGAYBAN] [date] NOT NULL,
	[MAKHACH] [nvarchar](10) NOT NULL,
	[TONGTIEN] [float] NOT NULL,
 CONSTRAINT [PK_HDBAN] PRIMARY KEY CLUSTERED 
(
	[MAHDBAN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHACH]    Script Date: 31/10/2023 20:26:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACH](
	[MAKHACH] [nvarchar](10) NOT NULL,
	[TENKHACH] [nvarchar](40) NOT NULL,
	[DIACHI_KH] [nvarchar](50) NOT NULL,
	[DIENTHOAI_KH] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_KHACH] PRIMARY KEY CLUSTERED 
(
	[MAKHACH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOAISP]    Script Date: 31/10/2023 20:26:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAISP](
	[MALOAI] [nvarchar](10) NOT NULL,
	[TENLOAI] [nvarchar](40) NOT NULL,
 CONSTRAINT [PK_LOAISP] PRIMARY KEY CLUSTERED 
(
	[MALOAI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHACUNGCAP]    Script Date: 31/10/2023 20:26:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHACUNGCAP](
	[MANCC] [char](20) NOT NULL,
	[TENNCC] [nvarchar](255) NOT NULL,
	[DIACHINCC] [nvarchar](255) NOT NULL,
	[EMAIL] [varchar](50) NOT NULL,
	[SDTNCC] [char](15) NOT NULL,
 CONSTRAINT [PK_NHACUNGCAP] PRIMARY KEY CLUSTERED 
(
	[MANCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 31/10/2023 20:26:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MANHANVIEN] [nvarchar](10) NOT NULL,
	[TENNHANVIEN] [nvarchar](50) NOT NULL,
	[MACHUCVU] [nvarchar](10) NOT NULL,
	[GIOITINH] [nvarchar](5) NOT NULL,
	[DIACHI_NV] [nvarchar](50) NOT NULL,
	[DIENTHOAI_NV] [nvarchar](20) NOT NULL,
	[NGAYSINH] [datetime] NULL,
 CONSTRAINT [PK_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[MANHANVIEN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHAPHANG]    Script Date: 31/10/2023 20:26:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHAPHANG](
	[MANHAPHANG] [char](25) NOT NULL,
	[NGAYTAO] [datetime] NOT NULL,
	[TONGTIEN] [float] NOT NULL,
	[MANHANVIEN] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_NHAPHANG] PRIMARY KEY CLUSTERED 
(
	[MANHAPHANG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QUYEN]    Script Date: 31/10/2023 20:26:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QUYEN](
	[MAQUYEN] [int] IDENTITY(1,1) NOT NULL,
	[TENQUYEN] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_QUYEN] PRIMARY KEY CLUSTERED 
(
	[MAQUYEN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SANPHAM]    Script Date: 31/10/2023 20:26:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SANPHAM](
	[MASP] [nvarchar](10) NOT NULL,
	[TENSP] [nvarchar](50) NOT NULL,
	[DONVI] [nvarchar](50) NULL,
	[SOLUONG] [int] NOT NULL,
	[DONGIABAN] [float] NOT NULL,
	[HINHANH] [image] NULL,
	[MALOAI] [nvarchar](10) NOT NULL,
	[MANCC] [char](20) NULL,
 CONSTRAINT [PK_HANG] PRIMARY KEY CLUSTERED 
(
	[MASP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TAIKHOAN]    Script Date: 31/10/2023 20:26:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TAIKHOAN](
	[MATAIKHOAN] [int] IDENTITY(1,1) NOT NULL,
	[TAIKHOAN] [nvarchar](50) NOT NULL,
	[MATKHAU] [nvarchar](50) NOT NULL,
	[EMAIL] [varchar](50) NULL,
	[MAQUYEN] [int] NULL,
	[MANHANVIEN] [nvarchar](10) NULL,
 CONSTRAINT [PK_TAIKHOAN] PRIMARY KEY CLUSTERED 
(
	[MATAIKHOAN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CHITIETHDBAN] ([MAHDBAN], [MASP], [SOLUONGMUA], [DONGIA], [GIAMGIA], [THANHTIEN]) VALUES (N'HDB1162022154726 PM', N'HH001', 2, 18000, 0, 36000)
GO
INSERT [dbo].[CHUCVU] ([MACHUCVU], [TENCHUCVU]) VALUES (N'CV001', N'Nhân viên')
INSERT [dbo].[CHUCVU] ([MACHUCVU], [TENCHUCVU]) VALUES (N'CV002', N'Quản lý')
GO
INSERT [dbo].[HDBAN] ([MAHDBAN], [MANHANVIEN], [NGAYBAN], [MAKHACH], [TONGTIEN]) VALUES (N'HDB10062022144726 PM', N'NV001', CAST(N'2022-06-10' AS Date), N'KH001', 0)
INSERT [dbo].[HDBAN] ([MAHDBAN], [MANHANVIEN], [NGAYBAN], [MAKHACH], [TONGTIEN]) VALUES (N'HDB10062022154726 PM', N'NV002', CAST(N'2022-06-10' AS Date), N'KH002', 0)
INSERT [dbo].[HDBAN] ([MAHDBAN], [MANHANVIEN], [NGAYBAN], [MAKHACH], [TONGTIEN]) VALUES (N'HDB11062022154726 PM', N'NV002', CAST(N'2022-06-10' AS Date), N'KH003', 0)
INSERT [dbo].[HDBAN] ([MAHDBAN], [MANHANVIEN], [NGAYBAN], [MAKHACH], [TONGTIEN]) VALUES (N'HDB1162022154726 PM', N'NV004', CAST(N'2023-10-04' AS Date), N'KH003', 0)
GO
INSERT [dbo].[KHACH] ([MAKHACH], [TENKHACH], [DIACHI_KH], [DIENTHOAI_KH]) VALUES (N'KH001', N'Nguyễn Vip Tông', N'Cần Thơ', N'092817212721')
INSERT [dbo].[KHACH] ([MAKHACH], [TENKHACH], [DIACHI_KH], [DIENTHOAI_KH]) VALUES (N'KH002', N'Nguyễn Hỷ Nam', N'Củ Chi', N'092883281222')
INSERT [dbo].[KHACH] ([MAKHACH], [TENKHACH], [DIACHI_KH], [DIENTHOAI_KH]) VALUES (N'KH003', N'Trần Nhân Hồng', N'Q1,TPHCM', N'09282391212')
INSERT [dbo].[KHACH] ([MAKHACH], [TENKHACH], [DIACHI_KH], [DIENTHOAI_KH]) VALUES (N'KH004', N'Lê Na', N'Tân Bình', N'0987873882392')
INSERT [dbo].[KHACH] ([MAKHACH], [TENKHACH], [DIACHI_KH], [DIENTHOAI_KH]) VALUES (N'KH005', N'Dương Nhân Từ', N'Tân Bình', N'09721313392')
INSERT [dbo].[KHACH] ([MAKHACH], [TENKHACH], [DIACHI_KH], [DIENTHOAI_KH]) VALUES (N'KH006', N'Trần Lê Bá Cháy', N'Tân Phú', N'09721823392')
GO
INSERT [dbo].[LOAISP] ([MALOAI], [TENLOAI]) VALUES (N'LH001', N'Giấy In Ấn - Photo')
INSERT [dbo].[LOAISP] ([MALOAI], [TENLOAI]) VALUES (N'LH002', N'Sổ - Tập - Bao Thư')
INSERT [dbo].[LOAISP] ([MALOAI], [TENLOAI]) VALUES (N'LH003', N'Máy Tính Casio')
INSERT [dbo].[LOAISP] ([MALOAI], [TENLOAI]) VALUES (N'LH004', N'Thiết Bị Văn Phòng')
INSERT [dbo].[LOAISP] ([MALOAI], [TENLOAI]) VALUES (N'LH005', N'Bút - Mực')
INSERT [dbo].[LOAISP] ([MALOAI], [TENLOAI]) VALUES (N'LH006', N'Băng Keo - Dao - Kéo')
GO
INSERT [dbo].[NHANVIEN] ([MANHANVIEN], [TENNHANVIEN], [MACHUCVU], [GIOITINH], [DIACHI_NV], [DIENTHOAI_NV], [NGAYSINH]) VALUES (N'NV001', N'Trần Quyết Chiến', N'CV001', N'Nam', N'Q12,TPHCM', N'092817212721', CAST(N'2003-02-03T00:00:00.000' AS DateTime))
INSERT [dbo].[NHANVIEN] ([MANHANVIEN], [TENNHANVIEN], [MACHUCVU], [GIOITINH], [DIACHI_NV], [DIENTHOAI_NV], [NGAYSINH]) VALUES (N'NV002', N'Lê Thị Mười Điểm', N'CV002', N'Nữ', N'Q11,TPHCM', N'09288328392', CAST(N'2002-09-03T00:00:00.000' AS DateTime))
INSERT [dbo].[NHANVIEN] ([MANHANVIEN], [TENNHANVIEN], [MACHUCVU], [GIOITINH], [DIACHI_NV], [DIENTHOAI_NV], [NGAYSINH]) VALUES (N'NV003', N'Trần Hân Hoan', N'CV001', N'Nam', N'H?c Môn,TPHCM', N'09289291212', CAST(N'2001-02-08T00:00:00.000' AS DateTime))
INSERT [dbo].[NHANVIEN] ([MANHANVIEN], [TENNHANVIEN], [MACHUCVU], [GIOITINH], [DIACHI_NV], [DIENTHOAI_NV], [NGAYSINH]) VALUES (N'NV004', N'Võ Thị Bé Ba', N'CV001', N'Nữ', N'Tân Bình,TPHCM', N'097837882392', CAST(N'2004-12-02T00:00:00.000' AS DateTime))
INSERT [dbo].[NHANVIEN] ([MANHANVIEN], [TENNHANVIEN], [MACHUCVU], [GIOITINH], [DIACHI_NV], [DIENTHOAI_NV], [NGAYSINH]) VALUES (N'NV005', N'Đoàn Văn Sang', N'CV002', N'Nam', N'H?c Môn,TPHCM', N'097837882369', CAST(N'2002-05-16T00:00:00.000' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[QUYEN] ON 

INSERT [dbo].[QUYEN] ([MAQUYEN], [TENQUYEN]) VALUES (1, N'Admin')
INSERT [dbo].[QUYEN] ([MAQUYEN], [TENQUYEN]) VALUES (2, N'Nhân Viên')
SET IDENTITY_INSERT [dbo].[QUYEN] OFF
GO
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [DONVI], [SOLUONG], [DONGIABAN], [HINHANH], [MALOAI], [MANCC]) VALUES (N'HH001', N'Decal in Nhiệt A7 Cuộn - 75x100mm - 300 tem', NULL, 500, 18000, NULL, N'LH001', NULL)
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [DONVI], [SOLUONG], [DONGIABAN], [HINHANH], [MALOAI], [MANCC]) VALUES (N'HH002', N'Giấy A4 Double A 70 Gsm', NULL, 500, 30000, NULL, N'LH001', NULL)
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [DONVI], [SOLUONG], [DONGIABAN], [HINHANH], [MALOAI], [MANCC]) VALUES (N'HH003', N'Giấy Fort 70g màu hồng A4', NULL, 500, 118000, NULL, N'LH001', NULL)
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [DONVI], [SOLUONG], [DONGIABAN], [HINHANH], [MALOAI], [MANCC]) VALUES (N'HH004', N'Giấy in vi tính Liên Sơn 4 liên A4 210x279', NULL, 500, 182000, NULL, N'LH001', NULL)
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [DONVI], [SOLUONG], [DONGIABAN], [HINHANH], [MALOAI], [MANCC]) VALUES (N'HH005', N'Máy tính FX570', NULL, 500, 500000, NULL, N'LH003', NULL)
GO
SET IDENTITY_INSERT [dbo].[TAIKHOAN] ON 

INSERT [dbo].[TAIKHOAN] ([MATAIKHOAN], [TAIKHOAN], [MATKHAU], [EMAIL], [MAQUYEN], [MANHANVIEN]) VALUES (1, N'Admin', N'123', N'admin@gmail.com', 1, N'NV001')
INSERT [dbo].[TAIKHOAN] ([MATAIKHOAN], [TAIKHOAN], [MATKHAU], [EMAIL], [MAQUYEN], [MANHANVIEN]) VALUES (2, N'Sang', N'123', N'sang@gmail.com', 2, N'NV005')
SET IDENTITY_INSERT [dbo].[TAIKHOAN] OFF
GO
ALTER TABLE [dbo].[CHITIETHDBAN]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETHDBAN_HDBAN] FOREIGN KEY([MAHDBAN])
REFERENCES [dbo].[HDBAN] ([MAHDBAN])
GO
ALTER TABLE [dbo].[CHITIETHDBAN] CHECK CONSTRAINT [FK_CHITIETHDBAN_HDBAN]
GO
ALTER TABLE [dbo].[CHITIETHDBAN]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETHDBAN_SANPHAM] FOREIGN KEY([MASP])
REFERENCES [dbo].[SANPHAM] ([MASP])
GO
ALTER TABLE [dbo].[CHITIETHDBAN] CHECK CONSTRAINT [FK_CHITIETHDBAN_SANPHAM]
GO
ALTER TABLE [dbo].[CHITIETNHAPHANG]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETNHAPHANG_NHAPHANG] FOREIGN KEY([MANHAPHANG])
REFERENCES [dbo].[NHAPHANG] ([MANHAPHANG])
GO
ALTER TABLE [dbo].[CHITIETNHAPHANG] CHECK CONSTRAINT [FK_CHITIETNHAPHANG_NHAPHANG]
GO
ALTER TABLE [dbo].[CHITIETNHAPHANG]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETNHAPHANG_SANPHAM] FOREIGN KEY([MASP])
REFERENCES [dbo].[SANPHAM] ([MASP])
GO
ALTER TABLE [dbo].[CHITIETNHAPHANG] CHECK CONSTRAINT [FK_CHITIETNHAPHANG_SANPHAM]
GO
ALTER TABLE [dbo].[HDBAN]  WITH CHECK ADD  CONSTRAINT [FK_HDBAN_KHACH] FOREIGN KEY([MAKHACH])
REFERENCES [dbo].[KHACH] ([MAKHACH])
GO
ALTER TABLE [dbo].[HDBAN] CHECK CONSTRAINT [FK_HDBAN_KHACH]
GO
ALTER TABLE [dbo].[HDBAN]  WITH CHECK ADD  CONSTRAINT [FK_HDBAN_NHANVIEN] FOREIGN KEY([MANHANVIEN])
REFERENCES [dbo].[NHANVIEN] ([MANHANVIEN])
GO
ALTER TABLE [dbo].[HDBAN] CHECK CONSTRAINT [FK_HDBAN_NHANVIEN]
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [FK_NHANVIEN_CHUCVU] FOREIGN KEY([MACHUCVU])
REFERENCES [dbo].[CHUCVU] ([MACHUCVU])
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [FK_NHANVIEN_CHUCVU]
GO
ALTER TABLE [dbo].[NHAPHANG]  WITH CHECK ADD  CONSTRAINT [FK_NHAPHANG_NHANVIEN] FOREIGN KEY([MANHANVIEN])
REFERENCES [dbo].[NHANVIEN] ([MANHANVIEN])
GO
ALTER TABLE [dbo].[NHAPHANG] CHECK CONSTRAINT [FK_NHAPHANG_NHANVIEN]
GO
ALTER TABLE [dbo].[SANPHAM]  WITH CHECK ADD  CONSTRAINT [FK_SANPHAM_LOAISP] FOREIGN KEY([MALOAI])
REFERENCES [dbo].[LOAISP] ([MALOAI])
GO
ALTER TABLE [dbo].[SANPHAM] CHECK CONSTRAINT [FK_SANPHAM_LOAISP]
GO
ALTER TABLE [dbo].[SANPHAM]  WITH CHECK ADD  CONSTRAINT [FK_SANPHAM_NHACUNGCAP] FOREIGN KEY([MANCC])
REFERENCES [dbo].[NHACUNGCAP] ([MANCC])
GO
ALTER TABLE [dbo].[SANPHAM] CHECK CONSTRAINT [FK_SANPHAM_NHACUNGCAP]
GO
ALTER TABLE [dbo].[TAIKHOAN]  WITH CHECK ADD  CONSTRAINT [FK_TAIKHOAN_NHANVIEN] FOREIGN KEY([MANHANVIEN])
REFERENCES [dbo].[NHANVIEN] ([MANHANVIEN])
GO
ALTER TABLE [dbo].[TAIKHOAN] CHECK CONSTRAINT [FK_TAIKHOAN_NHANVIEN]
GO
ALTER TABLE [dbo].[TAIKHOAN]  WITH CHECK ADD  CONSTRAINT [FK_TAIKHOAN_QUYEN] FOREIGN KEY([MAQUYEN])
REFERENCES [dbo].[QUYEN] ([MAQUYEN])
GO
ALTER TABLE [dbo].[TAIKHOAN] CHECK CONSTRAINT [FK_TAIKHOAN_QUYEN]
GO
USE [master]
GO
ALTER DATABASE [QL_VanPhongPham] SET  READ_WRITE 
GO

select * from SANPHAM