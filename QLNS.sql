USE [master]
GO
/****** Object:  Database [DOAN_QUANLYNHASACH_NHOM12]  ******/
CREATE DATABASE [DOAN_QUANLYNHASACH]
GO
USE [DOAN_QUANLYNHASACH]
GO
SET DATEFORMAT DMY
GO

DROP DATABASE DOAN_QUANLYNHASACH 

/****** Object:  Table [dbo].[TAIKHOAN] ******/

CREATE TABLE [dbo].[TAIKHOAN](
	[USERNAME] [varchar](100) NOT NULL PRIMARY KEY ,
	[PASSWORD] [varchar](100) NOT NULL,
	[MANV] INT NOT NULL,
)





/****** Object:  Table [dbo].[THELOAI] ******/
CREATE TABLE [dbo].[THELOAI](
	[MATL] [varchar](10) NOT NULL PRIMARY KEY,
	[TENTL] [nvarchar](200) NOT NULL,
)

insert into THELOAI VALUES('TL01', N'KỸ NĂNG SỐNG')
insert into THELOAI VALUES('TL02', N'KHOA HỌC')
Insert Into THELOAI(TENTL,MATL) Values (N'Cổ tích','TH001');
Insert Into THELOAI(TENTL,MATL) Values (N'Tình cảm','TH002');
Insert Into THELOAI(TENTL,MATL) Values (N'Trinh thám','TH003');
Insert Into THELOAI(TENTL,MATL) Values (N'Văn học','TH004');
Insert Into THELOAI(TENTL,MATL) Values (N'Dân gian','TH005');


/****** Object:  Table [dbo].[NHACUNGCAP]  ******/

CREATE TABLE [dbo].[NHACUNGCAP](
	[MANCC] [varchar](10) NOT NULL PRIMARY KEY,
	[TENNCC] [nvarchar](100) NOT NULL,
	[SDT] [varchar](15) NOT NULL,
	[DIACHI] [nvarchar](100) NOT NULL,
	[EMAIL] [varchar](100) NOT NULL
	)

Insert Into NHACUNGCAP(MANCC, TENNCC, SDT, DIACHI, EMAIL) Values ('MH001', N'Duong Vu Hoang Hiep', '0961600587', 'Dong Nai', 'faeunidwa@gmail.com' );
select * from NHACUNGCAP
/****** Object:  Table [dbo].[DAUSACH]    ******/

CREATE TABLE [dbo].[DAUSACH](
	[MADS] [int] IDENTITY NOT NULL PRIMARY KEY,
	[TENSACH] [nvarchar](200) NOT NULL,
	[MATL] [varchar](10) NOT NULL REFERENCES THELOAI(MATL),
	[TACGIA] [nvarchar](100) NOT NULL,
	[SOLUONG] [int] NOT NULL,
	[DONGIA] [int] NOT NULL,
)



Insert Into DAUSACH(TENSACH, MATL, TACGIA, SOLUONG, DONGIA) Values ( N'Doremon', 'TH005', N'VIET NAM', '100',30000 );

INSERT INTO DAUSACH VALUES(N'ĐỜI NGẮN ĐỪNG NGỦ DÀI', 'TL01', 'KHÔNG BIẾT', 100, 50000 )
INSERT INTO DAUSACH VALUES(N'TONY BUỔI SÁNG', 'TL01', 'TONY', 100, 50000 )

select * from DAUSACH


/****** Object:  Table [dbo].[KHACHHANG] ******/
CREATE TABLE [dbo].[KHACHHANG](
	[MAKH] [varchar](20)  NOT NULL PRIMARY KEY,
	[HOTEN] [nvarchar](100) NOT NULL,
	[DIACHI] [nvarchar](100) NOT NULL,
	[SDT] [varchar](15) NOT NULL,
	[EMAIL] [varchar](50) NOT NULL,
	[GIOITINH] [nvarchar](10) NOT NULL,
)

drop table KHACHHANG
Insert Into KHACHHANG (MAKH, HOTEN, DIACHI, SDT, EMAIL, GIOITINH) Values ('CUS001', N'Duong Vu Hoang Hiep', 'Dong Nai', '0961600587', 'faeunidwa@gmail.com','Nam');
select * from KHACHHANG

/****** Object:  Table [dbo].[CHUCVU]    Script Date: 19/06/2015 5:01:00 AM ******/
CREATE TABLE [dbo].[CHUCVU](
	[MACV] [varchar](20)NOT NULL PRIMARY KEY,
	[TENCV] [nvarchar](100) NOT NULL,
)

Insert Into CHUCVU(TENCV,MACV) Values (N'Nhân viên bán hàng','MAH001');
Insert Into CHUCVU(TENCV,MACV) Values (N'Nhân viên quản lý','MAH002');

