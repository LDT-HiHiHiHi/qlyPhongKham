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
    MAQUYEN INT IDENTITY NOT NULL PRIMARY KEY,
    TENQUYEN NVARCHAR(50),
    CODE CHAR(2)
)

CREATE TABLE MANHINH
(
    ID VARCHAR(15) NOT NULL PRIMARY KEY,
    TENMH NVARCHAR(50)
)

CREATE TABLE QL_PHANQUYEN
(
    MAQUYEN INT REFERENCES QUYEN(MAQUYEN) NOT NULL,
    ID_MH VARCHAR(15) REFERENCES MANHINH(ID) NOT NULL,
    COQUYEN BIT NOT NULL,
    CONSTRAINT PK_PQ PRIMARY KEY (MAQUYEN, ID_MH)
)

CREATE TABLE TAIKHOAN (
    ID VARCHAR(20) NOT NULL, -- CREATE AUTO
    USERNAME VARCHAR(50), -- CHECK USERNAME THEO GROUP
    PW VARCHAR(50),
    CONSTRAINT PK_TK PRIMARY KEY (ID)
)
CREATE TABLE NHOMNGUOIDUNG
(
    ID_Q INT REFERENCES QUYEN(MAQUYEN),
    ID_TK VARCHAR(20) REFERENCES TAIKHOAN(ID),
    CONSTRAINT PK_NND PRIMARY KEY (ID_Q, ID_TK)
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
    ID_TAIKHOAN VARCHAR(20) REFERENCES TAIKHOAN(ID) unique,
    CONSTRAINT PK_TTTK PRIMARY KEY (ID)
)
CREATE TABLE NHANVIEN(
	MANV VARCHAR(10) NOT NULL PRIMARY KEY,
    ID VARCHAR(20) REFERENCES TAIKHOAN(ID) unique
)
CREATE TABLE PHONG 
(
	MAPHONG VARCHAR(10) NOT NULL PRIMARY KEY,
	TENPHONG NVARCHAR(50),
)
CREATE TABLE BACSI(
	MABS VARCHAR(10), 
    IDTK VARCHAR(20) REFERENCES TAIKHOAN(ID) unique,
	MACN VARCHAR(10) REFERENCES NHOMCHUYENNGANH(MACN),
	MAPHONG VARCHAR(10)  REFERENCES PHONG(MAPHONG),
	CONSTRAINT PK_BACSI PRIMARY KEY (MABS)
)
CREATE TABLE BENHNHAN(
	MABN VARCHAR(20) NOT NULL PRIMARY KEY,
	TENBN NVARCHAR(50),
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
	HSD NVARCHAR(50),
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
	MABN VARCHAR(20) REFERENCES BENHNHAN(MABN)
)
CREATE TABLE LS_KHAMBENH(
	MALS VARCHAR(20),
	MABN VARCHAR(20) REFERENCES BENHNHAN(MABN),
	MABS VARCHAR(10) REFERENCES BACSI(MABS),
	NGKHAM DATE,
	STT INT,
	CHANDOAN NVARCHAR(50),
	TRANGTHAI BIT,
	CONSTRAINT PK_LSKB PRIMARY KEY (MALS)
)
CREATE TABLE TOATHUOC(
	MATT VARCHAR(20) NOT NULL PRIMARY KEY,
	MALS VARCHAR(20) REFERENCES LS_KHAMBENH(MALS) unique,
	TRANGTHAI BIT,
	TONGTIENTT FLOAT
)
CREATE TABLE CT_TOATHUOC(
	MATT VARCHAR(20) REFERENCES TOATHUOC(MATT),
	MAT VARCHAR(10) REFERENCES DMTHUOC(MAT),
	SOBUOI INT,
	SOLUONGUONG INT,
	TONGSOLUONG INT,
	DONGIA FLOAT,
	CONSTRAINT PK_CT_TOATHUOC PRIMARY KEY (MATT, MAT)
)
CREATE TABLE PHIEUCHIDINH(
	MACD VARCHAR(20) NOT NULL,
	MALS VARCHAR(20) REFERENCES LS_KHAMBENH(MALS) unique,
	TRANGTHAI BIT,
	TONGTIENDV FLOAT,
	CONSTRAINT PK_PCD PRIMARY KEY (MACD)
)
CREATE TABLE CHITIETCD(
	MACD VARCHAR(20) REFERENCES PHIEUCHIDINH(MACD),
	MADV VARCHAR(10) REFERENCES DICHVU(MADV),
	MOTA NVARCHAR(MAX),
	KETQUA NVARCHAR(MAX),
	HINHANH NVARCHAR(MAX),
	CONSTRAINT PK_CTDONDV PRIMARY KEY (MACD, MADV)
)

