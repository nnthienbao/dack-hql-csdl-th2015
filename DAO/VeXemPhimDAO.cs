using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class VeXemPhimDAO
    {
        public List<VEXEMPHIM> LayDSVe()
        {
            try
            {
                using (var db = new DB_LOTTECINEMAEntities())
                {
                    return db.LAYDSVE().ToList();
                }
            } catch
            {
                return null;
            }
        }

        public VEXEMPHIM LayVeTheoMa(string maVe)
        {
            try
            {
                using (var db = new DB_LOTTECINEMAEntities())
                {
                    return db.LAYVETHEOMAVE(maVe).SingleOrDefault();
                }
            }
            catch
            {
                return null;
            }
        }

        public List<VEXEMPHIM> TraCuuVe(int? maKhachHang, string sdtDatVe, string nhanVienBanVe)
        {
            try
            {
                using (var db = new DB_LOTTECINEMAEntities())
                {
                    return db.TRACUUVE(maKhachHang, sdtDatVe, nhanVienBanVe).ToList();
                }
            }
            catch
            {
                return null;
            }
        }

        public bool ThemVe(int? maKhachHang, 
                            TINHTRANGVE tinhTrang, 
                            string tenChoNgoi, 
                            int maSuatChieu, 
                            bool choNgoiDep, 
                            string sdtDatVe, 
                            string maNhanVien)
        {
            try
            {
                using (var db = new DB_LOTTECINEMAEntities())
                {
                    db.TAOVE(maKhachHang,
                            (int)tinhTrang, 
                            tenChoNgoi, 
                            maSuatChieu, 
                            choNgoiDep, 
                            sdtDatVe, 
                            maNhanVien);
                    return true;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return false;
            }
        }

        public bool CapNhatVe(string maVe,
                            int? maKhachHang,
                            TINHTRANGVE tinhTrang,
                            string tenChoNgoi,
                            int? maSuatChieu,
                            bool? choNgoiDep,
                            string sdtDatVe,
                            string maNhanVien)
        {
            try
            {
                using (var db = new DB_LOTTECINEMAEntities())
                {
                    db.CAPNHATVE(maVe, 
                                maKhachHang, 
                                (int?)tinhTrang, 
                                tenChoNgoi, 
                                maSuatChieu, 
                                choNgoiDep, 
                                sdtDatVe, 
                                maNhanVien);
                    return true;
                }
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex);
                return false;
            }
        }

        public int? LayGiaVe(bool choNgoiDep, int maSuatChieu)
        {
            try
            {
                using (var db = new DB_LOTTECINEMAEntities())
                {
                    var pChoNgoiDep = new ObjectParameter("ChoNgoiDep", choNgoiDep);

                    var pMaSuatChieu = new ObjectParameter("MaSuatChieu", maSuatChieu);

                    var gia = ((IObjectContextAdapter)db)
                        .ObjectContext
                        .CreateQuery<int?>("DB_LOTTECINEMAModel.Store.TINHGIAVE(@ChoNgoiDep, @MaSuatChieu)", pChoNgoiDep, pMaSuatChieu)
                        .Execute(MergeOption.NoTracking)
                        .FirstOrDefault();

                    return gia;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return null;
            }
        }
    }
}
