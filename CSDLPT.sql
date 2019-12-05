
create database DETHI_DB;

use DETHI_DB;

create table CoSo(
MACS nchar(3) primary key,
TENCS nvarchar(40) unique,
DIACHI nvarchar(100)
);

INSERT INTO CoSo VALUES ('CS1','THITN Server 1','HCM')
INSERT INTO CoSo VALUES ('CS2','THITN Server 2','DN')

create table Khoa(
MAKH nchar(8) primary key,
TENKH nvarchar(40) unique,
MACS nchar(3) foreign key references CoSo(MACS),);

INSERT INTO Khoa VALUES ('1','CNTT','CS1');
INSERT INTO Khoa VALUES ('2','QTKD','CS1');
INSERT INTO Khoa VALUES ('3','NGAN HANG','CS1');
INSERT INTO Khoa VALUES ('4','D-DT','CS1');
INSERT INTO Khoa VALUES ('5','T-TK','CS1');
INSERT INTO Khoa VALUES ('6','BHLD','CS1');
INSERT INTO Khoa VALUES ('7','TDTT','CS2');
INSERT INTO Khoa VALUES ('8','LUAT','CS2');
INSERT INTO Khoa VALUES ('9','KDQT','CS2');
INSERT INTO Khoa VALUES ('10','ABC','CS2');
INSERT INTO Khoa VALUES ('11','DEF','CS2');
INSERT INTO Khoa VALUES ('12','GHI','CS2');

create table Lop(
MALOP nchar(8) primary key,
TENLOP nvarchar(40) unique,
MAKH nchar(8) foreign key references Khoa(MAKH),);

INSERT INTO Lop VALUES ('15050301','A','1');
INSERT INTO Lop VALUES ('15050302','B','2');
INSERT INTO Lop VALUES ('15050303','C','3');
INSERT INTO Lop VALUES ('15050304','D','4');
INSERT INTO Lop VALUES ('16050301','E','5');
INSERT INTO Lop VALUES ('16050302','F','6');
INSERT INTO Lop VALUES ('16050303','G','7');
INSERT INTO Lop VALUES ('16050304','H','8');

create table MonHoc(
MAMH nchar(5) primary key,
TENMH nvarchar(40) unique,);

INSERT INTO MonHoc VALUES ('50201', 'CSDLPT')
INSERT INTO MonHoc VALUES ('50202', 'BIGDATA')
INSERT INTO MonHoc VALUES ('50303', 'Android')
INSERT INTO MonHoc VALUES ('50404', 'Web')
INSERT INTO MonHoc VALUES ('50205', 'Java')
INSERT INTO MonHoc VALUES ('50306', 'Java2')
INSERT INTO MonHoc VALUES ('50407', 'C')
INSERT INTO MonHoc VALUES ('50508', 'C#')
INSERT INTO MonHoc VALUES ('50209', 'PTTKYC')
INSERT INTO MonHoc VALUES ('50310', 'HCSDL')
INSERT INTO MonHoc VALUES ('50511', 'BI')
INSERT INTO MonHoc VALUES ('50612', 'ERP')
INSERT INTO MonHoc VALUES ('50313', 'MIS')
INSERT INTO MonHoc VALUES ('50214', 'HRM')
INSERT INTO MonHoc VALUES ('50115', 'SCM')
INSERT INTO MonHoc VALUES ('50216', 'DM')

create table SinhVien(
MASV nchar(8) primary key,
HO nvarchar(40),
TEN nvarchar(10),
NGAYSINH datetime,
DIACHI nvarchar(40),
MALOP nchar(8) foreign key references Lop(MALOP),
check(HO like '%[ ^a-zA-Z]%'),
check(TEN like '%[ ^a-zA-Z]%'));

