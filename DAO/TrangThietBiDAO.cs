using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TrangThietBiDAO
    {
        public List<TRANGTHIETBI> LayDSTrangThietBi()
        {
            try
            {
                using (var db = new DB_LOTTECINEMAEntities())
                {
                    return db.LAYDSTRANGTHIETBI().ToList();
                }
            } catch
            {
                return null;
            }
        }

        public TRANGTHIETBI LayTrangThietBiTheoMa(string maTrangThietBi)
        {
            try
            {
                using (var db = new DB_LOTTECINEMAEntities())
                {
                    return db.LAYTRANGTHIETBITHEOMA(maTrangThietBi).SingleOrDefault();
                }
            }
            catch
            {
                return null;
            }
        }

        public bool ThemTrangThietBi(string tenThietBi, int tienPhuThem)
        {
            try
            {
                using (var db = new DB_LOTTECINEMAEntities())
                {
                    db.TAOTRANGTHIETBI(tenThietBi, tienPhuThem);
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool CapNhatTrangThietBi(string maThietBi, string tenThietBi, int? tienPhuthem)
        {
            try
            {
                using (var db = new DB_LOTTECINEMAEntities())
                {
                    db.CAPNHATTRANGTHIETBI(maThietBi, tenThietBi, tienPhuthem);
                    return true;
                }
            } catch
            {
                return false;
            }
        }
    }
}
