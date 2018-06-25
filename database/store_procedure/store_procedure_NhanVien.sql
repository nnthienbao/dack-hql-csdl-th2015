use DB_LOTTECINEMA

-----------------------------------
------------NHANVIEN---------------
-- LAY NHAN VIEN
ALTER PROC LAYNHANVIEN
	@MANV varchar(11)
AS
BEGIN
	BEGIN TRAN
		SELECT *
		FROM NHANVIEN NV
		WHERE NV.MaNhanVien=@MANV
	COMMIT TRAN
END