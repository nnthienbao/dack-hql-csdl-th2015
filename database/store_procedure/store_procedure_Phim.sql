USE DB_LOTTECINEMA

-----------------------------------
---------------PHIM----------------
GO
-- LAY DS PHIM
CREATE PROC LAYDSPHIM
AS
BEGIN
	BEGIN TRAN
		SELECT * FROM PHIM
	COMMIT TRAN
END

GO
-- LAY PHIM THEO MA PHIM
CREATE PROC LAYPHIMTHEOMAPHIM
	@MaPhim VARCHAR(10)
AS
BEGIN
	BEGIN TRAN
		SELECT * FROM PHIM WHERE MaPhim=@MaPhim
	COMMIT TRAN
END

GO
-- THEM PHIM
ALTER PROC TAOPHIM
	@TenPhim NVARCHAR(200),
	@TinhTrang NVARCHAR(50),
	@ThoiLuong int,
	@MaDoHot int
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			INSERT INTO PHIM(TenPhim, TinhTrang, ThoiLuong, MaDoHot)
				VALUES(@TenPhim, @TinhTrang, @ThoiLuong, @MaDoHot)
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		DECLARE @MsgError NVARCHAR(2000)
		SELECT @MsgError = N'Lỗi ' + ERROR_MESSAGE()
		RAISERROR(@MsgError, 16, 1)
		ROLLBACK TRAN
	END CATCH
END

GO
-- CAP NHAT PHIM
CREATE PROC CAPNHATPHIM
	@MaPhim VARCHAR(10),
	@TenPhim NVARCHAR(200),
	@TinhTrang NVARCHAR(50),
	@ThoiLuong int,
	@MaDoHot int
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			UPDATE PHIM
			SET TenPhim=ISNULL(@TenPhim, TenPhim),
				TinhTrang=ISNULL(@TinhTrang, @TinhTrang),
				ThoiLuong=ISNULL(@ThoiLuong, @ThoiLuong),
				MaDoHot=ISNULL(@MaDoHot, @MaDoHot)
			WHERE MaPhim=@MaPhim
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		DECLARE @MsgError NVARCHAR(2000)
		SELECT @MsgError = N'Lỗi ' + ERROR_MESSAGE()
		RAISERROR(@MsgError, 16, 1)
		ROLLBACK TRAN
	END CATCH
END