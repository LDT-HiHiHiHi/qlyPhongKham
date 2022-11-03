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
CREATE TABLE TAIKHOAN (
    ID VARCHAR(15) NOT NULL, -- CREATE AUTO
    USERNAME VARCHAR(50), -- CHECK USERNAME THEO GROUP
    PW VARBINARY(50), -- MÃ HÓA + salt
    CONSTRAINT PK_TK PRIMARY KEY (ID)
)
CREATE TABLE THONGTINTAIKHOAN (
    ID VARCHAR(20) NOT NULL, -- CREATE AUTO
    HOTEN NVARCHAR(50), -- HỌ TÊN
    NGSINH DATE, -- NGÀY SINH
    GTINH BIT, -- 1: NAM, 0: NỮ, NULL: CHƯA BIẾT(QUY VỀ 0)
    NGTAO DATE, -- NGÀY TẠO
    EMAIL VARCHAR(50), -- ĐỊA CHỈ EMAIL
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
    MANV VARCHAR(15) REFERENCES NHANVIEN(MANV) unique,
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
CREATE TABLE NHOMCHUYENNGANH(
	MACN VARCHAR(10) NOT NULL PRIMARY KEY,
	TENCN NVARCHAR(50)
)
CREATE TABLE DICHVU(
	MADV VARCHAR(10) NOT NULL PRIMARY KEY,
	TENDV NVARCHAR(50),
)
CREATE TABLE PHIEUCHIDINH(
	MACD VARCHAR(10) NOT NULL,
	MABS VARCHAR(10) REFERENCES BACSI(MABS),
	TONGTIENDV FLOAT,
	CONSTRAINT PK_PCD PRIMARY KEY (MACD)
)
CREATE TABLE THUOC(
	MAT VARCHAR(10) NOT NULL PRIMARY KEY,
	TENTHUOC NVARCHAR(50),
	HSD DATE,
	SOLUONG INT,
	DONVITINH VARCHAR(20)
)
CREATE TABLE DONGIA_THUOC(
	MADGT VARCHAR(10),
	MAT VARCHAR(10) REFERENCES THUOC(MAT),
	GIA FLOAT,
	NGCAPNHAT DATE,
	CONSTRAINT PK_DONGIA_THUOC PRIMARY KEY (MADGT,MAT)
)
CREATE TABLE DONGIA_DICHVU(
	MADGDV VARCHAR(10),
	MADV VARCHAR(10) REFERENCES DICHVU(MADV),
	GIA FLOAT,
	NGCAPNHAT DATE,
	CONSTRAINT PK_DONGIA_DV PRIMARY KEY (MADGDV,MADV)
)
CREATE TABLE CHITIETCD(
	MACD VARCHAR(10) REFERENCES PHIEUCHIDINH(MACD),
	MADV VARCHAR(10) REFERENCES DICHVU(MADV),
	NGTHUCHIEN DATE,
	KYTHUATVIEN VARCHAR(10) REFERENCES BACSI(MABS),
	KETQUA NVARCHAR(MAX),
	CONSTRAINT PK_CTDONDV PRIMARY KEY (MACD, MADV)
)
CREATE TABLE TOATHUOC(
	MATT VARCHAR(10) NOT NULL PRIMARY KEY,
	MABS VARCHAR(10) REFERENCES BACSI(MABS),
	MABN VARCHAR(10) REFERENCES BENHNHAN(MABN),
	TONGTIENTT FLOAT
)
CREATE TABLE CT_TOATHUOC(
	MATT VARCHAR(10) REFERENCES TOATHUOC(MATT),
	MAT VARCHAR(10) REFERENCES THUOC(MAT),
	LIEUDUNG NVARCHAR(50),
	CONSTRAINT PK_CT_TOATHUOC PRIMARY KEY (MATT, MAT)
)
CREATE TABLE HOADON(
	MAHD VARCHAR(10) NOT NULL PRIMARY KEY,
	TIENKHAM FLOAT,
	MABN VARCHAR(10) REFERENCES BENHNHAN(MABN),
	NGLAP DATE,
	TONGTIENHD FLOAT
)
CREATE TABLE LS_KHAMBENH(
	MALS VARCHAR(10),
	NGKHAM DATE,
	CANNANG VARCHAR(10),
	CHIEUCAO VARCHAR(10),
	TRIEUCHUNG NVARCHAR(50),
	MACD VARCHAR(10) REFERENCES PHIEUCHIDINH(MACD),
	MABN VARCHAR(10) REFERENCES BENHNHAN(MABN),
	CONSTRAINT PK_LSKB PRIMARY KEY (MALS,MACD)
)






