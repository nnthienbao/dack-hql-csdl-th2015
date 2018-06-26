using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PhimDAO
    {
        public List<PHIM> LayDSPhim()
        {
            try
            {
                using (var db = new DB_LOTTECINEMAEntities())
                {
                    return db.LAYDSPHIM().ToList();
                }
            } catch
            {
                return null;
            }
        }

        public PHIM LayPhimTheoMaPhim(string maPhim)
        {
            try
            {
                using (var db = new DB_LOTTECINEMAEntities())
                {
                    return db.LAYPHIMTHEOMAPHIM(maPhim).SingleOrDefault();
                }
            } catch
            {
                return null;
            }
        }

        public bool ThemPhim(string tenPhim, TINHTRANGPHIM? tinhTrang, int thoiLuong, int maDoHot)
        {
            try
            {
                using (var db = new DB_LOTTECINEMAEntities())
                {
                    db.TAOPHIM(tenPhim, (int?)tinhTrang, thoiLuong, maDoHot);
                    return true;
                }
            } catch
            {
                return false;
            }
        }

        public bool CapNhatPhim(string maPhim, string tenPhim, TINHTRANGPHIM? tinhTrang, int? thoiLuong, int? maDoHot)
        {
            try
            {
                using (var db = new DB_LOTTECINEMAEntities())
                {
                    db.CAPNHATPHIM(maPhim, tenPhim, (int?)tinhTrang, thoiLuong, maDoHot);
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