/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 19/06/2015 5:01:00 AM ******/
CREATE TABLE [dbo].[NHANVIEN](
	[MANV] [int] IDENTITY NOT NULL PRIMARY KEY,
	[HOTEN] [nvarchar](100) NOT NULL,
	[SDT] [varchar](15) NOT NULL,
	[DIACHI] [nvarchar](100) NOT NULL,
	[EMAIL] [varchar](100) NOT NULL,
	[MACV] [varchar] (20) NOT NULL REFERENCES CHUCVU(MACV),
)

INSERT INTO NHANVIEN VALUES(N'NGUYỄN VĂN A','091021312', N'QUẬN 9, THÀNH PHỐ HỒ CHÍ MINH', 'koodrg@gmail.com', 'MAH001')
Insert Into NHANVIEN ( HOTEN, SDT, DIACHI, EMAIL,MACV) Values (N'Duong Vu Hoang Hiep', '0961600587', N'Dong Nai', 'faeunidwa@gmail.com','MAH002');
select * from NHANVIEN

/****** Object:  Table [dbo].[HOADON]  ******/

CREATE TABLE [dbo].[HOADON](
	[MAHD] [int] NOT NULL IDENTITY PRIMARY KEY ,
	[NGAYLAP] [date] NOT NULL,
	[MANV] [int] NOT NULL REFERENCES NHANVIEN(MANV),
	[TONGTIEN] [int] NOT NULL,
)

alter table hoadon add tinhtrang int default 0



INSERT INTO HOADON VALUES(GETDATE(), 1, 0)



/****** Object:  Table [dbo].[CHITIETHOADON] ******/

CREATE TABLE [dbo].[CHITIETHOADON](
	[MACTHD] [int] IDENTITY NOT NULL PRIMARY KEY,
	[MAHD] [int] NOT NULL REFERENCES HOADON(MAHD),
	[MADS] [int] NOT NULL REFERENCES DAUSACH(MADS),
	[MATL] [varchar](10) NOT NULL REFERENCES THELOAI(MATL),
	[SOLUONG] [int] NOT NULL,
	[DONGIA] [int] NOT NULL,
	[THANHTIEN] [int] NOT NULL,
	)

/****** Object:  Table [dbo].[PHIEUNHAP]    Script Date: 19/06/2015 5:01:00 AM ******/

CREATE TABLE [dbo].[PHIEUNHAP](
	[MAPN] [int] IDENTITY NOT NULL PRIMARY KEY,
	[NGAYLAP] [date] NOT NULL,
	[MANV] int NOT NULL REFERENCES NHANVIEN(MANV),
	[MANCC] [varchar](10) NOT NULL REFERENCES NHACUNGCAP(MANCC),
	[TONGTIEN] int NOT NULL,
 )



 alter table PHIEUNHAP ADD TINHTRANG INT DEFAULT 0

/****** Object:  Table [dbo].[CHITIETPHIEUNHAP]    Script Date: 19/06/2015 5:01:00 AM ******/
CREATE TABLE [dbo].[CHITIETPHIEUNHAP](
	[MACTPN] [int] IDENTITY NOT NULL PRIMARY KEY,
	[MAPN] [int] NOT NULL REFERENCES PHIEUNHAP(MAPN),
	[MADS] [int] NOT NULL REFERENCES DAUSACH(MADS),
	[SOLUONG] [int] NOT NULL,
	[DONGIA] [int] NOT NULL,
	[THANHTIEN] [int] NOT NULL,
)

--/****** Object:  Table [dbo].[TONKHO]    Script Date: 19/06/2015 5:01:00 AM ******/
--SET ANSI_NULLS ON
--GO
--SET QUOTED_IDENTIFIER ON
--GO
--CREATE TABLE [dbo].[TONKHO](
--	[STT] [int] IDENTITY(1,1) NOT NULL,
--	[MADS] [int] NOT NULL REFERENCES DAUSACH(MADS),
--	[NGAYPHATSINH] [date] NOT NULL,
--	[TONDAU] [int] NOT NULL,
--	[PHATSINH] [int] NOT NULL,
--	[TONCUOI] [int] NOT NULL,
--PRIMARY KEY CLUSTERED 
--(
--	[STT] ASC
--)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
--) ON [PRIMARY]

--GO


--ALTER DATABASE [DOAN_QUANLYNHASACH_NHOM14] SET  READ_WRITE 
--GO



