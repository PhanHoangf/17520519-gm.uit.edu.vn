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
select *from Lop ORDER BY Tenlop ASC

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

INSERT INTO DSHocSinh(iDlop,Hoten,Gioitinh,Ngaysinh,Diachi,Email) VALUES
(6,N'Nguyễn Văn A',N'Nam','2003-03-03',N'a/2','a@gmail.com'),
(7,N'Nguyễn Văn B',N'Nam','2003-03-03',N'a/2','a@gmail.com'),
(9,N'Nguyễn Văn C',N'Nam','2002-03-03',N'a/2','a@gmail.com')

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


select hs.Hoten,mh.Tenmon,bd.Diem15p,bd.Diem1t,bd.HK,(bd.Diem15p+bd.Diem1t*2+bd.HK*3)/6 'Diemtbm' 
from BangDiemMon as bd, DSHocSinh as hs, MonHoc as mh where bd.iDhocsinh=hs.iDhocsinh and bd.idmonhoc=mh.iDmonhoc

select hs.Hoten,bd.idmonhoc,bd.Diem15p,bd.Diem1t,bd.HK,(bd.Diem15p+bd.Diem1t*2+bd.HK*3)/6 "Diemtbm" 
from BangDiemMon as bd
full outer join  DSHocSinh as hs 
on bd.iDhocsinh=hs.iDhocsinh

select hs.Hoten,bd.Diem15p,bd.Diem1t,bd.HK,bd.Diemtbm
from DSHocSinh as hs
Left join BangDiemMon as bd
on bd.iDhocsinh = hs.iDhocsinh

go

create proc USP_DanhSachBangDiemTheoLop 
@MaLop int
AS
BEGIN
	select hs.iDhocsinh, hs.Hoten,bd.idmonhoc,bd.Diem15p,bd.Diem1t,bd.HK,bd.Diemtbm,bd.Ghichu
	from DSHocSinh as hs
	Left join BangDiemMon as bd
	on bd.iDhocsinh = hs.iDhocsinh
	where hs.iDlop = @MaLop
END

go

create proc USP_DanhSachBangDiem 
AS
BEGIN
	select hs.iDhocsinh, hs.Hoten,bd.idmonhoc,bd.Diem15p,bd.Diem1t,bd.HK,bd.Diemtbm ,bd.Ghichu
	from DSHocSinh as hs
	Left join BangDiemMon as bd
	on bd.iDhocsinh = hs.iDhocsinh
END

go

alter proc USP_DanhSachBangDiemByMonHoc 
@idmonhoc int,@hocki int, @iDlop int
AS
BEGIN
	select hs.iDhocsinh, hs.Hoten,bd.idmonhoc,bd.Diem15p,bd.Diem1t,bd.HK,bd.Diemtbm ,bd.Hocki,bd.Ghichu
	from DSHocSinh as hs
	Left join BangDiemMon as bd
	on bd.iDhocsinh = hs.iDhocsinh and bd.idmonhoc=@idmonhoc and bd.Hocki=@hocki 
	where hs.iDlop=@iDlop 
End
go

exec USP_DanhSachBangDiemByMonHoc @idmonhoc , @hocki , @iDlop

select hs.iDhocsinh, hs.Hoten,bd.idmonhoc,bd.Diem15p,bd.Diem1t,bd.HK,bd.Diemtbm,bd.Hocki
from DSHocSinh as hs
Left join BangDiemMon as bd
on bd.iDhocsinh = hs.iDhocsinh
where hs.iDlop = 1 and bd.idmonhoc=1 and bd.Hocki=1


EXEC USP_DanhSachBangDiemTheoLop @MaLop = 1

EXEC USP_DanhSachBangDiem

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

SELECT dshs.iDhocsinh, dshs.Hoten, l.Tenlop, dshs.Ngaysinh,dshs.Gioitinh,dshs.Diachi,dshs.Email,dshs.TBHKI,dshs.TBHKII FROM DSHocSinh as dshs,Lop as l where dshs.iDlop = l.iDlop and l.Tenlop = '11A3'


select *from MonHoc
select *from DSHocSinh
UPDATE MonHoc SET DiemDat = 5.5 where iDmonhoc=1

UPDATE BangDiemMon SET idmonhoc = 1 , Diem15p = 5 , Diem1t = 7 , HK = 6 ,Hocki = 1 WHERE iDhocsinh = 4

go

alter proc USP_Insert
@idhocsinh int,@idmonhoc int, @idlop int , @diem15p float, @diem1t float,@hk float,@hocki int,@diemdat int,@slm int
as
begin
	INSERT INTO BangDiemMon (iDhocsinh,idmonhoc,idlop,Diem15p,Diem1t,HK,Hocki) 
	values (@idhocsinh,@idmonhoc,@idlop,@diem15p,@diem1t,@hk,@hocki)
	update BangDiemMon 
	set Diemtbm = (@diem15p+@diem1t*2+@hk*3)/@slm
	where iDhocsinh=@idhocsinh

	update BangDiemMon set Ghichu= N'Đạt' where Diemtbm > @diemdat

	update BangDiemMon set Ghichu = N'Rớt'
	where Diemtbm < @diemdat

