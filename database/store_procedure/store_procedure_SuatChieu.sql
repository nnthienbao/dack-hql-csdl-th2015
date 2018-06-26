USE DB_LOTTECINEMA

-----------------------------------
------------SUAT CHIEU---------------
GO
-- LAY DANH SACH SUAT CHIEU
ALTER PROC LAYDSSUATCHIEU
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			SELECT * FROM SUATCHIEU
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
-- LAY SUAT CHIEU THEO MA
ALTER PROC LAYSUATCHIEUTHEOMA
	@MaSuatChieu NVARCHAR(15)
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			SELECT * FROM SUATCHIEU WHERE MaSuatChieu=@MaSuatChieu
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		DECLARE @ErrorMsg NVARCHAR(2000)
		SELECT @ErrorMsg = N'Lỗi' + ERROR_MESSAGE()
		RAISERROR(@ErrorMsg, 16,1)
		ROLLBACK TRAN
	END CATCH
END

GO
--Tạo kiểu dữ liệu mới lưu danh sách chi tiết thiết bị cho suất chiếu
CREATE TYPE DS_THIETBI AS TABLE
(
	MaThieuBi int
)

GO
-- TAO SUAT CHIEU PHIM
ALTER PROC TAOSUATCHIEU
	@NgayChieu DATE, @ThoiGianBatDau TIME(7), @ThoiGianKetThuc TIME(7), @MaPhim VARCHAR(10), @MaPhong VARCHAR(9), @DS_THIETBI AS DS_THIETBI READONLY
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			INSERT INTO SUATCHIEU VALUES(@NgayChieu, @ThoiGianBatDau, @ThoiGianKetThuc, @MaPhim, @MaPhong)
			
			DECLARE @IdSuatChieu INT = SCOPE_IDENTITY()
			INSERT INTO CHITIETSUATCHIEU_THIETBI(MaSuatChieu, MaThietBi) SELECT @IdSuatChieu, * FROM @DS_THIETBI
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		DECLARE @ErrorMsg NVARCHAR(2000)
		SELECT @ErrorMsg = N'Lỗi' + ERROR_MESSAGE()
		RAISERROR(@ErrorMsg, 16,1)
		ROLLBACK TRAN
	END CATCH
END

GO
-- CAP NHAT SUAT CHIEU
CREATE PROC CAPNHATSUATCHIEU
	@MaSuatChieu VARCHAR(15),
	@NgayChieu DATE, 
	@ThoiGianBatDau TIME(7), 
	@ThoiGianKetThuc TIME(7), 
	@MaPhim VARCHAR(10), 
	@MaPhong VARCHAR(9), 
	@DS_THIETBI AS DS_THIETBI READONLY
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			IF NOT EXISTS (SELECT * FROM SUATCHIEU WHERE MaSuatChieu=@MaSuatChieu)
				RAISERROR(N'Không tìm thấy mã suất chiếu', 16, 1)

			UPDATE SUATCHIEU
			SET NgayChieu=ISNULL(@NgayChieu, NgayChieu),
				ThoiGianBatDau=ISNULL(@ThoiGianBatDau, ThoiGianBatDau),
				ThoiGianKetThuc=ISNULL(@ThoiGianKetThuc, ThoiGianKetThuc),
				MaPhim=ISNULL(@MaPhim, MaPhim),
				MaPhong=ISNULL(@MaPhong, MaPhong)
			WHERE MaSuatChieu=@MaSuatChieu

			DELETE CHITIETSUATCHIEU_THIETBI WHERE MaSuatChieu=@MaSuatChieu

			INSERT INTO CHITIETSUATCHIEU_THIETBI(MaSuatChieu, MaThietBi) SELECT @MaSuatChieu, * FROM @DS_THIETBI
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		DECLARE @ErrorMsg NVARCHAR(2000)
		SELECT @ErrorMsg = N'Lỗi' + ERROR_MESSAGE()
		RAISERROR(@ErrorMsg, 16,1)
		ROLLBACK TRAN
	END CATCH
END

GO
-- TRA CUU SUAT CHIEU
ALTER PROC TRACUUSUATCHIEU
	@NgayBatDau DATE, 
	@NgayKetThuc DATE,
	@ThoiGianBatDau TIME(7), 
	@ThoiGianKetThuc TIME(7),
	@MaPhim int,
	@MaPhong int
AS
BEGIN
	BEGIN TRAN
		SELECT *
		FROM SUATCHIEU
		WHERE
			(@NgayBatDau IS NULL OR NgayChieu>=@NgayBatDau) AND
			(@NgayKetThuc IS NULL OR NgayChieu<=@NgayKetThuc) AND
			(@ThoiGianBatDau IS NULL OR ThoiGianBatDau>=@ThoiGianBatDau) AND
			(@ThoiGianKetThuc IS NULL OR ThoiGianKetThuc<=@ThoiGianBatDau) AND
			(@MaPhim IS NULL OR MaPhim=@MaPhim) AND
			(@MaPhong IS NULL OR MaPhong=@MaPhong)
	COMMIT TRAN
END