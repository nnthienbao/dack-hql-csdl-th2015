using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class PhongBUS
    {
        private PhongDAO phongDAO = new PhongDAO();

        public PHONG LayPhongTheoMa(string maPhong)
        {
            return phongDAO.LayPhongTheoMa(maPhong);
        }

        public PHONG LayPhongTheoId(int idPhong)
        {
            return phongDAO.LayPhongTheoId(idPhong);
        }
    }
}
