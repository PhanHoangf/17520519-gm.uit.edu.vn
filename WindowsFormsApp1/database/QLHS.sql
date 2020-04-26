CREATE DATABASE QLHS
USE QLHS


CREATE TABLE DSHocSinh (
	iDhocsinh int IDENTITY(1,1) primary key,
	iDlop int,
	Hoten nvarchar(100),
	Gioitinh nvarchar(10),
	Ngaysinh date,
	Diachi nvarchar(100),
	Email nvarchar(100),
	TBHKI float null,
	TBHKII float null,
)

ALTER TABLE DSHocSinh ADD CONSTRAINT fk_iDlop FOREIGN KEY (iDlop) references Lop(iDlop)

CREATE TABLE Lop(
	iDlop int IDENTITY(1,1) PRIMARY KEY,
	Tenlop nvarchar(10)
)

CREATE TABLE MonHoc(
	iDmonhoc int IDENTITY(1,1) PRIMARY KEY,
	Tenmon nvarchar(50)
)

CREATE TABLE BangDiemMon(
	STT int IDENTITY(1,1) PRIMARY KEY ,
	iDhocsinh int,
	idmonhoc int,
	Diemtbm float,
	Diem15p float,
	Diem1t float,
	HK int,
	
	CONSTRAINT fk_idHocsinh FOREIGN KEY (iDhocsinh) REFERENCES DSHocSinh(iDhocsinh),
	CONSTRAINT fk_idHmonhoc FOREIGN KEY (iDmonhoc) REFERENCES MonHoc(iDmonhoc)
)

CREATE TABLE TongKetHocKi(
	STT int IDENTITY(1,1) PRIMARY KEY,
	iDlop int,
	Siso int,
	Soluongdat int,
	Tile float,
	HK int,
	
	CONSTRAINT fk_lop FOREIGN KEY (iDlop) REFERENCES Lop(iDlop)
)

CREATE TABLE DanhSachLop(
	STT int IDENTITY(1,1) PRIMARY KEY,
	iDlop int,
	iDhocsinh int,

	CONSTRAINT fk_DSlop FOREIGN KEY (iDlop) REFERENCES Lop(iDlop),
	CONSTRAINT fk_DShocsinh FOREIGN KEY (iDhocsinh) REFERENCES DSHocSinh(iDhocsinh)
)

INSERT INTO Lop(TenLop) values
('10A1'),
('10A2'),
('10A3'),
('10A4'),
('11A1'),
('11A2'),
('11A3'),
('12A1'),
('12A2')

set dateformat dmy 
SELECT Hoten , Tenlop , TBHKI , TBHKII from DSHocSinh


go
CREATE PROC Dslop10
AS
BEGIN
	SELECT * FROM Lop WHERE Tenlop  Like '10%'
END
GO

EXEC Dslop10

go
CREATE PROC USP_Dslop11
AS
BEGIN
	SELECT * FROM Lop WHERE Tenlop  Like '11%'
END
GO

EXEC USP_Dslop11

go
CREATE PROC USP_Dslop12
AS
BEGIN
	SELECT * FROM Lop WHERE Tenlop  Like '12%'
END
GO

EXEC USP_Dslop12

select * from DSHocSinh
select *from Lop

delete from MonHoc
delete from Lop
delete from DSHocSinh
delete from DanhSachLop
delete from BangDiemMon
DBCC CHECKIDENT (DsHocSinh, RESEED, 0)
DBCC CHECKIDENT (DanhSachLop, RESEED, 0)
DBCC CHECKIDENT (Lop, RESEED, 0)
DBCC CHECKIDENT (MonHoc, RESEED, 0)

--Xóa cột tên lớp trong ds học sinh
alter table  DSHocSinh
drop column Tenlop

select*from DanhSachLop

--Thêm học sinh vào lớp 10A1
INSERT INTO DSHocSinh(iDlop,Hoten,Gioitinh,Ngaysinh,Diachi,Email) VALUES
(1,N'Củ long',N'Nữ','2003-03-03',N'Vườn bách thú','CL@gmail.com'),
(2,N'Sơn tùng-mtp',N'Nam','2003-02-01','MTP-Entertainment','mtp@gmail.com')

INSERT INTO DSHocSinh(iDlop,Hoten,Gioitinh,Ngaysinh,Diachi,Email) VALUES
(1,N'Tiên Tiên',N'Nữ','2003-04-03',N'Vườn bách thú','TT@gmail.com')

