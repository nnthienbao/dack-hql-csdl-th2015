USE DB_LOTTECINEMA

-----------------------------------
---------------VE------------------
GO
-- HAM TINH GIA VE
ALTER FUNCTION TINHGIAVE(@ChoNgoiDep bit, @MaSuatChieu int)
	RETURNS INT
AS
BEGIN
	DECLARE @GiaVe INT = 0
	-- Gia ve co ban
	DECLARE @GiaVeCoBan INT = CONVERT(INT, (SELECT GiaTri FROM BANGTHAMSO WHERE TenThamSo='GIA_VE_CO_BAN'))
	SET @GiaVe = @GiaVe + @GiaVeCoBan

	-- Them tien neu cho ngoi dep
	IF(@ChoNgoiDep=1)
	BEGIN
		DECLARE @TienPhuThem_ChoNgoiDep int = CONVERT(INT, (SELECT GiaTri FROM BANGTHAMSO WHERE TenThamSo='TIEN_PHU_CHO_NGOI_DEP'))
		SET @GiaVe = @GiaVe + @TienPhuThem_ChoNgoiDep
	END

	-- Tien them do hot phim
	DECLARE @MaPhim int = (SELECT MaPhim FROM SUATCHIEU WHERE id=@MaSuatChieu)
	DECLARE @TienPhuThem_DoHotPhim INT =
		(SELECT DH.TienPhuThem 
		FROM PHIM P
		INNER JOIN DOHOTPHIM DH
		ON P.id=@MaPhim AND P.MaDoHot=DH.id)
	SET @GiaVe = @GiaVe + @TienPhuThem_DoHotPhim

	-- Tien them trang thiet bi
	DECLARE @TienPhuThem_TrangThietBi INT =
		(SELECT SUM(TB.TienPhuThem)
		FROM CHITIETSUATCHIEU_THIETBI CTTB
		INNER JOIN TRANGTHIETBI TB
		ON CTTB.MaSuatChieu=@MaSuatChieu AND CTTB.MaThietBi=TB.id
		GROUP BY CTTB.MaSuatChieu)
	SET @GiaVe = @GiaVe + ISNULL(@TienPhuThem_TrangThietBi, 0)

	RETURN @GiaVe
END

GO
-- TAO VE
ALTER PROC TAOVE
	@MaKhachHang int,
	@TinhTrang int, 
	@TenChoNgoi VARCHAR(10),
	@MaSuatChieu INT,
	@ChoNgoiDep BIT,
	@SDTDatVe VARCHAR(11),
	@NhanVienBanVe VARCHAR(11)
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			IF EXISTS (SELECT * 
						FROM VEXEMPHIM 
						WHERE MaSuatChieu=@MaSuatChieu AND TenChoNgoi=@TenChoNgoi AND (TinhTrang=0 OR TinhTrang=1))
				RAISERROR(N'Vé đã được bán hoặc đặt trước', 16, 1)

			IF(@MaKhachHang IS NULL AND @SDTDatVe IS NULL)
				RAISERROR(N'Không có thông tin khách hàng', 16, 1)

			IF(@MaKhachHang IS NOT NULL)
				IF NOT EXISTS(SELECT * FROM KHACHHANG WHERE id=@MaKhachHang)
					RAISERROR(N'Không tìm thấy khách hàng', 16, 1)

			-- Tinh gia ve
			DECLARE @GiaVe int = 0;
			SET @GiaVe = dbo.TINHGIAVE(@ChoNgoiDep, @MaSuatChieu)

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
-- TRA CUU VE
CREATE PROC TRACUUVE
	@MaKhachHang INT,
	@SDTDatVe VARCHAR(11),
	@NhanVienBanVe VARCHAR(11)
AS
BEGIN
	BEGIN TRAN
		SELECT * 
		FROM VEXEMPHIM 
		WHERE (@MaKhachHang IS NULL OR MaKhachHang=@MaKhachHang) AND
				(@SDTDatVe IS NULL OR SDTDatVe=@SDTDatVe) AND
				(@NhanVienBanVe IS NULL OR NhanVienBanVe=@NhanVienBanVe)
	COMMIT TRAN
END

GO
-- CAP NHAT THONG TIN VE
ALTER PROC CAPNHATVE
	@MaVe VARCHAR(8),
	@MaKhachHang int,
	@TinhTrang int, 
	@TenChoNgoi VARCHAR(10),
	@MaSuatChieu INT,
	@ChoNgoiDep BIT,
	@SDTDatVe VARCHAR(11),
	@NhanVienBanVe VARCHAR(11)
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			IF NOT EXISTS (SELECT * FROM VEXEMPHIM WHERE MaVe=@MaVe)
				RAISERROR(N'Không tìm thấy vé', 16, 1)

			IF(@MaKhachHang IS NOT NULL)
				IF NOT EXISTS(SELECT * FROM KHACHHANG WHERE id=@MaKhachHang)
					RAISERROR(N'Không tìm thấy khách hàng', 16, 1)

			UPDATE VEXEMPHIM
			SET MaKhachHang=ISNULL(@MaKhachHang, MaKhachHang),
				GiaVe=dbo.TINHGIAVE(ISNULL(@ChoNgoiDep, ChoNgoiDep), ISNULL(@MaSuatChieu, MaSuatChieu)),
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

GO
-- LAY DANH SACH VE
CREATE PROC LAYDSVE
AS
BEGIN
	BEGIN TRAN
		SELECT * FROM VEXEMPHIM
	COMMIT TRAN
END