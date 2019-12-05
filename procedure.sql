create proc [dbo].[sp_kiemtraMaKhoa]
@MAKH nchar(8)
as
BEGIN
	DECLARE  @result int
	if exists (select 1 from LINK.DETHI_DB.DBO.Khoa kh where kh.MAKH=@MAKH)
		begin
			select 1
		end
	else
		begin
			select 0
		end

END

create proc [dbo].[sp_kiemtraMaSV]
@MASV nchar(8)
as
BEGIN
	DECLARE  @result int
	if exists (select 1 from LINK.DETHI_DB.DBO.SinhVien sv where sv.MASV=@MASV)
		begin
			select 1
		end
	else
		begin
			select 0
		end

END

create proc [dbo].[sp_kiemtraMaGV]
@MAGV nchar(8)
as
BEGIN
	DECLARE  @result int
	if exists (select 1 from LINK.DETHI_DB.DBO.GiaoVien gv where gv.MAGV=@MAGV)
		begin
			select 1
		end
	else
		begin
			select 0
		end

END

create proc [dbo].[sp_kiemtraMaLop]
@MALOP nchar(8)
as
BEGIN
	DECLARE  @result int
	if exists (select 1 from LINK.DETHI_DB.DBO.Lop lp where Lp.MALOP=@MALOP)
		begin
			select 1
		end
	else
		begin
			select 0
		end

END