INSERT INTO DSHocSinh(iDlop,Hoten,Gioitinh,Ngaysinh,Diachi,Email) VALUES
(1,N'Hà bá',N'Nữ','2003-04-03',N'Vườn bách thú','HB@gmail.com'),
(1,N'Sư Tử',N'Nam','2003-05-03',N'Vườn bách thú','ST@gmail.com')
INSERT INTO DSHocSinh(iDlop,Hoten,Gioitinh,Ngaysinh,Diachi,Email) VALUES
('1',N'Lan Ngọc',N'Nữ','2003-07-03',N'Vườn bách thú','LN@gmail.com')
INSERT INTO DSHocSinh(iDlop,Hoten,Gioitinh,Ngaysinh,Diachi,Email) VALUES
('1',N'Lan Ngọc',N'Nữ','2003-07-03',N'Vườn bách thú','LN@gmail.com')
--Thêm học sinh vào lớp 10A2
INSERT INTO DSHocSinh(iDlop,Hoten,Gioitinh,Ngaysinh,Diachi,Email) VALUES
(2,N'Trần văn A',N'Nam','2004-03-03',N'a/2','a@gmail.com'),
(2,N'Nguyễn văn B',N'Nam','2004-02-01','b/3','b@gmail.com'),
(2,N'Nguyễn văn C',N'Nữ','2004-08-01','c/3','c@gmail.com'),
(2,N'Nguyễn văn D',N'Nam','2004-02-15','d/3','d@gmail.com')

--Thêm học sinh vào lớp 10A3
INSERT INTO DSHocSinh(iDlop,Hoten,Gioitinh,Ngaysinh,Diachi,Email) VALUES
(3,N'Cù văn A',N'Nam','2004-03-03',N'a/2','a@gmail.com'),
(3,N'Cù văn B',N'Nam','2004-02-01','b/3','b@gmail.com'),
(3,N'Cù văn C',N'Nữ','2004-08-01','c/3','c@gmail.com'),
(3,N'Cù văn D',N'Nam','2004-02-15','d/3','d@gmail.com')

--Thêm học sinh vào lớp 10A4

INSERT INTO DSHocSinh(iDlop,Hoten,Gioitinh,Ngaysinh,Diachi,Email) VALUES
(4,N'Tiến văn A',N'Nam','2004-03-03',N'a/2','a@gmail.com'),
(4,N'Tiến văn B',N'Nam','2004-02-01','b/3','b@gmail.com'),
(4,N'Tiến văn C',N'Nữ','2004-08-01','c/3','c@gmail.com'),
(4,N'Tiến văn D',N'Nam','2004-02-15','d/3','d@gmail.com')



select *from DSHocSinh where iDlop=1




select dshs.Hoten, l.Tenlop, dshs.Ngaysinh  from DSHocSinh as dshs, Lop as l 
where dshs.iDlop=l.iDlop and l.iDlop=4

select *from MonHoc

INSERT INTO MonHoc(Tenmon) values
(N'Toán'),
(N'Lý'),
(N'Hóa'),
(N'Văn'),
(N'Đạo đức'),
(N'Sinh'),
(N'Sử'),
(N'Địa'),
(N'Thể dục')

select dshs.Hoten,mh.Tenmon,BD.Diem15p,BD.Diem1t,BD.HK,l.Tenlop,BD.idmonhoc from BangDiemMon as BD,DSHocSinh as dshs,MonHoc as mh ,Lop as l
where dshs.iDhocsinh=BD.iDhocsinh and mh.iDmonhoc=2 and l.iDlop=1 and BD.idmonhoc=mh.iDmonhoc

select bd.idmonhoc,mh.iDmonhoc,mh.Tenmon from BangDiemMon as bd,MonHoc as mh where mh.iDmonhoc=2 and bd.idmonhoc=mh.iDmonhoc
select hs.Hoten,bd.idmonhoc,bd.Diem15p,bd.Diem1t,bd.HK,bd.Diemtbm from BangDiemMon as bd, DSHocSinh as hs where bd.idlop=1 and bd.iDhocsinh=hs.iDhocsinh and bd.idmonhoc=1

select *from BangDiemMon
INSERT INTO BangDiemMon (iDhocsinh,idmonhoc,idlop,Diem15p,Diem1t,HK) values
(2,1,4,10,10,10),
(3,1,4,9,9,9.5)

INSERT INTO BangDiemMon (iDhocsinh,idmonhoc,idlop,Diem15p,Diem1t,HK) values
(2,2,4,9.5,8.5,7),
(3,2,4,7.5,8,6)

INSERT INTO BangDiemMon (iDhocsinh,idmonhoc,idlop,Diem15p,Diem1t,HK) values
(14,1,1,10,10,10),
(16,1,1,9,9,9.5)

INSERT INTO BangDiemMon (iDhocsinh,idmonhoc,idlop,Diem15p,Diem1t,HK) values
(14,2,1,10,10,10),
(16,2,1,9,9,9.5)

