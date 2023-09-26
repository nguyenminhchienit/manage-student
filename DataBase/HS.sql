
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/30/2023 12:17:38
-- Generated from EDMX file: E:\HUTECH\Nam3\HK1\DataAccessLayer\Model1.edmx
-- --------------------------------------------------
CREATE DATABASE HS
SET QUOTED_IDENTIFIER OFF;
GO
USE HS;
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[tb_ChiTietVP]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_ChiTietVP];
GO
IF OBJECT_ID(N'[dbo].[tb_DanhMucLoi]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_DanhMucLoi];
GO
IF OBJECT_ID(N'[dbo].[tb_GiaoVien]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_GiaoVien];
GO
IF OBJECT_ID(N'[dbo].[tb_GiaoVien_Lop]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_GiaoVien_Lop];
GO
IF OBJECT_ID(N'[dbo].[tb_HocKy]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_HocKy];
GO
IF OBJECT_ID(N'[dbo].[tb_HocSinh]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_HocSinh];
GO
IF OBJECT_ID(N'[dbo].[tb_KetQua]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_KetQua];
GO
IF OBJECT_ID(N'[dbo].[tb_Lop]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_Lop];
GO
IF OBJECT_ID(N'[dbo].[tb_MonHoc]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_MonHoc];
GO
IF OBJECT_ID(N'[dbo].[tb_NamHoc]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_NamHoc];
GO
IF OBJECT_ID(N'[dbo].[tb_Truong]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_Truong];
GO
IF OBJECT_ID(N'[dbo].[tb_ViPham]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_ViPham];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'tb_ChiTietVP'
CREATE TABLE [dbo].[tb_ChiTietVP] (
    [MAVPCT] int IDENTITY(1,1) NOT NULL,
    [MAVP] int  NULL,
    [MALOI] int  NULL,
    [MAHS] int  NULL,
    [TENLOI] nvarchar(250)  NULL,
    [DIEM] int  NULL,
    [NGAYVP] datetime  NULL
);
GO
ALTER TABLE tb_ChiTietVP
ADD CONSTRAINT FK1
FOREIGN KEY (MAVP) REFERENCES dbo.tb_ViPham(MAVP);

ALTER TABLE tb_ChiTietVP
ADD CONSTRAINT FK2
FOREIGN KEY (MALOI) REFERENCES tb_DanhMucLoi(MALOI);

ALTER TABLE tb_ChiTietVP
ADD CONSTRAINT FK3
FOREIGN KEY (MAHS) REFERENCES tb_HocSinh(MAHS);


-- Creating table 'tb_DanhMucLoi'
CREATE TABLE [dbo].[tb_DanhMucLoi] (
    [MALOI] int IDENTITY(1,1) NOT NULL,
    [TENLOI] nvarchar(250)  NULL,
    [DIEM] int  NULL,
    [GHICHU] nvarchar(250)  NULL,
    [STATUS] bit  NULL,
    [CREATEDBY] int  NULL,
    [CREATEDDATE] datetime  NULL,
    [UPDATEDDATE] datetime  NULL,
    [UPDATEDBY] int  NULL
);
GO

-- Creating table 'tb_GiaoVien'
CREATE TABLE [dbo].[tb_GiaoVien] (
    [MAGV] int IDENTITY(1,1) NOT NULL,
    [HOTENGV] nvarchar(50)  NULL,
    [TEN] nvarchar(50)  NULL,
    [DT] nvarchar(11)  NULL,
    [EMAIL] nvarchar(50)  NULL,
    [DIACHI] nvarchar(250)  NULL,
    [STATUS] bit  NULL
);
GO

-- Creating table 'tb_GiaoVien_Lop'
CREATE TABLE [dbo].[tb_GiaoVien_Lop] (
    [MAGV_LOP] int IDENTITY(1,1) NOT NULL,
    [MAGV] int  NULL,
    [MALOP] int  NULL,
    [MANH] int  NULL,
    [MAHK] int  NULL
);
GO

ALTER TABLE tb_GiaoVien_Lop
ADD CONSTRAINT FK4
FOREIGN KEY ([MAGV]) REFERENCES tb_GiaoVien([MAGV]);

ALTER TABLE tb_GiaoVien_Lop
ADD CONSTRAINT FK5
FOREIGN KEY ([MALOP]) REFERENCES tb_Lop([MALOP]);

ALTER TABLE tb_GiaoVien_Lop
ADD CONSTRAINT FK6
FOREIGN KEY ([MANH]) REFERENCES tb_NamHoc([MANH]);

ALTER TABLE tb_GiaoVien_Lop
ADD CONSTRAINT FK7
FOREIGN KEY ([MAHK]) REFERENCES tb_HocKy([MAHK]);


-- Creating table 'tb_HocKy'
CREATE TABLE [dbo].[tb_HocKy] (
    [MAHK] int IDENTITY(1,1) NOT NULL,
    [TENHK] nvarchar(50)  NULL
);
GO

-- Creating table 'tb_HocSinh'
CREATE TABLE [dbo].[tb_HocSinh] (
    [MAHS] int IDENTITY(1,1) NOT NULL,
    [HOTENHS] nvarchar(50)  NULL,
    [GIOITINH] bit  NULL,
    [NGAYSINH] datetime  NULL,
    [MADANTOC] nvarchar(50)  NULL,
    [MATONGIAO] nvarchar(50)  NULL,
    [MALOP] int  NULL,
    [GHICHU] nvarchar(250)  NULL,
    [DANGHIHOC] bit  NULL,
    [CREATEDBY] int  NULL,
    [CREATEDDATE] datetime  NULL,
    [UPDATEDDATE] datetime  NULL,
    [DIACHI] nvarchar(250)  NULL,
    [DT] nvarchar(11)  NULL,
    [UPDATEDBY] int  NULL,
    [TEN] nvarchar(50)  NULL
);
GO

ALTER TABLE tb_HocSinh
ADD CONSTRAINT FK8
FOREIGN KEY ([MALOP]) REFERENCES tb_Lop([MALOP]);

-- Creating table 'tb_KetQua'
CREATE TABLE [dbo].[tb_KetQua] (
    [MAKQ] int IDENTITY(1,1) NOT NULL,
    [MAMH] int  NULL,
    [MAHS] int  NULL,
    [DIEMKIEMTRA] float  NULL,
    [DIEMTHIL1] float  NULL,
    [DIEMTHIL2] float  NULL,
    [DTB] float  NULL,
    [XEPLOAI] nvarchar(50)  NULL,
    [MANH] int  NULL,
    [MAHK] int  NULL,
    [MALOP] int  NULL,
    [CREATEDBY] int  NULL,
    [CREATEDDATE] datetime  NULL,
    [UPDATEDDATE] datetime  NULL,
    [UPDATEDBY] int  NULL
);
GO

ALTER TABLE tb_KetQua
ADD CONSTRAINT FK9
FOREIGN KEY ([MAMH]) REFERENCES tb_MonHoc([MAMH]);

ALTER TABLE tb_KetQua
ADD CONSTRAINT FK10
FOREIGN KEY ([MAHS]) REFERENCES tb_HocSinh([MAHS]);

ALTER TABLE tb_KetQua
ADD CONSTRAINT FK11
FOREIGN KEY ([MANH]) REFERENCES tb_NamHoc([MANH]);

ALTER TABLE tb_KetQua
ADD CONSTRAINT FK12
FOREIGN KEY ([MAHK]) REFERENCES tb_HocKy([MAHK]);

ALTER TABLE tb_KetQua
ADD CONSTRAINT FK13
FOREIGN KEY ([MALOP]) REFERENCES tb_Lop([MALOP]);

-- Creating table 'tb_Lop'
CREATE TABLE [dbo].[tb_Lop] (
    [MALOP] int IDENTITY(1,1) NOT NULL,
    [TENLOP] nvarchar(50)  NULL,
    [GHICHU] nvarchar(250)  NULL,
    [SAPXEP] int  NULL,
    [MATRUONG] int  NULL
);
GO

ALTER TABLE tb_Lop
ADD CONSTRAINT FK14
FOREIGN KEY ([MATRUONG]) REFERENCES tb_Truong([MATRUONG]);

-- Creating table 'tb_MonHoc'
CREATE TABLE [dbo].[tb_MonHoc] (
    [MAMH] int IDENTITY(1,1) NOT NULL,
    [TENMH] nvarchar(50)  NULL,
    [STATUS] bit  NULL
);
GO

-- Creating table 'tb_NamHoc'
CREATE TABLE [dbo].[tb_NamHoc] (
    [MANH] int IDENTITY(1,1) NOT NULL,
    [TENNH] nvarchar(50)  NULL
);
GO

-- Creating table 'tb_Truong'
CREATE TABLE [dbo].[tb_Truong] (
    [MATRUONG] int IDENTITY(1,1) NOT NULL,
    [TENTRUONG] nvarchar(250)  NULL,
    [EMAIL] nvarchar(50)  NULL,
    [DT] nvarchar(20)  NULL,
    [WEB] nvarchar(50)  NULL,
    [DIACHI] nvarchar(250)  NULL
);
GO

-- Creating table 'tb_ViPham'
CREATE TABLE [dbo].[tb_ViPham] (
    [MAVP] int IDENTITY(1,1) NOT NULL,
    [NGAYVP] datetime  NULL,
    [TONGSOLOI] int  NULL,
    [TONGDIEMTRU] int  NULL,
    [MALOP] int  NULL,
    [MANH] int  NULL,
    [MAHK] int  NULL,
    [GHICHU] nvarchar(250)  NULL,
    [CREATEDBY] int  NULL,
    [CREATEDDATE] datetime  NULL,
    [UPDATEDDATE] datetime  NULL,
    [UPDATEDBY] int  NULL,
    [DELETEDDATE] datetime  NULL,
    [DELETEDBY] int  NULL
);
GO

ALTER TABLE tb_ViPham
ADD CONSTRAINT FK15
FOREIGN KEY ([MANH]) REFERENCES tb_NamHoc([MANH]);

ALTER TABLE tb_ViPham
ADD CONSTRAINT FK16
FOREIGN KEY ([MAHK]) REFERENCES tb_HocKy([MAHK]);

ALTER TABLE tb_ViPham
ADD CONSTRAINT FK17
FOREIGN KEY ([MALOP]) REFERENCES tb_Lop([MALOP]);

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [MAVPCT] in table 'tb_ChiTietVP'
ALTER TABLE [dbo].[tb_ChiTietVP]
ADD CONSTRAINT [PK_tb_ChiTietVP]
    PRIMARY KEY CLUSTERED ([MAVPCT] ASC);
GO

-- Creating primary key on [MALOI] in table 'tb_DanhMucLoi'
ALTER TABLE [dbo].[tb_DanhMucLoi]
ADD CONSTRAINT [PK_tb_DanhMucLoi]
    PRIMARY KEY CLUSTERED ([MALOI] ASC);
GO

-- Creating primary key on [MAGV] in table 'tb_GiaoVien'
ALTER TABLE [dbo].[tb_GiaoVien]
ADD CONSTRAINT [PK_tb_GiaoVien]
    PRIMARY KEY CLUSTERED ([MAGV] ASC);
GO

-- Creating primary key on [MAGV_LOP] in table 'tb_GiaoVien_Lop'
ALTER TABLE [dbo].[tb_GiaoVien_Lop]
ADD CONSTRAINT [PK_tb_GiaoVien_Lop]
    PRIMARY KEY CLUSTERED ([MAGV_LOP] ASC);
GO

-- Creating primary key on [MAHK] in table 'tb_HocKy'
ALTER TABLE [dbo].[tb_HocKy]
ADD CONSTRAINT [PK_tb_HocKy]
    PRIMARY KEY CLUSTERED ([MAHK] ASC);
GO

-- Creating primary key on [MAHS] in table 'tb_HocSinh'
ALTER TABLE [dbo].[tb_HocSinh]
ADD CONSTRAINT [PK_tb_HocSinh]
    PRIMARY KEY CLUSTERED ([MAHS] ASC);
GO

-- Creating primary key on [MAKQ] in table 'tb_KetQua'
ALTER TABLE [dbo].[tb_KetQua]
ADD CONSTRAINT [PK_tb_KetQua]
    PRIMARY KEY CLUSTERED ([MAKQ] ASC);
GO

-- Creating primary key on [MALOP] in table 'tb_Lop'
ALTER TABLE [dbo].[tb_Lop]
ADD CONSTRAINT [PK_tb_Lop]
    PRIMARY KEY CLUSTERED ([MALOP] ASC);
GO

-- Creating primary key on [MAMH] in table 'tb_MonHoc'
ALTER TABLE [dbo].[tb_MonHoc]
ADD CONSTRAINT [PK_tb_MonHoc]
    PRIMARY KEY CLUSTERED ([MAMH] ASC);
GO

-- Creating primary key on [MANH] in table 'tb_NamHoc'
ALTER TABLE [dbo].[tb_NamHoc]
ADD CONSTRAINT [PK_tb_NamHoc]
    PRIMARY KEY CLUSTERED ([MANH] ASC);
GO

-- Creating primary key on [MATRUONG] in table 'tb_Truong'
ALTER TABLE [dbo].[tb_Truong]
ADD CONSTRAINT [PK_tb_Truong]
    PRIMARY KEY CLUSTERED ([MATRUONG] ASC);
GO

-- Creating primary key on [MAVP] in table 'tb_ViPham'
ALTER TABLE [dbo].[tb_ViPham]
ADD CONSTRAINT [PK_tb_ViPham]
    PRIMARY KEY CLUSTERED ([MAVP] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------