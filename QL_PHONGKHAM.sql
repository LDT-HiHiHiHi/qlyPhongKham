﻿USE master
GO
IF EXISTS(SELECT * FROM sys.databases WHERE name='QL_PHONGKHAM')
BEGIN
        DROP DATABASE QL_PHONGKHAM
END
CREATE DATABASE QL_PHONGKHAM
GO
USE QL_PHONGKHAM
GO
-- TẠO BẢNG 
CREATE TABLE QUYEN
(
    MaQuyen int not null primary key,
    TenQuyen nvarchar(50),
    Code char(2)
)

CREATE TABLE MANHINH
(
    Id varchar(15) not null primary key,
    TenMH nvarchar(50)
)

CREATE TABLE QL_PHANQUYEN
(
    MaQuyen int references QUYEN(MaQuyen) not null,
    Id_MH varchar(15) references MANHINH(Id) not null,
    CoQuyen bit not null,
    constraint PK_PQ primary key (MaQuyen, ID_MH)
)
CREATE TABLE TAIKHOAN (
    ID VARCHAR(15) NOT NULL, -- CREATE AUTO
    USERNAME VARCHAR(50), -- CHECK USERNAME THEO GROUP
    PW VARCHAR(50),
    CONSTRAINT PK_TK PRIMARY KEY (ID)
)
CREATE TABLE NHOMNGUOIDUNG
(
    Id_q int references QUYEN(MaQuyen),
    Id_tk varchar(15) references TAIKHOAN(ID),
    constraint PK_NND primary key (Id_q, Id_tk)
)
CREATE TABLE NHOMCHUYENNGANH(
	MACN VARCHAR(10) NOT NULL PRIMARY KEY,
	TENCN NVARCHAR(50)
)
CREATE TABLE THONGTINTAIKHOAN (
    ID VARCHAR(20) NOT NULL, -- CREATE AUTO
    HOTEN NVARCHAR(50), -- HỌ TÊN
    NGSINH DATE, -- NGÀY SINH
    GTINH NVARCHAR(10),
    SDT VARCHAR(11), -- SDT
    DCHI NVARCHAR(50), -- ĐỊA CHỈ NHÀ / ĐỊA CHỈ GIAO
    ID_TAIKHOAN VARCHAR(15) REFERENCES TAIKHOAN(ID) unique,
    CONSTRAINT PK_TTTK PRIMARY KEY (ID)
)
CREATE TABLE NHANVIEN(
	MANV VARCHAR(10) NOT NULL PRIMARY KEY,
    ID VARCHAR(15) REFERENCES TAIKHOAN(ID) unique
)
CREATE TABLE BACSI(
	MABS VARCHAR(10), 
    MANV VARCHAR(10) REFERENCES NHANVIEN(MANV) unique,
	MACN VARCHAR(10) REFERENCES NHOMCHUYENNGANH(MACN),
	CONSTRAINT PK_BACSI PRIMARY KEY (MABS)
)
CREATE TABLE BENHNHAN(
	MABN VARCHAR(10) NOT NULL PRIMARY KEY,
	TENBN NVARCHAR,
	NGAYSINH DATE,
	GTINH NVARCHAR(10),
	DIACHI NVARCHAR(50),
	SDT VARCHAR(15)
)
CREATE TABLE DICHVU(
	MADV VARCHAR(10) NOT NULL PRIMARY KEY,
	TENDV NVARCHAR(50),
)

CREATE TABLE DMTHUOC(
	MAT VARCHAR(10) NOT NULL PRIMARY KEY,
	TENTHUOC NVARCHAR(50),
	HSD DATE,
	SOLUONG INT,
	DONVITINH VARCHAR(20)
)
CREATE TABLE DONGIA_THUOC(
	MAT VARCHAR(10) REFERENCES DMTHUOC(MAT),
	NGCAPNHAT DATE,
	GIA FLOAT,
	CONSTRAINT PK_DONGIA_THUOC PRIMARY KEY (MAT,NGCAPNHAT)
)
CREATE TABLE DONGIA_DICHVU(
	MADV VARCHAR(10) REFERENCES DICHVU(MADV),
	NGCAPNHAT DATE,
	GIA FLOAT,
	CONSTRAINT PK_DONGIA_DV PRIMARY KEY (MADV,NGCAPNHAT)
)
CREATE TABLE HOADON(
	MAHD VARCHAR(10) NOT NULL PRIMARY KEY,
	TIENKHAM FLOAT,
	NGLAP DATE,
	TONGTIENHD FLOAT,
	MABN VARCHAR(10) REFERENCES BENHNHAN(MABN)
)
CREATE TABLE LS_KHAMBENH(
	MALS VARCHAR(10),
	MABN VARCHAR(10) REFERENCES BENHNHAN(MABN),
	MABS VARCHAR(10) REFERENCES BACSI(MABS),
	NGKHAM DATE,
	TRIEUCHUNG NVARCHAR(50),
	CONSTRAINT PK_LSKB PRIMARY KEY (MALS)
)
CREATE TABLE TOATHUOC(
	MATT VARCHAR(10) NOT NULL PRIMARY KEY,
	MALS VARCHAR(10) REFERENCES LS_KHAMBENH(MALS) unique,
	TONGTIENTT FLOAT
)
CREATE TABLE CT_TOATHUOC(
	MATT VARCHAR(10) REFERENCES TOATHUOC(MATT),
	MAT VARCHAR(10) REFERENCES DMTHUOC(MAT),
	LIEUDUNG NVARCHAR(50),
	DONGIA FLOAT,
	CONSTRAINT PK_CT_TOATHUOC PRIMARY KEY (MATT, MAT)
)
CREATE TABLE PHIEUCHIDINH(
	MACD VARCHAR(10) NOT NULL,
	MALS VARCHAR(10) REFERENCES LS_KHAMBENH(MALS) unique,
	TONGTIENDV FLOAT,
	CONSTRAINT PK_PCD PRIMARY KEY (MACD)
)
CREATE TABLE CHITIETCD(
	MACD VARCHAR(10) REFERENCES PHIEUCHIDINH(MACD),
	MADV VARCHAR(10) REFERENCES DICHVU(MADV),
	KETQUA NVARCHAR(MAX),
	CONSTRAINT PK_CTDONDV PRIMARY KEY (MACD, MADV)
)

--DATA
INSERT TAIKHOAN
VALUES
('TK001','admin','123')