GO
CREATE FUNCTION fn_PhanQuyen(@idGR INT)
RETURNS TABLE
AS
	RETURN SELECT ID, TENMH, COQUYEN
	FROM MANHINH MH LEFT JOIN QL_PHANQUYEN PQ
		ON MH.ID = PQ.ID_MH AND MAQUYEN = @idGR
GO

--DATA
INSERT TAIKHOAN
VALUES
('TK001','admin','123'),
('TK002','bacsi','123'),
('TK003','nhanvientn','123'),
('TK004','nvthungan','123'),
('TK005','bacsidv','123')

-- BẢNG TB_GRTK
INSERT QUYEN VALUES(N'ADMIN', '00')
INSERT QUYEN VALUES(N'USER', '01')
INSERT QUYEN VALUES(N'BACSI', '02')

INSERT MANHINH VALUES('M1', N'Quản lý bệnh nhân')
INSERT MANHINH VALUES('M2', N'Kê toa thuốc')
INSERT MANHINH VALUES('M3', N'Quản lý tài khoản')
INSERT MANHINH VALUES('M4', N'Thực hiện dịch vụ')
INSERT MANHINH VALUES('M5', N'Xem thông tin cá nhân')
INSERT MANHINH VALUES('M6', N'Phân quyền') 
INSERT MANHINH VALUES('M7', N'Quản lý nhóm người dùng') 
INSERT MANHINH VALUES('M8', N'Thêm người dùng vào nhóm')
INSERT MANHINH VALUES('M9', N'Khám bệnh')
INSERT MANHINH VALUES('MMH', N'Quản lý màn hình')

INSERT NHOMNGUOIDUNG VALUES ('1','TK001')
INSERT NHOMNGUOIDUNG VALUES ('3','TK002')
INSERT NHOMNGUOIDUNG VALUES ('2','TK003')
INSERT NHOMNGUOIDUNG VALUES ('2','TK004')
INSERT NHOMNGUOIDUNG VALUES ('3','TK005')

-- bảng phân quyền
-- phân quyền cho admin
INSERT QL_PHANQUYEN VALUES 
(1, 'M1', 1),
(1, 'M2', 0),
(1, 'M3', 1),
(1, 'M4', 0),
(1, 'M5', 0),
(1, 'M6', 1),
(1, 'M7', 1),
(1, 'M8', 1),
(1, 'M9', 0),
(1, 'MMH', 1)

-- phân quyền cho bác sĩ
INSERT QL_PHANQUYEN VALUES 
(3, 'M1', 0),
(3, 'M2', 1),
(3, 'M3', 0),
(3, 'M4', 1),
(3, 'M5', 1),
(3, 'M6', 0),
(3, 'M7', 0),
(3, 'M8', 0),
(3, 'M9', 1),
(3, 'MMH', 0)

-- phân quyền cho nhân viên
INSERT QL_PHANQUYEN VALUES 
(2, 'M1', 1),
(2, 'M2', 0),
(2, 'M3', 0),
(2, 'M4', 0),
(2, 'M5', 1),
(2, 'M6', 0),
(2, 'M7', 0),
(2, 'M8', 0),
(2, 'M9', 0),
(2, 'MMH', 0)

INSERT PHONG 
VALUES 
('P01',N'PHÒNG 401'),
('P02',N'PHÒNG 402'),
('P03',N'PHÒNG 403')

INSERT NHOMCHUYENNGANH
VALUES
('CN001',N'CHUYÊN NGÀNH NHI'),
('CN002',N'CHUYÊN NGÀNH TỔNG QUÁT')

