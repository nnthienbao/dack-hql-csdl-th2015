using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DoHotPhimDAO
    {
        public List<DOHOTPHIM> LayDSDoHotPhim()
        {
            try
            {
                using (var db = new DB_LOTTECINEMAEntities())
                {
                    return db.LAYDSDOHOTPHIM().ToList();
                }
            } catch
            {
                return null;
            }
        }

        public DOHOTPHIM LayDoHotPhimTheoMa(String maDoHot)
        {
            try
            {
                using (var db = new DB_LOTTECINEMAEntities())
                {
                    return db.LAYDOHOTPHIMTHEOMA(maDoHot).SingleOrDefault();
                }
            } catch
            {
                return null;
            }
        }

        public bool TaoDoHotPhim(string tenDoHot, int tienPhuThem)
        {
            try
            {
                using (var db = new DB_LOTTECINEMAEntities())
                {
                    db.TAODOHOTPHIM(tenDoHot, tienPhuThem);
                    return true;
                }
            } catch
            {
                return false;
            }
        }

        public bool CapNhatDoHotPhim(string maDoHot, string tenDoHot, int? tienPhuThem)
        {
            try
            {
                using (var db = new DB_LOTTECINEMAEntities())
                {
                    db.CAPNHATDOHOTPHIM(maDoHot, tenDoHot, tienPhuThem);
                    return true;
                }
            } catch
            {
                return false;
            }
        }
    }
}