end

go


alter proc USP_Update
@idhocsinh int, @idmonhoc int, @diem15p float,@diem1t float,@hk float,@hocki int,@diemdat int,@slm int
as
begin
	update BangDiemMon set Diem15p=@diem15p,Diem1t=@diem1t,HK=@hk,Hocki=@hocki
	where iDhocsinh=@idhocsinh and idmonhoc=@idmonhoc

	update BangDiemMon  set Diemtbm = (Diem15p + Diem1t * 2 + HK * 3) / @slm
	update BangDiemMon set Ghichu= N'Đạt' where Diemtbm > @diemdat and iDhocsinh=@idhocsinh
	update BangDiemMon set Ghichu= N'Rớt' where Diemtbm < @diemdat and iDhocsinh=@idhocsinh
end



exec USP_Insert @idhocsinh=8,@idmonhoc=1,@idlop=3,@diem15p=7,@diem1t=7,@hk=8,@hocki=1

exec USP_InsertBangDiem @idhocsinh=4,@idmonhoc=1,@idlop=4,@diem15p=6,@diem1t=7,@hk=8,@hocki=1

exec USP_DanhSachBangDiem

go

select *from BangDiemMon

go

create proc USP_DanhSachDiemHienTai
as
begin
	select hs.iDhocsinh,hs.Hoten,bd.idmonhoc,bd.Diem15p,bd.Diem1t,bd.HK,bd.Diemtbm,bd.Hocki,bd.Ghichu from BangDiemMon as  bd , DSHocSinh as hs
	where bd.iDhocsinh=hs.iDhocsinh
	order by iDhocsinh asc
end

exec USP_DanhSachDiemHienTai 


select count(Diemtbm)
from BangDiemMon
where idmonhoc = 1 and idlop = 3 and Diemtbm >= 5

Declare @soluongdat int


Set @soluongdat = (select count(Diemtbm)
					from BangDiemMon
					where idmonhoc = 1 and idlop = 1 and Diemtbm >= 5)
			select @soluongdat


update BangDiemMon set Ghichu= N'Đạt' 
where Diemtbm >= 5
select *from BangDiemMon


update BangDiemMon set Ghichu = N'Rớt'
where Diemtbm < 5

--Set dữ liệu cho bảng tổng kết môn--


CREATE TABLE TongKetMon(
	[STT] int IDENTITY(1,1),
	[ID Học Sinh] int,
	[ID Lớp] int,
	[ID môn học] int,
	[Điểm tb môn] decimal(10,1),
	[Ghi chú] nvarchar(50),
	[Học kì] int 
)
update TongKetMon set [Học kì] = 1

select hs.Hoten as [Họ tên],l.Tenlop as[Tên lớp] ,mh.Tenmon as [Tên môn] ,tkm.[Điểm tb môn],tkm.[Ghi chú],tkm.[Học kì] from TongKetMon as tkm,Lop as l,DSHocSinh as hs,MonHoc as mh 
where [ID Lớp] = 1 and [ID môn học] = 2 and tkm.[ID Học Sinh] = hs.iDhocsinh and tkm.[ID Lớp] = l.iDlop and tkm.[ID môn học] = mh.iDmonhoc

GO

alter PROC USP_TongKetMon 
@idlop int, @idmonhoc int
AS
BEGIN
	select hs.Hoten as [Họ tên],l.Tenlop as[Tên lớp] ,mh.Tenmon as [Tên môn] ,tkm.[Điểm tb môn],tkm.[Ghi chú] ,tkm.[Học kì] from TongKetMon as tkm,Lop as l,DSHocSinh as hs,MonHoc as mh 
	where [ID Lớp] = @idlop and [ID môn học] = @idmonhoc and tkm.[ID Học Sinh] = hs.iDhocsinh and tkm.[ID Lớp] = l.iDlop and tkm.[ID môn học] = mh.iDmonhoc

END

EXEC USP_TongKetMon 1,1

go


delete from TongKetMon where [ID Học Sinh]=35

select COUNT(*) from TongKetMon where [Ghi chú] = N'Đạt' and [ID môn học] = 1 and [ID Lớp] = 1

select COUNT(*) from TongKetMon where [Ghi chú] = N'Rớt' and [ID môn học]=1 and [ID Lớp]=1

GO


	
END 

INSERT INTO TongKetMon ([ID Học Sinh],[ID Lớp],[ID môn học],[Điểm tb môn],[Ghi chú],[Học kì])
SELECT iDhocsinh,idlop,idmonhoc,Diemtbm,Ghichu,Hocki
FROM BangDiemMon


SELECT Tenlop
FROM Lop

drop table TongKetMon

select *from BangDiemMon where idlop=1 and idmonhoc=1
select *from MonHoc

