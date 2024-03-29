USE [master]
GO
/****** Object:  Database [QL_library]    Script Date: 06/04/2019 20:04:07 ******/
CREATE DATABASE [QL_library] ON  PRIMARY 
( NAME = N'QL_library', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\QL_library.mdf' , SIZE = 2304KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QL_library_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\QL_library_log.LDF' , SIZE = 768KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QL_library] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QL_library].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QL_library] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [QL_library] SET ANSI_NULLS OFF
GO
ALTER DATABASE [QL_library] SET ANSI_PADDING OFF
GO
ALTER DATABASE [QL_library] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [QL_library] SET ARITHABORT OFF
GO
ALTER DATABASE [QL_library] SET AUTO_CLOSE ON
GO
ALTER DATABASE [QL_library] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [QL_library] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [QL_library] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [QL_library] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [QL_library] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [QL_library] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [QL_library] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [QL_library] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [QL_library] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [QL_library] SET  ENABLE_BROKER
GO
ALTER DATABASE [QL_library] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [QL_library] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [QL_library] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [QL_library] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [QL_library] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [QL_library] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [QL_library] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [QL_library] SET  READ_WRITE
GO
ALTER DATABASE [QL_library] SET RECOVERY SIMPLE
GO
ALTER DATABASE [QL_library] SET  MULTI_USER
GO
ALTER DATABASE [QL_library] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [QL_library] SET DB_CHAINING OFF
GO
USE [QL_library]
GO
/****** Object:  Table [dbo].[Doc_gia]    Script Date: 06/04/2019 20:04:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doc_gia](
	[MaDg] [nvarchar](50) NOT NULL,
	[TenDg] [nvarchar](50) NULL,
	[GioiTinh] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDg] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Doc_gia] ([MaDg], [TenDg], [GioiTinh], [DiaChi], [SDT]) VALUES (N'DG1', N'Nguyễn Thị Linh', N'Nữ', N'Quảng Ninh', N'0002234')
INSERT [dbo].[Doc_gia] ([MaDg], [TenDg], [GioiTinh], [DiaChi], [SDT]) VALUES (N'DG2', N'Hanna Giang', N'Nữ', N'Hà Nội', N'0124')
INSERT [dbo].[Doc_gia] ([MaDg], [TenDg], [GioiTinh], [DiaChi], [SDT]) VALUES (N'DG3', N'Trung Bảo', N'Nam', N'Hà Nội', N'035234')
INSERT [dbo].[Doc_gia] ([MaDg], [TenDg], [GioiTinh], [DiaChi], [SDT]) VALUES (N'DG4', N'Dũng óc chó', N'bê dê ', N'quảng ninh ', N'0381259249529')
INSERT [dbo].[Doc_gia] ([MaDg], [TenDg], [GioiTinh], [DiaChi], [SDT]) VALUES (N'DG5', N'Sa lêm ', N'Nữ', N'252 Đông mỹ Thanh Trì Hà Nội', N'0962907184')
/****** Object:  Table [dbo].[Dau_Sach]    Script Date: 06/04/2019 20:04:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dau_Sach](
	[MaDS] [nvarchar](50) NOT NULL,
	[TenDS] [nvarchar](50) NOT NULL,
	[LinhVuc] [nvarchar](50) NULL,
	[NXB] [nvarchar](50) NULL,
	[TacGia] [nvarchar](50) NULL,
	[NgayXB] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDS] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Dau_Sach] ([MaDS], [TenDS], [LinhVuc], [NXB], [TacGia], [NgayXB]) VALUES (N'DS1', N'Vị giám đốc 1 phút', N'Kinh tế', N'Kim Đồng', N'Hải Sơn', N'02/11/2015')
INSERT [dbo].[Dau_Sach] ([MaDS], [TenDS], [LinhVuc], [NXB], [TacGia], [NgayXB]) VALUES (N'DS10', N'Sách cực hay', N'Tâm lý', N'Kim Đồng', N'Fat Sa', N'02/11/2016')
INSERT [dbo].[Dau_Sach] ([MaDS], [TenDS], [LinhVuc], [NXB], [TacGia], [NgayXB]) VALUES (N'DS2', N'Nghĩ giàu làm giàu', N'Kinh tế', N'Hà Nội', N'Hải Sơn', N'18/06/2014')
INSERT [dbo].[Dau_Sach] ([MaDS], [TenDS], [LinhVuc], [NXB], [TacGia], [NgayXB]) VALUES (N'DS3', N'Toán cao cấp', N'Giáo dục', N'Kim Đồng', N'Xuân Dũng', N'14/05/2018')
INSERT [dbo].[Dau_Sach] ([MaDS], [TenDS], [LinhVuc], [NXB], [TacGia], [NgayXB]) VALUES (N'DS4', N'Chí phèo', N'Văn học', N'Kim Đồng', N'Nam Cao', N'15/11/1998')
INSERT [dbo].[Dau_Sach] ([MaDS], [TenDS], [LinhVuc], [NXB], [TacGia], [NgayXB]) VALUES (N'DS5', N'Think and grow rich', N'Kinh tế', N'Thaihabook', N'Napoleon Hill', N'12/09/1998')
INSERT [dbo].[Dau_Sach] ([MaDS], [TenDS], [LinhVuc], [NXB], [TacGia], [NgayXB]) VALUES (N'DS6', N'What is right & wrong?', N'Tâm lý', N'Haisonbook', N'Hải Sơn', N'02/11/2018')
INSERT [dbo].[Dau_Sach] ([MaDS], [TenDS], [LinhVuc], [NXB], [TacGia], [NgayXB]) VALUES (N'DS7', N'PewPew', N'Tâm lý', N'Cretory', N'Pewnoy', N'28/06/1997')
INSERT [dbo].[Dau_Sach] ([MaDS], [TenDS], [LinhVuc], [NXB], [TacGia], [NgayXB]) VALUES (N'ds8', N'Dũng óc chó', N'Tâm linh', N'Kim Đồng', N'Hải Sơn', N'12/07/2009')
INSERT [dbo].[Dau_Sach] ([MaDS], [TenDS], [LinhVuc], [NXB], [TacGia], [NgayXB]) VALUES (N'DS9', N'Sa lêm', N'Romantic', N'Salembook', N'Hải Sơn', N'02/11/2015')
/****** Object:  Table [dbo].[Account]    Script Date: 06/04/2019 20:04:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[usename] [nvarchar](50) NOT NULL,
	[pass] [nvarchar](50) NOT NULL,
	[tenhienthi] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[usename] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Account] ([usename], [pass], [tenhienthi]) VALUES (N'admin', N'1', N'ADMIN')
INSERT [dbo].[Account] ([usename], [pass], [tenhienthi]) VALUES (N'haison123', N'quynhanh98', N'Hải Sơn')
INSERT [dbo].[Account] ([usename], [pass], [tenhienthi]) VALUES (N'salemm1209', N'021198', N'Quỳnh Anh')
INSERT [dbo].[Account] ([usename], [pass], [tenhienthi]) VALUES (N'xuandung911', N'quangningngu', N'Xuân Dũng')
/****** Object:  Table [dbo].[Thu_thu]    Script Date: 06/04/2019 20:04:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Thu_thu](
	[MaTT] [nvarchar](50) NOT NULL,
	[TenTT] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](50) NOT NULL,
	[GioiTinh] [nvarchar](50) NULL,
	[SDT] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTT] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Thu_thu] ([MaTT], [TenTT], [DiaChi], [GioiTinh], [SDT]) VALUES (N'01', N'Hải Sơn', N'Hà Nội', N'Nam', N'0328791072')
INSERT [dbo].[Thu_thu] ([MaTT], [TenTT], [DiaChi], [GioiTinh], [SDT]) VALUES (N'02', N'Văn Tùng', N'Nam Định', N'Nữ', N'0243113')
/****** Object:  StoredProcedure [dbo].[insert_acc]    Script Date: 06/04/2019 20:04:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insert_acc]
		@usename NVARCHAR(50),
		@pass NVARCHAR(50),
		@tenhienthi NVARCHAR(50)
AS
BEGIN
	INSERT INTO dbo.Account
	        ( usename, pass, tenhienthi )
	VALUES  ( @usename, -- usename - nvarchar(50)
	          @pass, -- pass - nvarchar(50)
	          @tenhienthi  -- tenhienthi - nvarchar(50)
	          )
END
GO
/****** Object:  StoredProcedure [dbo].[update_docgia]    Script Date: 06/04/2019 20:04:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[update_docgia]
	@madg NVARCHAR(50),
	@tendg NVARCHAR(50),
	@gioitinh NVARCHAR(50),
	@diachi NVARCHAR(50),
	@sdt NVARCHAR(50)
AS
BEGIN
	UPDATE dbo.Doc_gia
	SET
		TenDg=@tendg,
		GioiTinh=@gioitinh,
		DiaChi=@diachi,
		SDT=@sdt
	WHERE MaDg=@madg
END
GO
/****** Object:  StoredProcedure [dbo].[update_dausach]    Script Date: 06/04/2019 20:04:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[update_dausach]
	@mads NVARCHAR(50),
	@tends NVARCHAR(50),
	@linhvuc NVARCHAR(50),
	@nxb NVARCHAR(50),
	@tacgia NVARCHAR(50),
	@ngayxb NVARCHAR(50)
AS
BEGIN
	UPDATE dbo.Dau_Sach
	SET 
		TenDS=@tends,
		LinhVuc=@linhvuc,
		NXB=@nxb,
		TacGia=@tacgia,
		NgayXB=@ngayxb
	WHERE MaDS=@mads
END
select * from Dau_Sach where TenDS like N'%Vị%'
select * from Dau_Sach where MaDS like N'%s1%'
GO
/****** Object:  StoredProcedure [dbo].[update_acc]    Script Date: 06/04/2019 20:04:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[update_acc] 
	@usename NVARCHAR(50),
	@pass NVARCHAR(50)
	
AS
BEGIN
	UPDATE dbo.Account
	SET
		pass=@pass
	WHERE
		usename = @usename
END
GO
/****** Object:  StoredProcedure [dbo].[insert_docgia]    Script Date: 06/04/2019 20:04:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insert_docgia]
	@madg NVARCHAR(50),
	@tendg NVARCHAR(50),
	@gioitinh NVARCHAR(50),
	@diachi NVARCHAR(50),
	@sdt NVARCHAR(50)
AS
BEGIN
	INSERT INTO dbo.Doc_gia
	        ( MaDg, TenDg, GioiTinh, DiaChi, SDT )
	VALUES  ( @madg, -- MaDg - nvarchar(50)
	          @tendg, -- TenDg - nvarchar(50)
	          @gioitinh, -- GioiTinh - nvarchar(50)
	          @diachi, -- DiaChi - nvarchar(50)
	          @sdt  -- SDT - nvarchar(50)
	          )
END
GO
/****** Object:  StoredProcedure [dbo].[insert_dausach]    Script Date: 06/04/2019 20:04:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insert_dausach]
	@mads NVARCHAR(50),
	@tends NVARCHAR(50),
	@linhvuc NVARCHAR(50),
	@nxb NVARCHAR(50),
	@tacgia NVARCHAR(50),
	@ngayxb NVARCHAR(50)
AS
BEGIN
	INSERT INTO dbo.Dau_Sach
	        ( MaDS ,
	          TenDS ,
	          LinhVuc ,
	          NXB ,
	          TacGia ,
	          NgayXB
	        )
	VALUES  ( @mads , -- MaDS - nvarchar(50)
	          @tends , -- TenDS - nvarchar(50)
	          @linhvuc , -- LinhVuc - nvarchar(50)
	          @nxb , -- NXB - nvarchar(50)
	          @tacgia , -- TacGia - nvarchar(50)
	          @ngayxb  -- NgayXB - datetime
	        )
END
GO
/****** Object:  StoredProcedure [dbo].[update_thuthu]    Script Date: 06/04/2019 20:04:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[update_thuthu]
	@matt NVARCHAR(50),
	@tentt NVARCHAR(50),
	@diachi NVARCHAR(50),
	@gt NVARCHAR(50),
	@sdt NVARCHAR(50)
AS
BEGIN
	UPDATE dbo.Thu_thu
	SET
		TenTT=@tentt,
		DiaChi=@diachi,
		GioiTinh=@gt,
		SDT=@sdt
	WHERE MaTT=@matt
END
GO
/****** Object:  StoredProcedure [dbo].[search_docgia]    Script Date: 06/04/2019 20:04:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[search_docgia]
	@tendg NVARCHAR(50)
AS
BEGIN
	SELECT *
	FROM dbo.Doc_gia
	WHERE TenDg=@tendg
END
GO
/****** Object:  StoredProcedure [dbo].[search_dausach]    Script Date: 06/04/2019 20:04:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[search_dausach]
	@tends NVARCHAR(50)
AS
BEGIN
	SELECT *
	FROM dbo.Dau_Sach
	WHERE TenDS=@tends
END
GO
/****** Object:  Table [dbo].[Sach]    Script Date: 06/04/2019 20:04:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sach](
	[MaSach] [nvarchar](50) NOT NULL,
	[MaDS] [nvarchar](50) NULL,
	[TinhTrang] [nvarchar](50) NULL,
	[TrangThai] [nvarchar](50) NULL,
	[SoLuotMuon] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Sach] ([MaSach], [MaDS], [TinhTrang], [TrangThai], [SoLuotMuon]) VALUES (N'S1.01', N'DS1', N'Mới', N'Đã mượn', 3)
INSERT [dbo].[Sach] ([MaSach], [MaDS], [TinhTrang], [TrangThai], [SoLuotMuon]) VALUES (N'S1.02', N'DS1', N'Cũ', N'Đã mượn', 3)
INSERT [dbo].[Sach] ([MaSach], [MaDS], [TinhTrang], [TrangThai], [SoLuotMuon]) VALUES (N'S1.03', N'DS1', N'Mới', N'Chưa mượn', 0)
INSERT [dbo].[Sach] ([MaSach], [MaDS], [TinhTrang], [TrangThai], [SoLuotMuon]) VALUES (N'S2.01', N'DS2', N'Cũ', N'Chưa mượn', 2)
INSERT [dbo].[Sach] ([MaSach], [MaDS], [TinhTrang], [TrangThai], [SoLuotMuon]) VALUES (N'S2.02', N'DS2', N'Cũ', N'Chưa mượn', 1)
INSERT [dbo].[Sach] ([MaSach], [MaDS], [TinhTrang], [TrangThai], [SoLuotMuon]) VALUES (N'S3.01', N'DS3', N'Cũ', N'Chưa mượn', 2)
INSERT [dbo].[Sach] ([MaSach], [MaDS], [TinhTrang], [TrangThai], [SoLuotMuon]) VALUES (N'S3.02', N'DS3', N'Cũ', N'Chưa mượn', 1)
INSERT [dbo].[Sach] ([MaSach], [MaDS], [TinhTrang], [TrangThai], [SoLuotMuon]) VALUES (N'S4.01', N'DS4', N'Cũ', N'Chưa mượn', 2)
INSERT [dbo].[Sach] ([MaSach], [MaDS], [TinhTrang], [TrangThai], [SoLuotMuon]) VALUES (N'S5.01', N'DS5', N'Mới', N'Chưa mượn', 1)
INSERT [dbo].[Sach] ([MaSach], [MaDS], [TinhTrang], [TrangThai], [SoLuotMuon]) VALUES (N'S5.02', N'DS5', N'Mói', N'Chưa mượn', 0)
INSERT [dbo].[Sach] ([MaSach], [MaDS], [TinhTrang], [TrangThai], [SoLuotMuon]) VALUES (N'S7.01', N'DS7', N'Mới', N'Chưa mượn', 0)
INSERT [dbo].[Sach] ([MaSach], [MaDS], [TinhTrang], [TrangThai], [SoLuotMuon]) VALUES (N'S7.02', N'DS7', N'Mới', N'Chưa mượn', 0)
INSERT [dbo].[Sach] ([MaSach], [MaDS], [TinhTrang], [TrangThai], [SoLuotMuon]) VALUES (N'S8.01', N'ds8', N'Mới', N'Chưa mượn', 1)
INSERT [dbo].[Sach] ([MaSach], [MaDS], [TinhTrang], [TrangThai], [SoLuotMuon]) VALUES (N'S8.02', N'ds8', N'Mới', N'Chưa mượn', 0)
INSERT [dbo].[Sach] ([MaSach], [MaDS], [TinhTrang], [TrangThai], [SoLuotMuon]) VALUES (N'S9.01', N'DS9', N'Mới', N'Chưa mượn', 0)
/****** Object:  Table [dbo].[Phieu_Muon]    Script Date: 06/04/2019 20:04:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phieu_Muon](
	[MaPM] [nvarchar](50) NOT NULL,
	[MaTT] [nvarchar](50) NULL,
	[NgayMuon] [nvarchar](50) NULL,
	[MaDg] [nvarchar](50) NULL,
	[TinhTrang] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPM] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Phieu_Muon] ([MaPM], [MaTT], [NgayMuon], [MaDg], [TinhTrang]) VALUES (N'PM1', N'01', N'12/09/2018', N'DG2', N'Chưa trả')
/****** Object:  StoredProcedure [dbo].[insert_thuthu]    Script Date: 06/04/2019 20:04:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insert_thuthu]
	@matt NVARCHAR(50),
	@tentt NVARCHAR(50),
	@diachi NVARCHAR(50),
	@gt NVARCHAR(50),
	@sdt NVARCHAR(50)
AS
BEGIN
	INSERT INTO dbo.Thu_thu
	        ( MaTT, TenTT, DiaChi, GioiTinh, SDT )
	VALUES  ( @matt, -- MaTT - nvarchar(50)
	          @tentt, -- TenTT - nvarchar(50)
	          @diachi, -- DiaChi - nvarchar(50)
	          @gt, -- GioiTinh - nvarchar(50)
	          @sdt  -- SDT - nvarchar(50)
	          )
END
GO
/****** Object:  StoredProcedure [dbo].[insert_sach]    Script Date: 06/04/2019 20:04:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insert_sach]
	@masach NVARCHAR(50),
	@mads NVARCHAR(50),
	@tinhtrang NVARCHAR(50)
AS
BEGIN
	INSERT INTO dbo.Sach
	        ( MaSach, MaDS, TinhTrang, TrangThai,SoLuotMuon )
	VALUES  ( @masach, -- MaSach - nvarchar(50)
	          @mads, -- MaDS - nvarchar(50)
	          @tinhtrang, -- TinhTrang - nvarchar(50)
	          N'Chưa mượn',
	          0  -- TrangThai - nvarchar(50)
	          )
END
GO
/****** Object:  StoredProcedure [dbo].[insert_pm]    Script Date: 06/04/2019 20:04:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insert_pm]
	@mapm NVARCHAR(50),
	@matt NVARCHAR(50),
	@ngaymuon NVARCHAR(50),
	@madg NVARCHAR(50)
AS
BEGIN
	INSERT INTO dbo.Phieu_Muon
	        ( MaPM, MaTT, NgayMuon, MaDg, TinhTrang )
	VALUES  ( @mapm, -- MaPM - nvarchar(50)
	          @matt, -- MaTT - nvarchar(50)
	          @ngaymuon, -- NgayMuon - datetime
	          @madg, -- MaDg - nvarchar(50)
	          N'Chưa trả'  -- TinhTrang - nvarchar(50)
	          )
END
GO
/****** Object:  StoredProcedure [dbo].[insert_phieumuon]    Script Date: 06/04/2019 20:04:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insert_phieumuon] 
	@mapm NVARCHAR(50),
	@matt NVARCHAR(50),
	@madg NVARCHAR(50),
	@ngaymuon NVARCHAR(50)
	
AS
BEGIN
	INSERT INTO dbo.Phieu_Muon
	        ( MaPM, MaTT, NgayMuon, MaDg, TinhTrang )
	VALUES  ( @mapm, -- MaPM - nvarchar(50)
	          @matt, -- MaTT - nvarchar(50)
	          @ngaymuon, -- NgayMuon - datetime
	          @madg, -- MaDg - nvarchar(50)
	          N'Chưa trả'  -- TinhTrang - nvarchar(50)
	          )
END
GO
/****** Object:  Table [dbo].[CTPM]    Script Date: 06/04/2019 20:04:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTPM](
	[MaPM] [nvarchar](50) NOT NULL,
	[MaSach] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPM] ASC,
	[MaSach] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CTPM] ([MaPM], [MaSach]) VALUES (N'PM1', N'S1.01')
INSERT [dbo].[CTPM] ([MaPM], [MaSach]) VALUES (N'PM1', N'S1.02')
/****** Object:  StoredProcedure [dbo].[delete_thuthu]    Script Date: 06/04/2019 20:04:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[delete_thuthu]
	@matt NVARCHAR(50)
	
AS
BEGIN
	DELETE dbo.Phieu_Muon WHERE MaTT =@matt
	DELETE dbo.Thu_thu WHERE MaTT = @matt
END
GO
/****** Object:  StoredProcedure [dbo].[search_phieumuon]    Script Date: 06/04/2019 20:04:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[search_phieumuon]
	@mapm NVARCHAR(50)
	
AS
BEGIN
	SELECT *
	FROM dbo.Phieu_Muon
	WHERE MaPM=@mapm
END
GO
/****** Object:  StoredProcedure [dbo].[delete_docgia]    Script Date: 06/04/2019 20:04:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[delete_docgia]
	@madg NVARCHAR(50)
	as
BEGIN
	DELETE FROM dbo.Phieu_Muon WHERE MaDg=@madg
	DELETE FROM dbo.Doc_gia WHERE MaDg =@madg
END
GO
/****** Object:  StoredProcedure [dbo].[delete_dausach]    Script Date: 06/04/2019 20:04:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[delete_dausach]
	@MaDS NVARCHAR(50)
AS
BEGIN
	DELETE FROM dbo.Sach WHERE MaDS = @MaDS
	DELETE FROM dbo.Dau_Sach WHERE MaDS = @MaDS
END
GO
/****** Object:  StoredProcedure [dbo].[update_sach_trangthai2]    Script Date: 06/04/2019 20:04:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[update_sach_trangthai2]
	@masach  NVARCHAR(50)
as
BEGIN
	UPDATE dbo.Sach
	SET
	TrangThai = N'Chưa mượn'
	WHERE MaSach = @masach
END
GO
/****** Object:  StoredProcedure [dbo].[update_sach_trangthai]    Script Date: 06/04/2019 20:04:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[update_sach_trangthai]
	@masach NVARCHAR(50)
AS
BEGIN
	UPDATE dbo.Sach
	SET
	TrangThai = N'Đã mượn'
	WHERE MaSach = @masach
END
GO
/****** Object:  StoredProcedure [dbo].[update_sach]    Script Date: 06/04/2019 20:04:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[update_sach]
	@masach NVARCHAR(50),
	@mads NVARCHAR(50),
	@tinhtrang NVARCHAR(50)
AS
BEGIN
	UPDATE dbo.Sach
	SET
		MaDS=@mads,
		TinhTrang=@tinhtrang
	WHERE MaSach = @masach
END
GO
/****** Object:  StoredProcedure [dbo].[update_phieumuon]    Script Date: 06/04/2019 20:04:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[update_phieumuon]
	@mapm NVARCHAR(50),
	@matt NVARCHAR(50),
	@madg NVARCHAR(50)
	
	
AS
BEGIN
	UPDATE dbo.Phieu_Muon
	SET MaPM=@mapm,
		MaTT=@matt,
		MaDg = @madg
END
GO
/****** Object:  StoredProcedure [dbo].[insert_ctpm]    Script Date: 06/04/2019 20:04:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insert_ctpm]
	@mapm NVARCHAR(50),
	@masach NVARCHAR(50)
AS
BEGIN
	DECLARE @slm INT
	SELECT @slm = SoLuotMuon
	FROM dbo.Sach
	WHERE MaSach = @masach
	INSERT INTO dbo.CTPM
	        ( MaPM, MaSach )
	VALUES  ( @mapm, -- MaPM - nvarchar(50)
	          @masach  -- MaSach - nvarchar(50)
	          )
	UPDATE dbo.Sach
	SET
		SoLuotMuon = @slm + 1
	WHERE MaSach = @masach
END
GO
/****** Object:  StoredProcedure [dbo].[delete_sach]    Script Date: 06/04/2019 20:04:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[delete_sach]
	@masach NVARCHAR(50)
AS
BEGIN
	DELETE FROM dbo.CTPM WHERE MaSach = @masach
	DELETE FROM dbo.Sach WHERE MaSach = @masach
END
GO
/****** Object:  StoredProcedure [dbo].[delete_phieumuon]    Script Date: 06/04/2019 20:04:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[delete_phieumuon]
	@mapm NVARCHAR(50)
	
AS
BEGIN
	DELETE FROM dbo.CTPM WHERE MaPM=@mapm
	DELETE FROM dbo.Phieu_Muon WHERE MaPM=@mapm
END
GO
/****** Object:  ForeignKey [S1]    Script Date: 06/04/2019 20:04:10 ******/
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD  CONSTRAINT [S1] FOREIGN KEY([MaDS])
REFERENCES [dbo].[Dau_Sach] ([MaDS])
GO
ALTER TABLE [dbo].[Sach] CHECK CONSTRAINT [S1]
GO
/****** Object:  ForeignKey [PM1]    Script Date: 06/04/2019 20:04:10 ******/
ALTER TABLE [dbo].[Phieu_Muon]  WITH CHECK ADD  CONSTRAINT [PM1] FOREIGN KEY([MaTT])
REFERENCES [dbo].[Thu_thu] ([MaTT])
GO
ALTER TABLE [dbo].[Phieu_Muon] CHECK CONSTRAINT [PM1]
GO
/****** Object:  ForeignKey [PM2]    Script Date: 06/04/2019 20:04:10 ******/
ALTER TABLE [dbo].[Phieu_Muon]  WITH CHECK ADD  CONSTRAINT [PM2] FOREIGN KEY([MaDg])
REFERENCES [dbo].[Doc_gia] ([MaDg])
GO
ALTER TABLE [dbo].[Phieu_Muon] CHECK CONSTRAINT [PM2]
GO
/****** Object:  ForeignKey [FK__CTPM__MaPM__145C0A3F]    Script Date: 06/04/2019 20:04:10 ******/
ALTER TABLE [dbo].[CTPM]  WITH CHECK ADD FOREIGN KEY([MaPM])
REFERENCES [dbo].[Phieu_Muon] ([MaPM])
GO
/****** Object:  ForeignKey [FK__CTPM__MaSach__15502E78]    Script Date: 06/04/2019 20:04:10 ******/
ALTER TABLE [dbo].[CTPM]  WITH CHECK ADD FOREIGN KEY([MaSach])
REFERENCES [dbo].[Sach] ([MaSach])
GO