CREATE PROC USP_addBillDetail
@mahd int ,@masach int, @soluong int
AS
BEGIN
	DECLARE @isExistBillDetail int, @soluongsach int, @tonkhosach int, @thanhtien int,@dongia int
	set @isExistBillDetail = 0
	SELECT @isExistBillDetail=MACTHD, @soluongsach=SOLUONG FROM CHITIETHOADON WHERE MADS = @masach AND MAHD= @mahd
	SELECT @tonkhosach=SOLUONG, @dongia=DONGIA FROM DAUSACH WHERE MADS= @masach 

	IF(@isExistBillDetail > 0) 
		BEGIN
			DECLARE @newCount int = @soluong + @soluongsach
			IF((@newCount > 0) AND (@newCount<@tonkhosach)) 
			BEGIN
				UPDATE CHITIETHOADON SET SOLUONG = @newCount, THANHTIEN=@dongia*@newCount Where MACTHD = @isExistBillDetail
			END
		END
	ELSE
		BEGIN
			SELECT @dongia=DAUSACH.DONGIA, @tonkhosach = DAUSACH.SOLUONG, @thanhtien=@dongia*@soluong FROM DAUSACH WHERE MADS = @masach
			IF(@tonkhosach > @soluong)
			BEGIN
				INSERT INTO CHITIETHOADON(MAHD,MADS,SOLUONG,DONGIA,THANHTIEN) VALUES (@mahd,@masach,@soluong,@dongia,@thanhtien)
			END
			ELSE SET @thanhtien=0
		END	
END

select * from CHITIETPHIEUNHAP

--CREATE PROC USP_addChiTietPhieuNhap
--@mapn int ,@masach int, @soluong int
--AS
--BEGIN
--	DECLARE @dongia int, @thanhtien int =0
--	SELECT @dongia=DONGIA, @thanhtien=@dongia * @soluong FROM DAUSACH WHERE MADS=@masach
--	INSERT INTO CHITIETPHIEUNHAP(MAPN, MADS,SOLUONG,DONGIA,THANHTIEN) VALUES (@mapn, @masach, @soluong,@dongia,@thanhtien)
--END

--SELECT MAPN FROM PHIEUNHAP WHERE MANCC =  1




create PROC USP_themChiTietPhieuNhap
@mapn int ,@masach int, @soluong int
AS
BEGIN
	DECLARE @laChiTietPhieuNhapDaTonTai int, @soluongsach int, @tonkhosach int, @thanhtien int,@dongia int
	set @laChiTietPhieuNhapDaTonTai = 0

	SELECT @laChiTietPhieuNhapDaTonTai=MACTPN, @soluongsach=SOLUONG FROM CHITIETPHIEUNHAP WHERE MADS = @masach AND MAPN= @mapn
	SELECT @tonkhosach=SOLUONG, @dongia=DONGIA FROM DAUSACH WHERE MADS= @masach 

	IF(@laChiTietPhieuNhapDaTonTai > 0) 
		BEGIN
			DECLARE @newCount int = @soluong + @soluongsach
			IF((@newCount > 0) AND (@newCount<@tonkhosach)) 
			BEGIN
				UPDATE CHITIETPHIEUNHAP SET SOLUONG = @newCount, THANHTIEN=@dongia*@newCount Where MACTPN = @laChiTietPhieuNhapDaTonTai
			END
			ELSE PRINT('So luong sach khong du')
		END

	ELSE
		BEGIN
			SELECT @dongia=DONGIA,@thanhtien=@dongia*@soluong FROM DAUSACH WHERE MADS= @masach
			INSERT INTO CHITIETPHIEUNHAP(MAPN,MADS,SOLUONG,DONGIA,THANHTIEN) VALUES (@mapn,@masach,@soluong,@dongia,@thanhtien)
		END	
END

SELECT * from CHITIETPHIEUNHAP
delete from PHIEUNHAP

USP_themChiTietPhieuNhap 1003 ,1,20

DELETE  FROM CHITIETPHIEUNHAP WHERE MACTPN =1008
select * from PHIEUNHAP

select * from DAUSACH WHERE MADS=1


create PROC USP_thanhToanPhieuNhap
@mapn int , @tongtien int
AS
BEGIN 
	UPDATE PHIEUNHAP SET TINHTRANG = 1, TONGTIEN = @tongtien WHERE MAPN=@mapn AND TINHTRANG=0 
END


select * from DAUSACH
select * from PHIEUNHAP

EXEC USP_thanhToanPhieuNhap 4, 50000

select * from NHANVIEN

INSERT INTO TAIKHOAN(USERNAME,PASSWORD,MANV) VALUES('aaa','1',2)