alter proc USP_Insert
@idhocsinh int,@idmonhoc int, @idlop int , @diem15p float, @diem1t float,@hk float,@hocki int,@diemdat int
as
begin
	INSERT INTO BangDiemMon (iDhocsinh,idmonhoc,idlop,Diem15p,Diem1t,HK,Hocki) 
	values (@idhocsinh,@idmonhoc,@idlop,@diem15p,@diem1t,@hk,@hocki)
	update BangDiemMon 
	set Diemtbm = (@diem15p+@diem1t*2+@hk*3)/6
	where iDhocsinh=@idhocsinh

	update BangDiemMon set Ghichu= N'Đạt' where Diemtbm > @diemdat

	update BangDiemMon set Ghichu = N'Rớt'
	where Diemtbm < @diemdat

	INSERT INTO TongKetMon ([ID Học Sinh],[ID môn học],[Điểm tb môn])
	VALUES (@idhocsinh,@idmonhoc,@idlop)

	update TongKetMon 
	set [Điểm tb môn] = (@diem15p+@diem1t*2+@hk*3)/6
	where [ID Học Sinh]=@idhocsinh

	update TongKetMon
	set [Ghi chú] = N'Đạt' where [Điểm tb môn] > @diemdat
	update TongKetMon
	set [Ghi chú] = N'Rớt' where [Điểm tb môn] < @diemdat
	update TongKetMon
	set [ID Lớp] = @idlop where [ID Học Sinh] = @idhocsinh
	update TongKetMon
	set [Học kì] = @hocki where [ID Học Sinh] = @idhocsinh
 end

 select *from TK
 go

alter PROC USP_DoiMatKhau
 @tentaikhoan nvarchar(30), @matkhauhientai varchar(8000) , @checkmatkhauhientai varchar(8000) ,@matkhaumoi varchar(8000) 
 AS
 BEGIN
	 IF( @matkhauhientai = @checkmatkhauhientai )
	 UPDATE TK SET MatKhau = @matkhaumoi WHERE Tentk=@tentaikhoan
	 ELSE
	 PRINT N'Wrong Password!'
 END
 select *from TK
 EXEC USP_DoiMatKhau User1,'abcd','abcd','123'

 ALTER TABLE TongKetMon
 ADD CONSTRAINT fk_IDhocsinh_tkm FOREIGN KEY ([ID học sinh]) REFERENCES DSHocSinh (iDhocsinh) ON DELETE CASCADE

  ALTER TABLE BangDiemMon
 ADD CONSTRAINT fk_IDhocsinh_BangDiemMon FOREIGN KEY (iDhocsinh) REFERENCES DSHocSinh (iDhocsinh) ON DELETE CASCADE

 ALTER TABLE TongKetHocKi
 ADD CONSTRAINT fk_IDLop_TongKetHocKi FOREIGN KEY (iDlop) REFERENCES Lop (iDlop) ON DELETE CASCADE

  ALTER TABLE TongKetHocKi
 ADD CONSTRAINT fk_IDBangDiemMon_TongKetHocKi FOREIGN KEY (iDbangdiem) REFERENCES BangDiemMon (STT) ON DELETE CASCADE
 go

CREATE PROC USP_TimKiemHsByTen
@tenhocsinh nvarchar(50)
AS
BEGIN
	SELECT hs.Hoten,l.Tenlop,hs.Gioitinh,hs.Ngaysinh,hs.Diachi,hs.Email,hs.TBHKI,hs.TBHKII FROM DSHocSinh AS hs , Lop AS l
	WHERE hs.iDlop= l.iDlop AND hs.Hoten LIKE N'%'+@tenhocsinh+'%'
END

EXEC USP_TimKiemHsByTen N'a' 

SELECT l.Tenlop, l.Siso , count(bdm.Ghichu) as N'Số lượng đạt' FROM TongKetHocKi as hk, Lop as l, BangDiemMon as bdm 
WHERE hk.iDlop = l.iDlop and hk.iDbangdiem=bdm.STT and l.iDlop=1

Insert into TongKetHocKi 
select l.idlop,bdm.STT
from Lop as l , BangDiemMon as bdm
where l.iDlop=bdm.idlop

select l.Tenlop,l.Siso,bdm.Diemtbm,bdm.Ghichu from TongKetHocKi as hk, Lop as l,BangDiemMon as bdm 
where l.iDlop=hk.iDlop and bdm.STT=hk.iDbangdiem 

select hs.Hoten, AVG(bdm.Diemtbm) as 'TBHKI'
from BangDiemMon as bdm, DSHocSinh as hs,Lop as l , MonHoc as mh
where bdm.iDhocsinh=hs.iDhocsinh and bdm.idlop=l.iDlop and l.iDlop=1
group by hs.Hoten

GO

alter PROC USP_TongKetHocKi @idlop int,@hocki int
AS
BEGIN
	select hs.Hoten as N'Họ tên', cast (AVG(bdm.Diemtbm) as decimal(10,1) ) as 'TBHKI'
	from BangDiemMon as bdm, DSHocSinh as hs,Lop as l , MonHoc as mh
	where bdm.iDhocsinh=hs.iDhocsinh and bdm.idlop=l.iDlop and l.iDlop=@idlop and bdm.Hocki=@hocki
	group by hs.Hoten
END

EXEC USP_TongKetHocKi 1 , 1


select *from BangDiemMon where iDhocsinh=35
delete from TongKetHocKi
