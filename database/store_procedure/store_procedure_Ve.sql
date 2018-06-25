USE DB_LOTTECINEMA

-----------------------------------
---------------VE------------------
-- TAO VE
ALTER PROC TAOVE
	@MaKhachHang int,
	@TinhTrang NVARCHAR(50), 
	@TenChoNgoi VARCHAR(10),
	@MaSuatChieu INT,
	@ChoNgoiDep BIT,
	@SDTDatVe VARCHAR(11),
	@NhanVienBanVe VARCHAR(11)
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			IF(@MaKhachHang IS NOT NULL)
				IF NOT EXISTS(SELECT * FROM KHACHHANG WHERE id=@MaKhachHang)
					RAISERROR(N'Không tìm thấy khách hàng', 16, 1)
			-- Tinh gia ve
			DECLARE @GiaVe int = 0;
			----Lay gia ve co ban
			DECLARE @GiaVeCoBan int = CONVERT(INT, (SELECT GiaTri FROM BANGTHAMSO WHERE TenThamSo='GIA_VE_CO_BAN'))
			SET @GiaVe = @GiaVe + @GiaVeCoBan
			----Tinh them tien neu cho ngoi dep
			IF(@ChoNgoiDep=1)
				DECLARE @TienPhuThem_ChoNgoiDep int = CONVERT(INT, (SELECT GiaTri FROM BANGTHAMSO WHERE TenThamSo='TIEN_PHU_CHO_NGOI_DEP'))
				SET @GiaVe = @GiaVe + @TienPhuThem_ChoNgoiDep
			----Tinh tien phu them trang thiet bi
			
			----Tinh tien phu them do hot phim

			INSERT INTO VEXEMPHIM(MaKhachHang, GiaVe, TinhTrang, TenChoNgoi, MaSuatChieu, ChoNgoiDep, SDTDatVe, NhanVienBanVe)
				VALUES(@MaKhachHang, @GiaVe, @TinhTrang, @TenChoNgoi, @MaSuatChieu, @ChoNgoiDep, @SDTDatVe, @NhanVienBanVe)
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
-- LAY VE THEO MA VE
ALTER PROC LAYVETHEOMAVE
	@Mave VARCHAR(8)
AS
BEGIN
	BEGIN TRAN
		SELECT * FROM VEXEMPHIM WHERE MaVe=@Mave
	COMMIT TRAN
END

GO
-- LAY VE THEO SDT DAT VE
CREATE PROC LAYVETHEOSDTDATVE
	@SDTDatVe VARCHAR(11)
AS
BEGIN
	BEGIN TRAN
		SELECT * FROM VEXEMPHIM WHERE SDTDatVe=@SDTDatVe
	COMMIT TRAN
END

GO
-- CAP NHAT THONG TIN VE
CREATE PROC CAPNHATVE
	@MaVe VARCHAR(8),
	@MaKhachHang int,
	@TinhTrang NVARCHAR(50), 
	@TenChoNgoi VARCHAR(10),
	@MaSuatChieu INT,
	@ChoNgoiDep BIT,
	@SDTDatVe VARCHAR(11),
	@NhanVienBanVe VARCHAR(11)
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			UPDATE VEXEMPHIM
			SET MaKhachHang=ISNULL(@MaKhachHang, MaKhachHang),
				TinhTrang=ISNULL(@TinhTrang, TinhTrang),
				TenChoNgoi=ISNULL(@TenChoNgoi, TenChoNgoi),
				MaSuatChieu=ISNULL(@MaSuatChieu, MaSuatChieu),
				ChoNgoiDep=ISNULL(@ChoNgoiDep, ChoNgoiDep),
				SDTDatVe=ISNULL(@SDTDatVe, SDTDatVe),
				NhanVienBanVe=ISNULL(@NhanVienBanVe, NhanVienBanVe)
			WHERE MaVe=@MaVe
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		DECLARE @ErrorMsg NVARCHAR(2000)
		SELECT @ErrorMsg = N'Lỗi' + ERROR_MESSAGE()
		RAISERROR(@ErrorMsg, 16,1)
		ROLLBACK TRAN
	END CATCH
END