INSERT BACSI
VALUES
('BS001','TK002','CN002','P01'),
('BS002','TK005','CN001','P02')
INSERT DICHVU
VALUES
('DV001',N'XÉT NGHIỆM MÁU'),
('DV002',N'SIÊU ÂM'),
('DV003',N'CHỤP X QUANG'),
('DV004',N'XÉT NGHIỆM NƯỚC TIỂU'),
('DV005',N'KHÁM BỆNH LÂM SÀN'),
('DV006',N'XÉT NGHIỆM ĐƯỜNG MÁU')

SET DATEFORMAT DMY
INSERT DONGIA_DICHVU
VALUES
('DV001','08/05/2022',160000),
('DV002','02/09/2022',180000),
('DV003','03/05/2021',190000),
('DV004','06/05/2021',250000),
('DV005','03/09/2022',200000),
('DV006','03/09/2022',900000)

INSERT DMTHUOC
VALUES
('T001','Paracetamol',N'12 THÁNG',100,N'VIÊN'),
('T002','Ibuprofen ',N'12 THÁNG',100,N'VIÊN'),
('T003','Meloxicam ',N'12 THÁNG',100,N'VIÊN'),
('T004','Celecoxib ',N'12 THÁNG',100,N'VIÊN'),
('T005','Piroxicam ',N'12 THÁNG',100,N'VIÊN'),
('T006','Prednisolon ',N'12 THÁNG',100,N'VIÊN'),
('T007','Methylprednisolon ',N'12 THÁNG',100,N'VIÊN'),
('T008','Amoxicillin  ',N'12 THÁNG',100,N'VIÊN'),
('T009','Ampicillin ',N'12 THÁNG',100,N'VIÊN'),
('T010','Cefpodoxime ',N'12 THÁNG',100,N'VIÊN'),
('T011','Cefuroxime ',N'12 THÁNG',100,N'VIÊN'),
('T012','Cefixime ',N'12 THÁNG',100,N'VIÊN'),
('T013','Cefnidir  ',N'12 THÁNG',100,N'VIÊN'),
('T014','Cephalexin ',N'12 THÁNG',100,N'VIÊN'),
('T015','Alimemazin ',N'12 THÁNG',100,N'VIÊN'),
('T016','Loratadin ',N'12 THÁNG',100,N'VIÊN'),
('T017','Chlorpheniramin ',N'12 THÁNG',100,N'VIÊN'),
('T018','Fexofenadin ',N'12 THÁNG',100,N'VIÊN'),
('T019','Cetirizine ',N'12 THÁNG',100,N'VIÊN'),
('T020','Omeprazol ',N'12 THÁNG',100,N'VIÊN'),
('T021','Esomeprazol ',N'12 THÁNG',100,N'VIÊN'),
('T022','Pantoprazol ',N'12 THÁNG',100,N'VIÊN'),
('T023','Rabeprazol ',N'12 THÁNG',100,N'VIÊN'),
('T024','Domperidol ',N'12 THÁNG',100,N'VIÊN'),
('T025','Lansoprazol ',N'12 THÁNG',100,N'VIÊN'),
('T026','Domitazol ',N'12 THÁNG',100,N'VIÊN'),
('T027','Rigevidon ',N'12 THÁNG',100,N'VIÊN'),
('T028','Itraconazol ',N'12 THÁNG',100,N'VIÊN'),
('T029','Fluconazol ',N'12 THÁNG',100,N'VIÊN'),
('T030','Pharmaton ',N'12 THÁNG',100,N'VIÊN'),
('T031','Boganic ',N'12 THÁNG',100,N'VIÊN'),
('T032','Rowatinex ',N'12 THÁNG',100,N'VIÊN'),
('T033','Decolgen ',N'12 THÁNG',100,N'VIÊN'),
('T034','Daflon ',N'12 THÁNG',100,N'VIÊN'),
('T035','Bisacodyl ',N'12 THÁNG',100,N'VIÊN'),
('T036','Canesten ',N'12 THÁNG',100,N'VIÊN'),
('T037','Bisolvon ',N'12 THÁNG',100,N'VIÊN'),
('T038','Biotin Collagen 30 ',N'12 THÁNG',100,N'VIÊN'),
('T039','Polygynax ',N'12 THÁNG',100,N'VIÊN'),
('T040','Sorbitol ',N'12 THÁNG',100,N'VIÊN'),
('T041','Alaxan ',N'12 THÁNG',100,N'VIÊN'),
('T042','Homtamin ',N'12 THÁNG',100,N'VIÊN'),
('T043','Zentel ',N'12 THÁNG',100,N'VIÊN'),
('T044','Calcium Corbiere ',N'12 THÁNG',100,N'VIÊN'),
('T045','Nystatin ',N'12 THÁNG',100,N'VIÊN'),
('T046','Mercilon ',N'12 THÁNG',100,N'VIÊN'),
('T047','Buscopan ',N'12 THÁNG',100,N'VIÊN'),
('T048','Maalox ',N'12 THÁNG',100,N'VIÊN'),
('T049','Stugon ',N'12 THÁNG',100,N'VIÊN'),
('T050','Lactomin ',N'12 THÁNG',100,N'VIÊN'),
('T051','Pectol ',N'12 THÁNG',100,N'CHAI'),
('T052','Cadumarin Fort ',N'12 THÁNG',100,N'CHAI'),
('T053','Atussin ',N'12 THÁNG',100,N'CHAI'),
('T054','Ventolin ',N'12 THÁNG',100,N'CHAI'),
('T055','Mouthpaste ',N'12 THÁNG',100,N'CHAI'),
('T056','Daktarin ',N'12 THÁNG',100,N'CHAI'),
('T057','Neodex ',N'12 THÁNG',100,N'CHAI'),
('T058','Tobradex  ',N'12 THÁNG',100,N'CHAI'),
('T059','Griseofulvin ',N'12 THÁNG',100,N'CHAI'),
('T060','Newchoi ',N'12 THÁNG',100,N'VIÊN')