INSERT INTO SinhVien VALUES ('51503358','NGUYEN','A',GETDATE(),'HCM','15050301');
INSERT INTO SinhVien VALUES ('51503359','NGUYEN','B',GETDATE(),'HN','15050301');
INSERT INTO SinhVien VALUES ('51503360','NGUYEN','C',GETDATE(),'HCM','15050301');
INSERT INTO SinhVien VALUES ('51503361','NGUYEN','D',GETDATE(),'HN','15050301');
INSERT INTO SinhVien VALUES ('51503362','NGUYEN','E',GETDATE(),'HN','15050302');
INSERT INTO SinhVien VALUES ('51503363','NGUYEN','F',GETDATE(),'HN','15050303');
INSERT INTO SinhVien VALUES ('51503364','NGUYEN','G',GETDATE(),'HN','15050304');
INSERT INTO SinhVien VALUES ('51503365','NGUYEN','H',GETDATE(),'HN','16050301');
INSERT INTO SinhVien VALUES ('51503366','NGUYEN','I',GETDATE(),'HN','16050302');
INSERT INTO SinhVien VALUES ('51503367','NGUYEN','J',GETDATE(),'HN','16050303');
INSERT INTO SinhVien VALUES ('51503368','NGUYEN','K',GETDATE(),'HN','16050304');
INSERT INTO SinhVien VALUES ('51503369','NGUYEN','L',GETDATE(),'HN','16050304');
INSERT INTO SinhVien VALUES ('51503370','NGUYEN','M',GETDATE(),'HCM','15050303');
INSERT INTO SinhVien VALUES ('51503370','NGUYEN','N',GETDATE(),'HCM','15050304');
INSERT INTO SinhVien VALUES ('51503371','NGUYEN','O',GETDATE(),'HCM','16050301');
INSERT INTO SinhVien VALUES ('51503372','NGUYEN','P',GETDATE(),'HCM','16050302');
INSERT INTO SinhVien VALUES ('51503373','NGUYEN','Q',GETDATE(),'HCM','15050303');

create table GiaoVien(
MAGV nchar(8) primary key,
HO nvarchar(40),
TEN nvarchar(10),
HOCVI nvarchar(40),
MAKH nchar(8) foreign key references Khoa(MAKH));

INSERT INTO GiaoVien VALUES ('CNTT01','LE VAN','A','ThS','1');
INSERT INTO GiaoVien VALUES ('QTKD02','LE VAN','B','TS','2');
INSERT INTO GiaoVien VALUES ('CNTT02','TRAN NGO','C','ThS','7');
INSERT INTO GiaoVien VALUES ('KDQT01','TRAN NGO','D','TS','8');

create table GiaoVien_DangKy(
MAGV nchar(8)foreign key references GiaoVien(MAGV),
MALOP nchar(8)foreign key references Lop(MALOP) ,
MAMH nchar(5)foreign key references MonHoc(MAMH),
TRINHDO char(1) check (TRINHDO like '[ABC]'),
NGAYTHI datetime default getdate(),
LAN smallint check (LAN >= 1 AND LAN <= 2),
SOCAUTHI smallint check (SOCAUTHI >= 10 AND SOCAUTHI <= 100),
THOIGIAN smallint check (THOIGIAN >= 15 AND THOIGIAN <= 60),
primary key (MALOP, MAMH, LAN)
);

INSERT INTO GiaoVien_DangKy VALUES ('CNTT01','15050303','50201','A',GETDATE(),1,40,60);
INSERT INTO GiaoVien_DangKy VALUES ('CNTT01','15050302','50201','A',GETDATE(),1,40,60);
INSERT INTO GiaoVien_DangKy VALUES ('CNTT01','15050301','50201','A',GETDATE(),1,40,60);
INSERT INTO GiaoVien_DangKy VALUES ('CNTT01','16050303','50201','A',GETDATE(),1,40,60);
INSERT INTO GiaoVien_DangKy VALUES ('CNTT01','16050301','50201','A',GETDATE(),1,40,60);
INSERT INTO GiaoVien_DangKy VALUES ('QTKD02','16050302','50201','C',GETDATE(),2,60,90);

create table BoDe(
CAUHOI int primary key,
MAMH nchar(5)foreign key references MonHoc(MAMH),
TRINHDO nchar(1) check (TRINHDO like '[ABC]'),
NOIDUNG text,
A nvarchar(30),
B nvarchar(30),
C nvarchar(30),
D nvarchar(30),
DAPAN char(1) check (DAPAN like '[ABCD]'),
MAGV nchar(8) foreign key references GiaoVien(MAGV),
);

create table BangDiem(
MAMH nchar(5)foreign key references MonHoc(MAMH),
MASV nchar(8)foreign key references SinhVien(MASV),
LAN smallint check (LAN >= 1 AND LAN <= 2),
NGAYTHI datetime, -- check proredure or function to getdate from GiaoVien_DangKy
DIEM float check (DIEM >= 0 AND DIEM <= 10),
BAITHI text, -- check procedure to save a record of select from BaiThi, SinhVien
primary key(MASV, MAMH, LAN)
);

create table Login(
username nvarchar(50) primary key,
pass nvarchar(50)
)

create table KQ_Thi(
MSV nchar(8),
MAMH nchar(8),
LAN int,
CAUHOI int,
CHOSE nvarchar(1),
DAPAN nvarchar(1),
id int IDENTITY(1,1) PRIMARY KEY,
Correct int,
NgayThi nvarchar(50),
)