using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class NhanVienDAO
    {
        public NHANVIEN LayNhanVienTheoMa(string maNV)
        {
            try
            {
                using (var db = new DB_LOTTECINEMAEntities())
                {
                    return db.LAYNHANVIEN(maNV).SingleOrDefault();
                }
            }
            catch(Exception ex)
            {
                return null;
            }
        }
    }
}