SELECT * FROM NHANVIEN
INSERT INTO NHANVIEN(HOTEN,SDT,DIACHI,EMAIL,MACV) VALUES(N'Nguyễn Hữu B','09123231',N'Quận Thủ Đức, Thành phố Hồ Chí Minh','ddsahs@gmail.com',2) 

select * from hoadon

select * from hoadon where month(NGAYLAP) =7 and year(NGAYLAP) =2020


/* cập nhật hàng trong kho sau khi đặt hàng hoặc cập nhật */
CREATE TRIGGER UTG_THEMCHITIETHOADON ON CHITIETHOADON AFTER INSERT AS 
BEGIN
	UPDATE DAUSACH 
	SET SOLUONG = DAUSACH.SOLUONG - (
		SELECT SOLUONG
		FROM inserted
		WHERE MADS = DAUSACH.MADS
	)
	FROM DAUSACH
	JOIN inserted ON DAUSACH.MADS = inserted.MADS
END
GO


SELECT * FROM HOADON
INSERT INTO HOADON VALUES(GETDATE(),1,0,0)

SELECT * FROM CHITIETHOADON

INSERT INTO CHITIETHOADON VALUES (25,1,6,50000,300000)

INSERT INTO CHITIETHOADON VALUES (25,2,6,50000,300000)


UPDATE CHITIETHOADON SET SOLUONG = 20 where macthd=30
SELECT * FROM DAUSACH WHERE MADS=1

/* cập nhật hàng trong kho sau khi cập nhật đặt hàng */
CREATE TRIGGER UTG_CAPNHATCHITIETHOADON on CHITIETHOADON after update AS
BEGIN
   UPDATE DAUSACH SET DAUSACH.SOLUONG = DAUSACH.SOLUONG -
	   (SELECT SOLUONG FROM inserted WHERE MADS = DAUSACH.MADS) +
	   (SELECT SOLUONG FROM deleted WHERE MADS = DAUSACH.MADS)
   FROM DAUSACH 
   JOIN deleted ON DAUSACH.MADS = deleted.MADS
end
GO


/* cập nhật hàng trong kho sau khi hủy đặt hàng */
create TRIGGER UTG_XOACHITIETHOADON ON CHITIETHOADON FOR DELETE AS 
BEGIN
	UPDATE DAUSACH
	SET SOLUONG = DAUSACH.SOLUONG + (SELECT SOLUONG FROM deleted WHERE MADS = DAUSACH.MADS)
	FROM DAUSACH 
	JOIN deleted ON DAUSACH.MADS = deleted.MADS
END




CREATE TRIGGER UTG_THEMCHITIETPHIEUNHAP ON CHITIETPHIEUNHAP AFTER INSERT AS 
BEGIN
	UPDATE DAUSACH 
	SET SOLUONG = DAUSACH.SOLUONG + (
		SELECT SOLUONG
		FROM inserted
		WHERE MADS = DAUSACH.MADS
	)
	FROM DAUSACH
	JOIN inserted ON DAUSACH.MADS = inserted.MADS
END
GO

/* cập nhật hàng trong kho sau khi cập nhật đặt hàng */
CREATE TRIGGER UTG_CAPNHATCHITIETPHIEUNHAP on CHITIETPHIEUNHAP after update AS
BEGIN
   UPDATE DAUSACH SET DAUSACH.SOLUONG = DAUSACH.SOLUONG +
	   (SELECT SOLUONG FROM inserted WHERE MADS = DAUSACH.MADS) -
	   (SELECT SOLUONG FROM deleted WHERE MADS = DAUSACH.MADS)
   FROM DAUSACH 
   JOIN deleted ON DAUSACH.MADS = deleted.MADS
end
GO


/* cập nhật hàng trong kho sau khi hủy đặt hàng */
create TRIGGER UTG_XOACHITIETPHIEUNHAP ON CHITIETPHIEUNHAP FOR DELETE AS 
BEGIN
	UPDATE DAUSACH
	SET SOLUONG = DAUSACH.SOLUONG - (SELECT SOLUONG FROM deleted WHERE MADS = DAUSACH.MADS)
	FROM DAUSACH 
	JOIN deleted ON DAUSACH.MADS = deleted.MADS
END


SELECT * FROM PHIEUNHAP
SELECT * FROM CHITIETPHIEUNHAP

INSERT INTO PHIEUNHAP VALUES (GETDATE(),1,'NCC1',0,0)

INSERT INTO CHITIETPHIEUNHAP VALUES (1003,2,22,50000,1100000)

SELECT * FROM DAUSACH WHERE MADS=2

UPDATE CHITIETPHIEUNHAP SET SOLUONG=25 WHERE MACTPN=1005

DELETE FROM CHITIETPHIEUNHAP WHERE MACTPN=1005

select * from DAUSACH