SET DATEFORMAT DMY
INSERT DONGIA_THUOC
VALUES
('T001','07/05/2022',170000),
('T002','06/05/2022',180000),
('T003','03/05/2022',190000),
('T004','02/05/2022',160000),
('T005','01/05/2022',150000),
('T006','08/06/2022',140000),
('T007','08/08/2022',120000),
('T008','08/09/2022',110000),
('T009','08/02/2022',100000),
('T010','08/04/2022',180000),
('T011','08/02/2022',190000),
('T012','08/03/2022',120000),
('T013','08/04/2022',140000),
('T014','08/08/2022',160000),
('T015','08/09/2022',160000),
('T016','08/05/2022',170000),
('T017','01/05/2022',120000),
('T018','02/05/2022',130000),
('T019','06/05/2022',140000),
('T020','09/05/2022',150000),
('T021','08/05/2022',150000),
('T022','03/05/2022',170000),
('T023','05/05/2022',180000),
('T024','07/05/2022',190000),
('T025','05/05/2022',100000),
('T026','08/05/2022',120000),
('T027','09/05/2022',110000),
('T028','01/05/2022',170000),
('T029','02/02/2022',140000),
('T030','03/01/2022',120000),
('T031','04/03/2022',130000),
('T032','05/01/2022',150000),
('T033','07/02/2022',150000),
('T034','09/08/2022',150000),
('T035','02/07/2022',160000),
('T036','05/07/2022',180000),
('T037','04/06/2022',180000),
('T038','04/06/2022',190000),
('T039','05/06/2022',180000),
('T040','06/07/2022',110000),
('T041','06/07/2022',1130000),
('T042','06/07/2022',130000),
('T043','06/07/2022',150000),
('T044','06/07/2022',140000),
('T045','06/07/2022',130000),
('T046','06/07/2022',120000),
('T047','06/07/2022',170000),
('T048','01/04/2022',160000),
('T049','02/05/2022',150000),
('T050','03/04/2022',140000),
('T051','04/09/2022',120000),
('T052','05/09/2022',110000),
('T053','06/09/2022',180000),
('T054','08/08/2022',170000),
('T055','09/06/2022',160000),
('T056','01/04/2022',150000),
('T057','03/02/2022',140000),
('T058','07/09/2022',130000),
('T059','09/02/2022',120000),
('T060','03/01/2022',160000)

select * from DICHVU
select * from DONGIA_DICHVU
select * from DMTHUOC
select * from DONGIA_THUOC

