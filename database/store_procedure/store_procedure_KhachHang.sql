use DB_LOTTECINEMA

-----------------------------------
------------KHACHHANG---------------
GO
-- LAY DANH SACH KHACH HANG
ALTER PROC LAYDSKHACHHANG
AS
BEGIN
	BEGIN TRAN
		SELECT *
		FROM KHACHHANG
	COMMIT TRAN
END

GO
-- THEM KHACH HANG
ALTER PROC THEMKHACHHANG
	@HOTEN nvarchar(70), @GIOITINH BIT, @NGAYSINH DATE, @CMND VARCHAR(10), @SODIENTHOAI VARCHAR(11)
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			IF EXISTS(SELECT * FROM KHACHHANG WHERE KHACHHANG.CMND=@CMND)
			BEGIN
				RAISERROR('Số CMND đã được sử dụng', 16, 1)
			END
			INSERT INTO KHACHHANG VALUES(@HOTEN, @GIOITINH, @NGAYSINH, @CMND, @SODIENTHOAI)
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		DECLARE @ErrorMsg NVARCHAR(2000)
		SELECT @ErrorMsg = N'Lỗi: ' + ERROR_MESSAGE()
		RAISERROR(@ErrorMsg, 16,1)
		ROLLBACK TRAN
	END CATCH
END

GO
-- CAP NHAT KHACH HANG
ALTER PROC CAPNHATKHACHHANG
	@MAKHACHHANG NVARCHAR(10),
	@HOTEN nvarchar(70) = NULL,
	@GIOITINH BIT = NULL,
	@NGAYSINH DATE = NULL,
	@CMND VARCHAR(10) = NULL,
	@SODIENTHOAI VARCHAR(11) = NULL
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			IF NOT EXISTS (SELECT * FROM KHACHHANG WHERE KHACHHANG.MaKhachHang = @MAKHACHHANG)
			BEGIN
				RAISERROR(N'Không tìm thấy khách hàng', 16, 1)
			END

			UPDATE KHACHHANG
			SET HoTen=ISNULL(@HOTEN, HoTen),
				GioiTinh=ISNULL(@GIOITINH, GioiTinh),
				NgaySinh=ISNULL(@NGAYSINH, NgaySinh),
				CMND=ISNULL(@CMND, CMND),
				SoDienThoai=ISNULL(@SODIENTHOAI, SoDienThoai)
			WHERE MaKhachHang = @MAKHACHHANG
		COMMIT TRAN
		RAISERROR (N'Cập nhật khách hàng thành công', 10, 1);
	END TRY
	BEGIN CATCH
		DECLARE @ErrorMsg VARCHAR(2000)
		SELECT @ErrorMsg = N'Lỗi: ' + ERROR_MESSAGE()
		RAISERROR(@ErrorMsg, 16,1)
		ROLLBACK TRAN
	END CATCH
END