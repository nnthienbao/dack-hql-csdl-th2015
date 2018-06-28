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
	MaThietBi int
)
drop type DS_THIETBI

GO
-- TAO SUAT CHIEU PHIM
ALTER PROC TAOSUATCHIEU
	@NgayChieu DATE,
	@ThoiGianBatDau TIME(7), 
	@ThoiGianKetThuc TIME(7), 
	@MaPhim int, 
	@MaPhong int, 
	@DS_THIETBI AS DS_THIETBI READONLY
AS
BEGIN
	BEGIN TRY
		SET XACT_ABORT ON
		BEGIN TRAN
			INSERT INTO SUATCHIEU(NgayChieu, ThoiGianBatDau, ThoiGianKetThuc, MaPhim, MaPhong)
			 VALUES(@NgayChieu, @ThoiGianBatDau, @ThoiGianKetThuc, @MaPhim, @MaPhong)
			
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
ALTER PROC CAPNHATSUATCHIEU
	@MaSuatChieu VARCHAR(15),
	@NgayChieu DATE, 
	@ThoiGianBatDau TIME(7), 
	@ThoiGianKetThuc TIME(7), 
	@MaPhim int, 
	@MaPhong int, 
	@DS_THIETBI AS DS_THIETBI READONLY
AS
BEGIN
	BEGIN TRY
		SET XACT_ABORT ON
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

			DECLARE @IdSuatChieu int = (SELECT id FROM SUATCHIEU WHERE MaSuatChieu=@MaSuatChieu);

			DELETE CHITIETSUATCHIEU_THIETBI WHERE MaSuatChieu=@IdSuatChieu

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
-- TRA CUU SUAT CHIEU
ALTER PROC TRACUUSUATCHIEU
	@NgayBatDau DATE, 
	@NgayKetThuc DATE,
	@ThoiGianBatDau TIME(7), 
	@ThoiGianKetThuc TIME(7),
	@MaPhim int,
	@MaPhong int,
	@DS_ThietBi AS DS_THIETBI READONLY
AS
BEGIN
	BEGIN TRAN
		SELECT *
		FROM SUATCHIEU SC
		WHERE
			(@NgayBatDau IS NULL OR SC.NgayChieu>=@NgayBatDau) AND
			(@NgayKetThuc IS NULL OR SC.NgayChieu<=@NgayKetThuc) AND
			(@ThoiGianBatDau IS NULL OR SC.ThoiGianBatDau>=@ThoiGianBatDau) AND
			(@ThoiGianKetThuc IS NULL OR SC.ThoiGianKetThuc<=@ThoiGianBatDau) AND
			(@MaPhim IS NULL OR SC.MaPhim=@MaPhim) AND
			(@MaPhong IS NULL OR SC.MaPhong=@MaPhong) AND
			NOT EXISTS(
				(SELECT MaThietBi FROM @DS_ThietBi)
				EXCEPT
				(SELECT MaThietBi FROM CHITIETSUATCHIEU_THIETBI CTTB
				WHERE CTTB.MaSuatChieu=SC.id))
			AND 
			NOT EXISTS(
				(SELECT MaThietBi FROM CHITIETSUATCHIEU_THIETBI CTTB
					WHERE CTTB.MaSuatChieu=SC.id)
				EXCEPT
				(SELECT MaThietBi FROM @DS_ThietBi))
	COMMIT TRAN
END