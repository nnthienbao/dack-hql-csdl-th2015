using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ThamSoDAO
    {
        public bool CapNhatGiaVeCoBan(int giaVeMoi)
        {
            try
            {
                using (var db = new DB_LOTTECINEMAEntities())
                {
                    db.CAPNHATGIAVECOBAN(giaVeMoi);
                    return true;
                }
            } catch
            {
                return false;
            }
        }

        public bool CapNhatPhuThuChoNgoiDep(int phuThuMoi)
        {
            try
            {
                using (var db = new DB_LOTTECINEMAEntities())
                {
                    db.CAPNHATPHUTHUCHONGOIDEP(phuThuMoi);
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public int? LayGiaVeCoBan()
        {
            try
            {
                using (var db = new DB_LOTTECINEMAEntities())
                {
                    return ((IObjectContextAdapter)db).ObjectContext
                        .CreateQuery<int?>("DB_LOTTECINEMAModel.Store.LAYGIAVECOBAN()")
                        .Execute(System.Data.Entity.Core.Objects.MergeOption.NoTracking)
                        .FirstOrDefault();
                }
            } catch
            {
                return null;
            }
        }

        public int? LayTienPhuThemChoNgoiDep()
        {
            try
            {
                using (var db = new DB_LOTTECINEMAEntities())
                {
                    return ((IObjectContextAdapter)db).ObjectContext
                        .CreateQuery<int?>("DB_LOTTECINEMAModel.Store.LAYTIENPHUTHEM_CHONGOIDEP()")
                        .Execute(System.Data.Entity.Core.Objects.MergeOption.NoTracking)
                        .FirstOrDefault();
                }
            } catch
            {
                return null;
            }
        }
    }
}
