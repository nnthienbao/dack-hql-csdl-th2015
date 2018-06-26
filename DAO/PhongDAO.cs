using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PhongDAO
    {
        public List<PHONG> LayDSPhong()
        {
            try
            {
                using (var db = new DB_LOTTECINEMAEntities())
                {
                    return db.LAYDANHSACHPHONG().ToList();
                }
            } catch
            {
                return null;
            }
        }

        public PHONG LayPhongTheoMa(string maPhong)
        {
            try
            {
                using (var db = new DB_LOTTECINEMAEntities())
                {
                    return db.LAYPHONGTHEOMA(maPhong).SingleOrDefault();
                }
            }
            catch
            {
                return null;
            }
        }

        public bool ThemPhong(string tenPhong)
        {
            try
            {
                using (var db = new DB_LOTTECINEMAEntities())
                {
                    db.TAOPHONG(tenPhong);
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool CapNhatPhong(string maPhong, string tenPhong)
        {
            try
            {
                using (var db = new DB_LOTTECINEMAEntities())
                {
                    db.CAPNHATPHONG(maPhong, tenPhong);
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
