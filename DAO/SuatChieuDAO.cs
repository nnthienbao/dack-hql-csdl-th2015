using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class SuatChieuDAO
    {
        public List<SUATCHIEU> LayDSSuatChieu()
        {
            try
            {
                using (var db = new DB_LOTTECINEMAEntities())
                {
                    return db.LAYDSSUATCHIEU().ToList();
                }
            } catch
            {
                return null;
            }
        }

        public SUATCHIEU LaySuatChieuTheoMa(string maSuatChieu)
        {
            try
            {
                using (var db = new DB_LOTTECINEMAEntities())
                {
                    return db.LAYSUATCHIEUTHEOMA(maSuatChieu).SingleOrDefault();
                }
            }
            catch
            {
                return null;
            }
        }

        public bool TaoSuatChieu(DateTime ngayChieu,
                                TimeSpan thoiGianBatDau, 
                                TimeSpan thoiGianKetThuc, 
                                int maPhim, 
                                int maPhong,
                                List<CT_THIETBI> dsThietBi)
        {
            try
            {
                using (var db = new DB_LOTTECINEMAEntities())
                {
                    var dt = new DataTable();
                    dt.Columns.Add("MaThietBi");
                    foreach(var thietBi in dsThietBi)
                    {
                        dt.Rows.Add(thietBi.MaThietBi);
                    }
                    var pNgayChieu = new SqlParameter("NgayChieu", SqlDbType.DateTime);
                    pNgayChieu.Value = ngayChieu;

                    var pthoiGianBD = new SqlParameter("ThoiGianBatDau", SqlDbType.Time);
                    pthoiGianBD.Value = thoiGianBatDau;

                    var pthoiGianKT = new SqlParameter("ThoiGianKetThuc", SqlDbType.Time);
                    pthoiGianKT.Value = thoiGianKetThuc;

                    var pMaPhim = new SqlParameter("MaPhim", SqlDbType.Int);
                    pMaPhim.Value = maPhim;

                    var pMaPhong = new SqlParameter("MaPhong", SqlDbType.Int);
                    pMaPhong.Value = maPhong;

                    var pDSThietBi = new SqlParameter("DS_THIETBI", SqlDbType.Structured);
                    pDSThietBi.Value = dt;
                    pDSThietBi.TypeName = "dbo.DS_THIETBI";

                    db.Database.ExecuteSqlCommand("EXEC " + "TAOSUATCHIEU" +
                            " @NgayChieu, @ThoiGianBatDau, @ThoiGianKetThuc, @MaPhim, @MaPhong, @DS_THIETBI",
                        pNgayChieu, pthoiGianBD, pthoiGianKT, pMaPhim, pMaPhong, pDSThietBi);
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool CapNhatSuatChieu(string maSuatChieu,
                                DateTime? ngayChieu,
                                TimeSpan? thoiGianBatDau,
                                TimeSpan? thoiGianKetThuc,
                                int? maPhim,
                                int? maPhong,
                                List<CT_THIETBI> dsThietBi)
        {
            try
            {
                using (var db = new DB_LOTTECINEMAEntities())
                {
                    var pMaSuatChieu = new SqlParameter("MaSuatChieu", SqlDbType.VarChar);
                    pMaSuatChieu.Value = (Object)maSuatChieu ?? DBNull.Value;

                    var pNgayChieu = new SqlParameter("NgayChieu", SqlDbType.DateTime);
                    pNgayChieu.Value = (Object)ngayChieu ?? DBNull.Value;

                    var pthoiGianBD = new SqlParameter("ThoiGianBatDau", SqlDbType.Time);
                    pthoiGianBD.Value = (Object)thoiGianBatDau ?? DBNull.Value;

                    var pthoiGianKT = new SqlParameter("ThoiGianKetThuc", SqlDbType.Time);
                    pthoiGianKT.Value = (Object)thoiGianKetThuc ?? DBNull.Value;

                    var pMaPhim = new SqlParameter("MaPhim", SqlDbType.Int);
                    pMaPhim.Value = (Object)maPhim ?? DBNull.Value;

                    var pMaPhong = new SqlParameter("MaPhong", SqlDbType.Int);
                    pMaPhong.Value = (Object)maPhong ?? DBNull.Value;

                    var pDSThietBi = new SqlParameter("DS_THIETBI", SqlDbType.Structured);
                    if(dsThietBi != null)
                    {
                        var dt = new DataTable();
                        dt.Columns.Add("MaThietBi");
                        foreach (var thietBi in dsThietBi)
                        {
                            dt.Rows.Add(thietBi.MaThietBi);
                        }
                        pDSThietBi.Value = dt;
                    } else
                    {
                        pDSThietBi.Value = DBNull.Value;
                    }
                    pDSThietBi.TypeName = "dbo.DS_THIETBI";

                    db.Database.ExecuteSqlCommand("EXEC " + "CAPNHATSUATCHIEU" +
                            " @MaSuatChieu, @NgayChieu, @ThoiGianBatDau, @ThoiGianKetThuc, @MaPhim, @MaPhong, @DS_THIETBI",
                        pMaSuatChieu ,pNgayChieu, pthoiGianBD, pthoiGianKT, pMaPhim, pMaPhong, pDSThietBi);
                    return true;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                return false;
            }
        }

        public List<SUATCHIEU> TraCuuSuatChieu(
                                                DateTime? ngayBatDau,
                                                DateTime? ngayKetThuc,
                                                TimeSpan? thoiGianBatDau,
                                                TimeSpan? thoiGianKetThuc,
                                                int? maPhim,
                                                int? maPhong
                                                )
        {
            try
            {
                using (var db = new DB_LOTTECINEMAEntities())
                {
                    return db
                        .TRACUUSUATCHIEU(ngayBatDau, 
                                        ngayKetThuc, 
                                        thoiGianBatDau, 
                                        thoiGianKetThuc, 
                                        maPhim, maPhong)
                        .ToList();
                }
            }
            catch
            {
                return null;
            }
        }
    }
}
