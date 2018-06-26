using System;
using System.Collections.Generic;
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

        public bool TaoSuatChieu()
        {
            try
            {
                using (var db = new DB_LOTTECINEMAEntities())
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool CapNhatSuatChieu()
        {
            try
            {
                using (var db = new DB_LOTTECINEMAEntities())
                {
                    return false;
                }
            }
            catch
            {
                return true;
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
